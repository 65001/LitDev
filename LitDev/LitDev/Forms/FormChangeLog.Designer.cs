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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("TEMP tables allowed for SQLite databases");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Convert2Cartesian fixed to be Culture Invariant.");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("NormalMap method added for normal map 3D effects");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("HeightMap2NormalMap method to create a normal map from a height map");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("MakeTransparent method added");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("ReplaceColour method added");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("To32bitARGB method added (code suggested by Pappa Lapub)");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("All image pixel manipulations speeded up");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("More Culture Invariace fixes");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Version 1.2.13.0", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4,
            treeNode10,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Base conversions extended to include bases up to 36");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Updated to new Bing API");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("LDSearch", new System.Windows.Forms.TreeNode[] {
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("ShowInTaskbar property added");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("ReadCSV and WriteCSV modified to handle \"");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("ToArray and FromArray methods added");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Version 1.2.12.0", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode18,
            treeNode20,
            treeNode22,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("DataViewColumnWidths method added");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("DataViewRowColours method added");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode27});
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Various obscure or experimental methods made visible to intelliseense. (LD3DView," +
        " LDBlueTooth, LDScrolBars, LDShapes)");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("SetCentre method added");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("A 3rd rotation added");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("BoundingBox method added");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode32,
            treeNode33});
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Reverted to earlier MySQL version to handle old password encryption");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode35});
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("PlayMusic2 method added");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Channel parameter added");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode37,
            treeNode38});
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Version 1.2.11.0", new System.Windows.Forms.TreeNode[] {
            treeNode28,
            treeNode30,
            treeNode34,
            treeNode36,
            treeNode39});
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("SetButtonStyle method added");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode41});
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Additional geometries added (Cube, Cone, Arrow, Revolute and Rectangle)");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("SetBillBoard method added");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("GetCameraUpDirection method added");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Gradient brushes can be used");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("AutoControl method added");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("SpecularExponent property added");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode43,
            treeNode44,
            treeNode45,
            treeNode46,
            treeNode47,
            treeNode48});
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("AddText method to annotate an image with text added");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode50});
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("BrushText for text on a brush added");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("Skew shapes method added");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode52,
            treeNode53});
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("Version 1.2.10.0", new System.Windows.Forms.TreeNode[] {
            treeNode42,
            treeNode49,
            treeNode51,
            treeNode54});
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("A general purpose unit system, see LDUnits.sb sample");
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("LDUnits", new System.Windows.Forms.TreeNode[] {
            treeNode56});
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("Possible issue with FixSigFig fixed");
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode58});
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("GetIndex method added (for SB arrays)");
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode60});
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("Resize mode property added");
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("Icon sets SB icon if property set to \"SB\"");
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode62,
            treeNode63});
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("Possible threading error with DataViewSetRow and DataViewSetValue fixed");
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("DataViewAllowUserEntry method added");
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode65,
            treeNode66});
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("Version 1.2.9.0", new System.Windows.Forms.TreeNode[] {
            treeNode57,
            treeNode59,
            treeNode61,
            treeNode64,
            treeNode67});
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("New extended math object, starting with FFT");
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("LDMathX", new System.Windows.Forms.TreeNode[] {
            treeNode69});
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("AddListBox and ListBoxContent can accept LDList and LDArray data");
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode71});
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("CreateFromIndices and CreateFromValues methods added");
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode73});
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("CreateFromIndices and CreateFromValues methods added");
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("LDList", new System.Windows.Forms.TreeNode[] {
            treeNode75});
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("Version 1.2.8.0", new System.Windows.Forms.TreeNode[] {
            treeNode70,
            treeNode72,
            treeNode74,
            treeNode76});
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("Error handling, additional settings and multiple ports supported");
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode78});
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("Posterise, Hue, Saturation and Lightness effects added");
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("More image effects, OilPaint, Charcoal, Sketch, Cartoon, Edge, Accent, Sepia, Noi" +
        "seRemoval and Solarise added");
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("LDImage and LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode80,
            treeNode81});
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("Bitwise operations object added");
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("LDBits", new System.Windows.Forms.TreeNode[] {
            treeNode83});
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("Extended text encoding property added");
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("TextWindow colours can be changed");
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode85,
            treeNode86});
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("GetWorkingImagePixelARGB method added");
            System.Windows.Forms.TreeNode treeNode89 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode88});
            System.Windows.Forms.TreeNode treeNode90 = new System.Windows.Forms.TreeNode("RasteriseTurtleLines method added");
            System.Windows.Forms.TreeNode treeNode91 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode90});
            System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("Version 1.2.7.0", new System.Windows.Forms.TreeNode[] {
            treeNode79,
            treeNode82,
            treeNode84,
            treeNode87,
            treeNode89,
            treeNode91});
            System.Windows.Forms.TreeNode treeNode93 = new System.Windows.Forms.TreeNode("Confirm dialog is given focus above GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode94 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode93});
            System.Windows.Forms.TreeNode treeNode95 = new System.Windows.Forms.TreeNode("Read and write json model scripts compatible with R.U.B.E.");
            System.Windows.Forms.TreeNode treeNode96 = new System.Windows.Forms.TreeNode("ToggleSensor added");
            System.Windows.Forms.TreeNode treeNode97 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode95,
            treeNode96});
            System.Windows.Forms.TreeNode treeNode98 = new System.Windows.Forms.TreeNode("Allow multiple copies of the webcam image");
            System.Windows.Forms.TreeNode treeNode99 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode98});
            System.Windows.Forms.TreeNode treeNode100 = new System.Windows.Forms.TreeNode("Fast pixel level image manipulation using a temporary working image added");
            System.Windows.Forms.TreeNode treeNode101 = new System.Windows.Forms.TreeNode("MetaData method added");
            System.Windows.Forms.TreeNode treeNode102 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode100,
            treeNode101});
            System.Windows.Forms.TreeNode treeNode103 = new System.Windows.Forms.TreeNode("Version 1.2.6.0", new System.Windows.Forms.TreeNode[] {
            treeNode94,
            treeNode97,
            treeNode99,
            treeNode102});
            System.Windows.Forms.TreeNode treeNode104 = new System.Windows.Forms.TreeNode("FixSigFig and FixDecimal methods added");
            System.Windows.Forms.TreeNode treeNode105 = new System.Windows.Forms.TreeNode("MinNumber and MaxNumber properties added");
            System.Windows.Forms.TreeNode treeNode106 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode104,
            treeNode105});
            System.Windows.Forms.TreeNode treeNode107 = new System.Windows.Forms.TreeNode("SliderMaximum property added");
            System.Windows.Forms.TreeNode treeNode108 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode107});
            System.Windows.Forms.TreeNode treeNode109 = new System.Windows.Forms.TreeNode("ZoomAll method added");
            System.Windows.Forms.TreeNode treeNode110 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode109});
            System.Windows.Forms.TreeNode treeNode111 = new System.Windows.Forms.TreeNode("Reposition methods and properties added");
            System.Windows.Forms.TreeNode treeNode112 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode111});
            System.Windows.Forms.TreeNode treeNode113 = new System.Windows.Forms.TreeNode("GetImagePixels and SetImagePixels methods added");
            System.Windows.Forms.TreeNode treeNode114 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode113});
            System.Windows.Forms.TreeNode treeNode115 = new System.Windows.Forms.TreeNode("MouseScroll parameter added");
            System.Windows.Forms.TreeNode treeNode116 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode115});
            System.Windows.Forms.TreeNode treeNode117 = new System.Windows.Forms.TreeNode("Version 1.2.5.0", new System.Windows.Forms.TreeNode[] {
            treeNode106,
            treeNode108,
            treeNode110,
            treeNode112,
            treeNode114,
            treeNode116});
            System.Windows.Forms.TreeNode treeNode118 = new System.Windows.Forms.TreeNode("New object added (previously a separate extension)");
            System.Windows.Forms.TreeNode treeNode119 = new System.Windows.Forms.TreeNode("Async, Loop, Volume and Pan properties added");
            System.Windows.Forms.TreeNode treeNode120 = new System.Windows.Forms.TreeNode("PlayWave, PlayHarmonics and PlayWavFile methods added");
            System.Windows.Forms.TreeNode treeNode121 = new System.Windows.Forms.TreeNode("LDWaveForm", new System.Windows.Forms.TreeNode[] {
            treeNode118,
            treeNode119,
            treeNode120});
            System.Windows.Forms.TreeNode treeNode122 = new System.Windows.Forms.TreeNode("New object added to get input from gamepads or joysticks");
            System.Windows.Forms.TreeNode treeNode123 = new System.Windows.Forms.TreeNode("LDController", new System.Windows.Forms.TreeNode[] {
            treeNode122});
            System.Windows.Forms.TreeNode treeNode124 = new System.Windows.Forms.TreeNode("RayCast method added");
            System.Windows.Forms.TreeNode treeNode125 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode124});
            System.Windows.Forms.TreeNode treeNode126 = new System.Windows.Forms.TreeNode("Version 1.2.4.0", new System.Windows.Forms.TreeNode[] {
            treeNode121,
            treeNode123,
            treeNode125});
            System.Windows.Forms.TreeNode treeNode127 = new System.Windows.Forms.TreeNode("New object to apply effects to any shape or control");
            System.Windows.Forms.TreeNode treeNode128 = new System.Windows.Forms.TreeNode("LDEffects", new System.Windows.Forms.TreeNode[] {
            treeNode127});
            System.Windows.Forms.TreeNode treeNode129 = new System.Windows.Forms.TreeNode("New object to add arrow, arc, polygons and callout shapes");
            System.Windows.Forms.TreeNode treeNode130 = new System.Windows.Forms.TreeNode("LDFigures", new System.Windows.Forms.TreeNode[] {
            treeNode129});
            System.Windows.Forms.TreeNode treeNode131 = new System.Windows.Forms.TreeNode("SetGroup method added");
            System.Windows.Forms.TreeNode treeNode132 = new System.Windows.Forms.TreeNode("GetContacts method added");
            System.Windows.Forms.TreeNode treeNode133 = new System.Windows.Forms.TreeNode("GetAllShapesAt method added");
            System.Windows.Forms.TreeNode treeNode134 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode131,
            treeNode132,
            treeNode133});
            System.Windows.Forms.TreeNode treeNode135 = new System.Windows.Forms.TreeNode("SetImage handles images with transparency");
            System.Windows.Forms.TreeNode treeNode136 = new System.Windows.Forms.TreeNode("ImageTransparency property added to switch how image transparencies are handled");
            System.Windows.Forms.TreeNode treeNode137 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode135,
            treeNode136});
            System.Windows.Forms.TreeNode treeNode138 = new System.Windows.Forms.TreeNode("Version 1.2.3.0", new System.Windows.Forms.TreeNode[] {
            treeNode128,
            treeNode130,
            treeNode134,
            treeNode137});
            System.Windows.Forms.TreeNode treeNode139 = new System.Windows.Forms.TreeNode("BrushGradient can use \"R\" for radial orientation");
            System.Windows.Forms.TreeNode treeNode140 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode139});
            System.Windows.Forms.TreeNode treeNode141 = new System.Windows.Forms.TreeNode("Unnecessary file existance checks removed from GetFolder, GetFile and GetExtensio" +
        "n");
            System.Windows.Forms.TreeNode treeNode142 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode141});
            System.Windows.Forms.TreeNode treeNode143 = new System.Windows.Forms.TreeNode("NewImage method added");
            System.Windows.Forms.TreeNode treeNode144 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode143});
            System.Windows.Forms.TreeNode treeNode145 = new System.Windows.Forms.TreeNode("SetStartupPosition method added to position dialogs");
            System.Windows.Forms.TreeNode treeNode146 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode145});
            System.Windows.Forms.TreeNode treeNode147 = new System.Windows.Forms.TreeNode("AddSeriesHitogram renamed AddSeriesHistogram");
            System.Windows.Forms.TreeNode treeNode148 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode147});
            System.Windows.Forms.TreeNode treeNode149 = new System.Windows.Forms.TreeNode("Version 1.2.2.0", new System.Windows.Forms.TreeNode[] {
            treeNode140,
            treeNode142,
            treeNode144,
            treeNode146,
            treeNode148});
            System.Windows.Forms.TreeNode treeNode150 = new System.Windows.Forms.TreeNode("Recompiled for Small Basic version 1.2");
            System.Windows.Forms.TreeNode treeNode151 = new System.Windows.Forms.TreeNode("Version 1.2", new System.Windows.Forms.TreeNode[] {
            treeNode150});
            System.Windows.Forms.TreeNode treeNode152 = new System.Windows.Forms.TreeNode("Version 1.2.0.1", new System.Windows.Forms.TreeNode[] {
            treeNode151});
            System.Windows.Forms.TreeNode treeNode153 = new System.Windows.Forms.TreeNode("OpenFile and SaveFile may take an array of extensions");
            System.Windows.Forms.TreeNode treeNode154 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode153});
            System.Windows.Forms.TreeNode treeNode155 = new System.Windows.Forms.TreeNode("Logical operations object added");
            System.Windows.Forms.TreeNode treeNode156 = new System.Windows.Forms.TreeNode("LDLogic", new System.Windows.Forms.TreeNode[] {
            treeNode155});
            System.Windows.Forms.TreeNode treeNode157 = new System.Windows.Forms.TreeNode("CurrentCulture property added");
            System.Windows.Forms.TreeNode treeNode158 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode157});
            System.Windows.Forms.TreeNode treeNode159 = new System.Windows.Forms.TreeNode("Evaluate3, a method to evaluate to a boolean added");
            System.Windows.Forms.TreeNode treeNode160 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode159});
            System.Windows.Forms.TreeNode treeNode161 = new System.Windows.Forms.TreeNode("Version 1.1.0.8", new System.Windows.Forms.TreeNode[] {
            treeNode154,
            treeNode156,
            treeNode158,
            treeNode160});
            System.Windows.Forms.TreeNode treeNode162 = new System.Windows.Forms.TreeNode("Scrolling to selected nodes improved for dataview with custom column type (e.g.co" +
        "mbobox)");
            System.Windows.Forms.TreeNode treeNode163 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode162});
            System.Windows.Forms.TreeNode treeNode164 = new System.Windows.Forms.TreeNode("Methods added to add and remove nodes and save xml file");
            System.Windows.Forms.TreeNode treeNode165 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode164});
            System.Windows.Forms.TreeNode treeNode166 = new System.Windows.Forms.TreeNode("MusicPlayTime moved from LDFile");
            System.Windows.Forms.TreeNode treeNode167 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode166});
            System.Windows.Forms.TreeNode treeNode168 = new System.Windows.Forms.TreeNode("Version 1.1.0.7", new System.Windows.Forms.TreeNode[] {
            treeNode163,
            treeNode165,
            treeNode167});
            System.Windows.Forms.TreeNode treeNode169 = new System.Windows.Forms.TreeNode("SplitImage method added");
            System.Windows.Forms.TreeNode treeNode170 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode169});
            System.Windows.Forms.TreeNode treeNode171 = new System.Windows.Forms.TreeNode("EditTable and SaveTable methods added");
            System.Windows.Forms.TreeNode treeNode172 = new System.Windows.Forms.TreeNode("LDDatabse", new System.Windows.Forms.TreeNode[] {
            treeNode171});
            System.Windows.Forms.TreeNode treeNode173 = new System.Windows.Forms.TreeNode("DataView control and methods added");
            System.Windows.Forms.TreeNode treeNode174 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode173});
            System.Windows.Forms.TreeNode treeNode175 = new System.Windows.Forms.TreeNode("Version 1.1.0.6", new System.Windows.Forms.TreeNode[] {
            treeNode170,
            treeNode172,
            treeNode174});
            System.Windows.Forms.TreeNode treeNode176 = new System.Windows.Forms.TreeNode("Exists modified to check for directory as well as file");
            System.Windows.Forms.TreeNode treeNode177 = new System.Windows.Forms.TreeNode("GetAllDirectories modified to omit directories without sufficient permissions");
            System.Windows.Forms.TreeNode treeNode178 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode176,
            treeNode177});
            System.Windows.Forms.TreeNode treeNode179 = new System.Windows.Forms.TreeNode("Instrumenting - Index was outside the bounds of the array - bug fixed");
            System.Windows.Forms.TreeNode treeNode180 = new System.Windows.Forms.TreeNode("Bug fixed returning to Small Basic IDE if application ends before debug window is" +
        " closed");
            System.Windows.Forms.TreeNode treeNode181 = new System.Windows.Forms.TreeNode("Conditonal break point added");
            System.Windows.Forms.TreeNode treeNode182 = new System.Windows.Forms.TreeNode("Step over button added");
            System.Windows.Forms.TreeNode treeNode183 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode179,
            treeNode180,
            treeNode181,
            treeNode182});
            System.Windows.Forms.TreeNode treeNode184 = new System.Windows.Forms.TreeNode("ExitOnClose works with LDWindows (multiple windows)");
            System.Windows.Forms.TreeNode treeNode185 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode184});
            System.Windows.Forms.TreeNode treeNode186 = new System.Windows.Forms.TreeNode("Object added to save image, sound, file and text/varables to a resources file");
            System.Windows.Forms.TreeNode treeNode187 = new System.Windows.Forms.TreeNode("LDResources", new System.Windows.Forms.TreeNode[] {
            treeNode186});
            System.Windows.Forms.TreeNode treeNode188 = new System.Windows.Forms.TreeNode("Version 1.1.0.5", new System.Windows.Forms.TreeNode[] {
            treeNode178,
            treeNode183,
            treeNode185,
            treeNode187});
            System.Windows.Forms.TreeNode treeNode189 = new System.Windows.Forms.TreeNode("ClipboardChanged event added");
            System.Windows.Forms.TreeNode treeNode190 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode189});
            System.Windows.Forms.TreeNode treeNode191 = new System.Windows.Forms.TreeNode("RenameFile, RenameDirctory, CopyDirectory and GetAllDirectories methods added");
            System.Windows.Forms.TreeNode treeNode192 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode191});
            System.Windows.Forms.TreeNode treeNode193 = new System.Windows.Forms.TreeNode("SetActive method added");
            System.Windows.Forms.TreeNode treeNode194 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode193});
            System.Windows.Forms.TreeNode treeNode195 = new System.Windows.Forms.TreeNode("Parse xml file nodes");
            System.Windows.Forms.TreeNode treeNode196 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode195});
            System.Windows.Forms.TreeNode treeNode197 = new System.Windows.Forms.TreeNode("\"FAILURE\" replaced by \"FAILED\" as a return message for consistency");
            System.Windows.Forms.TreeNode treeNode198 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode197});
            System.Windows.Forms.TreeNode treeNode199 = new System.Windows.Forms.TreeNode("Version 1.1.0.4", new System.Windows.Forms.TreeNode[] {
            treeNode190,
            treeNode192,
            treeNode194,
            treeNode196,
            treeNode198});
            System.Windows.Forms.TreeNode treeNode200 = new System.Windows.Forms.TreeNode("WakeAll method addded");
            System.Windows.Forms.TreeNode treeNode201 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode200});
            System.Windows.Forms.TreeNode treeNode202 = new System.Windows.Forms.TreeNode("Clipboard methods added");
            System.Windows.Forms.TreeNode treeNode203 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode202});
            System.Windows.Forms.TreeNode treeNode204 = new System.Windows.Forms.TreeNode("Version 1.1.0.3", new System.Windows.Forms.TreeNode[] {
            treeNode201,
            treeNode203});
            System.Windows.Forms.TreeNode treeNode205 = new System.Windows.Forms.TreeNode("SizeNWSE cursor added");
            System.Windows.Forms.TreeNode treeNode206 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode205});
            System.Windows.Forms.TreeNode treeNode207 = new System.Windows.Forms.TreeNode("ScaleAxisX & ScaleAxisY modified for better control");
            System.Windows.Forms.TreeNode treeNode208 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode207});
            System.Windows.Forms.TreeNode treeNode209 = new System.Windows.Forms.TreeNode("SQLite updated for .Net 4.5");
            System.Windows.Forms.TreeNode treeNode210 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode209});
            System.Windows.Forms.TreeNode treeNode211 = new System.Windows.Forms.TreeNode("Version 1.1.0.2", new System.Windows.Forms.TreeNode[] {
            treeNode206,
            treeNode208,
            treeNode210});
            System.Windows.Forms.TreeNode treeNode212 = new System.Windows.Forms.TreeNode("Recompiled for Small Basic version 1.1");
            System.Windows.Forms.TreeNode treeNode213 = new System.Windows.Forms.TreeNode("Version 1.1", new System.Windows.Forms.TreeNode[] {
            treeNode212});
            System.Windows.Forms.TreeNode treeNode214 = new System.Windows.Forms.TreeNode("Version 1.1.0.1", new System.Windows.Forms.TreeNode[] {
            treeNode213});
            System.Windows.Forms.TreeNode treeNode215 = new System.Windows.Forms.TreeNode("RichTextBoxCaseSensitive parameter added");
            System.Windows.Forms.TreeNode treeNode216 = new System.Windows.Forms.TreeNode("RichTextBoxMargins method added");
            System.Windows.Forms.TreeNode treeNode217 = new System.Windows.Forms.TreeNode("ListBoxSelectionMode added for multiple list box selection");
            System.Windows.Forms.TreeNode treeNode218 = new System.Windows.Forms.TreeNode("ListBoxGetSelected and ListBoxSelect modified for multiple selection modes");
            System.Windows.Forms.TreeNode treeNode219 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode215,
            treeNode216,
            treeNode217,
            treeNode218});
            System.Windows.Forms.TreeNode treeNode220 = new System.Windows.Forms.TreeNode("Error reporting added");
            System.Windows.Forms.TreeNode treeNode221 = new System.Windows.Forms.TreeNode("SetEncoding method added");
            System.Windows.Forms.TreeNode treeNode222 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode220,
            treeNode221});
            System.Windows.Forms.TreeNode treeNode223 = new System.Windows.Forms.TreeNode("AddSeries methods replace an existing series if the label name is the same");
            System.Windows.Forms.TreeNode treeNode224 = new System.Windows.Forms.TreeNode("Export to excel fix for graph with no title");
            System.Windows.Forms.TreeNode treeNode225 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode223,
            treeNode224});
            System.Windows.Forms.TreeNode treeNode226 = new System.Windows.Forms.TreeNode("Negative restitution option when adding moving shape");
            System.Windows.Forms.TreeNode treeNode227 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode226});
            System.Windows.Forms.TreeNode treeNode228 = new System.Windows.Forms.TreeNode("Version 1.0.0.133", new System.Windows.Forms.TreeNode[] {
            treeNode219,
            treeNode222,
            treeNode225,
            treeNode227});
            System.Windows.Forms.TreeNode treeNode229 = new System.Windows.Forms.TreeNode("Internal improvements to auto messaging");
            System.Windows.Forms.TreeNode treeNode230 = new System.Windows.Forms.TreeNode("Name can be set and GetClients method added");
            System.Windows.Forms.TreeNode treeNode231 = new System.Windows.Forms.TreeNode("LDClient", new System.Windows.Forms.TreeNode[] {
            treeNode229,
            treeNode230});
            System.Windows.Forms.TreeNode treeNode232 = new System.Windows.Forms.TreeNode("RichTextBoxWord method modified to include mode parameter");
            System.Windows.Forms.TreeNode treeNode233 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode232});
            System.Windows.Forms.TreeNode treeNode234 = new System.Windows.Forms.TreeNode("Return message and possible file error fixed for Stop method");
            System.Windows.Forms.TreeNode treeNode235 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode234});
            System.Windows.Forms.TreeNode treeNode236 = new System.Windows.Forms.TreeNode("Version 1.0.0.132", new System.Windows.Forms.TreeNode[] {
            treeNode231,
            treeNode233,
            treeNode235});
            System.Windows.Forms.TreeNode treeNode237 = new System.Windows.Forms.TreeNode("Include and CallInclude methods added to use a pre-compiled file");
            System.Windows.Forms.TreeNode treeNode238 = new System.Windows.Forms.TreeNode("Compile method added to compile a Small Basic program");
            System.Windows.Forms.TreeNode treeNode239 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode237,
            treeNode238});
            System.Windows.Forms.TreeNode treeNode240 = new System.Windows.Forms.TreeNode("Methods and code by Pappa Lapub added");
            System.Windows.Forms.TreeNode treeNode241 = new System.Windows.Forms.TreeNode("LDShell", new System.Windows.Forms.TreeNode[] {
            treeNode240});
            System.Windows.Forms.TreeNode treeNode242 = new System.Windows.Forms.TreeNode("Version 1.0.0.131", new System.Windows.Forms.TreeNode[] {
            treeNode239,
            treeNode241});
            System.Windows.Forms.TreeNode treeNode243 = new System.Windows.Forms.TreeNode("FollowShapeX and FollowShapeY methods added");
            System.Windows.Forms.TreeNode treeNode244 = new System.Windows.Forms.TreeNode("BoxShape method added to keep a shape with a region of the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode245 = new System.Windows.Forms.TreeNode("Refactoring of all the pan, follow and box methods");
            System.Windows.Forms.TreeNode treeNode246 = new System.Windows.Forms.TreeNode("All input and output coordinates are in world coordinates, apart from GetShapeAt " +
        "which is in screen coordinates");
            System.Windows.Forms.TreeNode treeNode247 = new System.Windows.Forms.TreeNode("GetPan method added to convert between world and screen coordinates");
            System.Windows.Forms.TreeNode treeNode248 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode243,
            treeNode244,
            treeNode245,
            treeNode246,
            treeNode247});
            System.Windows.Forms.TreeNode treeNode249 = new System.Windows.Forms.TreeNode("UseBinary property added");
            System.Windows.Forms.TreeNode treeNode250 = new System.Windows.Forms.TreeNode("DoAsync property and associated completion events added");
            System.Windows.Forms.TreeNode treeNode251 = new System.Windows.Forms.TreeNode("Delete method added");
            System.Windows.Forms.TreeNode treeNode252 = new System.Windows.Forms.TreeNode("LDftp", new System.Windows.Forms.TreeNode[] {
            treeNode249,
            treeNode250,
            treeNode251});
            System.Windows.Forms.TreeNode treeNode253 = new System.Windows.Forms.TreeNode("CallAsync method to call any extension method asynchronously added");
            System.Windows.Forms.TreeNode treeNode254 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode253});
            System.Windows.Forms.TreeNode treeNode255 = new System.Windows.Forms.TreeNode("SetCursorToEnd also works for RichTextBox");
            System.Windows.Forms.TreeNode treeNode256 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode255});
            System.Windows.Forms.TreeNode treeNode257 = new System.Windows.Forms.TreeNode("Version 1.0.0.130", new System.Windows.Forms.TreeNode[] {
            treeNode248,
            treeNode252,
            treeNode254,
            treeNode256});
            System.Windows.Forms.TreeNode treeNode258 = new System.Windows.Forms.TreeNode("Evaluate2 method added to behave nicely with the TextWindow");
            System.Windows.Forms.TreeNode treeNode259 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode258});
            System.Windows.Forms.TreeNode treeNode260 = new System.Windows.Forms.TreeNode("SetShapeGravity method to alter gravity for individual shapes");
            System.Windows.Forms.TreeNode treeNode261 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode260});
            System.Windows.Forms.TreeNode treeNode262 = new System.Windows.Forms.TreeNode("Improve PauseUpdate and ResumeUpdates methods");
            System.Windows.Forms.TreeNode treeNode263 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode262});
            System.Windows.Forms.TreeNode treeNode264 = new System.Windows.Forms.TreeNode("FTP object methods added");
            System.Windows.Forms.TreeNode treeNode265 = new System.Windows.Forms.TreeNode("LDftp", new System.Windows.Forms.TreeNode[] {
            treeNode264});
            System.Windows.Forms.TreeNode treeNode266 = new System.Windows.Forms.TreeNode("An existing file is replaced");
            System.Windows.Forms.TreeNode treeNode267 = new System.Windows.Forms.TreeNode("LDZip", new System.Windows.Forms.TreeNode[] {
            treeNode266});
            System.Windows.Forms.TreeNode treeNode268 = new System.Windows.Forms.TreeNode("Size method added");
            System.Windows.Forms.TreeNode treeNode269 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode268});
            System.Windows.Forms.TreeNode treeNode270 = new System.Windows.Forms.TreeNode("DownloadFile method added");
            System.Windows.Forms.TreeNode treeNode271 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode270});
            System.Windows.Forms.TreeNode treeNode272 = new System.Windows.Forms.TreeNode("Version 1.0.0.129", new System.Windows.Forms.TreeNode[] {
            treeNode259,
            treeNode261,
            treeNode263,
            treeNode265,
            treeNode267,
            treeNode269,
            treeNode271});
            System.Windows.Forms.TreeNode treeNode273 = new System.Windows.Forms.TreeNode("Generalised joint connections added");
            System.Windows.Forms.TreeNode treeNode274 = new System.Windows.Forms.TreeNode("AddExplosion method added");
            System.Windows.Forms.TreeNode treeNode275 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode273,
            treeNode274});
            System.Windows.Forms.TreeNode treeNode276 = new System.Windows.Forms.TreeNode("BrushImage method added and renamed some BrushGradient commands (old methods stil" +
        "l work but depreciated)");
            System.Windows.Forms.TreeNode treeNode277 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode276});
            System.Windows.Forms.TreeNode treeNode278 = new System.Windows.Forms.TreeNode("Version 1.0.0.128", new System.Windows.Forms.TreeNode[] {
            treeNode275,
            treeNode277});
            System.Windows.Forms.TreeNode treeNode279 = new System.Windows.Forms.TreeNode("CheckServer method added");
            System.Windows.Forms.TreeNode treeNode280 = new System.Windows.Forms.TreeNode("LDClient", new System.Windows.Forms.TreeNode[] {
            treeNode279});
            System.Windows.Forms.TreeNode treeNode281 = new System.Windows.Forms.TreeNode("Default maximum number of objects (proxies) increased from 512 to 1024");
            System.Windows.Forms.TreeNode treeNode282 = new System.Windows.Forms.TreeNode("MaxPolygonVertices and MaxProxies properties added");
            System.Windows.Forms.TreeNode treeNode283 = new System.Windows.Forms.TreeNode("GetAngle method added");
            System.Windows.Forms.TreeNode treeNode284 = new System.Windows.Forms.TreeNode("Top-down tire (to model a car from above) methods added");
            System.Windows.Forms.TreeNode treeNode285 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode281,
            treeNode282,
            treeNode283,
            treeNode284});
            System.Windows.Forms.TreeNode treeNode286 = new System.Windows.Forms.TreeNode("Version 1.0.0.127", new System.Windows.Forms.TreeNode[] {
            treeNode280,
            treeNode285});
            System.Windows.Forms.TreeNode treeNode287 = new System.Windows.Forms.TreeNode("Bug fixes for Overlap methods");
            System.Windows.Forms.TreeNode treeNode288 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode287});
            System.Windows.Forms.TreeNode treeNode289 = new System.Windows.Forms.TreeNode("Bug fix for multiple numeric sorts");
            System.Windows.Forms.TreeNode treeNode290 = new System.Windows.Forms.TreeNode("ByValueWithIndex method added");
            System.Windows.Forms.TreeNode treeNode291 = new System.Windows.Forms.TreeNode("LDSort", new System.Windows.Forms.TreeNode[] {
            treeNode289,
            treeNode290});
            System.Windows.Forms.TreeNode treeNode292 = new System.Windows.Forms.TreeNode("LAN method added to get local IP addresses");
            System.Windows.Forms.TreeNode treeNode293 = new System.Windows.Forms.TreeNode("Ping method added");
            System.Windows.Forms.TreeNode treeNode294 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode292,
            treeNode293});
            System.Windows.Forms.TreeNode treeNode295 = new System.Windows.Forms.TreeNode("LoadSVG method added");
            System.Windows.Forms.TreeNode treeNode296 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode295});
            System.Windows.Forms.TreeNode treeNode297 = new System.Windows.Forms.TreeNode("Evaluate method added");
            System.Windows.Forms.TreeNode treeNode298 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode297});
            System.Windows.Forms.TreeNode treeNode299 = new System.Windows.Forms.TreeNode("IncludeJScript method added");
            System.Windows.Forms.TreeNode treeNode300 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode299});
            System.Windows.Forms.TreeNode treeNode301 = new System.Windows.Forms.TreeNode("Version 1.0.0.126", new System.Windows.Forms.TreeNode[] {
            treeNode288,
            treeNode291,
            treeNode294,
            treeNode296,
            treeNode298,
            treeNode300});
            System.Windows.Forms.TreeNode treeNode302 = new System.Windows.Forms.TreeNode("Special emphasis on async consistency");
            System.Windows.Forms.TreeNode treeNode303 = new System.Windows.Forms.TreeNode("Simplified auto method for multi-player game data transfer");
            System.Windows.Forms.TreeNode treeNode304 = new System.Windows.Forms.TreeNode("LDServer and LDClient objects added", new System.Windows.Forms.TreeNode[] {
            treeNode302,
            treeNode303});
            System.Windows.Forms.TreeNode treeNode305 = new System.Windows.Forms.TreeNode("GetWidth and GetHeight methods added");
            System.Windows.Forms.TreeNode treeNode306 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode305});
            System.Windows.Forms.TreeNode treeNode307 = new System.Windows.Forms.TreeNode("Bing web search");
            System.Windows.Forms.TreeNode treeNode308 = new System.Windows.Forms.TreeNode("LDSearch", new System.Windows.Forms.TreeNode[] {
            treeNode307});
            System.Windows.Forms.TreeNode treeNode309 = new System.Windows.Forms.TreeNode("KeyDown event handled correctly for arrow keys with hidden scrollbars");
            System.Windows.Forms.TreeNode treeNode310 = new System.Windows.Forms.TreeNode("KeyScroll property added");
            System.Windows.Forms.TreeNode treeNode311 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode309,
            treeNode310});
            System.Windows.Forms.TreeNode treeNode312 = new System.Windows.Forms.TreeNode("GetLeft and GetTop methods (work while shape is animating)");
            System.Windows.Forms.TreeNode treeNode313 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode312});
            System.Windows.Forms.TreeNode treeNode314 = new System.Windows.Forms.TreeNode("SaveAs method bug fixed");
            System.Windows.Forms.TreeNode treeNode315 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode314});
            System.Windows.Forms.TreeNode treeNode316 = new System.Windows.Forms.TreeNode("Made thread-safe since often used to queue asynchronous events");
            System.Windows.Forms.TreeNode treeNode317 = new System.Windows.Forms.TreeNode("LDQueue", new System.Windows.Forms.TreeNode[] {
            treeNode316});
            System.Windows.Forms.TreeNode treeNode318 = new System.Windows.Forms.TreeNode("Version 1.0.0.125", new System.Windows.Forms.TreeNode[] {
            treeNode304,
            treeNode306,
            treeNode308,
            treeNode311,
            treeNode313,
            treeNode315,
            treeNode317});
            System.Windows.Forms.TreeNode treeNode319 = new System.Windows.Forms.TreeNode("Language translation object added");
            System.Windows.Forms.TreeNode treeNode320 = new System.Windows.Forms.TreeNode("LDTranslate", new System.Windows.Forms.TreeNode[] {
            treeNode319});
            System.Windows.Forms.TreeNode treeNode321 = new System.Windows.Forms.TreeNode("Version 1.0.0.124", new System.Windows.Forms.TreeNode[] {
            treeNode320});
            System.Windows.Forms.TreeNode treeNode322 = new System.Windows.Forms.TreeNode("Mouse screen coordinate conversion parameters added");
            System.Windows.Forms.TreeNode treeNode323 = new System.Windows.Forms.TreeNode("MouseX and MouseY added to set cursor in GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode324 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode322,
            treeNode323});
            System.Windows.Forms.TreeNode treeNode325 = new System.Windows.Forms.TreeNode("DPIX and DPIY properties added for screen resolution");
            System.Windows.Forms.TreeNode treeNode326 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode325});
            System.Windows.Forms.TreeNode treeNode327 = new System.Windows.Forms.TreeNode("Version 1.0.0.123", new System.Windows.Forms.TreeNode[] {
            treeNode324,
            treeNode326});
            System.Windows.Forms.TreeNode treeNode328 = new System.Windows.Forms.TreeNode("ColorMatrix method added");
            System.Windows.Forms.TreeNode treeNode329 = new System.Windows.Forms.TreeNode("Rotate method added");
            System.Windows.Forms.TreeNode treeNode330 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode328,
            treeNode329});
            System.Windows.Forms.TreeNode treeNode331 = new System.Windows.Forms.TreeNode("Customisable Pie, Doughnut, Bubble, Bar and Column chart control object added");
            System.Windows.Forms.TreeNode treeNode332 = new System.Windows.Forms.TreeNode("LDChart", new System.Windows.Forms.TreeNode[] {
            treeNode331});
            System.Windows.Forms.TreeNode treeNode333 = new System.Windows.Forms.TreeNode("Version 1.0.0.122", new System.Windows.Forms.TreeNode[] {
            treeNode330,
            treeNode332});
            System.Windows.Forms.TreeNode treeNode334 = new System.Windows.Forms.TreeNode("EffectGamma added to darken and lighten");
            System.Windows.Forms.TreeNode treeNode335 = new System.Windows.Forms.TreeNode("EffectFishEye, EffectBulge and EffectSwirl added");
            System.Windows.Forms.TreeNode treeNode336 = new System.Windows.Forms.TreeNode("EffectContrast modified");
            System.Windows.Forms.TreeNode treeNode337 = new System.Windows.Forms.TreeNode("GetEffects and EffectDefaults methods added to get list of effects and default pa" +
        "rameters");
            System.Windows.Forms.TreeNode treeNode338 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode334,
            treeNode335,
            treeNode336,
            treeNode337});
            System.Windows.Forms.TreeNode treeNode339 = new System.Windows.Forms.TreeNode("Error event added for all extension exceptions");
            System.Windows.Forms.TreeNode treeNode340 = new System.Windows.Forms.TreeNode("LDEvents", new System.Windows.Forms.TreeNode[] {
            treeNode339});
            System.Windows.Forms.TreeNode treeNode341 = new System.Windows.Forms.TreeNode("Hyperbolic trigonometric functions Sinh, Cosh and Tanh added");
            System.Windows.Forms.TreeNode treeNode342 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode341});
            System.Windows.Forms.TreeNode treeNode343 = new System.Windows.Forms.TreeNode("Version 1.0.0.121", new System.Windows.Forms.TreeNode[] {
            treeNode338,
            treeNode340,
            treeNode342});
            System.Windows.Forms.TreeNode treeNode344 = new System.Windows.Forms.TreeNode("FloodFill transparency effect fixed");
            System.Windows.Forms.TreeNode treeNode345 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode344});
            System.Windows.Forms.TreeNode treeNode346 = new System.Windows.Forms.TreeNode("SaveAllVariables and LoadAllVariables methods added");
            System.Windows.Forms.TreeNode treeNode347 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode346});
            System.Windows.Forms.TreeNode treeNode348 = new System.Windows.Forms.TreeNode("EffectPixelate added");
            System.Windows.Forms.TreeNode treeNode349 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode348});
            System.Windows.Forms.TreeNode treeNode350 = new System.Windows.Forms.TreeNode("Modified to work with Windows 8");
            System.Windows.Forms.TreeNode treeNode351 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode350});
            System.Windows.Forms.TreeNode treeNode352 = new System.Windows.Forms.TreeNode("Version 1.0.0.120", new System.Windows.Forms.TreeNode[] {
            treeNode345,
            treeNode347,
            treeNode349,
            treeNode351});
            System.Windows.Forms.TreeNode treeNode353 = new System.Windows.Forms.TreeNode("FloodFill method added");
            System.Windows.Forms.TreeNode treeNode354 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode353});
            System.Windows.Forms.TreeNode treeNode355 = new System.Windows.Forms.TreeNode("Version 1.0.0.119", new System.Windows.Forms.TreeNode[] {
            treeNode354});
            System.Windows.Forms.TreeNode treeNode356 = new System.Windows.Forms.TreeNode("SetShapeCursor method added");
            System.Windows.Forms.TreeNode treeNode357 = new System.Windows.Forms.TreeNode("CreateCursor method added");
            System.Windows.Forms.TreeNode treeNode358 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode356,
            treeNode357});
            System.Windows.Forms.TreeNode treeNode359 = new System.Windows.Forms.TreeNode("SaveAs method to save in different file formats");
            System.Windows.Forms.TreeNode treeNode360 = new System.Windows.Forms.TreeNode("Parameters added for some effects");
            System.Windows.Forms.TreeNode treeNode361 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode359,
            treeNode360});
            System.Windows.Forms.TreeNode treeNode362 = new System.Windows.Forms.TreeNode("Parameters added for some effects");
            System.Windows.Forms.TreeNode treeNode363 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode362});
            System.Windows.Forms.TreeNode treeNode364 = new System.Windows.Forms.TreeNode("Selected LDUtilities and LDShapes methods moved here to new object");
            System.Windows.Forms.TreeNode treeNode365 = new System.Windows.Forms.TreeNode("SetFontFromFile method added for ttf fonts");
            System.Windows.Forms.TreeNode treeNode366 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode364,
            treeNode365});
            System.Windows.Forms.TreeNode treeNode367 = new System.Windows.Forms.TreeNode("TWCapture and TWPrint moved from LDUtilities");
            System.Windows.Forms.TreeNode treeNode368 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode367});
            System.Windows.Forms.TreeNode treeNode369 = new System.Windows.Forms.TreeNode("Zip methods moved here from LDUtilities");
            System.Windows.Forms.TreeNode treeNode370 = new System.Windows.Forms.TreeNode("LDZip", new System.Windows.Forms.TreeNode[] {
            treeNode369});
            System.Windows.Forms.TreeNode treeNode371 = new System.Windows.Forms.TreeNode("Regex methods moved here from LDUtilities");
            System.Windows.Forms.TreeNode treeNode372 = new System.Windows.Forms.TreeNode("LDRegex", new System.Windows.Forms.TreeNode[] {
            treeNode371});
            System.Windows.Forms.TreeNode treeNode373 = new System.Windows.Forms.TreeNode("ListViewRowCount method added");
            System.Windows.Forms.TreeNode treeNode374 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode373});
            System.Windows.Forms.TreeNode treeNode375 = new System.Windows.Forms.TreeNode("Version 1.0.0.118", new System.Windows.Forms.TreeNode[] {
            treeNode358,
            treeNode361,
            treeNode363,
            treeNode366,
            treeNode368,
            treeNode370,
            treeNode372,
            treeNode374});
            System.Windows.Forms.TreeNode treeNode376 = new System.Windows.Forms.TreeNode("TransparentGW method added to create a fully transparent GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode377 = new System.Windows.Forms.TreeNode("TopMostGW method to set GraphicsWindow as top window");
            System.Windows.Forms.TreeNode treeNode378 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode376,
            treeNode377});
            System.Windows.Forms.TreeNode treeNode379 = new System.Windows.Forms.TreeNode("SetUserCursor method added");
            System.Windows.Forms.TreeNode treeNode380 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode379});
            System.Windows.Forms.TreeNode treeNode381 = new System.Windows.Forms.TreeNode("Version 1.0.0.117", new System.Windows.Forms.TreeNode[] {
            treeNode378,
            treeNode380});
            System.Windows.Forms.TreeNode treeNode382 = new System.Windows.Forms.TreeNode("Replacement for Version 1.0 Dictionary object that fails");
            System.Windows.Forms.TreeNode treeNode383 = new System.Windows.Forms.TreeNode("LDDictionary", new System.Windows.Forms.TreeNode[] {
            treeNode382});
            System.Windows.Forms.TreeNode treeNode384 = new System.Windows.Forms.TreeNode("Version 1.0.0.116", new System.Windows.Forms.TreeNode[] {
            treeNode383});
            System.Windows.Forms.TreeNode treeNode385 = new System.Windows.Forms.TreeNode("GetPixel method fix for SB v1.0 bug (works for background, drawing and shape laye" +
        "rs)");
            System.Windows.Forms.TreeNode treeNode386 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode385});
            System.Windows.Forms.TreeNode treeNode387 = new System.Windows.Forms.TreeNode("GetOpacity method fix for SB v1.0 bug");
            System.Windows.Forms.TreeNode treeNode388 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode387});
            System.Windows.Forms.TreeNode treeNode389 = new System.Windows.Forms.TreeNode("GridLines replaced with GridLinesX and GridLinesY");
            System.Windows.Forms.TreeNode treeNode390 = new System.Windows.Forms.TreeNode("ScaleAxisX and ScaleAxisY methods added");
            System.Windows.Forms.TreeNode treeNode391 = new System.Windows.Forms.TreeNode("AutoScale property added to revert to earlier scaling methods");
            System.Windows.Forms.TreeNode treeNode392 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode389,
            treeNode390,
            treeNode391});
            System.Windows.Forms.TreeNode treeNode393 = new System.Windows.Forms.TreeNode("Version 1.0.0.115", new System.Windows.Forms.TreeNode[] {
            treeNode386,
            treeNode388,
            treeNode392});
            System.Windows.Forms.TreeNode treeNode394 = new System.Windows.Forms.TreeNode("ListViewSetRow fixed for overwriting existing row");
            System.Windows.Forms.TreeNode treeNode395 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode394});
            System.Windows.Forms.TreeNode treeNode396 = new System.Windows.Forms.TreeNode("RemoveTurtleLines method added");
            System.Windows.Forms.TreeNode treeNode397 = new System.Windows.Forms.TreeNode("GetAllShapes method added");
            System.Windows.Forms.TreeNode treeNode398 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode396,
            treeNode397});
            System.Windows.Forms.TreeNode treeNode399 = new System.Windows.Forms.TreeNode("Odbc connection added");
            System.Windows.Forms.TreeNode treeNode400 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode399});
            System.Windows.Forms.TreeNode treeNode401 = new System.Windows.Forms.TreeNode("Version 1.0.0.114", new System.Windows.Forms.TreeNode[] {
            treeNode395,
            treeNode398,
            treeNode400});
            System.Windows.Forms.TreeNode treeNode402 = new System.Windows.Forms.TreeNode("NetworkURL property added for your own LDNetwork web server");
            System.Windows.Forms.TreeNode treeNode403 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode402});
            System.Windows.Forms.TreeNode treeNode404 = new System.Windows.Forms.TreeNode("ListView control added");
            System.Windows.Forms.TreeNode treeNode405 = new System.Windows.Forms.TreeNode("TextBoxReadOnly to set textbox to read only");
            System.Windows.Forms.TreeNode treeNode406 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode404,
            treeNode405});
            System.Windows.Forms.TreeNode treeNode407 = new System.Windows.Forms.TreeNode("Version 1.0.0.113", new System.Windows.Forms.TreeNode[] {
            treeNode403,
            treeNode406});
            System.Windows.Forms.TreeNode treeNode408 = new System.Windows.Forms.TreeNode("Tone method added");
            System.Windows.Forms.TreeNode treeNode409 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode408});
            System.Windows.Forms.TreeNode treeNode410 = new System.Windows.Forms.TreeNode("TreeViewGetData and TreeViewEdit methods added");
            System.Windows.Forms.TreeNode treeNode411 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode410});
            System.Windows.Forms.TreeNode treeNode412 = new System.Windows.Forms.TreeNode("Version 1.0.0.112", new System.Windows.Forms.TreeNode[] {
            treeNode409,
            treeNode411});
            System.Windows.Forms.TreeNode treeNode413 = new System.Windows.Forms.TreeNode("SqlServer and Access database support added");
            System.Windows.Forms.TreeNode treeNode414 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode413});
            System.Windows.Forms.TreeNode treeNode415 = new System.Windows.Forms.TreeNode("FixFlickr method added");
            System.Windows.Forms.TreeNode treeNode416 = new System.Windows.Forms.TreeNode("ShowNoShapeErrors enable or disable TextWindow errors when shape parameter not fo" +
        "und");
            System.Windows.Forms.TreeNode treeNode417 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode415,
            treeNode416});
            System.Windows.Forms.TreeNode treeNode418 = new System.Windows.Forms.TreeNode("Version 1.0.0.111", new System.Windows.Forms.TreeNode[] {
            treeNode414,
            treeNode417});
            System.Windows.Forms.TreeNode treeNode419 = new System.Windows.Forms.TreeNode("TextBoxTab method added");
            System.Windows.Forms.TreeNode treeNode420 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode419});
            System.Windows.Forms.TreeNode treeNode421 = new System.Windows.Forms.TreeNode("Version 1.0.0.110", new System.Windows.Forms.TreeNode[] {
            treeNode420});
            System.Windows.Forms.TreeNode treeNode422 = new System.Windows.Forms.TreeNode("TextWindow warning meaages for methods that are supplied with file paths that do " +
        "not exist");
            System.Windows.Forms.TreeNode treeNode423 = new System.Windows.Forms.TreeNode("File not found warnings controlled with LDUtilities ShowFileErrors");
            System.Windows.Forms.TreeNode treeNode424 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode422,
            treeNode423});
            System.Windows.Forms.TreeNode treeNode425 = new System.Windows.Forms.TreeNode("Exists method added to check if a file path exists or not");
            System.Windows.Forms.TreeNode treeNode426 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode425});
            System.Windows.Forms.TreeNode treeNode427 = new System.Windows.Forms.TreeNode("Start method handles attaching to existing process without warning");
            System.Windows.Forms.TreeNode treeNode428 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode427});
            System.Windows.Forms.TreeNode treeNode429 = new System.Windows.Forms.TreeNode("MySQL database support added");
            System.Windows.Forms.TreeNode treeNode430 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode429});
            System.Windows.Forms.TreeNode treeNode431 = new System.Windows.Forms.TreeNode("Add and Multiply methods honour transparency");
            System.Windows.Forms.TreeNode treeNode432 = new System.Windows.Forms.TreeNode("R, G, B truncated to 0 to 255 for Add, Multiply, AddImages, and Abs for Differenc" +
        "eImages");
            System.Windows.Forms.TreeNode treeNode433 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode431,
            treeNode432});
            System.Windows.Forms.TreeNode treeNode434 = new System.Windows.Forms.TreeNode("Version 1.0.0.109", new System.Windows.Forms.TreeNode[] {
            treeNode424,
            treeNode426,
            treeNode428,
            treeNode430,
            treeNode433});
            System.Windows.Forms.TreeNode treeNode435 = new System.Windows.Forms.TreeNode("Show and Hide (fix for SB v1.0 bug)");
            System.Windows.Forms.TreeNode treeNode436 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode435});
            System.Windows.Forms.TreeNode treeNode437 = new System.Windows.Forms.TreeNode("Version 1.0.0.108", new System.Windows.Forms.TreeNode[] {
            treeNode436});
            System.Windows.Forms.TreeNode treeNode438 = new System.Windows.Forms.TreeNode("Transparent colour added");
            System.Windows.Forms.TreeNode treeNode439 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode438});
            System.Windows.Forms.TreeNode treeNode440 = new System.Windows.Forms.TreeNode("Dialogs always appear in front of GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode441 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode440});
            System.Windows.Forms.TreeNode treeNode442 = new System.Windows.Forms.TreeNode("Version 1.0.0.107", new System.Windows.Forms.TreeNode[] {
            treeNode439,
            treeNode441});
            System.Windows.Forms.TreeNode treeNode443 = new System.Windows.Forms.TreeNode("Improvements to Menu control (colouring, separators and check state)");
            System.Windows.Forms.TreeNode treeNode444 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode443});
            System.Windows.Forms.TreeNode treeNode445 = new System.Windows.Forms.TreeNode("SetShapeEvent added GotFocus and LostFocus events");
            System.Windows.Forms.TreeNode treeNode446 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode445});
            System.Windows.Forms.TreeNode treeNode447 = new System.Windows.Forms.TreeNode("Version 1.0.0.106", new System.Windows.Forms.TreeNode[] {
            treeNode444,
            treeNode446});
            System.Windows.Forms.TreeNode treeNode448 = new System.Windows.Forms.TreeNode("Menu control added");
            System.Windows.Forms.TreeNode treeNode449 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode448});
            System.Windows.Forms.TreeNode treeNode450 = new System.Windows.Forms.TreeNode("Version 1.0.0.105", new System.Windows.Forms.TreeNode[] {
            treeNode449});
            System.Windows.Forms.TreeNode treeNode451 = new System.Windows.Forms.TreeNode("ZipList method added");
            System.Windows.Forms.TreeNode treeNode452 = new System.Windows.Forms.TreeNode("GetNextMapIndex method added");
            System.Windows.Forms.TreeNode treeNode453 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode451,
            treeNode452});
            System.Windows.Forms.TreeNode treeNode454 = new System.Windows.Forms.TreeNode("GetColour method added (gets Brush, Pen and Opacity)");
            System.Windows.Forms.TreeNode treeNode455 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode454});
            System.Windows.Forms.TreeNode treeNode456 = new System.Windows.Forms.TreeNode("Version 1.0.0.104", new System.Windows.Forms.TreeNode[] {
            treeNode453,
            treeNode455});
            System.Windows.Forms.TreeNode treeNode457 = new System.Windows.Forms.TreeNode("Transparency maintained for various methods");
            System.Windows.Forms.TreeNode treeNode458 = new System.Windows.Forms.TreeNode("Effects bug fixed");
            System.Windows.Forms.TreeNode treeNode459 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode457,
            treeNode458});
            System.Windows.Forms.TreeNode treeNode460 = new System.Windows.Forms.TreeNode("Version 1.0.0.103", new System.Windows.Forms.TreeNode[] {
            treeNode459});
            System.Windows.Forms.TreeNode treeNode461 = new System.Windows.Forms.TreeNode("Current application assemblies are all auto-referenced");
            System.Windows.Forms.TreeNode treeNode462 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode461});
            System.Windows.Forms.TreeNode treeNode463 = new System.Windows.Forms.TreeNode("Version 1.0.0.102", new System.Windows.Forms.TreeNode[] {
            treeNode462});
            System.Windows.Forms.TreeNode treeNode464 = new System.Windows.Forms.TreeNode("Include C# or VB methods, properties and events to compile and call from your Sma" +
        "llBasic code");
            System.Windows.Forms.TreeNode treeNode465 = new System.Windows.Forms.TreeNode("LDInline.sb sample provided");
            System.Windows.Forms.TreeNode treeNode466 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode464,
            treeNode465});
            System.Windows.Forms.TreeNode treeNode467 = new System.Windows.Forms.TreeNode("ExitButtonMode method added to control window close button state");
            System.Windows.Forms.TreeNode treeNode468 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode467});
            System.Windows.Forms.TreeNode treeNode469 = new System.Windows.Forms.TreeNode("Version 1.0.0.101", new System.Windows.Forms.TreeNode[] {
            treeNode466,
            treeNode468});
            System.Windows.Forms.TreeNode treeNode470 = new System.Windows.Forms.TreeNode("Read and ReadNumber methods added (with a delay before auto return)");
            System.Windows.Forms.TreeNode treeNode471 = new System.Windows.Forms.TreeNode("KeyDown, KeyUp and SendKey (low level keyboard control) added");
            System.Windows.Forms.TreeNode treeNode472 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode470,
            treeNode471});
            System.Windows.Forms.TreeNode treeNode473 = new System.Windows.Forms.TreeNode("Version 1.0.0.100", new System.Windows.Forms.TreeNode[] {
            treeNode472});
            System.Windows.Forms.TreeNode treeNode474 = new System.Windows.Forms.TreeNode("ReadANSIToArray method added");
            System.Windows.Forms.TreeNode treeNode475 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode474});
            System.Windows.Forms.TreeNode treeNode476 = new System.Windows.Forms.TreeNode("DocumentViewer control added");
            System.Windows.Forms.TreeNode treeNode477 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode476});
            System.Windows.Forms.TreeNode treeNode478 = new System.Windows.Forms.TreeNode("An object to batch update shapes (for speed reasons)");
            System.Windows.Forms.TreeNode treeNode479 = new System.Windows.Forms.TreeNode("LDFastShapes.sb sample included");
            System.Windows.Forms.TreeNode treeNode480 = new System.Windows.Forms.TreeNode("LDFastShapes", new System.Windows.Forms.TreeNode[] {
            treeNode478,
            treeNode479});
            System.Windows.Forms.TreeNode treeNode481 = new System.Windows.Forms.TreeNode("Version 1.0.0.99", new System.Windows.Forms.TreeNode[] {
            treeNode475,
            treeNode477,
            treeNode480});
            System.Windows.Forms.TreeNode treeNode482 = new System.Windows.Forms.TreeNode("Rendering performance improvements when many shapes present");
            System.Windows.Forms.TreeNode treeNode483 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode482});
            System.Windows.Forms.TreeNode treeNode484 = new System.Windows.Forms.TreeNode("ANSItoUTF8 method added");
            System.Windows.Forms.TreeNode treeNode485 = new System.Windows.Forms.TreeNode("ReadANSI method added");
            System.Windows.Forms.TreeNode treeNode486 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode484,
            treeNode485});
            System.Windows.Forms.TreeNode treeNode487 = new System.Windows.Forms.TreeNode("Version 1.0.0.98", new System.Windows.Forms.TreeNode[] {
            treeNode483,
            treeNode486});
            System.Windows.Forms.TreeNode treeNode488 = new System.Windows.Forms.TreeNode("Move method added for tiangles, polygons and lines");
            System.Windows.Forms.TreeNode treeNode489 = new System.Windows.Forms.TreeNode("RotateAbout method added");
            System.Windows.Forms.TreeNode treeNode490 = new System.Windows.Forms.TreeNode("GetLeft and GetTop methods added for triangles, polygons and lines");
            System.Windows.Forms.TreeNode treeNode491 = new System.Windows.Forms.TreeNode("SetTurtleImage repositioning \'hot spot\' on resize fixed");
            System.Windows.Forms.TreeNode treeNode492 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode488,
            treeNode489,
            treeNode490,
            treeNode491});
            System.Windows.Forms.TreeNode treeNode493 = new System.Windows.Forms.TreeNode("Version 1.0.0.97", new System.Windows.Forms.TreeNode[] {
            treeNode492});
            System.Windows.Forms.TreeNode treeNode494 = new System.Windows.Forms.TreeNode("A list storage object added");
            System.Windows.Forms.TreeNode treeNode495 = new System.Windows.Forms.TreeNode("LDList", new System.Windows.Forms.TreeNode[] {
            treeNode494});
            System.Windows.Forms.TreeNode treeNode496 = new System.Windows.Forms.TreeNode("Version 1.0.0.96", new System.Windows.Forms.TreeNode[] {
            treeNode495});
            System.Windows.Forms.TreeNode treeNode497 = new System.Windows.Forms.TreeNode("A queue (first-in first-out) storage similar to a stack object added");
            System.Windows.Forms.TreeNode treeNode498 = new System.Windows.Forms.TreeNode("LDQueue", new System.Windows.Forms.TreeNode[] {
            treeNode497});
            System.Windows.Forms.TreeNode treeNode499 = new System.Windows.Forms.TreeNode("Fix for multi-dimensional arrays using GetGameData and SetGameData");
            System.Windows.Forms.TreeNode treeNode500 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode499});
            System.Windows.Forms.TreeNode treeNode501 = new System.Windows.Forms.TreeNode("Returned arrays with \\= or ; in index or value correctly handled");
            System.Windows.Forms.TreeNode treeNode502 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode501});
            System.Windows.Forms.TreeNode treeNode503 = new System.Windows.Forms.TreeNode("Version 1.0.0.95", new System.Windows.Forms.TreeNode[] {
            treeNode498,
            treeNode500,
            treeNode502});
            System.Windows.Forms.TreeNode treeNode504 = new System.Windows.Forms.TreeNode("SHA512Hash and MD5HashFile methods added");
            System.Windows.Forms.TreeNode treeNode505 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode504});
            System.Windows.Forms.TreeNode treeNode506 = new System.Windows.Forms.TreeNode("RandomNumberSeed property added");
            System.Windows.Forms.TreeNode treeNode507 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode506});
            System.Windows.Forms.TreeNode treeNode508 = new System.Windows.Forms.TreeNode("SetGameData and GetGameData methods added");
            System.Windows.Forms.TreeNode treeNode509 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode508});
            System.Windows.Forms.TreeNode treeNode510 = new System.Windows.Forms.TreeNode("Version 1.0.0.94", new System.Windows.Forms.TreeNode[] {
            treeNode505,
            treeNode507,
            treeNode509});
            System.Windows.Forms.TreeNode treeNode511 = new System.Windows.Forms.TreeNode("SliderGetValue method added");
            System.Windows.Forms.TreeNode treeNode512 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode511});
            System.Windows.Forms.TreeNode treeNode513 = new System.Windows.Forms.TreeNode("UnZip now works with most zip formats, not just those created with LDUtilities.Zi" +
        "p");
            System.Windows.Forms.TreeNode treeNode514 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode513});
            System.Windows.Forms.TreeNode treeNode515 = new System.Windows.Forms.TreeNode("Encrypt and Decrypt methods added");
            System.Windows.Forms.TreeNode treeNode516 = new System.Windows.Forms.TreeNode("MD5Hash method added");
            System.Windows.Forms.TreeNode treeNode517 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode515,
            treeNode516});
            System.Windows.Forms.TreeNode treeNode518 = new System.Windows.Forms.TreeNode("Version 1.0.0.93", new System.Windows.Forms.TreeNode[] {
            treeNode512,
            treeNode514,
            treeNode517});
            System.Windows.Forms.TreeNode treeNode519 = new System.Windows.Forms.TreeNode("ProgressBar, Slider and PasswordBox controls added");
            System.Windows.Forms.TreeNode treeNode520 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode519});
            System.Windows.Forms.TreeNode treeNode521 = new System.Windows.Forms.TreeNode("Version 1.0.0.92", new System.Windows.Forms.TreeNode[] {
            treeNode520});
            System.Windows.Forms.TreeNode treeNode522 = new System.Windows.Forms.TreeNode("TreeViewGetSelected, ListBoxGetSelected, ComboBoxGetSelected, CheckBoxGetState an" +
        "d RadioButtonGet methods added");
            System.Windows.Forms.TreeNode treeNode523 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode522});
            System.Windows.Forms.TreeNode treeNode524 = new System.Windows.Forms.TreeNode("Version 1.0.0.91", new System.Windows.Forms.TreeNode[] {
            treeNode523});
            System.Windows.Forms.TreeNode treeNode525 = new System.Windows.Forms.TreeNode("Font method added to modify shapes or controls that have text");
            System.Windows.Forms.TreeNode treeNode526 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode525});
            System.Windows.Forms.TreeNode treeNode527 = new System.Windows.Forms.TreeNode("MediaPlayer control added (play videos etc)");
            System.Windows.Forms.TreeNode treeNode528 = new System.Windows.Forms.TreeNode("ListBoxContent, TreeViewContent and ComboBoxContent methods added to change list " +
        "contents");
            System.Windows.Forms.TreeNode treeNode529 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode527,
            treeNode528});
            System.Windows.Forms.TreeNode treeNode530 = new System.Windows.Forms.TreeNode("Version 1.0.0.90", new System.Windows.Forms.TreeNode[] {
            treeNode526,
            treeNode529});
            System.Windows.Forms.TreeNode treeNode531 = new System.Windows.Forms.TreeNode("Autosize columns for ListView");
            System.Windows.Forms.TreeNode treeNode532 = new System.Windows.Forms.TreeNode("LDDataBase.sb sample updated");
            System.Windows.Forms.TreeNode treeNode533 = new System.Windows.Forms.TreeNode("Optionally return array of results for query (GetRecord removed)");
            System.Windows.Forms.TreeNode treeNode534 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode531,
            treeNode532,
            treeNode533});
            System.Windows.Forms.TreeNode treeNode535 = new System.Windows.Forms.TreeNode("Version 1.0.0.89", new System.Windows.Forms.TreeNode[] {
            treeNode534});
            System.Windows.Forms.TreeNode treeNode536 = new System.Windows.Forms.TreeNode("GraphicsWindow.MouseDown works for any event subroutine name");
            System.Windows.Forms.TreeNode treeNode537 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode536});
            System.Windows.Forms.TreeNode treeNode538 = new System.Windows.Forms.TreeNode("CleanTemp method added");
            System.Windows.Forms.TreeNode treeNode539 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode538});
            System.Windows.Forms.TreeNode treeNode540 = new System.Windows.Forms.TreeNode("SQLite database methods added");
            System.Windows.Forms.TreeNode treeNode541 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode540});
            System.Windows.Forms.TreeNode treeNode542 = new System.Windows.Forms.TreeNode("Version 1.0.0.88", new System.Windows.Forms.TreeNode[] {
            treeNode537,
            treeNode539,
            treeNode541});
            System.Windows.Forms.TreeNode treeNode543 = new System.Windows.Forms.TreeNode("LastError now returns a text error");
            System.Windows.Forms.TreeNode treeNode544 = new System.Windows.Forms.TreeNode("LDIOWarrior", new System.Windows.Forms.TreeNode[] {
            treeNode543});
            System.Windows.Forms.TreeNode treeNode545 = new System.Windows.Forms.TreeNode("MouseDown (must be named \"OnMouseDown\") and MouseWheel events fixed");
            System.Windows.Forms.TreeNode treeNode546 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode545});
            System.Windows.Forms.TreeNode treeNode547 = new System.Windows.Forms.TreeNode("Version 1.0.0.87", new System.Windows.Forms.TreeNode[] {
            treeNode544,
            treeNode546});
            System.Windows.Forms.TreeNode treeNode548 = new System.Windows.Forms.TreeNode("SetTurtleImage method added");
            System.Windows.Forms.TreeNode treeNode549 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode548});
            System.Windows.Forms.TreeNode treeNode550 = new System.Windows.Forms.TreeNode("Connect to IOWarrior USB devices");
            System.Windows.Forms.TreeNode treeNode551 = new System.Windows.Forms.TreeNode("http://www.codemercs.com/io-warrior/?L=1");
            System.Windows.Forms.TreeNode treeNode552 = new System.Windows.Forms.TreeNode("LDIOWarrior", new System.Windows.Forms.TreeNode[] {
            treeNode550,
            treeNode551});
            System.Windows.Forms.TreeNode treeNode553 = new System.Windows.Forms.TreeNode("Version 1.0.0.86", new System.Windows.Forms.TreeNode[] {
            treeNode549,
            treeNode552});
            System.Windows.Forms.TreeNode treeNode554 = new System.Windows.Forms.TreeNode("PenColour, BrushColour and BrushGradientShape applied to most Shapes and Controls" +
        "");
            System.Windows.Forms.TreeNode treeNode555 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode554});
            System.Windows.Forms.TreeNode treeNode556 = new System.Windows.Forms.TreeNode("Version 1.0.0.85", new System.Windows.Forms.TreeNode[] {
            treeNode555});
            System.Windows.Forms.TreeNode treeNode557 = new System.Windows.Forms.TreeNode("GetFolder, GetFile and GetExtension methods added");
            System.Windows.Forms.TreeNode treeNode558 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode557});
            System.Windows.Forms.TreeNode treeNode559 = new System.Windows.Forms.TreeNode("Crop method added");
            System.Windows.Forms.TreeNode treeNode560 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode559});
            System.Windows.Forms.TreeNode treeNode561 = new System.Windows.Forms.TreeNode("LastDropFiles bug fixed");
            System.Windows.Forms.TreeNode treeNode562 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode561});
            System.Windows.Forms.TreeNode treeNode563 = new System.Windows.Forms.TreeNode("Version 1.0.0.84", new System.Windows.Forms.TreeNode[] {
            treeNode558,
            treeNode560,
            treeNode562});
            System.Windows.Forms.TreeNode treeNode564 = new System.Windows.Forms.TreeNode("FileDropped event added");
            System.Windows.Forms.TreeNode treeNode565 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode564});
            System.Windows.Forms.TreeNode treeNode566 = new System.Windows.Forms.TreeNode("Bug in Split corrected");
            System.Windows.Forms.TreeNode treeNode567 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode566});
            System.Windows.Forms.TreeNode treeNode568 = new System.Windows.Forms.TreeNode("Version 1.0.0.83", new System.Windows.Forms.TreeNode[] {
            treeNode565,
            treeNode567});
            System.Windows.Forms.TreeNode treeNode569 = new System.Windows.Forms.TreeNode("Title argument removed from AddComboBox");
            System.Windows.Forms.TreeNode treeNode570 = new System.Windows.Forms.TreeNode("AllowDrop method added (for TextBox, RichTextBox, Image and Background)");
            System.Windows.Forms.TreeNode treeNode571 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode569,
            treeNode570});
            System.Windows.Forms.TreeNode treeNode572 = new System.Windows.Forms.TreeNode("Version 1.0.0.82", new System.Windows.Forms.TreeNode[] {
            treeNode571});
            System.Windows.Forms.TreeNode treeNode573 = new System.Windows.Forms.TreeNode("German xml updated (Thanks to Pappa Lapub)");
            System.Windows.Forms.TreeNode treeNode574 = new System.Windows.Forms.TreeNode("Program settings added");
            System.Windows.Forms.TreeNode treeNode575 = new System.Windows.Forms.TreeNode("LDSettings", new System.Windows.Forms.TreeNode[] {
            treeNode574});
            System.Windows.Forms.TreeNode treeNode576 = new System.Windows.Forms.TreeNode("Get some system paths and user name");
            System.Windows.Forms.TreeNode treeNode577 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode576});
            System.Windows.Forms.TreeNode treeNode578 = new System.Windows.Forms.TreeNode("System sounds added");
            System.Windows.Forms.TreeNode treeNode579 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode578});
            System.Windows.Forms.TreeNode treeNode580 = new System.Windows.Forms.TreeNode("Binary, octal, hex and decimal conversions");
            System.Windows.Forms.TreeNode treeNode581 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode580});
            System.Windows.Forms.TreeNode treeNode582 = new System.Windows.Forms.TreeNode("Replace method added");
            System.Windows.Forms.TreeNode treeNode583 = new System.Windows.Forms.TreeNode("FindAll method added");
            System.Windows.Forms.TreeNode treeNode584 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode582,
            treeNode583});
            System.Windows.Forms.TreeNode treeNode585 = new System.Windows.Forms.TreeNode("Version 1.0.0.81", new System.Windows.Forms.TreeNode[] {
            treeNode573,
            treeNode575,
            treeNode577,
            treeNode579,
            treeNode581,
            treeNode584});
            System.Windows.Forms.TreeNode treeNode586 = new System.Windows.Forms.TreeNode("BrushColour, BrushGradientShape and PenColour implemented for buttons");
            System.Windows.Forms.TreeNode treeNode587 = new System.Windows.Forms.TreeNode("General events for shapes added (see ShapeEvents sample)");
            System.Windows.Forms.TreeNode treeNode588 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode586,
            treeNode587});
            System.Windows.Forms.TreeNode treeNode589 = new System.Windows.Forms.TreeNode("Truncate method added");
            System.Windows.Forms.TreeNode treeNode590 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode589});
            System.Windows.Forms.TreeNode treeNode591 = new System.Windows.Forms.TreeNode("Additional text methods");
            System.Windows.Forms.TreeNode treeNode592 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode591});
            System.Windows.Forms.TreeNode treeNode593 = new System.Windows.Forms.TreeNode("Version 1.0.0.80", new System.Windows.Forms.TreeNode[] {
            treeNode588,
            treeNode590,
            treeNode592});
            System.Windows.Forms.TreeNode treeNode594 = new System.Windows.Forms.TreeNode("Confirm dialog message box (Yes, No, Cancel) added");
            System.Windows.Forms.TreeNode treeNode595 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode594});
            System.Windows.Forms.TreeNode treeNode596 = new System.Windows.Forms.TreeNode("CancelClose property added for GraphicsWindow closure");
            System.Windows.Forms.TreeNode treeNode597 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode596});
            System.Windows.Forms.TreeNode treeNode598 = new System.Windows.Forms.TreeNode("Version 1.0.0.79", new System.Windows.Forms.TreeNode[] {
            treeNode595,
            treeNode597});
            System.Windows.Forms.TreeNode treeNode599 = new System.Windows.Forms.TreeNode("Rasterize property added");
            System.Windows.Forms.TreeNode treeNode600 = new System.Windows.Forms.TreeNode("Improvements associated with window resizing");
            System.Windows.Forms.TreeNode treeNode601 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode599,
            treeNode600});
            System.Windows.Forms.TreeNode treeNode602 = new System.Windows.Forms.TreeNode("ExitOnClose property (and GWClosing event) added");
            System.Windows.Forms.TreeNode treeNode603 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode602});
            System.Windows.Forms.TreeNode treeNode604 = new System.Windows.Forms.TreeNode("Version 1.0.0.78", new System.Windows.Forms.TreeNode[] {
            treeNode601,
            treeNode603});
            System.Windows.Forms.TreeNode treeNode605 = new System.Windows.Forms.TreeNode("Handle more than 100 drawables (rasterization)");
            System.Windows.Forms.TreeNode treeNode606 = new System.Windows.Forms.TreeNode("LDScollBars", new System.Windows.Forms.TreeNode[] {
            treeNode605});
            System.Windows.Forms.TreeNode treeNode607 = new System.Windows.Forms.TreeNode("Version 1.0.0.77", new System.Windows.Forms.TreeNode[] {
            treeNode606});
            System.Windows.Forms.TreeNode treeNode608 = new System.Windows.Forms.TreeNode("Record sound from a microphone");
            System.Windows.Forms.TreeNode treeNode609 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode608});
            System.Windows.Forms.TreeNode treeNode610 = new System.Windows.Forms.TreeNode("AnimateOpacity method added (flashing)");
            System.Windows.Forms.TreeNode treeNode611 = new System.Windows.Forms.TreeNode("AnimateRotation method added (continuous rotation)");
            System.Windows.Forms.TreeNode treeNode612 = new System.Windows.Forms.TreeNode("AnimateZoom method added (coninuous zooming)");
            System.Windows.Forms.TreeNode treeNode613 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode610,
            treeNode611,
            treeNode612});
            System.Windows.Forms.TreeNode treeNode614 = new System.Windows.Forms.TreeNode("Version 1.0.0.76", new System.Windows.Forms.TreeNode[] {
            treeNode609,
            treeNode613});
            System.Windows.Forms.TreeNode treeNode615 = new System.Windows.Forms.TreeNode("AddAnimatedImage can use an ImageList image");
            System.Windows.Forms.TreeNode treeNode616 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode615});
            System.Windows.Forms.TreeNode treeNode617 = new System.Windows.Forms.TreeNode("Version 1.0.0.75", new System.Windows.Forms.TreeNode[] {
            treeNode616});
            System.Windows.Forms.TreeNode treeNode618 = new System.Windows.Forms.TreeNode("Initial graph axes scaling improvement");
            System.Windows.Forms.TreeNode treeNode619 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode618});
            System.Windows.Forms.TreeNode treeNode620 = new System.Windows.Forms.TreeNode("Methods to access a bluetooth device");
            System.Windows.Forms.TreeNode treeNode621 = new System.Windows.Forms.TreeNode("Includes simple file transfer and potentially advanced device interaction");
            System.Windows.Forms.TreeNode treeNode622 = new System.Windows.Forms.TreeNode("LDBlueTooth", new System.Windows.Forms.TreeNode[] {
            treeNode620,
            treeNode621});
            System.Windows.Forms.TreeNode treeNode623 = new System.Windows.Forms.TreeNode("getFocus handles multiple LDWindows");
            System.Windows.Forms.TreeNode treeNode624 = new System.Windows.Forms.TreeNode("LDFocus", new System.Windows.Forms.TreeNode[] {
            treeNode623});
            System.Windows.Forms.TreeNode treeNode625 = new System.Windows.Forms.TreeNode("Version 1.0.0.74", new System.Windows.Forms.TreeNode[] {
            treeNode619,
            treeNode622,
            treeNode624});
            System.Windows.Forms.TreeNode treeNode626 = new System.Windows.Forms.TreeNode("First pass at a generic USB (HID) device controller");
            System.Windows.Forms.TreeNode treeNode627 = new System.Windows.Forms.TreeNode("LDHID", new System.Windows.Forms.TreeNode[] {
            treeNode626});
            System.Windows.Forms.TreeNode treeNode628 = new System.Windows.Forms.TreeNode("Version 1.0.0.73", new System.Windows.Forms.TreeNode[] {
            treeNode627});
            System.Windows.Forms.TreeNode treeNode629 = new System.Windows.Forms.TreeNode("Initial scaling doesn\'t position points touching the axes");
            System.Windows.Forms.TreeNode treeNode630 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode629});
            System.Windows.Forms.TreeNode treeNode631 = new System.Windows.Forms.TreeNode("Version 1.0.0.72", new System.Windows.Forms.TreeNode[] {
            treeNode630});
            System.Windows.Forms.TreeNode treeNode632 = new System.Windows.Forms.TreeNode("TrendCoef method added to get polynomial trend line coefficients");
            System.Windows.Forms.TreeNode treeNode633 = new System.Windows.Forms.TreeNode("TrendPointCount property added to control the number of points on a trend line");
            System.Windows.Forms.TreeNode treeNode634 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode632,
            treeNode633});
            System.Windows.Forms.TreeNode treeNode635 = new System.Windows.Forms.TreeNode("Version 1.0.0.71", new System.Windows.Forms.TreeNode[] {
            treeNode634});
            System.Windows.Forms.TreeNode treeNode636 = new System.Windows.Forms.TreeNode("Spurious error message fixed");
            System.Windows.Forms.TreeNode treeNode637 = new System.Windows.Forms.TreeNode("CreateTrend data series creation method added");
            System.Windows.Forms.TreeNode treeNode638 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode636,
            treeNode637});
            System.Windows.Forms.TreeNode treeNode639 = new System.Windows.Forms.TreeNode("Version 1.0.0.70", new System.Windows.Forms.TreeNode[] {
            treeNode638});
            System.Windows.Forms.TreeNode treeNode640 = new System.Windows.Forms.TreeNode("Font properties and colours set for LDControls in the same way as standard Contro" +
        "ls");
            System.Windows.Forms.TreeNode treeNode641 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode640});
            System.Windows.Forms.TreeNode treeNode642 = new System.Windows.Forms.TreeNode("Version 1.0.0.69", new System.Windows.Forms.TreeNode[] {
            treeNode641});
            System.Windows.Forms.TreeNode treeNode643 = new System.Windows.Forms.TreeNode("Radio button control added");
            System.Windows.Forms.TreeNode treeNode644 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode643});
            System.Windows.Forms.TreeNode treeNode645 = new System.Windows.Forms.TreeNode("Version 1.0.0.68", new System.Windows.Forms.TreeNode[] {
            treeNode644});
            System.Windows.Forms.TreeNode treeNode646 = new System.Windows.Forms.TreeNode("Bug fix for Copy");
            System.Windows.Forms.TreeNode treeNode647 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode646});
            System.Windows.Forms.TreeNode treeNode648 = new System.Windows.Forms.TreeNode("Version 1.0.0.67", new System.Windows.Forms.TreeNode[] {
            treeNode647});
            System.Windows.Forms.TreeNode treeNode649 = new System.Windows.Forms.TreeNode("RegexMatch and RegexReplace methods added");
            System.Windows.Forms.TreeNode treeNode650 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode649});
            System.Windows.Forms.TreeNode treeNode651 = new System.Windows.Forms.TreeNode("Version 1.0.0.66", new System.Windows.Forms.TreeNode[] {
            treeNode650});
            System.Windows.Forms.TreeNode treeNode652 = new System.Windows.Forms.TreeNode("Number culture conversions added");
            System.Windows.Forms.TreeNode treeNode653 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode652});
            System.Windows.Forms.TreeNode treeNode654 = new System.Windows.Forms.TreeNode("Version 1.0.0.65", new System.Windows.Forms.TreeNode[] {
            treeNode653});
            System.Windows.Forms.TreeNode treeNode655 = new System.Windows.Forms.TreeNode("IsNumber method added");
            System.Windows.Forms.TreeNode treeNode656 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode655});
            System.Windows.Forms.TreeNode treeNode657 = new System.Windows.Forms.TreeNode("Version 1.0.0.64", new System.Windows.Forms.TreeNode[] {
            treeNode656});
            System.Windows.Forms.TreeNode treeNode658 = new System.Windows.Forms.TreeNode("SetCursorPosition method added for textboxes");
            System.Windows.Forms.TreeNode treeNode659 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode658});
            System.Windows.Forms.TreeNode treeNode660 = new System.Windows.Forms.TreeNode("Version 1.0.0.63", new System.Windows.Forms.TreeNode[] {
            treeNode659});
            System.Windows.Forms.TreeNode treeNode661 = new System.Windows.Forms.TreeNode("SetCursorToEnd method added for textboxes");
            System.Windows.Forms.TreeNode treeNode662 = new System.Windows.Forms.TreeNode("SetSpellCheck method added for textboxes and richtextboxes");
            System.Windows.Forms.TreeNode treeNode663 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode661,
            treeNode662});
            System.Windows.Forms.TreeNode treeNode664 = new System.Windows.Forms.TreeNode("Version 1.0.0.62", new System.Windows.Forms.TreeNode[] {
            treeNode663});
            System.Windows.Forms.TreeNode treeNode665 = new System.Windows.Forms.TreeNode("Adding polygons not located at (0,0) corrected");
            System.Windows.Forms.TreeNode treeNode666 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode665});
            System.Windows.Forms.TreeNode treeNode667 = new System.Windows.Forms.TreeNode("Version 1.0.0.61", new System.Windows.Forms.TreeNode[] {
            treeNode666});
            System.Windows.Forms.TreeNode treeNode668 = new System.Windows.Forms.TreeNode("GetFolder dialog added");
            System.Windows.Forms.TreeNode treeNode669 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode668});
            System.Windows.Forms.TreeNode treeNode670 = new System.Windows.Forms.TreeNode("Version 1.0.0.60", new System.Windows.Forms.TreeNode[] {
            treeNode669});
            System.Windows.Forms.TreeNode treeNode671 = new System.Windows.Forms.TreeNode("Possible localization issue with Font size fixed");
            System.Windows.Forms.TreeNode treeNode672 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode671});
            System.Windows.Forms.TreeNode treeNode673 = new System.Windows.Forms.TreeNode("Version 1.0.0.59", new System.Windows.Forms.TreeNode[] {
            treeNode672});
            System.Windows.Forms.TreeNode treeNode674 = new System.Windows.Forms.TreeNode("More internationalization fixes");
            System.Windows.Forms.TreeNode treeNode675 = new System.Windows.Forms.TreeNode("ShowPrintPreview property added");
            System.Windows.Forms.TreeNode treeNode676 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode675});
            System.Windows.Forms.TreeNode treeNode677 = new System.Windows.Forms.TreeNode("Possible error with gradient drawings fixed");
            System.Windows.Forms.TreeNode treeNode678 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode677});
            System.Windows.Forms.TreeNode treeNode679 = new System.Windows.Forms.TreeNode("Possible Listen event initialisation error fixed");
            System.Windows.Forms.TreeNode treeNode680 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode679});
            System.Windows.Forms.TreeNode treeNode681 = new System.Windows.Forms.TreeNode("Version 1.0.0.58", new System.Windows.Forms.TreeNode[] {
            treeNode674,
            treeNode676,
            treeNode678,
            treeNode680});
            System.Windows.Forms.TreeNode treeNode682 = new System.Windows.Forms.TreeNode("Many possible internationisation issues fixed");
            System.Windows.Forms.TreeNode treeNode683 = new System.Windows.Forms.TreeNode("Version 1.0.0.57", new System.Windows.Forms.TreeNode[] {
            treeNode682});
            System.Windows.Forms.TreeNode treeNode684 = new System.Windows.Forms.TreeNode("Emmisive colour correction for AddGeometry");
            System.Windows.Forms.TreeNode treeNode685 = new System.Windows.Forms.TreeNode("Geometry coordinates etc are now colon or space deminiated (not comma)");
            System.Windows.Forms.TreeNode treeNode686 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode684,
            treeNode685});
            System.Windows.Forms.TreeNode treeNode687 = new System.Windows.Forms.TreeNode("CSVdeminiator property added");
            System.Windows.Forms.TreeNode treeNode688 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode687});
            System.Windows.Forms.TreeNode treeNode689 = new System.Windows.Forms.TreeNode("Version 1.0.0.56", new System.Windows.Forms.TreeNode[] {
            treeNode686,
            treeNode688});
            System.Windows.Forms.TreeNode treeNode690 = new System.Windows.Forms.TreeNode("Improved error reporting");
            System.Windows.Forms.TreeNode treeNode691 = new System.Windows.Forms.TreeNode("Culture invariant type conversions");
            System.Windows.Forms.TreeNode treeNode692 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode691});
            System.Windows.Forms.TreeNode treeNode693 = new System.Windows.Forms.TreeNode("ShowErrors method added");
            System.Windows.Forms.TreeNode treeNode694 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode693});
            System.Windows.Forms.TreeNode treeNode695 = new System.Windows.Forms.TreeNode("Version 1.0.0.55", new System.Windows.Forms.TreeNode[] {
            treeNode690,
            treeNode692,
            treeNode694});
            System.Windows.Forms.TreeNode treeNode696 = new System.Windows.Forms.TreeNode("Warning added to intellisense help about  resizing GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode697 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode696});
            System.Windows.Forms.TreeNode treeNode698 = new System.Windows.Forms.TreeNode("GWWidth and GWHeight added for use with LDScrollBars");
            System.Windows.Forms.TreeNode treeNode699 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode698});
            System.Windows.Forms.TreeNode treeNode700 = new System.Windows.Forms.TreeNode("Version 1.0.0.54", new System.Windows.Forms.TreeNode[] {
            treeNode697,
            treeNode699});
            System.Windows.Forms.TreeNode treeNode701 = new System.Windows.Forms.TreeNode("Debug window can be resized");
            System.Windows.Forms.TreeNode treeNode702 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode701});
            System.Windows.Forms.TreeNode treeNode703 = new System.Windows.Forms.TreeNode("PrintFile method added");
            System.Windows.Forms.TreeNode treeNode704 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode703});
            System.Windows.Forms.TreeNode treeNode705 = new System.Windows.Forms.TreeNode("Version 1.0.0.53", new System.Windows.Forms.TreeNode[] {
            treeNode702,
            treeNode704});
            System.Windows.Forms.TreeNode treeNode706 = new System.Windows.Forms.TreeNode("SSL property option added");
            System.Windows.Forms.TreeNode treeNode707 = new System.Windows.Forms.TreeNode("LDEmail", new System.Windows.Forms.TreeNode[] {
            treeNode706});
            System.Windows.Forms.TreeNode treeNode708 = new System.Windows.Forms.TreeNode("Version 1.0.0.52", new System.Windows.Forms.TreeNode[] {
            treeNode707});
            System.Windows.Forms.TreeNode treeNode709 = new System.Windows.Forms.TreeNode("Right Click Context menu added for any shape or control");
            System.Windows.Forms.TreeNode treeNode710 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode709});
            System.Windows.Forms.TreeNode treeNode711 = new System.Windows.Forms.TreeNode("Version 1.0.0.51", new System.Windows.Forms.TreeNode[] {
            treeNode710});
            System.Windows.Forms.TreeNode treeNode712 = new System.Windows.Forms.TreeNode("Right click dropdown menu option added");
            System.Windows.Forms.TreeNode treeNode713 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode712});
            System.Windows.Forms.TreeNode treeNode714 = new System.Windows.Forms.TreeNode("Version 1.0.0.50", new System.Windows.Forms.TreeNode[] {
            treeNode713});
            System.Windows.Forms.TreeNode treeNode715 = new System.Windows.Forms.TreeNode("More methods added, AddSphere, AddTube, ReverseNormals");
            System.Windows.Forms.TreeNode treeNode716 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode715});
            System.Windows.Forms.TreeNode treeNode717 = new System.Windows.Forms.TreeNode("Version 1.0.0.49", new System.Windows.Forms.TreeNode[] {
            treeNode716});
            System.Windows.Forms.TreeNode treeNode718 = new System.Windows.Forms.TreeNode("Performance improvements (some camera controls for this)");
            System.Windows.Forms.TreeNode treeNode719 = new System.Windows.Forms.TreeNode("LoadModel (*.3ds) files added");
            System.Windows.Forms.TreeNode treeNode720 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode718,
            treeNode719});
            System.Windows.Forms.TreeNode treeNode721 = new System.Windows.Forms.TreeNode("AddStar and AddRegularPolygon shape methods added");
            System.Windows.Forms.TreeNode treeNode722 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode721});
            System.Windows.Forms.TreeNode treeNode723 = new System.Windows.Forms.TreeNode("Version 1.0.0.48", new System.Windows.Forms.TreeNode[] {
            treeNode720,
            treeNode722});
            System.Windows.Forms.TreeNode treeNode724 = new System.Windows.Forms.TreeNode("Some improvements including animations");
            System.Windows.Forms.TreeNode treeNode725 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode724});
            System.Windows.Forms.TreeNode treeNode726 = new System.Windows.Forms.TreeNode("Version 1.0.0.47", new System.Windows.Forms.TreeNode[] {
            treeNode725});
            System.Windows.Forms.TreeNode treeNode727 = new System.Windows.Forms.TreeNode("Some improvemts and new methods");
            System.Windows.Forms.TreeNode treeNode728 = new System.Windows.Forms.TreeNode("LD3Dview", new System.Windows.Forms.TreeNode[] {
            treeNode727});
            System.Windows.Forms.TreeNode treeNode729 = new System.Windows.Forms.TreeNode("Version 1.0.0.46", new System.Windows.Forms.TreeNode[] {
            treeNode728});
            System.Windows.Forms.TreeNode treeNode730 = new System.Windows.Forms.TreeNode("A start at a 3D set of methods");
            System.Windows.Forms.TreeNode treeNode731 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode730});
            System.Windows.Forms.TreeNode treeNode732 = new System.Windows.Forms.TreeNode("Version 1.0.0.45", new System.Windows.Forms.TreeNode[] {
            treeNode731});
            System.Windows.Forms.TreeNode treeNode733 = new System.Windows.Forms.TreeNode("Create scrollbars for the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode734 = new System.Windows.Forms.TreeNode("Methods to control the scrollbars allowing a scrolling game to be made");
            System.Windows.Forms.TreeNode treeNode735 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode733,
            treeNode734});
            System.Windows.Forms.TreeNode treeNode736 = new System.Windows.Forms.TreeNode("ColourList method added");
            System.Windows.Forms.TreeNode treeNode737 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode736});
            System.Windows.Forms.TreeNode treeNode738 = new System.Windows.Forms.TreeNode("Linear and radial gradient methods for shapes, drawings and background");
            System.Windows.Forms.TreeNode treeNode739 = new System.Windows.Forms.TreeNode("BackgroundImage method to set the background added");
            System.Windows.Forms.TreeNode treeNode740 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode738,
            treeNode739});
            System.Windows.Forms.TreeNode treeNode741 = new System.Windows.Forms.TreeNode("Version 1.0.0.44", new System.Windows.Forms.TreeNode[] {
            treeNode735,
            treeNode737,
            treeNode740});
            System.Windows.Forms.TreeNode treeNode742 = new System.Windows.Forms.TreeNode("AddScrollBars method added for the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode743 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode742});
            System.Windows.Forms.TreeNode treeNode744 = new System.Windows.Forms.TreeNode("Version 1.0.0.43", new System.Windows.Forms.TreeNode[] {
            treeNode743});
            System.Windows.Forms.TreeNode treeNode745 = new System.Windows.Forms.TreeNode("Call Subs as functions with arguments");
            System.Windows.Forms.TreeNode treeNode746 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode745});
            System.Windows.Forms.TreeNode treeNode747 = new System.Windows.Forms.TreeNode("Version 1.0.0.42", new System.Windows.Forms.TreeNode[] {
            treeNode746});
            System.Windows.Forms.TreeNode treeNode748 = new System.Windows.Forms.TreeNode("Font dialog added");
            System.Windows.Forms.TreeNode treeNode749 = new System.Windows.Forms.TreeNode("Colours dialog moved here from LDColours");
            System.Windows.Forms.TreeNode treeNode750 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode748,
            treeNode749});
            System.Windows.Forms.TreeNode treeNode751 = new System.Windows.Forms.TreeNode("Version 1.0.0.41", new System.Windows.Forms.TreeNode[] {
            treeNode750});
            System.Windows.Forms.TreeNode treeNode752 = new System.Windows.Forms.TreeNode("Controls methods (RichTextBox and TreeView) moved here from LDDialogs");
            System.Windows.Forms.TreeNode treeNode753 = new System.Windows.Forms.TreeNode("WebBrowser, ListBox, ComboBox and CheckBox objects added");
            System.Windows.Forms.TreeNode treeNode754 = new System.Windows.Forms.TreeNode("Some methods renamed");
            System.Windows.Forms.TreeNode treeNode755 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode752,
            treeNode753,
            treeNode754});
            System.Windows.Forms.TreeNode treeNode756 = new System.Windows.Forms.TreeNode("HighScore method move here");
            System.Windows.Forms.TreeNode treeNode757 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode756});
            System.Windows.Forms.TreeNode treeNode758 = new System.Windows.Forms.TreeNode("SetSize method added");
            System.Windows.Forms.TreeNode treeNode759 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode758});
            System.Windows.Forms.TreeNode treeNode760 = new System.Windows.Forms.TreeNode("Version 1.0.0.40", new System.Windows.Forms.TreeNode[] {
            treeNode755,
            treeNode757,
            treeNode759});
            System.Windows.Forms.TreeNode treeNode761 = new System.Windows.Forms.TreeNode("SelectTreeView method added");
            System.Windows.Forms.TreeNode treeNode762 = new System.Windows.Forms.TreeNode("A currently selected node also registers selection event when it is clicked");
            System.Windows.Forms.TreeNode treeNode763 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode761,
            treeNode762});
            System.Windows.Forms.TreeNode treeNode764 = new System.Windows.Forms.TreeNode("Simple high score web method");
            System.Windows.Forms.TreeNode treeNode765 = new System.Windows.Forms.TreeNode("LDHighScore", new System.Windows.Forms.TreeNode[] {
            treeNode764});
            System.Windows.Forms.TreeNode treeNode766 = new System.Windows.Forms.TreeNode("Version 1.0.0.39", new System.Windows.Forms.TreeNode[] {
            treeNode763,
            treeNode765});
            System.Windows.Forms.TreeNode treeNode767 = new System.Windows.Forms.TreeNode("RichTextBox methods improved");
            System.Windows.Forms.TreeNode treeNode768 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode767});
            System.Windows.Forms.TreeNode treeNode769 = new System.Windows.Forms.TreeNode("Search, Load and Save methods added");
            System.Windows.Forms.TreeNode treeNode770 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode769});
            System.Windows.Forms.TreeNode treeNode771 = new System.Windows.Forms.TreeNode("Version 1.0.0.38", new System.Windows.Forms.TreeNode[] {
            treeNode768,
            treeNode770});
            System.Windows.Forms.TreeNode treeNode772 = new System.Windows.Forms.TreeNode("Depreciated");
            System.Windows.Forms.TreeNode treeNode773 = new System.Windows.Forms.TreeNode("LDWeather", new System.Windows.Forms.TreeNode[] {
            treeNode772});
            System.Windows.Forms.TreeNode treeNode774 = new System.Windows.Forms.TreeNode("Renamed from LDTrig and some more methods added");
            System.Windows.Forms.TreeNode treeNode775 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode774});
            System.Windows.Forms.TreeNode treeNode776 = new System.Windows.Forms.TreeNode("RichTextBox method added");
            System.Windows.Forms.TreeNode treeNode777 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode776});
            System.Windows.Forms.TreeNode treeNode778 = new System.Windows.Forms.TreeNode("FontList method added");
            System.Windows.Forms.TreeNode treeNode779 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode778});
            System.Windows.Forms.TreeNode treeNode780 = new System.Windows.Forms.TreeNode("Version 1.0.0.37", new System.Windows.Forms.TreeNode[] {
            treeNode773,
            treeNode775,
            treeNode777,
            treeNode779});
            System.Windows.Forms.TreeNode treeNode781 = new System.Windows.Forms.TreeNode("Zip method extended");
            System.Windows.Forms.TreeNode treeNode782 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode781});
            System.Windows.Forms.TreeNode treeNode783 = new System.Windows.Forms.TreeNode("Version 1.0.0.36", new System.Windows.Forms.TreeNode[] {
            treeNode782});
            System.Windows.Forms.TreeNode treeNode784 = new System.Windows.Forms.TreeNode("Collapse and expand treeview nodes method added");
            System.Windows.Forms.TreeNode treeNode785 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode784});
            System.Windows.Forms.TreeNode treeNode786 = new System.Windows.Forms.TreeNode("Version 1.0.0.35", new System.Windows.Forms.TreeNode[] {
            treeNode785});
            System.Windows.Forms.TreeNode treeNode787 = new System.Windows.Forms.TreeNode("Arguments added to Start method");
            System.Windows.Forms.TreeNode treeNode788 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode787});
            System.Windows.Forms.TreeNode treeNode789 = new System.Windows.Forms.TreeNode("Zip compression methods added");
            System.Windows.Forms.TreeNode treeNode790 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode789});
            System.Windows.Forms.TreeNode treeNode791 = new System.Windows.Forms.TreeNode("Version 1.0.0.34", new System.Windows.Forms.TreeNode[] {
            treeNode788,
            treeNode790});
            System.Windows.Forms.TreeNode treeNode792 = new System.Windows.Forms.TreeNode("GWStyle property added");
            System.Windows.Forms.TreeNode treeNode793 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode792});
            System.Windows.Forms.TreeNode treeNode794 = new System.Windows.Forms.TreeNode("TreeView and associated events added");
            System.Windows.Forms.TreeNode treeNode795 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode794});
            System.Windows.Forms.TreeNode treeNode796 = new System.Windows.Forms.TreeNode("Version 1.0.0.33", new System.Windows.Forms.TreeNode[] {
            treeNode793,
            treeNode795});
            System.Windows.Forms.TreeNode treeNode797 = new System.Windows.Forms.TreeNode("Possible end points not plotting bug fixed");
            System.Windows.Forms.TreeNode treeNode798 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode797});
            System.Windows.Forms.TreeNode treeNode799 = new System.Windows.Forms.TreeNode("Version 1.0.0.32", new System.Windows.Forms.TreeNode[] {
            treeNode798});
            System.Windows.Forms.TreeNode treeNode800 = new System.Windows.Forms.TreeNode("Activated event and Active property addded");
            System.Windows.Forms.TreeNode treeNode801 = new System.Windows.Forms.TreeNode("LDWindows", new System.Windows.Forms.TreeNode[] {
            treeNode800});
            System.Windows.Forms.TreeNode treeNode802 = new System.Windows.Forms.TreeNode("Version 1.0.0.31", new System.Windows.Forms.TreeNode[] {
            treeNode801});
            System.Windows.Forms.TreeNode treeNode803 = new System.Windows.Forms.TreeNode("Create multiple GraphicsWindows");
            System.Windows.Forms.TreeNode treeNode804 = new System.Windows.Forms.TreeNode("LDWindows", new System.Windows.Forms.TreeNode[] {
            treeNode803});
            System.Windows.Forms.TreeNode treeNode805 = new System.Windows.Forms.TreeNode("Version 1.0.0.30", new System.Windows.Forms.TreeNode[] {
            treeNode804});
            System.Windows.Forms.TreeNode treeNode806 = new System.Windows.Forms.TreeNode("Email sending method");
            System.Windows.Forms.TreeNode treeNode807 = new System.Windows.Forms.TreeNode("LDMail", new System.Windows.Forms.TreeNode[] {
            treeNode806});
            System.Windows.Forms.TreeNode treeNode808 = new System.Windows.Forms.TreeNode("Add and Multiply methods bug fixed");
            System.Windows.Forms.TreeNode treeNode809 = new System.Windows.Forms.TreeNode("Image statistics combined into one method");
            System.Windows.Forms.TreeNode treeNode810 = new System.Windows.Forms.TreeNode("Histogram method added");
            System.Windows.Forms.TreeNode treeNode811 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode808,
            treeNode809,
            treeNode810});
            System.Windows.Forms.TreeNode treeNode812 = new System.Windows.Forms.TreeNode("Version 1.0.0.29", new System.Windows.Forms.TreeNode[] {
            treeNode807,
            treeNode811});
            System.Windows.Forms.TreeNode treeNode813 = new System.Windows.Forms.TreeNode("SnapshotToImageList method added");
            System.Windows.Forms.TreeNode treeNode814 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode813});
            System.Windows.Forms.TreeNode treeNode815 = new System.Windows.Forms.TreeNode("ImageList image manipulation methods");
            System.Windows.Forms.TreeNode treeNode816 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode815});
            System.Windows.Forms.TreeNode treeNode817 = new System.Windows.Forms.TreeNode("Version 1.0.0.28", new System.Windows.Forms.TreeNode[] {
            treeNode814,
            treeNode816});
            System.Windows.Forms.TreeNode treeNode818 = new System.Windows.Forms.TreeNode("SortIndex bugfix for null values");
            System.Windows.Forms.TreeNode treeNode819 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode818});
            System.Windows.Forms.TreeNode treeNode820 = new System.Windows.Forms.TreeNode("SnapshotToFile bug fixed");
            System.Windows.Forms.TreeNode treeNode821 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode820});
            System.Windows.Forms.TreeNode treeNode822 = new System.Windows.Forms.TreeNode("Version 1.0.0.27", new System.Windows.Forms.TreeNode[] {
            treeNode819,
            treeNode821});
            System.Windows.Forms.TreeNode treeNode823 = new System.Windows.Forms.TreeNode("SortIndex method added");
            System.Windows.Forms.TreeNode treeNode824 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode823});
            System.Windows.Forms.TreeNode treeNode825 = new System.Windows.Forms.TreeNode("Web based weather report data added");
            System.Windows.Forms.TreeNode treeNode826 = new System.Windows.Forms.TreeNode("LDWeather", new System.Windows.Forms.TreeNode[] {
            treeNode825});
            System.Windows.Forms.TreeNode treeNode827 = new System.Windows.Forms.TreeNode("DataReceived event added");
            System.Windows.Forms.TreeNode treeNode828 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode827});
            System.Windows.Forms.TreeNode treeNode829 = new System.Windows.Forms.TreeNode("Version 1.0.0.26", new System.Windows.Forms.TreeNode[] {
            treeNode824,
            treeNode826,
            treeNode828});
            System.Windows.Forms.TreeNode treeNode830 = new System.Windows.Forms.TreeNode("Speech recognition added");
            System.Windows.Forms.TreeNode treeNode831 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode830});
            System.Windows.Forms.TreeNode treeNode832 = new System.Windows.Forms.TreeNode("Version 1.0.0.25", new System.Windows.Forms.TreeNode[] {
            treeNode831});
            System.Windows.Forms.TreeNode treeNode833 = new System.Windows.Forms.TreeNode("More methods added and some internal code optimised");
            System.Windows.Forms.TreeNode treeNode834 = new System.Windows.Forms.TreeNode("LDArray & LDMatrix", new System.Windows.Forms.TreeNode[] {
            treeNode833});
            System.Windows.Forms.TreeNode treeNode835 = new System.Windows.Forms.TreeNode("KeyDown method added");
            System.Windows.Forms.TreeNode treeNode836 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode835});
            System.Windows.Forms.TreeNode treeNode837 = new System.Windows.Forms.TreeNode("GetAllShapesAt method added");
            System.Windows.Forms.TreeNode treeNode838 = new System.Windows.Forms.TreeNode("Overlap method for ellipse and rectangle combinations added");
            System.Windows.Forms.TreeNode treeNode839 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode837,
            treeNode838});
            System.Windows.Forms.TreeNode treeNode840 = new System.Windows.Forms.TreeNode("Version 1.0.0.24", new System.Windows.Forms.TreeNode[] {
            treeNode834,
            treeNode836,
            treeNode839});
            System.Windows.Forms.TreeNode treeNode841 = new System.Windows.Forms.TreeNode("OpenFile and SaveFile dialogs added");
            System.Windows.Forms.TreeNode treeNode842 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode841});
            System.Windows.Forms.TreeNode treeNode843 = new System.Windows.Forms.TreeNode("Matrix methods, for example to solve linear equations");
            System.Windows.Forms.TreeNode treeNode844 = new System.Windows.Forms.TreeNode("LDMatrix", new System.Windows.Forms.TreeNode[] {
            treeNode843});
            System.Windows.Forms.TreeNode treeNode845 = new System.Windows.Forms.TreeNode("Version 1.0.0.23", new System.Windows.Forms.TreeNode[] {
            treeNode842,
            treeNode844});
            System.Windows.Forms.TreeNode treeNode846 = new System.Windows.Forms.TreeNode("Sorting method added");
            System.Windows.Forms.TreeNode treeNode847 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode846});
            System.Windows.Forms.TreeNode treeNode848 = new System.Windows.Forms.TreeNode("Version 1.0.0.22", new System.Windows.Forms.TreeNode[] {
            treeNode847});
            System.Windows.Forms.TreeNode treeNode849 = new System.Windows.Forms.TreeNode("Velocity Threshold setting added");
            System.Windows.Forms.TreeNode treeNode850 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode849});
            System.Windows.Forms.TreeNode treeNode851 = new System.Windows.Forms.TreeNode("Version 1.0.0.21", new System.Windows.Forms.TreeNode[] {
            treeNode850});
            System.Windows.Forms.TreeNode treeNode852 = new System.Windows.Forms.TreeNode("SetDamping method added");
            System.Windows.Forms.TreeNode treeNode853 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode852});
            System.Windows.Forms.TreeNode treeNode854 = new System.Windows.Forms.TreeNode("Version 1.0.0.20", new System.Windows.Forms.TreeNode[] {
            treeNode853});
            System.Windows.Forms.TreeNode treeNode855 = new System.Windows.Forms.TreeNode("Instrument name can be obtained from its number");
            System.Windows.Forms.TreeNode treeNode856 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode855});
            System.Windows.Forms.TreeNode treeNode857 = new System.Windows.Forms.TreeNode("Version 1.0.0.19", new System.Windows.Forms.TreeNode[] {
            treeNode856});
            System.Windows.Forms.TreeNode treeNode858 = new System.Windows.Forms.TreeNode("Calendar uses MS visual styles if available (better calendar, but no colours)");
            System.Windows.Forms.TreeNode treeNode859 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode858});
            System.Windows.Forms.TreeNode treeNode860 = new System.Windows.Forms.TreeNode("Extends Sounds.PlayMusic to include additional instruments");
            System.Windows.Forms.TreeNode treeNode861 = new System.Windows.Forms.TreeNode("Notes can also be played synchronously (chords)");
            System.Windows.Forms.TreeNode treeNode862 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode860,
            treeNode861});
            System.Windows.Forms.TreeNode treeNode863 = new System.Windows.Forms.TreeNode("Version 1.0.0.18", new System.Windows.Forms.TreeNode[] {
            treeNode859,
            treeNode862});
            System.Windows.Forms.TreeNode treeNode864 = new System.Windows.Forms.TreeNode("AnimationPause and AnimationResume methods added");
            System.Windows.Forms.TreeNode treeNode865 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode864});
            System.Windows.Forms.TreeNode treeNode866 = new System.Windows.Forms.TreeNode("Process list indexed by ID rather than name");
            System.Windows.Forms.TreeNode treeNode867 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode866});
            System.Windows.Forms.TreeNode treeNode868 = new System.Windows.Forms.TreeNode("Version 1.0.0.17", new System.Windows.Forms.TreeNode[] {
            treeNode865,
            treeNode867});
            System.Windows.Forms.TreeNode treeNode869 = new System.Windows.Forms.TreeNode("More effects added");
            System.Windows.Forms.TreeNode treeNode870 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode869});
            System.Windows.Forms.TreeNode treeNode871 = new System.Windows.Forms.TreeNode("Add or change an image on a button or image shape");
            System.Windows.Forms.TreeNode treeNode872 = new System.Windows.Forms.TreeNode("Add an animated gif or tiled image");
            System.Windows.Forms.TreeNode treeNode873 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode871,
            treeNode872});
            System.Windows.Forms.TreeNode treeNode874 = new System.Windows.Forms.TreeNode("Version 1.0.0.16", new System.Windows.Forms.TreeNode[] {
            treeNode870,
            treeNode873});
            System.Windows.Forms.TreeNode treeNode875 = new System.Windows.Forms.TreeNode("A webcam object for the GraphicsWindow, including a picture taking function");
            System.Windows.Forms.TreeNode treeNode876 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode875});
            System.Windows.Forms.TreeNode treeNode877 = new System.Windows.Forms.TreeNode("Version 1.0.0.15", new System.Windows.Forms.TreeNode[] {
            treeNode876});
            System.Windows.Forms.TreeNode treeNode878 = new System.Windows.Forms.TreeNode("Variables may be changed during a debug session");
            System.Windows.Forms.TreeNode treeNode879 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode878});
            System.Windows.Forms.TreeNode treeNode880 = new System.Windows.Forms.TreeNode("Version 1.0.0.14", new System.Windows.Forms.TreeNode[] {
            treeNode879});
            System.Windows.Forms.TreeNode treeNode881 = new System.Windows.Forms.TreeNode("A basic debugging tool");
            System.Windows.Forms.TreeNode treeNode882 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode881});
            System.Windows.Forms.TreeNode treeNode883 = new System.Windows.Forms.TreeNode("Version 1.0.0.13", new System.Windows.Forms.TreeNode[] {
            treeNode882});
            System.Windows.Forms.TreeNode treeNode884 = new System.Windows.Forms.TreeNode("Methods to convert between HSL and RGB");
            System.Windows.Forms.TreeNode treeNode885 = new System.Windows.Forms.TreeNode("Method to set colour opacity");
            System.Windows.Forms.TreeNode treeNode886 = new System.Windows.Forms.TreeNode("Methods to get R, G, B and H, S, L for a colour");
            System.Windows.Forms.TreeNode treeNode887 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode884,
            treeNode885,
            treeNode886});
            System.Windows.Forms.TreeNode treeNode888 = new System.Windows.Forms.TreeNode("Methods to add and subtract dates and times");
            System.Windows.Forms.TreeNode treeNode889 = new System.Windows.Forms.TreeNode("LDDateTime", new System.Windows.Forms.TreeNode[] {
            treeNode888});
            System.Windows.Forms.TreeNode treeNode890 = new System.Windows.Forms.TreeNode("Waiting overlay, Calendar and About popups");
            System.Windows.Forms.TreeNode treeNode891 = new System.Windows.Forms.TreeNode("Tooltips");
            System.Windows.Forms.TreeNode treeNode892 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode890,
            treeNode891});
            System.Windows.Forms.TreeNode treeNode893 = new System.Windows.Forms.TreeNode("File change event");
            System.Windows.Forms.TreeNode treeNode894 = new System.Windows.Forms.TreeNode("LDEvents", new System.Windows.Forms.TreeNode[] {
            treeNode893});
            System.Windows.Forms.TreeNode treeNode895 = new System.Windows.Forms.TreeNode("Version 1.0.0.12", new System.Windows.Forms.TreeNode[] {
            treeNode887,
            treeNode889,
            treeNode892,
            treeNode894});
            System.Windows.Forms.TreeNode treeNode896 = new System.Windows.Forms.TreeNode("Methods to sort arrays by index or value");
            System.Windows.Forms.TreeNode treeNode897 = new System.Windows.Forms.TreeNode("Sorting by number and character strings");
            System.Windows.Forms.TreeNode treeNode898 = new System.Windows.Forms.TreeNode("LDSort", new System.Windows.Forms.TreeNode[] {
            treeNode896,
            treeNode897});
            System.Windows.Forms.TreeNode treeNode899 = new System.Windows.Forms.TreeNode("Statistics on any array and distribution generation");
            System.Windows.Forms.TreeNode treeNode900 = new System.Windows.Forms.TreeNode("Includes integration and differentiation to convert between PDF and CDF");
            System.Windows.Forms.TreeNode treeNode901 = new System.Windows.Forms.TreeNode("Normal, Binomial, Traingular and Uniform distributions");
            System.Windows.Forms.TreeNode treeNode902 = new System.Windows.Forms.TreeNode("LDStatistics", new System.Windows.Forms.TreeNode[] {
            treeNode899,
            treeNode900,
            treeNode901});
            System.Windows.Forms.TreeNode treeNode903 = new System.Windows.Forms.TreeNode("Voice and volume added");
            System.Windows.Forms.TreeNode treeNode904 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode903});
            System.Windows.Forms.TreeNode treeNode905 = new System.Windows.Forms.TreeNode("Version 1.0.0.11", new System.Windows.Forms.TreeNode[] {
            treeNode898,
            treeNode902,
            treeNode904});
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
            treeNode1.Text = "TEMP tables allowed for SQLite databases";
            treeNode2.Name = "Node1";
            treeNode2.Text = "LDDataBase";
            treeNode3.Name = "Node1";
            treeNode3.Text = "Convert2Cartesian fixed to be Culture Invariant.";
            treeNode4.Name = "Node0";
            treeNode4.Text = "LDMath";
            treeNode5.Name = "Node1";
            treeNode5.Text = "NormalMap method added for normal map 3D effects";
            treeNode6.Name = "Node2";
            treeNode6.Text = "HeightMap2NormalMap method to create a normal map from a height map";
            treeNode7.Name = "Node5";
            treeNode7.Text = "MakeTransparent method added";
            treeNode8.Name = "Node6";
            treeNode8.Text = "ReplaceColour method added";
            treeNode9.Name = "Node0";
            treeNode9.Text = "To32bitARGB method added (code suggested by Pappa Lapub)";
            treeNode10.Name = "Node0";
            treeNode10.Text = "LDImage";
            treeNode11.Name = "Node4";
            treeNode11.Text = "All image pixel manipulations speeded up";
            treeNode12.Name = "Node7";
            treeNode12.Text = "More Culture Invariace fixes";
            treeNode13.Name = "Node3";
            treeNode13.Text = "General";
            treeNode14.Name = "Node0";
            treeNode14.Text = "Version 1.2.13.0";
            treeNode15.Name = "Node1";
            treeNode15.Text = "Base conversions extended to include bases up to 36";
            treeNode16.Name = "Node0";
            treeNode16.Text = "LDMath";
            treeNode17.Name = "Node3";
            treeNode17.Text = "Updated to new Bing API";
            treeNode18.Name = "Node2";
            treeNode18.Text = "LDSearch";
            treeNode19.Name = "Node1";
            treeNode19.Text = "ShowInTaskbar property added";
            treeNode20.Name = "Node0";
            treeNode20.Text = "LDGraphicsWindow";
            treeNode21.Name = "Node1";
            treeNode21.Text = "ReadCSV and WriteCSV modified to handle \"";
            treeNode22.Name = "Node0";
            treeNode22.Text = "LDFile";
            treeNode23.Name = "Node1";
            treeNode23.Text = "ToArray and FromArray methods added";
            treeNode24.Name = "Node0";
            treeNode24.Text = "LDxml";
            treeNode25.Name = "Node0";
            treeNode25.Text = "Version 1.2.12.0";
            treeNode26.Name = "Node2";
            treeNode26.Text = "DataViewColumnWidths method added";
            treeNode27.Name = "Node3";
            treeNode27.Text = "DataViewRowColours method added";
            treeNode28.Name = "Node1";
            treeNode28.Text = "LDControls";
            treeNode29.Name = "Node1";
            treeNode29.Text = "Various obscure or experimental methods made visible to intelliseense. (LD3DView," +
    " LDBlueTooth, LDScrolBars, LDShapes)";
            treeNode30.Name = "Node0";
            treeNode30.Text = "General";
            treeNode31.Name = "Node1";
            treeNode31.Text = "SetCentre method added";
            treeNode32.Name = "Node4";
            treeNode32.Text = "A 3rd rotation added";
            treeNode33.Name = "Node3";
            treeNode33.Text = "BoundingBox method added";
            treeNode34.Name = "Node0";
            treeNode34.Text = "LD3DView";
            treeNode35.Name = "Node3";
            treeNode35.Text = "Reverted to earlier MySQL version to handle old password encryption";
            treeNode36.Name = "Node2";
            treeNode36.Text = "LDDatabase";
            treeNode37.Name = "Node1";
            treeNode37.Text = "PlayMusic2 method added";
            treeNode38.Name = "Node2";
            treeNode38.Text = "Channel parameter added";
            treeNode39.Name = "Node0";
            treeNode39.Text = "LDMusic";
            treeNode40.Name = "Node0";
            treeNode40.Text = "Version 1.2.11.0";
            treeNode41.Name = "Node1";
            treeNode41.Text = "SetButtonStyle method added";
            treeNode42.Name = "Node0";
            treeNode42.Text = "LDControls";
            treeNode43.Name = "Node1";
            treeNode43.Text = "Additional geometries added (Cube, Cone, Arrow, Revolute and Rectangle)";
            treeNode44.Name = "Node2";
            treeNode44.Text = "SetBillBoard method added";
            treeNode45.Name = "Node0";
            treeNode45.Text = "GetCameraUpDirection method added";
            treeNode46.Name = "Node1";
            treeNode46.Text = "Gradient brushes can be used";
            treeNode47.Name = "Node2";
            treeNode47.Text = "AutoControl method added";
            treeNode48.Name = "Node0";
            treeNode48.Text = "SpecularExponent property added";
            treeNode49.Name = "Node0";
            treeNode49.Text = "LD3DView";
            treeNode50.Name = "Node1";
            treeNode50.Text = "AddText method to annotate an image with text added";
            treeNode51.Name = "Node0";
            treeNode51.Text = "LDImage";
            treeNode52.Name = "Node4";
            treeNode52.Text = "BrushText for text on a brush added";
            treeNode53.Name = "Node0";
            treeNode53.Text = "Skew shapes method added";
            treeNode54.Name = "Node3";
            treeNode54.Text = "LDShapes";
            treeNode55.Name = "Node0";
            treeNode55.Text = "Version 1.2.10.0";
            treeNode56.Name = "Node1";
            treeNode56.Text = "A general purpose unit system, see LDUnits.sb sample";
            treeNode57.Name = "Node0";
            treeNode57.Text = "LDUnits";
            treeNode58.Name = "Node1";
            treeNode58.Text = "Possible issue with FixSigFig fixed";
            treeNode59.Name = "Node0";
            treeNode59.Text = "LDMath";
            treeNode60.Name = "Node3";
            treeNode60.Text = "GetIndex method added (for SB arrays)";
            treeNode61.Name = "Node2";
            treeNode61.Text = "LDArray";
            treeNode62.Name = "Node5";
            treeNode62.Text = "Resize mode property added";
            treeNode63.Name = "Node6";
            treeNode63.Text = "Icon sets SB icon if property set to \"SB\"";
            treeNode64.Name = "Node4";
            treeNode64.Text = "LDGraphicsWindow";
            treeNode65.Name = "Node8";
            treeNode65.Text = "Possible threading error with DataViewSetRow and DataViewSetValue fixed";
            treeNode66.Name = "Node9";
            treeNode66.Text = "DataViewAllowUserEntry method added";
            treeNode67.Name = "Node7";
            treeNode67.Text = "LDControls";
            treeNode68.Name = "Node0";
            treeNode68.Text = "Version 1.2.9.0";
            treeNode69.Name = "Node1";
            treeNode69.Text = "New extended math object, starting with FFT";
            treeNode70.Name = "Node0";
            treeNode70.Text = "LDMathX";
            treeNode71.Name = "Node1";
            treeNode71.Text = "AddListBox and ListBoxContent can accept LDList and LDArray data";
            treeNode72.Name = "Node0";
            treeNode72.Text = "LDControls";
            treeNode73.Name = "Node3";
            treeNode73.Text = "CreateFromIndices and CreateFromValues methods added";
            treeNode74.Name = "Node2";
            treeNode74.Text = "LDArray";
            treeNode75.Name = "Node5";
            treeNode75.Text = "CreateFromIndices and CreateFromValues methods added";
            treeNode76.Name = "Node4";
            treeNode76.Text = "LDList";
            treeNode77.Name = "Node0";
            treeNode77.Text = "Version 1.2.8.0";
            treeNode78.Name = "Node2";
            treeNode78.Text = "Error handling, additional settings and multiple ports supported";
            treeNode79.Name = "Node1";
            treeNode79.Text = "LDCommPort";
            treeNode80.Name = "Node1";
            treeNode80.Text = "Posterise, Hue, Saturation and Lightness effects added";
            treeNode81.Name = "Node1";
            treeNode81.Text = "More image effects, OilPaint, Charcoal, Sketch, Cartoon, Edge, Accent, Sepia, Noi" +
    "seRemoval and Solarise added";
            treeNode82.Name = "Node0";
            treeNode82.Text = "LDImage and LDWebCam";
            treeNode83.Name = "Node1";
            treeNode83.Text = "Bitwise operations object added";
            treeNode84.Name = "Node0";
            treeNode84.Text = "LDBits";
            treeNode85.Name = "Node1";
            treeNode85.Text = "Extended text encoding property added";
            treeNode86.Name = "Node0";
            treeNode86.Text = "TextWindow colours can be changed";
            treeNode87.Name = "Node0";
            treeNode87.Text = "LDTextWindow";
            treeNode88.Name = "Node1";
            treeNode88.Text = "GetWorkingImagePixelARGB method added";
            treeNode89.Name = "Node0";
            treeNode89.Text = "LDImage";
            treeNode90.Name = "Node1";
            treeNode90.Text = "RasteriseTurtleLines method added";
            treeNode91.Name = "Node0";
            treeNode91.Text = "LDShapes";
            treeNode92.Name = "Node0";
            treeNode92.Text = "Version 1.2.7.0";
            treeNode93.Name = "Node1";
            treeNode93.Text = "Confirm dialog is given focus above GraphicsWindow";
            treeNode94.Name = "Node0";
            treeNode94.Text = "LDDialogs";
            treeNode95.Name = "Node1";
            treeNode95.Text = "Read and write json model scripts compatible with R.U.B.E.";
            treeNode96.Name = "Node2";
            treeNode96.Text = "ToggleSensor added";
            treeNode97.Name = "Node0";
            treeNode97.Text = "LDPhysics";
            treeNode98.Name = "Node1";
            treeNode98.Text = "Allow multiple copies of the webcam image";
            treeNode99.Name = "Node0";
            treeNode99.Text = "LDWebCam";
            treeNode100.Name = "Node1";
            treeNode100.Text = "Fast pixel level image manipulation using a temporary working image added";
            treeNode101.Name = "Node0";
            treeNode101.Text = "MetaData method added";
            treeNode102.Name = "Node0";
            treeNode102.Text = "LDImage";
            treeNode103.Name = "Node0";
            treeNode103.Text = "Version 1.2.6.0";
            treeNode104.Name = "Node2";
            treeNode104.Text = "FixSigFig and FixDecimal methods added";
            treeNode105.Name = "Node3";
            treeNode105.Text = "MinNumber and MaxNumber properties added";
            treeNode106.Name = "Node1";
            treeNode106.Text = "LDMath";
            treeNode107.Name = "Node1";
            treeNode107.Text = "SliderMaximum property added";
            treeNode108.Name = "Node0";
            treeNode108.Text = "LDControls";
            treeNode109.Name = "Node1";
            treeNode109.Text = "ZoomAll method added";
            treeNode110.Name = "Node0";
            treeNode110.Text = "LDShapes";
            treeNode111.Name = "Node1";
            treeNode111.Text = "Reposition methods and properties added";
            treeNode112.Name = "Node0";
            treeNode112.Text = "LDGraphicsWindow";
            treeNode113.Name = "Node1";
            treeNode113.Text = "GetImagePixels and SetImagePixels methods added";
            treeNode114.Name = "Node0";
            treeNode114.Text = "LDImage";
            treeNode115.Name = "Node1";
            treeNode115.Text = "MouseScroll parameter added";
            treeNode116.Name = "Node0";
            treeNode116.Text = "LDScrollBars";
            treeNode117.Name = "Node0";
            treeNode117.Text = "Version 1.2.5.0";
            treeNode118.Name = "Node0";
            treeNode118.Text = "New object added (previously a separate extension)";
            treeNode119.Name = "Node1";
            treeNode119.Text = "Async, Loop, Volume and Pan properties added";
            treeNode120.Name = "Node2";
            treeNode120.Text = "PlayWave, PlayHarmonics and PlayWavFile methods added";
            treeNode121.Name = "Node1";
            treeNode121.Text = "LDWaveForm";
            treeNode122.Name = "Node1";
            treeNode122.Text = "New object added to get input from gamepads or joysticks";
            treeNode123.Name = "Node0";
            treeNode123.Text = "LDController";
            treeNode124.Name = "Node1";
            treeNode124.Text = "RayCast method added";
            treeNode125.Name = "Node0";
            treeNode125.Text = "LDPhysics";
            treeNode126.Name = "Node0";
            treeNode126.Text = "Version 1.2.4.0";
            treeNode127.Name = "Node2";
            treeNode127.Text = "New object to apply effects to any shape or control";
            treeNode128.Name = "Node1";
            treeNode128.Text = "LDEffects";
            treeNode129.Name = "Node1";
            treeNode129.Text = "New object to add arrow, arc, polygons and callout shapes";
            treeNode130.Name = "Node0";
            treeNode130.Text = "LDFigures";
            treeNode131.Name = "Node1";
            treeNode131.Text = "SetGroup method added";
            treeNode132.Name = "Node2";
            treeNode132.Text = "GetContacts method added";
            treeNode133.Name = "Node0";
            treeNode133.Text = "GetAllShapesAt method added";
            treeNode134.Name = "Node0";
            treeNode134.Text = "LDPhysics";
            treeNode135.Name = "Node2";
            treeNode135.Text = "SetImage handles images with transparency";
            treeNode136.Name = "Node0";
            treeNode136.Text = "ImageTransparency property added to switch how image transparencies are handled";
            treeNode137.Name = "Node1";
            treeNode137.Text = "LDClipboard";
            treeNode138.Name = "Node0";
            treeNode138.Text = "Version 1.2.3.0";
            treeNode139.Name = "Node2";
            treeNode139.Text = "BrushGradient can use \"R\" for radial orientation";
            treeNode140.Name = "Node1";
            treeNode140.Text = "LDShapes";
            treeNode141.Name = "Node4";
            treeNode141.Text = "Unnecessary file existance checks removed from GetFolder, GetFile and GetExtensio" +
    "n";
            treeNode142.Name = "Node3";
            treeNode142.Text = "LDFile";
            treeNode143.Name = "Node6";
            treeNode143.Text = "NewImage method added";
            treeNode144.Name = "Node5";
            treeNode144.Text = "LDImage";
            treeNode145.Name = "Node1";
            treeNode145.Text = "SetStartupPosition method added to position dialogs";
            treeNode146.Name = "Node0";
            treeNode146.Text = "LDDialogs";
            treeNode147.Name = "Node1";
            treeNode147.Text = "AddSeriesHitogram renamed AddSeriesHistogram";
            treeNode148.Name = "Node0";
            treeNode148.Text = "LDGraph";
            treeNode149.Name = "Node0";
            treeNode149.Text = "Version 1.2.2.0";
            treeNode150.Name = "Node2";
            treeNode150.Text = "Recompiled for Small Basic version 1.2";
            treeNode151.Name = "Node1";
            treeNode151.Text = "Version 1.2";
            treeNode152.Name = "Node0";
            treeNode152.Text = "Version 1.2.0.1";
            treeNode153.Name = "Node2";
            treeNode153.Text = "OpenFile and SaveFile may take an array of extensions";
            treeNode154.Name = "Node1";
            treeNode154.Text = "LDDialogs";
            treeNode155.Name = "Node1";
            treeNode155.Text = "Logical operations object added";
            treeNode156.Name = "Node0";
            treeNode156.Text = "LDLogic";
            treeNode157.Name = "Node4";
            treeNode157.Text = "CurrentCulture property added";
            treeNode158.Name = "Node3";
            treeNode158.Text = "LDUtilities";
            treeNode159.Name = "Node6";
            treeNode159.Text = "Evaluate3, a method to evaluate to a boolean added";
            treeNode160.Name = "Node5";
            treeNode160.Text = "LDMath";
            treeNode161.Name = "Node0";
            treeNode161.Text = "Version 1.1.0.8";
            treeNode162.Name = "Node1";
            treeNode162.Text = "Scrolling to selected nodes improved for dataview with custom column type (e.g.co" +
    "mbobox)";
            treeNode163.Name = "Node0";
            treeNode163.Text = "LDControls";
            treeNode164.Name = "Node1";
            treeNode164.Text = "Methods added to add and remove nodes and save xml file";
            treeNode165.Name = "Node0";
            treeNode165.Text = "LDxml";
            treeNode166.Name = "Node1";
            treeNode166.Text = "MusicPlayTime moved from LDFile";
            treeNode167.Name = "Node0";
            treeNode167.Text = "LDSound";
            treeNode168.Name = "Node0";
            treeNode168.Text = "Version 1.1.0.7";
            treeNode169.Name = "Node4";
            treeNode169.Text = "SplitImage method added";
            treeNode170.Name = "Node3";
            treeNode170.Text = "LDImage";
            treeNode171.Name = "Node6";
            treeNode171.Text = "EditTable and SaveTable methods added";
            treeNode172.Name = "Node5";
            treeNode172.Text = "LDDatabse";
            treeNode173.Name = "Node2";
            treeNode173.Text = "DataView control and methods added";
            treeNode174.Name = "Node1";
            treeNode174.Text = "LDControls";
            treeNode175.Name = "Node2";
            treeNode175.Text = "Version 1.1.0.6";
            treeNode176.Name = "Node2";
            treeNode176.Text = "Exists modified to check for directory as well as file";
            treeNode177.Name = "Node3";
            treeNode177.Text = "GetAllDirectories modified to omit directories without sufficient permissions";
            treeNode178.Name = "Node1";
            treeNode178.Text = "LDFile";
            treeNode179.Name = "Node5";
            treeNode179.Text = "Instrumenting - Index was outside the bounds of the array - bug fixed";
            treeNode180.Name = "Node6";
            treeNode180.Text = "Bug fixed returning to Small Basic IDE if application ends before debug window is" +
    " closed";
            treeNode181.Name = "Node9";
            treeNode181.Text = "Conditonal break point added";
            treeNode182.Name = "Node0";
            treeNode182.Text = "Step over button added";
            treeNode183.Name = "Node4";
            treeNode183.Text = "LDDebug";
            treeNode184.Name = "Node8";
            treeNode184.Text = "ExitOnClose works with LDWindows (multiple windows)";
            treeNode185.Name = "Node7";
            treeNode185.Text = "LDGraphicsWindow";
            treeNode186.Name = "Node1";
            treeNode186.Text = "Object added to save image, sound, file and text/varables to a resources file";
            treeNode187.Name = "Node0";
            treeNode187.Text = "LDResources";
            treeNode188.Name = "Node0";
            treeNode188.Text = "Version 1.1.0.5";
            treeNode189.Name = "Node2";
            treeNode189.Text = "ClipboardChanged event added";
            treeNode190.Name = "Node1";
            treeNode190.Text = "LDClipboard";
            treeNode191.Name = "Node1";
            treeNode191.Text = "RenameFile, RenameDirctory, CopyDirectory and GetAllDirectories methods added";
            treeNode192.Name = "Node0";
            treeNode192.Text = "LDFile";
            treeNode193.Name = "Node3";
            treeNode193.Text = "SetActive method added";
            treeNode194.Name = "Node2";
            treeNode194.Text = "LDGraphicsWindow";
            treeNode195.Name = "Node1";
            treeNode195.Text = "Parse xml file nodes";
            treeNode196.Name = "Node0";
            treeNode196.Text = "LDxml";
            treeNode197.Name = "Node3";
            treeNode197.Text = "\"FAILURE\" replaced by \"FAILED\" as a return message for consistency";
            treeNode198.Name = "Node2";
            treeNode198.Text = "General";
            treeNode199.Name = "Node0";
            treeNode199.Text = "Version 1.1.0.4";
            treeNode200.Name = "Node2";
            treeNode200.Text = "WakeAll method addded";
            treeNode201.Name = "Node1";
            treeNode201.Text = "LDPhysics";
            treeNode202.Name = "Node1";
            treeNode202.Text = "Clipboard methods added";
            treeNode203.Name = "Node0";
            treeNode203.Text = "LDClipboard";
            treeNode204.Name = "Node0";
            treeNode204.Text = "Version 1.1.0.3";
            treeNode205.Name = "Node6";
            treeNode205.Text = "SizeNWSE cursor added";
            treeNode206.Name = "Node5";
            treeNode206.Text = "LDCursors";
            treeNode207.Name = "Node8";
            treeNode207.Text = "ScaleAxisX & ScaleAxisY modified for better control";
            treeNode208.Name = "Node7";
            treeNode208.Text = "LDGraph";
            treeNode209.Name = "Node1";
            treeNode209.Text = "SQLite updated for .Net 4.5";
            treeNode210.Name = "Node0";
            treeNode210.Text = "LDDataBase";
            treeNode211.Name = "Node4";
            treeNode211.Text = "Version 1.1.0.2";
            treeNode212.Name = "Node3";
            treeNode212.Text = "Recompiled for Small Basic version 1.1";
            treeNode213.Name = "Node2";
            treeNode213.Text = "Version 1.1";
            treeNode214.Name = "Node0";
            treeNode214.Text = "Version 1.1.0.1";
            treeNode215.Name = "Node12";
            treeNode215.Text = "RichTextBoxCaseSensitive parameter added";
            treeNode216.Name = "Node13";
            treeNode216.Text = "RichTextBoxMargins method added";
            treeNode217.Name = "Node0";
            treeNode217.Text = "ListBoxSelectionMode added for multiple list box selection";
            treeNode218.Name = "Node1";
            treeNode218.Text = "ListBoxGetSelected and ListBoxSelect modified for multiple selection modes";
            treeNode219.Name = "Node11";
            treeNode219.Text = "LDControls";
            treeNode220.Name = "Node3";
            treeNode220.Text = "Error reporting added";
            treeNode221.Name = "Node4";
            treeNode221.Text = "SetEncoding method added";
            treeNode222.Name = "Node2";
            treeNode222.Text = "LDCommPort";
            treeNode223.Name = "Node6";
            treeNode223.Text = "AddSeries methods replace an existing series if the label name is the same";
            treeNode224.Name = "Node7";
            treeNode224.Text = "Export to excel fix for graph with no title";
            treeNode225.Name = "Node5";
            treeNode225.Text = "LDGraph";
            treeNode226.Name = "Node9";
            treeNode226.Text = "Negative restitution option when adding moving shape";
            treeNode227.Name = "Node8";
            treeNode227.Text = "LDPhysics";
            treeNode228.Name = "Node10";
            treeNode228.Text = "Version 1.0.0.133";
            treeNode229.Name = "Node2";
            treeNode229.Text = "Internal improvements to auto messaging";
            treeNode230.Name = "Node9";
            treeNode230.Text = "Name can be set and GetClients method added";
            treeNode231.Name = "Node1";
            treeNode231.Text = "LDClient";
            treeNode232.Name = "Node4";
            treeNode232.Text = "RichTextBoxWord method modified to include mode parameter";
            treeNode233.Name = "Node3";
            treeNode233.Text = "LDControls";
            treeNode234.Name = "Node8";
            treeNode234.Text = "Return message and possible file error fixed for Stop method";
            treeNode235.Name = "Node7";
            treeNode235.Text = "LDSound";
            treeNode236.Name = "Node0";
            treeNode236.Text = "Version 1.0.0.132";
            treeNode237.Name = "Node2";
            treeNode237.Text = "Include and CallInclude methods added to use a pre-compiled file";
            treeNode238.Name = "Node5";
            treeNode238.Text = "Compile method added to compile a Small Basic program";
            treeNode239.Name = "Node1";
            treeNode239.Text = "LDCall";
            treeNode240.Name = "Node4";
            treeNode240.Text = "Methods and code by Pappa Lapub added";
            treeNode241.Name = "Node3";
            treeNode241.Text = "LDShell";
            treeNode242.Name = "Node0";
            treeNode242.Text = "Version 1.0.0.131";
            treeNode243.Name = "Node6";
            treeNode243.Text = "FollowShapeX and FollowShapeY methods added";
            treeNode244.Name = "Node7";
            treeNode244.Text = "BoxShape method added to keep a shape with a region of the GraphicsWindow";
            treeNode245.Name = "Node8";
            treeNode245.Text = "Refactoring of all the pan, follow and box methods";
            treeNode246.Name = "Node6";
            treeNode246.Text = "All input and output coordinates are in world coordinates, apart from GetShapeAt " +
    "which is in screen coordinates";
            treeNode247.Name = "Node8";
            treeNode247.Text = "GetPan method added to convert between world and screen coordinates";
            treeNode248.Name = "Node5";
            treeNode248.Text = "LDPhysics";
            treeNode249.Name = "Node1";
            treeNode249.Text = "UseBinary property added";
            treeNode250.Name = "Node2";
            treeNode250.Text = "DoAsync property and associated completion events added";
            treeNode251.Name = "Node3";
            treeNode251.Text = "Delete method added";
            treeNode252.Name = "Node0";
            treeNode252.Text = "LDftp";
            treeNode253.Name = "Node5";
            treeNode253.Text = "CallAsync method to call any extension method asynchronously added";
            treeNode254.Name = "Node4";
            treeNode254.Text = "LDCall";
            treeNode255.Name = "Node2";
            treeNode255.Text = "SetCursorToEnd also works for RichTextBox";
            treeNode256.Name = "Node1";
            treeNode256.Text = "LDControls";
            treeNode257.Name = "Node4";
            treeNode257.Text = "Version 1.0.0.130";
            treeNode258.Name = "Node2";
            treeNode258.Text = "Evaluate2 method added to behave nicely with the TextWindow";
            treeNode259.Name = "Node1";
            treeNode259.Text = "LDMath";
            treeNode260.Name = "Node1";
            treeNode260.Text = "SetShapeGravity method to alter gravity for individual shapes";
            treeNode261.Name = "Node0";
            treeNode261.Text = "LDPhysics";
            treeNode262.Name = "Node3";
            treeNode262.Text = "Improve PauseUpdate and ResumeUpdates methods";
            treeNode263.Name = "Node2";
            treeNode263.Text = "LDGraphicsWindow";
            treeNode264.Name = "Node1";
            treeNode264.Text = "FTP object methods added";
            treeNode265.Name = "Node0";
            treeNode265.Text = "LDftp";
            treeNode266.Name = "Node3";
            treeNode266.Text = "An existing file is replaced";
            treeNode267.Name = "Node2";
            treeNode267.Text = "LDZip";
            treeNode268.Name = "Node1";
            treeNode268.Text = "Size method added";
            treeNode269.Name = "Node0";
            treeNode269.Text = "LDFile";
            treeNode270.Name = "Node3";
            treeNode270.Text = "DownloadFile method added";
            treeNode271.Name = "Node2";
            treeNode271.Text = "LDNetwork";
            treeNode272.Name = "Node0";
            treeNode272.Text = "Version 1.0.0.129";
            treeNode273.Name = "Node2";
            treeNode273.Text = "Generalised joint connections added";
            treeNode274.Name = "Node0";
            treeNode274.Text = "AddExplosion method added";
            treeNode275.Name = "Node1";
            treeNode275.Text = "LDPhysics";
            treeNode276.Name = "Node1";
            treeNode276.Text = "BrushImage method added and renamed some BrushGradient commands (old methods stil" +
    "l work but depreciated)";
            treeNode277.Name = "Node0";
            treeNode277.Text = "LDShapes";
            treeNode278.Name = "Node0";
            treeNode278.Text = "Version 1.0.0.128";
            treeNode279.Name = "Node2";
            treeNode279.Text = "CheckServer method added";
            treeNode280.Name = "Node1";
            treeNode280.Text = "LDClient";
            treeNode281.Name = "Node1";
            treeNode281.Text = "Default maximum number of objects (proxies) increased from 512 to 1024";
            treeNode282.Name = "Node2";
            treeNode282.Text = "MaxPolygonVertices and MaxProxies properties added";
            treeNode283.Name = "Node3";
            treeNode283.Text = "GetAngle method added";
            treeNode284.Name = "Node4";
            treeNode284.Text = "Top-down tire (to model a car from above) methods added";
            treeNode285.Name = "Node0";
            treeNode285.Text = "LDPhysics";
            treeNode286.Name = "Node0";
            treeNode286.Text = "Version 1.0.0.127";
            treeNode287.Name = "Node7";
            treeNode287.Text = "Bug fixes for Overlap methods";
            treeNode288.Name = "Node6";
            treeNode288.Text = "LDShapes";
            treeNode289.Name = "Node0";
            treeNode289.Text = "Bug fix for multiple numeric sorts";
            treeNode290.Name = "Node9";
            treeNode290.Text = "ByValueWithIndex method added";
            treeNode291.Name = "Node8";
            treeNode291.Text = "LDSort";
            treeNode292.Name = "Node1";
            treeNode292.Text = "LAN method added to get local IP addresses";
            treeNode293.Name = "Node2";
            treeNode293.Text = "Ping method added";
            treeNode294.Name = "Node0";
            treeNode294.Text = "LDNetwork";
            treeNode295.Name = "Node1";
            treeNode295.Text = "LoadSVG method added";
            treeNode296.Name = "Node0";
            treeNode296.Text = "LDImage";
            treeNode297.Name = "Node3";
            treeNode297.Text = "Evaluate method added";
            treeNode298.Name = "Node2";
            treeNode298.Text = "LDMath";
            treeNode299.Name = "Node5";
            treeNode299.Text = "IncludeJScript method added";
            treeNode300.Name = "Node4";
            treeNode300.Text = "LDInline";
            treeNode301.Name = "Node5";
            treeNode301.Text = "Version 1.0.0.126";
            treeNode302.Name = "Node0";
            treeNode302.Text = "Special emphasis on async consistency";
            treeNode303.Name = "Node4";
            treeNode303.Text = "Simplified auto method for multi-player game data transfer";
            treeNode304.Name = "Node9";
            treeNode304.Text = "LDServer and LDClient objects added";
            treeNode305.Name = "Node2";
            treeNode305.Text = "GetWidth and GetHeight methods added";
            treeNode306.Name = "Node1";
            treeNode306.Text = "LDText";
            treeNode307.Name = "Node4";
            treeNode307.Text = "Bing web search";
            treeNode308.Name = "Node3";
            treeNode308.Text = "LDSearch";
            treeNode309.Name = "Node6";
            treeNode309.Text = "KeyDown event handled correctly for arrow keys with hidden scrollbars";
            treeNode310.Name = "Node7";
            treeNode310.Text = "KeyScroll property added";
            treeNode311.Name = "Node5";
            treeNode311.Text = "LDScrollBars";
            treeNode312.Name = "Node9";
            treeNode312.Text = "GetLeft and GetTop methods (work while shape is animating)";
            treeNode313.Name = "Node8";
            treeNode313.Text = "LDShapes";
            treeNode314.Name = "Node1";
            treeNode314.Text = "SaveAs method bug fixed";
            treeNode315.Name = "Node0";
            treeNode315.Text = "LDImage";
            treeNode316.Name = "Node3";
            treeNode316.Text = "Made thread-safe since often used to queue asynchronous events";
            treeNode317.Name = "Node2";
            treeNode317.Text = "LDQueue";
            treeNode318.Name = "Node8";
            treeNode318.Text = "Version 1.0.0.125";
            treeNode319.Name = "Node7";
            treeNode319.Text = "Language translation object added";
            treeNode320.Name = "Node6";
            treeNode320.Text = "LDTranslate";
            treeNode321.Name = "Node5";
            treeNode321.Text = "Version 1.0.0.124";
            treeNode322.Name = "Node1";
            treeNode322.Text = "Mouse screen coordinate conversion parameters added";
            treeNode323.Name = "Node2";
            treeNode323.Text = "MouseX and MouseY added to set cursor in GraphicsWindow";
            treeNode324.Name = "Node0";
            treeNode324.Text = "LDGraphicsWindow";
            treeNode325.Name = "Node4";
            treeNode325.Text = "DPIX and DPIY properties added for screen resolution";
            treeNode326.Name = "Node3";
            treeNode326.Text = "LDUtilities";
            treeNode327.Name = "Node0";
            treeNode327.Text = "Version 1.0.0.123";
            treeNode328.Name = "Node5";
            treeNode328.Text = "ColorMatrix method added";
            treeNode329.Name = "Node0";
            treeNode329.Text = "Rotate method added";
            treeNode330.Name = "Node3";
            treeNode330.Text = "LDImage";
            treeNode331.Name = "Node1";
            treeNode331.Text = "Customisable Pie, Doughnut, Bubble, Bar and Column chart control object added";
            treeNode332.Name = "Node0";
            treeNode332.Text = "LDChart";
            treeNode333.Name = "Node2";
            treeNode333.Text = "Version 1.0.0.122";
            treeNode334.Name = "Node2";
            treeNode334.Text = "EffectGamma added to darken and lighten";
            treeNode335.Name = "Node4";
            treeNode335.Text = "EffectFishEye, EffectBulge and EffectSwirl added";
            treeNode336.Name = "Node3";
            treeNode336.Text = "EffectContrast modified";
            treeNode337.Name = "Node0";
            treeNode337.Text = "GetEffects and EffectDefaults methods added to get list of effects and default pa" +
    "rameters";
            treeNode338.Name = "Node1";
            treeNode338.Text = "LDImage";
            treeNode339.Name = "Node2";
            treeNode339.Text = "Error event added for all extension exceptions";
            treeNode340.Name = "Node1";
            treeNode340.Text = "LDEvents";
            treeNode341.Name = "Node1";
            treeNode341.Text = "Hyperbolic trigonometric functions Sinh, Cosh and Tanh added";
            treeNode342.Name = "Node0";
            treeNode342.Text = "LDMath";
            treeNode343.Name = "Node0";
            treeNode343.Text = "Version 1.0.0.121";
            treeNode344.Name = "Node2";
            treeNode344.Text = "FloodFill transparency effect fixed";
            treeNode345.Name = "Node1";
            treeNode345.Text = "LDGraphicsWindow";
            treeNode346.Name = "Node1";
            treeNode346.Text = "SaveAllVariables and LoadAllVariables methods added";
            treeNode347.Name = "Node0";
            treeNode347.Text = "LDFile";
            treeNode348.Name = "Node1";
            treeNode348.Text = "EffectPixelate added";
            treeNode349.Name = "Node0";
            treeNode349.Text = "LDImage";
            treeNode350.Name = "Node1";
            treeNode350.Text = "Modified to work with Windows 8";
            treeNode351.Name = "Node0";
            treeNode351.Text = "LDWebCam";
            treeNode352.Name = "Node0";
            treeNode352.Text = "Version 1.0.0.120";
            treeNode353.Name = "Node2";
            treeNode353.Text = "FloodFill method added";
            treeNode354.Name = "Node1";
            treeNode354.Text = "LDGraphicsWindow";
            treeNode355.Name = "Node0";
            treeNode355.Text = "Version 1.0.0.119";
            treeNode356.Name = "Node0";
            treeNode356.Text = "SetShapeCursor method added";
            treeNode357.Name = "Node11";
            treeNode357.Text = "CreateCursor method added";
            treeNode358.Name = "Node9";
            treeNode358.Text = "LDCursors";
            treeNode359.Name = "Node2";
            treeNode359.Text = "SaveAs method to save in different file formats";
            treeNode360.Name = "Node0";
            treeNode360.Text = "Parameters added for some effects";
            treeNode361.Name = "Node1";
            treeNode361.Text = "LDImage";
            treeNode362.Name = "Node2";
            treeNode362.Text = "Parameters added for some effects";
            treeNode363.Name = "Node1";
            treeNode363.Text = "LDWebCam";
            treeNode364.Name = "Node1";
            treeNode364.Text = "Selected LDUtilities and LDShapes methods moved here to new object";
            treeNode365.Name = "Node0";
            treeNode365.Text = "SetFontFromFile method added for ttf fonts";
            treeNode366.Name = "Node0";
            treeNode366.Text = "LDGraphicsWindow";
            treeNode367.Name = "Node3";
            treeNode367.Text = "TWCapture and TWPrint moved from LDUtilities";
            treeNode368.Name = "Node2";
            treeNode368.Text = "LDTextWindow";
            treeNode369.Name = "Node2";
            treeNode369.Text = "Zip methods moved here from LDUtilities";
            treeNode370.Name = "Node0";
            treeNode370.Text = "LDZip";
            treeNode371.Name = "Node3";
            treeNode371.Text = "Regex methods moved here from LDUtilities";
            treeNode372.Name = "Node1";
            treeNode372.Text = "LDRegex";
            treeNode373.Name = "Node1";
            treeNode373.Text = "ListViewRowCount method added";
            treeNode374.Name = "Node0";
            treeNode374.Text = "LDControls";
            treeNode375.Name = "Node3";
            treeNode375.Text = "Version 1.0.0.118";
            treeNode376.Name = "Node5";
            treeNode376.Text = "TransparentGW method added to create a fully transparent GraphicsWindow";
            treeNode377.Name = "Node6";
            treeNode377.Text = "TopMostGW method to set GraphicsWindow as top window";
            treeNode378.Name = "Node4";
            treeNode378.Text = "LDUtilities";
            treeNode379.Name = "Node10";
            treeNode379.Text = "SetUserCursor method added";
            treeNode380.Name = "Node4";
            treeNode380.Text = "LDCursors";
            treeNode381.Name = "Node3";
            treeNode381.Text = "Version 1.0.0.117";
            treeNode382.Name = "Node2";
            treeNode382.Text = "Replacement for Version 1.0 Dictionary object that fails";
            treeNode383.Name = "Node1";
            treeNode383.Text = "LDDictionary";
            treeNode384.Name = "Node0";
            treeNode384.Text = "Version 1.0.0.116";
            treeNode385.Name = "Node2";
            treeNode385.Text = "GetPixel method fix for SB v1.0 bug (works for background, drawing and shape laye" +
    "rs)";
            treeNode386.Name = "Node1";
            treeNode386.Text = "LDColours";
            treeNode387.Name = "Node4";
            treeNode387.Text = "GetOpacity method fix for SB v1.0 bug";
            treeNode388.Name = "Node3";
            treeNode388.Text = "LDShapes";
            treeNode389.Name = "Node1";
            treeNode389.Text = "GridLines replaced with GridLinesX and GridLinesY";
            treeNode390.Name = "Node0";
            treeNode390.Text = "ScaleAxisX and ScaleAxisY methods added";
            treeNode391.Name = "Node1";
            treeNode391.Text = "AutoScale property added to revert to earlier scaling methods";
            treeNode392.Name = "Node0";
            treeNode392.Text = "LDGraph";
            treeNode393.Name = "Node0";
            treeNode393.Text = "Version 1.0.0.115";
            treeNode394.Name = "Node2";
            treeNode394.Text = "ListViewSetRow fixed for overwriting existing row";
            treeNode395.Name = "Node1";
            treeNode395.Text = "LDControls";
            treeNode396.Name = "Node4";
            treeNode396.Text = "RemoveTurtleLines method added";
            treeNode397.Name = "Node6";
            treeNode397.Text = "GetAllShapes method added";
            treeNode398.Name = "Node3";
            treeNode398.Text = "LDShapes";
            treeNode399.Name = "Node1";
            treeNode399.Text = "Odbc connection added";
            treeNode400.Name = "Node0";
            treeNode400.Text = "LDDatabase";
            treeNode401.Name = "Node0";
            treeNode401.Text = "Version 1.0.0.114";
            treeNode402.Name = "Node2";
            treeNode402.Text = "NetworkURL property added for your own LDNetwork web server";
            treeNode403.Name = "Node1";
            treeNode403.Text = "LDUtilities";
            treeNode404.Name = "Node4";
            treeNode404.Text = "ListView control added";
            treeNode405.Name = "Node5";
            treeNode405.Text = "TextBoxReadOnly to set textbox to read only";
            treeNode406.Name = "Node3";
            treeNode406.Text = "LDControls";
            treeNode407.Name = "Node0";
            treeNode407.Text = "Version 1.0.0.113";
            treeNode408.Name = "Node2";
            treeNode408.Text = "Tone method added";
            treeNode409.Name = "Node1";
            treeNode409.Text = "LDSound";
            treeNode410.Name = "Node5";
            treeNode410.Text = "TreeViewGetData and TreeViewEdit methods added";
            treeNode411.Name = "Node4";
            treeNode411.Text = "LDControls";
            treeNode412.Name = "Node0";
            treeNode412.Text = "Version 1.0.0.112";
            treeNode413.Name = "Node2";
            treeNode413.Text = "SqlServer and Access database support added";
            treeNode414.Name = "Node1";
            treeNode414.Text = "LDDataBase";
            treeNode415.Name = "Node4";
            treeNode415.Text = "FixFlickr method added";
            treeNode416.Name = "Node0";
            treeNode416.Text = "ShowNoShapeErrors enable or disable TextWindow errors when shape parameter not fo" +
    "und";
            treeNode417.Name = "Node3";
            treeNode417.Text = "LDUtilities";
            treeNode418.Name = "Node0";
            treeNode418.Text = "Version 1.0.0.111";
            treeNode419.Name = "Node2";
            treeNode419.Text = "TextBoxTab method added";
            treeNode420.Name = "Node1";
            treeNode420.Text = "LDControls";
            treeNode421.Name = "Node0";
            treeNode421.Text = "Version 1.0.0.110";
            treeNode422.Name = "Node1";
            treeNode422.Text = "TextWindow warning meaages for methods that are supplied with file paths that do " +
    "not exist";
            treeNode423.Name = "Node3";
            treeNode423.Text = "File not found warnings controlled with LDUtilities ShowFileErrors";
            treeNode424.Name = "Node0";
            treeNode424.Text = "General";
            treeNode425.Name = "Node5";
            treeNode425.Text = "Exists method added to check if a file path exists or not";
            treeNode426.Name = "Node4";
            treeNode426.Text = "LDFile";
            treeNode427.Name = "Node7";
            treeNode427.Text = "Start method handles attaching to existing process without warning";
            treeNode428.Name = "Node6";
            treeNode428.Text = "LDProcess";
            treeNode429.Name = "Node1";
            treeNode429.Text = "MySQL database support added";
            treeNode430.Name = "Node0";
            treeNode430.Text = "LDDatabase";
            treeNode431.Name = "Node3";
            treeNode431.Text = "Add and Multiply methods honour transparency";
            treeNode432.Name = "Node4";
            treeNode432.Text = "R, G, B truncated to 0 to 255 for Add, Multiply, AddImages, and Abs for Differenc" +
    "eImages";
            treeNode433.Name = "Node2";
            treeNode433.Text = "LDImage";
            treeNode434.Name = "Node3";
            treeNode434.Text = "Version 1.0.0.109";
            treeNode435.Name = "Node2";
            treeNode435.Text = "Show and Hide (fix for SB v1.0 bug)";
            treeNode436.Name = "Node1";
            treeNode436.Text = "LDTextWindow";
            treeNode437.Name = "Node0";
            treeNode437.Text = "Version 1.0.0.108";
            treeNode438.Name = "Node14";
            treeNode438.Text = "Transparent colour added";
            treeNode439.Name = "Node13";
            treeNode439.Text = "LDColours";
            treeNode440.Name = "Node16";
            treeNode440.Text = "Dialogs always appear in front of GraphicsWindow";
            treeNode441.Name = "Node15";
            treeNode441.Text = "LDDialogs";
            treeNode442.Name = "Node12";
            treeNode442.Text = "Version 1.0.0.107";
            treeNode443.Name = "Node8";
            treeNode443.Text = "Improvements to Menu control (colouring, separators and check state)";
            treeNode444.Name = "Node7";
            treeNode444.Text = "LDControls";
            treeNode445.Name = "Node11";
            treeNode445.Text = "SetShapeEvent added GotFocus and LostFocus events";
            treeNode446.Name = "Node10";
            treeNode446.Text = "LDShapes";
            treeNode447.Name = "Node6";
            treeNode447.Text = "Version 1.0.0.106";
            treeNode448.Name = "Node5";
            treeNode448.Text = "Menu control added";
            treeNode449.Name = "Node4";
            treeNode449.Text = "LDControls";
            treeNode450.Name = "Node3";
            treeNode450.Text = "Version 1.0.0.105";
            treeNode451.Name = "Node5";
            treeNode451.Text = "ZipList method added";
            treeNode452.Name = "Node2";
            treeNode452.Text = "GetNextMapIndex method added";
            treeNode453.Name = "Node4";
            treeNode453.Text = "LDUtilities";
            treeNode454.Name = "Node1";
            treeNode454.Text = "GetColour method added (gets Brush, Pen and Opacity)";
            treeNode455.Name = "Node0";
            treeNode455.Text = "LDShapes";
            treeNode456.Name = "Node3";
            treeNode456.Text = "Version 1.0.0.104";
            treeNode457.Name = "Node1";
            treeNode457.Text = "Transparency maintained for various methods";
            treeNode458.Name = "Node2";
            treeNode458.Text = "Effects bug fixed";
            treeNode459.Name = "Node0";
            treeNode459.Text = "LDImage";
            treeNode460.Name = "Node0";
            treeNode460.Text = "Version 1.0.0.103";
            treeNode461.Name = "Node1";
            treeNode461.Text = "Current application assemblies are all auto-referenced";
            treeNode462.Name = "Node0";
            treeNode462.Text = "LDInline";
            treeNode463.Name = "Node5";
            treeNode463.Text = "Version 1.0.0.102";
            treeNode464.Name = "Node1";
            treeNode464.Text = "Include C# or VB methods, properties and events to compile and call from your Sma" +
    "llBasic code";
            treeNode465.Name = "Node2";
            treeNode465.Text = "LDInline.sb sample provided";
            treeNode466.Name = "Node0";
            treeNode466.Text = "LDInline";
            treeNode467.Name = "Node4";
            treeNode467.Text = "ExitButtonMode method added to control window close button state";
            treeNode468.Name = "Node3";
            treeNode468.Text = "LDUtilities";
            treeNode469.Name = "Node0";
            treeNode469.Text = "Version 1.0.0.101";
            treeNode470.Name = "Node1";
            treeNode470.Text = "Read and ReadNumber methods added (with a delay before auto return)";
            treeNode471.Name = "Node0";
            treeNode471.Text = "KeyDown, KeyUp and SendKey (low level keyboard control) added";
            treeNode472.Name = "Node0";
            treeNode472.Text = "LDTextWindow";
            treeNode473.Name = "Node0";
            treeNode473.Text = "Version 1.0.0.100";
            treeNode474.Name = "Node2";
            treeNode474.Text = "ReadANSIToArray method added";
            treeNode475.Name = "Node1";
            treeNode475.Text = "LDFile";
            treeNode476.Name = "Node1";
            treeNode476.Text = "DocumentViewer control added";
            treeNode477.Name = "Node0";
            treeNode477.Text = "LDControls";
            treeNode478.Name = "Node3";
            treeNode478.Text = "An object to batch update shapes (for speed reasons)";
            treeNode479.Name = "Node0";
            treeNode479.Text = "LDFastShapes.sb sample included";
            treeNode480.Name = "Node2";
            treeNode480.Text = "LDFastShapes";
            treeNode481.Name = "Node0";
            treeNode481.Text = "Version 1.0.0.99";
            treeNode482.Name = "Node1";
            treeNode482.Text = "Rendering performance improvements when many shapes present";
            treeNode483.Name = "Node0";
            treeNode483.Text = "LDPhysics";
            treeNode484.Name = "Node1";
            treeNode484.Text = "ANSItoUTF8 method added";
            treeNode485.Name = "Node2";
            treeNode485.Text = "ReadANSI method added";
            treeNode486.Name = "Node0";
            treeNode486.Text = "LDFile";
            treeNode487.Name = "Node1";
            treeNode487.Text = "Version 1.0.0.98";
            treeNode488.Name = "Node3";
            treeNode488.Text = "Move method added for tiangles, polygons and lines";
            treeNode489.Name = "Node4";
            treeNode489.Text = "RotateAbout method added";
            treeNode490.Name = "Node1";
            treeNode490.Text = "GetLeft and GetTop methods added for triangles, polygons and lines";
            treeNode491.Name = "Node0";
            treeNode491.Text = "SetTurtleImage repositioning \'hot spot\' on resize fixed";
            treeNode492.Name = "Node2";
            treeNode492.Text = "LDShapes";
            treeNode493.Name = "Node0";
            treeNode493.Text = "Version 1.0.0.97";
            treeNode494.Name = "Node4";
            treeNode494.Text = "A list storage object added";
            treeNode495.Name = "Node3";
            treeNode495.Text = "LDList";
            treeNode496.Name = "Node2";
            treeNode496.Text = "Version 1.0.0.96";
            treeNode497.Name = "Node4";
            treeNode497.Text = "A queue (first-in first-out) storage similar to a stack object added";
            treeNode498.Name = "Node3";
            treeNode498.Text = "LDQueue";
            treeNode499.Name = "Node6";
            treeNode499.Text = "Fix for multi-dimensional arrays using GetGameData and SetGameData";
            treeNode500.Name = "Node5";
            treeNode500.Text = "LDNetwork";
            treeNode501.Name = "Node0";
            treeNode501.Text = "Returned arrays with \\= or ; in index or value correctly handled";
            treeNode502.Name = "Node1";
            treeNode502.Text = "General";
            treeNode503.Name = "Node2";
            treeNode503.Text = "Version 1.0.0.95";
            treeNode504.Name = "Node2";
            treeNode504.Text = "SHA512Hash and MD5HashFile methods added";
            treeNode505.Name = "Node1";
            treeNode505.Text = "LDEncryption";
            treeNode506.Name = "Node1";
            treeNode506.Text = "RandomNumberSeed property added";
            treeNode507.Name = "Node0";
            treeNode507.Text = "LDMath";
            treeNode508.Name = "Node1";
            treeNode508.Text = "SetGameData and GetGameData methods added";
            treeNode509.Name = "Node0";
            treeNode509.Text = "LDNetwork";
            treeNode510.Name = "Node0";
            treeNode510.Text = "Version 1.0.0.94";
            treeNode511.Name = "Node1";
            treeNode511.Text = "SliderGetValue method added";
            treeNode512.Name = "Node0";
            treeNode512.Text = "LDControls";
            treeNode513.Name = "Node5";
            treeNode513.Text = "UnZip now works with most zip formats, not just those created with LDUtilities.Zi" +
    "p";
            treeNode514.Name = "Node2";
            treeNode514.Text = "LDUtilities";
            treeNode515.Name = "Node3";
            treeNode515.Text = "Encrypt and Decrypt methods added";
            treeNode516.Name = "Node4";
            treeNode516.Text = "MD5Hash method added";
            treeNode517.Name = "Node6";
            treeNode517.Text = "LDEncryption";
            treeNode518.Name = "Node0";
            treeNode518.Text = "Version 1.0.0.93";
            treeNode519.Name = "Node1";
            treeNode519.Text = "ProgressBar, Slider and PasswordBox controls added";
            treeNode520.Name = "Node0";
            treeNode520.Text = "LDControls";
            treeNode521.Name = "Node0";
            treeNode521.Text = "Version 1.0.0.92";
            treeNode522.Name = "Node2";
            treeNode522.Text = "TreeViewGetSelected, ListBoxGetSelected, ComboBoxGetSelected, CheckBoxGetState an" +
    "d RadioButtonGet methods added";
            treeNode523.Name = "Node1";
            treeNode523.Text = "LDControls";
            treeNode524.Name = "Node1";
            treeNode524.Text = "Version 1.0.0.91";
            treeNode525.Name = "Node1";
            treeNode525.Text = "Font method added to modify shapes or controls that have text";
            treeNode526.Name = "Node0";
            treeNode526.Text = "LDShapes";
            treeNode527.Name = "Node1";
            treeNode527.Text = "MediaPlayer control added (play videos etc)";
            treeNode528.Name = "Node0";
            treeNode528.Text = "ListBoxContent, TreeViewContent and ComboBoxContent methods added to change list " +
    "contents";
            treeNode529.Name = "Node0";
            treeNode529.Text = "LDControls";
            treeNode530.Name = "Node1";
            treeNode530.Text = "Version 1.0.0.90";
            treeNode531.Name = "Node1";
            treeNode531.Text = "Autosize columns for ListView";
            treeNode532.Name = "Node2";
            treeNode532.Text = "LDDataBase.sb sample updated";
            treeNode533.Name = "Node0";
            treeNode533.Text = "Optionally return array of results for query (GetRecord removed)";
            treeNode534.Name = "Node0";
            treeNode534.Text = "LDDataBase";
            treeNode535.Name = "Node0";
            treeNode535.Text = "Version 1.0.0.89";
            treeNode536.Name = "Node4";
            treeNode536.Text = "GraphicsWindow.MouseDown works for any event subroutine name";
            treeNode537.Name = "Node3";
            treeNode537.Text = "LDScrollBars";
            treeNode538.Name = "Node1";
            treeNode538.Text = "CleanTemp method added";
            treeNode539.Name = "Node0";
            treeNode539.Text = "LDUtilities";
            treeNode540.Name = "Node1";
            treeNode540.Text = "SQLite database methods added";
            treeNode541.Name = "Node0";
            treeNode541.Text = "LDDataBase";
            treeNode542.Name = "Node2";
            treeNode542.Text = "Version 1.0.0.88";
            treeNode543.Name = "Node2";
            treeNode543.Text = "LastError now returns a text error";
            treeNode544.Name = "Node1";
            treeNode544.Text = "LDIOWarrior";
            treeNode545.Name = "Node1";
            treeNode545.Text = "MouseDown (must be named \"OnMouseDown\") and MouseWheel events fixed";
            treeNode546.Name = "Node0";
            treeNode546.Text = "LDScrollBars";
            treeNode547.Name = "Node0";
            treeNode547.Text = "Version 1.0.0.87";
            treeNode548.Name = "Node4";
            treeNode548.Text = "SetTurtleImage method added";
            treeNode549.Name = "Node3";
            treeNode549.Text = "LDShapes";
            treeNode550.Name = "Node1";
            treeNode550.Text = "Connect to IOWarrior USB devices";
            treeNode551.Name = "Node0";
            treeNode551.Text = "http://www.codemercs.com/io-warrior/?L=1";
            treeNode552.Name = "Node0";
            treeNode552.Text = "LDIOWarrior";
            treeNode553.Name = "Node2";
            treeNode553.Text = "Version 1.0.0.86";
            treeNode554.Name = "Node1";
            treeNode554.Text = "PenColour, BrushColour and BrushGradientShape applied to most Shapes and Controls" +
    "";
            treeNode555.Name = "Node0";
            treeNode555.Text = "LDShapes";
            treeNode556.Name = "Node2";
            treeNode556.Text = "Version 1.0.0.85";
            treeNode557.Name = "Node4";
            treeNode557.Text = "GetFolder, GetFile and GetExtension methods added";
            treeNode558.Name = "Node3";
            treeNode558.Text = "LDFile";
            treeNode559.Name = "Node6";
            treeNode559.Text = "Crop method added";
            treeNode560.Name = "Node5";
            treeNode560.Text = "LDImage";
            treeNode561.Name = "Node1";
            treeNode561.Text = "LastDropFiles bug fixed";
            treeNode562.Name = "Node0";
            treeNode562.Text = "LDControls";
            treeNode563.Name = "Node2";
            treeNode563.Text = "Version 1.0.0.84";
            treeNode564.Name = "Node7";
            treeNode564.Text = "FileDropped event added";
            treeNode565.Name = "Node6";
            treeNode565.Text = "LDControls";
            treeNode566.Name = "Node1";
            treeNode566.Text = "Bug in Split corrected";
            treeNode567.Name = "Node0";
            treeNode567.Text = "LDText";
            treeNode568.Name = "Node5";
            treeNode568.Text = "Version 1.0.0.83";
            treeNode569.Name = "Node3";
            treeNode569.Text = "Title argument removed from AddComboBox";
            treeNode570.Name = "Node4";
            treeNode570.Text = "AllowDrop method added (for TextBox, RichTextBox, Image and Background)";
            treeNode571.Name = "Node2";
            treeNode571.Text = "LDControls";
            treeNode572.Name = "Node1";
            treeNode572.Text = "Version 1.0.0.82";
            treeNode573.Name = "Node0";
            treeNode573.Text = "German xml updated (Thanks to Pappa Lapub)";
            treeNode574.Name = "Node12";
            treeNode574.Text = "Program settings added";
            treeNode575.Name = "Node9";
            treeNode575.Text = "LDSettings";
            treeNode576.Name = "Node11";
            treeNode576.Text = "Get some system paths and user name";
            treeNode577.Name = "Node10";
            treeNode577.Text = "LDFile";
            treeNode578.Name = "Node14";
            treeNode578.Text = "System sounds added";
            treeNode579.Name = "Node13";
            treeNode579.Text = "LDSound";
            treeNode580.Name = "Node16";
            treeNode580.Text = "Binary, octal, hex and decimal conversions";
            treeNode581.Name = "Node15";
            treeNode581.Text = "LDMath";
            treeNode582.Name = "Node1";
            treeNode582.Text = "Replace method added";
            treeNode583.Name = "Node2";
            treeNode583.Text = "FindAll method added";
            treeNode584.Name = "Node0";
            treeNode584.Text = "LDText";
            treeNode585.Name = "Node8";
            treeNode585.Text = "Version 1.0.0.81";
            treeNode586.Name = "Node1";
            treeNode586.Text = "BrushColour, BrushGradientShape and PenColour implemented for buttons";
            treeNode587.Name = "Node6";
            treeNode587.Text = "General events for shapes added (see ShapeEvents sample)";
            treeNode588.Name = "Node0";
            treeNode588.Text = "LDShapes";
            treeNode589.Name = "Node3";
            treeNode589.Text = "Truncate method added";
            treeNode590.Name = "Node2";
            treeNode590.Text = "LDMath";
            treeNode591.Name = "Node5";
            treeNode591.Text = "Additional text methods";
            treeNode592.Name = "Node4";
            treeNode592.Text = "LDText";
            treeNode593.Name = "Node0";
            treeNode593.Text = "Version 1.0.0.80";
            treeNode594.Name = "Node1";
            treeNode594.Text = "Confirm dialog message box (Yes, No, Cancel) added";
            treeNode595.Name = "Node0";
            treeNode595.Text = "LDDialogs";
            treeNode596.Name = "Node1";
            treeNode596.Text = "CancelClose property added for GraphicsWindow closure";
            treeNode597.Name = "Node0";
            treeNode597.Text = "LDUtilities";
            treeNode598.Name = "Node6";
            treeNode598.Text = "Version 1.0.0.79";
            treeNode599.Name = "Node2";
            treeNode599.Text = "Rasterize property added";
            treeNode600.Name = "Node5";
            treeNode600.Text = "Improvements associated with window resizing";
            treeNode601.Name = "Node1";
            treeNode601.Text = "LDScrollBars";
            treeNode602.Name = "Node4";
            treeNode602.Text = "ExitOnClose property (and GWClosing event) added";
            treeNode603.Name = "Node3";
            treeNode603.Text = "LDUtilities";
            treeNode604.Name = "Node0";
            treeNode604.Text = "Version 1.0.0.78";
            treeNode605.Name = "Node1";
            treeNode605.Text = "Handle more than 100 drawables (rasterization)";
            treeNode606.Name = "Node0";
            treeNode606.Text = "LDScollBars";
            treeNode607.Name = "Node2";
            treeNode607.Text = "Version 1.0.0.77";
            treeNode608.Name = "Node1";
            treeNode608.Text = "Record sound from a microphone";
            treeNode609.Name = "Node0";
            treeNode609.Text = "LDSound";
            treeNode610.Name = "Node3";
            treeNode610.Text = "AnimateOpacity method added (flashing)";
            treeNode611.Name = "Node0";
            treeNode611.Text = "AnimateRotation method added (continuous rotation)";
            treeNode612.Name = "Node1";
            treeNode612.Text = "AnimateZoom method added (coninuous zooming)";
            treeNode613.Name = "Node2";
            treeNode613.Text = "LDShapes";
            treeNode614.Name = "Node2";
            treeNode614.Text = "Version 1.0.0.76";
            treeNode615.Name = "Node1";
            treeNode615.Text = "AddAnimatedImage can use an ImageList image";
            treeNode616.Name = "Node0";
            treeNode616.Text = "LDShapes";
            treeNode617.Name = "Node0";
            treeNode617.Text = "Version 1.0.0.75";
            treeNode618.Name = "Node1";
            treeNode618.Text = "Initial graph axes scaling improvement";
            treeNode619.Name = "Node0";
            treeNode619.Text = "LDGraph";
            treeNode620.Name = "Node3";
            treeNode620.Text = "Methods to access a bluetooth device";
            treeNode621.Name = "Node0";
            treeNode621.Text = "Includes simple file transfer and potentially advanced device interaction";
            treeNode622.Name = "Node2";
            treeNode622.Text = "LDBlueTooth";
            treeNode623.Name = "Node1";
            treeNode623.Text = "getFocus handles multiple LDWindows";
            treeNode624.Name = "Node0";
            treeNode624.Text = "LDFocus";
            treeNode625.Name = "Node0";
            treeNode625.Text = "Version 1.0.0.74";
            treeNode626.Name = "Node1";
            treeNode626.Text = "First pass at a generic USB (HID) device controller";
            treeNode627.Name = "Node0";
            treeNode627.Text = "LDHID";
            treeNode628.Name = "Node9";
            treeNode628.Text = "Version 1.0.0.73";
            treeNode629.Name = "Node8";
            treeNode629.Text = "Initial scaling doesn\'t position points touching the axes";
            treeNode630.Name = "Node7";
            treeNode630.Text = "LDGraph";
            treeNode631.Name = "Node6";
            treeNode631.Text = "Version 1.0.0.72";
            treeNode632.Name = "Node4";
            treeNode632.Text = "TrendCoef method added to get polynomial trend line coefficients";
            treeNode633.Name = "Node5";
            treeNode633.Text = "TrendPointCount property added to control the number of points on a trend line";
            treeNode634.Name = "Node3";
            treeNode634.Text = "LDGraph";
            treeNode635.Name = "Node2";
            treeNode635.Text = "Version 1.0.0.71";
            treeNode636.Name = "Node1";
            treeNode636.Text = "Spurious error message fixed";
            treeNode637.Name = "Node2";
            treeNode637.Text = "CreateTrend data series creation method added";
            treeNode638.Name = "Node0";
            treeNode638.Text = "LDGraph";
            treeNode639.Name = "Node2";
            treeNode639.Text = "Version 1.0.0.70";
            treeNode640.Name = "Node1";
            treeNode640.Text = "Font properties and colours set for LDControls in the same way as standard Contro" +
    "ls";
            treeNode641.Name = "Node0";
            treeNode641.Text = "LDControls";
            treeNode642.Name = "Node3";
            treeNode642.Text = "Version 1.0.0.69";
            treeNode643.Name = "Node2";
            treeNode643.Text = "Radio button control added";
            treeNode644.Name = "Node1";
            treeNode644.Text = "LDControls";
            treeNode645.Name = "Node0";
            treeNode645.Text = "Version 1.0.0.68";
            treeNode646.Name = "Node1";
            treeNode646.Text = "Bug fix for Copy";
            treeNode647.Name = "Node0";
            treeNode647.Text = "LDArray";
            treeNode648.Name = "Node2";
            treeNode648.Text = "Version 1.0.0.67";
            treeNode649.Name = "Node1";
            treeNode649.Text = "RegexMatch and RegexReplace methods added";
            treeNode650.Name = "Node0";
            treeNode650.Text = "LDUtilities";
            treeNode651.Name = "Node3";
            treeNode651.Text = "Version 1.0.0.66";
            treeNode652.Name = "Node2";
            treeNode652.Text = "Number culture conversions added";
            treeNode653.Name = "Node1";
            treeNode653.Text = "LDUtilities";
            treeNode654.Name = "Node0";
            treeNode654.Text = "Version 1.0.0.65";
            treeNode655.Name = "Node1";
            treeNode655.Text = "IsNumber method added";
            treeNode656.Name = "Node0";
            treeNode656.Text = "LDUtilities";
            treeNode657.Name = "Node2";
            treeNode657.Text = "Version 1.0.0.64";
            treeNode658.Name = "Node1";
            treeNode658.Text = "SetCursorPosition method added for textboxes";
            treeNode659.Name = "Node0";
            treeNode659.Text = "LDControls";
            treeNode660.Name = "Node4";
            treeNode660.Text = "Version 1.0.0.63";
            treeNode661.Name = "Node1";
            treeNode661.Text = "SetCursorToEnd method added for textboxes";
            treeNode662.Name = "Node3";
            treeNode662.Text = "SetSpellCheck method added for textboxes and richtextboxes";
            treeNode663.Name = "Node0";
            treeNode663.Text = "LDControls";
            treeNode664.Name = "Node2";
            treeNode664.Text = "Version 1.0.0.62";
            treeNode665.Name = "Node1";
            treeNode665.Text = "Adding polygons not located at (0,0) corrected";
            treeNode666.Name = "Node0";
            treeNode666.Text = "LDPhysics";
            treeNode667.Name = "Node2";
            treeNode667.Text = "Version 1.0.0.61";
            treeNode668.Name = "Node1";
            treeNode668.Text = "GetFolder dialog added";
            treeNode669.Name = "Node0";
            treeNode669.Text = "LDDialogs";
            treeNode670.Name = "Node0";
            treeNode670.Text = "Version 1.0.0.60";
            treeNode671.Name = "Node10";
            treeNode671.Text = "Possible localization issue with Font size fixed";
            treeNode672.Name = "Node9";
            treeNode672.Text = "LDDialogs";
            treeNode673.Name = "Node8";
            treeNode673.Text = "Version 1.0.0.59";
            treeNode674.Name = "Node3";
            treeNode674.Text = "More internationalization fixes";
            treeNode675.Name = "Node2";
            treeNode675.Text = "ShowPrintPreview property added";
            treeNode676.Name = "Node1";
            treeNode676.Text = "LDUtilities";
            treeNode677.Name = "Node5";
            treeNode677.Text = "Possible error with gradient drawings fixed";
            treeNode678.Name = "Node4";
            treeNode678.Text = "LDShapes";
            treeNode679.Name = "Node7";
            treeNode679.Text = "Possible Listen event initialisation error fixed";
            treeNode680.Name = "Node6";
            treeNode680.Text = "LDSpeech";
            treeNode681.Name = "Node0";
            treeNode681.Text = "Version 1.0.0.58";
            treeNode682.Name = "Node7";
            treeNode682.Text = "Many possible internationisation issues fixed";
            treeNode683.Name = "Node4";
            treeNode683.Text = "Version 1.0.0.57";
            treeNode684.Name = "Node1";
            treeNode684.Text = "Emmisive colour correction for AddGeometry";
            treeNode685.Name = "Node2";
            treeNode685.Text = "Geometry coordinates etc are now colon or space deminiated (not comma)";
            treeNode686.Name = "Node0";
            treeNode686.Text = "LD3DView";
            treeNode687.Name = "Node1";
            treeNode687.Text = "CSVdeminiator property added";
            treeNode688.Name = "Node0";
            treeNode688.Text = "LDUtilities";
            treeNode689.Name = "Node5";
            treeNode689.Text = "Version 1.0.0.56";
            treeNode690.Name = "Node1";
            treeNode690.Text = "Improved error reporting";
            treeNode691.Name = "Node2";
            treeNode691.Text = "Culture invariant type conversions";
            treeNode692.Name = "Node1";
            treeNode692.Text = "LD3DView";
            treeNode693.Name = "Node4";
            treeNode693.Text = "ShowErrors method added";
            treeNode694.Name = "Node3";
            treeNode694.Text = "LDUtilities";
            treeNode695.Name = "Node0";
            treeNode695.Text = "Version 1.0.0.55";
            treeNode696.Name = "Node4";
            treeNode696.Text = "Warning added to intellisense help about  resizing GraphicsWindow";
            treeNode697.Name = "Node3";
            treeNode697.Text = "LDScrollBars";
            treeNode698.Name = "Node6";
            treeNode698.Text = "GWWidth and GWHeight added for use with LDScrollBars";
            treeNode699.Name = "Node5";
            treeNode699.Text = "LDUtilities";
            treeNode700.Name = "Node2";
            treeNode700.Text = "Version 1.0.0.54";
            treeNode701.Name = "Node1";
            treeNode701.Text = "Debug window can be resized";
            treeNode702.Name = "Node0";
            treeNode702.Text = "LDDebug";
            treeNode703.Name = "Node1";
            treeNode703.Text = "PrintFile method added";
            treeNode704.Name = "Node0";
            treeNode704.Text = "LDFile";
            treeNode705.Name = "Node2";
            treeNode705.Text = "Version 1.0.0.53";
            treeNode706.Name = "Node1";
            treeNode706.Text = "SSL property option added";
            treeNode707.Name = "Node0";
            treeNode707.Text = "LDEmail";
            treeNode708.Name = "Node0";
            treeNode708.Text = "Version 1.0.0.52";
            treeNode709.Name = "Node1";
            treeNode709.Text = "Right Click Context menu added for any shape or control";
            treeNode710.Name = "Node0";
            treeNode710.Text = "LDControls";
            treeNode711.Name = "Node0";
            treeNode711.Text = "Version 1.0.0.51";
            treeNode712.Name = "Node1";
            treeNode712.Text = "Right click dropdown menu option added";
            treeNode713.Name = "Node0";
            treeNode713.Text = "LDDialogs";
            treeNode714.Name = "Node0";
            treeNode714.Text = "Version 1.0.0.50";
            treeNode715.Name = "Node1";
            treeNode715.Text = "More methods added, AddSphere, AddTube, ReverseNormals";
            treeNode716.Name = "Node0";
            treeNode716.Text = "LD3DView";
            treeNode717.Name = "Node0";
            treeNode717.Text = "Version 1.0.0.49";
            treeNode718.Name = "Node1";
            treeNode718.Text = "Performance improvements (some camera controls for this)";
            treeNode719.Name = "Node1";
            treeNode719.Text = "LoadModel (*.3ds) files added";
            treeNode720.Name = "Node0";
            treeNode720.Text = "LD3DView";
            treeNode721.Name = "Node3";
            treeNode721.Text = "AddStar and AddRegularPolygon shape methods added";
            treeNode722.Name = "Node2";
            treeNode722.Text = "LDShapes";
            treeNode723.Name = "Node0";
            treeNode723.Text = "Version 1.0.0.48";
            treeNode724.Name = "Node1";
            treeNode724.Text = "Some improvements including animations";
            treeNode725.Name = "Node0";
            treeNode725.Text = "LD3DView";
            treeNode726.Name = "Node0";
            treeNode726.Text = "Version 1.0.0.47";
            treeNode727.Name = "Node1";
            treeNode727.Text = "Some improvemts and new methods";
            treeNode728.Name = "Node0";
            treeNode728.Text = "LD3Dview";
            treeNode729.Name = "Node2";
            treeNode729.Text = "Version 1.0.0.46";
            treeNode730.Name = "Node1";
            treeNode730.Text = "A start at a 3D set of methods";
            treeNode731.Name = "Node0";
            treeNode731.Text = "LD3DView";
            treeNode732.Name = "Node10";
            treeNode732.Text = "Version 1.0.0.45";
            treeNode733.Name = "Node1";
            treeNode733.Text = "Create scrollbars for the GraphicsWindow";
            treeNode734.Name = "Node5";
            treeNode734.Text = "Methods to control the scrollbars allowing a scrolling game to be made";
            treeNode735.Name = "Node0";
            treeNode735.Text = "LDScrollBars";
            treeNode736.Name = "Node4";
            treeNode736.Text = "ColourList method added";
            treeNode737.Name = "Node3";
            treeNode737.Text = "LDUtilities";
            treeNode738.Name = "Node8";
            treeNode738.Text = "Linear and radial gradient methods for shapes, drawings and background";
            treeNode739.Name = "Node9";
            treeNode739.Text = "BackgroundImage method to set the background added";
            treeNode740.Name = "Node6";
            treeNode740.Text = "LDShapes";
            treeNode741.Name = "Node0";
            treeNode741.Text = "Version 1.0.0.44";
            treeNode742.Name = "Node1";
            treeNode742.Text = "AddScrollBars method added for the GraphicsWindow";
            treeNode743.Name = "Node0";
            treeNode743.Text = "LDUtilities";
            treeNode744.Name = "Node0";
            treeNode744.Text = "Version 1.0.0.43";
            treeNode745.Name = "Node1";
            treeNode745.Text = "Call Subs as functions with arguments";
            treeNode746.Name = "Node0";
            treeNode746.Text = "LDCall";
            treeNode747.Name = "Node0";
            treeNode747.Text = "Version 1.0.0.42";
            treeNode748.Name = "Node1";
            treeNode748.Text = "Font dialog added";
            treeNode749.Name = "Node2";
            treeNode749.Text = "Colours dialog moved here from LDColours";
            treeNode750.Name = "Node0";
            treeNode750.Text = "LDDialogs";
            treeNode751.Name = "Node9";
            treeNode751.Text = "Version 1.0.0.41";
            treeNode752.Name = "Node1";
            treeNode752.Text = "Controls methods (RichTextBox and TreeView) moved here from LDDialogs";
            treeNode753.Name = "Node7";
            treeNode753.Text = "WebBrowser, ListBox, ComboBox and CheckBox objects added";
            treeNode754.Name = "Node8";
            treeNode754.Text = "Some methods renamed";
            treeNode755.Name = "Node0";
            treeNode755.Text = "LDControls";
            treeNode756.Name = "Node3";
            treeNode756.Text = "HighScore method move here";
            treeNode757.Name = "Node2";
            treeNode757.Text = "LDNetwork";
            treeNode758.Name = "Node6";
            treeNode758.Text = "SetSize method added";
            treeNode759.Name = "Node5";
            treeNode759.Text = "LDShapes";
            treeNode760.Name = "Node3";
            treeNode760.Text = "Version 1.0.0.40";
            treeNode761.Name = "Node1";
            treeNode761.Text = "SelectTreeView method added";
            treeNode762.Name = "Node2";
            treeNode762.Text = "A currently selected node also registers selection event when it is clicked";
            treeNode763.Name = "Node0";
            treeNode763.Text = "LDDialogs";
            treeNode764.Name = "Node1";
            treeNode764.Text = "Simple high score web method";
            treeNode765.Name = "Node0";
            treeNode765.Text = "LDHighScore";
            treeNode766.Name = "Node3";
            treeNode766.Text = "Version 1.0.0.39";
            treeNode767.Name = "Node2";
            treeNode767.Text = "RichTextBox methods improved";
            treeNode768.Name = "Node1";
            treeNode768.Text = "LDDialogs";
            treeNode769.Name = "Node1";
            treeNode769.Text = "Search, Load and Save methods added";
            treeNode770.Name = "Node0";
            treeNode770.Text = "LDArray";
            treeNode771.Name = "Node0";
            treeNode771.Text = "Version 1.0.0.38";
            treeNode772.Name = "Node1";
            treeNode772.Text = "Depreciated";
            treeNode773.Name = "Node0";
            treeNode773.Text = "LDWeather";
            treeNode774.Name = "Node1";
            treeNode774.Text = "Renamed from LDTrig and some more methods added";
            treeNode775.Name = "Node0";
            treeNode775.Text = "LDMath";
            treeNode776.Name = "Node3";
            treeNode776.Text = "RichTextBox method added";
            treeNode777.Name = "Node2";
            treeNode777.Text = "LDDialogs";
            treeNode778.Name = "Node5";
            treeNode778.Text = "FontList method added";
            treeNode779.Name = "Node4";
            treeNode779.Text = "LDUtilities";
            treeNode780.Name = "Node2";
            treeNode780.Text = "Version 1.0.0.37";
            treeNode781.Name = "Node1";
            treeNode781.Text = "Zip method extended";
            treeNode782.Name = "Node0";
            treeNode782.Text = "LDUtilities";
            treeNode783.Name = "Node2";
            treeNode783.Text = "Version 1.0.0.36";
            treeNode784.Name = "Node1";
            treeNode784.Text = "Collapse and expand treeview nodes method added";
            treeNode785.Name = "Node0";
            treeNode785.Text = "LDDialogs";
            treeNode786.Name = "Node5";
            treeNode786.Text = "Version 1.0.0.35";
            treeNode787.Name = "Node1";
            treeNode787.Text = "Arguments added to Start method";
            treeNode788.Name = "Node0";
            treeNode788.Text = "LDProcess";
            treeNode789.Name = "Node4";
            treeNode789.Text = "Zip compression methods added";
            treeNode790.Name = "Node2";
            treeNode790.Text = "LDUtilities";
            treeNode791.Name = "Node2";
            treeNode791.Text = "Version 1.0.0.34";
            treeNode792.Name = "Node1";
            treeNode792.Text = "GWStyle property added";
            treeNode793.Name = "Node0";
            treeNode793.Text = "LDUtilities";
            treeNode794.Name = "Node1";
            treeNode794.Text = "TreeView and associated events added";
            treeNode795.Name = "Node0";
            treeNode795.Text = "LDDialogs";
            treeNode796.Name = "Node0";
            treeNode796.Text = "Version 1.0.0.33";
            treeNode797.Name = "Node1";
            treeNode797.Text = "Possible end points not plotting bug fixed";
            treeNode798.Name = "Node0";
            treeNode798.Text = "LDGraph";
            treeNode799.Name = "Node2";
            treeNode799.Text = "Version 1.0.0.32";
            treeNode800.Name = "Node1";
            treeNode800.Text = "Activated event and Active property addded";
            treeNode801.Name = "Node0";
            treeNode801.Text = "LDWindows";
            treeNode802.Name = "Node0";
            treeNode802.Text = "Version 1.0.0.31";
            treeNode803.Name = "Node1";
            treeNode803.Text = "Create multiple GraphicsWindows";
            treeNode804.Name = "Node0";
            treeNode804.Text = "LDWindows";
            treeNode805.Name = "Node0";
            treeNode805.Text = "Version 1.0.0.30";
            treeNode806.Name = "Node1";
            treeNode806.Text = "Email sending method";
            treeNode807.Name = "Node0";
            treeNode807.Text = "LDMail";
            treeNode808.Name = "Node1";
            treeNode808.Text = "Add and Multiply methods bug fixed";
            treeNode809.Name = "Node2";
            treeNode809.Text = "Image statistics combined into one method";
            treeNode810.Name = "Node3";
            treeNode810.Text = "Histogram method added";
            treeNode811.Name = "Node0";
            treeNode811.Text = "LDImage";
            treeNode812.Name = "Node0";
            treeNode812.Text = "Version 1.0.0.29";
            treeNode813.Name = "Node1";
            treeNode813.Text = "SnapshotToImageList method added";
            treeNode814.Name = "Node0";
            treeNode814.Text = "LDWebCam";
            treeNode815.Name = "Node3";
            treeNode815.Text = "ImageList image manipulation methods";
            treeNode816.Name = "Node2";
            treeNode816.Text = "LDImage";
            treeNode817.Name = "Node0";
            treeNode817.Text = "Version 1.0.0.28";
            treeNode818.Name = "Node1";
            treeNode818.Text = "SortIndex bugfix for null values";
            treeNode819.Name = "Node0";
            treeNode819.Text = "LDArray";
            treeNode820.Name = "Node1";
            treeNode820.Text = "SnapshotToFile bug fixed";
            treeNode821.Name = "Node0";
            treeNode821.Text = "LDWebCam";
            treeNode822.Name = "Node0";
            treeNode822.Text = "Version 1.0.0.27";
            treeNode823.Name = "Node1";
            treeNode823.Text = "SortIndex method added";
            treeNode824.Name = "Node0";
            treeNode824.Text = "LDArray";
            treeNode825.Name = "Node1";
            treeNode825.Text = "Web based weather report data added";
            treeNode826.Name = "Node0";
            treeNode826.Text = "LDWeather";
            treeNode827.Name = "Node3";
            treeNode827.Text = "DataReceived event added";
            treeNode828.Name = "Node2";
            treeNode828.Text = "LDCommPort";
            treeNode829.Name = "Node0";
            treeNode829.Text = "Version 1.0.0.26";
            treeNode830.Name = "Node1";
            treeNode830.Text = "Speech recognition added";
            treeNode831.Name = "Node0";
            treeNode831.Text = "LDSpeech";
            treeNode832.Name = "Node0";
            treeNode832.Text = "Version 1.0.0.25";
            treeNode833.Name = "Node4";
            treeNode833.Text = "More methods added and some internal code optimised";
            treeNode834.Name = "Node0";
            treeNode834.Text = "LDArray & LDMatrix";
            treeNode835.Name = "Node1";
            treeNode835.Text = "KeyDown method added";
            treeNode836.Name = "Node0";
            treeNode836.Text = "LDUtilities";
            treeNode837.Name = "Node1";
            treeNode837.Text = "GetAllShapesAt method added";
            treeNode838.Name = "Node0";
            treeNode838.Text = "Overlap method for ellipse and rectangle combinations added";
            treeNode839.Name = "Node0";
            treeNode839.Text = "LDShapes";
            treeNode840.Name = "Node0";
            treeNode840.Text = "Version 1.0.0.24";
            treeNode841.Name = "Node1";
            treeNode841.Text = "OpenFile and SaveFile dialogs added";
            treeNode842.Name = "Node0";
            treeNode842.Text = "LDDialogs";
            treeNode843.Name = "Node2";
            treeNode843.Text = "Matrix methods, for example to solve linear equations";
            treeNode844.Name = "Node1";
            treeNode844.Text = "LDMatrix";
            treeNode845.Name = "Node0";
            treeNode845.Text = "Version 1.0.0.23";
            treeNode846.Name = "Node1";
            treeNode846.Text = "Sorting method added";
            treeNode847.Name = "Node0";
            treeNode847.Text = "LDArray";
            treeNode848.Name = "Node0";
            treeNode848.Text = "Version 1.0.0.22";
            treeNode849.Name = "Node2";
            treeNode849.Text = "Velocity Threshold setting added";
            treeNode850.Name = "Node1";
            treeNode850.Text = "LDPhysics";
            treeNode851.Name = "Node0";
            treeNode851.Text = "Version 1.0.0.21";
            treeNode852.Name = "Node3";
            treeNode852.Text = "SetDamping method added";
            treeNode853.Name = "Node2";
            treeNode853.Text = "LDPhysics";
            treeNode854.Name = "Node1";
            treeNode854.Text = "Version 1.0.0.20";
            treeNode855.Name = "Node1";
            treeNode855.Text = "Instrument name can be obtained from its number";
            treeNode856.Name = "Node0";
            treeNode856.Text = "LDMusic";
            treeNode857.Name = "Node0";
            treeNode857.Text = "Version 1.0.0.19";
            treeNode858.Name = "Node1";
            treeNode858.Text = "Calendar uses MS visual styles if available (better calendar, but no colours)";
            treeNode859.Name = "Node0";
            treeNode859.Text = "LDDialogs";
            treeNode860.Name = "Node1";
            treeNode860.Text = "Extends Sounds.PlayMusic to include additional instruments";
            treeNode861.Name = "Node2";
            treeNode861.Text = "Notes can also be played synchronously (chords)";
            treeNode862.Name = "Node0";
            treeNode862.Text = "LDMusic";
            treeNode863.Name = "Node0";
            treeNode863.Text = "Version 1.0.0.18";
            treeNode864.Name = "Node1";
            treeNode864.Text = "AnimationPause and AnimationResume methods added";
            treeNode865.Name = "Node0";
            treeNode865.Text = "LDShapes";
            treeNode866.Name = "Node1";
            treeNode866.Text = "Process list indexed by ID rather than name";
            treeNode867.Name = "Node0";
            treeNode867.Text = "LDProcess";
            treeNode868.Name = "Node1";
            treeNode868.Text = "Version 1.0.0.17";
            treeNode869.Name = "Node1";
            treeNode869.Text = "More effects added";
            treeNode870.Name = "Node0";
            treeNode870.Text = "LDWebCam";
            treeNode871.Name = "Node1";
            treeNode871.Text = "Add or change an image on a button or image shape";
            treeNode872.Name = "Node1";
            treeNode872.Text = "Add an animated gif or tiled image";
            treeNode873.Name = "Node0";
            treeNode873.Text = "LDShapes";
            treeNode874.Name = "Node0";
            treeNode874.Text = "Version 1.0.0.16";
            treeNode875.Name = "Node1";
            treeNode875.Text = "A webcam object for the GraphicsWindow, including a picture taking function";
            treeNode876.Name = "Node0";
            treeNode876.Text = "LDWebCam";
            treeNode877.Name = "Node0";
            treeNode877.Text = "Version 1.0.0.15";
            treeNode878.Name = "Node2";
            treeNode878.Text = "Variables may be changed during a debug session";
            treeNode879.Name = "Node1";
            treeNode879.Text = "LDDebug";
            treeNode880.Name = "Node0";
            treeNode880.Text = "Version 1.0.0.14";
            treeNode881.Name = "Node1";
            treeNode881.Text = "A basic debugging tool";
            treeNode882.Name = "Node0";
            treeNode882.Text = "LDDebug";
            treeNode883.Name = "Node0";
            treeNode883.Text = "Version 1.0.0.13";
            treeNode884.Name = "Node2";
            treeNode884.Text = "Methods to convert between HSL and RGB";
            treeNode885.Name = "Node18";
            treeNode885.Text = "Method to set colour opacity";
            treeNode886.Name = "Node19";
            treeNode886.Text = "Methods to get R, G, B and H, S, L for a colour";
            treeNode887.Name = "Node1";
            treeNode887.Text = "LDColours";
            treeNode888.Name = "Node4";
            treeNode888.Text = "Methods to add and subtract dates and times";
            treeNode889.Name = "Node3";
            treeNode889.Text = "LDDateTime";
            treeNode890.Name = "Node6";
            treeNode890.Text = "Waiting overlay, Calendar and About popups";
            treeNode891.Name = "Node17";
            treeNode891.Text = "Tooltips";
            treeNode892.Name = "Node5";
            treeNode892.Text = "LDDialogs";
            treeNode893.Name = "Node8";
            treeNode893.Text = "File change event";
            treeNode894.Name = "Node7";
            treeNode894.Text = "LDEvents";
            treeNode895.Name = "Node0";
            treeNode895.Text = "Version 1.0.0.12";
            treeNode896.Name = "Node12";
            treeNode896.Text = "Methods to sort arrays by index or value";
            treeNode897.Name = "Node22";
            treeNode897.Text = "Sorting by number and character strings";
            treeNode898.Name = "Node11";
            treeNode898.Text = "LDSort";
            treeNode899.Name = "Node14";
            treeNode899.Text = "Statistics on any array and distribution generation";
            treeNode900.Name = "Node20";
            treeNode900.Text = "Includes integration and differentiation to convert between PDF and CDF";
            treeNode901.Name = "Node21";
            treeNode901.Text = "Normal, Binomial, Traingular and Uniform distributions";
            treeNode902.Name = "Node13";
            treeNode902.Text = "LDStatistics";
            treeNode903.Name = "Node16";
            treeNode903.Text = "Voice and volume added";
            treeNode904.Name = "Node15";
            treeNode904.Text = "LDSpeech";
            treeNode905.Name = "Node9";
            treeNode905.Text = "Version 1.0.0.11";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode25,
            treeNode40,
            treeNode55,
            treeNode68,
            treeNode77,
            treeNode92,
            treeNode103,
            treeNode117,
            treeNode126,
            treeNode138,
            treeNode149,
            treeNode152,
            treeNode161,
            treeNode168,
            treeNode175,
            treeNode188,
            treeNode199,
            treeNode204,
            treeNode211,
            treeNode214,
            treeNode228,
            treeNode236,
            treeNode242,
            treeNode257,
            treeNode272,
            treeNode278,
            treeNode286,
            treeNode301,
            treeNode318,
            treeNode321,
            treeNode327,
            treeNode333,
            treeNode343,
            treeNode352,
            treeNode355,
            treeNode375,
            treeNode381,
            treeNode384,
            treeNode393,
            treeNode401,
            treeNode407,
            treeNode412,
            treeNode418,
            treeNode421,
            treeNode434,
            treeNode437,
            treeNode442,
            treeNode447,
            treeNode450,
            treeNode456,
            treeNode460,
            treeNode463,
            treeNode469,
            treeNode473,
            treeNode481,
            treeNode487,
            treeNode493,
            treeNode496,
            treeNode503,
            treeNode510,
            treeNode518,
            treeNode521,
            treeNode524,
            treeNode530,
            treeNode535,
            treeNode542,
            treeNode547,
            treeNode553,
            treeNode556,
            treeNode563,
            treeNode568,
            treeNode572,
            treeNode585,
            treeNode593,
            treeNode598,
            treeNode604,
            treeNode607,
            treeNode614,
            treeNode617,
            treeNode625,
            treeNode628,
            treeNode631,
            treeNode635,
            treeNode639,
            treeNode642,
            treeNode645,
            treeNode648,
            treeNode651,
            treeNode654,
            treeNode657,
            treeNode660,
            treeNode664,
            treeNode667,
            treeNode670,
            treeNode673,
            treeNode681,
            treeNode683,
            treeNode689,
            treeNode695,
            treeNode700,
            treeNode705,
            treeNode708,
            treeNode711,
            treeNode714,
            treeNode717,
            treeNode723,
            treeNode726,
            treeNode729,
            treeNode732,
            treeNode741,
            treeNode744,
            treeNode747,
            treeNode751,
            treeNode760,
            treeNode766,
            treeNode771,
            treeNode780,
            treeNode783,
            treeNode786,
            treeNode791,
            treeNode796,
            treeNode799,
            treeNode802,
            treeNode805,
            treeNode812,
            treeNode817,
            treeNode822,
            treeNode829,
            treeNode832,
            treeNode840,
            treeNode845,
            treeNode848,
            treeNode851,
            treeNode854,
            treeNode857,
            treeNode863,
            treeNode868,
            treeNode874,
            treeNode877,
            treeNode880,
            treeNode883,
            treeNode895,
            treeNode905});
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