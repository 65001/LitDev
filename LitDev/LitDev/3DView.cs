﻿//The following Copyright applies to the LitDev Extension for Small Basic and files in the namespace LitDev.
//Copyright (C) <2011 - 2015> litdev@hotmail.co.uk
//This file is part of the LitDev Extension for Small Basic.

//LitDev Extension is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//LitDev Extension is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with LitDev Extension.  If not, see <http://www.gnu.org/licenses/>.

using HelixToolkit.Wpf;
using Microsoft.SmallBasic.Library;
using Microsoft.SmallBasic.Library.Internal;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;

namespace LitDev
{
    /// <summary>
    /// 3D Visualisation in the GraphicsWindow.
    /// 
    /// Coordinates have the following directions and have no correspondence to the GraphicsWindow coordinates.
    /// X - Left(-) to Right(+)
    /// Y - Down(-) to Up(+)
    /// Z - Far(-) to Near(+)
    /// 
    /// For more details on the underlying methods see http://msdn.microsoft.com/en-us/library/ms747437%28v=vs.90%29.aspx
    /// The following methods use HelixToolkit (recompiled and slightly modified for SmallBasic) http://helixToolkit.codeplex.com
    /// LoadModel, AddSphere, AddTube
    /// </summary>
    [SmallBasicType]
    public static class LD3DView
    {
        private static int iLight = 0;
        private class Lighting
        {
            public string name;
            public Light light;
            public Lighting(string _name, Light _light)
            {
                name = _name;
                light = _light;
            }
        }
        private static List<Lighting> Lightings = new List<Lighting>();
        private static Lighting getLighting(string name)
        {
            return Lightings.Find(item => item.name == name);
        }
        private static string getLightingName()
        {
            return "Light" + (++iLight).ToString();
        }

        private static int iGeometry = 0;
        private class Geometry
        {
            public string name;
            public GeometryModel3D geometryModel3D;
            public Geometry(string _name, GeometryModel3D _geometryModel3D)
            {
                name = _name;
                geometryModel3D = _geometryModel3D;
            }
        }
        private static List<Geometry> Geometries = new List<Geometry>();
        private static Geometry getGeometry(string name)
        {
            return Geometries.Find(item => item.name == name);
        }
        private static string getGeometryName()
        {
            return "Geometry" + (++iGeometry).ToString();
        }

        public static Object lockObj = new Object(); //public static to keep the queue thread safe

        private static string lastRotation = "";
        private static Queue<string> queueRotation = new Queue<string>();
        private static SmallBasicCallback _RotationCompletedDelegate = null;
        private static void _RotationCompletedEvent(Geometry geom)
        {
            queueRotation.Enqueue(geom.name);
            if (null != _RotationCompletedDelegate) _RotationCompletedDelegate();
        }

        private static string lastTranslation = "";
        private static Queue<string> queueTranslation = new Queue<string>();
        private static SmallBasicCallback _TranslationCompletedDelegate = null;
        private static void _TranslationCompletedEvent(Geometry geom)
        {
            queueTranslation.Enqueue(geom.name);
            if (null != _TranslationCompletedDelegate) _TranslationCompletedDelegate();
        }

        private enum transform
        {
            Rotate,
            Rotate2,
            Scale,
            Translate
        }

        private static string[] stringSeparators = new string[] { " ", ":" };

        private static RayHitTestResult rayResult = null;
        private static HitTestResultBehavior ResultCallback(HitTestResult result)
        {
            rayResult = result as RayHitTestResult;
            return HitTestResultBehavior.Stop; // Nearest
        }

        private static void AddTransforms(GeometryModel3D geometry)
        {
            double X = geometry.Bounds.X + geometry.Bounds.SizeX / 2.0;
            double Y = geometry.Bounds.Y + geometry.Bounds.SizeY / 2.0;
            double Z = geometry.Bounds.Z + geometry.Bounds.SizeZ / 2.0;

            RotateTransform3D rotateTransform3D = new RotateTransform3D();
            AxisAngleRotation3D axisAngleRotation3D = new AxisAngleRotation3D();
            axisAngleRotation3D.Axis = new Vector3D(0, 1, 0);
            axisAngleRotation3D.Angle = 0;
            rotateTransform3D.Rotation = axisAngleRotation3D;
            rotateTransform3D.CenterX = X;
            rotateTransform3D.CenterY = Y;
            rotateTransform3D.CenterZ = Z;

            RotateTransform3D rotateTransform3D2 = new RotateTransform3D();
            AxisAngleRotation3D axisAngleRotation3D2 = new AxisAngleRotation3D();
            axisAngleRotation3D2.Axis = new Vector3D(0, 1, 0);
            axisAngleRotation3D2.Angle = 0;
            rotateTransform3D2.Rotation = axisAngleRotation3D2;
            rotateTransform3D2.CenterX = X;
            rotateTransform3D2.CenterY = Y;
            rotateTransform3D2.CenterZ = Z;

            ScaleTransform3D scaleTransform3D = new ScaleTransform3D();
            scaleTransform3D.CenterX = X;
            scaleTransform3D.CenterY = Y;
            scaleTransform3D.CenterZ = Z;
            scaleTransform3D.ScaleX = 1;
            scaleTransform3D.ScaleY = 1;
            scaleTransform3D.ScaleZ = 1;

            TranslateTransform3D translateTransform3D = new TranslateTransform3D();
            translateTransform3D.OffsetX = 0;
            translateTransform3D.OffsetY = 0;
            translateTransform3D.OffsetZ = 0;

            Transform3DGroup transform3DGroup = new Transform3DGroup();
            transform3DGroup.Children.Add(rotateTransform3D);
            transform3DGroup.Children.Add(rotateTransform3D2);
            transform3DGroup.Children.Add(scaleTransform3D);
            transform3DGroup.Children.Add(translateTransform3D);
            geometry.Transform = transform3DGroup;
        }

        private static string AddGeometry(Viewport3D viewport3D, Point3DCollection pointCollection, Int32Collection indexCollection, Vector3DCollection normalCollection, PointCollection textureCollection, string colour, string materialType)
        {
            try
            {
                ModelVisual3D modelVisual3D = (ModelVisual3D)viewport3D.Children[0];
                Model3DGroup model3DGroup = (Model3DGroup)modelVisual3D.Content;

                GeometryModel3D geometry = new GeometryModel3D();
                MeshGeometry3D mesh = new MeshGeometry3D();

                mesh.Positions = pointCollection;
                mesh.TriangleIndices = indexCollection;
                if (normalCollection.Count == pointCollection.Count) mesh.Normals = normalCollection;
                if (textureCollection.Count == pointCollection.Count) mesh.TextureCoordinates = textureCollection;

                // Apply the mesh to the geometry model.
                geometry.Geometry = mesh;

                AddTransforms(geometry);

                MaterialGroup material = new MaterialGroup();
                Brush brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colour));
                switch (materialType.ToString().ToLower())
                {
                    case "e":
                        material.Children.Add(new DiffuseMaterial(brush));
                        material.Children.Add(new EmissiveMaterial(brush));
                        break;
                    case "d":
                        material.Children.Add(new DiffuseMaterial(brush));
                        break;
                    case "s":
                        material.Children.Add(new SpecularMaterial(brush, 2));
                        break;
                }
                geometry.Material = material;

                string name = getGeometryName();
                Geometries.Add(new Geometry(name, geometry));
                model3DGroup.Children.Add(geometry);
                return name;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Add a 3DView (GraphicsWindow shape).
        /// </summary>
        /// <param name="width">The width of the 3DView.</param>
        /// <param name="height">The height of the 3DView.</param>
        /// <param name="performance">A flag to favour speed over quality "True" or "False".
        /// "True" removes visual clipping (clip 3DView to input width and height), hit-testing (unused) and anti-aliasing (not needed).</param>
        /// <returns>The 3DView viewport3D name.</returns>
        public static Primitive AddView(Primitive width, Primitive height, Primitive performance)
        {
            GraphicsWindow.Show();
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ShapesType = typeof(Shapes);
            Canvas _mainCanvas;
            Dictionary<string, UIElement> _objectsMap;
            string shapeName;

            try
            {
                MethodInfo method = GraphicsWindowType.GetMethod("VerifyAccess", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                method.Invoke(null, new object[] { });

                method = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                shapeName = method.Invoke(null, new object[] { "View3D" }).ToString();

                _mainCanvas = (Canvas)GraphicsWindowType.GetField("_mainCanvas", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        Viewport3D viewport3D = new Viewport3D();
                        //viewport3D.Cursor = Cursors.Cross;
                        viewport3D.Name = shapeName;
                        viewport3D.Width = width;
                        viewport3D.Height = height;
                        if (performance)
                        {
                            viewport3D.IsHitTestVisible = false;
                            viewport3D.ClipToBounds = false;
                            RenderOptions.SetEdgeMode((DependencyObject)viewport3D, EdgeMode.Aliased);
                        }

                        PerspectiveCamera camera = new PerspectiveCamera();
                        camera.Position = new Point3D(0, 0, 0);
                        camera.LookDirection = new Vector3D(0, 0, -1);
                        camera.FieldOfView = 60;
                        viewport3D.Camera = camera;

                        ModelVisual3D modelVisual3D = new ModelVisual3D();
                        viewport3D.Children.Add(modelVisual3D);

                        Model3DGroup model3DGroup = new Model3DGroup();
                        modelVisual3D.Content = model3DGroup;

                        _objectsMap[shapeName] = viewport3D;
                        _mainCanvas.Children.Add(viewport3D);
                        return shapeName;
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                    }
                    return "";
                });
                method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                return method.Invoke(null, new object[] { ret }).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Add a geometry object.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="points">A space or colon deliminated list of point coordinates.</param>
        /// <param name="indices">A space or colon deliminated list of indices for each triangle (counter-clockwise for outward face).</param>
        /// <param name="normals">An optional space or colon deliminated list of the outward normals for each node or "".</param>
        /// <param name="colour">A colour for the object.</param>
        /// <param name="materialType">A material for the object.
        /// The available options are:
        /// "E" Emmissive - constant brightness.
        /// "D" Diffusive - affected by lights.</param>
        /// <returns>The 3DView Geometry name.</returns>
        public static Primitive AddGeometry(Primitive shapeName, Primitive points, Primitive indices, Primitive normals, Primitive colour, Primitive materialType)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                string[] s;
                                int i;

                                // Create a collection of vertex positions for the MeshGeometry3D. 
                                Point3DCollection pointCollection = new Point3DCollection();
                                s = Utilities.getString(points).Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
                                for (i = 0; i < s.Length; i += 3)
                                {
                                    pointCollection.Add(new Point3D(Utilities.getDouble(s[i]), Utilities.getDouble(s[i + 1]), Utilities.getDouble(s[i + 2])));
                                }

                                // Create a collection of triangle indices for the MeshGeometry3D.
                                Int32Collection indexCollection = new Int32Collection();
                                s = Utilities.getString(indices).Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
                                for (i = 0; i < s.Length; i++)
                                {
                                    indexCollection.Add(Utilities.getInt(s[i]));
                                }

                                // Create a collection of normal vectors for the MeshGeometry3D.
                                Vector3DCollection normalCollection = new Vector3DCollection();
                                s = Utilities.getString(normals).Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
                                for (i = 0; i < s.Length; i += 3)
                                {
                                    normalCollection.Add(new Vector3D(Utilities.getDouble(s[i]), Utilities.getDouble(s[i + 1]), Utilities.getDouble(s[i + 2])));
                                }

                                // Create a collection of texture coordinates for the MeshGeometry3D.
                                PointCollection textureCollection = new PointCollection();
                                //s = Utilities.getString(textures).Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
                                //for (i = 0; i < s.Length; i += 2)
                                //{
                                //    textureCollection.Add(new Point(Utilities.getDouble(s[i]), Utilities.getDouble(s[i + 1])));
                                //}

                                Viewport3D viewport3D = (Viewport3D)obj;
                                return AddGeometry(viewport3D, pointCollection, indexCollection, normalCollection, textureCollection, colour, materialType);
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return "";
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    return method.Invoke(null, new object[] { ret }).ToString();
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Add an image to a geometry object.
        /// A geometry 'skin' may contain several segment images in one inage.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="geometryName">The geometry object.</param>
        /// <param name="textures">A space or colon deliminated list of the texture coordinates for each node.
        /// Each node has 2 values between 0 and 1 indicating the x,y image mapping to the node.
        /// The may be defaulted to "" if the texture has previously been set.</param>
        /// <param name="imageName">
        /// The image to load to the geometry.
        /// Value returned from ImageList.LoadImage or local or network image file.
        /// </param>
        /// <param name="materialType">A material for the object.
        /// The available options are:
        /// "E" Emmissive - constant brightness.
        /// "D" Diffusive - affected by lights.
        /// "S" Specular - additional specular highlights.</param>
        public static void AddImage(Primitive shapeName, Primitive geometryName, Primitive textures, Primitive imageName, Primitive materialType)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;
            Type ImageListType = typeof(ImageList);
            Dictionary<string, BitmapSource> _savedImages;
            BitmapSource img;

            try
            {
                _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_savedImages.TryGetValue((string)imageName, out img))
                {
                    imageName = ImageList.LoadImage(imageName);
                    if (!_savedImages.TryGetValue((string)imageName, out img))
                    {
                        return;
                    }
                }

                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Geometry geom = getGeometry(geometryName);
                                if (null == geom) return;
                                GeometryModel3D geometry = geom.geometryModel3D;
                                MeshGeometry3D mesh = (MeshGeometry3D)geometry.Geometry;
                                MaterialGroup material = (MaterialGroup)geometry.Material;

                                string[] s;
                                int i;

                                // Create a collection of texture coordinates for the MeshGeometry3D.
                                PointCollection textureCollection = new PointCollection();
                                s = Utilities.getString(textures).Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
                                for (i = 0; i < s.Length; i += 2)
                                {
                                    textureCollection.Add(new Point(Utilities.getDouble(s[i]), Utilities.getDouble(s[i + 1])));
                                }
                                if (textureCollection.Count == mesh.Positions.Count) mesh.TextureCoordinates = textureCollection;

                                Brush brush = new ImageBrush(img);
                                switch (materialType.ToString().ToLower())
                                {
                                    case "e":
                                        material.Children.Add(new EmissiveMaterial(brush));
                                        break;
                                    case "d":
                                        material.Children.Add(new DiffuseMaterial(brush));
                                        break;
                                    case "s":
                                        material.Children.Add(new SpecularMaterial(brush, 2));
                                        break;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return;
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Move the camera view direction and position.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="yaw">The Left/Right rotation in degrees (Yaw).</param>
        /// <param name="pitch">The Up/Down rotation in degrees (Pitch).</param>
        /// <param name="roll">Spin view about view direction in degrees (Roll).</param>
        /// <param name="move">The Forward/Backward movement in device coordinates (along the view direction).</param>
        public static void MoveCamera(Primitive shapeName, Primitive yaw, Primitive pitch, Primitive roll, Primitive move)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Viewport3D viewport3D = (Viewport3D)obj;
                                PerspectiveCamera camera = (PerspectiveCamera)viewport3D.Camera;
                                Vector3D lookDirection = camera.LookDirection;
                                Vector3D upDirection = camera.UpDirection;
                                Point3D position = camera.Position;

                                Vector3D rotateAbout1 = upDirection;
                                Vector3D rotateAbout2 = Vector3D.CrossProduct(rotateAbout1, lookDirection);

                                Matrix3D rotateMatrix = Matrix3D.Identity;
                                Quaternion quaterion = new Quaternion(upDirection, -yaw);
                                rotateMatrix.Rotate(quaterion);
                                quaterion = new Quaternion(rotateAbout2, -pitch);
                                rotateMatrix.Rotate(quaterion);
                                lookDirection = rotateMatrix.Transform(lookDirection);
                                lookDirection.Normalize();
                                position += move * lookDirection;

                                //Also rotate up direction
                                rotateMatrix = Matrix3D.Identity;
                                quaterion = new Quaternion(rotateAbout2, -pitch);
                                rotateMatrix.Rotate(quaterion);
                                quaterion = new Quaternion(lookDirection, roll);
                                rotateMatrix.Rotate(quaterion);
                                upDirection = rotateMatrix.Transform(upDirection);
  
                                camera.LookDirection = lookDirection;
                                camera.UpDirection = upDirection;
                                camera.Position = position;
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Reset the camera position, view direction and up vector (optional).
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="xPos">The x position of the camera.</param>
        /// <param name="yPos">The y position of the camera.</param>
        /// <param name="zPos">The z position of the camera.</param>
        /// <param name="xDir">The x direction of the camera.</param>
        /// <param name="yDir">The y direction of the camera.</param>
        /// <param name="zDir">The z direction of the camera.</param>
        /// <param name="xUp">The optional x up direction of the camera or "".</param>
        /// <param name="yUp">The optional y up direction of the camera or "".</param>
        /// <param name="zUp">The optional z up direction of the camera or "".</param>
        public static void ResetCamera(Primitive shapeName, Primitive xPos, Primitive yPos, Primitive zPos, Primitive xDir, Primitive yDir, Primitive zDir, Primitive xUp, Primitive yUp, Primitive zUp)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Viewport3D viewport3D = (Viewport3D)obj;
                                PerspectiveCamera camera = (PerspectiveCamera)viewport3D.Camera;

                                camera.LookDirection = new Vector3D(xDir, yDir, zDir);
                                camera.Position = new Point3D(xPos, yPos, zPos);
                                if (xUp == "" || yUp == "" || zUp == "")
                                {
                                    camera.UpDirection = (xDir == 0 && zDir == 0) ? new Vector3D(0, 0, -1) : new Vector3D(0, 1, 0);
                                    Vector3D rotateAbout = Vector3D.CrossProduct(camera.LookDirection, camera.UpDirection);
                                    camera.UpDirection = Vector3D.CrossProduct(rotateAbout, camera.LookDirection);
                                }
                                else
                                {
                                    camera.UpDirection = new Vector3D(xUp, yUp, zUp);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Set the angle of view, near and far clipping distances.
        /// These are all of the fundamental perspective camera properties.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="nearDistance">The near clipping distance (can improve near object e.g. wall hit detection).
        /// A negative value is 0.001 (default is 0.125).</param>
        /// <param name="farDistance">The far clipping distance (can improve performance).
        /// A negative value is infinity (default).</param>
        /// <param name="angle">The view angle cone of the camera in degrees (affects perspective vanishing point).</param>
        public static void CameraProperties(Primitive shapeName, Primitive nearDistance, Primitive farDistance, Primitive angle)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Viewport3D viewport3D = (Viewport3D)obj;
                                PerspectiveCamera camera = (PerspectiveCamera)viewport3D.Camera;

                                camera.NearPlaneDistance = System.Math.Max(1.0e-3, nearDistance);
                                camera.FarPlaneDistance = (farDistance < camera.NearPlaneDistance) ? double.PositiveInfinity : (double)farDistance;
                                camera.FieldOfView = angle;
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Get the camera position.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <returns>An array of the camera position coordinates.</returns>
        public static Primitive GetCameraPosition(Primitive shapeName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Viewport3D viewport3D = (Viewport3D)obj;
                                PerspectiveCamera camera = (PerspectiveCamera)viewport3D.Camera;

                                string position = "1=" + Utilities.ArrayParse(camera.Position.X.ToString(CultureInfo.InvariantCulture)) + ";" + "2=" + Utilities.ArrayParse(camera.Position.Y.ToString(CultureInfo.InvariantCulture)) + ";" + "3=" + Utilities.ArrayParse(camera.Position.Z.ToString(CultureInfo.InvariantCulture)) + ";";
                                return position;
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return "";
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    return Utilities.CreateArrayMap(method.Invoke(null, new object[] { ret }).ToString());
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Get the camera direction.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <returns>An array of the camera direction vector.</returns>
        public static Primitive GetCameraDirection(Primitive shapeName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Viewport3D viewport3D = (Viewport3D)obj;
                                PerspectiveCamera camera = (PerspectiveCamera)viewport3D.Camera;

                                string direction = "1=" + Utilities.ArrayParse(camera.LookDirection.X.ToString(CultureInfo.InvariantCulture)) + ";" + "2=" + Utilities.ArrayParse(camera.LookDirection.Y.ToString(CultureInfo.InvariantCulture)) + ";" + "3=" + Utilities.ArrayParse(camera.LookDirection.Z.ToString(CultureInfo.InvariantCulture)) + ";";
                                return direction;
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return "";
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    return Utilities.CreateArrayMap(method.Invoke(null, new object[] { ret }).ToString());
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Add a directional light source.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="colour">The light colour.</param>
        /// <param name="x">The x direction of the light.</param>
        /// <param name="y">The y direction of the light.</param>
        /// <param name="z">The z direction of the light.</param>
        /// <returns>The 3DView Light name.</returns>
        public static Primitive AddDirectionalLight(Primitive shapeName, Primitive colour, Primitive x, Primitive y, Primitive z)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Viewport3D viewport3D = (Viewport3D)obj;
                                ModelVisual3D modelVisual3D = (ModelVisual3D)viewport3D.Children[0];
                                Model3DGroup model3DGroup = (Model3DGroup)modelVisual3D.Content;

                                DirectionalLight directionalLight = new DirectionalLight();
                                directionalLight.Color = (Color)ColorConverter.ConvertFromString(colour);
                                directionalLight.Direction = new Vector3D(x, y, z);

                                string name = getLightingName();
                                Lightings.Add(new Lighting(name, directionalLight));
                                model3DGroup.Children.Add(directionalLight);
                                return name;
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return "";
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    return method.Invoke(null, new object[] { ret }).ToString();
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Add an ambient light source.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="colour">The light colour.</param>
        /// <returns>The 3DView Light name.</returns>
        public static Primitive AddAmbientLight(Primitive shapeName, Primitive colour)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Viewport3D viewport3D = (Viewport3D)obj;
                                ModelVisual3D modelVisual3D = (ModelVisual3D)viewport3D.Children[0];
                                Model3DGroup model3DGroup = (Model3DGroup)modelVisual3D.Content;

                                AmbientLight ambientLight = new AmbientLight();
                                ambientLight.Color = (Color)ColorConverter.ConvertFromString(colour);

                                string name = getLightingName();
                                Lightings.Add(new Lighting(name, ambientLight));
                                model3DGroup.Children.Add(ambientLight);
                                return name;
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return "";
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    return method.Invoke(null, new object[] { ret }).ToString();
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Add a directional spot light source.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="colour">The light colour.</param>
        /// <param name="xPos">The x position of the light.</param>
        /// <param name="yPos">The y position of the light.</param>
        /// <param name="zPos">The z position of the light.</param>
        /// <param name="xDir">The x direction of the light.</param>
        /// <param name="yDir">The y direction of the light.</param>
        /// <param name="zDir">The z direction of the light.</param>
        /// <param name="angle">The cone angle the light in degrees.</param>
        /// <param name="range">The light range.</param>
        /// <returns>The 3DView Light name.</returns>
        public static Primitive AddSpotLight(Primitive shapeName, Primitive colour, Primitive xPos, Primitive yPos, Primitive zPos, Primitive xDir, Primitive yDir, Primitive zDir, Primitive angle, Primitive range)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Viewport3D viewport3D = (Viewport3D)obj;
                                ModelVisual3D modelVisual3D = (ModelVisual3D)viewport3D.Children[0];
                                Model3DGroup model3DGroup = (Model3DGroup)modelVisual3D.Content;

                                SpotLight spotLight = new SpotLight();
                                spotLight.Color = (Color)ColorConverter.ConvertFromString(colour);
                                spotLight.Position = new Point3D(xPos, yPos, zPos);
                                spotLight.Direction = new Vector3D(xDir, yDir, zDir);
                                spotLight.InnerConeAngle = angle;
                                spotLight.OuterConeAngle = angle+10;
                                spotLight.Range = range;
                                //spotLight.ConstantAttenuation = 3;

                                string name = getLightingName();
                                Lightings.Add(new Lighting(name, spotLight));
                                model3DGroup.Children.Add(spotLight);
                                return name;
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return "";
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    return method.Invoke(null, new object[] { ret }).ToString();
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Add a non-directional point light source.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="colour">The light colour.</param>
        /// <param name="xPos">The x position of the light.</param>
        /// <param name="yPos">The y position of the light.</param>
        /// <param name="zPos">The z position of the light.</param>
        /// <param name="range">The light range.</param>
        /// <returns>The 3DView Light name.</returns>
        public static Primitive AddPointLight(Primitive shapeName, Primitive colour, Primitive xPos, Primitive yPos, Primitive zPos, Primitive range)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Viewport3D viewport3D = (Viewport3D)obj;
                                ModelVisual3D modelVisual3D = (ModelVisual3D)viewport3D.Children[0];
                                Model3DGroup model3DGroup = (Model3DGroup)modelVisual3D.Content;

                                PointLight pointLight = new PointLight();
                                pointLight.Color = (Color)ColorConverter.ConvertFromString(colour);
                                pointLight.Position = new Point3D(xPos, yPos, zPos);
                                pointLight.Range = range;
                                pointLight.QuadraticAttenuation = 1;

                                string name = getLightingName();
                                Lightings.Add(new Lighting(name, pointLight));
                                model3DGroup.Children.Add(pointLight);
                                return name;
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return "";
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    return method.Invoke(null, new object[] { ret }).ToString();
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Rotate a geometry object about its centre.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="geometryName">The geometry object.</param>
        /// <param name="x">X direction of vector to rotate about.</param>
        /// <param name="y">Y direction of vector to rotate about.</param>
        /// <param name="z">Z direction of vector to rotate about.</param>
        /// <param name="angle">An angle in degrees to rotate.</param>
        public static void RotateGeometry(Primitive shapeName, Primitive geometryName, Primitive x, Primitive y, Primitive z, Primitive angle)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Geometry geom = getGeometry(geometryName);
                                if (null == geom) return;
                                GeometryModel3D geometry = geom.geometryModel3D;
                                Transform3D transform3D = (Transform3D)geometry.Transform;
                                Transform3DGroup transform3DGroup = (Transform3DGroup)transform3D;

                                RotateTransform3D rotateTransform3D = (RotateTransform3D)transform3DGroup.Children[(int)transform.Rotate];
                                AxisAngleRotation3D axisAngleRotation3D = new AxisAngleRotation3D();
                                axisAngleRotation3D.Axis = new Vector3D(x, y, z);
                                axisAngleRotation3D.Angle = angle;
                                rotateTransform3D.Rotation = axisAngleRotation3D;

                                geometry.Transform = transform3DGroup;
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return;
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Rotate a geometry object about its centre (a second rotation).
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="geometryName">The geometry object.</param>
        /// <param name="x">X direction of vector to rotate about.</param>
        /// <param name="y">Y direction of vector to rotate about.</param>
        /// <param name="z">Z direction of vector to rotate about.</param>
        /// <param name="angle">An angle in degrees to rotate.</param>
        public static void RotateGeometry2(Primitive shapeName, Primitive geometryName, Primitive x, Primitive y, Primitive z, Primitive angle)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Geometry geom = getGeometry(geometryName);
                                if (null == geom) return;
                                GeometryModel3D geometry = geom.geometryModel3D;
                                Transform3D transform3D = (Transform3D)geometry.Transform;
                                Transform3DGroup transform3DGroup = (Transform3DGroup)transform3D;

                                RotateTransform3D rotateTransform3D = (RotateTransform3D)transform3DGroup.Children[(int)transform.Rotate2];
                                AxisAngleRotation3D axisAngleRotation3D = new AxisAngleRotation3D();
                                axisAngleRotation3D.Axis = new Vector3D(x, y, z);
                                axisAngleRotation3D.Angle = angle;
                                rotateTransform3D.Rotation = axisAngleRotation3D;

                                geometry.Transform = transform3DGroup;
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return;
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Scale (zoom) a geometry object about its centre.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="geometryName">The geometry object.</param>
        /// <param name="x">X scale factor.</param>
        /// <param name="y">Y scale factor.</param>
        /// <param name="z">Z scale factor.</param>
        public static void ScaleGeometry(Primitive shapeName, Primitive geometryName, Primitive x, Primitive y, Primitive z)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Geometry geom = getGeometry(geometryName);
                                if (null == geom) return;
                                GeometryModel3D geometry = geom.geometryModel3D;
                                Transform3D transform3D = (Transform3D)geometry.Transform;
                                Transform3DGroup transform3DGroup = (Transform3DGroup)transform3D;

                                ScaleTransform3D scaleTransform3D = (ScaleTransform3D)transform3DGroup.Children[(int)transform.Scale];
                                scaleTransform3D.ScaleX = x;
                                scaleTransform3D.ScaleY = y;
                                scaleTransform3D.ScaleZ = z;

                                geometry.Transform = transform3DGroup;
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return;
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Translate (move) a geometry object.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="geometryName">The geometry object.</param>
        /// <param name="x">X direction translation.</param>
        /// <param name="y">Y direction translation.</param>
        /// <param name="z">Z direction translation.</param>
        public static void TranslateGeometry(Primitive shapeName, Primitive geometryName, Primitive x, Primitive y, Primitive z)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Geometry geom = getGeometry(geometryName);
                                if (null == geom) return;
                                GeometryModel3D geometry = geom.geometryModel3D;
                                Transform3D transform3D = (Transform3D)geometry.Transform;
                                Transform3DGroup transform3DGroup = (Transform3DGroup)transform3D;

                                TranslateTransform3D translateTransform3D = (TranslateTransform3D)transform3DGroup.Children[(int)transform.Translate];
                                translateTransform3D.OffsetX = x;
                                translateTransform3D.OffsetY = y;
                                translateTransform3D.OffsetZ = z;

                                geometry.Transform = transform3DGroup;
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return;
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Perform an action on a light or geometry object.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="geometryName">The geometry or light name.</param>
        /// <param name="action">The action to perform.
        /// The allowed actions are:
        /// "X" remove
        /// "H" hide
        /// "S" show
        /// </param>
        public static void ModifyObject(Primitive shapeName, Primitive geometryName, Primitive action)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Viewport3D viewport3D = (Viewport3D)obj;
                                ModelVisual3D modelVisual3D = (ModelVisual3D)viewport3D.Children[0];
                                Model3DGroup model3DGroup = (Model3DGroup)modelVisual3D.Content;

                                Geometry geom = getGeometry(geometryName);
                                Lighting lighting = getLighting(geometryName);
                                if (null != geom)
                                {
                                    switch (action.ToString().ToLower())
                                    {
                                        case "x":
                                            model3DGroup.Children.Remove(geom.geometryModel3D);
                                            Geometries.Remove(geom);
                                            break;
                                        case "h":
                                            model3DGroup.Children.Remove(geom.geometryModel3D);
                                            break;
                                        case "s":
                                            if (!model3DGroup.Children.Contains(geom.geometryModel3D)) model3DGroup.Children.Add(geom.geometryModel3D);
                                            break;
                                    }
                                }
                                else if (null != lighting)
                                {
                                    switch (action.ToString().ToLower())
                                    {
                                        case "x":
                                            model3DGroup.Children.Remove(lighting.light);
                                            Lightings.Remove(lighting);
                                            break;
                                        case "h":
                                            model3DGroup.Children.Remove(lighting.light);
                                            break;
                                        case "s":
                                            if (!model3DGroup.Children.Contains(lighting.light)) model3DGroup.Children.Add(lighting.light);
                                            break;
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Create a complete copy of a geometry object and all of its properties.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="geometryName">The object to copy's name.</param>
        /// <returns>The new copied 3DView object name.</returns>
        public static Primitive CloneObject(Primitive shapeName, Primitive geometryName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Viewport3D viewport3D = (Viewport3D)obj;
                                ModelVisual3D modelVisual3D = (ModelVisual3D)viewport3D.Children[0];
                                Model3DGroup model3DGroup = (Model3DGroup)modelVisual3D.Content;

                                Geometry geom = getGeometry(geometryName);
                                Lighting lighting = getLighting(geometryName);
                                if (null != geom)
                                {
                                    GeometryModel3D geomClone = geom.geometryModel3D.Clone();
                                    string name = getGeometryName();
                                    Geometries.Add(new Geometry(name, geomClone));
                                    model3DGroup.Children.Add(geomClone);
                                    return name;

                                }
                                else if (null != lighting)
                                {
                                    Light lightClone = lighting.light.Clone();
                                    string name = getLightingName();
                                    Lightings.Add(new Lighting(name, lightClone));
                                    model3DGroup.Children.Add(lightClone);
                                    return name;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return "";
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    return method.Invoke(null, new object[] { ret }).ToString();
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Perform a hit test in the 3DView.
        /// A negative value for the coordinates defaults to the screen centre (camera view).
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="x">The x coordinate in the GraphicsWindow coordinates within the 3DView.</param>
        /// <param name="y">The y coordinate in the GraphicsWindow coordinates within the 3DView.</param>
        /// <returns>An array with the hit object name and its distance or "" for no hit.</returns>
        public static Primitive HitTest(Primitive shapeName, Primitive x, Primitive y)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Viewport3D viewport3D = (Viewport3D)obj;
                                PerspectiveCamera camera = (PerspectiveCamera)viewport3D.Camera;

                                ModelVisual3D modelVisual3D = (ModelVisual3D)viewport3D.Children[0];
                                Model3DGroup model3DGroup = (Model3DGroup)modelVisual3D.Content;

                                if (x < 0) x = viewport3D.Width / 2;
                                if (y < 0) y = viewport3D.Height / 2;

                                PointHitTestParameters hitParams = new PointHitTestParameters(new Point(x, y));
                                rayResult = null;
                                VisualTreeHelper.HitTest(viewport3D, null, ResultCallback, hitParams);

                                if (null != rayResult)
                                {
                                    RayMeshGeometry3DHitTestResult rayResultMesh = rayResult as RayMeshGeometry3DHitTestResult;
                                    string result = "";
                                    foreach (Geometry i in Geometries)
                                    {
                                        if (i.geometryModel3D == rayResultMesh.ModelHit)
                                        {
                                            result += "1=" + i.name + ";";
                                            break;
                                        }
                                    }
                                    result += "2=" + Utilities.ArrayParse(rayResultMesh.DistanceToRayOrigin.ToString(CultureInfo.InvariantCulture)) + ";";
                                    return result;
                                }
                                return ""; 
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return "";
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    return Utilities.CreateArrayMap(method.Invoke(null, new object[] { ret }).ToString());
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Freeze a geometry object to improve performance a bit - it cannot then be modified in any way.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="geometryName">The object to freeze.</param>
        public static void Freeze(Primitive shapeName, Primitive geometryName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Viewport3D viewport3D = (Viewport3D)obj;
                                ModelVisual3D modelVisual3D = (ModelVisual3D)viewport3D.Children[0];
                                Model3DGroup model3DGroup = (Model3DGroup)modelVisual3D.Content;

                                Geometry geom = getGeometry(geometryName);
                                geom.geometryModel3D.Freeze();
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Animate a geometry rotation about an axis vector.
        /// This is the second rotation, the first is still available for another axis rotation.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="geometryName">The geometry object to animate.</param>
        /// <param name="x">X direction of vector to rotate about.</param>
        /// <param name="y">Y direction of vector to rotate about.</param>
        /// <param name="z">Z direction of vector to rotate about.</param>
        /// <param name="startAngle">The starting angle in dgrees (e.g. 0).</param>
        /// <param name="endAngle">The final angle in degrees (e.g. 360).</param>
        /// <param name="duration">The animation duration (time in sec).</param>
        /// <param name="repeats">The number of times to repeat the animation (-1 is for ever).</param>
        public static void AnimateRotation(Primitive shapeName, Primitive geometryName, Primitive x, Primitive y, Primitive z, Primitive startAngle, Primitive endAngle, Primitive duration, Primitive repeats)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Geometry geom = getGeometry(geometryName);
                                if (null == geom) return;
                                GeometryModel3D geometry = geom.geometryModel3D;
                                Transform3D transform3D = (Transform3D)geometry.Transform;
                                Transform3DGroup transform3DGroup = (Transform3DGroup)transform3D;

                                RotateTransform3D rotateTransform3D = (RotateTransform3D)transform3DGroup.Children[(int)transform.Rotate2];
                                AxisAngleRotation3D axisAngleRotation3D = (AxisAngleRotation3D)rotateTransform3D.Rotation;

                                DoubleAnimation doubleAnimaton = new DoubleAnimation();
                                doubleAnimaton.Duration = new Duration(new TimeSpan(duration * 10000000));
                                doubleAnimaton.RepeatBehavior = repeats < 0 ? RepeatBehavior.Forever : new RepeatBehavior(repeats);
                                doubleAnimaton.From = startAngle;
                                doubleAnimaton.To = endAngle;
                                doubleAnimaton.Completed += (s, _) => _RotationCompletedEvent(geom);
                                axisAngleRotation3D.Axis = new Vector3D(x, y, z);
                                axisAngleRotation3D.BeginAnimation(AxisAngleRotation3D.AngleProperty, doubleAnimaton); 
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Event when a rotation animation is completed.
        /// </summary>
        public static event SmallBasicCallback RotationCompleted
        {
            add
            {
                _RotationCompletedDelegate = value;
            }
            remove
            {
                _RotationCompletedDelegate = null;
            }
        }

        /// <summary>
        /// The last completed rotation animation geometry object.
        /// </summary>
        public static Primitive LastRotationCompleted
        {
            get
            {
                if (queueRotation.Count > 0) lastRotation = queueRotation.Dequeue();
                return lastRotation;
            }
        }

        /// <summary>
        /// Animate a geometry translation.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="geometryName">The geometry object to animate.</param>
        /// <param name="x">X position to animate to.</param>
        /// <param name="y">Y position to animate to.</param>
        /// <param name="z">Z position to animate to.</param>
        /// <param name="duration">The animation duration (sec).</param>
        public static void AnimateTranslation(Primitive shapeName, Primitive geometryName, Primitive x, Primitive y, Primitive z, Primitive duration)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Geometry geom = getGeometry(geometryName);
                                if (null == geom) return;
                                GeometryModel3D geometry = geom.geometryModel3D;
                                Transform3D transform3D = (Transform3D)geometry.Transform;
                                Transform3DGroup transform3DGroup = (Transform3DGroup)transform3D;

                                TranslateTransform3D translateTransform3D = (TranslateTransform3D)transform3DGroup.Children[(int)transform.Translate];

                                DoubleAnimation doubleAnimationX = new DoubleAnimation();
                                doubleAnimationX.Duration = new Duration(new TimeSpan(duration * 10000000));
                                doubleAnimationX.From = translateTransform3D.OffsetX;
                                doubleAnimationX.To = x;

                                DoubleAnimation doubleAnimationY = new DoubleAnimation();
                                doubleAnimationY.Duration = new Duration(new TimeSpan(duration * 10000000));
                                doubleAnimationY.From = translateTransform3D.OffsetY;
                                doubleAnimationY.To = y;

                                DoubleAnimation doubleAnimationZ = new DoubleAnimation();
                                doubleAnimationZ.Duration = new Duration(new TimeSpan(duration * 10000000));
                                doubleAnimationZ.From = translateTransform3D.OffsetZ;
                                doubleAnimationZ.To = z;

                                doubleAnimationX.Completed += (s, _) => _TranslationCompletedEvent(geom);

                                translateTransform3D.BeginAnimation(TranslateTransform3D.OffsetXProperty, doubleAnimationX);
                                translateTransform3D.BeginAnimation(TranslateTransform3D.OffsetYProperty, doubleAnimationY);
                                translateTransform3D.BeginAnimation(TranslateTransform3D.OffsetZProperty, doubleAnimationZ);
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        /// <summary>
        /// Event when a translation animation is completed.
        /// </summary>
        public static event SmallBasicCallback TranslationCompleted
        {
            add
            {
                _TranslationCompletedDelegate = value;
            }
            remove
            {
                _TranslationCompletedDelegate = null;
            }
        }

        /// <summary>
        /// The last completed translation animation geometry object.
        /// </summary>
        public static Primitive LastTranslationCompleted
        {
            get
            {
                if (queueTranslation.Count > 0) lastTranslation = queueTranslation.Dequeue();
                return lastTranslation;
            }
        }

        /// <summary>
        /// The number of currently queued completed rotation animations.
        /// </summary>
        public static Primitive QueuedRotationCompleted
        {
            get
            {
                return queueRotation.Count;
            }
        }

        /// <summary>
        /// The number of currently queued completed translation animations.
        /// </summary>
        public static Primitive QueuedTranslationCompleted
        {
            get
            {
                return queueTranslation.Count;
            }
        }

        /// <summary>
        /// Load geometry models from a file.
        /// Supported formats include 3ds, lwo, obj, objz, stl and off.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="fileName">The file to load.
        /// Often image files etc are also required with the same name in the same folder.</param>
        /// <returns>An array with the added geometry names.</returns>
        public static Primitive LoadModel(Primitive shapeName, Primitive fileName)
        {
            if (!System.IO.File.Exists(fileName))
            {
                Utilities.OnFileError(Utilities.GetCurrentMethod(), fileName);
                return "";
            }
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Viewport3D viewport3D = (Viewport3D)obj;
                                ModelVisual3D modelVisual3D = (ModelVisual3D)viewport3D.Children[0];
                                Model3DGroup model3DGroup = (Model3DGroup)modelVisual3D.Content;

                                Model3DGroup model3DGroupLoad = ModelImporter.Load(fileName);
                                string names = "";
                                int i = 0;
                                foreach (GeometryModel3D geometry in model3DGroupLoad.Children)
                                {
                                    string name = getGeometryName();
                                    names += (++i).ToString() + "=" + Utilities.ArrayParse(name) + ";";
                                    AddTransforms(geometry);
                                    Geometries.Add(new Geometry(name, geometry));
                                    model3DGroup.Children.Add(geometry);
                                }
                                return Utilities.CreateArrayMap(names);
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return "";
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    return method.Invoke(null, new object[] { ret }).ToString();
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Add a sphere geometry object centred on (0,0,0).
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="radius">The sphere radius.</param>
        /// <param name="divisions">The sphere divisions, default 10 (affects number of triangles and smoothness).</param>
        /// <param name="colour">A colour for the object.</param>
        /// <param name="materialType">A material for the object.
        /// The available options are:
        /// "E" Emmissive - constant brightness.
        /// "D" Diffusive - affected by lights.</param>
        /// <returns>The 3DView Geometry name.</returns>
        public static Primitive AddSphere(Primitive shapeName, Primitive radius, Primitive divisions, Primitive colour, Primitive materialType)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                MeshBuilder builder = new MeshBuilder(true, true);
                                Point3D center = new Point3D(0, 0, 0);
                                int phiDiv = divisions < 2 ? 10 : (int)divisions;
                                int thetaDiv = 2 * phiDiv;
                                builder.AddSphere(center, radius, thetaDiv, phiDiv);
                                MeshGeometry3D mesh = builder.ToMesh();

                                Viewport3D viewport3D = (Viewport3D)obj;
                                return AddGeometry(viewport3D, mesh.Positions, mesh.TriangleIndices, mesh.Normals, mesh.TextureCoordinates, colour, materialType);
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return "";
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    return method.Invoke(null, new object[] { ret }).ToString();
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Add a tube geometry object.
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="path">A space or colon deliminated list of point coordinates.</param>
        /// <param name="diameter">The tube diameter.</param>
        /// <param name="divisions">The tube radial divisions, default 10 (affects number of triangles and smoothness).</param>
        /// <param name="colour">A colour for the object.</param>
        /// <param name="materialType">A material for the object.
        /// The available options are:
        /// "E" Emmissive - constant brightness.
        /// "D" Diffusive - affected by lights.</param>
        /// <returns>The 3DView Geometry name.</returns>
        public static Primitive AddTube(Primitive shapeName, Primitive path, Primitive diameter, Primitive divisions, Primitive colour, Primitive materialType)
        {
            bool closed = false;
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                MeshBuilder builder = new MeshBuilder(true, true);
                                Point3DCollection pointCollection = new Point3DCollection();
                                string[] s = Utilities.getString(path).Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
                                for (int i = 0; i < s.Length; i += 3)
                                {
                                    pointCollection.Add(new Point3D(Utilities.getDouble(s[i]), Utilities.getDouble(s[i + 1]), Utilities.getDouble(s[i + 2])));
                                }
                                int thetaDiv = divisions < 2 ? 10 : (int)divisions;
                                builder.AddTube(pointCollection, diameter, thetaDiv, closed);
                                MeshGeometry3D mesh = builder.ToMesh();

                                Viewport3D viewport3D = (Viewport3D)obj;
                                return AddGeometry(viewport3D, mesh.Positions, mesh.TriangleIndices, mesh.Normals, mesh.TextureCoordinates, colour, materialType);
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                        return "";
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("InvokeWithReturn", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    return method.Invoke(null, new object[] { ret }).ToString();
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Reverse the outward normals for a geometry.
        /// For example, make the inside surface of a sphere the visible surface instead of the outside surface (skydome).
        /// </summary>
        /// <param name="shapeName">The 3DView object.</param>
        /// <param name="geometryName">The geometry object to reverse outward normals.</param>
        public static void ReverseNormals(Primitive shapeName, Primitive geometryName)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            if (obj.GetType() == typeof(Viewport3D))
                            {
                                Geometry geom = getGeometry(geometryName);
                                if (null == geom) return;
                                GeometryModel3D geometry = geom.geometryModel3D;
                                MeshGeometry3D mesh = (MeshGeometry3D)geometry.Geometry;
                                Material material = geometry.Material;
                                int i;
                                for (i = 0; i < mesh.TriangleIndices.Count; i += 3)
                                {
                                    int j = mesh.TriangleIndices[i];
                                    mesh.TriangleIndices[i] = mesh.TriangleIndices[i + 1];
                                    mesh.TriangleIndices[i + 1] = j;
                                }
                                for (i = 0; i < mesh.Normals.Count; i++)
                                {
                                    mesh.Normals[i] *= -1;
                                }
                                geometry.Material = material;
                            }
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    MethodInfo method = GraphicsWindowType.GetMethod("Invoke", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
                    method.Invoke(null, new object[] { ret });
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }
    }
}