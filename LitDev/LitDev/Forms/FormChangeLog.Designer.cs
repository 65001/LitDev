﻿namespace LitDev
{
    partial class FormChangeLog
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("DataViewColumnWidths method added");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("DataViewRowColours method added");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Various obscure or experimental methods made visible to intelliseense. (LD3DView," +
        " LDBlueTooth, LDScrolBars, LDShapes)");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("SetCentre method added");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("A 3rd rotation added");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("BoundingBox method added");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Reverted to earlier MySQL version to handle old password encryption");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("PlayMusic2 method added");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Channel parameter added");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Version 1.2.11.0", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode5,
            treeNode9,
            treeNode11,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("SetButtonStyle method added");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Additional geometries added (Cube, Cone, Arrow, Revolute and Rectangle)");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("SetBillBoard method added");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("GetCameraUpDirection method added");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Gradient brushes can be used");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("AutoControl method added");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("SpecularExponent property added");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("AddText method to annotate an image with text added");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("BrushText for text on a brush added");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Skew shapes method added");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode28});
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Version 1.2.10.0", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode24,
            treeNode26,
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("A general purpose unit system, see LDUnits.sb sample");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("LDUnits", new System.Windows.Forms.TreeNode[] {
            treeNode31});
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Possible issue with FixSigFig fixed");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode33});
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("GetIndex method added (for SB arrays)");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode35});
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Resize mode property added");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Icon sets SB icon if property set to \"SB\"");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode37,
            treeNode38});
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Possible threading error with DataViewSetRow and DataViewSetValue fixed");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("DataViewAllowUserEntry method added");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode40,
            treeNode41});
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Version 1.2.9.0", new System.Windows.Forms.TreeNode[] {
            treeNode32,
            treeNode34,
            treeNode36,
            treeNode39,
            treeNode42});
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("New extended math object, starting with FFT");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("LDMathX", new System.Windows.Forms.TreeNode[] {
            treeNode44});
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("AddListBox and ListBoxContent can accept LDList and LDArray data");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode46});
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("CreateFromIndices and CreateFromValues methods added");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode48});
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("CreateFromIndices and CreateFromValues methods added");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("LDList", new System.Windows.Forms.TreeNode[] {
            treeNode50});
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Version 1.2.8.0", new System.Windows.Forms.TreeNode[] {
            treeNode45,
            treeNode47,
            treeNode49,
            treeNode51});
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("Error handling, additional settings and multiple ports supported");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode53});
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("Posterise, Hue, Saturation and Lightness effects added");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("More image effects, OilPaint, Charcoal, Sketch, Cartoon, Edge, Accent, Sepia, Noi" +
        "seRemoval and Solarise added");
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("LDImage and LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode55,
            treeNode56});
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("Bitwise operations object added");
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("LDBits", new System.Windows.Forms.TreeNode[] {
            treeNode58});
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("Extended text encoding property added");
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("TextWindow colours can be changed");
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode60,
            treeNode61});
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("GetWorkingImagePixelARGB method added");
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode63});
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("RasteriseTurtleLines method added");
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode65});
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("Version 1.2.7.0", new System.Windows.Forms.TreeNode[] {
            treeNode54,
            treeNode57,
            treeNode59,
            treeNode62,
            treeNode64,
            treeNode66});
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("Confirm dialog is given focus above GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode68});
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("Read and write json model scripts compatible with R.U.B.E.");
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("ToggleSensor added");
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode70,
            treeNode71});
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("Allow multiple copies of the webcam image");
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode73});
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("Fast pixel level image manipulation using a temporary working image added");
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("MetaData method added");
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode75,
            treeNode76});
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("Version 1.2.6.0", new System.Windows.Forms.TreeNode[] {
            treeNode69,
            treeNode72,
            treeNode74,
            treeNode77});
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("FixSigFig and FixDecimal methods added");
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("MinNumber and MaxNumber properties added");
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode79,
            treeNode80});
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("SliderMaximum property added");
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode82});
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("ZoomAll method added");
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode84});
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("Reposition methods and properties added");
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode86});
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("GetImagePixels and SetImagePixels methods added");
            System.Windows.Forms.TreeNode treeNode89 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode88});
            System.Windows.Forms.TreeNode treeNode90 = new System.Windows.Forms.TreeNode("MouseScroll parameter added");
            System.Windows.Forms.TreeNode treeNode91 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode90});
            System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("Version 1.2.5.0", new System.Windows.Forms.TreeNode[] {
            treeNode81,
            treeNode83,
            treeNode85,
            treeNode87,
            treeNode89,
            treeNode91});
            System.Windows.Forms.TreeNode treeNode93 = new System.Windows.Forms.TreeNode("New object added (previously a separate extension)");
            System.Windows.Forms.TreeNode treeNode94 = new System.Windows.Forms.TreeNode("Async, Loop, Volume and Pan properties added");
            System.Windows.Forms.TreeNode treeNode95 = new System.Windows.Forms.TreeNode("PlayWave, PlayHarmonics and PlayWavFile methods added");
            System.Windows.Forms.TreeNode treeNode96 = new System.Windows.Forms.TreeNode("LDWaveForm", new System.Windows.Forms.TreeNode[] {
            treeNode93,
            treeNode94,
            treeNode95});
            System.Windows.Forms.TreeNode treeNode97 = new System.Windows.Forms.TreeNode("New object added to get input from gamepads or joysticks");
            System.Windows.Forms.TreeNode treeNode98 = new System.Windows.Forms.TreeNode("LDController", new System.Windows.Forms.TreeNode[] {
            treeNode97});
            System.Windows.Forms.TreeNode treeNode99 = new System.Windows.Forms.TreeNode("RayCast method added");
            System.Windows.Forms.TreeNode treeNode100 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode99});
            System.Windows.Forms.TreeNode treeNode101 = new System.Windows.Forms.TreeNode("Version 1.2.4.0", new System.Windows.Forms.TreeNode[] {
            treeNode96,
            treeNode98,
            treeNode100});
            System.Windows.Forms.TreeNode treeNode102 = new System.Windows.Forms.TreeNode("New object to apply effects to any shape or control");
            System.Windows.Forms.TreeNode treeNode103 = new System.Windows.Forms.TreeNode("LDEffects", new System.Windows.Forms.TreeNode[] {
            treeNode102});
            System.Windows.Forms.TreeNode treeNode104 = new System.Windows.Forms.TreeNode("New object to add arrow, arc, polygons and callout shapes");
            System.Windows.Forms.TreeNode treeNode105 = new System.Windows.Forms.TreeNode("LDFigures", new System.Windows.Forms.TreeNode[] {
            treeNode104});
            System.Windows.Forms.TreeNode treeNode106 = new System.Windows.Forms.TreeNode("SetGroup method added");
            System.Windows.Forms.TreeNode treeNode107 = new System.Windows.Forms.TreeNode("GetContacts method added");
            System.Windows.Forms.TreeNode treeNode108 = new System.Windows.Forms.TreeNode("GetAllShapesAt method added");
            System.Windows.Forms.TreeNode treeNode109 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode106,
            treeNode107,
            treeNode108});
            System.Windows.Forms.TreeNode treeNode110 = new System.Windows.Forms.TreeNode("SetImage handles images with transparency");
            System.Windows.Forms.TreeNode treeNode111 = new System.Windows.Forms.TreeNode("ImageTransparency property added to switch how image transparencies are handled");
            System.Windows.Forms.TreeNode treeNode112 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode110,
            treeNode111});
            System.Windows.Forms.TreeNode treeNode113 = new System.Windows.Forms.TreeNode("Version 1.2.3.0", new System.Windows.Forms.TreeNode[] {
            treeNode103,
            treeNode105,
            treeNode109,
            treeNode112});
            System.Windows.Forms.TreeNode treeNode114 = new System.Windows.Forms.TreeNode("BrushGradient can use \"R\" for radial orientation");
            System.Windows.Forms.TreeNode treeNode115 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode114});
            System.Windows.Forms.TreeNode treeNode116 = new System.Windows.Forms.TreeNode("Unnecessary file existance checks removed from GetFolder, GetFile and GetExtensio" +
        "n");
            System.Windows.Forms.TreeNode treeNode117 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode116});
            System.Windows.Forms.TreeNode treeNode118 = new System.Windows.Forms.TreeNode("NewImage method added");
            System.Windows.Forms.TreeNode treeNode119 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode118});
            System.Windows.Forms.TreeNode treeNode120 = new System.Windows.Forms.TreeNode("SetStartupPosition method added to position dialogs");
            System.Windows.Forms.TreeNode treeNode121 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode120});
            System.Windows.Forms.TreeNode treeNode122 = new System.Windows.Forms.TreeNode("AddSeriesHitogram renamed AddSeriesHistogram");
            System.Windows.Forms.TreeNode treeNode123 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode122});
            System.Windows.Forms.TreeNode treeNode124 = new System.Windows.Forms.TreeNode("Version 1.2.2.0", new System.Windows.Forms.TreeNode[] {
            treeNode115,
            treeNode117,
            treeNode119,
            treeNode121,
            treeNode123});
            System.Windows.Forms.TreeNode treeNode125 = new System.Windows.Forms.TreeNode("Recompiled for Small Basic version 1.2");
            System.Windows.Forms.TreeNode treeNode126 = new System.Windows.Forms.TreeNode("Version 1.2", new System.Windows.Forms.TreeNode[] {
            treeNode125});
            System.Windows.Forms.TreeNode treeNode127 = new System.Windows.Forms.TreeNode("Version 1.2.0.1", new System.Windows.Forms.TreeNode[] {
            treeNode126});
            System.Windows.Forms.TreeNode treeNode128 = new System.Windows.Forms.TreeNode("OpenFile and SaveFile may take an array of extensions");
            System.Windows.Forms.TreeNode treeNode129 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode128});
            System.Windows.Forms.TreeNode treeNode130 = new System.Windows.Forms.TreeNode("Logical operations object added");
            System.Windows.Forms.TreeNode treeNode131 = new System.Windows.Forms.TreeNode("LDLogic", new System.Windows.Forms.TreeNode[] {
            treeNode130});
            System.Windows.Forms.TreeNode treeNode132 = new System.Windows.Forms.TreeNode("CurrentCulture property added");
            System.Windows.Forms.TreeNode treeNode133 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode132});
            System.Windows.Forms.TreeNode treeNode134 = new System.Windows.Forms.TreeNode("Evaluate3, a method to evaluate to a boolean added");
            System.Windows.Forms.TreeNode treeNode135 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode134});
            System.Windows.Forms.TreeNode treeNode136 = new System.Windows.Forms.TreeNode("Version 1.1.0.8", new System.Windows.Forms.TreeNode[] {
            treeNode129,
            treeNode131,
            treeNode133,
            treeNode135});
            System.Windows.Forms.TreeNode treeNode137 = new System.Windows.Forms.TreeNode("Scrolling to selected nodes improved for dataview with custom column type (e.g.co" +
        "mbobox)");
            System.Windows.Forms.TreeNode treeNode138 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode137});
            System.Windows.Forms.TreeNode treeNode139 = new System.Windows.Forms.TreeNode("Methods added to add and remove nodes and save xml file");
            System.Windows.Forms.TreeNode treeNode140 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode139});
            System.Windows.Forms.TreeNode treeNode141 = new System.Windows.Forms.TreeNode("MusicPlayTime moved from LDFile");
            System.Windows.Forms.TreeNode treeNode142 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode141});
            System.Windows.Forms.TreeNode treeNode143 = new System.Windows.Forms.TreeNode("Version 1.1.0.7", new System.Windows.Forms.TreeNode[] {
            treeNode138,
            treeNode140,
            treeNode142});
            System.Windows.Forms.TreeNode treeNode144 = new System.Windows.Forms.TreeNode("SplitImage method added");
            System.Windows.Forms.TreeNode treeNode145 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode144});
            System.Windows.Forms.TreeNode treeNode146 = new System.Windows.Forms.TreeNode("EditTable and SaveTable methods added");
            System.Windows.Forms.TreeNode treeNode147 = new System.Windows.Forms.TreeNode("LDDatabse", new System.Windows.Forms.TreeNode[] {
            treeNode146});
            System.Windows.Forms.TreeNode treeNode148 = new System.Windows.Forms.TreeNode("DataView control and methods added");
            System.Windows.Forms.TreeNode treeNode149 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode148});
            System.Windows.Forms.TreeNode treeNode150 = new System.Windows.Forms.TreeNode("Version 1.1.0.6", new System.Windows.Forms.TreeNode[] {
            treeNode145,
            treeNode147,
            treeNode149});
            System.Windows.Forms.TreeNode treeNode151 = new System.Windows.Forms.TreeNode("Exists modified to check for directory as well as file");
            System.Windows.Forms.TreeNode treeNode152 = new System.Windows.Forms.TreeNode("GetAllDirectories modified to omit directories without sufficient permissions");
            System.Windows.Forms.TreeNode treeNode153 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode151,
            treeNode152});
            System.Windows.Forms.TreeNode treeNode154 = new System.Windows.Forms.TreeNode("Instrumenting - Index was outside the bounds of the array - bug fixed");
            System.Windows.Forms.TreeNode treeNode155 = new System.Windows.Forms.TreeNode("Bug fixed returning to Small Basic IDE if application ends before debug window is" +
        " closed");
            System.Windows.Forms.TreeNode treeNode156 = new System.Windows.Forms.TreeNode("Conditonal break point added");
            System.Windows.Forms.TreeNode treeNode157 = new System.Windows.Forms.TreeNode("Step over button added");
            System.Windows.Forms.TreeNode treeNode158 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode154,
            treeNode155,
            treeNode156,
            treeNode157});
            System.Windows.Forms.TreeNode treeNode159 = new System.Windows.Forms.TreeNode("ExitOnClose works with LDWindows (multiple windows)");
            System.Windows.Forms.TreeNode treeNode160 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode159});
            System.Windows.Forms.TreeNode treeNode161 = new System.Windows.Forms.TreeNode("Object added to save image, sound, file and text/varables to a resources file");
            System.Windows.Forms.TreeNode treeNode162 = new System.Windows.Forms.TreeNode("LDResources", new System.Windows.Forms.TreeNode[] {
            treeNode161});
            System.Windows.Forms.TreeNode treeNode163 = new System.Windows.Forms.TreeNode("Version 1.1.0.5", new System.Windows.Forms.TreeNode[] {
            treeNode153,
            treeNode158,
            treeNode160,
            treeNode162});
            System.Windows.Forms.TreeNode treeNode164 = new System.Windows.Forms.TreeNode("ClipboardChanged event added");
            System.Windows.Forms.TreeNode treeNode165 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode164});
            System.Windows.Forms.TreeNode treeNode166 = new System.Windows.Forms.TreeNode("RenameFile, RenameDirctory, CopyDirectory and GetAllDirectories methods added");
            System.Windows.Forms.TreeNode treeNode167 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode166});
            System.Windows.Forms.TreeNode treeNode168 = new System.Windows.Forms.TreeNode("SetActive method added");
            System.Windows.Forms.TreeNode treeNode169 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode168});
            System.Windows.Forms.TreeNode treeNode170 = new System.Windows.Forms.TreeNode("Parse xml file nodes");
            System.Windows.Forms.TreeNode treeNode171 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode170});
            System.Windows.Forms.TreeNode treeNode172 = new System.Windows.Forms.TreeNode("\"FAILURE\" replaced by \"FAILED\" as a return message for consistency");
            System.Windows.Forms.TreeNode treeNode173 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode172});
            System.Windows.Forms.TreeNode treeNode174 = new System.Windows.Forms.TreeNode("Version 1.1.0.4", new System.Windows.Forms.TreeNode[] {
            treeNode165,
            treeNode167,
            treeNode169,
            treeNode171,
            treeNode173});
            System.Windows.Forms.TreeNode treeNode175 = new System.Windows.Forms.TreeNode("WakeAll method addded");
            System.Windows.Forms.TreeNode treeNode176 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode175});
            System.Windows.Forms.TreeNode treeNode177 = new System.Windows.Forms.TreeNode("Clipboard methods added");
            System.Windows.Forms.TreeNode treeNode178 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode177});
            System.Windows.Forms.TreeNode treeNode179 = new System.Windows.Forms.TreeNode("Version 1.1.0.3", new System.Windows.Forms.TreeNode[] {
            treeNode176,
            treeNode178});
            System.Windows.Forms.TreeNode treeNode180 = new System.Windows.Forms.TreeNode("SizeNWSE cursor added");
            System.Windows.Forms.TreeNode treeNode181 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode180});
            System.Windows.Forms.TreeNode treeNode182 = new System.Windows.Forms.TreeNode("ScaleAxisX & ScaleAxisY modified for better control");
            System.Windows.Forms.TreeNode treeNode183 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode182});
            System.Windows.Forms.TreeNode treeNode184 = new System.Windows.Forms.TreeNode("SQLite updated for .Net 4.5");
            System.Windows.Forms.TreeNode treeNode185 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode184});
            System.Windows.Forms.TreeNode treeNode186 = new System.Windows.Forms.TreeNode("Version 1.1.0.2", new System.Windows.Forms.TreeNode[] {
            treeNode181,
            treeNode183,
            treeNode185});
            System.Windows.Forms.TreeNode treeNode187 = new System.Windows.Forms.TreeNode("Recompiled for Small Basic version 1.1");
            System.Windows.Forms.TreeNode treeNode188 = new System.Windows.Forms.TreeNode("Version 1.1", new System.Windows.Forms.TreeNode[] {
            treeNode187});
            System.Windows.Forms.TreeNode treeNode189 = new System.Windows.Forms.TreeNode("Version 1.1.0.1", new System.Windows.Forms.TreeNode[] {
            treeNode188});
            System.Windows.Forms.TreeNode treeNode190 = new System.Windows.Forms.TreeNode("RichTextBoxCaseSensitive parameter added");
            System.Windows.Forms.TreeNode treeNode191 = new System.Windows.Forms.TreeNode("RichTextBoxMargins method added");
            System.Windows.Forms.TreeNode treeNode192 = new System.Windows.Forms.TreeNode("ListBoxSelectionMode added for multiple list box selection");
            System.Windows.Forms.TreeNode treeNode193 = new System.Windows.Forms.TreeNode("ListBoxGetSelected and ListBoxSelect modified for multiple selection modes");
            System.Windows.Forms.TreeNode treeNode194 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode190,
            treeNode191,
            treeNode192,
            treeNode193});
            System.Windows.Forms.TreeNode treeNode195 = new System.Windows.Forms.TreeNode("Error reporting added");
            System.Windows.Forms.TreeNode treeNode196 = new System.Windows.Forms.TreeNode("SetEncoding method added");
            System.Windows.Forms.TreeNode treeNode197 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode195,
            treeNode196});
            System.Windows.Forms.TreeNode treeNode198 = new System.Windows.Forms.TreeNode("AddSeries methods replace an existing series if the label name is the same");
            System.Windows.Forms.TreeNode treeNode199 = new System.Windows.Forms.TreeNode("Export to excel fix for graph with no title");
            System.Windows.Forms.TreeNode treeNode200 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode198,
            treeNode199});
            System.Windows.Forms.TreeNode treeNode201 = new System.Windows.Forms.TreeNode("Negative restitution option when adding moving shape");
            System.Windows.Forms.TreeNode treeNode202 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode201});
            System.Windows.Forms.TreeNode treeNode203 = new System.Windows.Forms.TreeNode("Version 1.0.0.133", new System.Windows.Forms.TreeNode[] {
            treeNode194,
            treeNode197,
            treeNode200,
            treeNode202});
            System.Windows.Forms.TreeNode treeNode204 = new System.Windows.Forms.TreeNode("Internal improvements to auto messaging");
            System.Windows.Forms.TreeNode treeNode205 = new System.Windows.Forms.TreeNode("Name can be set and GetClients method added");
            System.Windows.Forms.TreeNode treeNode206 = new System.Windows.Forms.TreeNode("LDClient", new System.Windows.Forms.TreeNode[] {
            treeNode204,
            treeNode205});
            System.Windows.Forms.TreeNode treeNode207 = new System.Windows.Forms.TreeNode("RichTextBoxWord method modified to include mode parameter");
            System.Windows.Forms.TreeNode treeNode208 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode207});
            System.Windows.Forms.TreeNode treeNode209 = new System.Windows.Forms.TreeNode("Return message and possible file error fixed for Stop method");
            System.Windows.Forms.TreeNode treeNode210 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode209});
            System.Windows.Forms.TreeNode treeNode211 = new System.Windows.Forms.TreeNode("Version 1.0.0.132", new System.Windows.Forms.TreeNode[] {
            treeNode206,
            treeNode208,
            treeNode210});
            System.Windows.Forms.TreeNode treeNode212 = new System.Windows.Forms.TreeNode("Include and CallInclude methods added to use a pre-compiled file");
            System.Windows.Forms.TreeNode treeNode213 = new System.Windows.Forms.TreeNode("Compile method added to compile a Small Basic program");
            System.Windows.Forms.TreeNode treeNode214 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode212,
            treeNode213});
            System.Windows.Forms.TreeNode treeNode215 = new System.Windows.Forms.TreeNode("Methods and code by Pappa Lapub added");
            System.Windows.Forms.TreeNode treeNode216 = new System.Windows.Forms.TreeNode("LDShell", new System.Windows.Forms.TreeNode[] {
            treeNode215});
            System.Windows.Forms.TreeNode treeNode217 = new System.Windows.Forms.TreeNode("Version 1.0.0.131", new System.Windows.Forms.TreeNode[] {
            treeNode214,
            treeNode216});
            System.Windows.Forms.TreeNode treeNode218 = new System.Windows.Forms.TreeNode("FollowShapeX and FollowShapeY methods added");
            System.Windows.Forms.TreeNode treeNode219 = new System.Windows.Forms.TreeNode("BoxShape method added to keep a shape with a region of the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode220 = new System.Windows.Forms.TreeNode("Refactoring of all the pan, follow and box methods");
            System.Windows.Forms.TreeNode treeNode221 = new System.Windows.Forms.TreeNode("All input and output coordinates are in world coordinates, apart from GetShapeAt " +
        "which is in screen coordinates");
            System.Windows.Forms.TreeNode treeNode222 = new System.Windows.Forms.TreeNode("GetPan method added to convert between world and screen coordinates");
            System.Windows.Forms.TreeNode treeNode223 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode218,
            treeNode219,
            treeNode220,
            treeNode221,
            treeNode222});
            System.Windows.Forms.TreeNode treeNode224 = new System.Windows.Forms.TreeNode("UseBinary property added");
            System.Windows.Forms.TreeNode treeNode225 = new System.Windows.Forms.TreeNode("DoAsync property and associated completion events added");
            System.Windows.Forms.TreeNode treeNode226 = new System.Windows.Forms.TreeNode("Delete method added");
            System.Windows.Forms.TreeNode treeNode227 = new System.Windows.Forms.TreeNode("LDftp", new System.Windows.Forms.TreeNode[] {
            treeNode224,
            treeNode225,
            treeNode226});
            System.Windows.Forms.TreeNode treeNode228 = new System.Windows.Forms.TreeNode("CallAsync method to call any extension method asynchronously added");
            System.Windows.Forms.TreeNode treeNode229 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode228});
            System.Windows.Forms.TreeNode treeNode230 = new System.Windows.Forms.TreeNode("SetCursorToEnd also works for RichTextBox");
            System.Windows.Forms.TreeNode treeNode231 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode230});
            System.Windows.Forms.TreeNode treeNode232 = new System.Windows.Forms.TreeNode("Version 1.0.0.130", new System.Windows.Forms.TreeNode[] {
            treeNode223,
            treeNode227,
            treeNode229,
            treeNode231});
            System.Windows.Forms.TreeNode treeNode233 = new System.Windows.Forms.TreeNode("Evaluate2 method added to behave nicely with the TextWindow");
            System.Windows.Forms.TreeNode treeNode234 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode233});
            System.Windows.Forms.TreeNode treeNode235 = new System.Windows.Forms.TreeNode("SetShapeGravity method to alter gravity for individual shapes");
            System.Windows.Forms.TreeNode treeNode236 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode235});
            System.Windows.Forms.TreeNode treeNode237 = new System.Windows.Forms.TreeNode("Improve PauseUpdate and ResumeUpdates methods");
            System.Windows.Forms.TreeNode treeNode238 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode237});
            System.Windows.Forms.TreeNode treeNode239 = new System.Windows.Forms.TreeNode("FTP object methods added");
            System.Windows.Forms.TreeNode treeNode240 = new System.Windows.Forms.TreeNode("LDftp", new System.Windows.Forms.TreeNode[] {
            treeNode239});
            System.Windows.Forms.TreeNode treeNode241 = new System.Windows.Forms.TreeNode("An existing file is replaced");
            System.Windows.Forms.TreeNode treeNode242 = new System.Windows.Forms.TreeNode("LDZip", new System.Windows.Forms.TreeNode[] {
            treeNode241});
            System.Windows.Forms.TreeNode treeNode243 = new System.Windows.Forms.TreeNode("Size method added");
            System.Windows.Forms.TreeNode treeNode244 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode243});
            System.Windows.Forms.TreeNode treeNode245 = new System.Windows.Forms.TreeNode("DownloadFile method added");
            System.Windows.Forms.TreeNode treeNode246 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode245});
            System.Windows.Forms.TreeNode treeNode247 = new System.Windows.Forms.TreeNode("Version 1.0.0.129", new System.Windows.Forms.TreeNode[] {
            treeNode234,
            treeNode236,
            treeNode238,
            treeNode240,
            treeNode242,
            treeNode244,
            treeNode246});
            System.Windows.Forms.TreeNode treeNode248 = new System.Windows.Forms.TreeNode("Generalised joint connections added");
            System.Windows.Forms.TreeNode treeNode249 = new System.Windows.Forms.TreeNode("AddExplosion method added");
            System.Windows.Forms.TreeNode treeNode250 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode248,
            treeNode249});
            System.Windows.Forms.TreeNode treeNode251 = new System.Windows.Forms.TreeNode("BrushImage method added and renamed some BrushGradient commands (old methods stil" +
        "l work but depreciated)");
            System.Windows.Forms.TreeNode treeNode252 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode251});
            System.Windows.Forms.TreeNode treeNode253 = new System.Windows.Forms.TreeNode("Version 1.0.0.128", new System.Windows.Forms.TreeNode[] {
            treeNode250,
            treeNode252});
            System.Windows.Forms.TreeNode treeNode254 = new System.Windows.Forms.TreeNode("CheckServer method added");
            System.Windows.Forms.TreeNode treeNode255 = new System.Windows.Forms.TreeNode("LDClient", new System.Windows.Forms.TreeNode[] {
            treeNode254});
            System.Windows.Forms.TreeNode treeNode256 = new System.Windows.Forms.TreeNode("Default maximum number of objects (proxies) increased from 512 to 1024");
            System.Windows.Forms.TreeNode treeNode257 = new System.Windows.Forms.TreeNode("MaxPolygonVertices and MaxProxies properties added");
            System.Windows.Forms.TreeNode treeNode258 = new System.Windows.Forms.TreeNode("GetAngle method added");
            System.Windows.Forms.TreeNode treeNode259 = new System.Windows.Forms.TreeNode("Top-down tire (to model a car from above) methods added");
            System.Windows.Forms.TreeNode treeNode260 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode256,
            treeNode257,
            treeNode258,
            treeNode259});
            System.Windows.Forms.TreeNode treeNode261 = new System.Windows.Forms.TreeNode("Version 1.0.0.127", new System.Windows.Forms.TreeNode[] {
            treeNode255,
            treeNode260});
            System.Windows.Forms.TreeNode treeNode262 = new System.Windows.Forms.TreeNode("Bug fixes for Overlap methods");
            System.Windows.Forms.TreeNode treeNode263 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode262});
            System.Windows.Forms.TreeNode treeNode264 = new System.Windows.Forms.TreeNode("Bug fix for multiple numeric sorts");
            System.Windows.Forms.TreeNode treeNode265 = new System.Windows.Forms.TreeNode("ByValueWithIndex method added");
            System.Windows.Forms.TreeNode treeNode266 = new System.Windows.Forms.TreeNode("LDSort", new System.Windows.Forms.TreeNode[] {
            treeNode264,
            treeNode265});
            System.Windows.Forms.TreeNode treeNode267 = new System.Windows.Forms.TreeNode("LAN method added to get local IP addresses");
            System.Windows.Forms.TreeNode treeNode268 = new System.Windows.Forms.TreeNode("Ping method added");
            System.Windows.Forms.TreeNode treeNode269 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode267,
            treeNode268});
            System.Windows.Forms.TreeNode treeNode270 = new System.Windows.Forms.TreeNode("LoadSVG method added");
            System.Windows.Forms.TreeNode treeNode271 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode270});
            System.Windows.Forms.TreeNode treeNode272 = new System.Windows.Forms.TreeNode("Evaluate method added");
            System.Windows.Forms.TreeNode treeNode273 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode272});
            System.Windows.Forms.TreeNode treeNode274 = new System.Windows.Forms.TreeNode("IncludeJScript method added");
            System.Windows.Forms.TreeNode treeNode275 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode274});
            System.Windows.Forms.TreeNode treeNode276 = new System.Windows.Forms.TreeNode("Version 1.0.0.126", new System.Windows.Forms.TreeNode[] {
            treeNode263,
            treeNode266,
            treeNode269,
            treeNode271,
            treeNode273,
            treeNode275});
            System.Windows.Forms.TreeNode treeNode277 = new System.Windows.Forms.TreeNode("Special emphasis on async consistency");
            System.Windows.Forms.TreeNode treeNode278 = new System.Windows.Forms.TreeNode("Simplified auto method for multi-player game data transfer");
            System.Windows.Forms.TreeNode treeNode279 = new System.Windows.Forms.TreeNode("LDServer and LDClient objects added", new System.Windows.Forms.TreeNode[] {
            treeNode277,
            treeNode278});
            System.Windows.Forms.TreeNode treeNode280 = new System.Windows.Forms.TreeNode("GetWidth and GetHeight methods added");
            System.Windows.Forms.TreeNode treeNode281 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode280});
            System.Windows.Forms.TreeNode treeNode282 = new System.Windows.Forms.TreeNode("Bing web search");
            System.Windows.Forms.TreeNode treeNode283 = new System.Windows.Forms.TreeNode("LDSearch", new System.Windows.Forms.TreeNode[] {
            treeNode282});
            System.Windows.Forms.TreeNode treeNode284 = new System.Windows.Forms.TreeNode("KeyDown event handled correctly for arrow keys with hidden scrollbars");
            System.Windows.Forms.TreeNode treeNode285 = new System.Windows.Forms.TreeNode("KeyScroll property added");
            System.Windows.Forms.TreeNode treeNode286 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode284,
            treeNode285});
            System.Windows.Forms.TreeNode treeNode287 = new System.Windows.Forms.TreeNode("GetLeft and GetTop methods (work while shape is animating)");
            System.Windows.Forms.TreeNode treeNode288 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode287});
            System.Windows.Forms.TreeNode treeNode289 = new System.Windows.Forms.TreeNode("SaveAs method bug fixed");
            System.Windows.Forms.TreeNode treeNode290 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode289});
            System.Windows.Forms.TreeNode treeNode291 = new System.Windows.Forms.TreeNode("Made thread-safe since often used to queue asynchronous events");
            System.Windows.Forms.TreeNode treeNode292 = new System.Windows.Forms.TreeNode("LDQueue", new System.Windows.Forms.TreeNode[] {
            treeNode291});
            System.Windows.Forms.TreeNode treeNode293 = new System.Windows.Forms.TreeNode("Version 1.0.0.125", new System.Windows.Forms.TreeNode[] {
            treeNode279,
            treeNode281,
            treeNode283,
            treeNode286,
            treeNode288,
            treeNode290,
            treeNode292});
            System.Windows.Forms.TreeNode treeNode294 = new System.Windows.Forms.TreeNode("Language translation object added");
            System.Windows.Forms.TreeNode treeNode295 = new System.Windows.Forms.TreeNode("LDTranslate", new System.Windows.Forms.TreeNode[] {
            treeNode294});
            System.Windows.Forms.TreeNode treeNode296 = new System.Windows.Forms.TreeNode("Version 1.0.0.124", new System.Windows.Forms.TreeNode[] {
            treeNode295});
            System.Windows.Forms.TreeNode treeNode297 = new System.Windows.Forms.TreeNode("Mouse screen coordinate conversion parameters added");
            System.Windows.Forms.TreeNode treeNode298 = new System.Windows.Forms.TreeNode("MouseX and MouseY added to set cursor in GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode299 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode297,
            treeNode298});
            System.Windows.Forms.TreeNode treeNode300 = new System.Windows.Forms.TreeNode("DPIX and DPIY properties added for screen resolution");
            System.Windows.Forms.TreeNode treeNode301 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode300});
            System.Windows.Forms.TreeNode treeNode302 = new System.Windows.Forms.TreeNode("Version 1.0.0.123", new System.Windows.Forms.TreeNode[] {
            treeNode299,
            treeNode301});
            System.Windows.Forms.TreeNode treeNode303 = new System.Windows.Forms.TreeNode("ColorMatrix method added");
            System.Windows.Forms.TreeNode treeNode304 = new System.Windows.Forms.TreeNode("Rotate method added");
            System.Windows.Forms.TreeNode treeNode305 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode303,
            treeNode304});
            System.Windows.Forms.TreeNode treeNode306 = new System.Windows.Forms.TreeNode("Customisable Pie, Doughnut, Bubble, Bar and Column chart control object added");
            System.Windows.Forms.TreeNode treeNode307 = new System.Windows.Forms.TreeNode("LDChart", new System.Windows.Forms.TreeNode[] {
            treeNode306});
            System.Windows.Forms.TreeNode treeNode308 = new System.Windows.Forms.TreeNode("Version 1.0.0.122", new System.Windows.Forms.TreeNode[] {
            treeNode305,
            treeNode307});
            System.Windows.Forms.TreeNode treeNode309 = new System.Windows.Forms.TreeNode("EffectGamma added to darken and lighten");
            System.Windows.Forms.TreeNode treeNode310 = new System.Windows.Forms.TreeNode("EffectFishEye, EffectBulge and EffectSwirl added");
            System.Windows.Forms.TreeNode treeNode311 = new System.Windows.Forms.TreeNode("EffectContrast modified");
            System.Windows.Forms.TreeNode treeNode312 = new System.Windows.Forms.TreeNode("GetEffects and EffectDefaults methods added to get list of effects and default pa" +
        "rameters");
            System.Windows.Forms.TreeNode treeNode313 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode309,
            treeNode310,
            treeNode311,
            treeNode312});
            System.Windows.Forms.TreeNode treeNode314 = new System.Windows.Forms.TreeNode("Error event added for all extension exceptions");
            System.Windows.Forms.TreeNode treeNode315 = new System.Windows.Forms.TreeNode("LDEvents", new System.Windows.Forms.TreeNode[] {
            treeNode314});
            System.Windows.Forms.TreeNode treeNode316 = new System.Windows.Forms.TreeNode("Hyperbolic trigonometric functions Sinh, Cosh and Tanh added");
            System.Windows.Forms.TreeNode treeNode317 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode316});
            System.Windows.Forms.TreeNode treeNode318 = new System.Windows.Forms.TreeNode("Version 1.0.0.121", new System.Windows.Forms.TreeNode[] {
            treeNode313,
            treeNode315,
            treeNode317});
            System.Windows.Forms.TreeNode treeNode319 = new System.Windows.Forms.TreeNode("FloodFill transparency effect fixed");
            System.Windows.Forms.TreeNode treeNode320 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode319});
            System.Windows.Forms.TreeNode treeNode321 = new System.Windows.Forms.TreeNode("SaveAllVariables and LoadAllVariables methods added");
            System.Windows.Forms.TreeNode treeNode322 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode321});
            System.Windows.Forms.TreeNode treeNode323 = new System.Windows.Forms.TreeNode("EffectPixelate added");
            System.Windows.Forms.TreeNode treeNode324 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode323});
            System.Windows.Forms.TreeNode treeNode325 = new System.Windows.Forms.TreeNode("Modified to work with Windows 8");
            System.Windows.Forms.TreeNode treeNode326 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode325});
            System.Windows.Forms.TreeNode treeNode327 = new System.Windows.Forms.TreeNode("Version 1.0.0.120", new System.Windows.Forms.TreeNode[] {
            treeNode320,
            treeNode322,
            treeNode324,
            treeNode326});
            System.Windows.Forms.TreeNode treeNode328 = new System.Windows.Forms.TreeNode("FloodFill method added");
            System.Windows.Forms.TreeNode treeNode329 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode328});
            System.Windows.Forms.TreeNode treeNode330 = new System.Windows.Forms.TreeNode("Version 1.0.0.119", new System.Windows.Forms.TreeNode[] {
            treeNode329});
            System.Windows.Forms.TreeNode treeNode331 = new System.Windows.Forms.TreeNode("SetShapeCursor method added");
            System.Windows.Forms.TreeNode treeNode332 = new System.Windows.Forms.TreeNode("CreateCursor method added");
            System.Windows.Forms.TreeNode treeNode333 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode331,
            treeNode332});
            System.Windows.Forms.TreeNode treeNode334 = new System.Windows.Forms.TreeNode("SaveAs method to save in different file formats");
            System.Windows.Forms.TreeNode treeNode335 = new System.Windows.Forms.TreeNode("Parameters added for some effects");
            System.Windows.Forms.TreeNode treeNode336 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode334,
            treeNode335});
            System.Windows.Forms.TreeNode treeNode337 = new System.Windows.Forms.TreeNode("Parameters added for some effects");
            System.Windows.Forms.TreeNode treeNode338 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode337});
            System.Windows.Forms.TreeNode treeNode339 = new System.Windows.Forms.TreeNode("Selected LDUtilities and LDShapes methods moved here to new object");
            System.Windows.Forms.TreeNode treeNode340 = new System.Windows.Forms.TreeNode("SetFontFromFile method added for ttf fonts");
            System.Windows.Forms.TreeNode treeNode341 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode339,
            treeNode340});
            System.Windows.Forms.TreeNode treeNode342 = new System.Windows.Forms.TreeNode("TWCapture and TWPrint moved from LDUtilities");
            System.Windows.Forms.TreeNode treeNode343 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode342});
            System.Windows.Forms.TreeNode treeNode344 = new System.Windows.Forms.TreeNode("Zip methods moved here from LDUtilities");
            System.Windows.Forms.TreeNode treeNode345 = new System.Windows.Forms.TreeNode("LDZip", new System.Windows.Forms.TreeNode[] {
            treeNode344});
            System.Windows.Forms.TreeNode treeNode346 = new System.Windows.Forms.TreeNode("Regex methods moved here from LDUtilities");
            System.Windows.Forms.TreeNode treeNode347 = new System.Windows.Forms.TreeNode("LDRegex", new System.Windows.Forms.TreeNode[] {
            treeNode346});
            System.Windows.Forms.TreeNode treeNode348 = new System.Windows.Forms.TreeNode("ListViewRowCount method added");
            System.Windows.Forms.TreeNode treeNode349 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode348});
            System.Windows.Forms.TreeNode treeNode350 = new System.Windows.Forms.TreeNode("Version 1.0.0.118", new System.Windows.Forms.TreeNode[] {
            treeNode333,
            treeNode336,
            treeNode338,
            treeNode341,
            treeNode343,
            treeNode345,
            treeNode347,
            treeNode349});
            System.Windows.Forms.TreeNode treeNode351 = new System.Windows.Forms.TreeNode("TransparentGW method added to create a fully transparent GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode352 = new System.Windows.Forms.TreeNode("TopMostGW method to set GraphicsWindow as top window");
            System.Windows.Forms.TreeNode treeNode353 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode351,
            treeNode352});
            System.Windows.Forms.TreeNode treeNode354 = new System.Windows.Forms.TreeNode("SetUserCursor method added");
            System.Windows.Forms.TreeNode treeNode355 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode354});
            System.Windows.Forms.TreeNode treeNode356 = new System.Windows.Forms.TreeNode("Version 1.0.0.117", new System.Windows.Forms.TreeNode[] {
            treeNode353,
            treeNode355});
            System.Windows.Forms.TreeNode treeNode357 = new System.Windows.Forms.TreeNode("Replacement for Version 1.0 Dictionary object that fails");
            System.Windows.Forms.TreeNode treeNode358 = new System.Windows.Forms.TreeNode("LDDictionary", new System.Windows.Forms.TreeNode[] {
            treeNode357});
            System.Windows.Forms.TreeNode treeNode359 = new System.Windows.Forms.TreeNode("Version 1.0.0.116", new System.Windows.Forms.TreeNode[] {
            treeNode358});
            System.Windows.Forms.TreeNode treeNode360 = new System.Windows.Forms.TreeNode("GetPixel method fix for SB v1.0 bug (works for background, drawing and shape laye" +
        "rs)");
            System.Windows.Forms.TreeNode treeNode361 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode360});
            System.Windows.Forms.TreeNode treeNode362 = new System.Windows.Forms.TreeNode("GetOpacity method fix for SB v1.0 bug");
            System.Windows.Forms.TreeNode treeNode363 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode362});
            System.Windows.Forms.TreeNode treeNode364 = new System.Windows.Forms.TreeNode("GridLines replaced with GridLinesX and GridLinesY");
            System.Windows.Forms.TreeNode treeNode365 = new System.Windows.Forms.TreeNode("ScaleAxisX and ScaleAxisY methods added");
            System.Windows.Forms.TreeNode treeNode366 = new System.Windows.Forms.TreeNode("AutoScale property added to revert to earlier scaling methods");
            System.Windows.Forms.TreeNode treeNode367 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode364,
            treeNode365,
            treeNode366});
            System.Windows.Forms.TreeNode treeNode368 = new System.Windows.Forms.TreeNode("Version 1.0.0.115", new System.Windows.Forms.TreeNode[] {
            treeNode361,
            treeNode363,
            treeNode367});
            System.Windows.Forms.TreeNode treeNode369 = new System.Windows.Forms.TreeNode("ListViewSetRow fixed for overwriting existing row");
            System.Windows.Forms.TreeNode treeNode370 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode369});
            System.Windows.Forms.TreeNode treeNode371 = new System.Windows.Forms.TreeNode("RemoveTurtleLines method added");
            System.Windows.Forms.TreeNode treeNode372 = new System.Windows.Forms.TreeNode("GetAllShapes method added");
            System.Windows.Forms.TreeNode treeNode373 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode371,
            treeNode372});
            System.Windows.Forms.TreeNode treeNode374 = new System.Windows.Forms.TreeNode("Odbc connection added");
            System.Windows.Forms.TreeNode treeNode375 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode374});
            System.Windows.Forms.TreeNode treeNode376 = new System.Windows.Forms.TreeNode("Version 1.0.0.114", new System.Windows.Forms.TreeNode[] {
            treeNode370,
            treeNode373,
            treeNode375});
            System.Windows.Forms.TreeNode treeNode377 = new System.Windows.Forms.TreeNode("NetworkURL property added for your own LDNetwork web server");
            System.Windows.Forms.TreeNode treeNode378 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode377});
            System.Windows.Forms.TreeNode treeNode379 = new System.Windows.Forms.TreeNode("ListView control added");
            System.Windows.Forms.TreeNode treeNode380 = new System.Windows.Forms.TreeNode("TextBoxReadOnly to set textbox to read only");
            System.Windows.Forms.TreeNode treeNode381 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode379,
            treeNode380});
            System.Windows.Forms.TreeNode treeNode382 = new System.Windows.Forms.TreeNode("Version 1.0.0.113", new System.Windows.Forms.TreeNode[] {
            treeNode378,
            treeNode381});
            System.Windows.Forms.TreeNode treeNode383 = new System.Windows.Forms.TreeNode("Tone method added");
            System.Windows.Forms.TreeNode treeNode384 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode383});
            System.Windows.Forms.TreeNode treeNode385 = new System.Windows.Forms.TreeNode("TreeViewGetData and TreeViewEdit methods added");
            System.Windows.Forms.TreeNode treeNode386 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode385});
            System.Windows.Forms.TreeNode treeNode387 = new System.Windows.Forms.TreeNode("Version 1.0.0.112", new System.Windows.Forms.TreeNode[] {
            treeNode384,
            treeNode386});
            System.Windows.Forms.TreeNode treeNode388 = new System.Windows.Forms.TreeNode("SqlServer and Access database support added");
            System.Windows.Forms.TreeNode treeNode389 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode388});
            System.Windows.Forms.TreeNode treeNode390 = new System.Windows.Forms.TreeNode("FixFlickr method added");
            System.Windows.Forms.TreeNode treeNode391 = new System.Windows.Forms.TreeNode("ShowNoShapeErrors enable or disable TextWindow errors when shape parameter not fo" +
        "und");
            System.Windows.Forms.TreeNode treeNode392 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode390,
            treeNode391});
            System.Windows.Forms.TreeNode treeNode393 = new System.Windows.Forms.TreeNode("Version 1.0.0.111", new System.Windows.Forms.TreeNode[] {
            treeNode389,
            treeNode392});
            System.Windows.Forms.TreeNode treeNode394 = new System.Windows.Forms.TreeNode("TextBoxTab method added");
            System.Windows.Forms.TreeNode treeNode395 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode394});
            System.Windows.Forms.TreeNode treeNode396 = new System.Windows.Forms.TreeNode("Version 1.0.0.110", new System.Windows.Forms.TreeNode[] {
            treeNode395});
            System.Windows.Forms.TreeNode treeNode397 = new System.Windows.Forms.TreeNode("TextWindow warning meaages for methods that are supplied with file paths that do " +
        "not exist");
            System.Windows.Forms.TreeNode treeNode398 = new System.Windows.Forms.TreeNode("File not found warnings controlled with LDUtilities ShowFileErrors");
            System.Windows.Forms.TreeNode treeNode399 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode397,
            treeNode398});
            System.Windows.Forms.TreeNode treeNode400 = new System.Windows.Forms.TreeNode("Exists method added to check if a file path exists or not");
            System.Windows.Forms.TreeNode treeNode401 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode400});
            System.Windows.Forms.TreeNode treeNode402 = new System.Windows.Forms.TreeNode("Start method handles attaching to existing process without warning");
            System.Windows.Forms.TreeNode treeNode403 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode402});
            System.Windows.Forms.TreeNode treeNode404 = new System.Windows.Forms.TreeNode("MySQL database support added");
            System.Windows.Forms.TreeNode treeNode405 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode404});
            System.Windows.Forms.TreeNode treeNode406 = new System.Windows.Forms.TreeNode("Add and Multiply methods honour transparency");
            System.Windows.Forms.TreeNode treeNode407 = new System.Windows.Forms.TreeNode("R, G, B truncated to 0 to 255 for Add, Multiply, AddImages, and Abs for Differenc" +
        "eImages");
            System.Windows.Forms.TreeNode treeNode408 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode406,
            treeNode407});
            System.Windows.Forms.TreeNode treeNode409 = new System.Windows.Forms.TreeNode("Version 1.0.0.109", new System.Windows.Forms.TreeNode[] {
            treeNode399,
            treeNode401,
            treeNode403,
            treeNode405,
            treeNode408});
            System.Windows.Forms.TreeNode treeNode410 = new System.Windows.Forms.TreeNode("Show and Hide (fix for SB v1.0 bug)");
            System.Windows.Forms.TreeNode treeNode411 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode410});
            System.Windows.Forms.TreeNode treeNode412 = new System.Windows.Forms.TreeNode("Version 1.0.0.108", new System.Windows.Forms.TreeNode[] {
            treeNode411});
            System.Windows.Forms.TreeNode treeNode413 = new System.Windows.Forms.TreeNode("Transparent colour added");
            System.Windows.Forms.TreeNode treeNode414 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode413});
            System.Windows.Forms.TreeNode treeNode415 = new System.Windows.Forms.TreeNode("Dialogs always appear in front of GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode416 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode415});
            System.Windows.Forms.TreeNode treeNode417 = new System.Windows.Forms.TreeNode("Version 1.0.0.107", new System.Windows.Forms.TreeNode[] {
            treeNode414,
            treeNode416});
            System.Windows.Forms.TreeNode treeNode418 = new System.Windows.Forms.TreeNode("Improvements to Menu control (colouring, separators and check state)");
            System.Windows.Forms.TreeNode treeNode419 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode418});
            System.Windows.Forms.TreeNode treeNode420 = new System.Windows.Forms.TreeNode("SetShapeEvent added GotFocus and LostFocus events");
            System.Windows.Forms.TreeNode treeNode421 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode420});
            System.Windows.Forms.TreeNode treeNode422 = new System.Windows.Forms.TreeNode("Version 1.0.0.106", new System.Windows.Forms.TreeNode[] {
            treeNode419,
            treeNode421});
            System.Windows.Forms.TreeNode treeNode423 = new System.Windows.Forms.TreeNode("Menu control added");
            System.Windows.Forms.TreeNode treeNode424 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode423});
            System.Windows.Forms.TreeNode treeNode425 = new System.Windows.Forms.TreeNode("Version 1.0.0.105", new System.Windows.Forms.TreeNode[] {
            treeNode424});
            System.Windows.Forms.TreeNode treeNode426 = new System.Windows.Forms.TreeNode("ZipList method added");
            System.Windows.Forms.TreeNode treeNode427 = new System.Windows.Forms.TreeNode("GetNextMapIndex method added");
            System.Windows.Forms.TreeNode treeNode428 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode426,
            treeNode427});
            System.Windows.Forms.TreeNode treeNode429 = new System.Windows.Forms.TreeNode("GetColour method added (gets Brush, Pen and Opacity)");
            System.Windows.Forms.TreeNode treeNode430 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode429});
            System.Windows.Forms.TreeNode treeNode431 = new System.Windows.Forms.TreeNode("Version 1.0.0.104", new System.Windows.Forms.TreeNode[] {
            treeNode428,
            treeNode430});
            System.Windows.Forms.TreeNode treeNode432 = new System.Windows.Forms.TreeNode("Transparency maintained for various methods");
            System.Windows.Forms.TreeNode treeNode433 = new System.Windows.Forms.TreeNode("Effects bug fixed");
            System.Windows.Forms.TreeNode treeNode434 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode432,
            treeNode433});
            System.Windows.Forms.TreeNode treeNode435 = new System.Windows.Forms.TreeNode("Version 1.0.0.103", new System.Windows.Forms.TreeNode[] {
            treeNode434});
            System.Windows.Forms.TreeNode treeNode436 = new System.Windows.Forms.TreeNode("Current application assemblies are all auto-referenced");
            System.Windows.Forms.TreeNode treeNode437 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode436});
            System.Windows.Forms.TreeNode treeNode438 = new System.Windows.Forms.TreeNode("Version 1.0.0.102", new System.Windows.Forms.TreeNode[] {
            treeNode437});
            System.Windows.Forms.TreeNode treeNode439 = new System.Windows.Forms.TreeNode("Include C# or VB methods, properties and events to compile and call from your Sma" +
        "llBasic code");
            System.Windows.Forms.TreeNode treeNode440 = new System.Windows.Forms.TreeNode("LDInline.sb sample provided");
            System.Windows.Forms.TreeNode treeNode441 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode439,
            treeNode440});
            System.Windows.Forms.TreeNode treeNode442 = new System.Windows.Forms.TreeNode("ExitButtonMode method added to control window close button state");
            System.Windows.Forms.TreeNode treeNode443 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode442});
            System.Windows.Forms.TreeNode treeNode444 = new System.Windows.Forms.TreeNode("Version 1.0.0.101", new System.Windows.Forms.TreeNode[] {
            treeNode441,
            treeNode443});
            System.Windows.Forms.TreeNode treeNode445 = new System.Windows.Forms.TreeNode("Read and ReadNumber methods added (with a delay before auto return)");
            System.Windows.Forms.TreeNode treeNode446 = new System.Windows.Forms.TreeNode("KeyDown, KeyUp and SendKey (low level keyboard control) added");
            System.Windows.Forms.TreeNode treeNode447 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode445,
            treeNode446});
            System.Windows.Forms.TreeNode treeNode448 = new System.Windows.Forms.TreeNode("Version 1.0.0.100", new System.Windows.Forms.TreeNode[] {
            treeNode447});
            System.Windows.Forms.TreeNode treeNode449 = new System.Windows.Forms.TreeNode("ReadANSIToArray method added");
            System.Windows.Forms.TreeNode treeNode450 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode449});
            System.Windows.Forms.TreeNode treeNode451 = new System.Windows.Forms.TreeNode("DocumentViewer control added");
            System.Windows.Forms.TreeNode treeNode452 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode451});
            System.Windows.Forms.TreeNode treeNode453 = new System.Windows.Forms.TreeNode("An object to batch update shapes (for speed reasons)");
            System.Windows.Forms.TreeNode treeNode454 = new System.Windows.Forms.TreeNode("LDFastShapes.sb sample included");
            System.Windows.Forms.TreeNode treeNode455 = new System.Windows.Forms.TreeNode("LDFastShapes", new System.Windows.Forms.TreeNode[] {
            treeNode453,
            treeNode454});
            System.Windows.Forms.TreeNode treeNode456 = new System.Windows.Forms.TreeNode("Version 1.0.0.99", new System.Windows.Forms.TreeNode[] {
            treeNode450,
            treeNode452,
            treeNode455});
            System.Windows.Forms.TreeNode treeNode457 = new System.Windows.Forms.TreeNode("Rendering performance improvements when many shapes present");
            System.Windows.Forms.TreeNode treeNode458 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode457});
            System.Windows.Forms.TreeNode treeNode459 = new System.Windows.Forms.TreeNode("ANSItoUTF8 method added");
            System.Windows.Forms.TreeNode treeNode460 = new System.Windows.Forms.TreeNode("ReadANSI method added");
            System.Windows.Forms.TreeNode treeNode461 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode459,
            treeNode460});
            System.Windows.Forms.TreeNode treeNode462 = new System.Windows.Forms.TreeNode("Version 1.0.0.98", new System.Windows.Forms.TreeNode[] {
            treeNode458,
            treeNode461});
            System.Windows.Forms.TreeNode treeNode463 = new System.Windows.Forms.TreeNode("Move method added for tiangles, polygons and lines");
            System.Windows.Forms.TreeNode treeNode464 = new System.Windows.Forms.TreeNode("RotateAbout method added");
            System.Windows.Forms.TreeNode treeNode465 = new System.Windows.Forms.TreeNode("GetLeft and GetTop methods added for triangles, polygons and lines");
            System.Windows.Forms.TreeNode treeNode466 = new System.Windows.Forms.TreeNode("SetTurtleImage repositioning \'hot spot\' on resize fixed");
            System.Windows.Forms.TreeNode treeNode467 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode463,
            treeNode464,
            treeNode465,
            treeNode466});
            System.Windows.Forms.TreeNode treeNode468 = new System.Windows.Forms.TreeNode("Version 1.0.0.97", new System.Windows.Forms.TreeNode[] {
            treeNode467});
            System.Windows.Forms.TreeNode treeNode469 = new System.Windows.Forms.TreeNode("A list storage object added");
            System.Windows.Forms.TreeNode treeNode470 = new System.Windows.Forms.TreeNode("LDList", new System.Windows.Forms.TreeNode[] {
            treeNode469});
            System.Windows.Forms.TreeNode treeNode471 = new System.Windows.Forms.TreeNode("Version 1.0.0.96", new System.Windows.Forms.TreeNode[] {
            treeNode470});
            System.Windows.Forms.TreeNode treeNode472 = new System.Windows.Forms.TreeNode("A queue (first-in first-out) storage similar to a stack object added");
            System.Windows.Forms.TreeNode treeNode473 = new System.Windows.Forms.TreeNode("LDQueue", new System.Windows.Forms.TreeNode[] {
            treeNode472});
            System.Windows.Forms.TreeNode treeNode474 = new System.Windows.Forms.TreeNode("Fix for multi-dimensional arrays using GetGameData and SetGameData");
            System.Windows.Forms.TreeNode treeNode475 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode474});
            System.Windows.Forms.TreeNode treeNode476 = new System.Windows.Forms.TreeNode("Returned arrays with \\= or ; in index or value correctly handled");
            System.Windows.Forms.TreeNode treeNode477 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode476});
            System.Windows.Forms.TreeNode treeNode478 = new System.Windows.Forms.TreeNode("Version 1.0.0.95", new System.Windows.Forms.TreeNode[] {
            treeNode473,
            treeNode475,
            treeNode477});
            System.Windows.Forms.TreeNode treeNode479 = new System.Windows.Forms.TreeNode("SHA512Hash and MD5HashFile methods added");
            System.Windows.Forms.TreeNode treeNode480 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode479});
            System.Windows.Forms.TreeNode treeNode481 = new System.Windows.Forms.TreeNode("RandomNumberSeed property added");
            System.Windows.Forms.TreeNode treeNode482 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode481});
            System.Windows.Forms.TreeNode treeNode483 = new System.Windows.Forms.TreeNode("SetGameData and GetGameData methods added");
            System.Windows.Forms.TreeNode treeNode484 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode483});
            System.Windows.Forms.TreeNode treeNode485 = new System.Windows.Forms.TreeNode("Version 1.0.0.94", new System.Windows.Forms.TreeNode[] {
            treeNode480,
            treeNode482,
            treeNode484});
            System.Windows.Forms.TreeNode treeNode486 = new System.Windows.Forms.TreeNode("SliderGetValue method added");
            System.Windows.Forms.TreeNode treeNode487 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode486});
            System.Windows.Forms.TreeNode treeNode488 = new System.Windows.Forms.TreeNode("UnZip now works with most zip formats, not just those created with LDUtilities.Zi" +
        "p");
            System.Windows.Forms.TreeNode treeNode489 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode488});
            System.Windows.Forms.TreeNode treeNode490 = new System.Windows.Forms.TreeNode("Encrypt and Decrypt methods added");
            System.Windows.Forms.TreeNode treeNode491 = new System.Windows.Forms.TreeNode("MD5Hash method added");
            System.Windows.Forms.TreeNode treeNode492 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode490,
            treeNode491});
            System.Windows.Forms.TreeNode treeNode493 = new System.Windows.Forms.TreeNode("Version 1.0.0.93", new System.Windows.Forms.TreeNode[] {
            treeNode487,
            treeNode489,
            treeNode492});
            System.Windows.Forms.TreeNode treeNode494 = new System.Windows.Forms.TreeNode("ProgressBar, Slider and PasswordBox controls added");
            System.Windows.Forms.TreeNode treeNode495 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode494});
            System.Windows.Forms.TreeNode treeNode496 = new System.Windows.Forms.TreeNode("Version 1.0.0.92", new System.Windows.Forms.TreeNode[] {
            treeNode495});
            System.Windows.Forms.TreeNode treeNode497 = new System.Windows.Forms.TreeNode("TreeViewGetSelected, ListBoxGetSelected, ComboBoxGetSelected, CheckBoxGetState an" +
        "d RadioButtonGet methods added");
            System.Windows.Forms.TreeNode treeNode498 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode497});
            System.Windows.Forms.TreeNode treeNode499 = new System.Windows.Forms.TreeNode("Version 1.0.0.91", new System.Windows.Forms.TreeNode[] {
            treeNode498});
            System.Windows.Forms.TreeNode treeNode500 = new System.Windows.Forms.TreeNode("Font method added to modify shapes or controls that have text");
            System.Windows.Forms.TreeNode treeNode501 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode500});
            System.Windows.Forms.TreeNode treeNode502 = new System.Windows.Forms.TreeNode("MediaPlayer control added (play videos etc)");
            System.Windows.Forms.TreeNode treeNode503 = new System.Windows.Forms.TreeNode("ListBoxContent, TreeViewContent and ComboBoxContent methods added to change list " +
        "contents");
            System.Windows.Forms.TreeNode treeNode504 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode502,
            treeNode503});
            System.Windows.Forms.TreeNode treeNode505 = new System.Windows.Forms.TreeNode("Version 1.0.0.90", new System.Windows.Forms.TreeNode[] {
            treeNode501,
            treeNode504});
            System.Windows.Forms.TreeNode treeNode506 = new System.Windows.Forms.TreeNode("Autosize columns for ListView");
            System.Windows.Forms.TreeNode treeNode507 = new System.Windows.Forms.TreeNode("LDDataBase.sb sample updated");
            System.Windows.Forms.TreeNode treeNode508 = new System.Windows.Forms.TreeNode("Optionally return array of results for query (GetRecord removed)");
            System.Windows.Forms.TreeNode treeNode509 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode506,
            treeNode507,
            treeNode508});
            System.Windows.Forms.TreeNode treeNode510 = new System.Windows.Forms.TreeNode("Version 1.0.0.89", new System.Windows.Forms.TreeNode[] {
            treeNode509});
            System.Windows.Forms.TreeNode treeNode511 = new System.Windows.Forms.TreeNode("GraphicsWindow.MouseDown works for any event subroutine name");
            System.Windows.Forms.TreeNode treeNode512 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode511});
            System.Windows.Forms.TreeNode treeNode513 = new System.Windows.Forms.TreeNode("CleanTemp method added");
            System.Windows.Forms.TreeNode treeNode514 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode513});
            System.Windows.Forms.TreeNode treeNode515 = new System.Windows.Forms.TreeNode("SQLite database methods added");
            System.Windows.Forms.TreeNode treeNode516 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode515});
            System.Windows.Forms.TreeNode treeNode517 = new System.Windows.Forms.TreeNode("Version 1.0.0.88", new System.Windows.Forms.TreeNode[] {
            treeNode512,
            treeNode514,
            treeNode516});
            System.Windows.Forms.TreeNode treeNode518 = new System.Windows.Forms.TreeNode("LastError now returns a text error");
            System.Windows.Forms.TreeNode treeNode519 = new System.Windows.Forms.TreeNode("LDIOWarrior", new System.Windows.Forms.TreeNode[] {
            treeNode518});
            System.Windows.Forms.TreeNode treeNode520 = new System.Windows.Forms.TreeNode("MouseDown (must be named \"OnMouseDown\") and MouseWheel events fixed");
            System.Windows.Forms.TreeNode treeNode521 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode520});
            System.Windows.Forms.TreeNode treeNode522 = new System.Windows.Forms.TreeNode("Version 1.0.0.87", new System.Windows.Forms.TreeNode[] {
            treeNode519,
            treeNode521});
            System.Windows.Forms.TreeNode treeNode523 = new System.Windows.Forms.TreeNode("SetTurtleImage method added");
            System.Windows.Forms.TreeNode treeNode524 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode523});
            System.Windows.Forms.TreeNode treeNode525 = new System.Windows.Forms.TreeNode("Connect to IOWarrior USB devices");
            System.Windows.Forms.TreeNode treeNode526 = new System.Windows.Forms.TreeNode("http://www.codemercs.com/io-warrior/?L=1");
            System.Windows.Forms.TreeNode treeNode527 = new System.Windows.Forms.TreeNode("LDIOWarrior", new System.Windows.Forms.TreeNode[] {
            treeNode525,
            treeNode526});
            System.Windows.Forms.TreeNode treeNode528 = new System.Windows.Forms.TreeNode("Version 1.0.0.86", new System.Windows.Forms.TreeNode[] {
            treeNode524,
            treeNode527});
            System.Windows.Forms.TreeNode treeNode529 = new System.Windows.Forms.TreeNode("PenColour, BrushColour and BrushGradientShape applied to most Shapes and Controls" +
        "");
            System.Windows.Forms.TreeNode treeNode530 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode529});
            System.Windows.Forms.TreeNode treeNode531 = new System.Windows.Forms.TreeNode("Version 1.0.0.85", new System.Windows.Forms.TreeNode[] {
            treeNode530});
            System.Windows.Forms.TreeNode treeNode532 = new System.Windows.Forms.TreeNode("GetFolder, GetFile and GetExtension methods added");
            System.Windows.Forms.TreeNode treeNode533 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode532});
            System.Windows.Forms.TreeNode treeNode534 = new System.Windows.Forms.TreeNode("Crop method added");
            System.Windows.Forms.TreeNode treeNode535 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode534});
            System.Windows.Forms.TreeNode treeNode536 = new System.Windows.Forms.TreeNode("LastDropFiles bug fixed");
            System.Windows.Forms.TreeNode treeNode537 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode536});
            System.Windows.Forms.TreeNode treeNode538 = new System.Windows.Forms.TreeNode("Version 1.0.0.84", new System.Windows.Forms.TreeNode[] {
            treeNode533,
            treeNode535,
            treeNode537});
            System.Windows.Forms.TreeNode treeNode539 = new System.Windows.Forms.TreeNode("FileDropped event added");
            System.Windows.Forms.TreeNode treeNode540 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode539});
            System.Windows.Forms.TreeNode treeNode541 = new System.Windows.Forms.TreeNode("Bug in Split corrected");
            System.Windows.Forms.TreeNode treeNode542 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode541});
            System.Windows.Forms.TreeNode treeNode543 = new System.Windows.Forms.TreeNode("Version 1.0.0.83", new System.Windows.Forms.TreeNode[] {
            treeNode540,
            treeNode542});
            System.Windows.Forms.TreeNode treeNode544 = new System.Windows.Forms.TreeNode("Title argument removed from AddComboBox");
            System.Windows.Forms.TreeNode treeNode545 = new System.Windows.Forms.TreeNode("AllowDrop method added (for TextBox, RichTextBox, Image and Background)");
            System.Windows.Forms.TreeNode treeNode546 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode544,
            treeNode545});
            System.Windows.Forms.TreeNode treeNode547 = new System.Windows.Forms.TreeNode("Version 1.0.0.82", new System.Windows.Forms.TreeNode[] {
            treeNode546});
            System.Windows.Forms.TreeNode treeNode548 = new System.Windows.Forms.TreeNode("German xml updated (Thanks to Pappa Lapub)");
            System.Windows.Forms.TreeNode treeNode549 = new System.Windows.Forms.TreeNode("Program settings added");
            System.Windows.Forms.TreeNode treeNode550 = new System.Windows.Forms.TreeNode("LDSettings", new System.Windows.Forms.TreeNode[] {
            treeNode549});
            System.Windows.Forms.TreeNode treeNode551 = new System.Windows.Forms.TreeNode("Get some system paths and user name");
            System.Windows.Forms.TreeNode treeNode552 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode551});
            System.Windows.Forms.TreeNode treeNode553 = new System.Windows.Forms.TreeNode("System sounds added");
            System.Windows.Forms.TreeNode treeNode554 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode553});
            System.Windows.Forms.TreeNode treeNode555 = new System.Windows.Forms.TreeNode("Binary, octal, hex and decimal conversions");
            System.Windows.Forms.TreeNode treeNode556 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode555});
            System.Windows.Forms.TreeNode treeNode557 = new System.Windows.Forms.TreeNode("Replace method added");
            System.Windows.Forms.TreeNode treeNode558 = new System.Windows.Forms.TreeNode("FindAll method added");
            System.Windows.Forms.TreeNode treeNode559 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode557,
            treeNode558});
            System.Windows.Forms.TreeNode treeNode560 = new System.Windows.Forms.TreeNode("Version 1.0.0.81", new System.Windows.Forms.TreeNode[] {
            treeNode548,
            treeNode550,
            treeNode552,
            treeNode554,
            treeNode556,
            treeNode559});
            System.Windows.Forms.TreeNode treeNode561 = new System.Windows.Forms.TreeNode("BrushColour, BrushGradientShape and PenColour implemented for buttons");
            System.Windows.Forms.TreeNode treeNode562 = new System.Windows.Forms.TreeNode("General events for shapes added (see ShapeEvents sample)");
            System.Windows.Forms.TreeNode treeNode563 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode561,
            treeNode562});
            System.Windows.Forms.TreeNode treeNode564 = new System.Windows.Forms.TreeNode("Truncate method added");
            System.Windows.Forms.TreeNode treeNode565 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode564});
            System.Windows.Forms.TreeNode treeNode566 = new System.Windows.Forms.TreeNode("Additional text methods");
            System.Windows.Forms.TreeNode treeNode567 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode566});
            System.Windows.Forms.TreeNode treeNode568 = new System.Windows.Forms.TreeNode("Version 1.0.0.80", new System.Windows.Forms.TreeNode[] {
            treeNode563,
            treeNode565,
            treeNode567});
            System.Windows.Forms.TreeNode treeNode569 = new System.Windows.Forms.TreeNode("Confirm dialog message box (Yes, No, Cancel) added");
            System.Windows.Forms.TreeNode treeNode570 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode569});
            System.Windows.Forms.TreeNode treeNode571 = new System.Windows.Forms.TreeNode("CancelClose property added for GraphicsWindow closure");
            System.Windows.Forms.TreeNode treeNode572 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode571});
            System.Windows.Forms.TreeNode treeNode573 = new System.Windows.Forms.TreeNode("Version 1.0.0.79", new System.Windows.Forms.TreeNode[] {
            treeNode570,
            treeNode572});
            System.Windows.Forms.TreeNode treeNode574 = new System.Windows.Forms.TreeNode("Rasterize property added");
            System.Windows.Forms.TreeNode treeNode575 = new System.Windows.Forms.TreeNode("Improvements associated with window resizing");
            System.Windows.Forms.TreeNode treeNode576 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode574,
            treeNode575});
            System.Windows.Forms.TreeNode treeNode577 = new System.Windows.Forms.TreeNode("ExitOnClose property (and GWClosing event) added");
            System.Windows.Forms.TreeNode treeNode578 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode577});
            System.Windows.Forms.TreeNode treeNode579 = new System.Windows.Forms.TreeNode("Version 1.0.0.78", new System.Windows.Forms.TreeNode[] {
            treeNode576,
            treeNode578});
            System.Windows.Forms.TreeNode treeNode580 = new System.Windows.Forms.TreeNode("Handle more than 100 drawables (rasterization)");
            System.Windows.Forms.TreeNode treeNode581 = new System.Windows.Forms.TreeNode("LDScollBars", new System.Windows.Forms.TreeNode[] {
            treeNode580});
            System.Windows.Forms.TreeNode treeNode582 = new System.Windows.Forms.TreeNode("Version 1.0.0.77", new System.Windows.Forms.TreeNode[] {
            treeNode581});
            System.Windows.Forms.TreeNode treeNode583 = new System.Windows.Forms.TreeNode("Record sound from a microphone");
            System.Windows.Forms.TreeNode treeNode584 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode583});
            System.Windows.Forms.TreeNode treeNode585 = new System.Windows.Forms.TreeNode("AnimateOpacity method added (flashing)");
            System.Windows.Forms.TreeNode treeNode586 = new System.Windows.Forms.TreeNode("AnimateRotation method added (continuous rotation)");
            System.Windows.Forms.TreeNode treeNode587 = new System.Windows.Forms.TreeNode("AnimateZoom method added (coninuous zooming)");
            System.Windows.Forms.TreeNode treeNode588 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode585,
            treeNode586,
            treeNode587});
            System.Windows.Forms.TreeNode treeNode589 = new System.Windows.Forms.TreeNode("Version 1.0.0.76", new System.Windows.Forms.TreeNode[] {
            treeNode584,
            treeNode588});
            System.Windows.Forms.TreeNode treeNode590 = new System.Windows.Forms.TreeNode("AddAnimatedImage can use an ImageList image");
            System.Windows.Forms.TreeNode treeNode591 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode590});
            System.Windows.Forms.TreeNode treeNode592 = new System.Windows.Forms.TreeNode("Version 1.0.0.75", new System.Windows.Forms.TreeNode[] {
            treeNode591});
            System.Windows.Forms.TreeNode treeNode593 = new System.Windows.Forms.TreeNode("Initial graph axes scaling improvement");
            System.Windows.Forms.TreeNode treeNode594 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode593});
            System.Windows.Forms.TreeNode treeNode595 = new System.Windows.Forms.TreeNode("Methods to access a bluetooth device");
            System.Windows.Forms.TreeNode treeNode596 = new System.Windows.Forms.TreeNode("Includes simple file transfer and potentially advanced device interaction");
            System.Windows.Forms.TreeNode treeNode597 = new System.Windows.Forms.TreeNode("LDBlueTooth", new System.Windows.Forms.TreeNode[] {
            treeNode595,
            treeNode596});
            System.Windows.Forms.TreeNode treeNode598 = new System.Windows.Forms.TreeNode("getFocus handles multiple LDWindows");
            System.Windows.Forms.TreeNode treeNode599 = new System.Windows.Forms.TreeNode("LDFocus", new System.Windows.Forms.TreeNode[] {
            treeNode598});
            System.Windows.Forms.TreeNode treeNode600 = new System.Windows.Forms.TreeNode("Version 1.0.0.74", new System.Windows.Forms.TreeNode[] {
            treeNode594,
            treeNode597,
            treeNode599});
            System.Windows.Forms.TreeNode treeNode601 = new System.Windows.Forms.TreeNode("First pass at a generic USB (HID) device controller");
            System.Windows.Forms.TreeNode treeNode602 = new System.Windows.Forms.TreeNode("LDHID", new System.Windows.Forms.TreeNode[] {
            treeNode601});
            System.Windows.Forms.TreeNode treeNode603 = new System.Windows.Forms.TreeNode("Version 1.0.0.73", new System.Windows.Forms.TreeNode[] {
            treeNode602});
            System.Windows.Forms.TreeNode treeNode604 = new System.Windows.Forms.TreeNode("Initial scaling doesn\'t position points touching the axes");
            System.Windows.Forms.TreeNode treeNode605 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode604});
            System.Windows.Forms.TreeNode treeNode606 = new System.Windows.Forms.TreeNode("Version 1.0.0.72", new System.Windows.Forms.TreeNode[] {
            treeNode605});
            System.Windows.Forms.TreeNode treeNode607 = new System.Windows.Forms.TreeNode("TrendCoef method added to get polynomial trend line coefficients");
            System.Windows.Forms.TreeNode treeNode608 = new System.Windows.Forms.TreeNode("TrendPointCount property added to control the number of points on a trend line");
            System.Windows.Forms.TreeNode treeNode609 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode607,
            treeNode608});
            System.Windows.Forms.TreeNode treeNode610 = new System.Windows.Forms.TreeNode("Version 1.0.0.71", new System.Windows.Forms.TreeNode[] {
            treeNode609});
            System.Windows.Forms.TreeNode treeNode611 = new System.Windows.Forms.TreeNode("Spurious error message fixed");
            System.Windows.Forms.TreeNode treeNode612 = new System.Windows.Forms.TreeNode("CreateTrend data series creation method added");
            System.Windows.Forms.TreeNode treeNode613 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode611,
            treeNode612});
            System.Windows.Forms.TreeNode treeNode614 = new System.Windows.Forms.TreeNode("Version 1.0.0.70", new System.Windows.Forms.TreeNode[] {
            treeNode613});
            System.Windows.Forms.TreeNode treeNode615 = new System.Windows.Forms.TreeNode("Font properties and colours set for LDControls in the same way as standard Contro" +
        "ls");
            System.Windows.Forms.TreeNode treeNode616 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode615});
            System.Windows.Forms.TreeNode treeNode617 = new System.Windows.Forms.TreeNode("Version 1.0.0.69", new System.Windows.Forms.TreeNode[] {
            treeNode616});
            System.Windows.Forms.TreeNode treeNode618 = new System.Windows.Forms.TreeNode("Radio button control added");
            System.Windows.Forms.TreeNode treeNode619 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode618});
            System.Windows.Forms.TreeNode treeNode620 = new System.Windows.Forms.TreeNode("Version 1.0.0.68", new System.Windows.Forms.TreeNode[] {
            treeNode619});
            System.Windows.Forms.TreeNode treeNode621 = new System.Windows.Forms.TreeNode("Bug fix for Copy");
            System.Windows.Forms.TreeNode treeNode622 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode621});
            System.Windows.Forms.TreeNode treeNode623 = new System.Windows.Forms.TreeNode("Version 1.0.0.67", new System.Windows.Forms.TreeNode[] {
            treeNode622});
            System.Windows.Forms.TreeNode treeNode624 = new System.Windows.Forms.TreeNode("RegexMatch and RegexReplace methods added");
            System.Windows.Forms.TreeNode treeNode625 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode624});
            System.Windows.Forms.TreeNode treeNode626 = new System.Windows.Forms.TreeNode("Version 1.0.0.66", new System.Windows.Forms.TreeNode[] {
            treeNode625});
            System.Windows.Forms.TreeNode treeNode627 = new System.Windows.Forms.TreeNode("Number culture conversions added");
            System.Windows.Forms.TreeNode treeNode628 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode627});
            System.Windows.Forms.TreeNode treeNode629 = new System.Windows.Forms.TreeNode("Version 1.0.0.65", new System.Windows.Forms.TreeNode[] {
            treeNode628});
            System.Windows.Forms.TreeNode treeNode630 = new System.Windows.Forms.TreeNode("IsNumber method added");
            System.Windows.Forms.TreeNode treeNode631 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode630});
            System.Windows.Forms.TreeNode treeNode632 = new System.Windows.Forms.TreeNode("Version 1.0.0.64", new System.Windows.Forms.TreeNode[] {
            treeNode631});
            System.Windows.Forms.TreeNode treeNode633 = new System.Windows.Forms.TreeNode("SetCursorPosition method added for textboxes");
            System.Windows.Forms.TreeNode treeNode634 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode633});
            System.Windows.Forms.TreeNode treeNode635 = new System.Windows.Forms.TreeNode("Version 1.0.0.63", new System.Windows.Forms.TreeNode[] {
            treeNode634});
            System.Windows.Forms.TreeNode treeNode636 = new System.Windows.Forms.TreeNode("SetCursorToEnd method added for textboxes");
            System.Windows.Forms.TreeNode treeNode637 = new System.Windows.Forms.TreeNode("SetSpellCheck method added for textboxes and richtextboxes");
            System.Windows.Forms.TreeNode treeNode638 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode636,
            treeNode637});
            System.Windows.Forms.TreeNode treeNode639 = new System.Windows.Forms.TreeNode("Version 1.0.0.62", new System.Windows.Forms.TreeNode[] {
            treeNode638});
            System.Windows.Forms.TreeNode treeNode640 = new System.Windows.Forms.TreeNode("Adding polygons not located at (0,0) corrected");
            System.Windows.Forms.TreeNode treeNode641 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode640});
            System.Windows.Forms.TreeNode treeNode642 = new System.Windows.Forms.TreeNode("Version 1.0.0.61", new System.Windows.Forms.TreeNode[] {
            treeNode641});
            System.Windows.Forms.TreeNode treeNode643 = new System.Windows.Forms.TreeNode("GetFolder dialog added");
            System.Windows.Forms.TreeNode treeNode644 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode643});
            System.Windows.Forms.TreeNode treeNode645 = new System.Windows.Forms.TreeNode("Version 1.0.0.60", new System.Windows.Forms.TreeNode[] {
            treeNode644});
            System.Windows.Forms.TreeNode treeNode646 = new System.Windows.Forms.TreeNode("Possible localization issue with Font size fixed");
            System.Windows.Forms.TreeNode treeNode647 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode646});
            System.Windows.Forms.TreeNode treeNode648 = new System.Windows.Forms.TreeNode("Version 1.0.0.59", new System.Windows.Forms.TreeNode[] {
            treeNode647});
            System.Windows.Forms.TreeNode treeNode649 = new System.Windows.Forms.TreeNode("More internationalization fixes");
            System.Windows.Forms.TreeNode treeNode650 = new System.Windows.Forms.TreeNode("ShowPrintPreview property added");
            System.Windows.Forms.TreeNode treeNode651 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode650});
            System.Windows.Forms.TreeNode treeNode652 = new System.Windows.Forms.TreeNode("Possible error with gradient drawings fixed");
            System.Windows.Forms.TreeNode treeNode653 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode652});
            System.Windows.Forms.TreeNode treeNode654 = new System.Windows.Forms.TreeNode("Possible Listen event initialisation error fixed");
            System.Windows.Forms.TreeNode treeNode655 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode654});
            System.Windows.Forms.TreeNode treeNode656 = new System.Windows.Forms.TreeNode("Version 1.0.0.58", new System.Windows.Forms.TreeNode[] {
            treeNode649,
            treeNode651,
            treeNode653,
            treeNode655});
            System.Windows.Forms.TreeNode treeNode657 = new System.Windows.Forms.TreeNode("Many possible internationisation issues fixed");
            System.Windows.Forms.TreeNode treeNode658 = new System.Windows.Forms.TreeNode("Version 1.0.0.57", new System.Windows.Forms.TreeNode[] {
            treeNode657});
            System.Windows.Forms.TreeNode treeNode659 = new System.Windows.Forms.TreeNode("Emmisive colour correction for AddGeometry");
            System.Windows.Forms.TreeNode treeNode660 = new System.Windows.Forms.TreeNode("Geometry coordinates etc are now colon or space deminiated (not comma)");
            System.Windows.Forms.TreeNode treeNode661 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode659,
            treeNode660});
            System.Windows.Forms.TreeNode treeNode662 = new System.Windows.Forms.TreeNode("CSVdeminiator property added");
            System.Windows.Forms.TreeNode treeNode663 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode662});
            System.Windows.Forms.TreeNode treeNode664 = new System.Windows.Forms.TreeNode("Version 1.0.0.56", new System.Windows.Forms.TreeNode[] {
            treeNode661,
            treeNode663});
            System.Windows.Forms.TreeNode treeNode665 = new System.Windows.Forms.TreeNode("Improved error reporting");
            System.Windows.Forms.TreeNode treeNode666 = new System.Windows.Forms.TreeNode("Culture invariant type conversions");
            System.Windows.Forms.TreeNode treeNode667 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode666});
            System.Windows.Forms.TreeNode treeNode668 = new System.Windows.Forms.TreeNode("ShowErrors method added");
            System.Windows.Forms.TreeNode treeNode669 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode668});
            System.Windows.Forms.TreeNode treeNode670 = new System.Windows.Forms.TreeNode("Version 1.0.0.55", new System.Windows.Forms.TreeNode[] {
            treeNode665,
            treeNode667,
            treeNode669});
            System.Windows.Forms.TreeNode treeNode671 = new System.Windows.Forms.TreeNode("Warning added to intellisense help about  resizing GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode672 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode671});
            System.Windows.Forms.TreeNode treeNode673 = new System.Windows.Forms.TreeNode("GWWidth and GWHeight added for use with LDScrollBars");
            System.Windows.Forms.TreeNode treeNode674 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode673});
            System.Windows.Forms.TreeNode treeNode675 = new System.Windows.Forms.TreeNode("Version 1.0.0.54", new System.Windows.Forms.TreeNode[] {
            treeNode672,
            treeNode674});
            System.Windows.Forms.TreeNode treeNode676 = new System.Windows.Forms.TreeNode("Debug window can be resized");
            System.Windows.Forms.TreeNode treeNode677 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode676});
            System.Windows.Forms.TreeNode treeNode678 = new System.Windows.Forms.TreeNode("PrintFile method added");
            System.Windows.Forms.TreeNode treeNode679 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode678});
            System.Windows.Forms.TreeNode treeNode680 = new System.Windows.Forms.TreeNode("Version 1.0.0.53", new System.Windows.Forms.TreeNode[] {
            treeNode677,
            treeNode679});
            System.Windows.Forms.TreeNode treeNode681 = new System.Windows.Forms.TreeNode("SSL property option added");
            System.Windows.Forms.TreeNode treeNode682 = new System.Windows.Forms.TreeNode("LDEmail", new System.Windows.Forms.TreeNode[] {
            treeNode681});
            System.Windows.Forms.TreeNode treeNode683 = new System.Windows.Forms.TreeNode("Version 1.0.0.52", new System.Windows.Forms.TreeNode[] {
            treeNode682});
            System.Windows.Forms.TreeNode treeNode684 = new System.Windows.Forms.TreeNode("Right Click Context menu added for any shape or control");
            System.Windows.Forms.TreeNode treeNode685 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode684});
            System.Windows.Forms.TreeNode treeNode686 = new System.Windows.Forms.TreeNode("Version 1.0.0.51", new System.Windows.Forms.TreeNode[] {
            treeNode685});
            System.Windows.Forms.TreeNode treeNode687 = new System.Windows.Forms.TreeNode("Right click dropdown menu option added");
            System.Windows.Forms.TreeNode treeNode688 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode687});
            System.Windows.Forms.TreeNode treeNode689 = new System.Windows.Forms.TreeNode("Version 1.0.0.50", new System.Windows.Forms.TreeNode[] {
            treeNode688});
            System.Windows.Forms.TreeNode treeNode690 = new System.Windows.Forms.TreeNode("More methods added, AddSphere, AddTube, ReverseNormals");
            System.Windows.Forms.TreeNode treeNode691 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode690});
            System.Windows.Forms.TreeNode treeNode692 = new System.Windows.Forms.TreeNode("Version 1.0.0.49", new System.Windows.Forms.TreeNode[] {
            treeNode691});
            System.Windows.Forms.TreeNode treeNode693 = new System.Windows.Forms.TreeNode("Performance improvements (some camera controls for this)");
            System.Windows.Forms.TreeNode treeNode694 = new System.Windows.Forms.TreeNode("LoadModel (*.3ds) files added");
            System.Windows.Forms.TreeNode treeNode695 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode693,
            treeNode694});
            System.Windows.Forms.TreeNode treeNode696 = new System.Windows.Forms.TreeNode("AddStar and AddRegularPolygon shape methods added");
            System.Windows.Forms.TreeNode treeNode697 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode696});
            System.Windows.Forms.TreeNode treeNode698 = new System.Windows.Forms.TreeNode("Version 1.0.0.48", new System.Windows.Forms.TreeNode[] {
            treeNode695,
            treeNode697});
            System.Windows.Forms.TreeNode treeNode699 = new System.Windows.Forms.TreeNode("Some improvements including animations");
            System.Windows.Forms.TreeNode treeNode700 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode699});
            System.Windows.Forms.TreeNode treeNode701 = new System.Windows.Forms.TreeNode("Version 1.0.0.47", new System.Windows.Forms.TreeNode[] {
            treeNode700});
            System.Windows.Forms.TreeNode treeNode702 = new System.Windows.Forms.TreeNode("Some improvemts and new methods");
            System.Windows.Forms.TreeNode treeNode703 = new System.Windows.Forms.TreeNode("LD3Dview", new System.Windows.Forms.TreeNode[] {
            treeNode702});
            System.Windows.Forms.TreeNode treeNode704 = new System.Windows.Forms.TreeNode("Version 1.0.0.46", new System.Windows.Forms.TreeNode[] {
            treeNode703});
            System.Windows.Forms.TreeNode treeNode705 = new System.Windows.Forms.TreeNode("A start at a 3D set of methods");
            System.Windows.Forms.TreeNode treeNode706 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode705});
            System.Windows.Forms.TreeNode treeNode707 = new System.Windows.Forms.TreeNode("Version 1.0.0.45", new System.Windows.Forms.TreeNode[] {
            treeNode706});
            System.Windows.Forms.TreeNode treeNode708 = new System.Windows.Forms.TreeNode("Create scrollbars for the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode709 = new System.Windows.Forms.TreeNode("Methods to control the scrollbars allowing a scrolling game to be made");
            System.Windows.Forms.TreeNode treeNode710 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode708,
            treeNode709});
            System.Windows.Forms.TreeNode treeNode711 = new System.Windows.Forms.TreeNode("ColourList method added");
            System.Windows.Forms.TreeNode treeNode712 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode711});
            System.Windows.Forms.TreeNode treeNode713 = new System.Windows.Forms.TreeNode("Linear and radial gradient methods for shapes, drawings and background");
            System.Windows.Forms.TreeNode treeNode714 = new System.Windows.Forms.TreeNode("BackgroundImage method to set the background added");
            System.Windows.Forms.TreeNode treeNode715 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode713,
            treeNode714});
            System.Windows.Forms.TreeNode treeNode716 = new System.Windows.Forms.TreeNode("Version 1.0.0.44", new System.Windows.Forms.TreeNode[] {
            treeNode710,
            treeNode712,
            treeNode715});
            System.Windows.Forms.TreeNode treeNode717 = new System.Windows.Forms.TreeNode("AddScrollBars method added for the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode718 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode717});
            System.Windows.Forms.TreeNode treeNode719 = new System.Windows.Forms.TreeNode("Version 1.0.0.43", new System.Windows.Forms.TreeNode[] {
            treeNode718});
            System.Windows.Forms.TreeNode treeNode720 = new System.Windows.Forms.TreeNode("Call Subs as functions with arguments");
            System.Windows.Forms.TreeNode treeNode721 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode720});
            System.Windows.Forms.TreeNode treeNode722 = new System.Windows.Forms.TreeNode("Version 1.0.0.42", new System.Windows.Forms.TreeNode[] {
            treeNode721});
            System.Windows.Forms.TreeNode treeNode723 = new System.Windows.Forms.TreeNode("Font dialog added");
            System.Windows.Forms.TreeNode treeNode724 = new System.Windows.Forms.TreeNode("Colours dialog moved here from LDColours");
            System.Windows.Forms.TreeNode treeNode725 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode723,
            treeNode724});
            System.Windows.Forms.TreeNode treeNode726 = new System.Windows.Forms.TreeNode("Version 1.0.0.41", new System.Windows.Forms.TreeNode[] {
            treeNode725});
            System.Windows.Forms.TreeNode treeNode727 = new System.Windows.Forms.TreeNode("Controls methods (RichTextBox and TreeView) moved here from LDDialogs");
            System.Windows.Forms.TreeNode treeNode728 = new System.Windows.Forms.TreeNode("WebBrowser, ListBox, ComboBox and CheckBox objects added");
            System.Windows.Forms.TreeNode treeNode729 = new System.Windows.Forms.TreeNode("Some methods renamed");
            System.Windows.Forms.TreeNode treeNode730 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode727,
            treeNode728,
            treeNode729});
            System.Windows.Forms.TreeNode treeNode731 = new System.Windows.Forms.TreeNode("HighScore method move here");
            System.Windows.Forms.TreeNode treeNode732 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode731});
            System.Windows.Forms.TreeNode treeNode733 = new System.Windows.Forms.TreeNode("SetSize method added");
            System.Windows.Forms.TreeNode treeNode734 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode733});
            System.Windows.Forms.TreeNode treeNode735 = new System.Windows.Forms.TreeNode("Version 1.0.0.40", new System.Windows.Forms.TreeNode[] {
            treeNode730,
            treeNode732,
            treeNode734});
            System.Windows.Forms.TreeNode treeNode736 = new System.Windows.Forms.TreeNode("SelectTreeView method added");
            System.Windows.Forms.TreeNode treeNode737 = new System.Windows.Forms.TreeNode("A currently selected node also registers selection event when it is clicked");
            System.Windows.Forms.TreeNode treeNode738 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode736,
            treeNode737});
            System.Windows.Forms.TreeNode treeNode739 = new System.Windows.Forms.TreeNode("Simple high score web method");
            System.Windows.Forms.TreeNode treeNode740 = new System.Windows.Forms.TreeNode("LDHighScore", new System.Windows.Forms.TreeNode[] {
            treeNode739});
            System.Windows.Forms.TreeNode treeNode741 = new System.Windows.Forms.TreeNode("Version 1.0.0.39", new System.Windows.Forms.TreeNode[] {
            treeNode738,
            treeNode740});
            System.Windows.Forms.TreeNode treeNode742 = new System.Windows.Forms.TreeNode("RichTextBox methods improved");
            System.Windows.Forms.TreeNode treeNode743 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode742});
            System.Windows.Forms.TreeNode treeNode744 = new System.Windows.Forms.TreeNode("Search, Load and Save methods added");
            System.Windows.Forms.TreeNode treeNode745 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode744});
            System.Windows.Forms.TreeNode treeNode746 = new System.Windows.Forms.TreeNode("Version 1.0.0.38", new System.Windows.Forms.TreeNode[] {
            treeNode743,
            treeNode745});
            System.Windows.Forms.TreeNode treeNode747 = new System.Windows.Forms.TreeNode("Depreciated");
            System.Windows.Forms.TreeNode treeNode748 = new System.Windows.Forms.TreeNode("LDWeather", new System.Windows.Forms.TreeNode[] {
            treeNode747});
            System.Windows.Forms.TreeNode treeNode749 = new System.Windows.Forms.TreeNode("Renamed from LDTrig and some more methods added");
            System.Windows.Forms.TreeNode treeNode750 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode749});
            System.Windows.Forms.TreeNode treeNode751 = new System.Windows.Forms.TreeNode("RichTextBox method added");
            System.Windows.Forms.TreeNode treeNode752 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode751});
            System.Windows.Forms.TreeNode treeNode753 = new System.Windows.Forms.TreeNode("FontList method added");
            System.Windows.Forms.TreeNode treeNode754 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode753});
            System.Windows.Forms.TreeNode treeNode755 = new System.Windows.Forms.TreeNode("Version 1.0.0.37", new System.Windows.Forms.TreeNode[] {
            treeNode748,
            treeNode750,
            treeNode752,
            treeNode754});
            System.Windows.Forms.TreeNode treeNode756 = new System.Windows.Forms.TreeNode("Zip method extended");
            System.Windows.Forms.TreeNode treeNode757 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode756});
            System.Windows.Forms.TreeNode treeNode758 = new System.Windows.Forms.TreeNode("Version 1.0.0.36", new System.Windows.Forms.TreeNode[] {
            treeNode757});
            System.Windows.Forms.TreeNode treeNode759 = new System.Windows.Forms.TreeNode("Collapse and expand treeview nodes method added");
            System.Windows.Forms.TreeNode treeNode760 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode759});
            System.Windows.Forms.TreeNode treeNode761 = new System.Windows.Forms.TreeNode("Version 1.0.0.35", new System.Windows.Forms.TreeNode[] {
            treeNode760});
            System.Windows.Forms.TreeNode treeNode762 = new System.Windows.Forms.TreeNode("Arguments added to Start method");
            System.Windows.Forms.TreeNode treeNode763 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode762});
            System.Windows.Forms.TreeNode treeNode764 = new System.Windows.Forms.TreeNode("Zip compression methods added");
            System.Windows.Forms.TreeNode treeNode765 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode764});
            System.Windows.Forms.TreeNode treeNode766 = new System.Windows.Forms.TreeNode("Version 1.0.0.34", new System.Windows.Forms.TreeNode[] {
            treeNode763,
            treeNode765});
            System.Windows.Forms.TreeNode treeNode767 = new System.Windows.Forms.TreeNode("GWStyle property added");
            System.Windows.Forms.TreeNode treeNode768 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode767});
            System.Windows.Forms.TreeNode treeNode769 = new System.Windows.Forms.TreeNode("TreeView and associated events added");
            System.Windows.Forms.TreeNode treeNode770 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode769});
            System.Windows.Forms.TreeNode treeNode771 = new System.Windows.Forms.TreeNode("Version 1.0.0.33", new System.Windows.Forms.TreeNode[] {
            treeNode768,
            treeNode770});
            System.Windows.Forms.TreeNode treeNode772 = new System.Windows.Forms.TreeNode("Possible end points not plotting bug fixed");
            System.Windows.Forms.TreeNode treeNode773 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode772});
            System.Windows.Forms.TreeNode treeNode774 = new System.Windows.Forms.TreeNode("Version 1.0.0.32", new System.Windows.Forms.TreeNode[] {
            treeNode773});
            System.Windows.Forms.TreeNode treeNode775 = new System.Windows.Forms.TreeNode("Activated event and Active property addded");
            System.Windows.Forms.TreeNode treeNode776 = new System.Windows.Forms.TreeNode("LDWindows", new System.Windows.Forms.TreeNode[] {
            treeNode775});
            System.Windows.Forms.TreeNode treeNode777 = new System.Windows.Forms.TreeNode("Version 1.0.0.31", new System.Windows.Forms.TreeNode[] {
            treeNode776});
            System.Windows.Forms.TreeNode treeNode778 = new System.Windows.Forms.TreeNode("Create multiple GraphicsWindows");
            System.Windows.Forms.TreeNode treeNode779 = new System.Windows.Forms.TreeNode("LDWindows", new System.Windows.Forms.TreeNode[] {
            treeNode778});
            System.Windows.Forms.TreeNode treeNode780 = new System.Windows.Forms.TreeNode("Version 1.0.0.30", new System.Windows.Forms.TreeNode[] {
            treeNode779});
            System.Windows.Forms.TreeNode treeNode781 = new System.Windows.Forms.TreeNode("Email sending method");
            System.Windows.Forms.TreeNode treeNode782 = new System.Windows.Forms.TreeNode("LDMail", new System.Windows.Forms.TreeNode[] {
            treeNode781});
            System.Windows.Forms.TreeNode treeNode783 = new System.Windows.Forms.TreeNode("Add and Multiply methods bug fixed");
            System.Windows.Forms.TreeNode treeNode784 = new System.Windows.Forms.TreeNode("Image statistics combined into one method");
            System.Windows.Forms.TreeNode treeNode785 = new System.Windows.Forms.TreeNode("Histogram method added");
            System.Windows.Forms.TreeNode treeNode786 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode783,
            treeNode784,
            treeNode785});
            System.Windows.Forms.TreeNode treeNode787 = new System.Windows.Forms.TreeNode("Version 1.0.0.29", new System.Windows.Forms.TreeNode[] {
            treeNode782,
            treeNode786});
            System.Windows.Forms.TreeNode treeNode788 = new System.Windows.Forms.TreeNode("SnapshotToImageList method added");
            System.Windows.Forms.TreeNode treeNode789 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode788});
            System.Windows.Forms.TreeNode treeNode790 = new System.Windows.Forms.TreeNode("ImageList image manipulation methods");
            System.Windows.Forms.TreeNode treeNode791 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode790});
            System.Windows.Forms.TreeNode treeNode792 = new System.Windows.Forms.TreeNode("Version 1.0.0.28", new System.Windows.Forms.TreeNode[] {
            treeNode789,
            treeNode791});
            System.Windows.Forms.TreeNode treeNode793 = new System.Windows.Forms.TreeNode("SortIndex bugfix for null values");
            System.Windows.Forms.TreeNode treeNode794 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode793});
            System.Windows.Forms.TreeNode treeNode795 = new System.Windows.Forms.TreeNode("SnapshotToFile bug fixed");
            System.Windows.Forms.TreeNode treeNode796 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode795});
            System.Windows.Forms.TreeNode treeNode797 = new System.Windows.Forms.TreeNode("Version 1.0.0.27", new System.Windows.Forms.TreeNode[] {
            treeNode794,
            treeNode796});
            System.Windows.Forms.TreeNode treeNode798 = new System.Windows.Forms.TreeNode("SortIndex method added");
            System.Windows.Forms.TreeNode treeNode799 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode798});
            System.Windows.Forms.TreeNode treeNode800 = new System.Windows.Forms.TreeNode("Web based weather report data added");
            System.Windows.Forms.TreeNode treeNode801 = new System.Windows.Forms.TreeNode("LDWeather", new System.Windows.Forms.TreeNode[] {
            treeNode800});
            System.Windows.Forms.TreeNode treeNode802 = new System.Windows.Forms.TreeNode("DataReceived event added");
            System.Windows.Forms.TreeNode treeNode803 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode802});
            System.Windows.Forms.TreeNode treeNode804 = new System.Windows.Forms.TreeNode("Version 1.0.0.26", new System.Windows.Forms.TreeNode[] {
            treeNode799,
            treeNode801,
            treeNode803});
            System.Windows.Forms.TreeNode treeNode805 = new System.Windows.Forms.TreeNode("Speech recognition added");
            System.Windows.Forms.TreeNode treeNode806 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode805});
            System.Windows.Forms.TreeNode treeNode807 = new System.Windows.Forms.TreeNode("Version 1.0.0.25", new System.Windows.Forms.TreeNode[] {
            treeNode806});
            System.Windows.Forms.TreeNode treeNode808 = new System.Windows.Forms.TreeNode("More methods added and some internal code optimised");
            System.Windows.Forms.TreeNode treeNode809 = new System.Windows.Forms.TreeNode("LDArray & LDMatrix", new System.Windows.Forms.TreeNode[] {
            treeNode808});
            System.Windows.Forms.TreeNode treeNode810 = new System.Windows.Forms.TreeNode("KeyDown method added");
            System.Windows.Forms.TreeNode treeNode811 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode810});
            System.Windows.Forms.TreeNode treeNode812 = new System.Windows.Forms.TreeNode("GetAllShapesAt method added");
            System.Windows.Forms.TreeNode treeNode813 = new System.Windows.Forms.TreeNode("Overlap method for ellipse and rectangle combinations added");
            System.Windows.Forms.TreeNode treeNode814 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode812,
            treeNode813});
            System.Windows.Forms.TreeNode treeNode815 = new System.Windows.Forms.TreeNode("Version 1.0.0.24", new System.Windows.Forms.TreeNode[] {
            treeNode809,
            treeNode811,
            treeNode814});
            System.Windows.Forms.TreeNode treeNode816 = new System.Windows.Forms.TreeNode("OpenFile and SaveFile dialogs added");
            System.Windows.Forms.TreeNode treeNode817 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode816});
            System.Windows.Forms.TreeNode treeNode818 = new System.Windows.Forms.TreeNode("Matrix methods, for example to solve linear equations");
            System.Windows.Forms.TreeNode treeNode819 = new System.Windows.Forms.TreeNode("LDMatrix", new System.Windows.Forms.TreeNode[] {
            treeNode818});
            System.Windows.Forms.TreeNode treeNode820 = new System.Windows.Forms.TreeNode("Version 1.0.0.23", new System.Windows.Forms.TreeNode[] {
            treeNode817,
            treeNode819});
            System.Windows.Forms.TreeNode treeNode821 = new System.Windows.Forms.TreeNode("Sorting method added");
            System.Windows.Forms.TreeNode treeNode822 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode821});
            System.Windows.Forms.TreeNode treeNode823 = new System.Windows.Forms.TreeNode("Version 1.0.0.22", new System.Windows.Forms.TreeNode[] {
            treeNode822});
            System.Windows.Forms.TreeNode treeNode824 = new System.Windows.Forms.TreeNode("Velocity Threshold setting added");
            System.Windows.Forms.TreeNode treeNode825 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode824});
            System.Windows.Forms.TreeNode treeNode826 = new System.Windows.Forms.TreeNode("Version 1.0.0.21", new System.Windows.Forms.TreeNode[] {
            treeNode825});
            System.Windows.Forms.TreeNode treeNode827 = new System.Windows.Forms.TreeNode("SetDamping method added");
            System.Windows.Forms.TreeNode treeNode828 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode827});
            System.Windows.Forms.TreeNode treeNode829 = new System.Windows.Forms.TreeNode("Version 1.0.0.20", new System.Windows.Forms.TreeNode[] {
            treeNode828});
            System.Windows.Forms.TreeNode treeNode830 = new System.Windows.Forms.TreeNode("Instrument name can be obtained from its number");
            System.Windows.Forms.TreeNode treeNode831 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode830});
            System.Windows.Forms.TreeNode treeNode832 = new System.Windows.Forms.TreeNode("Version 1.0.0.19", new System.Windows.Forms.TreeNode[] {
            treeNode831});
            System.Windows.Forms.TreeNode treeNode833 = new System.Windows.Forms.TreeNode("Calendar uses MS visual styles if available (better calendar, but no colours)");
            System.Windows.Forms.TreeNode treeNode834 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode833});
            System.Windows.Forms.TreeNode treeNode835 = new System.Windows.Forms.TreeNode("Extends Sounds.PlayMusic to include additional instruments");
            System.Windows.Forms.TreeNode treeNode836 = new System.Windows.Forms.TreeNode("Notes can also be played synchronously (chords)");
            System.Windows.Forms.TreeNode treeNode837 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode835,
            treeNode836});
            System.Windows.Forms.TreeNode treeNode838 = new System.Windows.Forms.TreeNode("Version 1.0.0.18", new System.Windows.Forms.TreeNode[] {
            treeNode834,
            treeNode837});
            System.Windows.Forms.TreeNode treeNode839 = new System.Windows.Forms.TreeNode("AnimationPause and AnimationResume methods added");
            System.Windows.Forms.TreeNode treeNode840 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode839});
            System.Windows.Forms.TreeNode treeNode841 = new System.Windows.Forms.TreeNode("Process list indexed by ID rather than name");
            System.Windows.Forms.TreeNode treeNode842 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode841});
            System.Windows.Forms.TreeNode treeNode843 = new System.Windows.Forms.TreeNode("Version 1.0.0.17", new System.Windows.Forms.TreeNode[] {
            treeNode840,
            treeNode842});
            System.Windows.Forms.TreeNode treeNode844 = new System.Windows.Forms.TreeNode("More effects added");
            System.Windows.Forms.TreeNode treeNode845 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode844});
            System.Windows.Forms.TreeNode treeNode846 = new System.Windows.Forms.TreeNode("Add or change an image on a button or image shape");
            System.Windows.Forms.TreeNode treeNode847 = new System.Windows.Forms.TreeNode("Add an animated gif or tiled image");
            System.Windows.Forms.TreeNode treeNode848 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode846,
            treeNode847});
            System.Windows.Forms.TreeNode treeNode849 = new System.Windows.Forms.TreeNode("Version 1.0.0.16", new System.Windows.Forms.TreeNode[] {
            treeNode845,
            treeNode848});
            System.Windows.Forms.TreeNode treeNode850 = new System.Windows.Forms.TreeNode("A webcam object for the GraphicsWindow, including a picture taking function");
            System.Windows.Forms.TreeNode treeNode851 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode850});
            System.Windows.Forms.TreeNode treeNode852 = new System.Windows.Forms.TreeNode("Version 1.0.0.15", new System.Windows.Forms.TreeNode[] {
            treeNode851});
            System.Windows.Forms.TreeNode treeNode853 = new System.Windows.Forms.TreeNode("Variables may be changed during a debug session");
            System.Windows.Forms.TreeNode treeNode854 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode853});
            System.Windows.Forms.TreeNode treeNode855 = new System.Windows.Forms.TreeNode("Version 1.0.0.14", new System.Windows.Forms.TreeNode[] {
            treeNode854});
            System.Windows.Forms.TreeNode treeNode856 = new System.Windows.Forms.TreeNode("A basic debugging tool");
            System.Windows.Forms.TreeNode treeNode857 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode856});
            System.Windows.Forms.TreeNode treeNode858 = new System.Windows.Forms.TreeNode("Version 1.0.0.13", new System.Windows.Forms.TreeNode[] {
            treeNode857});
            System.Windows.Forms.TreeNode treeNode859 = new System.Windows.Forms.TreeNode("Methods to convert between HSL and RGB");
            System.Windows.Forms.TreeNode treeNode860 = new System.Windows.Forms.TreeNode("Method to set colour opacity");
            System.Windows.Forms.TreeNode treeNode861 = new System.Windows.Forms.TreeNode("Methods to get R, G, B and H, S, L for a colour");
            System.Windows.Forms.TreeNode treeNode862 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode859,
            treeNode860,
            treeNode861});
            System.Windows.Forms.TreeNode treeNode863 = new System.Windows.Forms.TreeNode("Methods to add and subtract dates and times");
            System.Windows.Forms.TreeNode treeNode864 = new System.Windows.Forms.TreeNode("LDDateTime", new System.Windows.Forms.TreeNode[] {
            treeNode863});
            System.Windows.Forms.TreeNode treeNode865 = new System.Windows.Forms.TreeNode("Waiting overlay, Calendar and About popups");
            System.Windows.Forms.TreeNode treeNode866 = new System.Windows.Forms.TreeNode("Tooltips");
            System.Windows.Forms.TreeNode treeNode867 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode865,
            treeNode866});
            System.Windows.Forms.TreeNode treeNode868 = new System.Windows.Forms.TreeNode("File change event");
            System.Windows.Forms.TreeNode treeNode869 = new System.Windows.Forms.TreeNode("LDEvents", new System.Windows.Forms.TreeNode[] {
            treeNode868});
            System.Windows.Forms.TreeNode treeNode870 = new System.Windows.Forms.TreeNode("Version 1.0.0.12", new System.Windows.Forms.TreeNode[] {
            treeNode862,
            treeNode864,
            treeNode867,
            treeNode869});
            System.Windows.Forms.TreeNode treeNode871 = new System.Windows.Forms.TreeNode("Methods to sort arrays by index or value");
            System.Windows.Forms.TreeNode treeNode872 = new System.Windows.Forms.TreeNode("Sorting by number and character strings");
            System.Windows.Forms.TreeNode treeNode873 = new System.Windows.Forms.TreeNode("LDSort", new System.Windows.Forms.TreeNode[] {
            treeNode871,
            treeNode872});
            System.Windows.Forms.TreeNode treeNode874 = new System.Windows.Forms.TreeNode("Statistics on any array and distribution generation");
            System.Windows.Forms.TreeNode treeNode875 = new System.Windows.Forms.TreeNode("Includes integration and differentiation to convert between PDF and CDF");
            System.Windows.Forms.TreeNode treeNode876 = new System.Windows.Forms.TreeNode("Normal, Binomial, Traingular and Uniform distributions");
            System.Windows.Forms.TreeNode treeNode877 = new System.Windows.Forms.TreeNode("LDStatistics", new System.Windows.Forms.TreeNode[] {
            treeNode874,
            treeNode875,
            treeNode876});
            System.Windows.Forms.TreeNode treeNode878 = new System.Windows.Forms.TreeNode("Voice and volume added");
            System.Windows.Forms.TreeNode treeNode879 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode878});
            System.Windows.Forms.TreeNode treeNode880 = new System.Windows.Forms.TreeNode("Version 1.0.0.11", new System.Windows.Forms.TreeNode[] {
            treeNode873,
            treeNode877,
            treeNode879});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(16, 15);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node2";
            treeNode1.Text = "DataViewColumnWidths method added";
            treeNode2.Name = "Node3";
            treeNode2.Text = "DataViewRowColours method added";
            treeNode3.Name = "Node1";
            treeNode3.Text = "LDControls";
            treeNode4.Name = "Node1";
            treeNode4.Text = "Various obscure or experimental methods made visible to intelliseense. (LD3DView," +
    " LDBlueTooth, LDScrolBars, LDShapes)";
            treeNode5.Name = "Node0";
            treeNode5.Text = "General";
            treeNode6.Name = "Node1";
            treeNode6.Text = "SetCentre method added";
            treeNode7.Name = "Node4";
            treeNode7.Text = "A 3rd rotation added";
            treeNode8.Name = "Node3";
            treeNode8.Text = "BoundingBox method added";
            treeNode9.Name = "Node0";
            treeNode9.Text = "LD3DView";
            treeNode10.Name = "Node3";
            treeNode10.Text = "Reverted to earlier MySQL version to handle old password encryption";
            treeNode11.Name = "Node2";
            treeNode11.Text = "LDDatabase";
            treeNode12.Name = "Node1";
            treeNode12.Text = "PlayMusic2 method added";
            treeNode13.Name = "Node2";
            treeNode13.Text = "Channel parameter added";
            treeNode14.Name = "Node0";
            treeNode14.Text = "LDMusic";
            treeNode15.Name = "Node0";
            treeNode15.Text = "Version 1.2.11.0";
            treeNode16.Name = "Node1";
            treeNode16.Text = "SetButtonStyle method added";
            treeNode17.Name = "Node0";
            treeNode17.Text = "LDControls";
            treeNode18.Name = "Node1";
            treeNode18.Text = "Additional geometries added (Cube, Cone, Arrow, Revolute and Rectangle)";
            treeNode19.Name = "Node2";
            treeNode19.Text = "SetBillBoard method added";
            treeNode20.Name = "Node0";
            treeNode20.Text = "GetCameraUpDirection method added";
            treeNode21.Name = "Node1";
            treeNode21.Text = "Gradient brushes can be used";
            treeNode22.Name = "Node2";
            treeNode22.Text = "AutoControl method added";
            treeNode23.Name = "Node0";
            treeNode23.Text = "SpecularExponent property added";
            treeNode24.Name = "Node0";
            treeNode24.Text = "LD3DView";
            treeNode25.Name = "Node1";
            treeNode25.Text = "AddText method to annotate an image with text added";
            treeNode26.Name = "Node0";
            treeNode26.Text = "LDImage";
            treeNode27.Name = "Node4";
            treeNode27.Text = "BrushText for text on a brush added";
            treeNode28.Name = "Node0";
            treeNode28.Text = "Skew shapes method added";
            treeNode29.Name = "Node3";
            treeNode29.Text = "LDShapes";
            treeNode30.Name = "Node0";
            treeNode30.Text = "Version 1.2.10.0";
            treeNode31.Name = "Node1";
            treeNode31.Text = "A general purpose unit system, see LDUnits.sb sample";
            treeNode32.Name = "Node0";
            treeNode32.Text = "LDUnits";
            treeNode33.Name = "Node1";
            treeNode33.Text = "Possible issue with FixSigFig fixed";
            treeNode34.Name = "Node0";
            treeNode34.Text = "LDMath";
            treeNode35.Name = "Node3";
            treeNode35.Text = "GetIndex method added (for SB arrays)";
            treeNode36.Name = "Node2";
            treeNode36.Text = "LDArray";
            treeNode37.Name = "Node5";
            treeNode37.Text = "Resize mode property added";
            treeNode38.Name = "Node6";
            treeNode38.Text = "Icon sets SB icon if property set to \"SB\"";
            treeNode39.Name = "Node4";
            treeNode39.Text = "LDGraphicsWindow";
            treeNode40.Name = "Node8";
            treeNode40.Text = "Possible threading error with DataViewSetRow and DataViewSetValue fixed";
            treeNode41.Name = "Node9";
            treeNode41.Text = "DataViewAllowUserEntry method added";
            treeNode42.Name = "Node7";
            treeNode42.Text = "LDControls";
            treeNode43.Name = "Node0";
            treeNode43.Text = "Version 1.2.9.0";
            treeNode44.Name = "Node1";
            treeNode44.Text = "New extended math object, starting with FFT";
            treeNode45.Name = "Node0";
            treeNode45.Text = "LDMathX";
            treeNode46.Name = "Node1";
            treeNode46.Text = "AddListBox and ListBoxContent can accept LDList and LDArray data";
            treeNode47.Name = "Node0";
            treeNode47.Text = "LDControls";
            treeNode48.Name = "Node3";
            treeNode48.Text = "CreateFromIndices and CreateFromValues methods added";
            treeNode49.Name = "Node2";
            treeNode49.Text = "LDArray";
            treeNode50.Name = "Node5";
            treeNode50.Text = "CreateFromIndices and CreateFromValues methods added";
            treeNode51.Name = "Node4";
            treeNode51.Text = "LDList";
            treeNode52.Name = "Node0";
            treeNode52.Text = "Version 1.2.8.0";
            treeNode53.Name = "Node2";
            treeNode53.Text = "Error handling, additional settings and multiple ports supported";
            treeNode54.Name = "Node1";
            treeNode54.Text = "LDCommPort";
            treeNode55.Name = "Node1";
            treeNode55.Text = "Posterise, Hue, Saturation and Lightness effects added";
            treeNode56.Name = "Node1";
            treeNode56.Text = "More image effects, OilPaint, Charcoal, Sketch, Cartoon, Edge, Accent, Sepia, Noi" +
    "seRemoval and Solarise added";
            treeNode57.Name = "Node0";
            treeNode57.Text = "LDImage and LDWebCam";
            treeNode58.Name = "Node1";
            treeNode58.Text = "Bitwise operations object added";
            treeNode59.Name = "Node0";
            treeNode59.Text = "LDBits";
            treeNode60.Name = "Node1";
            treeNode60.Text = "Extended text encoding property added";
            treeNode61.Name = "Node0";
            treeNode61.Text = "TextWindow colours can be changed";
            treeNode62.Name = "Node0";
            treeNode62.Text = "LDTextWindow";
            treeNode63.Name = "Node1";
            treeNode63.Text = "GetWorkingImagePixelARGB method added";
            treeNode64.Name = "Node0";
            treeNode64.Text = "LDImage";
            treeNode65.Name = "Node1";
            treeNode65.Text = "RasteriseTurtleLines method added";
            treeNode66.Name = "Node0";
            treeNode66.Text = "LDShapes";
            treeNode67.Name = "Node0";
            treeNode67.Text = "Version 1.2.7.0";
            treeNode68.Name = "Node1";
            treeNode68.Text = "Confirm dialog is given focus above GraphicsWindow";
            treeNode69.Name = "Node0";
            treeNode69.Text = "LDDialogs";
            treeNode70.Name = "Node1";
            treeNode70.Text = "Read and write json model scripts compatible with R.U.B.E.";
            treeNode71.Name = "Node2";
            treeNode71.Text = "ToggleSensor added";
            treeNode72.Name = "Node0";
            treeNode72.Text = "LDPhysics";
            treeNode73.Name = "Node1";
            treeNode73.Text = "Allow multiple copies of the webcam image";
            treeNode74.Name = "Node0";
            treeNode74.Text = "LDWebCam";
            treeNode75.Name = "Node1";
            treeNode75.Text = "Fast pixel level image manipulation using a temporary working image added";
            treeNode76.Name = "Node0";
            treeNode76.Text = "MetaData method added";
            treeNode77.Name = "Node0";
            treeNode77.Text = "LDImage";
            treeNode78.Name = "Node0";
            treeNode78.Text = "Version 1.2.6.0";
            treeNode79.Name = "Node2";
            treeNode79.Text = "FixSigFig and FixDecimal methods added";
            treeNode80.Name = "Node3";
            treeNode80.Text = "MinNumber and MaxNumber properties added";
            treeNode81.Name = "Node1";
            treeNode81.Text = "LDMath";
            treeNode82.Name = "Node1";
            treeNode82.Text = "SliderMaximum property added";
            treeNode83.Name = "Node0";
            treeNode83.Text = "LDControls";
            treeNode84.Name = "Node1";
            treeNode84.Text = "ZoomAll method added";
            treeNode85.Name = "Node0";
            treeNode85.Text = "LDShapes";
            treeNode86.Name = "Node1";
            treeNode86.Text = "Reposition methods and properties added";
            treeNode87.Name = "Node0";
            treeNode87.Text = "LDGraphicsWindow";
            treeNode88.Name = "Node1";
            treeNode88.Text = "GetImagePixels and SetImagePixels methods added";
            treeNode89.Name = "Node0";
            treeNode89.Text = "LDImage";
            treeNode90.Name = "Node1";
            treeNode90.Text = "MouseScroll parameter added";
            treeNode91.Name = "Node0";
            treeNode91.Text = "LDScrollBars";
            treeNode92.Name = "Node0";
            treeNode92.Text = "Version 1.2.5.0";
            treeNode93.Name = "Node0";
            treeNode93.Text = "New object added (previously a separate extension)";
            treeNode94.Name = "Node1";
            treeNode94.Text = "Async, Loop, Volume and Pan properties added";
            treeNode95.Name = "Node2";
            treeNode95.Text = "PlayWave, PlayHarmonics and PlayWavFile methods added";
            treeNode96.Name = "Node1";
            treeNode96.Text = "LDWaveForm";
            treeNode97.Name = "Node1";
            treeNode97.Text = "New object added to get input from gamepads or joysticks";
            treeNode98.Name = "Node0";
            treeNode98.Text = "LDController";
            treeNode99.Name = "Node1";
            treeNode99.Text = "RayCast method added";
            treeNode100.Name = "Node0";
            treeNode100.Text = "LDPhysics";
            treeNode101.Name = "Node0";
            treeNode101.Text = "Version 1.2.4.0";
            treeNode102.Name = "Node2";
            treeNode102.Text = "New object to apply effects to any shape or control";
            treeNode103.Name = "Node1";
            treeNode103.Text = "LDEffects";
            treeNode104.Name = "Node1";
            treeNode104.Text = "New object to add arrow, arc, polygons and callout shapes";
            treeNode105.Name = "Node0";
            treeNode105.Text = "LDFigures";
            treeNode106.Name = "Node1";
            treeNode106.Text = "SetGroup method added";
            treeNode107.Name = "Node2";
            treeNode107.Text = "GetContacts method added";
            treeNode108.Name = "Node0";
            treeNode108.Text = "GetAllShapesAt method added";
            treeNode109.Name = "Node0";
            treeNode109.Text = "LDPhysics";
            treeNode110.Name = "Node2";
            treeNode110.Text = "SetImage handles images with transparency";
            treeNode111.Name = "Node0";
            treeNode111.Text = "ImageTransparency property added to switch how image transparencies are handled";
            treeNode112.Name = "Node1";
            treeNode112.Text = "LDClipboard";
            treeNode113.Name = "Node0";
            treeNode113.Text = "Version 1.2.3.0";
            treeNode114.Name = "Node2";
            treeNode114.Text = "BrushGradient can use \"R\" for radial orientation";
            treeNode115.Name = "Node1";
            treeNode115.Text = "LDShapes";
            treeNode116.Name = "Node4";
            treeNode116.Text = "Unnecessary file existance checks removed from GetFolder, GetFile and GetExtensio" +
    "n";
            treeNode117.Name = "Node3";
            treeNode117.Text = "LDFile";
            treeNode118.Name = "Node6";
            treeNode118.Text = "NewImage method added";
            treeNode119.Name = "Node5";
            treeNode119.Text = "LDImage";
            treeNode120.Name = "Node1";
            treeNode120.Text = "SetStartupPosition method added to position dialogs";
            treeNode121.Name = "Node0";
            treeNode121.Text = "LDDialogs";
            treeNode122.Name = "Node1";
            treeNode122.Text = "AddSeriesHitogram renamed AddSeriesHistogram";
            treeNode123.Name = "Node0";
            treeNode123.Text = "LDGraph";
            treeNode124.Name = "Node0";
            treeNode124.Text = "Version 1.2.2.0";
            treeNode125.Name = "Node2";
            treeNode125.Text = "Recompiled for Small Basic version 1.2";
            treeNode126.Name = "Node1";
            treeNode126.Text = "Version 1.2";
            treeNode127.Name = "Node0";
            treeNode127.Text = "Version 1.2.0.1";
            treeNode128.Name = "Node2";
            treeNode128.Text = "OpenFile and SaveFile may take an array of extensions";
            treeNode129.Name = "Node1";
            treeNode129.Text = "LDDialogs";
            treeNode130.Name = "Node1";
            treeNode130.Text = "Logical operations object added";
            treeNode131.Name = "Node0";
            treeNode131.Text = "LDLogic";
            treeNode132.Name = "Node4";
            treeNode132.Text = "CurrentCulture property added";
            treeNode133.Name = "Node3";
            treeNode133.Text = "LDUtilities";
            treeNode134.Name = "Node6";
            treeNode134.Text = "Evaluate3, a method to evaluate to a boolean added";
            treeNode135.Name = "Node5";
            treeNode135.Text = "LDMath";
            treeNode136.Name = "Node0";
            treeNode136.Text = "Version 1.1.0.8";
            treeNode137.Name = "Node1";
            treeNode137.Text = "Scrolling to selected nodes improved for dataview with custom column type (e.g.co" +
    "mbobox)";
            treeNode138.Name = "Node0";
            treeNode138.Text = "LDControls";
            treeNode139.Name = "Node1";
            treeNode139.Text = "Methods added to add and remove nodes and save xml file";
            treeNode140.Name = "Node0";
            treeNode140.Text = "LDxml";
            treeNode141.Name = "Node1";
            treeNode141.Text = "MusicPlayTime moved from LDFile";
            treeNode142.Name = "Node0";
            treeNode142.Text = "LDSound";
            treeNode143.Name = "Node0";
            treeNode143.Text = "Version 1.1.0.7";
            treeNode144.Name = "Node4";
            treeNode144.Text = "SplitImage method added";
            treeNode145.Name = "Node3";
            treeNode145.Text = "LDImage";
            treeNode146.Name = "Node6";
            treeNode146.Text = "EditTable and SaveTable methods added";
            treeNode147.Name = "Node5";
            treeNode147.Text = "LDDatabse";
            treeNode148.Name = "Node2";
            treeNode148.Text = "DataView control and methods added";
            treeNode149.Name = "Node1";
            treeNode149.Text = "LDControls";
            treeNode150.Name = "Node2";
            treeNode150.Text = "Version 1.1.0.6";
            treeNode151.Name = "Node2";
            treeNode151.Text = "Exists modified to check for directory as well as file";
            treeNode152.Name = "Node3";
            treeNode152.Text = "GetAllDirectories modified to omit directories without sufficient permissions";
            treeNode153.Name = "Node1";
            treeNode153.Text = "LDFile";
            treeNode154.Name = "Node5";
            treeNode154.Text = "Instrumenting - Index was outside the bounds of the array - bug fixed";
            treeNode155.Name = "Node6";
            treeNode155.Text = "Bug fixed returning to Small Basic IDE if application ends before debug window is" +
    " closed";
            treeNode156.Name = "Node9";
            treeNode156.Text = "Conditonal break point added";
            treeNode157.Name = "Node0";
            treeNode157.Text = "Step over button added";
            treeNode158.Name = "Node4";
            treeNode158.Text = "LDDebug";
            treeNode159.Name = "Node8";
            treeNode159.Text = "ExitOnClose works with LDWindows (multiple windows)";
            treeNode160.Name = "Node7";
            treeNode160.Text = "LDGraphicsWindow";
            treeNode161.Name = "Node1";
            treeNode161.Text = "Object added to save image, sound, file and text/varables to a resources file";
            treeNode162.Name = "Node0";
            treeNode162.Text = "LDResources";
            treeNode163.Name = "Node0";
            treeNode163.Text = "Version 1.1.0.5";
            treeNode164.Name = "Node2";
            treeNode164.Text = "ClipboardChanged event added";
            treeNode165.Name = "Node1";
            treeNode165.Text = "LDClipboard";
            treeNode166.Name = "Node1";
            treeNode166.Text = "RenameFile, RenameDirctory, CopyDirectory and GetAllDirectories methods added";
            treeNode167.Name = "Node0";
            treeNode167.Text = "LDFile";
            treeNode168.Name = "Node3";
            treeNode168.Text = "SetActive method added";
            treeNode169.Name = "Node2";
            treeNode169.Text = "LDGraphicsWindow";
            treeNode170.Name = "Node1";
            treeNode170.Text = "Parse xml file nodes";
            treeNode171.Name = "Node0";
            treeNode171.Text = "LDxml";
            treeNode172.Name = "Node3";
            treeNode172.Text = "\"FAILURE\" replaced by \"FAILED\" as a return message for consistency";
            treeNode173.Name = "Node2";
            treeNode173.Text = "General";
            treeNode174.Name = "Node0";
            treeNode174.Text = "Version 1.1.0.4";
            treeNode175.Name = "Node2";
            treeNode175.Text = "WakeAll method addded";
            treeNode176.Name = "Node1";
            treeNode176.Text = "LDPhysics";
            treeNode177.Name = "Node1";
            treeNode177.Text = "Clipboard methods added";
            treeNode178.Name = "Node0";
            treeNode178.Text = "LDClipboard";
            treeNode179.Name = "Node0";
            treeNode179.Text = "Version 1.1.0.3";
            treeNode180.Name = "Node6";
            treeNode180.Text = "SizeNWSE cursor added";
            treeNode181.Name = "Node5";
            treeNode181.Text = "LDCursors";
            treeNode182.Name = "Node8";
            treeNode182.Text = "ScaleAxisX & ScaleAxisY modified for better control";
            treeNode183.Name = "Node7";
            treeNode183.Text = "LDGraph";
            treeNode184.Name = "Node1";
            treeNode184.Text = "SQLite updated for .Net 4.5";
            treeNode185.Name = "Node0";
            treeNode185.Text = "LDDataBase";
            treeNode186.Name = "Node4";
            treeNode186.Text = "Version 1.1.0.2";
            treeNode187.Name = "Node3";
            treeNode187.Text = "Recompiled for Small Basic version 1.1";
            treeNode188.Name = "Node2";
            treeNode188.Text = "Version 1.1";
            treeNode189.Name = "Node0";
            treeNode189.Text = "Version 1.1.0.1";
            treeNode190.Name = "Node12";
            treeNode190.Text = "RichTextBoxCaseSensitive parameter added";
            treeNode191.Name = "Node13";
            treeNode191.Text = "RichTextBoxMargins method added";
            treeNode192.Name = "Node0";
            treeNode192.Text = "ListBoxSelectionMode added for multiple list box selection";
            treeNode193.Name = "Node1";
            treeNode193.Text = "ListBoxGetSelected and ListBoxSelect modified for multiple selection modes";
            treeNode194.Name = "Node11";
            treeNode194.Text = "LDControls";
            treeNode195.Name = "Node3";
            treeNode195.Text = "Error reporting added";
            treeNode196.Name = "Node4";
            treeNode196.Text = "SetEncoding method added";
            treeNode197.Name = "Node2";
            treeNode197.Text = "LDCommPort";
            treeNode198.Name = "Node6";
            treeNode198.Text = "AddSeries methods replace an existing series if the label name is the same";
            treeNode199.Name = "Node7";
            treeNode199.Text = "Export to excel fix for graph with no title";
            treeNode200.Name = "Node5";
            treeNode200.Text = "LDGraph";
            treeNode201.Name = "Node9";
            treeNode201.Text = "Negative restitution option when adding moving shape";
            treeNode202.Name = "Node8";
            treeNode202.Text = "LDPhysics";
            treeNode203.Name = "Node10";
            treeNode203.Text = "Version 1.0.0.133";
            treeNode204.Name = "Node2";
            treeNode204.Text = "Internal improvements to auto messaging";
            treeNode205.Name = "Node9";
            treeNode205.Text = "Name can be set and GetClients method added";
            treeNode206.Name = "Node1";
            treeNode206.Text = "LDClient";
            treeNode207.Name = "Node4";
            treeNode207.Text = "RichTextBoxWord method modified to include mode parameter";
            treeNode208.Name = "Node3";
            treeNode208.Text = "LDControls";
            treeNode209.Name = "Node8";
            treeNode209.Text = "Return message and possible file error fixed for Stop method";
            treeNode210.Name = "Node7";
            treeNode210.Text = "LDSound";
            treeNode211.Name = "Node0";
            treeNode211.Text = "Version 1.0.0.132";
            treeNode212.Name = "Node2";
            treeNode212.Text = "Include and CallInclude methods added to use a pre-compiled file";
            treeNode213.Name = "Node5";
            treeNode213.Text = "Compile method added to compile a Small Basic program";
            treeNode214.Name = "Node1";
            treeNode214.Text = "LDCall";
            treeNode215.Name = "Node4";
            treeNode215.Text = "Methods and code by Pappa Lapub added";
            treeNode216.Name = "Node3";
            treeNode216.Text = "LDShell";
            treeNode217.Name = "Node0";
            treeNode217.Text = "Version 1.0.0.131";
            treeNode218.Name = "Node6";
            treeNode218.Text = "FollowShapeX and FollowShapeY methods added";
            treeNode219.Name = "Node7";
            treeNode219.Text = "BoxShape method added to keep a shape with a region of the GraphicsWindow";
            treeNode220.Name = "Node8";
            treeNode220.Text = "Refactoring of all the pan, follow and box methods";
            treeNode221.Name = "Node6";
            treeNode221.Text = "All input and output coordinates are in world coordinates, apart from GetShapeAt " +
    "which is in screen coordinates";
            treeNode222.Name = "Node8";
            treeNode222.Text = "GetPan method added to convert between world and screen coordinates";
            treeNode223.Name = "Node5";
            treeNode223.Text = "LDPhysics";
            treeNode224.Name = "Node1";
            treeNode224.Text = "UseBinary property added";
            treeNode225.Name = "Node2";
            treeNode225.Text = "DoAsync property and associated completion events added";
            treeNode226.Name = "Node3";
            treeNode226.Text = "Delete method added";
            treeNode227.Name = "Node0";
            treeNode227.Text = "LDftp";
            treeNode228.Name = "Node5";
            treeNode228.Text = "CallAsync method to call any extension method asynchronously added";
            treeNode229.Name = "Node4";
            treeNode229.Text = "LDCall";
            treeNode230.Name = "Node2";
            treeNode230.Text = "SetCursorToEnd also works for RichTextBox";
            treeNode231.Name = "Node1";
            treeNode231.Text = "LDControls";
            treeNode232.Name = "Node4";
            treeNode232.Text = "Version 1.0.0.130";
            treeNode233.Name = "Node2";
            treeNode233.Text = "Evaluate2 method added to behave nicely with the TextWindow";
            treeNode234.Name = "Node1";
            treeNode234.Text = "LDMath";
            treeNode235.Name = "Node1";
            treeNode235.Text = "SetShapeGravity method to alter gravity for individual shapes";
            treeNode236.Name = "Node0";
            treeNode236.Text = "LDPhysics";
            treeNode237.Name = "Node3";
            treeNode237.Text = "Improve PauseUpdate and ResumeUpdates methods";
            treeNode238.Name = "Node2";
            treeNode238.Text = "LDGraphicsWindow";
            treeNode239.Name = "Node1";
            treeNode239.Text = "FTP object methods added";
            treeNode240.Name = "Node0";
            treeNode240.Text = "LDftp";
            treeNode241.Name = "Node3";
            treeNode241.Text = "An existing file is replaced";
            treeNode242.Name = "Node2";
            treeNode242.Text = "LDZip";
            treeNode243.Name = "Node1";
            treeNode243.Text = "Size method added";
            treeNode244.Name = "Node0";
            treeNode244.Text = "LDFile";
            treeNode245.Name = "Node3";
            treeNode245.Text = "DownloadFile method added";
            treeNode246.Name = "Node2";
            treeNode246.Text = "LDNetwork";
            treeNode247.Name = "Node0";
            treeNode247.Text = "Version 1.0.0.129";
            treeNode248.Name = "Node2";
            treeNode248.Text = "Generalised joint connections added";
            treeNode249.Name = "Node0";
            treeNode249.Text = "AddExplosion method added";
            treeNode250.Name = "Node1";
            treeNode250.Text = "LDPhysics";
            treeNode251.Name = "Node1";
            treeNode251.Text = "BrushImage method added and renamed some BrushGradient commands (old methods stil" +
    "l work but depreciated)";
            treeNode252.Name = "Node0";
            treeNode252.Text = "LDShapes";
            treeNode253.Name = "Node0";
            treeNode253.Text = "Version 1.0.0.128";
            treeNode254.Name = "Node2";
            treeNode254.Text = "CheckServer method added";
            treeNode255.Name = "Node1";
            treeNode255.Text = "LDClient";
            treeNode256.Name = "Node1";
            treeNode256.Text = "Default maximum number of objects (proxies) increased from 512 to 1024";
            treeNode257.Name = "Node2";
            treeNode257.Text = "MaxPolygonVertices and MaxProxies properties added";
            treeNode258.Name = "Node3";
            treeNode258.Text = "GetAngle method added";
            treeNode259.Name = "Node4";
            treeNode259.Text = "Top-down tire (to model a car from above) methods added";
            treeNode260.Name = "Node0";
            treeNode260.Text = "LDPhysics";
            treeNode261.Name = "Node0";
            treeNode261.Text = "Version 1.0.0.127";
            treeNode262.Name = "Node7";
            treeNode262.Text = "Bug fixes for Overlap methods";
            treeNode263.Name = "Node6";
            treeNode263.Text = "LDShapes";
            treeNode264.Name = "Node0";
            treeNode264.Text = "Bug fix for multiple numeric sorts";
            treeNode265.Name = "Node9";
            treeNode265.Text = "ByValueWithIndex method added";
            treeNode266.Name = "Node8";
            treeNode266.Text = "LDSort";
            treeNode267.Name = "Node1";
            treeNode267.Text = "LAN method added to get local IP addresses";
            treeNode268.Name = "Node2";
            treeNode268.Text = "Ping method added";
            treeNode269.Name = "Node0";
            treeNode269.Text = "LDNetwork";
            treeNode270.Name = "Node1";
            treeNode270.Text = "LoadSVG method added";
            treeNode271.Name = "Node0";
            treeNode271.Text = "LDImage";
            treeNode272.Name = "Node3";
            treeNode272.Text = "Evaluate method added";
            treeNode273.Name = "Node2";
            treeNode273.Text = "LDMath";
            treeNode274.Name = "Node5";
            treeNode274.Text = "IncludeJScript method added";
            treeNode275.Name = "Node4";
            treeNode275.Text = "LDInline";
            treeNode276.Name = "Node5";
            treeNode276.Text = "Version 1.0.0.126";
            treeNode277.Name = "Node0";
            treeNode277.Text = "Special emphasis on async consistency";
            treeNode278.Name = "Node4";
            treeNode278.Text = "Simplified auto method for multi-player game data transfer";
            treeNode279.Name = "Node9";
            treeNode279.Text = "LDServer and LDClient objects added";
            treeNode280.Name = "Node2";
            treeNode280.Text = "GetWidth and GetHeight methods added";
            treeNode281.Name = "Node1";
            treeNode281.Text = "LDText";
            treeNode282.Name = "Node4";
            treeNode282.Text = "Bing web search";
            treeNode283.Name = "Node3";
            treeNode283.Text = "LDSearch";
            treeNode284.Name = "Node6";
            treeNode284.Text = "KeyDown event handled correctly for arrow keys with hidden scrollbars";
            treeNode285.Name = "Node7";
            treeNode285.Text = "KeyScroll property added";
            treeNode286.Name = "Node5";
            treeNode286.Text = "LDScrollBars";
            treeNode287.Name = "Node9";
            treeNode287.Text = "GetLeft and GetTop methods (work while shape is animating)";
            treeNode288.Name = "Node8";
            treeNode288.Text = "LDShapes";
            treeNode289.Name = "Node1";
            treeNode289.Text = "SaveAs method bug fixed";
            treeNode290.Name = "Node0";
            treeNode290.Text = "LDImage";
            treeNode291.Name = "Node3";
            treeNode291.Text = "Made thread-safe since often used to queue asynchronous events";
            treeNode292.Name = "Node2";
            treeNode292.Text = "LDQueue";
            treeNode293.Name = "Node8";
            treeNode293.Text = "Version 1.0.0.125";
            treeNode294.Name = "Node7";
            treeNode294.Text = "Language translation object added";
            treeNode295.Name = "Node6";
            treeNode295.Text = "LDTranslate";
            treeNode296.Name = "Node5";
            treeNode296.Text = "Version 1.0.0.124";
            treeNode297.Name = "Node1";
            treeNode297.Text = "Mouse screen coordinate conversion parameters added";
            treeNode298.Name = "Node2";
            treeNode298.Text = "MouseX and MouseY added to set cursor in GraphicsWindow";
            treeNode299.Name = "Node0";
            treeNode299.Text = "LDGraphicsWindow";
            treeNode300.Name = "Node4";
            treeNode300.Text = "DPIX and DPIY properties added for screen resolution";
            treeNode301.Name = "Node3";
            treeNode301.Text = "LDUtilities";
            treeNode302.Name = "Node0";
            treeNode302.Text = "Version 1.0.0.123";
            treeNode303.Name = "Node5";
            treeNode303.Text = "ColorMatrix method added";
            treeNode304.Name = "Node0";
            treeNode304.Text = "Rotate method added";
            treeNode305.Name = "Node3";
            treeNode305.Text = "LDImage";
            treeNode306.Name = "Node1";
            treeNode306.Text = "Customisable Pie, Doughnut, Bubble, Bar and Column chart control object added";
            treeNode307.Name = "Node0";
            treeNode307.Text = "LDChart";
            treeNode308.Name = "Node2";
            treeNode308.Text = "Version 1.0.0.122";
            treeNode309.Name = "Node2";
            treeNode309.Text = "EffectGamma added to darken and lighten";
            treeNode310.Name = "Node4";
            treeNode310.Text = "EffectFishEye, EffectBulge and EffectSwirl added";
            treeNode311.Name = "Node3";
            treeNode311.Text = "EffectContrast modified";
            treeNode312.Name = "Node0";
            treeNode312.Text = "GetEffects and EffectDefaults methods added to get list of effects and default pa" +
    "rameters";
            treeNode313.Name = "Node1";
            treeNode313.Text = "LDImage";
            treeNode314.Name = "Node2";
            treeNode314.Text = "Error event added for all extension exceptions";
            treeNode315.Name = "Node1";
            treeNode315.Text = "LDEvents";
            treeNode316.Name = "Node1";
            treeNode316.Text = "Hyperbolic trigonometric functions Sinh, Cosh and Tanh added";
            treeNode317.Name = "Node0";
            treeNode317.Text = "LDMath";
            treeNode318.Name = "Node0";
            treeNode318.Text = "Version 1.0.0.121";
            treeNode319.Name = "Node2";
            treeNode319.Text = "FloodFill transparency effect fixed";
            treeNode320.Name = "Node1";
            treeNode320.Text = "LDGraphicsWindow";
            treeNode321.Name = "Node1";
            treeNode321.Text = "SaveAllVariables and LoadAllVariables methods added";
            treeNode322.Name = "Node0";
            treeNode322.Text = "LDFile";
            treeNode323.Name = "Node1";
            treeNode323.Text = "EffectPixelate added";
            treeNode324.Name = "Node0";
            treeNode324.Text = "LDImage";
            treeNode325.Name = "Node1";
            treeNode325.Text = "Modified to work with Windows 8";
            treeNode326.Name = "Node0";
            treeNode326.Text = "LDWebCam";
            treeNode327.Name = "Node0";
            treeNode327.Text = "Version 1.0.0.120";
            treeNode328.Name = "Node2";
            treeNode328.Text = "FloodFill method added";
            treeNode329.Name = "Node1";
            treeNode329.Text = "LDGraphicsWindow";
            treeNode330.Name = "Node0";
            treeNode330.Text = "Version 1.0.0.119";
            treeNode331.Name = "Node0";
            treeNode331.Text = "SetShapeCursor method added";
            treeNode332.Name = "Node11";
            treeNode332.Text = "CreateCursor method added";
            treeNode333.Name = "Node9";
            treeNode333.Text = "LDCursors";
            treeNode334.Name = "Node2";
            treeNode334.Text = "SaveAs method to save in different file formats";
            treeNode335.Name = "Node0";
            treeNode335.Text = "Parameters added for some effects";
            treeNode336.Name = "Node1";
            treeNode336.Text = "LDImage";
            treeNode337.Name = "Node2";
            treeNode337.Text = "Parameters added for some effects";
            treeNode338.Name = "Node1";
            treeNode338.Text = "LDWebCam";
            treeNode339.Name = "Node1";
            treeNode339.Text = "Selected LDUtilities and LDShapes methods moved here to new object";
            treeNode340.Name = "Node0";
            treeNode340.Text = "SetFontFromFile method added for ttf fonts";
            treeNode341.Name = "Node0";
            treeNode341.Text = "LDGraphicsWindow";
            treeNode342.Name = "Node3";
            treeNode342.Text = "TWCapture and TWPrint moved from LDUtilities";
            treeNode343.Name = "Node2";
            treeNode343.Text = "LDTextWindow";
            treeNode344.Name = "Node2";
            treeNode344.Text = "Zip methods moved here from LDUtilities";
            treeNode345.Name = "Node0";
            treeNode345.Text = "LDZip";
            treeNode346.Name = "Node3";
            treeNode346.Text = "Regex methods moved here from LDUtilities";
            treeNode347.Name = "Node1";
            treeNode347.Text = "LDRegex";
            treeNode348.Name = "Node1";
            treeNode348.Text = "ListViewRowCount method added";
            treeNode349.Name = "Node0";
            treeNode349.Text = "LDControls";
            treeNode350.Name = "Node3";
            treeNode350.Text = "Version 1.0.0.118";
            treeNode351.Name = "Node5";
            treeNode351.Text = "TransparentGW method added to create a fully transparent GraphicsWindow";
            treeNode352.Name = "Node6";
            treeNode352.Text = "TopMostGW method to set GraphicsWindow as top window";
            treeNode353.Name = "Node4";
            treeNode353.Text = "LDUtilities";
            treeNode354.Name = "Node10";
            treeNode354.Text = "SetUserCursor method added";
            treeNode355.Name = "Node4";
            treeNode355.Text = "LDCursors";
            treeNode356.Name = "Node3";
            treeNode356.Text = "Version 1.0.0.117";
            treeNode357.Name = "Node2";
            treeNode357.Text = "Replacement for Version 1.0 Dictionary object that fails";
            treeNode358.Name = "Node1";
            treeNode358.Text = "LDDictionary";
            treeNode359.Name = "Node0";
            treeNode359.Text = "Version 1.0.0.116";
            treeNode360.Name = "Node2";
            treeNode360.Text = "GetPixel method fix for SB v1.0 bug (works for background, drawing and shape laye" +
    "rs)";
            treeNode361.Name = "Node1";
            treeNode361.Text = "LDColours";
            treeNode362.Name = "Node4";
            treeNode362.Text = "GetOpacity method fix for SB v1.0 bug";
            treeNode363.Name = "Node3";
            treeNode363.Text = "LDShapes";
            treeNode364.Name = "Node1";
            treeNode364.Text = "GridLines replaced with GridLinesX and GridLinesY";
            treeNode365.Name = "Node0";
            treeNode365.Text = "ScaleAxisX and ScaleAxisY methods added";
            treeNode366.Name = "Node1";
            treeNode366.Text = "AutoScale property added to revert to earlier scaling methods";
            treeNode367.Name = "Node0";
            treeNode367.Text = "LDGraph";
            treeNode368.Name = "Node0";
            treeNode368.Text = "Version 1.0.0.115";
            treeNode369.Name = "Node2";
            treeNode369.Text = "ListViewSetRow fixed for overwriting existing row";
            treeNode370.Name = "Node1";
            treeNode370.Text = "LDControls";
            treeNode371.Name = "Node4";
            treeNode371.Text = "RemoveTurtleLines method added";
            treeNode372.Name = "Node6";
            treeNode372.Text = "GetAllShapes method added";
            treeNode373.Name = "Node3";
            treeNode373.Text = "LDShapes";
            treeNode374.Name = "Node1";
            treeNode374.Text = "Odbc connection added";
            treeNode375.Name = "Node0";
            treeNode375.Text = "LDDatabase";
            treeNode376.Name = "Node0";
            treeNode376.Text = "Version 1.0.0.114";
            treeNode377.Name = "Node2";
            treeNode377.Text = "NetworkURL property added for your own LDNetwork web server";
            treeNode378.Name = "Node1";
            treeNode378.Text = "LDUtilities";
            treeNode379.Name = "Node4";
            treeNode379.Text = "ListView control added";
            treeNode380.Name = "Node5";
            treeNode380.Text = "TextBoxReadOnly to set textbox to read only";
            treeNode381.Name = "Node3";
            treeNode381.Text = "LDControls";
            treeNode382.Name = "Node0";
            treeNode382.Text = "Version 1.0.0.113";
            treeNode383.Name = "Node2";
            treeNode383.Text = "Tone method added";
            treeNode384.Name = "Node1";
            treeNode384.Text = "LDSound";
            treeNode385.Name = "Node5";
            treeNode385.Text = "TreeViewGetData and TreeViewEdit methods added";
            treeNode386.Name = "Node4";
            treeNode386.Text = "LDControls";
            treeNode387.Name = "Node0";
            treeNode387.Text = "Version 1.0.0.112";
            treeNode388.Name = "Node2";
            treeNode388.Text = "SqlServer and Access database support added";
            treeNode389.Name = "Node1";
            treeNode389.Text = "LDDataBase";
            treeNode390.Name = "Node4";
            treeNode390.Text = "FixFlickr method added";
            treeNode391.Name = "Node0";
            treeNode391.Text = "ShowNoShapeErrors enable or disable TextWindow errors when shape parameter not fo" +
    "und";
            treeNode392.Name = "Node3";
            treeNode392.Text = "LDUtilities";
            treeNode393.Name = "Node0";
            treeNode393.Text = "Version 1.0.0.111";
            treeNode394.Name = "Node2";
            treeNode394.Text = "TextBoxTab method added";
            treeNode395.Name = "Node1";
            treeNode395.Text = "LDControls";
            treeNode396.Name = "Node0";
            treeNode396.Text = "Version 1.0.0.110";
            treeNode397.Name = "Node1";
            treeNode397.Text = "TextWindow warning meaages for methods that are supplied with file paths that do " +
    "not exist";
            treeNode398.Name = "Node3";
            treeNode398.Text = "File not found warnings controlled with LDUtilities ShowFileErrors";
            treeNode399.Name = "Node0";
            treeNode399.Text = "General";
            treeNode400.Name = "Node5";
            treeNode400.Text = "Exists method added to check if a file path exists or not";
            treeNode401.Name = "Node4";
            treeNode401.Text = "LDFile";
            treeNode402.Name = "Node7";
            treeNode402.Text = "Start method handles attaching to existing process without warning";
            treeNode403.Name = "Node6";
            treeNode403.Text = "LDProcess";
            treeNode404.Name = "Node1";
            treeNode404.Text = "MySQL database support added";
            treeNode405.Name = "Node0";
            treeNode405.Text = "LDDatabase";
            treeNode406.Name = "Node3";
            treeNode406.Text = "Add and Multiply methods honour transparency";
            treeNode407.Name = "Node4";
            treeNode407.Text = "R, G, B truncated to 0 to 255 for Add, Multiply, AddImages, and Abs for Differenc" +
    "eImages";
            treeNode408.Name = "Node2";
            treeNode408.Text = "LDImage";
            treeNode409.Name = "Node3";
            treeNode409.Text = "Version 1.0.0.109";
            treeNode410.Name = "Node2";
            treeNode410.Text = "Show and Hide (fix for SB v1.0 bug)";
            treeNode411.Name = "Node1";
            treeNode411.Text = "LDTextWindow";
            treeNode412.Name = "Node0";
            treeNode412.Text = "Version 1.0.0.108";
            treeNode413.Name = "Node14";
            treeNode413.Text = "Transparent colour added";
            treeNode414.Name = "Node13";
            treeNode414.Text = "LDColours";
            treeNode415.Name = "Node16";
            treeNode415.Text = "Dialogs always appear in front of GraphicsWindow";
            treeNode416.Name = "Node15";
            treeNode416.Text = "LDDialogs";
            treeNode417.Name = "Node12";
            treeNode417.Text = "Version 1.0.0.107";
            treeNode418.Name = "Node8";
            treeNode418.Text = "Improvements to Menu control (colouring, separators and check state)";
            treeNode419.Name = "Node7";
            treeNode419.Text = "LDControls";
            treeNode420.Name = "Node11";
            treeNode420.Text = "SetShapeEvent added GotFocus and LostFocus events";
            treeNode421.Name = "Node10";
            treeNode421.Text = "LDShapes";
            treeNode422.Name = "Node6";
            treeNode422.Text = "Version 1.0.0.106";
            treeNode423.Name = "Node5";
            treeNode423.Text = "Menu control added";
            treeNode424.Name = "Node4";
            treeNode424.Text = "LDControls";
            treeNode425.Name = "Node3";
            treeNode425.Text = "Version 1.0.0.105";
            treeNode426.Name = "Node5";
            treeNode426.Text = "ZipList method added";
            treeNode427.Name = "Node2";
            treeNode427.Text = "GetNextMapIndex method added";
            treeNode428.Name = "Node4";
            treeNode428.Text = "LDUtilities";
            treeNode429.Name = "Node1";
            treeNode429.Text = "GetColour method added (gets Brush, Pen and Opacity)";
            treeNode430.Name = "Node0";
            treeNode430.Text = "LDShapes";
            treeNode431.Name = "Node3";
            treeNode431.Text = "Version 1.0.0.104";
            treeNode432.Name = "Node1";
            treeNode432.Text = "Transparency maintained for various methods";
            treeNode433.Name = "Node2";
            treeNode433.Text = "Effects bug fixed";
            treeNode434.Name = "Node0";
            treeNode434.Text = "LDImage";
            treeNode435.Name = "Node0";
            treeNode435.Text = "Version 1.0.0.103";
            treeNode436.Name = "Node1";
            treeNode436.Text = "Current application assemblies are all auto-referenced";
            treeNode437.Name = "Node0";
            treeNode437.Text = "LDInline";
            treeNode438.Name = "Node5";
            treeNode438.Text = "Version 1.0.0.102";
            treeNode439.Name = "Node1";
            treeNode439.Text = "Include C# or VB methods, properties and events to compile and call from your Sma" +
    "llBasic code";
            treeNode440.Name = "Node2";
            treeNode440.Text = "LDInline.sb sample provided";
            treeNode441.Name = "Node0";
            treeNode441.Text = "LDInline";
            treeNode442.Name = "Node4";
            treeNode442.Text = "ExitButtonMode method added to control window close button state";
            treeNode443.Name = "Node3";
            treeNode443.Text = "LDUtilities";
            treeNode444.Name = "Node0";
            treeNode444.Text = "Version 1.0.0.101";
            treeNode445.Name = "Node1";
            treeNode445.Text = "Read and ReadNumber methods added (with a delay before auto return)";
            treeNode446.Name = "Node0";
            treeNode446.Text = "KeyDown, KeyUp and SendKey (low level keyboard control) added";
            treeNode447.Name = "Node0";
            treeNode447.Text = "LDTextWindow";
            treeNode448.Name = "Node0";
            treeNode448.Text = "Version 1.0.0.100";
            treeNode449.Name = "Node2";
            treeNode449.Text = "ReadANSIToArray method added";
            treeNode450.Name = "Node1";
            treeNode450.Text = "LDFile";
            treeNode451.Name = "Node1";
            treeNode451.Text = "DocumentViewer control added";
            treeNode452.Name = "Node0";
            treeNode452.Text = "LDControls";
            treeNode453.Name = "Node3";
            treeNode453.Text = "An object to batch update shapes (for speed reasons)";
            treeNode454.Name = "Node0";
            treeNode454.Text = "LDFastShapes.sb sample included";
            treeNode455.Name = "Node2";
            treeNode455.Text = "LDFastShapes";
            treeNode456.Name = "Node0";
            treeNode456.Text = "Version 1.0.0.99";
            treeNode457.Name = "Node1";
            treeNode457.Text = "Rendering performance improvements when many shapes present";
            treeNode458.Name = "Node0";
            treeNode458.Text = "LDPhysics";
            treeNode459.Name = "Node1";
            treeNode459.Text = "ANSItoUTF8 method added";
            treeNode460.Name = "Node2";
            treeNode460.Text = "ReadANSI method added";
            treeNode461.Name = "Node0";
            treeNode461.Text = "LDFile";
            treeNode462.Name = "Node1";
            treeNode462.Text = "Version 1.0.0.98";
            treeNode463.Name = "Node3";
            treeNode463.Text = "Move method added for tiangles, polygons and lines";
            treeNode464.Name = "Node4";
            treeNode464.Text = "RotateAbout method added";
            treeNode465.Name = "Node1";
            treeNode465.Text = "GetLeft and GetTop methods added for triangles, polygons and lines";
            treeNode466.Name = "Node0";
            treeNode466.Text = "SetTurtleImage repositioning \'hot spot\' on resize fixed";
            treeNode467.Name = "Node2";
            treeNode467.Text = "LDShapes";
            treeNode468.Name = "Node0";
            treeNode468.Text = "Version 1.0.0.97";
            treeNode469.Name = "Node4";
            treeNode469.Text = "A list storage object added";
            treeNode470.Name = "Node3";
            treeNode470.Text = "LDList";
            treeNode471.Name = "Node2";
            treeNode471.Text = "Version 1.0.0.96";
            treeNode472.Name = "Node4";
            treeNode472.Text = "A queue (first-in first-out) storage similar to a stack object added";
            treeNode473.Name = "Node3";
            treeNode473.Text = "LDQueue";
            treeNode474.Name = "Node6";
            treeNode474.Text = "Fix for multi-dimensional arrays using GetGameData and SetGameData";
            treeNode475.Name = "Node5";
            treeNode475.Text = "LDNetwork";
            treeNode476.Name = "Node0";
            treeNode476.Text = "Returned arrays with \\= or ; in index or value correctly handled";
            treeNode477.Name = "Node1";
            treeNode477.Text = "General";
            treeNode478.Name = "Node2";
            treeNode478.Text = "Version 1.0.0.95";
            treeNode479.Name = "Node2";
            treeNode479.Text = "SHA512Hash and MD5HashFile methods added";
            treeNode480.Name = "Node1";
            treeNode480.Text = "LDEncryption";
            treeNode481.Name = "Node1";
            treeNode481.Text = "RandomNumberSeed property added";
            treeNode482.Name = "Node0";
            treeNode482.Text = "LDMath";
            treeNode483.Name = "Node1";
            treeNode483.Text = "SetGameData and GetGameData methods added";
            treeNode484.Name = "Node0";
            treeNode484.Text = "LDNetwork";
            treeNode485.Name = "Node0";
            treeNode485.Text = "Version 1.0.0.94";
            treeNode486.Name = "Node1";
            treeNode486.Text = "SliderGetValue method added";
            treeNode487.Name = "Node0";
            treeNode487.Text = "LDControls";
            treeNode488.Name = "Node5";
            treeNode488.Text = "UnZip now works with most zip formats, not just those created with LDUtilities.Zi" +
    "p";
            treeNode489.Name = "Node2";
            treeNode489.Text = "LDUtilities";
            treeNode490.Name = "Node3";
            treeNode490.Text = "Encrypt and Decrypt methods added";
            treeNode491.Name = "Node4";
            treeNode491.Text = "MD5Hash method added";
            treeNode492.Name = "Node6";
            treeNode492.Text = "LDEncryption";
            treeNode493.Name = "Node0";
            treeNode493.Text = "Version 1.0.0.93";
            treeNode494.Name = "Node1";
            treeNode494.Text = "ProgressBar, Slider and PasswordBox controls added";
            treeNode495.Name = "Node0";
            treeNode495.Text = "LDControls";
            treeNode496.Name = "Node0";
            treeNode496.Text = "Version 1.0.0.92";
            treeNode497.Name = "Node2";
            treeNode497.Text = "TreeViewGetSelected, ListBoxGetSelected, ComboBoxGetSelected, CheckBoxGetState an" +
    "d RadioButtonGet methods added";
            treeNode498.Name = "Node1";
            treeNode498.Text = "LDControls";
            treeNode499.Name = "Node1";
            treeNode499.Text = "Version 1.0.0.91";
            treeNode500.Name = "Node1";
            treeNode500.Text = "Font method added to modify shapes or controls that have text";
            treeNode501.Name = "Node0";
            treeNode501.Text = "LDShapes";
            treeNode502.Name = "Node1";
            treeNode502.Text = "MediaPlayer control added (play videos etc)";
            treeNode503.Name = "Node0";
            treeNode503.Text = "ListBoxContent, TreeViewContent and ComboBoxContent methods added to change list " +
    "contents";
            treeNode504.Name = "Node0";
            treeNode504.Text = "LDControls";
            treeNode505.Name = "Node1";
            treeNode505.Text = "Version 1.0.0.90";
            treeNode506.Name = "Node1";
            treeNode506.Text = "Autosize columns for ListView";
            treeNode507.Name = "Node2";
            treeNode507.Text = "LDDataBase.sb sample updated";
            treeNode508.Name = "Node0";
            treeNode508.Text = "Optionally return array of results for query (GetRecord removed)";
            treeNode509.Name = "Node0";
            treeNode509.Text = "LDDataBase";
            treeNode510.Name = "Node0";
            treeNode510.Text = "Version 1.0.0.89";
            treeNode511.Name = "Node4";
            treeNode511.Text = "GraphicsWindow.MouseDown works for any event subroutine name";
            treeNode512.Name = "Node3";
            treeNode512.Text = "LDScrollBars";
            treeNode513.Name = "Node1";
            treeNode513.Text = "CleanTemp method added";
            treeNode514.Name = "Node0";
            treeNode514.Text = "LDUtilities";
            treeNode515.Name = "Node1";
            treeNode515.Text = "SQLite database methods added";
            treeNode516.Name = "Node0";
            treeNode516.Text = "LDDataBase";
            treeNode517.Name = "Node2";
            treeNode517.Text = "Version 1.0.0.88";
            treeNode518.Name = "Node2";
            treeNode518.Text = "LastError now returns a text error";
            treeNode519.Name = "Node1";
            treeNode519.Text = "LDIOWarrior";
            treeNode520.Name = "Node1";
            treeNode520.Text = "MouseDown (must be named \"OnMouseDown\") and MouseWheel events fixed";
            treeNode521.Name = "Node0";
            treeNode521.Text = "LDScrollBars";
            treeNode522.Name = "Node0";
            treeNode522.Text = "Version 1.0.0.87";
            treeNode523.Name = "Node4";
            treeNode523.Text = "SetTurtleImage method added";
            treeNode524.Name = "Node3";
            treeNode524.Text = "LDShapes";
            treeNode525.Name = "Node1";
            treeNode525.Text = "Connect to IOWarrior USB devices";
            treeNode526.Name = "Node0";
            treeNode526.Text = "http://www.codemercs.com/io-warrior/?L=1";
            treeNode527.Name = "Node0";
            treeNode527.Text = "LDIOWarrior";
            treeNode528.Name = "Node2";
            treeNode528.Text = "Version 1.0.0.86";
            treeNode529.Name = "Node1";
            treeNode529.Text = "PenColour, BrushColour and BrushGradientShape applied to most Shapes and Controls" +
    "";
            treeNode530.Name = "Node0";
            treeNode530.Text = "LDShapes";
            treeNode531.Name = "Node2";
            treeNode531.Text = "Version 1.0.0.85";
            treeNode532.Name = "Node4";
            treeNode532.Text = "GetFolder, GetFile and GetExtension methods added";
            treeNode533.Name = "Node3";
            treeNode533.Text = "LDFile";
            treeNode534.Name = "Node6";
            treeNode534.Text = "Crop method added";
            treeNode535.Name = "Node5";
            treeNode535.Text = "LDImage";
            treeNode536.Name = "Node1";
            treeNode536.Text = "LastDropFiles bug fixed";
            treeNode537.Name = "Node0";
            treeNode537.Text = "LDControls";
            treeNode538.Name = "Node2";
            treeNode538.Text = "Version 1.0.0.84";
            treeNode539.Name = "Node7";
            treeNode539.Text = "FileDropped event added";
            treeNode540.Name = "Node6";
            treeNode540.Text = "LDControls";
            treeNode541.Name = "Node1";
            treeNode541.Text = "Bug in Split corrected";
            treeNode542.Name = "Node0";
            treeNode542.Text = "LDText";
            treeNode543.Name = "Node5";
            treeNode543.Text = "Version 1.0.0.83";
            treeNode544.Name = "Node3";
            treeNode544.Text = "Title argument removed from AddComboBox";
            treeNode545.Name = "Node4";
            treeNode545.Text = "AllowDrop method added (for TextBox, RichTextBox, Image and Background)";
            treeNode546.Name = "Node2";
            treeNode546.Text = "LDControls";
            treeNode547.Name = "Node1";
            treeNode547.Text = "Version 1.0.0.82";
            treeNode548.Name = "Node0";
            treeNode548.Text = "German xml updated (Thanks to Pappa Lapub)";
            treeNode549.Name = "Node12";
            treeNode549.Text = "Program settings added";
            treeNode550.Name = "Node9";
            treeNode550.Text = "LDSettings";
            treeNode551.Name = "Node11";
            treeNode551.Text = "Get some system paths and user name";
            treeNode552.Name = "Node10";
            treeNode552.Text = "LDFile";
            treeNode553.Name = "Node14";
            treeNode553.Text = "System sounds added";
            treeNode554.Name = "Node13";
            treeNode554.Text = "LDSound";
            treeNode555.Name = "Node16";
            treeNode555.Text = "Binary, octal, hex and decimal conversions";
            treeNode556.Name = "Node15";
            treeNode556.Text = "LDMath";
            treeNode557.Name = "Node1";
            treeNode557.Text = "Replace method added";
            treeNode558.Name = "Node2";
            treeNode558.Text = "FindAll method added";
            treeNode559.Name = "Node0";
            treeNode559.Text = "LDText";
            treeNode560.Name = "Node8";
            treeNode560.Text = "Version 1.0.0.81";
            treeNode561.Name = "Node1";
            treeNode561.Text = "BrushColour, BrushGradientShape and PenColour implemented for buttons";
            treeNode562.Name = "Node6";
            treeNode562.Text = "General events for shapes added (see ShapeEvents sample)";
            treeNode563.Name = "Node0";
            treeNode563.Text = "LDShapes";
            treeNode564.Name = "Node3";
            treeNode564.Text = "Truncate method added";
            treeNode565.Name = "Node2";
            treeNode565.Text = "LDMath";
            treeNode566.Name = "Node5";
            treeNode566.Text = "Additional text methods";
            treeNode567.Name = "Node4";
            treeNode567.Text = "LDText";
            treeNode568.Name = "Node0";
            treeNode568.Text = "Version 1.0.0.80";
            treeNode569.Name = "Node1";
            treeNode569.Text = "Confirm dialog message box (Yes, No, Cancel) added";
            treeNode570.Name = "Node0";
            treeNode570.Text = "LDDialogs";
            treeNode571.Name = "Node1";
            treeNode571.Text = "CancelClose property added for GraphicsWindow closure";
            treeNode572.Name = "Node0";
            treeNode572.Text = "LDUtilities";
            treeNode573.Name = "Node6";
            treeNode573.Text = "Version 1.0.0.79";
            treeNode574.Name = "Node2";
            treeNode574.Text = "Rasterize property added";
            treeNode575.Name = "Node5";
            treeNode575.Text = "Improvements associated with window resizing";
            treeNode576.Name = "Node1";
            treeNode576.Text = "LDScrollBars";
            treeNode577.Name = "Node4";
            treeNode577.Text = "ExitOnClose property (and GWClosing event) added";
            treeNode578.Name = "Node3";
            treeNode578.Text = "LDUtilities";
            treeNode579.Name = "Node0";
            treeNode579.Text = "Version 1.0.0.78";
            treeNode580.Name = "Node1";
            treeNode580.Text = "Handle more than 100 drawables (rasterization)";
            treeNode581.Name = "Node0";
            treeNode581.Text = "LDScollBars";
            treeNode582.Name = "Node2";
            treeNode582.Text = "Version 1.0.0.77";
            treeNode583.Name = "Node1";
            treeNode583.Text = "Record sound from a microphone";
            treeNode584.Name = "Node0";
            treeNode584.Text = "LDSound";
            treeNode585.Name = "Node3";
            treeNode585.Text = "AnimateOpacity method added (flashing)";
            treeNode586.Name = "Node0";
            treeNode586.Text = "AnimateRotation method added (continuous rotation)";
            treeNode587.Name = "Node1";
            treeNode587.Text = "AnimateZoom method added (coninuous zooming)";
            treeNode588.Name = "Node2";
            treeNode588.Text = "LDShapes";
            treeNode589.Name = "Node2";
            treeNode589.Text = "Version 1.0.0.76";
            treeNode590.Name = "Node1";
            treeNode590.Text = "AddAnimatedImage can use an ImageList image";
            treeNode591.Name = "Node0";
            treeNode591.Text = "LDShapes";
            treeNode592.Name = "Node0";
            treeNode592.Text = "Version 1.0.0.75";
            treeNode593.Name = "Node1";
            treeNode593.Text = "Initial graph axes scaling improvement";
            treeNode594.Name = "Node0";
            treeNode594.Text = "LDGraph";
            treeNode595.Name = "Node3";
            treeNode595.Text = "Methods to access a bluetooth device";
            treeNode596.Name = "Node0";
            treeNode596.Text = "Includes simple file transfer and potentially advanced device interaction";
            treeNode597.Name = "Node2";
            treeNode597.Text = "LDBlueTooth";
            treeNode598.Name = "Node1";
            treeNode598.Text = "getFocus handles multiple LDWindows";
            treeNode599.Name = "Node0";
            treeNode599.Text = "LDFocus";
            treeNode600.Name = "Node0";
            treeNode600.Text = "Version 1.0.0.74";
            treeNode601.Name = "Node1";
            treeNode601.Text = "First pass at a generic USB (HID) device controller";
            treeNode602.Name = "Node0";
            treeNode602.Text = "LDHID";
            treeNode603.Name = "Node9";
            treeNode603.Text = "Version 1.0.0.73";
            treeNode604.Name = "Node8";
            treeNode604.Text = "Initial scaling doesn\'t position points touching the axes";
            treeNode605.Name = "Node7";
            treeNode605.Text = "LDGraph";
            treeNode606.Name = "Node6";
            treeNode606.Text = "Version 1.0.0.72";
            treeNode607.Name = "Node4";
            treeNode607.Text = "TrendCoef method added to get polynomial trend line coefficients";
            treeNode608.Name = "Node5";
            treeNode608.Text = "TrendPointCount property added to control the number of points on a trend line";
            treeNode609.Name = "Node3";
            treeNode609.Text = "LDGraph";
            treeNode610.Name = "Node2";
            treeNode610.Text = "Version 1.0.0.71";
            treeNode611.Name = "Node1";
            treeNode611.Text = "Spurious error message fixed";
            treeNode612.Name = "Node2";
            treeNode612.Text = "CreateTrend data series creation method added";
            treeNode613.Name = "Node0";
            treeNode613.Text = "LDGraph";
            treeNode614.Name = "Node2";
            treeNode614.Text = "Version 1.0.0.70";
            treeNode615.Name = "Node1";
            treeNode615.Text = "Font properties and colours set for LDControls in the same way as standard Contro" +
    "ls";
            treeNode616.Name = "Node0";
            treeNode616.Text = "LDControls";
            treeNode617.Name = "Node3";
            treeNode617.Text = "Version 1.0.0.69";
            treeNode618.Name = "Node2";
            treeNode618.Text = "Radio button control added";
            treeNode619.Name = "Node1";
            treeNode619.Text = "LDControls";
            treeNode620.Name = "Node0";
            treeNode620.Text = "Version 1.0.0.68";
            treeNode621.Name = "Node1";
            treeNode621.Text = "Bug fix for Copy";
            treeNode622.Name = "Node0";
            treeNode622.Text = "LDArray";
            treeNode623.Name = "Node2";
            treeNode623.Text = "Version 1.0.0.67";
            treeNode624.Name = "Node1";
            treeNode624.Text = "RegexMatch and RegexReplace methods added";
            treeNode625.Name = "Node0";
            treeNode625.Text = "LDUtilities";
            treeNode626.Name = "Node3";
            treeNode626.Text = "Version 1.0.0.66";
            treeNode627.Name = "Node2";
            treeNode627.Text = "Number culture conversions added";
            treeNode628.Name = "Node1";
            treeNode628.Text = "LDUtilities";
            treeNode629.Name = "Node0";
            treeNode629.Text = "Version 1.0.0.65";
            treeNode630.Name = "Node1";
            treeNode630.Text = "IsNumber method added";
            treeNode631.Name = "Node0";
            treeNode631.Text = "LDUtilities";
            treeNode632.Name = "Node2";
            treeNode632.Text = "Version 1.0.0.64";
            treeNode633.Name = "Node1";
            treeNode633.Text = "SetCursorPosition method added for textboxes";
            treeNode634.Name = "Node0";
            treeNode634.Text = "LDControls";
            treeNode635.Name = "Node4";
            treeNode635.Text = "Version 1.0.0.63";
            treeNode636.Name = "Node1";
            treeNode636.Text = "SetCursorToEnd method added for textboxes";
            treeNode637.Name = "Node3";
            treeNode637.Text = "SetSpellCheck method added for textboxes and richtextboxes";
            treeNode638.Name = "Node0";
            treeNode638.Text = "LDControls";
            treeNode639.Name = "Node2";
            treeNode639.Text = "Version 1.0.0.62";
            treeNode640.Name = "Node1";
            treeNode640.Text = "Adding polygons not located at (0,0) corrected";
            treeNode641.Name = "Node0";
            treeNode641.Text = "LDPhysics";
            treeNode642.Name = "Node2";
            treeNode642.Text = "Version 1.0.0.61";
            treeNode643.Name = "Node1";
            treeNode643.Text = "GetFolder dialog added";
            treeNode644.Name = "Node0";
            treeNode644.Text = "LDDialogs";
            treeNode645.Name = "Node0";
            treeNode645.Text = "Version 1.0.0.60";
            treeNode646.Name = "Node10";
            treeNode646.Text = "Possible localization issue with Font size fixed";
            treeNode647.Name = "Node9";
            treeNode647.Text = "LDDialogs";
            treeNode648.Name = "Node8";
            treeNode648.Text = "Version 1.0.0.59";
            treeNode649.Name = "Node3";
            treeNode649.Text = "More internationalization fixes";
            treeNode650.Name = "Node2";
            treeNode650.Text = "ShowPrintPreview property added";
            treeNode651.Name = "Node1";
            treeNode651.Text = "LDUtilities";
            treeNode652.Name = "Node5";
            treeNode652.Text = "Possible error with gradient drawings fixed";
            treeNode653.Name = "Node4";
            treeNode653.Text = "LDShapes";
            treeNode654.Name = "Node7";
            treeNode654.Text = "Possible Listen event initialisation error fixed";
            treeNode655.Name = "Node6";
            treeNode655.Text = "LDSpeech";
            treeNode656.Name = "Node0";
            treeNode656.Text = "Version 1.0.0.58";
            treeNode657.Name = "Node7";
            treeNode657.Text = "Many possible internationisation issues fixed";
            treeNode658.Name = "Node4";
            treeNode658.Text = "Version 1.0.0.57";
            treeNode659.Name = "Node1";
            treeNode659.Text = "Emmisive colour correction for AddGeometry";
            treeNode660.Name = "Node2";
            treeNode660.Text = "Geometry coordinates etc are now colon or space deminiated (not comma)";
            treeNode661.Name = "Node0";
            treeNode661.Text = "LD3DView";
            treeNode662.Name = "Node1";
            treeNode662.Text = "CSVdeminiator property added";
            treeNode663.Name = "Node0";
            treeNode663.Text = "LDUtilities";
            treeNode664.Name = "Node5";
            treeNode664.Text = "Version 1.0.0.56";
            treeNode665.Name = "Node1";
            treeNode665.Text = "Improved error reporting";
            treeNode666.Name = "Node2";
            treeNode666.Text = "Culture invariant type conversions";
            treeNode667.Name = "Node1";
            treeNode667.Text = "LD3DView";
            treeNode668.Name = "Node4";
            treeNode668.Text = "ShowErrors method added";
            treeNode669.Name = "Node3";
            treeNode669.Text = "LDUtilities";
            treeNode670.Name = "Node0";
            treeNode670.Text = "Version 1.0.0.55";
            treeNode671.Name = "Node4";
            treeNode671.Text = "Warning added to intellisense help about  resizing GraphicsWindow";
            treeNode672.Name = "Node3";
            treeNode672.Text = "LDScrollBars";
            treeNode673.Name = "Node6";
            treeNode673.Text = "GWWidth and GWHeight added for use with LDScrollBars";
            treeNode674.Name = "Node5";
            treeNode674.Text = "LDUtilities";
            treeNode675.Name = "Node2";
            treeNode675.Text = "Version 1.0.0.54";
            treeNode676.Name = "Node1";
            treeNode676.Text = "Debug window can be resized";
            treeNode677.Name = "Node0";
            treeNode677.Text = "LDDebug";
            treeNode678.Name = "Node1";
            treeNode678.Text = "PrintFile method added";
            treeNode679.Name = "Node0";
            treeNode679.Text = "LDFile";
            treeNode680.Name = "Node2";
            treeNode680.Text = "Version 1.0.0.53";
            treeNode681.Name = "Node1";
            treeNode681.Text = "SSL property option added";
            treeNode682.Name = "Node0";
            treeNode682.Text = "LDEmail";
            treeNode683.Name = "Node0";
            treeNode683.Text = "Version 1.0.0.52";
            treeNode684.Name = "Node1";
            treeNode684.Text = "Right Click Context menu added for any shape or control";
            treeNode685.Name = "Node0";
            treeNode685.Text = "LDControls";
            treeNode686.Name = "Node0";
            treeNode686.Text = "Version 1.0.0.51";
            treeNode687.Name = "Node1";
            treeNode687.Text = "Right click dropdown menu option added";
            treeNode688.Name = "Node0";
            treeNode688.Text = "LDDialogs";
            treeNode689.Name = "Node0";
            treeNode689.Text = "Version 1.0.0.50";
            treeNode690.Name = "Node1";
            treeNode690.Text = "More methods added, AddSphere, AddTube, ReverseNormals";
            treeNode691.Name = "Node0";
            treeNode691.Text = "LD3DView";
            treeNode692.Name = "Node0";
            treeNode692.Text = "Version 1.0.0.49";
            treeNode693.Name = "Node1";
            treeNode693.Text = "Performance improvements (some camera controls for this)";
            treeNode694.Name = "Node1";
            treeNode694.Text = "LoadModel (*.3ds) files added";
            treeNode695.Name = "Node0";
            treeNode695.Text = "LD3DView";
            treeNode696.Name = "Node3";
            treeNode696.Text = "AddStar and AddRegularPolygon shape methods added";
            treeNode697.Name = "Node2";
            treeNode697.Text = "LDShapes";
            treeNode698.Name = "Node0";
            treeNode698.Text = "Version 1.0.0.48";
            treeNode699.Name = "Node1";
            treeNode699.Text = "Some improvements including animations";
            treeNode700.Name = "Node0";
            treeNode700.Text = "LD3DView";
            treeNode701.Name = "Node0";
            treeNode701.Text = "Version 1.0.0.47";
            treeNode702.Name = "Node1";
            treeNode702.Text = "Some improvemts and new methods";
            treeNode703.Name = "Node0";
            treeNode703.Text = "LD3Dview";
            treeNode704.Name = "Node2";
            treeNode704.Text = "Version 1.0.0.46";
            treeNode705.Name = "Node1";
            treeNode705.Text = "A start at a 3D set of methods";
            treeNode706.Name = "Node0";
            treeNode706.Text = "LD3DView";
            treeNode707.Name = "Node10";
            treeNode707.Text = "Version 1.0.0.45";
            treeNode708.Name = "Node1";
            treeNode708.Text = "Create scrollbars for the GraphicsWindow";
            treeNode709.Name = "Node5";
            treeNode709.Text = "Methods to control the scrollbars allowing a scrolling game to be made";
            treeNode710.Name = "Node0";
            treeNode710.Text = "LDScrollBars";
            treeNode711.Name = "Node4";
            treeNode711.Text = "ColourList method added";
            treeNode712.Name = "Node3";
            treeNode712.Text = "LDUtilities";
            treeNode713.Name = "Node8";
            treeNode713.Text = "Linear and radial gradient methods for shapes, drawings and background";
            treeNode714.Name = "Node9";
            treeNode714.Text = "BackgroundImage method to set the background added";
            treeNode715.Name = "Node6";
            treeNode715.Text = "LDShapes";
            treeNode716.Name = "Node0";
            treeNode716.Text = "Version 1.0.0.44";
            treeNode717.Name = "Node1";
            treeNode717.Text = "AddScrollBars method added for the GraphicsWindow";
            treeNode718.Name = "Node0";
            treeNode718.Text = "LDUtilities";
            treeNode719.Name = "Node0";
            treeNode719.Text = "Version 1.0.0.43";
            treeNode720.Name = "Node1";
            treeNode720.Text = "Call Subs as functions with arguments";
            treeNode721.Name = "Node0";
            treeNode721.Text = "LDCall";
            treeNode722.Name = "Node0";
            treeNode722.Text = "Version 1.0.0.42";
            treeNode723.Name = "Node1";
            treeNode723.Text = "Font dialog added";
            treeNode724.Name = "Node2";
            treeNode724.Text = "Colours dialog moved here from LDColours";
            treeNode725.Name = "Node0";
            treeNode725.Text = "LDDialogs";
            treeNode726.Name = "Node9";
            treeNode726.Text = "Version 1.0.0.41";
            treeNode727.Name = "Node1";
            treeNode727.Text = "Controls methods (RichTextBox and TreeView) moved here from LDDialogs";
            treeNode728.Name = "Node7";
            treeNode728.Text = "WebBrowser, ListBox, ComboBox and CheckBox objects added";
            treeNode729.Name = "Node8";
            treeNode729.Text = "Some methods renamed";
            treeNode730.Name = "Node0";
            treeNode730.Text = "LDControls";
            treeNode731.Name = "Node3";
            treeNode731.Text = "HighScore method move here";
            treeNode732.Name = "Node2";
            treeNode732.Text = "LDNetwork";
            treeNode733.Name = "Node6";
            treeNode733.Text = "SetSize method added";
            treeNode734.Name = "Node5";
            treeNode734.Text = "LDShapes";
            treeNode735.Name = "Node3";
            treeNode735.Text = "Version 1.0.0.40";
            treeNode736.Name = "Node1";
            treeNode736.Text = "SelectTreeView method added";
            treeNode737.Name = "Node2";
            treeNode737.Text = "A currently selected node also registers selection event when it is clicked";
            treeNode738.Name = "Node0";
            treeNode738.Text = "LDDialogs";
            treeNode739.Name = "Node1";
            treeNode739.Text = "Simple high score web method";
            treeNode740.Name = "Node0";
            treeNode740.Text = "LDHighScore";
            treeNode741.Name = "Node3";
            treeNode741.Text = "Version 1.0.0.39";
            treeNode742.Name = "Node2";
            treeNode742.Text = "RichTextBox methods improved";
            treeNode743.Name = "Node1";
            treeNode743.Text = "LDDialogs";
            treeNode744.Name = "Node1";
            treeNode744.Text = "Search, Load and Save methods added";
            treeNode745.Name = "Node0";
            treeNode745.Text = "LDArray";
            treeNode746.Name = "Node0";
            treeNode746.Text = "Version 1.0.0.38";
            treeNode747.Name = "Node1";
            treeNode747.Text = "Depreciated";
            treeNode748.Name = "Node0";
            treeNode748.Text = "LDWeather";
            treeNode749.Name = "Node1";
            treeNode749.Text = "Renamed from LDTrig and some more methods added";
            treeNode750.Name = "Node0";
            treeNode750.Text = "LDMath";
            treeNode751.Name = "Node3";
            treeNode751.Text = "RichTextBox method added";
            treeNode752.Name = "Node2";
            treeNode752.Text = "LDDialogs";
            treeNode753.Name = "Node5";
            treeNode753.Text = "FontList method added";
            treeNode754.Name = "Node4";
            treeNode754.Text = "LDUtilities";
            treeNode755.Name = "Node2";
            treeNode755.Text = "Version 1.0.0.37";
            treeNode756.Name = "Node1";
            treeNode756.Text = "Zip method extended";
            treeNode757.Name = "Node0";
            treeNode757.Text = "LDUtilities";
            treeNode758.Name = "Node2";
            treeNode758.Text = "Version 1.0.0.36";
            treeNode759.Name = "Node1";
            treeNode759.Text = "Collapse and expand treeview nodes method added";
            treeNode760.Name = "Node0";
            treeNode760.Text = "LDDialogs";
            treeNode761.Name = "Node5";
            treeNode761.Text = "Version 1.0.0.35";
            treeNode762.Name = "Node1";
            treeNode762.Text = "Arguments added to Start method";
            treeNode763.Name = "Node0";
            treeNode763.Text = "LDProcess";
            treeNode764.Name = "Node4";
            treeNode764.Text = "Zip compression methods added";
            treeNode765.Name = "Node2";
            treeNode765.Text = "LDUtilities";
            treeNode766.Name = "Node2";
            treeNode766.Text = "Version 1.0.0.34";
            treeNode767.Name = "Node1";
            treeNode767.Text = "GWStyle property added";
            treeNode768.Name = "Node0";
            treeNode768.Text = "LDUtilities";
            treeNode769.Name = "Node1";
            treeNode769.Text = "TreeView and associated events added";
            treeNode770.Name = "Node0";
            treeNode770.Text = "LDDialogs";
            treeNode771.Name = "Node0";
            treeNode771.Text = "Version 1.0.0.33";
            treeNode772.Name = "Node1";
            treeNode772.Text = "Possible end points not plotting bug fixed";
            treeNode773.Name = "Node0";
            treeNode773.Text = "LDGraph";
            treeNode774.Name = "Node2";
            treeNode774.Text = "Version 1.0.0.32";
            treeNode775.Name = "Node1";
            treeNode775.Text = "Activated event and Active property addded";
            treeNode776.Name = "Node0";
            treeNode776.Text = "LDWindows";
            treeNode777.Name = "Node0";
            treeNode777.Text = "Version 1.0.0.31";
            treeNode778.Name = "Node1";
            treeNode778.Text = "Create multiple GraphicsWindows";
            treeNode779.Name = "Node0";
            treeNode779.Text = "LDWindows";
            treeNode780.Name = "Node0";
            treeNode780.Text = "Version 1.0.0.30";
            treeNode781.Name = "Node1";
            treeNode781.Text = "Email sending method";
            treeNode782.Name = "Node0";
            treeNode782.Text = "LDMail";
            treeNode783.Name = "Node1";
            treeNode783.Text = "Add and Multiply methods bug fixed";
            treeNode784.Name = "Node2";
            treeNode784.Text = "Image statistics combined into one method";
            treeNode785.Name = "Node3";
            treeNode785.Text = "Histogram method added";
            treeNode786.Name = "Node0";
            treeNode786.Text = "LDImage";
            treeNode787.Name = "Node0";
            treeNode787.Text = "Version 1.0.0.29";
            treeNode788.Name = "Node1";
            treeNode788.Text = "SnapshotToImageList method added";
            treeNode789.Name = "Node0";
            treeNode789.Text = "LDWebCam";
            treeNode790.Name = "Node3";
            treeNode790.Text = "ImageList image manipulation methods";
            treeNode791.Name = "Node2";
            treeNode791.Text = "LDImage";
            treeNode792.Name = "Node0";
            treeNode792.Text = "Version 1.0.0.28";
            treeNode793.Name = "Node1";
            treeNode793.Text = "SortIndex bugfix for null values";
            treeNode794.Name = "Node0";
            treeNode794.Text = "LDArray";
            treeNode795.Name = "Node1";
            treeNode795.Text = "SnapshotToFile bug fixed";
            treeNode796.Name = "Node0";
            treeNode796.Text = "LDWebCam";
            treeNode797.Name = "Node0";
            treeNode797.Text = "Version 1.0.0.27";
            treeNode798.Name = "Node1";
            treeNode798.Text = "SortIndex method added";
            treeNode799.Name = "Node0";
            treeNode799.Text = "LDArray";
            treeNode800.Name = "Node1";
            treeNode800.Text = "Web based weather report data added";
            treeNode801.Name = "Node0";
            treeNode801.Text = "LDWeather";
            treeNode802.Name = "Node3";
            treeNode802.Text = "DataReceived event added";
            treeNode803.Name = "Node2";
            treeNode803.Text = "LDCommPort";
            treeNode804.Name = "Node0";
            treeNode804.Text = "Version 1.0.0.26";
            treeNode805.Name = "Node1";
            treeNode805.Text = "Speech recognition added";
            treeNode806.Name = "Node0";
            treeNode806.Text = "LDSpeech";
            treeNode807.Name = "Node0";
            treeNode807.Text = "Version 1.0.0.25";
            treeNode808.Name = "Node4";
            treeNode808.Text = "More methods added and some internal code optimised";
            treeNode809.Name = "Node0";
            treeNode809.Text = "LDArray & LDMatrix";
            treeNode810.Name = "Node1";
            treeNode810.Text = "KeyDown method added";
            treeNode811.Name = "Node0";
            treeNode811.Text = "LDUtilities";
            treeNode812.Name = "Node1";
            treeNode812.Text = "GetAllShapesAt method added";
            treeNode813.Name = "Node0";
            treeNode813.Text = "Overlap method for ellipse and rectangle combinations added";
            treeNode814.Name = "Node0";
            treeNode814.Text = "LDShapes";
            treeNode815.Name = "Node0";
            treeNode815.Text = "Version 1.0.0.24";
            treeNode816.Name = "Node1";
            treeNode816.Text = "OpenFile and SaveFile dialogs added";
            treeNode817.Name = "Node0";
            treeNode817.Text = "LDDialogs";
            treeNode818.Name = "Node2";
            treeNode818.Text = "Matrix methods, for example to solve linear equations";
            treeNode819.Name = "Node1";
            treeNode819.Text = "LDMatrix";
            treeNode820.Name = "Node0";
            treeNode820.Text = "Version 1.0.0.23";
            treeNode821.Name = "Node1";
            treeNode821.Text = "Sorting method added";
            treeNode822.Name = "Node0";
            treeNode822.Text = "LDArray";
            treeNode823.Name = "Node0";
            treeNode823.Text = "Version 1.0.0.22";
            treeNode824.Name = "Node2";
            treeNode824.Text = "Velocity Threshold setting added";
            treeNode825.Name = "Node1";
            treeNode825.Text = "LDPhysics";
            treeNode826.Name = "Node0";
            treeNode826.Text = "Version 1.0.0.21";
            treeNode827.Name = "Node3";
            treeNode827.Text = "SetDamping method added";
            treeNode828.Name = "Node2";
            treeNode828.Text = "LDPhysics";
            treeNode829.Name = "Node1";
            treeNode829.Text = "Version 1.0.0.20";
            treeNode830.Name = "Node1";
            treeNode830.Text = "Instrument name can be obtained from its number";
            treeNode831.Name = "Node0";
            treeNode831.Text = "LDMusic";
            treeNode832.Name = "Node0";
            treeNode832.Text = "Version 1.0.0.19";
            treeNode833.Name = "Node1";
            treeNode833.Text = "Calendar uses MS visual styles if available (better calendar, but no colours)";
            treeNode834.Name = "Node0";
            treeNode834.Text = "LDDialogs";
            treeNode835.Name = "Node1";
            treeNode835.Text = "Extends Sounds.PlayMusic to include additional instruments";
            treeNode836.Name = "Node2";
            treeNode836.Text = "Notes can also be played synchronously (chords)";
            treeNode837.Name = "Node0";
            treeNode837.Text = "LDMusic";
            treeNode838.Name = "Node0";
            treeNode838.Text = "Version 1.0.0.18";
            treeNode839.Name = "Node1";
            treeNode839.Text = "AnimationPause and AnimationResume methods added";
            treeNode840.Name = "Node0";
            treeNode840.Text = "LDShapes";
            treeNode841.Name = "Node1";
            treeNode841.Text = "Process list indexed by ID rather than name";
            treeNode842.Name = "Node0";
            treeNode842.Text = "LDProcess";
            treeNode843.Name = "Node1";
            treeNode843.Text = "Version 1.0.0.17";
            treeNode844.Name = "Node1";
            treeNode844.Text = "More effects added";
            treeNode845.Name = "Node0";
            treeNode845.Text = "LDWebCam";
            treeNode846.Name = "Node1";
            treeNode846.Text = "Add or change an image on a button or image shape";
            treeNode847.Name = "Node1";
            treeNode847.Text = "Add an animated gif or tiled image";
            treeNode848.Name = "Node0";
            treeNode848.Text = "LDShapes";
            treeNode849.Name = "Node0";
            treeNode849.Text = "Version 1.0.0.16";
            treeNode850.Name = "Node1";
            treeNode850.Text = "A webcam object for the GraphicsWindow, including a picture taking function";
            treeNode851.Name = "Node0";
            treeNode851.Text = "LDWebCam";
            treeNode852.Name = "Node0";
            treeNode852.Text = "Version 1.0.0.15";
            treeNode853.Name = "Node2";
            treeNode853.Text = "Variables may be changed during a debug session";
            treeNode854.Name = "Node1";
            treeNode854.Text = "LDDebug";
            treeNode855.Name = "Node0";
            treeNode855.Text = "Version 1.0.0.14";
            treeNode856.Name = "Node1";
            treeNode856.Text = "A basic debugging tool";
            treeNode857.Name = "Node0";
            treeNode857.Text = "LDDebug";
            treeNode858.Name = "Node0";
            treeNode858.Text = "Version 1.0.0.13";
            treeNode859.Name = "Node2";
            treeNode859.Text = "Methods to convert between HSL and RGB";
            treeNode860.Name = "Node18";
            treeNode860.Text = "Method to set colour opacity";
            treeNode861.Name = "Node19";
            treeNode861.Text = "Methods to get R, G, B and H, S, L for a colour";
            treeNode862.Name = "Node1";
            treeNode862.Text = "LDColours";
            treeNode863.Name = "Node4";
            treeNode863.Text = "Methods to add and subtract dates and times";
            treeNode864.Name = "Node3";
            treeNode864.Text = "LDDateTime";
            treeNode865.Name = "Node6";
            treeNode865.Text = "Waiting overlay, Calendar and About popups";
            treeNode866.Name = "Node17";
            treeNode866.Text = "Tooltips";
            treeNode867.Name = "Node5";
            treeNode867.Text = "LDDialogs";
            treeNode868.Name = "Node8";
            treeNode868.Text = "File change event";
            treeNode869.Name = "Node7";
            treeNode869.Text = "LDEvents";
            treeNode870.Name = "Node0";
            treeNode870.Text = "Version 1.0.0.12";
            treeNode871.Name = "Node12";
            treeNode871.Text = "Methods to sort arrays by index or value";
            treeNode872.Name = "Node22";
            treeNode872.Text = "Sorting by number and character strings";
            treeNode873.Name = "Node11";
            treeNode873.Text = "LDSort";
            treeNode874.Name = "Node14";
            treeNode874.Text = "Statistics on any array and distribution generation";
            treeNode875.Name = "Node20";
            treeNode875.Text = "Includes integration and differentiation to convert between PDF and CDF";
            treeNode876.Name = "Node21";
            treeNode876.Text = "Normal, Binomial, Traingular and Uniform distributions";
            treeNode877.Name = "Node13";
            treeNode877.Text = "LDStatistics";
            treeNode878.Name = "Node16";
            treeNode878.Text = "Voice and volume added";
            treeNode879.Name = "Node15";
            treeNode879.Text = "LDSpeech";
            treeNode880.Name = "Node9";
            treeNode880.Text = "Version 1.0.0.11";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode30,
            treeNode43,
            treeNode52,
            treeNode67,
            treeNode78,
            treeNode92,
            treeNode101,
            treeNode113,
            treeNode124,
            treeNode127,
            treeNode136,
            treeNode143,
            treeNode150,
            treeNode163,
            treeNode174,
            treeNode179,
            treeNode186,
            treeNode189,
            treeNode203,
            treeNode211,
            treeNode217,
            treeNode232,
            treeNode247,
            treeNode253,
            treeNode261,
            treeNode276,
            treeNode293,
            treeNode296,
            treeNode302,
            treeNode308,
            treeNode318,
            treeNode327,
            treeNode330,
            treeNode350,
            treeNode356,
            treeNode359,
            treeNode368,
            treeNode376,
            treeNode382,
            treeNode387,
            treeNode393,
            treeNode396,
            treeNode409,
            treeNode412,
            treeNode417,
            treeNode422,
            treeNode425,
            treeNode431,
            treeNode435,
            treeNode438,
            treeNode444,
            treeNode448,
            treeNode456,
            treeNode462,
            treeNode468,
            treeNode471,
            treeNode478,
            treeNode485,
            treeNode493,
            treeNode496,
            treeNode499,
            treeNode505,
            treeNode510,
            treeNode517,
            treeNode522,
            treeNode528,
            treeNode531,
            treeNode538,
            treeNode543,
            treeNode547,
            treeNode560,
            treeNode568,
            treeNode573,
            treeNode579,
            treeNode582,
            treeNode589,
            treeNode592,
            treeNode600,
            treeNode603,
            treeNode606,
            treeNode610,
            treeNode614,
            treeNode617,
            treeNode620,
            treeNode623,
            treeNode626,
            treeNode629,
            treeNode632,
            treeNode635,
            treeNode639,
            treeNode642,
            treeNode645,
            treeNode648,
            treeNode656,
            treeNode658,
            treeNode664,
            treeNode670,
            treeNode675,
            treeNode680,
            treeNode683,
            treeNode686,
            treeNode689,
            treeNode692,
            treeNode698,
            treeNode701,
            treeNode704,
            treeNode707,
            treeNode716,
            treeNode719,
            treeNode722,
            treeNode726,
            treeNode735,
            treeNode741,
            treeNode746,
            treeNode755,
            treeNode758,
            treeNode761,
            treeNode766,
            treeNode771,
            treeNode774,
            treeNode777,
            treeNode780,
            treeNode787,
            treeNode792,
            treeNode797,
            treeNode804,
            treeNode807,
            treeNode815,
            treeNode820,
            treeNode823,
            treeNode826,
            treeNode829,
            treeNode832,
            treeNode838,
            treeNode843,
            treeNode849,
            treeNode852,
            treeNode855,
            treeNode858,
            treeNode870,
            treeNode880});
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.Size = new System.Drawing.Size(759, 403);
            this.treeView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(643, 426);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Expand All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(501, 426);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Collapse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormChangeLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 458);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChangeLog";
            this.ShowIcon = false;
            this.Text = "Change Log";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TreeView treeView1;
    }
}