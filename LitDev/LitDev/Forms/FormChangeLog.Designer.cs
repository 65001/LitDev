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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Read method extended to read unindexed lines to 1D array");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("LDFastArray", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Version 1.2.15.0", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Possible unclosed zip conflicts fixed");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("LDZip", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("LDStopwatch object added to accurately measure time intervals");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("LDStopwatch", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("LDTimer object added for additional timers");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("LDTimer", new System.Windows.Forms.TreeNode[] {
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Speedup of selected critical performance code listed below");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("1) LDShapes.FastMove");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("2) LDPhysics graphical updates");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("3) LDImage and LDwebCam image processing");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("4) LDFastShapes");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("5) LDGraphicsWindow.PauseUpdates and LDGraphicsWindow.ResumeUpdates");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("6) Selected LD3DView visual updates");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("7) LDEffect");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("8) LDGraph");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("9) LDShapes animated gifs and Overlap methods");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("A new 1D, 2D and 3D and higher dimension array with fast access and variable dime" +
        "nsioning");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("CSV file read and write");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("LDFastArray", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("DataViewColAlignment method added");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("DataViewSaveAsCSV and DataViewReadFromCSV fixed to work with CSVDeliminator");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("RichTextBoxTextTyped event added");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("RichTextBoxIndentToTab property added");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27});
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("OverlapDetail property added");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Version 1.2.14.0", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode7,
            treeNode9,
            treeNode20,
            treeNode23,
            treeNode28,
            treeNode30});
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("TEMP tables allowed for SQLite databases");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode32});
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Convert2Cartesian fixed to be Culture Invariant.");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode34});
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("NormalMap method added for normal map 3D effects");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("HeightMap2NormalMap method to create a normal map from a height map");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("MakeTransparent method added");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("ReplaceColour method added");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("To32bitARGB method added (code suggested by Pappa Lapub)");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode36,
            treeNode37,
            treeNode38,
            treeNode39,
            treeNode40});
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("All image pixel manipulations speeded up");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("More Culture Invariace fixes");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode42,
            treeNode43});
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Version 1.2.13.0", new System.Windows.Forms.TreeNode[] {
            treeNode33,
            treeNode35,
            treeNode41,
            treeNode44});
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Base conversions extended to include bases up to 36");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode46});
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Updated to new Bing API");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("LDSearch", new System.Windows.Forms.TreeNode[] {
            treeNode48});
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("ShowInTaskbar property added");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode50});
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("ReadCSV and WriteCSV modified to handle \"");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode52});
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("ToArray and FromArray methods added");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode54});
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("Version 1.2.12.0", new System.Windows.Forms.TreeNode[] {
            treeNode47,
            treeNode49,
            treeNode51,
            treeNode53,
            treeNode55});
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("DataViewColumnWidths method added");
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("DataViewRowColours method added");
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode57,
            treeNode58});
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("Various obscure or experimental methods made visible to intelliseense. (LD3DView," +
        " LDBlueTooth, LDScrolBars, LDShapes)");
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode60});
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("SetCentre method added");
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("A 3rd rotation added");
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("BoundingBox method added");
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode62,
            treeNode63,
            treeNode64});
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("Reverted to earlier MySQL version to handle old password encryption");
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode66});
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("PlayMusic2 method added");
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("Channel parameter added");
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode68,
            treeNode69});
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("Version 1.2.11.0", new System.Windows.Forms.TreeNode[] {
            treeNode59,
            treeNode61,
            treeNode65,
            treeNode67,
            treeNode70});
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("SetButtonStyle method added");
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode72});
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("Additional geometries added (Cube, Cone, Arrow, Revolute and Rectangle)");
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("SetBillBoard method added");
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("GetCameraUpDirection method added");
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("Gradient brushes can be used");
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("AutoControl method added");
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("SpecularExponent property added");
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode74,
            treeNode75,
            treeNode76,
            treeNode77,
            treeNode78,
            treeNode79});
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("AddText method to annotate an image with text added");
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode81});
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("BrushText for text on a brush added");
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("Skew shapes method added");
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode83,
            treeNode84});
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("Version 1.2.10.0", new System.Windows.Forms.TreeNode[] {
            treeNode73,
            treeNode80,
            treeNode82,
            treeNode85});
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("A general purpose unit system, see LDUnits.sb sample");
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("LDUnits", new System.Windows.Forms.TreeNode[] {
            treeNode87});
            System.Windows.Forms.TreeNode treeNode89 = new System.Windows.Forms.TreeNode("Possible issue with FixSigFig fixed");
            System.Windows.Forms.TreeNode treeNode90 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode89});
            System.Windows.Forms.TreeNode treeNode91 = new System.Windows.Forms.TreeNode("GetIndex method added (for SB arrays)");
            System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode91});
            System.Windows.Forms.TreeNode treeNode93 = new System.Windows.Forms.TreeNode("Resize mode property added");
            System.Windows.Forms.TreeNode treeNode94 = new System.Windows.Forms.TreeNode("Icon sets SB icon if property set to \"SB\"");
            System.Windows.Forms.TreeNode treeNode95 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode93,
            treeNode94});
            System.Windows.Forms.TreeNode treeNode96 = new System.Windows.Forms.TreeNode("Possible threading error with DataViewSetRow and DataViewSetValue fixed");
            System.Windows.Forms.TreeNode treeNode97 = new System.Windows.Forms.TreeNode("DataViewAllowUserEntry method added");
            System.Windows.Forms.TreeNode treeNode98 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode96,
            treeNode97});
            System.Windows.Forms.TreeNode treeNode99 = new System.Windows.Forms.TreeNode("Version 1.2.9.0", new System.Windows.Forms.TreeNode[] {
            treeNode88,
            treeNode90,
            treeNode92,
            treeNode95,
            treeNode98});
            System.Windows.Forms.TreeNode treeNode100 = new System.Windows.Forms.TreeNode("New extended math object, starting with FFT");
            System.Windows.Forms.TreeNode treeNode101 = new System.Windows.Forms.TreeNode("LDMathX", new System.Windows.Forms.TreeNode[] {
            treeNode100});
            System.Windows.Forms.TreeNode treeNode102 = new System.Windows.Forms.TreeNode("AddListBox and ListBoxContent can accept LDList and LDArray data");
            System.Windows.Forms.TreeNode treeNode103 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode102});
            System.Windows.Forms.TreeNode treeNode104 = new System.Windows.Forms.TreeNode("CreateFromIndices and CreateFromValues methods added");
            System.Windows.Forms.TreeNode treeNode105 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode104});
            System.Windows.Forms.TreeNode treeNode106 = new System.Windows.Forms.TreeNode("CreateFromIndices and CreateFromValues methods added");
            System.Windows.Forms.TreeNode treeNode107 = new System.Windows.Forms.TreeNode("LDList", new System.Windows.Forms.TreeNode[] {
            treeNode106});
            System.Windows.Forms.TreeNode treeNode108 = new System.Windows.Forms.TreeNode("Version 1.2.8.0", new System.Windows.Forms.TreeNode[] {
            treeNode101,
            treeNode103,
            treeNode105,
            treeNode107});
            System.Windows.Forms.TreeNode treeNode109 = new System.Windows.Forms.TreeNode("Error handling, additional settings and multiple ports supported");
            System.Windows.Forms.TreeNode treeNode110 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode109});
            System.Windows.Forms.TreeNode treeNode111 = new System.Windows.Forms.TreeNode("Posterise, Hue, Saturation and Lightness effects added");
            System.Windows.Forms.TreeNode treeNode112 = new System.Windows.Forms.TreeNode("More image effects, OilPaint, Charcoal, Sketch, Cartoon, Edge, Accent, Sepia, Noi" +
        "seRemoval and Solarise added");
            System.Windows.Forms.TreeNode treeNode113 = new System.Windows.Forms.TreeNode("LDImage and LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode111,
            treeNode112});
            System.Windows.Forms.TreeNode treeNode114 = new System.Windows.Forms.TreeNode("Bitwise operations object added");
            System.Windows.Forms.TreeNode treeNode115 = new System.Windows.Forms.TreeNode("LDBits", new System.Windows.Forms.TreeNode[] {
            treeNode114});
            System.Windows.Forms.TreeNode treeNode116 = new System.Windows.Forms.TreeNode("Extended text encoding property added");
            System.Windows.Forms.TreeNode treeNode117 = new System.Windows.Forms.TreeNode("TextWindow colours can be changed");
            System.Windows.Forms.TreeNode treeNode118 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode116,
            treeNode117});
            System.Windows.Forms.TreeNode treeNode119 = new System.Windows.Forms.TreeNode("GetWorkingImagePixelARGB method added");
            System.Windows.Forms.TreeNode treeNode120 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode119});
            System.Windows.Forms.TreeNode treeNode121 = new System.Windows.Forms.TreeNode("RasteriseTurtleLines method added");
            System.Windows.Forms.TreeNode treeNode122 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode121});
            System.Windows.Forms.TreeNode treeNode123 = new System.Windows.Forms.TreeNode("Version 1.2.7.0", new System.Windows.Forms.TreeNode[] {
            treeNode110,
            treeNode113,
            treeNode115,
            treeNode118,
            treeNode120,
            treeNode122});
            System.Windows.Forms.TreeNode treeNode124 = new System.Windows.Forms.TreeNode("Confirm dialog is given focus above GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode125 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode124});
            System.Windows.Forms.TreeNode treeNode126 = new System.Windows.Forms.TreeNode("Read and write json model scripts compatible with R.U.B.E.");
            System.Windows.Forms.TreeNode treeNode127 = new System.Windows.Forms.TreeNode("ToggleSensor added");
            System.Windows.Forms.TreeNode treeNode128 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode126,
            treeNode127});
            System.Windows.Forms.TreeNode treeNode129 = new System.Windows.Forms.TreeNode("Allow multiple copies of the webcam image");
            System.Windows.Forms.TreeNode treeNode130 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode129});
            System.Windows.Forms.TreeNode treeNode131 = new System.Windows.Forms.TreeNode("Fast pixel level image manipulation using a temporary working image added");
            System.Windows.Forms.TreeNode treeNode132 = new System.Windows.Forms.TreeNode("MetaData method added");
            System.Windows.Forms.TreeNode treeNode133 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode131,
            treeNode132});
            System.Windows.Forms.TreeNode treeNode134 = new System.Windows.Forms.TreeNode("Version 1.2.6.0", new System.Windows.Forms.TreeNode[] {
            treeNode125,
            treeNode128,
            treeNode130,
            treeNode133});
            System.Windows.Forms.TreeNode treeNode135 = new System.Windows.Forms.TreeNode("FixSigFig and FixDecimal methods added");
            System.Windows.Forms.TreeNode treeNode136 = new System.Windows.Forms.TreeNode("MinNumber and MaxNumber properties added");
            System.Windows.Forms.TreeNode treeNode137 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode135,
            treeNode136});
            System.Windows.Forms.TreeNode treeNode138 = new System.Windows.Forms.TreeNode("SliderMaximum property added");
            System.Windows.Forms.TreeNode treeNode139 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode138});
            System.Windows.Forms.TreeNode treeNode140 = new System.Windows.Forms.TreeNode("ZoomAll method added");
            System.Windows.Forms.TreeNode treeNode141 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode140});
            System.Windows.Forms.TreeNode treeNode142 = new System.Windows.Forms.TreeNode("Reposition methods and properties added");
            System.Windows.Forms.TreeNode treeNode143 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode142});
            System.Windows.Forms.TreeNode treeNode144 = new System.Windows.Forms.TreeNode("GetImagePixels and SetImagePixels methods added");
            System.Windows.Forms.TreeNode treeNode145 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode144});
            System.Windows.Forms.TreeNode treeNode146 = new System.Windows.Forms.TreeNode("MouseScroll parameter added");
            System.Windows.Forms.TreeNode treeNode147 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode146});
            System.Windows.Forms.TreeNode treeNode148 = new System.Windows.Forms.TreeNode("Version 1.2.5.0", new System.Windows.Forms.TreeNode[] {
            treeNode137,
            treeNode139,
            treeNode141,
            treeNode143,
            treeNode145,
            treeNode147});
            System.Windows.Forms.TreeNode treeNode149 = new System.Windows.Forms.TreeNode("New object added (previously a separate extension)");
            System.Windows.Forms.TreeNode treeNode150 = new System.Windows.Forms.TreeNode("Async, Loop, Volume and Pan properties added");
            System.Windows.Forms.TreeNode treeNode151 = new System.Windows.Forms.TreeNode("PlayWave, PlayHarmonics and PlayWavFile methods added");
            System.Windows.Forms.TreeNode treeNode152 = new System.Windows.Forms.TreeNode("LDWaveForm", new System.Windows.Forms.TreeNode[] {
            treeNode149,
            treeNode150,
            treeNode151});
            System.Windows.Forms.TreeNode treeNode153 = new System.Windows.Forms.TreeNode("New object added to get input from gamepads or joysticks");
            System.Windows.Forms.TreeNode treeNode154 = new System.Windows.Forms.TreeNode("LDController", new System.Windows.Forms.TreeNode[] {
            treeNode153});
            System.Windows.Forms.TreeNode treeNode155 = new System.Windows.Forms.TreeNode("RayCast method added");
            System.Windows.Forms.TreeNode treeNode156 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode155});
            System.Windows.Forms.TreeNode treeNode157 = new System.Windows.Forms.TreeNode("Version 1.2.4.0", new System.Windows.Forms.TreeNode[] {
            treeNode152,
            treeNode154,
            treeNode156});
            System.Windows.Forms.TreeNode treeNode158 = new System.Windows.Forms.TreeNode("New object to apply effects to any shape or control");
            System.Windows.Forms.TreeNode treeNode159 = new System.Windows.Forms.TreeNode("LDEffects", new System.Windows.Forms.TreeNode[] {
            treeNode158});
            System.Windows.Forms.TreeNode treeNode160 = new System.Windows.Forms.TreeNode("New object to add arrow, arc, polygons and callout shapes");
            System.Windows.Forms.TreeNode treeNode161 = new System.Windows.Forms.TreeNode("LDFigures", new System.Windows.Forms.TreeNode[] {
            treeNode160});
            System.Windows.Forms.TreeNode treeNode162 = new System.Windows.Forms.TreeNode("SetGroup method added");
            System.Windows.Forms.TreeNode treeNode163 = new System.Windows.Forms.TreeNode("GetContacts method added");
            System.Windows.Forms.TreeNode treeNode164 = new System.Windows.Forms.TreeNode("GetAllShapesAt method added");
            System.Windows.Forms.TreeNode treeNode165 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode162,
            treeNode163,
            treeNode164});
            System.Windows.Forms.TreeNode treeNode166 = new System.Windows.Forms.TreeNode("SetImage handles images with transparency");
            System.Windows.Forms.TreeNode treeNode167 = new System.Windows.Forms.TreeNode("ImageTransparency property added to switch how image transparencies are handled");
            System.Windows.Forms.TreeNode treeNode168 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode166,
            treeNode167});
            System.Windows.Forms.TreeNode treeNode169 = new System.Windows.Forms.TreeNode("Version 1.2.3.0", new System.Windows.Forms.TreeNode[] {
            treeNode159,
            treeNode161,
            treeNode165,
            treeNode168});
            System.Windows.Forms.TreeNode treeNode170 = new System.Windows.Forms.TreeNode("BrushGradient can use \"R\" for radial orientation");
            System.Windows.Forms.TreeNode treeNode171 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode170});
            System.Windows.Forms.TreeNode treeNode172 = new System.Windows.Forms.TreeNode("Unnecessary file existance checks removed from GetFolder, GetFile and GetExtensio" +
        "n");
            System.Windows.Forms.TreeNode treeNode173 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode172});
            System.Windows.Forms.TreeNode treeNode174 = new System.Windows.Forms.TreeNode("NewImage method added");
            System.Windows.Forms.TreeNode treeNode175 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode174});
            System.Windows.Forms.TreeNode treeNode176 = new System.Windows.Forms.TreeNode("SetStartupPosition method added to position dialogs");
            System.Windows.Forms.TreeNode treeNode177 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode176});
            System.Windows.Forms.TreeNode treeNode178 = new System.Windows.Forms.TreeNode("AddSeriesHitogram renamed AddSeriesHistogram");
            System.Windows.Forms.TreeNode treeNode179 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode178});
            System.Windows.Forms.TreeNode treeNode180 = new System.Windows.Forms.TreeNode("Version 1.2.2.0", new System.Windows.Forms.TreeNode[] {
            treeNode171,
            treeNode173,
            treeNode175,
            treeNode177,
            treeNode179});
            System.Windows.Forms.TreeNode treeNode181 = new System.Windows.Forms.TreeNode("Recompiled for Small Basic version 1.2");
            System.Windows.Forms.TreeNode treeNode182 = new System.Windows.Forms.TreeNode("Version 1.2", new System.Windows.Forms.TreeNode[] {
            treeNode181});
            System.Windows.Forms.TreeNode treeNode183 = new System.Windows.Forms.TreeNode("Version 1.2.0.1", new System.Windows.Forms.TreeNode[] {
            treeNode182});
            System.Windows.Forms.TreeNode treeNode184 = new System.Windows.Forms.TreeNode("OpenFile and SaveFile may take an array of extensions");
            System.Windows.Forms.TreeNode treeNode185 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode184});
            System.Windows.Forms.TreeNode treeNode186 = new System.Windows.Forms.TreeNode("Logical operations object added");
            System.Windows.Forms.TreeNode treeNode187 = new System.Windows.Forms.TreeNode("LDLogic", new System.Windows.Forms.TreeNode[] {
            treeNode186});
            System.Windows.Forms.TreeNode treeNode188 = new System.Windows.Forms.TreeNode("CurrentCulture property added");
            System.Windows.Forms.TreeNode treeNode189 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode188});
            System.Windows.Forms.TreeNode treeNode190 = new System.Windows.Forms.TreeNode("Evaluate3, a method to evaluate to a boolean added");
            System.Windows.Forms.TreeNode treeNode191 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode190});
            System.Windows.Forms.TreeNode treeNode192 = new System.Windows.Forms.TreeNode("Version 1.1.0.8", new System.Windows.Forms.TreeNode[] {
            treeNode185,
            treeNode187,
            treeNode189,
            treeNode191});
            System.Windows.Forms.TreeNode treeNode193 = new System.Windows.Forms.TreeNode("Scrolling to selected nodes improved for dataview with custom column type (e.g.co" +
        "mbobox)");
            System.Windows.Forms.TreeNode treeNode194 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode193});
            System.Windows.Forms.TreeNode treeNode195 = new System.Windows.Forms.TreeNode("Methods added to add and remove nodes and save xml file");
            System.Windows.Forms.TreeNode treeNode196 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode195});
            System.Windows.Forms.TreeNode treeNode197 = new System.Windows.Forms.TreeNode("MusicPlayTime moved from LDFile");
            System.Windows.Forms.TreeNode treeNode198 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode197});
            System.Windows.Forms.TreeNode treeNode199 = new System.Windows.Forms.TreeNode("Version 1.1.0.7", new System.Windows.Forms.TreeNode[] {
            treeNode194,
            treeNode196,
            treeNode198});
            System.Windows.Forms.TreeNode treeNode200 = new System.Windows.Forms.TreeNode("SplitImage method added");
            System.Windows.Forms.TreeNode treeNode201 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode200});
            System.Windows.Forms.TreeNode treeNode202 = new System.Windows.Forms.TreeNode("EditTable and SaveTable methods added");
            System.Windows.Forms.TreeNode treeNode203 = new System.Windows.Forms.TreeNode("LDDatabse", new System.Windows.Forms.TreeNode[] {
            treeNode202});
            System.Windows.Forms.TreeNode treeNode204 = new System.Windows.Forms.TreeNode("DataView control and methods added");
            System.Windows.Forms.TreeNode treeNode205 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode204});
            System.Windows.Forms.TreeNode treeNode206 = new System.Windows.Forms.TreeNode("Version 1.1.0.6", new System.Windows.Forms.TreeNode[] {
            treeNode201,
            treeNode203,
            treeNode205});
            System.Windows.Forms.TreeNode treeNode207 = new System.Windows.Forms.TreeNode("Exists modified to check for directory as well as file");
            System.Windows.Forms.TreeNode treeNode208 = new System.Windows.Forms.TreeNode("GetAllDirectories modified to omit directories without sufficient permissions");
            System.Windows.Forms.TreeNode treeNode209 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode207,
            treeNode208});
            System.Windows.Forms.TreeNode treeNode210 = new System.Windows.Forms.TreeNode("Instrumenting - Index was outside the bounds of the array - bug fixed");
            System.Windows.Forms.TreeNode treeNode211 = new System.Windows.Forms.TreeNode("Bug fixed returning to Small Basic IDE if application ends before debug window is" +
        " closed");
            System.Windows.Forms.TreeNode treeNode212 = new System.Windows.Forms.TreeNode("Conditonal break point added");
            System.Windows.Forms.TreeNode treeNode213 = new System.Windows.Forms.TreeNode("Step over button added");
            System.Windows.Forms.TreeNode treeNode214 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode210,
            treeNode211,
            treeNode212,
            treeNode213});
            System.Windows.Forms.TreeNode treeNode215 = new System.Windows.Forms.TreeNode("ExitOnClose works with LDWindows (multiple windows)");
            System.Windows.Forms.TreeNode treeNode216 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode215});
            System.Windows.Forms.TreeNode treeNode217 = new System.Windows.Forms.TreeNode("Object added to save image, sound, file and text/varables to a resources file");
            System.Windows.Forms.TreeNode treeNode218 = new System.Windows.Forms.TreeNode("LDResources", new System.Windows.Forms.TreeNode[] {
            treeNode217});
            System.Windows.Forms.TreeNode treeNode219 = new System.Windows.Forms.TreeNode("Version 1.1.0.5", new System.Windows.Forms.TreeNode[] {
            treeNode209,
            treeNode214,
            treeNode216,
            treeNode218});
            System.Windows.Forms.TreeNode treeNode220 = new System.Windows.Forms.TreeNode("ClipboardChanged event added");
            System.Windows.Forms.TreeNode treeNode221 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode220});
            System.Windows.Forms.TreeNode treeNode222 = new System.Windows.Forms.TreeNode("RenameFile, RenameDirctory, CopyDirectory and GetAllDirectories methods added");
            System.Windows.Forms.TreeNode treeNode223 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode222});
            System.Windows.Forms.TreeNode treeNode224 = new System.Windows.Forms.TreeNode("SetActive method added");
            System.Windows.Forms.TreeNode treeNode225 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode224});
            System.Windows.Forms.TreeNode treeNode226 = new System.Windows.Forms.TreeNode("Parse xml file nodes");
            System.Windows.Forms.TreeNode treeNode227 = new System.Windows.Forms.TreeNode("LDxml", new System.Windows.Forms.TreeNode[] {
            treeNode226});
            System.Windows.Forms.TreeNode treeNode228 = new System.Windows.Forms.TreeNode("\"FAILURE\" replaced by \"FAILED\" as a return message for consistency");
            System.Windows.Forms.TreeNode treeNode229 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode228});
            System.Windows.Forms.TreeNode treeNode230 = new System.Windows.Forms.TreeNode("Version 1.1.0.4", new System.Windows.Forms.TreeNode[] {
            treeNode221,
            treeNode223,
            treeNode225,
            treeNode227,
            treeNode229});
            System.Windows.Forms.TreeNode treeNode231 = new System.Windows.Forms.TreeNode("WakeAll method addded");
            System.Windows.Forms.TreeNode treeNode232 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode231});
            System.Windows.Forms.TreeNode treeNode233 = new System.Windows.Forms.TreeNode("Clipboard methods added");
            System.Windows.Forms.TreeNode treeNode234 = new System.Windows.Forms.TreeNode("LDClipboard", new System.Windows.Forms.TreeNode[] {
            treeNode233});
            System.Windows.Forms.TreeNode treeNode235 = new System.Windows.Forms.TreeNode("Version 1.1.0.3", new System.Windows.Forms.TreeNode[] {
            treeNode232,
            treeNode234});
            System.Windows.Forms.TreeNode treeNode236 = new System.Windows.Forms.TreeNode("SizeNWSE cursor added");
            System.Windows.Forms.TreeNode treeNode237 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode236});
            System.Windows.Forms.TreeNode treeNode238 = new System.Windows.Forms.TreeNode("ScaleAxisX & ScaleAxisY modified for better control");
            System.Windows.Forms.TreeNode treeNode239 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode238});
            System.Windows.Forms.TreeNode treeNode240 = new System.Windows.Forms.TreeNode("SQLite updated for .Net 4.5");
            System.Windows.Forms.TreeNode treeNode241 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode240});
            System.Windows.Forms.TreeNode treeNode242 = new System.Windows.Forms.TreeNode("Version 1.1.0.2", new System.Windows.Forms.TreeNode[] {
            treeNode237,
            treeNode239,
            treeNode241});
            System.Windows.Forms.TreeNode treeNode243 = new System.Windows.Forms.TreeNode("Recompiled for Small Basic version 1.1");
            System.Windows.Forms.TreeNode treeNode244 = new System.Windows.Forms.TreeNode("Version 1.1", new System.Windows.Forms.TreeNode[] {
            treeNode243});
            System.Windows.Forms.TreeNode treeNode245 = new System.Windows.Forms.TreeNode("Version 1.1.0.1", new System.Windows.Forms.TreeNode[] {
            treeNode244});
            System.Windows.Forms.TreeNode treeNode246 = new System.Windows.Forms.TreeNode("RichTextBoxCaseSensitive parameter added");
            System.Windows.Forms.TreeNode treeNode247 = new System.Windows.Forms.TreeNode("RichTextBoxMargins method added");
            System.Windows.Forms.TreeNode treeNode248 = new System.Windows.Forms.TreeNode("ListBoxSelectionMode added for multiple list box selection");
            System.Windows.Forms.TreeNode treeNode249 = new System.Windows.Forms.TreeNode("ListBoxGetSelected and ListBoxSelect modified for multiple selection modes");
            System.Windows.Forms.TreeNode treeNode250 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode246,
            treeNode247,
            treeNode248,
            treeNode249});
            System.Windows.Forms.TreeNode treeNode251 = new System.Windows.Forms.TreeNode("Error reporting added");
            System.Windows.Forms.TreeNode treeNode252 = new System.Windows.Forms.TreeNode("SetEncoding method added");
            System.Windows.Forms.TreeNode treeNode253 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode251,
            treeNode252});
            System.Windows.Forms.TreeNode treeNode254 = new System.Windows.Forms.TreeNode("AddSeries methods replace an existing series if the label name is the same");
            System.Windows.Forms.TreeNode treeNode255 = new System.Windows.Forms.TreeNode("Export to excel fix for graph with no title");
            System.Windows.Forms.TreeNode treeNode256 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode254,
            treeNode255});
            System.Windows.Forms.TreeNode treeNode257 = new System.Windows.Forms.TreeNode("Negative restitution option when adding moving shape");
            System.Windows.Forms.TreeNode treeNode258 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode257});
            System.Windows.Forms.TreeNode treeNode259 = new System.Windows.Forms.TreeNode("Version 1.0.0.133", new System.Windows.Forms.TreeNode[] {
            treeNode250,
            treeNode253,
            treeNode256,
            treeNode258});
            System.Windows.Forms.TreeNode treeNode260 = new System.Windows.Forms.TreeNode("Internal improvements to auto messaging");
            System.Windows.Forms.TreeNode treeNode261 = new System.Windows.Forms.TreeNode("Name can be set and GetClients method added");
            System.Windows.Forms.TreeNode treeNode262 = new System.Windows.Forms.TreeNode("LDClient", new System.Windows.Forms.TreeNode[] {
            treeNode260,
            treeNode261});
            System.Windows.Forms.TreeNode treeNode263 = new System.Windows.Forms.TreeNode("RichTextBoxWord method modified to include mode parameter");
            System.Windows.Forms.TreeNode treeNode264 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode263});
            System.Windows.Forms.TreeNode treeNode265 = new System.Windows.Forms.TreeNode("Return message and possible file error fixed for Stop method");
            System.Windows.Forms.TreeNode treeNode266 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode265});
            System.Windows.Forms.TreeNode treeNode267 = new System.Windows.Forms.TreeNode("Version 1.0.0.132", new System.Windows.Forms.TreeNode[] {
            treeNode262,
            treeNode264,
            treeNode266});
            System.Windows.Forms.TreeNode treeNode268 = new System.Windows.Forms.TreeNode("Include and CallInclude methods added to use a pre-compiled file");
            System.Windows.Forms.TreeNode treeNode269 = new System.Windows.Forms.TreeNode("Compile method added to compile a Small Basic program");
            System.Windows.Forms.TreeNode treeNode270 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode268,
            treeNode269});
            System.Windows.Forms.TreeNode treeNode271 = new System.Windows.Forms.TreeNode("Methods and code by Pappa Lapub added");
            System.Windows.Forms.TreeNode treeNode272 = new System.Windows.Forms.TreeNode("LDShell", new System.Windows.Forms.TreeNode[] {
            treeNode271});
            System.Windows.Forms.TreeNode treeNode273 = new System.Windows.Forms.TreeNode("Version 1.0.0.131", new System.Windows.Forms.TreeNode[] {
            treeNode270,
            treeNode272});
            System.Windows.Forms.TreeNode treeNode274 = new System.Windows.Forms.TreeNode("FollowShapeX and FollowShapeY methods added");
            System.Windows.Forms.TreeNode treeNode275 = new System.Windows.Forms.TreeNode("BoxShape method added to keep a shape with a region of the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode276 = new System.Windows.Forms.TreeNode("Refactoring of all the pan, follow and box methods");
            System.Windows.Forms.TreeNode treeNode277 = new System.Windows.Forms.TreeNode("All input and output coordinates are in world coordinates, apart from GetShapeAt " +
        "which is in screen coordinates");
            System.Windows.Forms.TreeNode treeNode278 = new System.Windows.Forms.TreeNode("GetPan method added to convert between world and screen coordinates");
            System.Windows.Forms.TreeNode treeNode279 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode274,
            treeNode275,
            treeNode276,
            treeNode277,
            treeNode278});
            System.Windows.Forms.TreeNode treeNode280 = new System.Windows.Forms.TreeNode("UseBinary property added");
            System.Windows.Forms.TreeNode treeNode281 = new System.Windows.Forms.TreeNode("DoAsync property and associated completion events added");
            System.Windows.Forms.TreeNode treeNode282 = new System.Windows.Forms.TreeNode("Delete method added");
            System.Windows.Forms.TreeNode treeNode283 = new System.Windows.Forms.TreeNode("LDftp", new System.Windows.Forms.TreeNode[] {
            treeNode280,
            treeNode281,
            treeNode282});
            System.Windows.Forms.TreeNode treeNode284 = new System.Windows.Forms.TreeNode("CallAsync method to call any extension method asynchronously added");
            System.Windows.Forms.TreeNode treeNode285 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode284});
            System.Windows.Forms.TreeNode treeNode286 = new System.Windows.Forms.TreeNode("SetCursorToEnd also works for RichTextBox");
            System.Windows.Forms.TreeNode treeNode287 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode286});
            System.Windows.Forms.TreeNode treeNode288 = new System.Windows.Forms.TreeNode("Version 1.0.0.130", new System.Windows.Forms.TreeNode[] {
            treeNode279,
            treeNode283,
            treeNode285,
            treeNode287});
            System.Windows.Forms.TreeNode treeNode289 = new System.Windows.Forms.TreeNode("Evaluate2 method added to behave nicely with the TextWindow");
            System.Windows.Forms.TreeNode treeNode290 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode289});
            System.Windows.Forms.TreeNode treeNode291 = new System.Windows.Forms.TreeNode("SetShapeGravity method to alter gravity for individual shapes");
            System.Windows.Forms.TreeNode treeNode292 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode291});
            System.Windows.Forms.TreeNode treeNode293 = new System.Windows.Forms.TreeNode("Improve PauseUpdate and ResumeUpdates methods");
            System.Windows.Forms.TreeNode treeNode294 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode293});
            System.Windows.Forms.TreeNode treeNode295 = new System.Windows.Forms.TreeNode("FTP object methods added");
            System.Windows.Forms.TreeNode treeNode296 = new System.Windows.Forms.TreeNode("LDftp", new System.Windows.Forms.TreeNode[] {
            treeNode295});
            System.Windows.Forms.TreeNode treeNode297 = new System.Windows.Forms.TreeNode("An existing file is replaced");
            System.Windows.Forms.TreeNode treeNode298 = new System.Windows.Forms.TreeNode("LDZip", new System.Windows.Forms.TreeNode[] {
            treeNode297});
            System.Windows.Forms.TreeNode treeNode299 = new System.Windows.Forms.TreeNode("Size method added");
            System.Windows.Forms.TreeNode treeNode300 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode299});
            System.Windows.Forms.TreeNode treeNode301 = new System.Windows.Forms.TreeNode("DownloadFile method added");
            System.Windows.Forms.TreeNode treeNode302 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode301});
            System.Windows.Forms.TreeNode treeNode303 = new System.Windows.Forms.TreeNode("Version 1.0.0.129", new System.Windows.Forms.TreeNode[] {
            treeNode290,
            treeNode292,
            treeNode294,
            treeNode296,
            treeNode298,
            treeNode300,
            treeNode302});
            System.Windows.Forms.TreeNode treeNode304 = new System.Windows.Forms.TreeNode("Generalised joint connections added");
            System.Windows.Forms.TreeNode treeNode305 = new System.Windows.Forms.TreeNode("AddExplosion method added");
            System.Windows.Forms.TreeNode treeNode306 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode304,
            treeNode305});
            System.Windows.Forms.TreeNode treeNode307 = new System.Windows.Forms.TreeNode("BrushImage method added and renamed some BrushGradient commands (old methods stil" +
        "l work but depreciated)");
            System.Windows.Forms.TreeNode treeNode308 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode307});
            System.Windows.Forms.TreeNode treeNode309 = new System.Windows.Forms.TreeNode("Version 1.0.0.128", new System.Windows.Forms.TreeNode[] {
            treeNode306,
            treeNode308});
            System.Windows.Forms.TreeNode treeNode310 = new System.Windows.Forms.TreeNode("CheckServer method added");
            System.Windows.Forms.TreeNode treeNode311 = new System.Windows.Forms.TreeNode("LDClient", new System.Windows.Forms.TreeNode[] {
            treeNode310});
            System.Windows.Forms.TreeNode treeNode312 = new System.Windows.Forms.TreeNode("Default maximum number of objects (proxies) increased from 512 to 1024");
            System.Windows.Forms.TreeNode treeNode313 = new System.Windows.Forms.TreeNode("MaxPolygonVertices and MaxProxies properties added");
            System.Windows.Forms.TreeNode treeNode314 = new System.Windows.Forms.TreeNode("GetAngle method added");
            System.Windows.Forms.TreeNode treeNode315 = new System.Windows.Forms.TreeNode("Top-down tire (to model a car from above) methods added");
            System.Windows.Forms.TreeNode treeNode316 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode312,
            treeNode313,
            treeNode314,
            treeNode315});
            System.Windows.Forms.TreeNode treeNode317 = new System.Windows.Forms.TreeNode("Version 1.0.0.127", new System.Windows.Forms.TreeNode[] {
            treeNode311,
            treeNode316});
            System.Windows.Forms.TreeNode treeNode318 = new System.Windows.Forms.TreeNode("Bug fixes for Overlap methods");
            System.Windows.Forms.TreeNode treeNode319 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode318});
            System.Windows.Forms.TreeNode treeNode320 = new System.Windows.Forms.TreeNode("Bug fix for multiple numeric sorts");
            System.Windows.Forms.TreeNode treeNode321 = new System.Windows.Forms.TreeNode("ByValueWithIndex method added");
            System.Windows.Forms.TreeNode treeNode322 = new System.Windows.Forms.TreeNode("LDSort", new System.Windows.Forms.TreeNode[] {
            treeNode320,
            treeNode321});
            System.Windows.Forms.TreeNode treeNode323 = new System.Windows.Forms.TreeNode("LAN method added to get local IP addresses");
            System.Windows.Forms.TreeNode treeNode324 = new System.Windows.Forms.TreeNode("Ping method added");
            System.Windows.Forms.TreeNode treeNode325 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode323,
            treeNode324});
            System.Windows.Forms.TreeNode treeNode326 = new System.Windows.Forms.TreeNode("LoadSVG method added");
            System.Windows.Forms.TreeNode treeNode327 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode326});
            System.Windows.Forms.TreeNode treeNode328 = new System.Windows.Forms.TreeNode("Evaluate method added");
            System.Windows.Forms.TreeNode treeNode329 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode328});
            System.Windows.Forms.TreeNode treeNode330 = new System.Windows.Forms.TreeNode("IncludeJScript method added");
            System.Windows.Forms.TreeNode treeNode331 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode330});
            System.Windows.Forms.TreeNode treeNode332 = new System.Windows.Forms.TreeNode("Version 1.0.0.126", new System.Windows.Forms.TreeNode[] {
            treeNode319,
            treeNode322,
            treeNode325,
            treeNode327,
            treeNode329,
            treeNode331});
            System.Windows.Forms.TreeNode treeNode333 = new System.Windows.Forms.TreeNode("Special emphasis on async consistency");
            System.Windows.Forms.TreeNode treeNode334 = new System.Windows.Forms.TreeNode("Simplified auto method for multi-player game data transfer");
            System.Windows.Forms.TreeNode treeNode335 = new System.Windows.Forms.TreeNode("LDServer and LDClient objects added", new System.Windows.Forms.TreeNode[] {
            treeNode333,
            treeNode334});
            System.Windows.Forms.TreeNode treeNode336 = new System.Windows.Forms.TreeNode("GetWidth and GetHeight methods added");
            System.Windows.Forms.TreeNode treeNode337 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode336});
            System.Windows.Forms.TreeNode treeNode338 = new System.Windows.Forms.TreeNode("Bing web search");
            System.Windows.Forms.TreeNode treeNode339 = new System.Windows.Forms.TreeNode("LDSearch", new System.Windows.Forms.TreeNode[] {
            treeNode338});
            System.Windows.Forms.TreeNode treeNode340 = new System.Windows.Forms.TreeNode("KeyDown event handled correctly for arrow keys with hidden scrollbars");
            System.Windows.Forms.TreeNode treeNode341 = new System.Windows.Forms.TreeNode("KeyScroll property added");
            System.Windows.Forms.TreeNode treeNode342 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode340,
            treeNode341});
            System.Windows.Forms.TreeNode treeNode343 = new System.Windows.Forms.TreeNode("GetLeft and GetTop methods (work while shape is animating)");
            System.Windows.Forms.TreeNode treeNode344 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode343});
            System.Windows.Forms.TreeNode treeNode345 = new System.Windows.Forms.TreeNode("SaveAs method bug fixed");
            System.Windows.Forms.TreeNode treeNode346 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode345});
            System.Windows.Forms.TreeNode treeNode347 = new System.Windows.Forms.TreeNode("Made thread-safe since often used to queue asynchronous events");
            System.Windows.Forms.TreeNode treeNode348 = new System.Windows.Forms.TreeNode("LDQueue", new System.Windows.Forms.TreeNode[] {
            treeNode347});
            System.Windows.Forms.TreeNode treeNode349 = new System.Windows.Forms.TreeNode("Version 1.0.0.125", new System.Windows.Forms.TreeNode[] {
            treeNode335,
            treeNode337,
            treeNode339,
            treeNode342,
            treeNode344,
            treeNode346,
            treeNode348});
            System.Windows.Forms.TreeNode treeNode350 = new System.Windows.Forms.TreeNode("Language translation object added");
            System.Windows.Forms.TreeNode treeNode351 = new System.Windows.Forms.TreeNode("LDTranslate", new System.Windows.Forms.TreeNode[] {
            treeNode350});
            System.Windows.Forms.TreeNode treeNode352 = new System.Windows.Forms.TreeNode("Version 1.0.0.124", new System.Windows.Forms.TreeNode[] {
            treeNode351});
            System.Windows.Forms.TreeNode treeNode353 = new System.Windows.Forms.TreeNode("Mouse screen coordinate conversion parameters added");
            System.Windows.Forms.TreeNode treeNode354 = new System.Windows.Forms.TreeNode("MouseX and MouseY added to set cursor in GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode355 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode353,
            treeNode354});
            System.Windows.Forms.TreeNode treeNode356 = new System.Windows.Forms.TreeNode("DPIX and DPIY properties added for screen resolution");
            System.Windows.Forms.TreeNode treeNode357 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode356});
            System.Windows.Forms.TreeNode treeNode358 = new System.Windows.Forms.TreeNode("Version 1.0.0.123", new System.Windows.Forms.TreeNode[] {
            treeNode355,
            treeNode357});
            System.Windows.Forms.TreeNode treeNode359 = new System.Windows.Forms.TreeNode("ColorMatrix method added");
            System.Windows.Forms.TreeNode treeNode360 = new System.Windows.Forms.TreeNode("Rotate method added");
            System.Windows.Forms.TreeNode treeNode361 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode359,
            treeNode360});
            System.Windows.Forms.TreeNode treeNode362 = new System.Windows.Forms.TreeNode("Customisable Pie, Doughnut, Bubble, Bar and Column chart control object added");
            System.Windows.Forms.TreeNode treeNode363 = new System.Windows.Forms.TreeNode("LDChart", new System.Windows.Forms.TreeNode[] {
            treeNode362});
            System.Windows.Forms.TreeNode treeNode364 = new System.Windows.Forms.TreeNode("Version 1.0.0.122", new System.Windows.Forms.TreeNode[] {
            treeNode361,
            treeNode363});
            System.Windows.Forms.TreeNode treeNode365 = new System.Windows.Forms.TreeNode("EffectGamma added to darken and lighten");
            System.Windows.Forms.TreeNode treeNode366 = new System.Windows.Forms.TreeNode("EffectFishEye, EffectBulge and EffectSwirl added");
            System.Windows.Forms.TreeNode treeNode367 = new System.Windows.Forms.TreeNode("EffectContrast modified");
            System.Windows.Forms.TreeNode treeNode368 = new System.Windows.Forms.TreeNode("GetEffects and EffectDefaults methods added to get list of effects and default pa" +
        "rameters");
            System.Windows.Forms.TreeNode treeNode369 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode365,
            treeNode366,
            treeNode367,
            treeNode368});
            System.Windows.Forms.TreeNode treeNode370 = new System.Windows.Forms.TreeNode("Error event added for all extension exceptions");
            System.Windows.Forms.TreeNode treeNode371 = new System.Windows.Forms.TreeNode("LDEvents", new System.Windows.Forms.TreeNode[] {
            treeNode370});
            System.Windows.Forms.TreeNode treeNode372 = new System.Windows.Forms.TreeNode("Hyperbolic trigonometric functions Sinh, Cosh and Tanh added");
            System.Windows.Forms.TreeNode treeNode373 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode372});
            System.Windows.Forms.TreeNode treeNode374 = new System.Windows.Forms.TreeNode("Version 1.0.0.121", new System.Windows.Forms.TreeNode[] {
            treeNode369,
            treeNode371,
            treeNode373});
            System.Windows.Forms.TreeNode treeNode375 = new System.Windows.Forms.TreeNode("FloodFill transparency effect fixed");
            System.Windows.Forms.TreeNode treeNode376 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode375});
            System.Windows.Forms.TreeNode treeNode377 = new System.Windows.Forms.TreeNode("SaveAllVariables and LoadAllVariables methods added");
            System.Windows.Forms.TreeNode treeNode378 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode377});
            System.Windows.Forms.TreeNode treeNode379 = new System.Windows.Forms.TreeNode("EffectPixelate added");
            System.Windows.Forms.TreeNode treeNode380 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode379});
            System.Windows.Forms.TreeNode treeNode381 = new System.Windows.Forms.TreeNode("Modified to work with Windows 8");
            System.Windows.Forms.TreeNode treeNode382 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode381});
            System.Windows.Forms.TreeNode treeNode383 = new System.Windows.Forms.TreeNode("Version 1.0.0.120", new System.Windows.Forms.TreeNode[] {
            treeNode376,
            treeNode378,
            treeNode380,
            treeNode382});
            System.Windows.Forms.TreeNode treeNode384 = new System.Windows.Forms.TreeNode("FloodFill method added");
            System.Windows.Forms.TreeNode treeNode385 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode384});
            System.Windows.Forms.TreeNode treeNode386 = new System.Windows.Forms.TreeNode("Version 1.0.0.119", new System.Windows.Forms.TreeNode[] {
            treeNode385});
            System.Windows.Forms.TreeNode treeNode387 = new System.Windows.Forms.TreeNode("SetShapeCursor method added");
            System.Windows.Forms.TreeNode treeNode388 = new System.Windows.Forms.TreeNode("CreateCursor method added");
            System.Windows.Forms.TreeNode treeNode389 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode387,
            treeNode388});
            System.Windows.Forms.TreeNode treeNode390 = new System.Windows.Forms.TreeNode("SaveAs method to save in different file formats");
            System.Windows.Forms.TreeNode treeNode391 = new System.Windows.Forms.TreeNode("Parameters added for some effects");
            System.Windows.Forms.TreeNode treeNode392 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode390,
            treeNode391});
            System.Windows.Forms.TreeNode treeNode393 = new System.Windows.Forms.TreeNode("Parameters added for some effects");
            System.Windows.Forms.TreeNode treeNode394 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode393});
            System.Windows.Forms.TreeNode treeNode395 = new System.Windows.Forms.TreeNode("Selected LDUtilities and LDShapes methods moved here to new object");
            System.Windows.Forms.TreeNode treeNode396 = new System.Windows.Forms.TreeNode("SetFontFromFile method added for ttf fonts");
            System.Windows.Forms.TreeNode treeNode397 = new System.Windows.Forms.TreeNode("LDGraphicsWindow", new System.Windows.Forms.TreeNode[] {
            treeNode395,
            treeNode396});
            System.Windows.Forms.TreeNode treeNode398 = new System.Windows.Forms.TreeNode("TWCapture and TWPrint moved from LDUtilities");
            System.Windows.Forms.TreeNode treeNode399 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode398});
            System.Windows.Forms.TreeNode treeNode400 = new System.Windows.Forms.TreeNode("Zip methods moved here from LDUtilities");
            System.Windows.Forms.TreeNode treeNode401 = new System.Windows.Forms.TreeNode("LDZip", new System.Windows.Forms.TreeNode[] {
            treeNode400});
            System.Windows.Forms.TreeNode treeNode402 = new System.Windows.Forms.TreeNode("Regex methods moved here from LDUtilities");
            System.Windows.Forms.TreeNode treeNode403 = new System.Windows.Forms.TreeNode("LDRegex", new System.Windows.Forms.TreeNode[] {
            treeNode402});
            System.Windows.Forms.TreeNode treeNode404 = new System.Windows.Forms.TreeNode("ListViewRowCount method added");
            System.Windows.Forms.TreeNode treeNode405 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode404});
            System.Windows.Forms.TreeNode treeNode406 = new System.Windows.Forms.TreeNode("Version 1.0.0.118", new System.Windows.Forms.TreeNode[] {
            treeNode389,
            treeNode392,
            treeNode394,
            treeNode397,
            treeNode399,
            treeNode401,
            treeNode403,
            treeNode405});
            System.Windows.Forms.TreeNode treeNode407 = new System.Windows.Forms.TreeNode("TransparentGW method added to create a fully transparent GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode408 = new System.Windows.Forms.TreeNode("TopMostGW method to set GraphicsWindow as top window");
            System.Windows.Forms.TreeNode treeNode409 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode407,
            treeNode408});
            System.Windows.Forms.TreeNode treeNode410 = new System.Windows.Forms.TreeNode("SetUserCursor method added");
            System.Windows.Forms.TreeNode treeNode411 = new System.Windows.Forms.TreeNode("LDCursors", new System.Windows.Forms.TreeNode[] {
            treeNode410});
            System.Windows.Forms.TreeNode treeNode412 = new System.Windows.Forms.TreeNode("Version 1.0.0.117", new System.Windows.Forms.TreeNode[] {
            treeNode409,
            treeNode411});
            System.Windows.Forms.TreeNode treeNode413 = new System.Windows.Forms.TreeNode("Replacement for Version 1.0 Dictionary object that fails");
            System.Windows.Forms.TreeNode treeNode414 = new System.Windows.Forms.TreeNode("LDDictionary", new System.Windows.Forms.TreeNode[] {
            treeNode413});
            System.Windows.Forms.TreeNode treeNode415 = new System.Windows.Forms.TreeNode("Version 1.0.0.116", new System.Windows.Forms.TreeNode[] {
            treeNode414});
            System.Windows.Forms.TreeNode treeNode416 = new System.Windows.Forms.TreeNode("GetPixel method fix for SB v1.0 bug (works for background, drawing and shape laye" +
        "rs)");
            System.Windows.Forms.TreeNode treeNode417 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode416});
            System.Windows.Forms.TreeNode treeNode418 = new System.Windows.Forms.TreeNode("GetOpacity method fix for SB v1.0 bug");
            System.Windows.Forms.TreeNode treeNode419 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode418});
            System.Windows.Forms.TreeNode treeNode420 = new System.Windows.Forms.TreeNode("GridLines replaced with GridLinesX and GridLinesY");
            System.Windows.Forms.TreeNode treeNode421 = new System.Windows.Forms.TreeNode("ScaleAxisX and ScaleAxisY methods added");
            System.Windows.Forms.TreeNode treeNode422 = new System.Windows.Forms.TreeNode("AutoScale property added to revert to earlier scaling methods");
            System.Windows.Forms.TreeNode treeNode423 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode420,
            treeNode421,
            treeNode422});
            System.Windows.Forms.TreeNode treeNode424 = new System.Windows.Forms.TreeNode("Version 1.0.0.115", new System.Windows.Forms.TreeNode[] {
            treeNode417,
            treeNode419,
            treeNode423});
            System.Windows.Forms.TreeNode treeNode425 = new System.Windows.Forms.TreeNode("ListViewSetRow fixed for overwriting existing row");
            System.Windows.Forms.TreeNode treeNode426 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode425});
            System.Windows.Forms.TreeNode treeNode427 = new System.Windows.Forms.TreeNode("RemoveTurtleLines method added");
            System.Windows.Forms.TreeNode treeNode428 = new System.Windows.Forms.TreeNode("GetAllShapes method added");
            System.Windows.Forms.TreeNode treeNode429 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode427,
            treeNode428});
            System.Windows.Forms.TreeNode treeNode430 = new System.Windows.Forms.TreeNode("Odbc connection added");
            System.Windows.Forms.TreeNode treeNode431 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode430});
            System.Windows.Forms.TreeNode treeNode432 = new System.Windows.Forms.TreeNode("Version 1.0.0.114", new System.Windows.Forms.TreeNode[] {
            treeNode426,
            treeNode429,
            treeNode431});
            System.Windows.Forms.TreeNode treeNode433 = new System.Windows.Forms.TreeNode("NetworkURL property added for your own LDNetwork web server");
            System.Windows.Forms.TreeNode treeNode434 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode433});
            System.Windows.Forms.TreeNode treeNode435 = new System.Windows.Forms.TreeNode("ListView control added");
            System.Windows.Forms.TreeNode treeNode436 = new System.Windows.Forms.TreeNode("TextBoxReadOnly to set textbox to read only");
            System.Windows.Forms.TreeNode treeNode437 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode435,
            treeNode436});
            System.Windows.Forms.TreeNode treeNode438 = new System.Windows.Forms.TreeNode("Version 1.0.0.113", new System.Windows.Forms.TreeNode[] {
            treeNode434,
            treeNode437});
            System.Windows.Forms.TreeNode treeNode439 = new System.Windows.Forms.TreeNode("Tone method added");
            System.Windows.Forms.TreeNode treeNode440 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode439});
            System.Windows.Forms.TreeNode treeNode441 = new System.Windows.Forms.TreeNode("TreeViewGetData and TreeViewEdit methods added");
            System.Windows.Forms.TreeNode treeNode442 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode441});
            System.Windows.Forms.TreeNode treeNode443 = new System.Windows.Forms.TreeNode("Version 1.0.0.112", new System.Windows.Forms.TreeNode[] {
            treeNode440,
            treeNode442});
            System.Windows.Forms.TreeNode treeNode444 = new System.Windows.Forms.TreeNode("SqlServer and Access database support added");
            System.Windows.Forms.TreeNode treeNode445 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode444});
            System.Windows.Forms.TreeNode treeNode446 = new System.Windows.Forms.TreeNode("FixFlickr method added");
            System.Windows.Forms.TreeNode treeNode447 = new System.Windows.Forms.TreeNode("ShowNoShapeErrors enable or disable TextWindow errors when shape parameter not fo" +
        "und");
            System.Windows.Forms.TreeNode treeNode448 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode446,
            treeNode447});
            System.Windows.Forms.TreeNode treeNode449 = new System.Windows.Forms.TreeNode("Version 1.0.0.111", new System.Windows.Forms.TreeNode[] {
            treeNode445,
            treeNode448});
            System.Windows.Forms.TreeNode treeNode450 = new System.Windows.Forms.TreeNode("TextBoxTab method added");
            System.Windows.Forms.TreeNode treeNode451 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode450});
            System.Windows.Forms.TreeNode treeNode452 = new System.Windows.Forms.TreeNode("Version 1.0.0.110", new System.Windows.Forms.TreeNode[] {
            treeNode451});
            System.Windows.Forms.TreeNode treeNode453 = new System.Windows.Forms.TreeNode("TextWindow warning meaages for methods that are supplied with file paths that do " +
        "not exist");
            System.Windows.Forms.TreeNode treeNode454 = new System.Windows.Forms.TreeNode("File not found warnings controlled with LDUtilities ShowFileErrors");
            System.Windows.Forms.TreeNode treeNode455 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode453,
            treeNode454});
            System.Windows.Forms.TreeNode treeNode456 = new System.Windows.Forms.TreeNode("Exists method added to check if a file path exists or not");
            System.Windows.Forms.TreeNode treeNode457 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode456});
            System.Windows.Forms.TreeNode treeNode458 = new System.Windows.Forms.TreeNode("Start method handles attaching to existing process without warning");
            System.Windows.Forms.TreeNode treeNode459 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode458});
            System.Windows.Forms.TreeNode treeNode460 = new System.Windows.Forms.TreeNode("MySQL database support added");
            System.Windows.Forms.TreeNode treeNode461 = new System.Windows.Forms.TreeNode("LDDatabase", new System.Windows.Forms.TreeNode[] {
            treeNode460});
            System.Windows.Forms.TreeNode treeNode462 = new System.Windows.Forms.TreeNode("Add and Multiply methods honour transparency");
            System.Windows.Forms.TreeNode treeNode463 = new System.Windows.Forms.TreeNode("R, G, B truncated to 0 to 255 for Add, Multiply, AddImages, and Abs for Differenc" +
        "eImages");
            System.Windows.Forms.TreeNode treeNode464 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode462,
            treeNode463});
            System.Windows.Forms.TreeNode treeNode465 = new System.Windows.Forms.TreeNode("Version 1.0.0.109", new System.Windows.Forms.TreeNode[] {
            treeNode455,
            treeNode457,
            treeNode459,
            treeNode461,
            treeNode464});
            System.Windows.Forms.TreeNode treeNode466 = new System.Windows.Forms.TreeNode("Show and Hide (fix for SB v1.0 bug)");
            System.Windows.Forms.TreeNode treeNode467 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode466});
            System.Windows.Forms.TreeNode treeNode468 = new System.Windows.Forms.TreeNode("Version 1.0.0.108", new System.Windows.Forms.TreeNode[] {
            treeNode467});
            System.Windows.Forms.TreeNode treeNode469 = new System.Windows.Forms.TreeNode("Transparent colour added");
            System.Windows.Forms.TreeNode treeNode470 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode469});
            System.Windows.Forms.TreeNode treeNode471 = new System.Windows.Forms.TreeNode("Dialogs always appear in front of GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode472 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode471});
            System.Windows.Forms.TreeNode treeNode473 = new System.Windows.Forms.TreeNode("Version 1.0.0.107", new System.Windows.Forms.TreeNode[] {
            treeNode470,
            treeNode472});
            System.Windows.Forms.TreeNode treeNode474 = new System.Windows.Forms.TreeNode("Improvements to Menu control (colouring, separators and check state)");
            System.Windows.Forms.TreeNode treeNode475 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode474});
            System.Windows.Forms.TreeNode treeNode476 = new System.Windows.Forms.TreeNode("SetShapeEvent added GotFocus and LostFocus events");
            System.Windows.Forms.TreeNode treeNode477 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode476});
            System.Windows.Forms.TreeNode treeNode478 = new System.Windows.Forms.TreeNode("Version 1.0.0.106", new System.Windows.Forms.TreeNode[] {
            treeNode475,
            treeNode477});
            System.Windows.Forms.TreeNode treeNode479 = new System.Windows.Forms.TreeNode("Menu control added");
            System.Windows.Forms.TreeNode treeNode480 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode479});
            System.Windows.Forms.TreeNode treeNode481 = new System.Windows.Forms.TreeNode("Version 1.0.0.105", new System.Windows.Forms.TreeNode[] {
            treeNode480});
            System.Windows.Forms.TreeNode treeNode482 = new System.Windows.Forms.TreeNode("ZipList method added");
            System.Windows.Forms.TreeNode treeNode483 = new System.Windows.Forms.TreeNode("GetNextMapIndex method added");
            System.Windows.Forms.TreeNode treeNode484 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode482,
            treeNode483});
            System.Windows.Forms.TreeNode treeNode485 = new System.Windows.Forms.TreeNode("GetColour method added (gets Brush, Pen and Opacity)");
            System.Windows.Forms.TreeNode treeNode486 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode485});
            System.Windows.Forms.TreeNode treeNode487 = new System.Windows.Forms.TreeNode("Version 1.0.0.104", new System.Windows.Forms.TreeNode[] {
            treeNode484,
            treeNode486});
            System.Windows.Forms.TreeNode treeNode488 = new System.Windows.Forms.TreeNode("Transparency maintained for various methods");
            System.Windows.Forms.TreeNode treeNode489 = new System.Windows.Forms.TreeNode("Effects bug fixed");
            System.Windows.Forms.TreeNode treeNode490 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode488,
            treeNode489});
            System.Windows.Forms.TreeNode treeNode491 = new System.Windows.Forms.TreeNode("Version 1.0.0.103", new System.Windows.Forms.TreeNode[] {
            treeNode490});
            System.Windows.Forms.TreeNode treeNode492 = new System.Windows.Forms.TreeNode("Current application assemblies are all auto-referenced");
            System.Windows.Forms.TreeNode treeNode493 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode492});
            System.Windows.Forms.TreeNode treeNode494 = new System.Windows.Forms.TreeNode("Version 1.0.0.102", new System.Windows.Forms.TreeNode[] {
            treeNode493});
            System.Windows.Forms.TreeNode treeNode495 = new System.Windows.Forms.TreeNode("Include C# or VB methods, properties and events to compile and call from your Sma" +
        "llBasic code");
            System.Windows.Forms.TreeNode treeNode496 = new System.Windows.Forms.TreeNode("LDInline.sb sample provided");
            System.Windows.Forms.TreeNode treeNode497 = new System.Windows.Forms.TreeNode("LDInline", new System.Windows.Forms.TreeNode[] {
            treeNode495,
            treeNode496});
            System.Windows.Forms.TreeNode treeNode498 = new System.Windows.Forms.TreeNode("ExitButtonMode method added to control window close button state");
            System.Windows.Forms.TreeNode treeNode499 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode498});
            System.Windows.Forms.TreeNode treeNode500 = new System.Windows.Forms.TreeNode("Version 1.0.0.101", new System.Windows.Forms.TreeNode[] {
            treeNode497,
            treeNode499});
            System.Windows.Forms.TreeNode treeNode501 = new System.Windows.Forms.TreeNode("Read and ReadNumber methods added (with a delay before auto return)");
            System.Windows.Forms.TreeNode treeNode502 = new System.Windows.Forms.TreeNode("KeyDown, KeyUp and SendKey (low level keyboard control) added");
            System.Windows.Forms.TreeNode treeNode503 = new System.Windows.Forms.TreeNode("LDTextWindow", new System.Windows.Forms.TreeNode[] {
            treeNode501,
            treeNode502});
            System.Windows.Forms.TreeNode treeNode504 = new System.Windows.Forms.TreeNode("Version 1.0.0.100", new System.Windows.Forms.TreeNode[] {
            treeNode503});
            System.Windows.Forms.TreeNode treeNode505 = new System.Windows.Forms.TreeNode("ReadANSIToArray method added");
            System.Windows.Forms.TreeNode treeNode506 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode505});
            System.Windows.Forms.TreeNode treeNode507 = new System.Windows.Forms.TreeNode("DocumentViewer control added");
            System.Windows.Forms.TreeNode treeNode508 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode507});
            System.Windows.Forms.TreeNode treeNode509 = new System.Windows.Forms.TreeNode("An object to batch update shapes (for speed reasons)");
            System.Windows.Forms.TreeNode treeNode510 = new System.Windows.Forms.TreeNode("LDFastShapes.sb sample included");
            System.Windows.Forms.TreeNode treeNode511 = new System.Windows.Forms.TreeNode("LDFastShapes", new System.Windows.Forms.TreeNode[] {
            treeNode509,
            treeNode510});
            System.Windows.Forms.TreeNode treeNode512 = new System.Windows.Forms.TreeNode("Version 1.0.0.99", new System.Windows.Forms.TreeNode[] {
            treeNode506,
            treeNode508,
            treeNode511});
            System.Windows.Forms.TreeNode treeNode513 = new System.Windows.Forms.TreeNode("Rendering performance improvements when many shapes present");
            System.Windows.Forms.TreeNode treeNode514 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode513});
            System.Windows.Forms.TreeNode treeNode515 = new System.Windows.Forms.TreeNode("ANSItoUTF8 method added");
            System.Windows.Forms.TreeNode treeNode516 = new System.Windows.Forms.TreeNode("ReadANSI method added");
            System.Windows.Forms.TreeNode treeNode517 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode515,
            treeNode516});
            System.Windows.Forms.TreeNode treeNode518 = new System.Windows.Forms.TreeNode("Version 1.0.0.98", new System.Windows.Forms.TreeNode[] {
            treeNode514,
            treeNode517});
            System.Windows.Forms.TreeNode treeNode519 = new System.Windows.Forms.TreeNode("Move method added for tiangles, polygons and lines");
            System.Windows.Forms.TreeNode treeNode520 = new System.Windows.Forms.TreeNode("RotateAbout method added");
            System.Windows.Forms.TreeNode treeNode521 = new System.Windows.Forms.TreeNode("GetLeft and GetTop methods added for triangles, polygons and lines");
            System.Windows.Forms.TreeNode treeNode522 = new System.Windows.Forms.TreeNode("SetTurtleImage repositioning \'hot spot\' on resize fixed");
            System.Windows.Forms.TreeNode treeNode523 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode519,
            treeNode520,
            treeNode521,
            treeNode522});
            System.Windows.Forms.TreeNode treeNode524 = new System.Windows.Forms.TreeNode("Version 1.0.0.97", new System.Windows.Forms.TreeNode[] {
            treeNode523});
            System.Windows.Forms.TreeNode treeNode525 = new System.Windows.Forms.TreeNode("A list storage object added");
            System.Windows.Forms.TreeNode treeNode526 = new System.Windows.Forms.TreeNode("LDList", new System.Windows.Forms.TreeNode[] {
            treeNode525});
            System.Windows.Forms.TreeNode treeNode527 = new System.Windows.Forms.TreeNode("Version 1.0.0.96", new System.Windows.Forms.TreeNode[] {
            treeNode526});
            System.Windows.Forms.TreeNode treeNode528 = new System.Windows.Forms.TreeNode("A queue (first-in first-out) storage similar to a stack object added");
            System.Windows.Forms.TreeNode treeNode529 = new System.Windows.Forms.TreeNode("LDQueue", new System.Windows.Forms.TreeNode[] {
            treeNode528});
            System.Windows.Forms.TreeNode treeNode530 = new System.Windows.Forms.TreeNode("Fix for multi-dimensional arrays using GetGameData and SetGameData");
            System.Windows.Forms.TreeNode treeNode531 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode530});
            System.Windows.Forms.TreeNode treeNode532 = new System.Windows.Forms.TreeNode("Returned arrays with \\= or ; in index or value correctly handled");
            System.Windows.Forms.TreeNode treeNode533 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode532});
            System.Windows.Forms.TreeNode treeNode534 = new System.Windows.Forms.TreeNode("Version 1.0.0.95", new System.Windows.Forms.TreeNode[] {
            treeNode529,
            treeNode531,
            treeNode533});
            System.Windows.Forms.TreeNode treeNode535 = new System.Windows.Forms.TreeNode("SHA512Hash and MD5HashFile methods added");
            System.Windows.Forms.TreeNode treeNode536 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode535});
            System.Windows.Forms.TreeNode treeNode537 = new System.Windows.Forms.TreeNode("RandomNumberSeed property added");
            System.Windows.Forms.TreeNode treeNode538 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode537});
            System.Windows.Forms.TreeNode treeNode539 = new System.Windows.Forms.TreeNode("SetGameData and GetGameData methods added");
            System.Windows.Forms.TreeNode treeNode540 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode539});
            System.Windows.Forms.TreeNode treeNode541 = new System.Windows.Forms.TreeNode("Version 1.0.0.94", new System.Windows.Forms.TreeNode[] {
            treeNode536,
            treeNode538,
            treeNode540});
            System.Windows.Forms.TreeNode treeNode542 = new System.Windows.Forms.TreeNode("SliderGetValue method added");
            System.Windows.Forms.TreeNode treeNode543 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode542});
            System.Windows.Forms.TreeNode treeNode544 = new System.Windows.Forms.TreeNode("UnZip now works with most zip formats, not just those created with LDUtilities.Zi" +
        "p");
            System.Windows.Forms.TreeNode treeNode545 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode544});
            System.Windows.Forms.TreeNode treeNode546 = new System.Windows.Forms.TreeNode("Encrypt and Decrypt methods added");
            System.Windows.Forms.TreeNode treeNode547 = new System.Windows.Forms.TreeNode("MD5Hash method added");
            System.Windows.Forms.TreeNode treeNode548 = new System.Windows.Forms.TreeNode("LDEncryption", new System.Windows.Forms.TreeNode[] {
            treeNode546,
            treeNode547});
            System.Windows.Forms.TreeNode treeNode549 = new System.Windows.Forms.TreeNode("Version 1.0.0.93", new System.Windows.Forms.TreeNode[] {
            treeNode543,
            treeNode545,
            treeNode548});
            System.Windows.Forms.TreeNode treeNode550 = new System.Windows.Forms.TreeNode("ProgressBar, Slider and PasswordBox controls added");
            System.Windows.Forms.TreeNode treeNode551 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode550});
            System.Windows.Forms.TreeNode treeNode552 = new System.Windows.Forms.TreeNode("Version 1.0.0.92", new System.Windows.Forms.TreeNode[] {
            treeNode551});
            System.Windows.Forms.TreeNode treeNode553 = new System.Windows.Forms.TreeNode("TreeViewGetSelected, ListBoxGetSelected, ComboBoxGetSelected, CheckBoxGetState an" +
        "d RadioButtonGet methods added");
            System.Windows.Forms.TreeNode treeNode554 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode553});
            System.Windows.Forms.TreeNode treeNode555 = new System.Windows.Forms.TreeNode("Version 1.0.0.91", new System.Windows.Forms.TreeNode[] {
            treeNode554});
            System.Windows.Forms.TreeNode treeNode556 = new System.Windows.Forms.TreeNode("Font method added to modify shapes or controls that have text");
            System.Windows.Forms.TreeNode treeNode557 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode556});
            System.Windows.Forms.TreeNode treeNode558 = new System.Windows.Forms.TreeNode("MediaPlayer control added (play videos etc)");
            System.Windows.Forms.TreeNode treeNode559 = new System.Windows.Forms.TreeNode("ListBoxContent, TreeViewContent and ComboBoxContent methods added to change list " +
        "contents");
            System.Windows.Forms.TreeNode treeNode560 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode558,
            treeNode559});
            System.Windows.Forms.TreeNode treeNode561 = new System.Windows.Forms.TreeNode("Version 1.0.0.90", new System.Windows.Forms.TreeNode[] {
            treeNode557,
            treeNode560});
            System.Windows.Forms.TreeNode treeNode562 = new System.Windows.Forms.TreeNode("Autosize columns for ListView");
            System.Windows.Forms.TreeNode treeNode563 = new System.Windows.Forms.TreeNode("LDDataBase.sb sample updated");
            System.Windows.Forms.TreeNode treeNode564 = new System.Windows.Forms.TreeNode("Optionally return array of results for query (GetRecord removed)");
            System.Windows.Forms.TreeNode treeNode565 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode562,
            treeNode563,
            treeNode564});
            System.Windows.Forms.TreeNode treeNode566 = new System.Windows.Forms.TreeNode("Version 1.0.0.89", new System.Windows.Forms.TreeNode[] {
            treeNode565});
            System.Windows.Forms.TreeNode treeNode567 = new System.Windows.Forms.TreeNode("GraphicsWindow.MouseDown works for any event subroutine name");
            System.Windows.Forms.TreeNode treeNode568 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode567});
            System.Windows.Forms.TreeNode treeNode569 = new System.Windows.Forms.TreeNode("CleanTemp method added");
            System.Windows.Forms.TreeNode treeNode570 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode569});
            System.Windows.Forms.TreeNode treeNode571 = new System.Windows.Forms.TreeNode("SQLite database methods added");
            System.Windows.Forms.TreeNode treeNode572 = new System.Windows.Forms.TreeNode("LDDataBase", new System.Windows.Forms.TreeNode[] {
            treeNode571});
            System.Windows.Forms.TreeNode treeNode573 = new System.Windows.Forms.TreeNode("Version 1.0.0.88", new System.Windows.Forms.TreeNode[] {
            treeNode568,
            treeNode570,
            treeNode572});
            System.Windows.Forms.TreeNode treeNode574 = new System.Windows.Forms.TreeNode("LastError now returns a text error");
            System.Windows.Forms.TreeNode treeNode575 = new System.Windows.Forms.TreeNode("LDIOWarrior", new System.Windows.Forms.TreeNode[] {
            treeNode574});
            System.Windows.Forms.TreeNode treeNode576 = new System.Windows.Forms.TreeNode("MouseDown (must be named \"OnMouseDown\") and MouseWheel events fixed");
            System.Windows.Forms.TreeNode treeNode577 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode576});
            System.Windows.Forms.TreeNode treeNode578 = new System.Windows.Forms.TreeNode("Version 1.0.0.87", new System.Windows.Forms.TreeNode[] {
            treeNode575,
            treeNode577});
            System.Windows.Forms.TreeNode treeNode579 = new System.Windows.Forms.TreeNode("SetTurtleImage method added");
            System.Windows.Forms.TreeNode treeNode580 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode579});
            System.Windows.Forms.TreeNode treeNode581 = new System.Windows.Forms.TreeNode("Connect to IOWarrior USB devices");
            System.Windows.Forms.TreeNode treeNode582 = new System.Windows.Forms.TreeNode("http://www.codemercs.com/io-warrior/?L=1");
            System.Windows.Forms.TreeNode treeNode583 = new System.Windows.Forms.TreeNode("LDIOWarrior", new System.Windows.Forms.TreeNode[] {
            treeNode581,
            treeNode582});
            System.Windows.Forms.TreeNode treeNode584 = new System.Windows.Forms.TreeNode("Version 1.0.0.86", new System.Windows.Forms.TreeNode[] {
            treeNode580,
            treeNode583});
            System.Windows.Forms.TreeNode treeNode585 = new System.Windows.Forms.TreeNode("PenColour, BrushColour and BrushGradientShape applied to most Shapes and Controls" +
        "");
            System.Windows.Forms.TreeNode treeNode586 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode585});
            System.Windows.Forms.TreeNode treeNode587 = new System.Windows.Forms.TreeNode("Version 1.0.0.85", new System.Windows.Forms.TreeNode[] {
            treeNode586});
            System.Windows.Forms.TreeNode treeNode588 = new System.Windows.Forms.TreeNode("GetFolder, GetFile and GetExtension methods added");
            System.Windows.Forms.TreeNode treeNode589 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode588});
            System.Windows.Forms.TreeNode treeNode590 = new System.Windows.Forms.TreeNode("Crop method added");
            System.Windows.Forms.TreeNode treeNode591 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode590});
            System.Windows.Forms.TreeNode treeNode592 = new System.Windows.Forms.TreeNode("LastDropFiles bug fixed");
            System.Windows.Forms.TreeNode treeNode593 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode592});
            System.Windows.Forms.TreeNode treeNode594 = new System.Windows.Forms.TreeNode("Version 1.0.0.84", new System.Windows.Forms.TreeNode[] {
            treeNode589,
            treeNode591,
            treeNode593});
            System.Windows.Forms.TreeNode treeNode595 = new System.Windows.Forms.TreeNode("FileDropped event added");
            System.Windows.Forms.TreeNode treeNode596 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode595});
            System.Windows.Forms.TreeNode treeNode597 = new System.Windows.Forms.TreeNode("Bug in Split corrected");
            System.Windows.Forms.TreeNode treeNode598 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode597});
            System.Windows.Forms.TreeNode treeNode599 = new System.Windows.Forms.TreeNode("Version 1.0.0.83", new System.Windows.Forms.TreeNode[] {
            treeNode596,
            treeNode598});
            System.Windows.Forms.TreeNode treeNode600 = new System.Windows.Forms.TreeNode("Title argument removed from AddComboBox");
            System.Windows.Forms.TreeNode treeNode601 = new System.Windows.Forms.TreeNode("AllowDrop method added (for TextBox, RichTextBox, Image and Background)");
            System.Windows.Forms.TreeNode treeNode602 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode600,
            treeNode601});
            System.Windows.Forms.TreeNode treeNode603 = new System.Windows.Forms.TreeNode("Version 1.0.0.82", new System.Windows.Forms.TreeNode[] {
            treeNode602});
            System.Windows.Forms.TreeNode treeNode604 = new System.Windows.Forms.TreeNode("German xml updated (Thanks to Pappa Lapub)");
            System.Windows.Forms.TreeNode treeNode605 = new System.Windows.Forms.TreeNode("Program settings added");
            System.Windows.Forms.TreeNode treeNode606 = new System.Windows.Forms.TreeNode("LDSettings", new System.Windows.Forms.TreeNode[] {
            treeNode605});
            System.Windows.Forms.TreeNode treeNode607 = new System.Windows.Forms.TreeNode("Get some system paths and user name");
            System.Windows.Forms.TreeNode treeNode608 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode607});
            System.Windows.Forms.TreeNode treeNode609 = new System.Windows.Forms.TreeNode("System sounds added");
            System.Windows.Forms.TreeNode treeNode610 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode609});
            System.Windows.Forms.TreeNode treeNode611 = new System.Windows.Forms.TreeNode("Binary, octal, hex and decimal conversions");
            System.Windows.Forms.TreeNode treeNode612 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode611});
            System.Windows.Forms.TreeNode treeNode613 = new System.Windows.Forms.TreeNode("Replace method added");
            System.Windows.Forms.TreeNode treeNode614 = new System.Windows.Forms.TreeNode("FindAll method added");
            System.Windows.Forms.TreeNode treeNode615 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode613,
            treeNode614});
            System.Windows.Forms.TreeNode treeNode616 = new System.Windows.Forms.TreeNode("Version 1.0.0.81", new System.Windows.Forms.TreeNode[] {
            treeNode604,
            treeNode606,
            treeNode608,
            treeNode610,
            treeNode612,
            treeNode615});
            System.Windows.Forms.TreeNode treeNode617 = new System.Windows.Forms.TreeNode("BrushColour, BrushGradientShape and PenColour implemented for buttons");
            System.Windows.Forms.TreeNode treeNode618 = new System.Windows.Forms.TreeNode("General events for shapes added (see ShapeEvents sample)");
            System.Windows.Forms.TreeNode treeNode619 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode617,
            treeNode618});
            System.Windows.Forms.TreeNode treeNode620 = new System.Windows.Forms.TreeNode("Truncate method added");
            System.Windows.Forms.TreeNode treeNode621 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode620});
            System.Windows.Forms.TreeNode treeNode622 = new System.Windows.Forms.TreeNode("Additional text methods");
            System.Windows.Forms.TreeNode treeNode623 = new System.Windows.Forms.TreeNode("LDText", new System.Windows.Forms.TreeNode[] {
            treeNode622});
            System.Windows.Forms.TreeNode treeNode624 = new System.Windows.Forms.TreeNode("Version 1.0.0.80", new System.Windows.Forms.TreeNode[] {
            treeNode619,
            treeNode621,
            treeNode623});
            System.Windows.Forms.TreeNode treeNode625 = new System.Windows.Forms.TreeNode("Confirm dialog message box (Yes, No, Cancel) added");
            System.Windows.Forms.TreeNode treeNode626 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode625});
            System.Windows.Forms.TreeNode treeNode627 = new System.Windows.Forms.TreeNode("CancelClose property added for GraphicsWindow closure");
            System.Windows.Forms.TreeNode treeNode628 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode627});
            System.Windows.Forms.TreeNode treeNode629 = new System.Windows.Forms.TreeNode("Version 1.0.0.79", new System.Windows.Forms.TreeNode[] {
            treeNode626,
            treeNode628});
            System.Windows.Forms.TreeNode treeNode630 = new System.Windows.Forms.TreeNode("Rasterize property added");
            System.Windows.Forms.TreeNode treeNode631 = new System.Windows.Forms.TreeNode("Improvements associated with window resizing");
            System.Windows.Forms.TreeNode treeNode632 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode630,
            treeNode631});
            System.Windows.Forms.TreeNode treeNode633 = new System.Windows.Forms.TreeNode("ExitOnClose property (and GWClosing event) added");
            System.Windows.Forms.TreeNode treeNode634 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode633});
            System.Windows.Forms.TreeNode treeNode635 = new System.Windows.Forms.TreeNode("Version 1.0.0.78", new System.Windows.Forms.TreeNode[] {
            treeNode632,
            treeNode634});
            System.Windows.Forms.TreeNode treeNode636 = new System.Windows.Forms.TreeNode("Handle more than 100 drawables (rasterization)");
            System.Windows.Forms.TreeNode treeNode637 = new System.Windows.Forms.TreeNode("LDScollBars", new System.Windows.Forms.TreeNode[] {
            treeNode636});
            System.Windows.Forms.TreeNode treeNode638 = new System.Windows.Forms.TreeNode("Version 1.0.0.77", new System.Windows.Forms.TreeNode[] {
            treeNode637});
            System.Windows.Forms.TreeNode treeNode639 = new System.Windows.Forms.TreeNode("Record sound from a microphone");
            System.Windows.Forms.TreeNode treeNode640 = new System.Windows.Forms.TreeNode("LDSound", new System.Windows.Forms.TreeNode[] {
            treeNode639});
            System.Windows.Forms.TreeNode treeNode641 = new System.Windows.Forms.TreeNode("AnimateOpacity method added (flashing)");
            System.Windows.Forms.TreeNode treeNode642 = new System.Windows.Forms.TreeNode("AnimateRotation method added (continuous rotation)");
            System.Windows.Forms.TreeNode treeNode643 = new System.Windows.Forms.TreeNode("AnimateZoom method added (coninuous zooming)");
            System.Windows.Forms.TreeNode treeNode644 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode641,
            treeNode642,
            treeNode643});
            System.Windows.Forms.TreeNode treeNode645 = new System.Windows.Forms.TreeNode("Version 1.0.0.76", new System.Windows.Forms.TreeNode[] {
            treeNode640,
            treeNode644});
            System.Windows.Forms.TreeNode treeNode646 = new System.Windows.Forms.TreeNode("AddAnimatedImage can use an ImageList image");
            System.Windows.Forms.TreeNode treeNode647 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode646});
            System.Windows.Forms.TreeNode treeNode648 = new System.Windows.Forms.TreeNode("Version 1.0.0.75", new System.Windows.Forms.TreeNode[] {
            treeNode647});
            System.Windows.Forms.TreeNode treeNode649 = new System.Windows.Forms.TreeNode("Initial graph axes scaling improvement");
            System.Windows.Forms.TreeNode treeNode650 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode649});
            System.Windows.Forms.TreeNode treeNode651 = new System.Windows.Forms.TreeNode("Methods to access a bluetooth device");
            System.Windows.Forms.TreeNode treeNode652 = new System.Windows.Forms.TreeNode("Includes simple file transfer and potentially advanced device interaction");
            System.Windows.Forms.TreeNode treeNode653 = new System.Windows.Forms.TreeNode("LDBlueTooth", new System.Windows.Forms.TreeNode[] {
            treeNode651,
            treeNode652});
            System.Windows.Forms.TreeNode treeNode654 = new System.Windows.Forms.TreeNode("getFocus handles multiple LDWindows");
            System.Windows.Forms.TreeNode treeNode655 = new System.Windows.Forms.TreeNode("LDFocus", new System.Windows.Forms.TreeNode[] {
            treeNode654});
            System.Windows.Forms.TreeNode treeNode656 = new System.Windows.Forms.TreeNode("Version 1.0.0.74", new System.Windows.Forms.TreeNode[] {
            treeNode650,
            treeNode653,
            treeNode655});
            System.Windows.Forms.TreeNode treeNode657 = new System.Windows.Forms.TreeNode("First pass at a generic USB (HID) device controller");
            System.Windows.Forms.TreeNode treeNode658 = new System.Windows.Forms.TreeNode("LDHID", new System.Windows.Forms.TreeNode[] {
            treeNode657});
            System.Windows.Forms.TreeNode treeNode659 = new System.Windows.Forms.TreeNode("Version 1.0.0.73", new System.Windows.Forms.TreeNode[] {
            treeNode658});
            System.Windows.Forms.TreeNode treeNode660 = new System.Windows.Forms.TreeNode("Initial scaling doesn\'t position points touching the axes");
            System.Windows.Forms.TreeNode treeNode661 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode660});
            System.Windows.Forms.TreeNode treeNode662 = new System.Windows.Forms.TreeNode("Version 1.0.0.72", new System.Windows.Forms.TreeNode[] {
            treeNode661});
            System.Windows.Forms.TreeNode treeNode663 = new System.Windows.Forms.TreeNode("TrendCoef method added to get polynomial trend line coefficients");
            System.Windows.Forms.TreeNode treeNode664 = new System.Windows.Forms.TreeNode("TrendPointCount property added to control the number of points on a trend line");
            System.Windows.Forms.TreeNode treeNode665 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode663,
            treeNode664});
            System.Windows.Forms.TreeNode treeNode666 = new System.Windows.Forms.TreeNode("Version 1.0.0.71", new System.Windows.Forms.TreeNode[] {
            treeNode665});
            System.Windows.Forms.TreeNode treeNode667 = new System.Windows.Forms.TreeNode("Spurious error message fixed");
            System.Windows.Forms.TreeNode treeNode668 = new System.Windows.Forms.TreeNode("CreateTrend data series creation method added");
            System.Windows.Forms.TreeNode treeNode669 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode667,
            treeNode668});
            System.Windows.Forms.TreeNode treeNode670 = new System.Windows.Forms.TreeNode("Version 1.0.0.70", new System.Windows.Forms.TreeNode[] {
            treeNode669});
            System.Windows.Forms.TreeNode treeNode671 = new System.Windows.Forms.TreeNode("Font properties and colours set for LDControls in the same way as standard Contro" +
        "ls");
            System.Windows.Forms.TreeNode treeNode672 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode671});
            System.Windows.Forms.TreeNode treeNode673 = new System.Windows.Forms.TreeNode("Version 1.0.0.69", new System.Windows.Forms.TreeNode[] {
            treeNode672});
            System.Windows.Forms.TreeNode treeNode674 = new System.Windows.Forms.TreeNode("Radio button control added");
            System.Windows.Forms.TreeNode treeNode675 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode674});
            System.Windows.Forms.TreeNode treeNode676 = new System.Windows.Forms.TreeNode("Version 1.0.0.68", new System.Windows.Forms.TreeNode[] {
            treeNode675});
            System.Windows.Forms.TreeNode treeNode677 = new System.Windows.Forms.TreeNode("Bug fix for Copy");
            System.Windows.Forms.TreeNode treeNode678 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode677});
            System.Windows.Forms.TreeNode treeNode679 = new System.Windows.Forms.TreeNode("Version 1.0.0.67", new System.Windows.Forms.TreeNode[] {
            treeNode678});
            System.Windows.Forms.TreeNode treeNode680 = new System.Windows.Forms.TreeNode("RegexMatch and RegexReplace methods added");
            System.Windows.Forms.TreeNode treeNode681 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode680});
            System.Windows.Forms.TreeNode treeNode682 = new System.Windows.Forms.TreeNode("Version 1.0.0.66", new System.Windows.Forms.TreeNode[] {
            treeNode681});
            System.Windows.Forms.TreeNode treeNode683 = new System.Windows.Forms.TreeNode("Number culture conversions added");
            System.Windows.Forms.TreeNode treeNode684 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode683});
            System.Windows.Forms.TreeNode treeNode685 = new System.Windows.Forms.TreeNode("Version 1.0.0.65", new System.Windows.Forms.TreeNode[] {
            treeNode684});
            System.Windows.Forms.TreeNode treeNode686 = new System.Windows.Forms.TreeNode("IsNumber method added");
            System.Windows.Forms.TreeNode treeNode687 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode686});
            System.Windows.Forms.TreeNode treeNode688 = new System.Windows.Forms.TreeNode("Version 1.0.0.64", new System.Windows.Forms.TreeNode[] {
            treeNode687});
            System.Windows.Forms.TreeNode treeNode689 = new System.Windows.Forms.TreeNode("SetCursorPosition method added for textboxes");
            System.Windows.Forms.TreeNode treeNode690 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode689});
            System.Windows.Forms.TreeNode treeNode691 = new System.Windows.Forms.TreeNode("Version 1.0.0.63", new System.Windows.Forms.TreeNode[] {
            treeNode690});
            System.Windows.Forms.TreeNode treeNode692 = new System.Windows.Forms.TreeNode("SetCursorToEnd method added for textboxes");
            System.Windows.Forms.TreeNode treeNode693 = new System.Windows.Forms.TreeNode("SetSpellCheck method added for textboxes and richtextboxes");
            System.Windows.Forms.TreeNode treeNode694 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode692,
            treeNode693});
            System.Windows.Forms.TreeNode treeNode695 = new System.Windows.Forms.TreeNode("Version 1.0.0.62", new System.Windows.Forms.TreeNode[] {
            treeNode694});
            System.Windows.Forms.TreeNode treeNode696 = new System.Windows.Forms.TreeNode("Adding polygons not located at (0,0) corrected");
            System.Windows.Forms.TreeNode treeNode697 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode696});
            System.Windows.Forms.TreeNode treeNode698 = new System.Windows.Forms.TreeNode("Version 1.0.0.61", new System.Windows.Forms.TreeNode[] {
            treeNode697});
            System.Windows.Forms.TreeNode treeNode699 = new System.Windows.Forms.TreeNode("GetFolder dialog added");
            System.Windows.Forms.TreeNode treeNode700 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode699});
            System.Windows.Forms.TreeNode treeNode701 = new System.Windows.Forms.TreeNode("Version 1.0.0.60", new System.Windows.Forms.TreeNode[] {
            treeNode700});
            System.Windows.Forms.TreeNode treeNode702 = new System.Windows.Forms.TreeNode("Possible localization issue with Font size fixed");
            System.Windows.Forms.TreeNode treeNode703 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode702});
            System.Windows.Forms.TreeNode treeNode704 = new System.Windows.Forms.TreeNode("Version 1.0.0.59", new System.Windows.Forms.TreeNode[] {
            treeNode703});
            System.Windows.Forms.TreeNode treeNode705 = new System.Windows.Forms.TreeNode("More internationalization fixes");
            System.Windows.Forms.TreeNode treeNode706 = new System.Windows.Forms.TreeNode("ShowPrintPreview property added");
            System.Windows.Forms.TreeNode treeNode707 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode706});
            System.Windows.Forms.TreeNode treeNode708 = new System.Windows.Forms.TreeNode("Possible error with gradient drawings fixed");
            System.Windows.Forms.TreeNode treeNode709 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode708});
            System.Windows.Forms.TreeNode treeNode710 = new System.Windows.Forms.TreeNode("Possible Listen event initialisation error fixed");
            System.Windows.Forms.TreeNode treeNode711 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode710});
            System.Windows.Forms.TreeNode treeNode712 = new System.Windows.Forms.TreeNode("Version 1.0.0.58", new System.Windows.Forms.TreeNode[] {
            treeNode705,
            treeNode707,
            treeNode709,
            treeNode711});
            System.Windows.Forms.TreeNode treeNode713 = new System.Windows.Forms.TreeNode("Many possible internationisation issues fixed");
            System.Windows.Forms.TreeNode treeNode714 = new System.Windows.Forms.TreeNode("Version 1.0.0.57", new System.Windows.Forms.TreeNode[] {
            treeNode713});
            System.Windows.Forms.TreeNode treeNode715 = new System.Windows.Forms.TreeNode("Emmisive colour correction for AddGeometry");
            System.Windows.Forms.TreeNode treeNode716 = new System.Windows.Forms.TreeNode("Geometry coordinates etc are now colon or space deminiated (not comma)");
            System.Windows.Forms.TreeNode treeNode717 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode715,
            treeNode716});
            System.Windows.Forms.TreeNode treeNode718 = new System.Windows.Forms.TreeNode("CSVdeminiator property added");
            System.Windows.Forms.TreeNode treeNode719 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode718});
            System.Windows.Forms.TreeNode treeNode720 = new System.Windows.Forms.TreeNode("Version 1.0.0.56", new System.Windows.Forms.TreeNode[] {
            treeNode717,
            treeNode719});
            System.Windows.Forms.TreeNode treeNode721 = new System.Windows.Forms.TreeNode("Improved error reporting");
            System.Windows.Forms.TreeNode treeNode722 = new System.Windows.Forms.TreeNode("Culture invariant type conversions");
            System.Windows.Forms.TreeNode treeNode723 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode722});
            System.Windows.Forms.TreeNode treeNode724 = new System.Windows.Forms.TreeNode("ShowErrors method added");
            System.Windows.Forms.TreeNode treeNode725 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode724});
            System.Windows.Forms.TreeNode treeNode726 = new System.Windows.Forms.TreeNode("Version 1.0.0.55", new System.Windows.Forms.TreeNode[] {
            treeNode721,
            treeNode723,
            treeNode725});
            System.Windows.Forms.TreeNode treeNode727 = new System.Windows.Forms.TreeNode("Warning added to intellisense help about  resizing GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode728 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode727});
            System.Windows.Forms.TreeNode treeNode729 = new System.Windows.Forms.TreeNode("GWWidth and GWHeight added for use with LDScrollBars");
            System.Windows.Forms.TreeNode treeNode730 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode729});
            System.Windows.Forms.TreeNode treeNode731 = new System.Windows.Forms.TreeNode("Version 1.0.0.54", new System.Windows.Forms.TreeNode[] {
            treeNode728,
            treeNode730});
            System.Windows.Forms.TreeNode treeNode732 = new System.Windows.Forms.TreeNode("Debug window can be resized");
            System.Windows.Forms.TreeNode treeNode733 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode732});
            System.Windows.Forms.TreeNode treeNode734 = new System.Windows.Forms.TreeNode("PrintFile method added");
            System.Windows.Forms.TreeNode treeNode735 = new System.Windows.Forms.TreeNode("LDFile", new System.Windows.Forms.TreeNode[] {
            treeNode734});
            System.Windows.Forms.TreeNode treeNode736 = new System.Windows.Forms.TreeNode("Version 1.0.0.53", new System.Windows.Forms.TreeNode[] {
            treeNode733,
            treeNode735});
            System.Windows.Forms.TreeNode treeNode737 = new System.Windows.Forms.TreeNode("SSL property option added");
            System.Windows.Forms.TreeNode treeNode738 = new System.Windows.Forms.TreeNode("LDEmail", new System.Windows.Forms.TreeNode[] {
            treeNode737});
            System.Windows.Forms.TreeNode treeNode739 = new System.Windows.Forms.TreeNode("Version 1.0.0.52", new System.Windows.Forms.TreeNode[] {
            treeNode738});
            System.Windows.Forms.TreeNode treeNode740 = new System.Windows.Forms.TreeNode("Right Click Context menu added for any shape or control");
            System.Windows.Forms.TreeNode treeNode741 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode740});
            System.Windows.Forms.TreeNode treeNode742 = new System.Windows.Forms.TreeNode("Version 1.0.0.51", new System.Windows.Forms.TreeNode[] {
            treeNode741});
            System.Windows.Forms.TreeNode treeNode743 = new System.Windows.Forms.TreeNode("Right click dropdown menu option added");
            System.Windows.Forms.TreeNode treeNode744 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode743});
            System.Windows.Forms.TreeNode treeNode745 = new System.Windows.Forms.TreeNode("Version 1.0.0.50", new System.Windows.Forms.TreeNode[] {
            treeNode744});
            System.Windows.Forms.TreeNode treeNode746 = new System.Windows.Forms.TreeNode("More methods added, AddSphere, AddTube, ReverseNormals");
            System.Windows.Forms.TreeNode treeNode747 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode746});
            System.Windows.Forms.TreeNode treeNode748 = new System.Windows.Forms.TreeNode("Version 1.0.0.49", new System.Windows.Forms.TreeNode[] {
            treeNode747});
            System.Windows.Forms.TreeNode treeNode749 = new System.Windows.Forms.TreeNode("Performance improvements (some camera controls for this)");
            System.Windows.Forms.TreeNode treeNode750 = new System.Windows.Forms.TreeNode("LoadModel (*.3ds) files added");
            System.Windows.Forms.TreeNode treeNode751 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode749,
            treeNode750});
            System.Windows.Forms.TreeNode treeNode752 = new System.Windows.Forms.TreeNode("AddStar and AddRegularPolygon shape methods added");
            System.Windows.Forms.TreeNode treeNode753 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode752});
            System.Windows.Forms.TreeNode treeNode754 = new System.Windows.Forms.TreeNode("Version 1.0.0.48", new System.Windows.Forms.TreeNode[] {
            treeNode751,
            treeNode753});
            System.Windows.Forms.TreeNode treeNode755 = new System.Windows.Forms.TreeNode("Some improvements including animations");
            System.Windows.Forms.TreeNode treeNode756 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode755});
            System.Windows.Forms.TreeNode treeNode757 = new System.Windows.Forms.TreeNode("Version 1.0.0.47", new System.Windows.Forms.TreeNode[] {
            treeNode756});
            System.Windows.Forms.TreeNode treeNode758 = new System.Windows.Forms.TreeNode("Some improvemts and new methods");
            System.Windows.Forms.TreeNode treeNode759 = new System.Windows.Forms.TreeNode("LD3Dview", new System.Windows.Forms.TreeNode[] {
            treeNode758});
            System.Windows.Forms.TreeNode treeNode760 = new System.Windows.Forms.TreeNode("Version 1.0.0.46", new System.Windows.Forms.TreeNode[] {
            treeNode759});
            System.Windows.Forms.TreeNode treeNode761 = new System.Windows.Forms.TreeNode("A start at a 3D set of methods");
            System.Windows.Forms.TreeNode treeNode762 = new System.Windows.Forms.TreeNode("LD3DView", new System.Windows.Forms.TreeNode[] {
            treeNode761});
            System.Windows.Forms.TreeNode treeNode763 = new System.Windows.Forms.TreeNode("Version 1.0.0.45", new System.Windows.Forms.TreeNode[] {
            treeNode762});
            System.Windows.Forms.TreeNode treeNode764 = new System.Windows.Forms.TreeNode("Create scrollbars for the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode765 = new System.Windows.Forms.TreeNode("Methods to control the scrollbars allowing a scrolling game to be made");
            System.Windows.Forms.TreeNode treeNode766 = new System.Windows.Forms.TreeNode("LDScrollBars", new System.Windows.Forms.TreeNode[] {
            treeNode764,
            treeNode765});
            System.Windows.Forms.TreeNode treeNode767 = new System.Windows.Forms.TreeNode("ColourList method added");
            System.Windows.Forms.TreeNode treeNode768 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode767});
            System.Windows.Forms.TreeNode treeNode769 = new System.Windows.Forms.TreeNode("Linear and radial gradient methods for shapes, drawings and background");
            System.Windows.Forms.TreeNode treeNode770 = new System.Windows.Forms.TreeNode("BackgroundImage method to set the background added");
            System.Windows.Forms.TreeNode treeNode771 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode769,
            treeNode770});
            System.Windows.Forms.TreeNode treeNode772 = new System.Windows.Forms.TreeNode("Version 1.0.0.44", new System.Windows.Forms.TreeNode[] {
            treeNode766,
            treeNode768,
            treeNode771});
            System.Windows.Forms.TreeNode treeNode773 = new System.Windows.Forms.TreeNode("AddScrollBars method added for the GraphicsWindow");
            System.Windows.Forms.TreeNode treeNode774 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode773});
            System.Windows.Forms.TreeNode treeNode775 = new System.Windows.Forms.TreeNode("Version 1.0.0.43", new System.Windows.Forms.TreeNode[] {
            treeNode774});
            System.Windows.Forms.TreeNode treeNode776 = new System.Windows.Forms.TreeNode("Call Subs as functions with arguments");
            System.Windows.Forms.TreeNode treeNode777 = new System.Windows.Forms.TreeNode("LDCall", new System.Windows.Forms.TreeNode[] {
            treeNode776});
            System.Windows.Forms.TreeNode treeNode778 = new System.Windows.Forms.TreeNode("Version 1.0.0.42", new System.Windows.Forms.TreeNode[] {
            treeNode777});
            System.Windows.Forms.TreeNode treeNode779 = new System.Windows.Forms.TreeNode("Font dialog added");
            System.Windows.Forms.TreeNode treeNode780 = new System.Windows.Forms.TreeNode("Colours dialog moved here from LDColours");
            System.Windows.Forms.TreeNode treeNode781 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode779,
            treeNode780});
            System.Windows.Forms.TreeNode treeNode782 = new System.Windows.Forms.TreeNode("Version 1.0.0.41", new System.Windows.Forms.TreeNode[] {
            treeNode781});
            System.Windows.Forms.TreeNode treeNode783 = new System.Windows.Forms.TreeNode("Controls methods (RichTextBox and TreeView) moved here from LDDialogs");
            System.Windows.Forms.TreeNode treeNode784 = new System.Windows.Forms.TreeNode("WebBrowser, ListBox, ComboBox and CheckBox objects added");
            System.Windows.Forms.TreeNode treeNode785 = new System.Windows.Forms.TreeNode("Some methods renamed");
            System.Windows.Forms.TreeNode treeNode786 = new System.Windows.Forms.TreeNode("LDControls", new System.Windows.Forms.TreeNode[] {
            treeNode783,
            treeNode784,
            treeNode785});
            System.Windows.Forms.TreeNode treeNode787 = new System.Windows.Forms.TreeNode("HighScore method move here");
            System.Windows.Forms.TreeNode treeNode788 = new System.Windows.Forms.TreeNode("LDNetwork", new System.Windows.Forms.TreeNode[] {
            treeNode787});
            System.Windows.Forms.TreeNode treeNode789 = new System.Windows.Forms.TreeNode("SetSize method added");
            System.Windows.Forms.TreeNode treeNode790 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode789});
            System.Windows.Forms.TreeNode treeNode791 = new System.Windows.Forms.TreeNode("Version 1.0.0.40", new System.Windows.Forms.TreeNode[] {
            treeNode786,
            treeNode788,
            treeNode790});
            System.Windows.Forms.TreeNode treeNode792 = new System.Windows.Forms.TreeNode("SelectTreeView method added");
            System.Windows.Forms.TreeNode treeNode793 = new System.Windows.Forms.TreeNode("A currently selected node also registers selection event when it is clicked");
            System.Windows.Forms.TreeNode treeNode794 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode792,
            treeNode793});
            System.Windows.Forms.TreeNode treeNode795 = new System.Windows.Forms.TreeNode("Simple high score web method");
            System.Windows.Forms.TreeNode treeNode796 = new System.Windows.Forms.TreeNode("LDHighScore", new System.Windows.Forms.TreeNode[] {
            treeNode795});
            System.Windows.Forms.TreeNode treeNode797 = new System.Windows.Forms.TreeNode("Version 1.0.0.39", new System.Windows.Forms.TreeNode[] {
            treeNode794,
            treeNode796});
            System.Windows.Forms.TreeNode treeNode798 = new System.Windows.Forms.TreeNode("RichTextBox methods improved");
            System.Windows.Forms.TreeNode treeNode799 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode798});
            System.Windows.Forms.TreeNode treeNode800 = new System.Windows.Forms.TreeNode("Search, Load and Save methods added");
            System.Windows.Forms.TreeNode treeNode801 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode800});
            System.Windows.Forms.TreeNode treeNode802 = new System.Windows.Forms.TreeNode("Version 1.0.0.38", new System.Windows.Forms.TreeNode[] {
            treeNode799,
            treeNode801});
            System.Windows.Forms.TreeNode treeNode803 = new System.Windows.Forms.TreeNode("Depreciated");
            System.Windows.Forms.TreeNode treeNode804 = new System.Windows.Forms.TreeNode("LDWeather", new System.Windows.Forms.TreeNode[] {
            treeNode803});
            System.Windows.Forms.TreeNode treeNode805 = new System.Windows.Forms.TreeNode("Renamed from LDTrig and some more methods added");
            System.Windows.Forms.TreeNode treeNode806 = new System.Windows.Forms.TreeNode("LDMath", new System.Windows.Forms.TreeNode[] {
            treeNode805});
            System.Windows.Forms.TreeNode treeNode807 = new System.Windows.Forms.TreeNode("RichTextBox method added");
            System.Windows.Forms.TreeNode treeNode808 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode807});
            System.Windows.Forms.TreeNode treeNode809 = new System.Windows.Forms.TreeNode("FontList method added");
            System.Windows.Forms.TreeNode treeNode810 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode809});
            System.Windows.Forms.TreeNode treeNode811 = new System.Windows.Forms.TreeNode("Version 1.0.0.37", new System.Windows.Forms.TreeNode[] {
            treeNode804,
            treeNode806,
            treeNode808,
            treeNode810});
            System.Windows.Forms.TreeNode treeNode812 = new System.Windows.Forms.TreeNode("Zip method extended");
            System.Windows.Forms.TreeNode treeNode813 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode812});
            System.Windows.Forms.TreeNode treeNode814 = new System.Windows.Forms.TreeNode("Version 1.0.0.36", new System.Windows.Forms.TreeNode[] {
            treeNode813});
            System.Windows.Forms.TreeNode treeNode815 = new System.Windows.Forms.TreeNode("Collapse and expand treeview nodes method added");
            System.Windows.Forms.TreeNode treeNode816 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode815});
            System.Windows.Forms.TreeNode treeNode817 = new System.Windows.Forms.TreeNode("Version 1.0.0.35", new System.Windows.Forms.TreeNode[] {
            treeNode816});
            System.Windows.Forms.TreeNode treeNode818 = new System.Windows.Forms.TreeNode("Arguments added to Start method");
            System.Windows.Forms.TreeNode treeNode819 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode818});
            System.Windows.Forms.TreeNode treeNode820 = new System.Windows.Forms.TreeNode("Zip compression methods added");
            System.Windows.Forms.TreeNode treeNode821 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode820});
            System.Windows.Forms.TreeNode treeNode822 = new System.Windows.Forms.TreeNode("Version 1.0.0.34", new System.Windows.Forms.TreeNode[] {
            treeNode819,
            treeNode821});
            System.Windows.Forms.TreeNode treeNode823 = new System.Windows.Forms.TreeNode("GWStyle property added");
            System.Windows.Forms.TreeNode treeNode824 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode823});
            System.Windows.Forms.TreeNode treeNode825 = new System.Windows.Forms.TreeNode("TreeView and associated events added");
            System.Windows.Forms.TreeNode treeNode826 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode825});
            System.Windows.Forms.TreeNode treeNode827 = new System.Windows.Forms.TreeNode("Version 1.0.0.33", new System.Windows.Forms.TreeNode[] {
            treeNode824,
            treeNode826});
            System.Windows.Forms.TreeNode treeNode828 = new System.Windows.Forms.TreeNode("Possible end points not plotting bug fixed");
            System.Windows.Forms.TreeNode treeNode829 = new System.Windows.Forms.TreeNode("LDGraph", new System.Windows.Forms.TreeNode[] {
            treeNode828});
            System.Windows.Forms.TreeNode treeNode830 = new System.Windows.Forms.TreeNode("Version 1.0.0.32", new System.Windows.Forms.TreeNode[] {
            treeNode829});
            System.Windows.Forms.TreeNode treeNode831 = new System.Windows.Forms.TreeNode("Activated event and Active property addded");
            System.Windows.Forms.TreeNode treeNode832 = new System.Windows.Forms.TreeNode("LDWindows", new System.Windows.Forms.TreeNode[] {
            treeNode831});
            System.Windows.Forms.TreeNode treeNode833 = new System.Windows.Forms.TreeNode("Version 1.0.0.31", new System.Windows.Forms.TreeNode[] {
            treeNode832});
            System.Windows.Forms.TreeNode treeNode834 = new System.Windows.Forms.TreeNode("Create multiple GraphicsWindows");
            System.Windows.Forms.TreeNode treeNode835 = new System.Windows.Forms.TreeNode("LDWindows", new System.Windows.Forms.TreeNode[] {
            treeNode834});
            System.Windows.Forms.TreeNode treeNode836 = new System.Windows.Forms.TreeNode("Version 1.0.0.30", new System.Windows.Forms.TreeNode[] {
            treeNode835});
            System.Windows.Forms.TreeNode treeNode837 = new System.Windows.Forms.TreeNode("Email sending method");
            System.Windows.Forms.TreeNode treeNode838 = new System.Windows.Forms.TreeNode("LDMail", new System.Windows.Forms.TreeNode[] {
            treeNode837});
            System.Windows.Forms.TreeNode treeNode839 = new System.Windows.Forms.TreeNode("Add and Multiply methods bug fixed");
            System.Windows.Forms.TreeNode treeNode840 = new System.Windows.Forms.TreeNode("Image statistics combined into one method");
            System.Windows.Forms.TreeNode treeNode841 = new System.Windows.Forms.TreeNode("Histogram method added");
            System.Windows.Forms.TreeNode treeNode842 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode839,
            treeNode840,
            treeNode841});
            System.Windows.Forms.TreeNode treeNode843 = new System.Windows.Forms.TreeNode("Version 1.0.0.29", new System.Windows.Forms.TreeNode[] {
            treeNode838,
            treeNode842});
            System.Windows.Forms.TreeNode treeNode844 = new System.Windows.Forms.TreeNode("SnapshotToImageList method added");
            System.Windows.Forms.TreeNode treeNode845 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode844});
            System.Windows.Forms.TreeNode treeNode846 = new System.Windows.Forms.TreeNode("ImageList image manipulation methods");
            System.Windows.Forms.TreeNode treeNode847 = new System.Windows.Forms.TreeNode("LDImage", new System.Windows.Forms.TreeNode[] {
            treeNode846});
            System.Windows.Forms.TreeNode treeNode848 = new System.Windows.Forms.TreeNode("Version 1.0.0.28", new System.Windows.Forms.TreeNode[] {
            treeNode845,
            treeNode847});
            System.Windows.Forms.TreeNode treeNode849 = new System.Windows.Forms.TreeNode("SortIndex bugfix for null values");
            System.Windows.Forms.TreeNode treeNode850 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode849});
            System.Windows.Forms.TreeNode treeNode851 = new System.Windows.Forms.TreeNode("SnapshotToFile bug fixed");
            System.Windows.Forms.TreeNode treeNode852 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode851});
            System.Windows.Forms.TreeNode treeNode853 = new System.Windows.Forms.TreeNode("Version 1.0.0.27", new System.Windows.Forms.TreeNode[] {
            treeNode850,
            treeNode852});
            System.Windows.Forms.TreeNode treeNode854 = new System.Windows.Forms.TreeNode("SortIndex method added");
            System.Windows.Forms.TreeNode treeNode855 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode854});
            System.Windows.Forms.TreeNode treeNode856 = new System.Windows.Forms.TreeNode("Web based weather report data added");
            System.Windows.Forms.TreeNode treeNode857 = new System.Windows.Forms.TreeNode("LDWeather", new System.Windows.Forms.TreeNode[] {
            treeNode856});
            System.Windows.Forms.TreeNode treeNode858 = new System.Windows.Forms.TreeNode("DataReceived event added");
            System.Windows.Forms.TreeNode treeNode859 = new System.Windows.Forms.TreeNode("LDCommPort", new System.Windows.Forms.TreeNode[] {
            treeNode858});
            System.Windows.Forms.TreeNode treeNode860 = new System.Windows.Forms.TreeNode("Version 1.0.0.26", new System.Windows.Forms.TreeNode[] {
            treeNode855,
            treeNode857,
            treeNode859});
            System.Windows.Forms.TreeNode treeNode861 = new System.Windows.Forms.TreeNode("Speech recognition added");
            System.Windows.Forms.TreeNode treeNode862 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode861});
            System.Windows.Forms.TreeNode treeNode863 = new System.Windows.Forms.TreeNode("Version 1.0.0.25", new System.Windows.Forms.TreeNode[] {
            treeNode862});
            System.Windows.Forms.TreeNode treeNode864 = new System.Windows.Forms.TreeNode("More methods added and some internal code optimised");
            System.Windows.Forms.TreeNode treeNode865 = new System.Windows.Forms.TreeNode("LDArray & LDMatrix", new System.Windows.Forms.TreeNode[] {
            treeNode864});
            System.Windows.Forms.TreeNode treeNode866 = new System.Windows.Forms.TreeNode("KeyDown method added");
            System.Windows.Forms.TreeNode treeNode867 = new System.Windows.Forms.TreeNode("LDUtilities", new System.Windows.Forms.TreeNode[] {
            treeNode866});
            System.Windows.Forms.TreeNode treeNode868 = new System.Windows.Forms.TreeNode("GetAllShapesAt method added");
            System.Windows.Forms.TreeNode treeNode869 = new System.Windows.Forms.TreeNode("Overlap method for ellipse and rectangle combinations added");
            System.Windows.Forms.TreeNode treeNode870 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode868,
            treeNode869});
            System.Windows.Forms.TreeNode treeNode871 = new System.Windows.Forms.TreeNode("Version 1.0.0.24", new System.Windows.Forms.TreeNode[] {
            treeNode865,
            treeNode867,
            treeNode870});
            System.Windows.Forms.TreeNode treeNode872 = new System.Windows.Forms.TreeNode("OpenFile and SaveFile dialogs added");
            System.Windows.Forms.TreeNode treeNode873 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode872});
            System.Windows.Forms.TreeNode treeNode874 = new System.Windows.Forms.TreeNode("Matrix methods, for example to solve linear equations");
            System.Windows.Forms.TreeNode treeNode875 = new System.Windows.Forms.TreeNode("LDMatrix", new System.Windows.Forms.TreeNode[] {
            treeNode874});
            System.Windows.Forms.TreeNode treeNode876 = new System.Windows.Forms.TreeNode("Version 1.0.0.23", new System.Windows.Forms.TreeNode[] {
            treeNode873,
            treeNode875});
            System.Windows.Forms.TreeNode treeNode877 = new System.Windows.Forms.TreeNode("Sorting method added");
            System.Windows.Forms.TreeNode treeNode878 = new System.Windows.Forms.TreeNode("LDArray", new System.Windows.Forms.TreeNode[] {
            treeNode877});
            System.Windows.Forms.TreeNode treeNode879 = new System.Windows.Forms.TreeNode("Version 1.0.0.22", new System.Windows.Forms.TreeNode[] {
            treeNode878});
            System.Windows.Forms.TreeNode treeNode880 = new System.Windows.Forms.TreeNode("Velocity Threshold setting added");
            System.Windows.Forms.TreeNode treeNode881 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode880});
            System.Windows.Forms.TreeNode treeNode882 = new System.Windows.Forms.TreeNode("Version 1.0.0.21", new System.Windows.Forms.TreeNode[] {
            treeNode881});
            System.Windows.Forms.TreeNode treeNode883 = new System.Windows.Forms.TreeNode("SetDamping method added");
            System.Windows.Forms.TreeNode treeNode884 = new System.Windows.Forms.TreeNode("LDPhysics", new System.Windows.Forms.TreeNode[] {
            treeNode883});
            System.Windows.Forms.TreeNode treeNode885 = new System.Windows.Forms.TreeNode("Version 1.0.0.20", new System.Windows.Forms.TreeNode[] {
            treeNode884});
            System.Windows.Forms.TreeNode treeNode886 = new System.Windows.Forms.TreeNode("Instrument name can be obtained from its number");
            System.Windows.Forms.TreeNode treeNode887 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode886});
            System.Windows.Forms.TreeNode treeNode888 = new System.Windows.Forms.TreeNode("Version 1.0.0.19", new System.Windows.Forms.TreeNode[] {
            treeNode887});
            System.Windows.Forms.TreeNode treeNode889 = new System.Windows.Forms.TreeNode("Calendar uses MS visual styles if available (better calendar, but no colours)");
            System.Windows.Forms.TreeNode treeNode890 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode889});
            System.Windows.Forms.TreeNode treeNode891 = new System.Windows.Forms.TreeNode("Extends Sounds.PlayMusic to include additional instruments");
            System.Windows.Forms.TreeNode treeNode892 = new System.Windows.Forms.TreeNode("Notes can also be played synchronously (chords)");
            System.Windows.Forms.TreeNode treeNode893 = new System.Windows.Forms.TreeNode("LDMusic", new System.Windows.Forms.TreeNode[] {
            treeNode891,
            treeNode892});
            System.Windows.Forms.TreeNode treeNode894 = new System.Windows.Forms.TreeNode("Version 1.0.0.18", new System.Windows.Forms.TreeNode[] {
            treeNode890,
            treeNode893});
            System.Windows.Forms.TreeNode treeNode895 = new System.Windows.Forms.TreeNode("AnimationPause and AnimationResume methods added");
            System.Windows.Forms.TreeNode treeNode896 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode895});
            System.Windows.Forms.TreeNode treeNode897 = new System.Windows.Forms.TreeNode("Process list indexed by ID rather than name");
            System.Windows.Forms.TreeNode treeNode898 = new System.Windows.Forms.TreeNode("LDProcess", new System.Windows.Forms.TreeNode[] {
            treeNode897});
            System.Windows.Forms.TreeNode treeNode899 = new System.Windows.Forms.TreeNode("Version 1.0.0.17", new System.Windows.Forms.TreeNode[] {
            treeNode896,
            treeNode898});
            System.Windows.Forms.TreeNode treeNode900 = new System.Windows.Forms.TreeNode("More effects added");
            System.Windows.Forms.TreeNode treeNode901 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode900});
            System.Windows.Forms.TreeNode treeNode902 = new System.Windows.Forms.TreeNode("Add or change an image on a button or image shape");
            System.Windows.Forms.TreeNode treeNode903 = new System.Windows.Forms.TreeNode("Add an animated gif or tiled image");
            System.Windows.Forms.TreeNode treeNode904 = new System.Windows.Forms.TreeNode("LDShapes", new System.Windows.Forms.TreeNode[] {
            treeNode902,
            treeNode903});
            System.Windows.Forms.TreeNode treeNode905 = new System.Windows.Forms.TreeNode("Version 1.0.0.16", new System.Windows.Forms.TreeNode[] {
            treeNode901,
            treeNode904});
            System.Windows.Forms.TreeNode treeNode906 = new System.Windows.Forms.TreeNode("A webcam object for the GraphicsWindow, including a picture taking function");
            System.Windows.Forms.TreeNode treeNode907 = new System.Windows.Forms.TreeNode("LDWebCam", new System.Windows.Forms.TreeNode[] {
            treeNode906});
            System.Windows.Forms.TreeNode treeNode908 = new System.Windows.Forms.TreeNode("Version 1.0.0.15", new System.Windows.Forms.TreeNode[] {
            treeNode907});
            System.Windows.Forms.TreeNode treeNode909 = new System.Windows.Forms.TreeNode("Variables may be changed during a debug session");
            System.Windows.Forms.TreeNode treeNode910 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode909});
            System.Windows.Forms.TreeNode treeNode911 = new System.Windows.Forms.TreeNode("Version 1.0.0.14", new System.Windows.Forms.TreeNode[] {
            treeNode910});
            System.Windows.Forms.TreeNode treeNode912 = new System.Windows.Forms.TreeNode("A basic debugging tool");
            System.Windows.Forms.TreeNode treeNode913 = new System.Windows.Forms.TreeNode("LDDebug", new System.Windows.Forms.TreeNode[] {
            treeNode912});
            System.Windows.Forms.TreeNode treeNode914 = new System.Windows.Forms.TreeNode("Version 1.0.0.13", new System.Windows.Forms.TreeNode[] {
            treeNode913});
            System.Windows.Forms.TreeNode treeNode915 = new System.Windows.Forms.TreeNode("Methods to convert between HSL and RGB");
            System.Windows.Forms.TreeNode treeNode916 = new System.Windows.Forms.TreeNode("Method to set colour opacity");
            System.Windows.Forms.TreeNode treeNode917 = new System.Windows.Forms.TreeNode("Methods to get R, G, B and H, S, L for a colour");
            System.Windows.Forms.TreeNode treeNode918 = new System.Windows.Forms.TreeNode("LDColours", new System.Windows.Forms.TreeNode[] {
            treeNode915,
            treeNode916,
            treeNode917});
            System.Windows.Forms.TreeNode treeNode919 = new System.Windows.Forms.TreeNode("Methods to add and subtract dates and times");
            System.Windows.Forms.TreeNode treeNode920 = new System.Windows.Forms.TreeNode("LDDateTime", new System.Windows.Forms.TreeNode[] {
            treeNode919});
            System.Windows.Forms.TreeNode treeNode921 = new System.Windows.Forms.TreeNode("Waiting overlay, Calendar and About popups");
            System.Windows.Forms.TreeNode treeNode922 = new System.Windows.Forms.TreeNode("Tooltips");
            System.Windows.Forms.TreeNode treeNode923 = new System.Windows.Forms.TreeNode("LDDialogs", new System.Windows.Forms.TreeNode[] {
            treeNode921,
            treeNode922});
            System.Windows.Forms.TreeNode treeNode924 = new System.Windows.Forms.TreeNode("File change event");
            System.Windows.Forms.TreeNode treeNode925 = new System.Windows.Forms.TreeNode("LDEvents", new System.Windows.Forms.TreeNode[] {
            treeNode924});
            System.Windows.Forms.TreeNode treeNode926 = new System.Windows.Forms.TreeNode("Version 1.0.0.12", new System.Windows.Forms.TreeNode[] {
            treeNode918,
            treeNode920,
            treeNode923,
            treeNode925});
            System.Windows.Forms.TreeNode treeNode927 = new System.Windows.Forms.TreeNode("Methods to sort arrays by index or value");
            System.Windows.Forms.TreeNode treeNode928 = new System.Windows.Forms.TreeNode("Sorting by number and character strings");
            System.Windows.Forms.TreeNode treeNode929 = new System.Windows.Forms.TreeNode("LDSort", new System.Windows.Forms.TreeNode[] {
            treeNode927,
            treeNode928});
            System.Windows.Forms.TreeNode treeNode930 = new System.Windows.Forms.TreeNode("Statistics on any array and distribution generation");
            System.Windows.Forms.TreeNode treeNode931 = new System.Windows.Forms.TreeNode("Includes integration and differentiation to convert between PDF and CDF");
            System.Windows.Forms.TreeNode treeNode932 = new System.Windows.Forms.TreeNode("Normal, Binomial, Traingular and Uniform distributions");
            System.Windows.Forms.TreeNode treeNode933 = new System.Windows.Forms.TreeNode("LDStatistics", new System.Windows.Forms.TreeNode[] {
            treeNode930,
            treeNode931,
            treeNode932});
            System.Windows.Forms.TreeNode treeNode934 = new System.Windows.Forms.TreeNode("Voice and volume added");
            System.Windows.Forms.TreeNode treeNode935 = new System.Windows.Forms.TreeNode("LDSpeech", new System.Windows.Forms.TreeNode[] {
            treeNode934});
            System.Windows.Forms.TreeNode treeNode936 = new System.Windows.Forms.TreeNode("Version 1.0.0.11", new System.Windows.Forms.TreeNode[] {
            treeNode929,
            treeNode933,
            treeNode935});
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
            treeNode1.Name = "Node1";
            treeNode1.Text = "Read method extended to read unindexed lines to 1D array";
            treeNode2.Name = "Node0";
            treeNode2.Text = "LDFastArray";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Version 1.2.15.0";
            treeNode4.Name = "Node2";
            treeNode4.Text = "Possible unclosed zip conflicts fixed";
            treeNode5.Name = "Node1";
            treeNode5.Text = "LDZip";
            treeNode6.Name = "Node5";
            treeNode6.Text = "LDStopwatch object added to accurately measure time intervals";
            treeNode7.Name = "Node3";
            treeNode7.Text = "LDStopwatch";
            treeNode8.Name = "Node7";
            treeNode8.Text = "LDTimer object added for additional timers";
            treeNode9.Name = "Node6";
            treeNode9.Text = "LDTimer";
            treeNode10.Name = "Node1";
            treeNode10.Text = "Speedup of selected critical performance code listed below";
            treeNode11.Name = "Node2";
            treeNode11.Text = "1) LDShapes.FastMove";
            treeNode12.Name = "Node3";
            treeNode12.Text = "2) LDPhysics graphical updates";
            treeNode13.Name = "Node4";
            treeNode13.Text = "3) LDImage and LDwebCam image processing";
            treeNode14.Name = "Node6";
            treeNode14.Text = "4) LDFastShapes";
            treeNode15.Name = "Node7";
            treeNode15.Text = "5) LDGraphicsWindow.PauseUpdates and LDGraphicsWindow.ResumeUpdates";
            treeNode16.Name = "Node8";
            treeNode16.Text = "6) Selected LD3DView visual updates";
            treeNode17.Name = "Node9";
            treeNode17.Text = "7) LDEffect";
            treeNode18.Name = "Node10";
            treeNode18.Text = "8) LDGraph";
            treeNode19.Name = "Node11";
            treeNode19.Text = "9) LDShapes animated gifs and Overlap methods";
            treeNode20.Name = "Node0";
            treeNode20.Text = "General";
            treeNode21.Name = "Node1";
            treeNode21.Text = "A new 1D, 2D and 3D and higher dimension array with fast access and variable dime" +
    "nsioning";
            treeNode22.Name = "Node2";
            treeNode22.Text = "CSV file read and write";
            treeNode23.Name = "Node0";
            treeNode23.Text = "LDFastArray";
            treeNode24.Name = "Node1";
            treeNode24.Text = "DataViewColAlignment method added";
            treeNode25.Name = "Node2";
            treeNode25.Text = "DataViewSaveAsCSV and DataViewReadFromCSV fixed to work with CSVDeliminator";
            treeNode26.Name = "Node0";
            treeNode26.Text = "RichTextBoxTextTyped event added";
            treeNode27.Name = "Node1";
            treeNode27.Text = "RichTextBoxIndentToTab property added";
            treeNode28.Name = "Node0";
            treeNode28.Text = "LDControls";
            treeNode29.Name = "Node4";
            treeNode29.Text = "OverlapDetail property added";
            treeNode30.Name = "Node3";
            treeNode30.Text = "LDShapes";
            treeNode31.Name = "Node0";
            treeNode31.Text = "Version 1.2.14.0";
            treeNode32.Name = "Node2";
            treeNode32.Text = "TEMP tables allowed for SQLite databases";
            treeNode33.Name = "Node1";
            treeNode33.Text = "LDDataBase";
            treeNode34.Name = "Node1";
            treeNode34.Text = "Convert2Cartesian fixed to be Culture Invariant.";
            treeNode35.Name = "Node0";
            treeNode35.Text = "LDMath";
            treeNode36.Name = "Node1";
            treeNode36.Text = "NormalMap method added for normal map 3D effects";
            treeNode37.Name = "Node2";
            treeNode37.Text = "HeightMap2NormalMap method to create a normal map from a height map";
            treeNode38.Name = "Node5";
            treeNode38.Text = "MakeTransparent method added";
            treeNode39.Name = "Node6";
            treeNode39.Text = "ReplaceColour method added";
            treeNode40.Name = "Node0";
            treeNode40.Text = "To32bitARGB method added (code suggested by Pappa Lapub)";
            treeNode41.Name = "Node0";
            treeNode41.Text = "LDImage";
            treeNode42.Name = "Node4";
            treeNode42.Text = "All image pixel manipulations speeded up";
            treeNode43.Name = "Node7";
            treeNode43.Text = "More Culture Invariace fixes";
            treeNode44.Name = "Node3";
            treeNode44.Text = "General";
            treeNode45.Name = "Node0";
            treeNode45.Text = "Version 1.2.13.0";
            treeNode46.Name = "Node1";
            treeNode46.Text = "Base conversions extended to include bases up to 36";
            treeNode47.Name = "Node0";
            treeNode47.Text = "LDMath";
            treeNode48.Name = "Node3";
            treeNode48.Text = "Updated to new Bing API";
            treeNode49.Name = "Node2";
            treeNode49.Text = "LDSearch";
            treeNode50.Name = "Node1";
            treeNode50.Text = "ShowInTaskbar property added";
            treeNode51.Name = "Node0";
            treeNode51.Text = "LDGraphicsWindow";
            treeNode52.Name = "Node1";
            treeNode52.Text = "ReadCSV and WriteCSV modified to handle \"";
            treeNode53.Name = "Node0";
            treeNode53.Text = "LDFile";
            treeNode54.Name = "Node1";
            treeNode54.Text = "ToArray and FromArray methods added";
            treeNode55.Name = "Node0";
            treeNode55.Text = "LDxml";
            treeNode56.Name = "Node0";
            treeNode56.Text = "Version 1.2.12.0";
            treeNode57.Name = "Node2";
            treeNode57.Text = "DataViewColumnWidths method added";
            treeNode58.Name = "Node3";
            treeNode58.Text = "DataViewRowColours method added";
            treeNode59.Name = "Node1";
            treeNode59.Text = "LDControls";
            treeNode60.Name = "Node1";
            treeNode60.Text = "Various obscure or experimental methods made visible to intelliseense. (LD3DView," +
    " LDBlueTooth, LDScrolBars, LDShapes)";
            treeNode61.Name = "Node0";
            treeNode61.Text = "General";
            treeNode62.Name = "Node1";
            treeNode62.Text = "SetCentre method added";
            treeNode63.Name = "Node4";
            treeNode63.Text = "A 3rd rotation added";
            treeNode64.Name = "Node3";
            treeNode64.Text = "BoundingBox method added";
            treeNode65.Name = "Node0";
            treeNode65.Text = "LD3DView";
            treeNode66.Name = "Node3";
            treeNode66.Text = "Reverted to earlier MySQL version to handle old password encryption";
            treeNode67.Name = "Node2";
            treeNode67.Text = "LDDatabase";
            treeNode68.Name = "Node1";
            treeNode68.Text = "PlayMusic2 method added";
            treeNode69.Name = "Node2";
            treeNode69.Text = "Channel parameter added";
            treeNode70.Name = "Node0";
            treeNode70.Text = "LDMusic";
            treeNode71.Name = "Node0";
            treeNode71.Text = "Version 1.2.11.0";
            treeNode72.Name = "Node1";
            treeNode72.Text = "SetButtonStyle method added";
            treeNode73.Name = "Node0";
            treeNode73.Text = "LDControls";
            treeNode74.Name = "Node1";
            treeNode74.Text = "Additional geometries added (Cube, Cone, Arrow, Revolute and Rectangle)";
            treeNode75.Name = "Node2";
            treeNode75.Text = "SetBillBoard method added";
            treeNode76.Name = "Node0";
            treeNode76.Text = "GetCameraUpDirection method added";
            treeNode77.Name = "Node1";
            treeNode77.Text = "Gradient brushes can be used";
            treeNode78.Name = "Node2";
            treeNode78.Text = "AutoControl method added";
            treeNode79.Name = "Node0";
            treeNode79.Text = "SpecularExponent property added";
            treeNode80.Name = "Node0";
            treeNode80.Text = "LD3DView";
            treeNode81.Name = "Node1";
            treeNode81.Text = "AddText method to annotate an image with text added";
            treeNode82.Name = "Node0";
            treeNode82.Text = "LDImage";
            treeNode83.Name = "Node4";
            treeNode83.Text = "BrushText for text on a brush added";
            treeNode84.Name = "Node0";
            treeNode84.Text = "Skew shapes method added";
            treeNode85.Name = "Node3";
            treeNode85.Text = "LDShapes";
            treeNode86.Name = "Node0";
            treeNode86.Text = "Version 1.2.10.0";
            treeNode87.Name = "Node1";
            treeNode87.Text = "A general purpose unit system, see LDUnits.sb sample";
            treeNode88.Name = "Node0";
            treeNode88.Text = "LDUnits";
            treeNode89.Name = "Node1";
            treeNode89.Text = "Possible issue with FixSigFig fixed";
            treeNode90.Name = "Node0";
            treeNode90.Text = "LDMath";
            treeNode91.Name = "Node3";
            treeNode91.Text = "GetIndex method added (for SB arrays)";
            treeNode92.Name = "Node2";
            treeNode92.Text = "LDArray";
            treeNode93.Name = "Node5";
            treeNode93.Text = "Resize mode property added";
            treeNode94.Name = "Node6";
            treeNode94.Text = "Icon sets SB icon if property set to \"SB\"";
            treeNode95.Name = "Node4";
            treeNode95.Text = "LDGraphicsWindow";
            treeNode96.Name = "Node8";
            treeNode96.Text = "Possible threading error with DataViewSetRow and DataViewSetValue fixed";
            treeNode97.Name = "Node9";
            treeNode97.Text = "DataViewAllowUserEntry method added";
            treeNode98.Name = "Node7";
            treeNode98.Text = "LDControls";
            treeNode99.Name = "Node0";
            treeNode99.Text = "Version 1.2.9.0";
            treeNode100.Name = "Node1";
            treeNode100.Text = "New extended math object, starting with FFT";
            treeNode101.Name = "Node0";
            treeNode101.Text = "LDMathX";
            treeNode102.Name = "Node1";
            treeNode102.Text = "AddListBox and ListBoxContent can accept LDList and LDArray data";
            treeNode103.Name = "Node0";
            treeNode103.Text = "LDControls";
            treeNode104.Name = "Node3";
            treeNode104.Text = "CreateFromIndices and CreateFromValues methods added";
            treeNode105.Name = "Node2";
            treeNode105.Text = "LDArray";
            treeNode106.Name = "Node5";
            treeNode106.Text = "CreateFromIndices and CreateFromValues methods added";
            treeNode107.Name = "Node4";
            treeNode107.Text = "LDList";
            treeNode108.Name = "Node0";
            treeNode108.Text = "Version 1.2.8.0";
            treeNode109.Name = "Node2";
            treeNode109.Text = "Error handling, additional settings and multiple ports supported";
            treeNode110.Name = "Node1";
            treeNode110.Text = "LDCommPort";
            treeNode111.Name = "Node1";
            treeNode111.Text = "Posterise, Hue, Saturation and Lightness effects added";
            treeNode112.Name = "Node1";
            treeNode112.Text = "More image effects, OilPaint, Charcoal, Sketch, Cartoon, Edge, Accent, Sepia, Noi" +
    "seRemoval and Solarise added";
            treeNode113.Name = "Node0";
            treeNode113.Text = "LDImage and LDWebCam";
            treeNode114.Name = "Node1";
            treeNode114.Text = "Bitwise operations object added";
            treeNode115.Name = "Node0";
            treeNode115.Text = "LDBits";
            treeNode116.Name = "Node1";
            treeNode116.Text = "Extended text encoding property added";
            treeNode117.Name = "Node0";
            treeNode117.Text = "TextWindow colours can be changed";
            treeNode118.Name = "Node0";
            treeNode118.Text = "LDTextWindow";
            treeNode119.Name = "Node1";
            treeNode119.Text = "GetWorkingImagePixelARGB method added";
            treeNode120.Name = "Node0";
            treeNode120.Text = "LDImage";
            treeNode121.Name = "Node1";
            treeNode121.Text = "RasteriseTurtleLines method added";
            treeNode122.Name = "Node0";
            treeNode122.Text = "LDShapes";
            treeNode123.Name = "Node0";
            treeNode123.Text = "Version 1.2.7.0";
            treeNode124.Name = "Node1";
            treeNode124.Text = "Confirm dialog is given focus above GraphicsWindow";
            treeNode125.Name = "Node0";
            treeNode125.Text = "LDDialogs";
            treeNode126.Name = "Node1";
            treeNode126.Text = "Read and write json model scripts compatible with R.U.B.E.";
            treeNode127.Name = "Node2";
            treeNode127.Text = "ToggleSensor added";
            treeNode128.Name = "Node0";
            treeNode128.Text = "LDPhysics";
            treeNode129.Name = "Node1";
            treeNode129.Text = "Allow multiple copies of the webcam image";
            treeNode130.Name = "Node0";
            treeNode130.Text = "LDWebCam";
            treeNode131.Name = "Node1";
            treeNode131.Text = "Fast pixel level image manipulation using a temporary working image added";
            treeNode132.Name = "Node0";
            treeNode132.Text = "MetaData method added";
            treeNode133.Name = "Node0";
            treeNode133.Text = "LDImage";
            treeNode134.Name = "Node0";
            treeNode134.Text = "Version 1.2.6.0";
            treeNode135.Name = "Node2";
            treeNode135.Text = "FixSigFig and FixDecimal methods added";
            treeNode136.Name = "Node3";
            treeNode136.Text = "MinNumber and MaxNumber properties added";
            treeNode137.Name = "Node1";
            treeNode137.Text = "LDMath";
            treeNode138.Name = "Node1";
            treeNode138.Text = "SliderMaximum property added";
            treeNode139.Name = "Node0";
            treeNode139.Text = "LDControls";
            treeNode140.Name = "Node1";
            treeNode140.Text = "ZoomAll method added";
            treeNode141.Name = "Node0";
            treeNode141.Text = "LDShapes";
            treeNode142.Name = "Node1";
            treeNode142.Text = "Reposition methods and properties added";
            treeNode143.Name = "Node0";
            treeNode143.Text = "LDGraphicsWindow";
            treeNode144.Name = "Node1";
            treeNode144.Text = "GetImagePixels and SetImagePixels methods added";
            treeNode145.Name = "Node0";
            treeNode145.Text = "LDImage";
            treeNode146.Name = "Node1";
            treeNode146.Text = "MouseScroll parameter added";
            treeNode147.Name = "Node0";
            treeNode147.Text = "LDScrollBars";
            treeNode148.Name = "Node0";
            treeNode148.Text = "Version 1.2.5.0";
            treeNode149.Name = "Node0";
            treeNode149.Text = "New object added (previously a separate extension)";
            treeNode150.Name = "Node1";
            treeNode150.Text = "Async, Loop, Volume and Pan properties added";
            treeNode151.Name = "Node2";
            treeNode151.Text = "PlayWave, PlayHarmonics and PlayWavFile methods added";
            treeNode152.Name = "Node1";
            treeNode152.Text = "LDWaveForm";
            treeNode153.Name = "Node1";
            treeNode153.Text = "New object added to get input from gamepads or joysticks";
            treeNode154.Name = "Node0";
            treeNode154.Text = "LDController";
            treeNode155.Name = "Node1";
            treeNode155.Text = "RayCast method added";
            treeNode156.Name = "Node0";
            treeNode156.Text = "LDPhysics";
            treeNode157.Name = "Node0";
            treeNode157.Text = "Version 1.2.4.0";
            treeNode158.Name = "Node2";
            treeNode158.Text = "New object to apply effects to any shape or control";
            treeNode159.Name = "Node1";
            treeNode159.Text = "LDEffects";
            treeNode160.Name = "Node1";
            treeNode160.Text = "New object to add arrow, arc, polygons and callout shapes";
            treeNode161.Name = "Node0";
            treeNode161.Text = "LDFigures";
            treeNode162.Name = "Node1";
            treeNode162.Text = "SetGroup method added";
            treeNode163.Name = "Node2";
            treeNode163.Text = "GetContacts method added";
            treeNode164.Name = "Node0";
            treeNode164.Text = "GetAllShapesAt method added";
            treeNode165.Name = "Node0";
            treeNode165.Text = "LDPhysics";
            treeNode166.Name = "Node2";
            treeNode166.Text = "SetImage handles images with transparency";
            treeNode167.Name = "Node0";
            treeNode167.Text = "ImageTransparency property added to switch how image transparencies are handled";
            treeNode168.Name = "Node1";
            treeNode168.Text = "LDClipboard";
            treeNode169.Name = "Node0";
            treeNode169.Text = "Version 1.2.3.0";
            treeNode170.Name = "Node2";
            treeNode170.Text = "BrushGradient can use \"R\" for radial orientation";
            treeNode171.Name = "Node1";
            treeNode171.Text = "LDShapes";
            treeNode172.Name = "Node4";
            treeNode172.Text = "Unnecessary file existance checks removed from GetFolder, GetFile and GetExtensio" +
    "n";
            treeNode173.Name = "Node3";
            treeNode173.Text = "LDFile";
            treeNode174.Name = "Node6";
            treeNode174.Text = "NewImage method added";
            treeNode175.Name = "Node5";
            treeNode175.Text = "LDImage";
            treeNode176.Name = "Node1";
            treeNode176.Text = "SetStartupPosition method added to position dialogs";
            treeNode177.Name = "Node0";
            treeNode177.Text = "LDDialogs";
            treeNode178.Name = "Node1";
            treeNode178.Text = "AddSeriesHitogram renamed AddSeriesHistogram";
            treeNode179.Name = "Node0";
            treeNode179.Text = "LDGraph";
            treeNode180.Name = "Node0";
            treeNode180.Text = "Version 1.2.2.0";
            treeNode181.Name = "Node2";
            treeNode181.Text = "Recompiled for Small Basic version 1.2";
            treeNode182.Name = "Node1";
            treeNode182.Text = "Version 1.2";
            treeNode183.Name = "Node0";
            treeNode183.Text = "Version 1.2.0.1";
            treeNode184.Name = "Node2";
            treeNode184.Text = "OpenFile and SaveFile may take an array of extensions";
            treeNode185.Name = "Node1";
            treeNode185.Text = "LDDialogs";
            treeNode186.Name = "Node1";
            treeNode186.Text = "Logical operations object added";
            treeNode187.Name = "Node0";
            treeNode187.Text = "LDLogic";
            treeNode188.Name = "Node4";
            treeNode188.Text = "CurrentCulture property added";
            treeNode189.Name = "Node3";
            treeNode189.Text = "LDUtilities";
            treeNode190.Name = "Node6";
            treeNode190.Text = "Evaluate3, a method to evaluate to a boolean added";
            treeNode191.Name = "Node5";
            treeNode191.Text = "LDMath";
            treeNode192.Name = "Node0";
            treeNode192.Text = "Version 1.1.0.8";
            treeNode193.Name = "Node1";
            treeNode193.Text = "Scrolling to selected nodes improved for dataview with custom column type (e.g.co" +
    "mbobox)";
            treeNode194.Name = "Node0";
            treeNode194.Text = "LDControls";
            treeNode195.Name = "Node1";
            treeNode195.Text = "Methods added to add and remove nodes and save xml file";
            treeNode196.Name = "Node0";
            treeNode196.Text = "LDxml";
            treeNode197.Name = "Node1";
            treeNode197.Text = "MusicPlayTime moved from LDFile";
            treeNode198.Name = "Node0";
            treeNode198.Text = "LDSound";
            treeNode199.Name = "Node0";
            treeNode199.Text = "Version 1.1.0.7";
            treeNode200.Name = "Node4";
            treeNode200.Text = "SplitImage method added";
            treeNode201.Name = "Node3";
            treeNode201.Text = "LDImage";
            treeNode202.Name = "Node6";
            treeNode202.Text = "EditTable and SaveTable methods added";
            treeNode203.Name = "Node5";
            treeNode203.Text = "LDDatabse";
            treeNode204.Name = "Node2";
            treeNode204.Text = "DataView control and methods added";
            treeNode205.Name = "Node1";
            treeNode205.Text = "LDControls";
            treeNode206.Name = "Node2";
            treeNode206.Text = "Version 1.1.0.6";
            treeNode207.Name = "Node2";
            treeNode207.Text = "Exists modified to check for directory as well as file";
            treeNode208.Name = "Node3";
            treeNode208.Text = "GetAllDirectories modified to omit directories without sufficient permissions";
            treeNode209.Name = "Node1";
            treeNode209.Text = "LDFile";
            treeNode210.Name = "Node5";
            treeNode210.Text = "Instrumenting - Index was outside the bounds of the array - bug fixed";
            treeNode211.Name = "Node6";
            treeNode211.Text = "Bug fixed returning to Small Basic IDE if application ends before debug window is" +
    " closed";
            treeNode212.Name = "Node9";
            treeNode212.Text = "Conditonal break point added";
            treeNode213.Name = "Node0";
            treeNode213.Text = "Step over button added";
            treeNode214.Name = "Node4";
            treeNode214.Text = "LDDebug";
            treeNode215.Name = "Node8";
            treeNode215.Text = "ExitOnClose works with LDWindows (multiple windows)";
            treeNode216.Name = "Node7";
            treeNode216.Text = "LDGraphicsWindow";
            treeNode217.Name = "Node1";
            treeNode217.Text = "Object added to save image, sound, file and text/varables to a resources file";
            treeNode218.Name = "Node0";
            treeNode218.Text = "LDResources";
            treeNode219.Name = "Node0";
            treeNode219.Text = "Version 1.1.0.5";
            treeNode220.Name = "Node2";
            treeNode220.Text = "ClipboardChanged event added";
            treeNode221.Name = "Node1";
            treeNode221.Text = "LDClipboard";
            treeNode222.Name = "Node1";
            treeNode222.Text = "RenameFile, RenameDirctory, CopyDirectory and GetAllDirectories methods added";
            treeNode223.Name = "Node0";
            treeNode223.Text = "LDFile";
            treeNode224.Name = "Node3";
            treeNode224.Text = "SetActive method added";
            treeNode225.Name = "Node2";
            treeNode225.Text = "LDGraphicsWindow";
            treeNode226.Name = "Node1";
            treeNode226.Text = "Parse xml file nodes";
            treeNode227.Name = "Node0";
            treeNode227.Text = "LDxml";
            treeNode228.Name = "Node3";
            treeNode228.Text = "\"FAILURE\" replaced by \"FAILED\" as a return message for consistency";
            treeNode229.Name = "Node2";
            treeNode229.Text = "General";
            treeNode230.Name = "Node0";
            treeNode230.Text = "Version 1.1.0.4";
            treeNode231.Name = "Node2";
            treeNode231.Text = "WakeAll method addded";
            treeNode232.Name = "Node1";
            treeNode232.Text = "LDPhysics";
            treeNode233.Name = "Node1";
            treeNode233.Text = "Clipboard methods added";
            treeNode234.Name = "Node0";
            treeNode234.Text = "LDClipboard";
            treeNode235.Name = "Node0";
            treeNode235.Text = "Version 1.1.0.3";
            treeNode236.Name = "Node6";
            treeNode236.Text = "SizeNWSE cursor added";
            treeNode237.Name = "Node5";
            treeNode237.Text = "LDCursors";
            treeNode238.Name = "Node8";
            treeNode238.Text = "ScaleAxisX & ScaleAxisY modified for better control";
            treeNode239.Name = "Node7";
            treeNode239.Text = "LDGraph";
            treeNode240.Name = "Node1";
            treeNode240.Text = "SQLite updated for .Net 4.5";
            treeNode241.Name = "Node0";
            treeNode241.Text = "LDDataBase";
            treeNode242.Name = "Node4";
            treeNode242.Text = "Version 1.1.0.2";
            treeNode243.Name = "Node3";
            treeNode243.Text = "Recompiled for Small Basic version 1.1";
            treeNode244.Name = "Node2";
            treeNode244.Text = "Version 1.1";
            treeNode245.Name = "Node0";
            treeNode245.Text = "Version 1.1.0.1";
            treeNode246.Name = "Node12";
            treeNode246.Text = "RichTextBoxCaseSensitive parameter added";
            treeNode247.Name = "Node13";
            treeNode247.Text = "RichTextBoxMargins method added";
            treeNode248.Name = "Node0";
            treeNode248.Text = "ListBoxSelectionMode added for multiple list box selection";
            treeNode249.Name = "Node1";
            treeNode249.Text = "ListBoxGetSelected and ListBoxSelect modified for multiple selection modes";
            treeNode250.Name = "Node11";
            treeNode250.Text = "LDControls";
            treeNode251.Name = "Node3";
            treeNode251.Text = "Error reporting added";
            treeNode252.Name = "Node4";
            treeNode252.Text = "SetEncoding method added";
            treeNode253.Name = "Node2";
            treeNode253.Text = "LDCommPort";
            treeNode254.Name = "Node6";
            treeNode254.Text = "AddSeries methods replace an existing series if the label name is the same";
            treeNode255.Name = "Node7";
            treeNode255.Text = "Export to excel fix for graph with no title";
            treeNode256.Name = "Node5";
            treeNode256.Text = "LDGraph";
            treeNode257.Name = "Node9";
            treeNode257.Text = "Negative restitution option when adding moving shape";
            treeNode258.Name = "Node8";
            treeNode258.Text = "LDPhysics";
            treeNode259.Name = "Node10";
            treeNode259.Text = "Version 1.0.0.133";
            treeNode260.Name = "Node2";
            treeNode260.Text = "Internal improvements to auto messaging";
            treeNode261.Name = "Node9";
            treeNode261.Text = "Name can be set and GetClients method added";
            treeNode262.Name = "Node1";
            treeNode262.Text = "LDClient";
            treeNode263.Name = "Node4";
            treeNode263.Text = "RichTextBoxWord method modified to include mode parameter";
            treeNode264.Name = "Node3";
            treeNode264.Text = "LDControls";
            treeNode265.Name = "Node8";
            treeNode265.Text = "Return message and possible file error fixed for Stop method";
            treeNode266.Name = "Node7";
            treeNode266.Text = "LDSound";
            treeNode267.Name = "Node0";
            treeNode267.Text = "Version 1.0.0.132";
            treeNode268.Name = "Node2";
            treeNode268.Text = "Include and CallInclude methods added to use a pre-compiled file";
            treeNode269.Name = "Node5";
            treeNode269.Text = "Compile method added to compile a Small Basic program";
            treeNode270.Name = "Node1";
            treeNode270.Text = "LDCall";
            treeNode271.Name = "Node4";
            treeNode271.Text = "Methods and code by Pappa Lapub added";
            treeNode272.Name = "Node3";
            treeNode272.Text = "LDShell";
            treeNode273.Name = "Node0";
            treeNode273.Text = "Version 1.0.0.131";
            treeNode274.Name = "Node6";
            treeNode274.Text = "FollowShapeX and FollowShapeY methods added";
            treeNode275.Name = "Node7";
            treeNode275.Text = "BoxShape method added to keep a shape with a region of the GraphicsWindow";
            treeNode276.Name = "Node8";
            treeNode276.Text = "Refactoring of all the pan, follow and box methods";
            treeNode277.Name = "Node6";
            treeNode277.Text = "All input and output coordinates are in world coordinates, apart from GetShapeAt " +
    "which is in screen coordinates";
            treeNode278.Name = "Node8";
            treeNode278.Text = "GetPan method added to convert between world and screen coordinates";
            treeNode279.Name = "Node5";
            treeNode279.Text = "LDPhysics";
            treeNode280.Name = "Node1";
            treeNode280.Text = "UseBinary property added";
            treeNode281.Name = "Node2";
            treeNode281.Text = "DoAsync property and associated completion events added";
            treeNode282.Name = "Node3";
            treeNode282.Text = "Delete method added";
            treeNode283.Name = "Node0";
            treeNode283.Text = "LDftp";
            treeNode284.Name = "Node5";
            treeNode284.Text = "CallAsync method to call any extension method asynchronously added";
            treeNode285.Name = "Node4";
            treeNode285.Text = "LDCall";
            treeNode286.Name = "Node2";
            treeNode286.Text = "SetCursorToEnd also works for RichTextBox";
            treeNode287.Name = "Node1";
            treeNode287.Text = "LDControls";
            treeNode288.Name = "Node4";
            treeNode288.Text = "Version 1.0.0.130";
            treeNode289.Name = "Node2";
            treeNode289.Text = "Evaluate2 method added to behave nicely with the TextWindow";
            treeNode290.Name = "Node1";
            treeNode290.Text = "LDMath";
            treeNode291.Name = "Node1";
            treeNode291.Text = "SetShapeGravity method to alter gravity for individual shapes";
            treeNode292.Name = "Node0";
            treeNode292.Text = "LDPhysics";
            treeNode293.Name = "Node3";
            treeNode293.Text = "Improve PauseUpdate and ResumeUpdates methods";
            treeNode294.Name = "Node2";
            treeNode294.Text = "LDGraphicsWindow";
            treeNode295.Name = "Node1";
            treeNode295.Text = "FTP object methods added";
            treeNode296.Name = "Node0";
            treeNode296.Text = "LDftp";
            treeNode297.Name = "Node3";
            treeNode297.Text = "An existing file is replaced";
            treeNode298.Name = "Node2";
            treeNode298.Text = "LDZip";
            treeNode299.Name = "Node1";
            treeNode299.Text = "Size method added";
            treeNode300.Name = "Node0";
            treeNode300.Text = "LDFile";
            treeNode301.Name = "Node3";
            treeNode301.Text = "DownloadFile method added";
            treeNode302.Name = "Node2";
            treeNode302.Text = "LDNetwork";
            treeNode303.Name = "Node0";
            treeNode303.Text = "Version 1.0.0.129";
            treeNode304.Name = "Node2";
            treeNode304.Text = "Generalised joint connections added";
            treeNode305.Name = "Node0";
            treeNode305.Text = "AddExplosion method added";
            treeNode306.Name = "Node1";
            treeNode306.Text = "LDPhysics";
            treeNode307.Name = "Node1";
            treeNode307.Text = "BrushImage method added and renamed some BrushGradient commands (old methods stil" +
    "l work but depreciated)";
            treeNode308.Name = "Node0";
            treeNode308.Text = "LDShapes";
            treeNode309.Name = "Node0";
            treeNode309.Text = "Version 1.0.0.128";
            treeNode310.Name = "Node2";
            treeNode310.Text = "CheckServer method added";
            treeNode311.Name = "Node1";
            treeNode311.Text = "LDClient";
            treeNode312.Name = "Node1";
            treeNode312.Text = "Default maximum number of objects (proxies) increased from 512 to 1024";
            treeNode313.Name = "Node2";
            treeNode313.Text = "MaxPolygonVertices and MaxProxies properties added";
            treeNode314.Name = "Node3";
            treeNode314.Text = "GetAngle method added";
            treeNode315.Name = "Node4";
            treeNode315.Text = "Top-down tire (to model a car from above) methods added";
            treeNode316.Name = "Node0";
            treeNode316.Text = "LDPhysics";
            treeNode317.Name = "Node0";
            treeNode317.Text = "Version 1.0.0.127";
            treeNode318.Name = "Node7";
            treeNode318.Text = "Bug fixes for Overlap methods";
            treeNode319.Name = "Node6";
            treeNode319.Text = "LDShapes";
            treeNode320.Name = "Node0";
            treeNode320.Text = "Bug fix for multiple numeric sorts";
            treeNode321.Name = "Node9";
            treeNode321.Text = "ByValueWithIndex method added";
            treeNode322.Name = "Node8";
            treeNode322.Text = "LDSort";
            treeNode323.Name = "Node1";
            treeNode323.Text = "LAN method added to get local IP addresses";
            treeNode324.Name = "Node2";
            treeNode324.Text = "Ping method added";
            treeNode325.Name = "Node0";
            treeNode325.Text = "LDNetwork";
            treeNode326.Name = "Node1";
            treeNode326.Text = "LoadSVG method added";
            treeNode327.Name = "Node0";
            treeNode327.Text = "LDImage";
            treeNode328.Name = "Node3";
            treeNode328.Text = "Evaluate method added";
            treeNode329.Name = "Node2";
            treeNode329.Text = "LDMath";
            treeNode330.Name = "Node5";
            treeNode330.Text = "IncludeJScript method added";
            treeNode331.Name = "Node4";
            treeNode331.Text = "LDInline";
            treeNode332.Name = "Node5";
            treeNode332.Text = "Version 1.0.0.126";
            treeNode333.Name = "Node0";
            treeNode333.Text = "Special emphasis on async consistency";
            treeNode334.Name = "Node4";
            treeNode334.Text = "Simplified auto method for multi-player game data transfer";
            treeNode335.Name = "Node9";
            treeNode335.Text = "LDServer and LDClient objects added";
            treeNode336.Name = "Node2";
            treeNode336.Text = "GetWidth and GetHeight methods added";
            treeNode337.Name = "Node1";
            treeNode337.Text = "LDText";
            treeNode338.Name = "Node4";
            treeNode338.Text = "Bing web search";
            treeNode339.Name = "Node3";
            treeNode339.Text = "LDSearch";
            treeNode340.Name = "Node6";
            treeNode340.Text = "KeyDown event handled correctly for arrow keys with hidden scrollbars";
            treeNode341.Name = "Node7";
            treeNode341.Text = "KeyScroll property added";
            treeNode342.Name = "Node5";
            treeNode342.Text = "LDScrollBars";
            treeNode343.Name = "Node9";
            treeNode343.Text = "GetLeft and GetTop methods (work while shape is animating)";
            treeNode344.Name = "Node8";
            treeNode344.Text = "LDShapes";
            treeNode345.Name = "Node1";
            treeNode345.Text = "SaveAs method bug fixed";
            treeNode346.Name = "Node0";
            treeNode346.Text = "LDImage";
            treeNode347.Name = "Node3";
            treeNode347.Text = "Made thread-safe since often used to queue asynchronous events";
            treeNode348.Name = "Node2";
            treeNode348.Text = "LDQueue";
            treeNode349.Name = "Node8";
            treeNode349.Text = "Version 1.0.0.125";
            treeNode350.Name = "Node7";
            treeNode350.Text = "Language translation object added";
            treeNode351.Name = "Node6";
            treeNode351.Text = "LDTranslate";
            treeNode352.Name = "Node5";
            treeNode352.Text = "Version 1.0.0.124";
            treeNode353.Name = "Node1";
            treeNode353.Text = "Mouse screen coordinate conversion parameters added";
            treeNode354.Name = "Node2";
            treeNode354.Text = "MouseX and MouseY added to set cursor in GraphicsWindow";
            treeNode355.Name = "Node0";
            treeNode355.Text = "LDGraphicsWindow";
            treeNode356.Name = "Node4";
            treeNode356.Text = "DPIX and DPIY properties added for screen resolution";
            treeNode357.Name = "Node3";
            treeNode357.Text = "LDUtilities";
            treeNode358.Name = "Node0";
            treeNode358.Text = "Version 1.0.0.123";
            treeNode359.Name = "Node5";
            treeNode359.Text = "ColorMatrix method added";
            treeNode360.Name = "Node0";
            treeNode360.Text = "Rotate method added";
            treeNode361.Name = "Node3";
            treeNode361.Text = "LDImage";
            treeNode362.Name = "Node1";
            treeNode362.Text = "Customisable Pie, Doughnut, Bubble, Bar and Column chart control object added";
            treeNode363.Name = "Node0";
            treeNode363.Text = "LDChart";
            treeNode364.Name = "Node2";
            treeNode364.Text = "Version 1.0.0.122";
            treeNode365.Name = "Node2";
            treeNode365.Text = "EffectGamma added to darken and lighten";
            treeNode366.Name = "Node4";
            treeNode366.Text = "EffectFishEye, EffectBulge and EffectSwirl added";
            treeNode367.Name = "Node3";
            treeNode367.Text = "EffectContrast modified";
            treeNode368.Name = "Node0";
            treeNode368.Text = "GetEffects and EffectDefaults methods added to get list of effects and default pa" +
    "rameters";
            treeNode369.Name = "Node1";
            treeNode369.Text = "LDImage";
            treeNode370.Name = "Node2";
            treeNode370.Text = "Error event added for all extension exceptions";
            treeNode371.Name = "Node1";
            treeNode371.Text = "LDEvents";
            treeNode372.Name = "Node1";
            treeNode372.Text = "Hyperbolic trigonometric functions Sinh, Cosh and Tanh added";
            treeNode373.Name = "Node0";
            treeNode373.Text = "LDMath";
            treeNode374.Name = "Node0";
            treeNode374.Text = "Version 1.0.0.121";
            treeNode375.Name = "Node2";
            treeNode375.Text = "FloodFill transparency effect fixed";
            treeNode376.Name = "Node1";
            treeNode376.Text = "LDGraphicsWindow";
            treeNode377.Name = "Node1";
            treeNode377.Text = "SaveAllVariables and LoadAllVariables methods added";
            treeNode378.Name = "Node0";
            treeNode378.Text = "LDFile";
            treeNode379.Name = "Node1";
            treeNode379.Text = "EffectPixelate added";
            treeNode380.Name = "Node0";
            treeNode380.Text = "LDImage";
            treeNode381.Name = "Node1";
            treeNode381.Text = "Modified to work with Windows 8";
            treeNode382.Name = "Node0";
            treeNode382.Text = "LDWebCam";
            treeNode383.Name = "Node0";
            treeNode383.Text = "Version 1.0.0.120";
            treeNode384.Name = "Node2";
            treeNode384.Text = "FloodFill method added";
            treeNode385.Name = "Node1";
            treeNode385.Text = "LDGraphicsWindow";
            treeNode386.Name = "Node0";
            treeNode386.Text = "Version 1.0.0.119";
            treeNode387.Name = "Node0";
            treeNode387.Text = "SetShapeCursor method added";
            treeNode388.Name = "Node11";
            treeNode388.Text = "CreateCursor method added";
            treeNode389.Name = "Node9";
            treeNode389.Text = "LDCursors";
            treeNode390.Name = "Node2";
            treeNode390.Text = "SaveAs method to save in different file formats";
            treeNode391.Name = "Node0";
            treeNode391.Text = "Parameters added for some effects";
            treeNode392.Name = "Node1";
            treeNode392.Text = "LDImage";
            treeNode393.Name = "Node2";
            treeNode393.Text = "Parameters added for some effects";
            treeNode394.Name = "Node1";
            treeNode394.Text = "LDWebCam";
            treeNode395.Name = "Node1";
            treeNode395.Text = "Selected LDUtilities and LDShapes methods moved here to new object";
            treeNode396.Name = "Node0";
            treeNode396.Text = "SetFontFromFile method added for ttf fonts";
            treeNode397.Name = "Node0";
            treeNode397.Text = "LDGraphicsWindow";
            treeNode398.Name = "Node3";
            treeNode398.Text = "TWCapture and TWPrint moved from LDUtilities";
            treeNode399.Name = "Node2";
            treeNode399.Text = "LDTextWindow";
            treeNode400.Name = "Node2";
            treeNode400.Text = "Zip methods moved here from LDUtilities";
            treeNode401.Name = "Node0";
            treeNode401.Text = "LDZip";
            treeNode402.Name = "Node3";
            treeNode402.Text = "Regex methods moved here from LDUtilities";
            treeNode403.Name = "Node1";
            treeNode403.Text = "LDRegex";
            treeNode404.Name = "Node1";
            treeNode404.Text = "ListViewRowCount method added";
            treeNode405.Name = "Node0";
            treeNode405.Text = "LDControls";
            treeNode406.Name = "Node3";
            treeNode406.Text = "Version 1.0.0.118";
            treeNode407.Name = "Node5";
            treeNode407.Text = "TransparentGW method added to create a fully transparent GraphicsWindow";
            treeNode408.Name = "Node6";
            treeNode408.Text = "TopMostGW method to set GraphicsWindow as top window";
            treeNode409.Name = "Node4";
            treeNode409.Text = "LDUtilities";
            treeNode410.Name = "Node10";
            treeNode410.Text = "SetUserCursor method added";
            treeNode411.Name = "Node4";
            treeNode411.Text = "LDCursors";
            treeNode412.Name = "Node3";
            treeNode412.Text = "Version 1.0.0.117";
            treeNode413.Name = "Node2";
            treeNode413.Text = "Replacement for Version 1.0 Dictionary object that fails";
            treeNode414.Name = "Node1";
            treeNode414.Text = "LDDictionary";
            treeNode415.Name = "Node0";
            treeNode415.Text = "Version 1.0.0.116";
            treeNode416.Name = "Node2";
            treeNode416.Text = "GetPixel method fix for SB v1.0 bug (works for background, drawing and shape laye" +
    "rs)";
            treeNode417.Name = "Node1";
            treeNode417.Text = "LDColours";
            treeNode418.Name = "Node4";
            treeNode418.Text = "GetOpacity method fix for SB v1.0 bug";
            treeNode419.Name = "Node3";
            treeNode419.Text = "LDShapes";
            treeNode420.Name = "Node1";
            treeNode420.Text = "GridLines replaced with GridLinesX and GridLinesY";
            treeNode421.Name = "Node0";
            treeNode421.Text = "ScaleAxisX and ScaleAxisY methods added";
            treeNode422.Name = "Node1";
            treeNode422.Text = "AutoScale property added to revert to earlier scaling methods";
            treeNode423.Name = "Node0";
            treeNode423.Text = "LDGraph";
            treeNode424.Name = "Node0";
            treeNode424.Text = "Version 1.0.0.115";
            treeNode425.Name = "Node2";
            treeNode425.Text = "ListViewSetRow fixed for overwriting existing row";
            treeNode426.Name = "Node1";
            treeNode426.Text = "LDControls";
            treeNode427.Name = "Node4";
            treeNode427.Text = "RemoveTurtleLines method added";
            treeNode428.Name = "Node6";
            treeNode428.Text = "GetAllShapes method added";
            treeNode429.Name = "Node3";
            treeNode429.Text = "LDShapes";
            treeNode430.Name = "Node1";
            treeNode430.Text = "Odbc connection added";
            treeNode431.Name = "Node0";
            treeNode431.Text = "LDDatabase";
            treeNode432.Name = "Node0";
            treeNode432.Text = "Version 1.0.0.114";
            treeNode433.Name = "Node2";
            treeNode433.Text = "NetworkURL property added for your own LDNetwork web server";
            treeNode434.Name = "Node1";
            treeNode434.Text = "LDUtilities";
            treeNode435.Name = "Node4";
            treeNode435.Text = "ListView control added";
            treeNode436.Name = "Node5";
            treeNode436.Text = "TextBoxReadOnly to set textbox to read only";
            treeNode437.Name = "Node3";
            treeNode437.Text = "LDControls";
            treeNode438.Name = "Node0";
            treeNode438.Text = "Version 1.0.0.113";
            treeNode439.Name = "Node2";
            treeNode439.Text = "Tone method added";
            treeNode440.Name = "Node1";
            treeNode440.Text = "LDSound";
            treeNode441.Name = "Node5";
            treeNode441.Text = "TreeViewGetData and TreeViewEdit methods added";
            treeNode442.Name = "Node4";
            treeNode442.Text = "LDControls";
            treeNode443.Name = "Node0";
            treeNode443.Text = "Version 1.0.0.112";
            treeNode444.Name = "Node2";
            treeNode444.Text = "SqlServer and Access database support added";
            treeNode445.Name = "Node1";
            treeNode445.Text = "LDDataBase";
            treeNode446.Name = "Node4";
            treeNode446.Text = "FixFlickr method added";
            treeNode447.Name = "Node0";
            treeNode447.Text = "ShowNoShapeErrors enable or disable TextWindow errors when shape parameter not fo" +
    "und";
            treeNode448.Name = "Node3";
            treeNode448.Text = "LDUtilities";
            treeNode449.Name = "Node0";
            treeNode449.Text = "Version 1.0.0.111";
            treeNode450.Name = "Node2";
            treeNode450.Text = "TextBoxTab method added";
            treeNode451.Name = "Node1";
            treeNode451.Text = "LDControls";
            treeNode452.Name = "Node0";
            treeNode452.Text = "Version 1.0.0.110";
            treeNode453.Name = "Node1";
            treeNode453.Text = "TextWindow warning meaages for methods that are supplied with file paths that do " +
    "not exist";
            treeNode454.Name = "Node3";
            treeNode454.Text = "File not found warnings controlled with LDUtilities ShowFileErrors";
            treeNode455.Name = "Node0";
            treeNode455.Text = "General";
            treeNode456.Name = "Node5";
            treeNode456.Text = "Exists method added to check if a file path exists or not";
            treeNode457.Name = "Node4";
            treeNode457.Text = "LDFile";
            treeNode458.Name = "Node7";
            treeNode458.Text = "Start method handles attaching to existing process without warning";
            treeNode459.Name = "Node6";
            treeNode459.Text = "LDProcess";
            treeNode460.Name = "Node1";
            treeNode460.Text = "MySQL database support added";
            treeNode461.Name = "Node0";
            treeNode461.Text = "LDDatabase";
            treeNode462.Name = "Node3";
            treeNode462.Text = "Add and Multiply methods honour transparency";
            treeNode463.Name = "Node4";
            treeNode463.Text = "R, G, B truncated to 0 to 255 for Add, Multiply, AddImages, and Abs for Differenc" +
    "eImages";
            treeNode464.Name = "Node2";
            treeNode464.Text = "LDImage";
            treeNode465.Name = "Node3";
            treeNode465.Text = "Version 1.0.0.109";
            treeNode466.Name = "Node2";
            treeNode466.Text = "Show and Hide (fix for SB v1.0 bug)";
            treeNode467.Name = "Node1";
            treeNode467.Text = "LDTextWindow";
            treeNode468.Name = "Node0";
            treeNode468.Text = "Version 1.0.0.108";
            treeNode469.Name = "Node14";
            treeNode469.Text = "Transparent colour added";
            treeNode470.Name = "Node13";
            treeNode470.Text = "LDColours";
            treeNode471.Name = "Node16";
            treeNode471.Text = "Dialogs always appear in front of GraphicsWindow";
            treeNode472.Name = "Node15";
            treeNode472.Text = "LDDialogs";
            treeNode473.Name = "Node12";
            treeNode473.Text = "Version 1.0.0.107";
            treeNode474.Name = "Node8";
            treeNode474.Text = "Improvements to Menu control (colouring, separators and check state)";
            treeNode475.Name = "Node7";
            treeNode475.Text = "LDControls";
            treeNode476.Name = "Node11";
            treeNode476.Text = "SetShapeEvent added GotFocus and LostFocus events";
            treeNode477.Name = "Node10";
            treeNode477.Text = "LDShapes";
            treeNode478.Name = "Node6";
            treeNode478.Text = "Version 1.0.0.106";
            treeNode479.Name = "Node5";
            treeNode479.Text = "Menu control added";
            treeNode480.Name = "Node4";
            treeNode480.Text = "LDControls";
            treeNode481.Name = "Node3";
            treeNode481.Text = "Version 1.0.0.105";
            treeNode482.Name = "Node5";
            treeNode482.Text = "ZipList method added";
            treeNode483.Name = "Node2";
            treeNode483.Text = "GetNextMapIndex method added";
            treeNode484.Name = "Node4";
            treeNode484.Text = "LDUtilities";
            treeNode485.Name = "Node1";
            treeNode485.Text = "GetColour method added (gets Brush, Pen and Opacity)";
            treeNode486.Name = "Node0";
            treeNode486.Text = "LDShapes";
            treeNode487.Name = "Node3";
            treeNode487.Text = "Version 1.0.0.104";
            treeNode488.Name = "Node1";
            treeNode488.Text = "Transparency maintained for various methods";
            treeNode489.Name = "Node2";
            treeNode489.Text = "Effects bug fixed";
            treeNode490.Name = "Node0";
            treeNode490.Text = "LDImage";
            treeNode491.Name = "Node0";
            treeNode491.Text = "Version 1.0.0.103";
            treeNode492.Name = "Node1";
            treeNode492.Text = "Current application assemblies are all auto-referenced";
            treeNode493.Name = "Node0";
            treeNode493.Text = "LDInline";
            treeNode494.Name = "Node5";
            treeNode494.Text = "Version 1.0.0.102";
            treeNode495.Name = "Node1";
            treeNode495.Text = "Include C# or VB methods, properties and events to compile and call from your Sma" +
    "llBasic code";
            treeNode496.Name = "Node2";
            treeNode496.Text = "LDInline.sb sample provided";
            treeNode497.Name = "Node0";
            treeNode497.Text = "LDInline";
            treeNode498.Name = "Node4";
            treeNode498.Text = "ExitButtonMode method added to control window close button state";
            treeNode499.Name = "Node3";
            treeNode499.Text = "LDUtilities";
            treeNode500.Name = "Node0";
            treeNode500.Text = "Version 1.0.0.101";
            treeNode501.Name = "Node1";
            treeNode501.Text = "Read and ReadNumber methods added (with a delay before auto return)";
            treeNode502.Name = "Node0";
            treeNode502.Text = "KeyDown, KeyUp and SendKey (low level keyboard control) added";
            treeNode503.Name = "Node0";
            treeNode503.Text = "LDTextWindow";
            treeNode504.Name = "Node0";
            treeNode504.Text = "Version 1.0.0.100";
            treeNode505.Name = "Node2";
            treeNode505.Text = "ReadANSIToArray method added";
            treeNode506.Name = "Node1";
            treeNode506.Text = "LDFile";
            treeNode507.Name = "Node1";
            treeNode507.Text = "DocumentViewer control added";
            treeNode508.Name = "Node0";
            treeNode508.Text = "LDControls";
            treeNode509.Name = "Node3";
            treeNode509.Text = "An object to batch update shapes (for speed reasons)";
            treeNode510.Name = "Node0";
            treeNode510.Text = "LDFastShapes.sb sample included";
            treeNode511.Name = "Node2";
            treeNode511.Text = "LDFastShapes";
            treeNode512.Name = "Node0";
            treeNode512.Text = "Version 1.0.0.99";
            treeNode513.Name = "Node1";
            treeNode513.Text = "Rendering performance improvements when many shapes present";
            treeNode514.Name = "Node0";
            treeNode514.Text = "LDPhysics";
            treeNode515.Name = "Node1";
            treeNode515.Text = "ANSItoUTF8 method added";
            treeNode516.Name = "Node2";
            treeNode516.Text = "ReadANSI method added";
            treeNode517.Name = "Node0";
            treeNode517.Text = "LDFile";
            treeNode518.Name = "Node1";
            treeNode518.Text = "Version 1.0.0.98";
            treeNode519.Name = "Node3";
            treeNode519.Text = "Move method added for tiangles, polygons and lines";
            treeNode520.Name = "Node4";
            treeNode520.Text = "RotateAbout method added";
            treeNode521.Name = "Node1";
            treeNode521.Text = "GetLeft and GetTop methods added for triangles, polygons and lines";
            treeNode522.Name = "Node0";
            treeNode522.Text = "SetTurtleImage repositioning \'hot spot\' on resize fixed";
            treeNode523.Name = "Node2";
            treeNode523.Text = "LDShapes";
            treeNode524.Name = "Node0";
            treeNode524.Text = "Version 1.0.0.97";
            treeNode525.Name = "Node4";
            treeNode525.Text = "A list storage object added";
            treeNode526.Name = "Node3";
            treeNode526.Text = "LDList";
            treeNode527.Name = "Node2";
            treeNode527.Text = "Version 1.0.0.96";
            treeNode528.Name = "Node4";
            treeNode528.Text = "A queue (first-in first-out) storage similar to a stack object added";
            treeNode529.Name = "Node3";
            treeNode529.Text = "LDQueue";
            treeNode530.Name = "Node6";
            treeNode530.Text = "Fix for multi-dimensional arrays using GetGameData and SetGameData";
            treeNode531.Name = "Node5";
            treeNode531.Text = "LDNetwork";
            treeNode532.Name = "Node0";
            treeNode532.Text = "Returned arrays with \\= or ; in index or value correctly handled";
            treeNode533.Name = "Node1";
            treeNode533.Text = "General";
            treeNode534.Name = "Node2";
            treeNode534.Text = "Version 1.0.0.95";
            treeNode535.Name = "Node2";
            treeNode535.Text = "SHA512Hash and MD5HashFile methods added";
            treeNode536.Name = "Node1";
            treeNode536.Text = "LDEncryption";
            treeNode537.Name = "Node1";
            treeNode537.Text = "RandomNumberSeed property added";
            treeNode538.Name = "Node0";
            treeNode538.Text = "LDMath";
            treeNode539.Name = "Node1";
            treeNode539.Text = "SetGameData and GetGameData methods added";
            treeNode540.Name = "Node0";
            treeNode540.Text = "LDNetwork";
            treeNode541.Name = "Node0";
            treeNode541.Text = "Version 1.0.0.94";
            treeNode542.Name = "Node1";
            treeNode542.Text = "SliderGetValue method added";
            treeNode543.Name = "Node0";
            treeNode543.Text = "LDControls";
            treeNode544.Name = "Node5";
            treeNode544.Text = "UnZip now works with most zip formats, not just those created with LDUtilities.Zi" +
    "p";
            treeNode545.Name = "Node2";
            treeNode545.Text = "LDUtilities";
            treeNode546.Name = "Node3";
            treeNode546.Text = "Encrypt and Decrypt methods added";
            treeNode547.Name = "Node4";
            treeNode547.Text = "MD5Hash method added";
            treeNode548.Name = "Node6";
            treeNode548.Text = "LDEncryption";
            treeNode549.Name = "Node0";
            treeNode549.Text = "Version 1.0.0.93";
            treeNode550.Name = "Node1";
            treeNode550.Text = "ProgressBar, Slider and PasswordBox controls added";
            treeNode551.Name = "Node0";
            treeNode551.Text = "LDControls";
            treeNode552.Name = "Node0";
            treeNode552.Text = "Version 1.0.0.92";
            treeNode553.Name = "Node2";
            treeNode553.Text = "TreeViewGetSelected, ListBoxGetSelected, ComboBoxGetSelected, CheckBoxGetState an" +
    "d RadioButtonGet methods added";
            treeNode554.Name = "Node1";
            treeNode554.Text = "LDControls";
            treeNode555.Name = "Node1";
            treeNode555.Text = "Version 1.0.0.91";
            treeNode556.Name = "Node1";
            treeNode556.Text = "Font method added to modify shapes or controls that have text";
            treeNode557.Name = "Node0";
            treeNode557.Text = "LDShapes";
            treeNode558.Name = "Node1";
            treeNode558.Text = "MediaPlayer control added (play videos etc)";
            treeNode559.Name = "Node0";
            treeNode559.Text = "ListBoxContent, TreeViewContent and ComboBoxContent methods added to change list " +
    "contents";
            treeNode560.Name = "Node0";
            treeNode560.Text = "LDControls";
            treeNode561.Name = "Node1";
            treeNode561.Text = "Version 1.0.0.90";
            treeNode562.Name = "Node1";
            treeNode562.Text = "Autosize columns for ListView";
            treeNode563.Name = "Node2";
            treeNode563.Text = "LDDataBase.sb sample updated";
            treeNode564.Name = "Node0";
            treeNode564.Text = "Optionally return array of results for query (GetRecord removed)";
            treeNode565.Name = "Node0";
            treeNode565.Text = "LDDataBase";
            treeNode566.Name = "Node0";
            treeNode566.Text = "Version 1.0.0.89";
            treeNode567.Name = "Node4";
            treeNode567.Text = "GraphicsWindow.MouseDown works for any event subroutine name";
            treeNode568.Name = "Node3";
            treeNode568.Text = "LDScrollBars";
            treeNode569.Name = "Node1";
            treeNode569.Text = "CleanTemp method added";
            treeNode570.Name = "Node0";
            treeNode570.Text = "LDUtilities";
            treeNode571.Name = "Node1";
            treeNode571.Text = "SQLite database methods added";
            treeNode572.Name = "Node0";
            treeNode572.Text = "LDDataBase";
            treeNode573.Name = "Node2";
            treeNode573.Text = "Version 1.0.0.88";
            treeNode574.Name = "Node2";
            treeNode574.Text = "LastError now returns a text error";
            treeNode575.Name = "Node1";
            treeNode575.Text = "LDIOWarrior";
            treeNode576.Name = "Node1";
            treeNode576.Text = "MouseDown (must be named \"OnMouseDown\") and MouseWheel events fixed";
            treeNode577.Name = "Node0";
            treeNode577.Text = "LDScrollBars";
            treeNode578.Name = "Node0";
            treeNode578.Text = "Version 1.0.0.87";
            treeNode579.Name = "Node4";
            treeNode579.Text = "SetTurtleImage method added";
            treeNode580.Name = "Node3";
            treeNode580.Text = "LDShapes";
            treeNode581.Name = "Node1";
            treeNode581.Text = "Connect to IOWarrior USB devices";
            treeNode582.Name = "Node0";
            treeNode582.Text = "http://www.codemercs.com/io-warrior/?L=1";
            treeNode583.Name = "Node0";
            treeNode583.Text = "LDIOWarrior";
            treeNode584.Name = "Node2";
            treeNode584.Text = "Version 1.0.0.86";
            treeNode585.Name = "Node1";
            treeNode585.Text = "PenColour, BrushColour and BrushGradientShape applied to most Shapes and Controls" +
    "";
            treeNode586.Name = "Node0";
            treeNode586.Text = "LDShapes";
            treeNode587.Name = "Node2";
            treeNode587.Text = "Version 1.0.0.85";
            treeNode588.Name = "Node4";
            treeNode588.Text = "GetFolder, GetFile and GetExtension methods added";
            treeNode589.Name = "Node3";
            treeNode589.Text = "LDFile";
            treeNode590.Name = "Node6";
            treeNode590.Text = "Crop method added";
            treeNode591.Name = "Node5";
            treeNode591.Text = "LDImage";
            treeNode592.Name = "Node1";
            treeNode592.Text = "LastDropFiles bug fixed";
            treeNode593.Name = "Node0";
            treeNode593.Text = "LDControls";
            treeNode594.Name = "Node2";
            treeNode594.Text = "Version 1.0.0.84";
            treeNode595.Name = "Node7";
            treeNode595.Text = "FileDropped event added";
            treeNode596.Name = "Node6";
            treeNode596.Text = "LDControls";
            treeNode597.Name = "Node1";
            treeNode597.Text = "Bug in Split corrected";
            treeNode598.Name = "Node0";
            treeNode598.Text = "LDText";
            treeNode599.Name = "Node5";
            treeNode599.Text = "Version 1.0.0.83";
            treeNode600.Name = "Node3";
            treeNode600.Text = "Title argument removed from AddComboBox";
            treeNode601.Name = "Node4";
            treeNode601.Text = "AllowDrop method added (for TextBox, RichTextBox, Image and Background)";
            treeNode602.Name = "Node2";
            treeNode602.Text = "LDControls";
            treeNode603.Name = "Node1";
            treeNode603.Text = "Version 1.0.0.82";
            treeNode604.Name = "Node0";
            treeNode604.Text = "German xml updated (Thanks to Pappa Lapub)";
            treeNode605.Name = "Node12";
            treeNode605.Text = "Program settings added";
            treeNode606.Name = "Node9";
            treeNode606.Text = "LDSettings";
            treeNode607.Name = "Node11";
            treeNode607.Text = "Get some system paths and user name";
            treeNode608.Name = "Node10";
            treeNode608.Text = "LDFile";
            treeNode609.Name = "Node14";
            treeNode609.Text = "System sounds added";
            treeNode610.Name = "Node13";
            treeNode610.Text = "LDSound";
            treeNode611.Name = "Node16";
            treeNode611.Text = "Binary, octal, hex and decimal conversions";
            treeNode612.Name = "Node15";
            treeNode612.Text = "LDMath";
            treeNode613.Name = "Node1";
            treeNode613.Text = "Replace method added";
            treeNode614.Name = "Node2";
            treeNode614.Text = "FindAll method added";
            treeNode615.Name = "Node0";
            treeNode615.Text = "LDText";
            treeNode616.Name = "Node8";
            treeNode616.Text = "Version 1.0.0.81";
            treeNode617.Name = "Node1";
            treeNode617.Text = "BrushColour, BrushGradientShape and PenColour implemented for buttons";
            treeNode618.Name = "Node6";
            treeNode618.Text = "General events for shapes added (see ShapeEvents sample)";
            treeNode619.Name = "Node0";
            treeNode619.Text = "LDShapes";
            treeNode620.Name = "Node3";
            treeNode620.Text = "Truncate method added";
            treeNode621.Name = "Node2";
            treeNode621.Text = "LDMath";
            treeNode622.Name = "Node5";
            treeNode622.Text = "Additional text methods";
            treeNode623.Name = "Node4";
            treeNode623.Text = "LDText";
            treeNode624.Name = "Node0";
            treeNode624.Text = "Version 1.0.0.80";
            treeNode625.Name = "Node1";
            treeNode625.Text = "Confirm dialog message box (Yes, No, Cancel) added";
            treeNode626.Name = "Node0";
            treeNode626.Text = "LDDialogs";
            treeNode627.Name = "Node1";
            treeNode627.Text = "CancelClose property added for GraphicsWindow closure";
            treeNode628.Name = "Node0";
            treeNode628.Text = "LDUtilities";
            treeNode629.Name = "Node6";
            treeNode629.Text = "Version 1.0.0.79";
            treeNode630.Name = "Node2";
            treeNode630.Text = "Rasterize property added";
            treeNode631.Name = "Node5";
            treeNode631.Text = "Improvements associated with window resizing";
            treeNode632.Name = "Node1";
            treeNode632.Text = "LDScrollBars";
            treeNode633.Name = "Node4";
            treeNode633.Text = "ExitOnClose property (and GWClosing event) added";
            treeNode634.Name = "Node3";
            treeNode634.Text = "LDUtilities";
            treeNode635.Name = "Node0";
            treeNode635.Text = "Version 1.0.0.78";
            treeNode636.Name = "Node1";
            treeNode636.Text = "Handle more than 100 drawables (rasterization)";
            treeNode637.Name = "Node0";
            treeNode637.Text = "LDScollBars";
            treeNode638.Name = "Node2";
            treeNode638.Text = "Version 1.0.0.77";
            treeNode639.Name = "Node1";
            treeNode639.Text = "Record sound from a microphone";
            treeNode640.Name = "Node0";
            treeNode640.Text = "LDSound";
            treeNode641.Name = "Node3";
            treeNode641.Text = "AnimateOpacity method added (flashing)";
            treeNode642.Name = "Node0";
            treeNode642.Text = "AnimateRotation method added (continuous rotation)";
            treeNode643.Name = "Node1";
            treeNode643.Text = "AnimateZoom method added (coninuous zooming)";
            treeNode644.Name = "Node2";
            treeNode644.Text = "LDShapes";
            treeNode645.Name = "Node2";
            treeNode645.Text = "Version 1.0.0.76";
            treeNode646.Name = "Node1";
            treeNode646.Text = "AddAnimatedImage can use an ImageList image";
            treeNode647.Name = "Node0";
            treeNode647.Text = "LDShapes";
            treeNode648.Name = "Node0";
            treeNode648.Text = "Version 1.0.0.75";
            treeNode649.Name = "Node1";
            treeNode649.Text = "Initial graph axes scaling improvement";
            treeNode650.Name = "Node0";
            treeNode650.Text = "LDGraph";
            treeNode651.Name = "Node3";
            treeNode651.Text = "Methods to access a bluetooth device";
            treeNode652.Name = "Node0";
            treeNode652.Text = "Includes simple file transfer and potentially advanced device interaction";
            treeNode653.Name = "Node2";
            treeNode653.Text = "LDBlueTooth";
            treeNode654.Name = "Node1";
            treeNode654.Text = "getFocus handles multiple LDWindows";
            treeNode655.Name = "Node0";
            treeNode655.Text = "LDFocus";
            treeNode656.Name = "Node0";
            treeNode656.Text = "Version 1.0.0.74";
            treeNode657.Name = "Node1";
            treeNode657.Text = "First pass at a generic USB (HID) device controller";
            treeNode658.Name = "Node0";
            treeNode658.Text = "LDHID";
            treeNode659.Name = "Node9";
            treeNode659.Text = "Version 1.0.0.73";
            treeNode660.Name = "Node8";
            treeNode660.Text = "Initial scaling doesn\'t position points touching the axes";
            treeNode661.Name = "Node7";
            treeNode661.Text = "LDGraph";
            treeNode662.Name = "Node6";
            treeNode662.Text = "Version 1.0.0.72";
            treeNode663.Name = "Node4";
            treeNode663.Text = "TrendCoef method added to get polynomial trend line coefficients";
            treeNode664.Name = "Node5";
            treeNode664.Text = "TrendPointCount property added to control the number of points on a trend line";
            treeNode665.Name = "Node3";
            treeNode665.Text = "LDGraph";
            treeNode666.Name = "Node2";
            treeNode666.Text = "Version 1.0.0.71";
            treeNode667.Name = "Node1";
            treeNode667.Text = "Spurious error message fixed";
            treeNode668.Name = "Node2";
            treeNode668.Text = "CreateTrend data series creation method added";
            treeNode669.Name = "Node0";
            treeNode669.Text = "LDGraph";
            treeNode670.Name = "Node2";
            treeNode670.Text = "Version 1.0.0.70";
            treeNode671.Name = "Node1";
            treeNode671.Text = "Font properties and colours set for LDControls in the same way as standard Contro" +
    "ls";
            treeNode672.Name = "Node0";
            treeNode672.Text = "LDControls";
            treeNode673.Name = "Node3";
            treeNode673.Text = "Version 1.0.0.69";
            treeNode674.Name = "Node2";
            treeNode674.Text = "Radio button control added";
            treeNode675.Name = "Node1";
            treeNode675.Text = "LDControls";
            treeNode676.Name = "Node0";
            treeNode676.Text = "Version 1.0.0.68";
            treeNode677.Name = "Node1";
            treeNode677.Text = "Bug fix for Copy";
            treeNode678.Name = "Node0";
            treeNode678.Text = "LDArray";
            treeNode679.Name = "Node2";
            treeNode679.Text = "Version 1.0.0.67";
            treeNode680.Name = "Node1";
            treeNode680.Text = "RegexMatch and RegexReplace methods added";
            treeNode681.Name = "Node0";
            treeNode681.Text = "LDUtilities";
            treeNode682.Name = "Node3";
            treeNode682.Text = "Version 1.0.0.66";
            treeNode683.Name = "Node2";
            treeNode683.Text = "Number culture conversions added";
            treeNode684.Name = "Node1";
            treeNode684.Text = "LDUtilities";
            treeNode685.Name = "Node0";
            treeNode685.Text = "Version 1.0.0.65";
            treeNode686.Name = "Node1";
            treeNode686.Text = "IsNumber method added";
            treeNode687.Name = "Node0";
            treeNode687.Text = "LDUtilities";
            treeNode688.Name = "Node2";
            treeNode688.Text = "Version 1.0.0.64";
            treeNode689.Name = "Node1";
            treeNode689.Text = "SetCursorPosition method added for textboxes";
            treeNode690.Name = "Node0";
            treeNode690.Text = "LDControls";
            treeNode691.Name = "Node4";
            treeNode691.Text = "Version 1.0.0.63";
            treeNode692.Name = "Node1";
            treeNode692.Text = "SetCursorToEnd method added for textboxes";
            treeNode693.Name = "Node3";
            treeNode693.Text = "SetSpellCheck method added for textboxes and richtextboxes";
            treeNode694.Name = "Node0";
            treeNode694.Text = "LDControls";
            treeNode695.Name = "Node2";
            treeNode695.Text = "Version 1.0.0.62";
            treeNode696.Name = "Node1";
            treeNode696.Text = "Adding polygons not located at (0,0) corrected";
            treeNode697.Name = "Node0";
            treeNode697.Text = "LDPhysics";
            treeNode698.Name = "Node2";
            treeNode698.Text = "Version 1.0.0.61";
            treeNode699.Name = "Node1";
            treeNode699.Text = "GetFolder dialog added";
            treeNode700.Name = "Node0";
            treeNode700.Text = "LDDialogs";
            treeNode701.Name = "Node0";
            treeNode701.Text = "Version 1.0.0.60";
            treeNode702.Name = "Node10";
            treeNode702.Text = "Possible localization issue with Font size fixed";
            treeNode703.Name = "Node9";
            treeNode703.Text = "LDDialogs";
            treeNode704.Name = "Node8";
            treeNode704.Text = "Version 1.0.0.59";
            treeNode705.Name = "Node3";
            treeNode705.Text = "More internationalization fixes";
            treeNode706.Name = "Node2";
            treeNode706.Text = "ShowPrintPreview property added";
            treeNode707.Name = "Node1";
            treeNode707.Text = "LDUtilities";
            treeNode708.Name = "Node5";
            treeNode708.Text = "Possible error with gradient drawings fixed";
            treeNode709.Name = "Node4";
            treeNode709.Text = "LDShapes";
            treeNode710.Name = "Node7";
            treeNode710.Text = "Possible Listen event initialisation error fixed";
            treeNode711.Name = "Node6";
            treeNode711.Text = "LDSpeech";
            treeNode712.Name = "Node0";
            treeNode712.Text = "Version 1.0.0.58";
            treeNode713.Name = "Node7";
            treeNode713.Text = "Many possible internationisation issues fixed";
            treeNode714.Name = "Node4";
            treeNode714.Text = "Version 1.0.0.57";
            treeNode715.Name = "Node1";
            treeNode715.Text = "Emmisive colour correction for AddGeometry";
            treeNode716.Name = "Node2";
            treeNode716.Text = "Geometry coordinates etc are now colon or space deminiated (not comma)";
            treeNode717.Name = "Node0";
            treeNode717.Text = "LD3DView";
            treeNode718.Name = "Node1";
            treeNode718.Text = "CSVdeminiator property added";
            treeNode719.Name = "Node0";
            treeNode719.Text = "LDUtilities";
            treeNode720.Name = "Node5";
            treeNode720.Text = "Version 1.0.0.56";
            treeNode721.Name = "Node1";
            treeNode721.Text = "Improved error reporting";
            treeNode722.Name = "Node2";
            treeNode722.Text = "Culture invariant type conversions";
            treeNode723.Name = "Node1";
            treeNode723.Text = "LD3DView";
            treeNode724.Name = "Node4";
            treeNode724.Text = "ShowErrors method added";
            treeNode725.Name = "Node3";
            treeNode725.Text = "LDUtilities";
            treeNode726.Name = "Node0";
            treeNode726.Text = "Version 1.0.0.55";
            treeNode727.Name = "Node4";
            treeNode727.Text = "Warning added to intellisense help about  resizing GraphicsWindow";
            treeNode728.Name = "Node3";
            treeNode728.Text = "LDScrollBars";
            treeNode729.Name = "Node6";
            treeNode729.Text = "GWWidth and GWHeight added for use with LDScrollBars";
            treeNode730.Name = "Node5";
            treeNode730.Text = "LDUtilities";
            treeNode731.Name = "Node2";
            treeNode731.Text = "Version 1.0.0.54";
            treeNode732.Name = "Node1";
            treeNode732.Text = "Debug window can be resized";
            treeNode733.Name = "Node0";
            treeNode733.Text = "LDDebug";
            treeNode734.Name = "Node1";
            treeNode734.Text = "PrintFile method added";
            treeNode735.Name = "Node0";
            treeNode735.Text = "LDFile";
            treeNode736.Name = "Node2";
            treeNode736.Text = "Version 1.0.0.53";
            treeNode737.Name = "Node1";
            treeNode737.Text = "SSL property option added";
            treeNode738.Name = "Node0";
            treeNode738.Text = "LDEmail";
            treeNode739.Name = "Node0";
            treeNode739.Text = "Version 1.0.0.52";
            treeNode740.Name = "Node1";
            treeNode740.Text = "Right Click Context menu added for any shape or control";
            treeNode741.Name = "Node0";
            treeNode741.Text = "LDControls";
            treeNode742.Name = "Node0";
            treeNode742.Text = "Version 1.0.0.51";
            treeNode743.Name = "Node1";
            treeNode743.Text = "Right click dropdown menu option added";
            treeNode744.Name = "Node0";
            treeNode744.Text = "LDDialogs";
            treeNode745.Name = "Node0";
            treeNode745.Text = "Version 1.0.0.50";
            treeNode746.Name = "Node1";
            treeNode746.Text = "More methods added, AddSphere, AddTube, ReverseNormals";
            treeNode747.Name = "Node0";
            treeNode747.Text = "LD3DView";
            treeNode748.Name = "Node0";
            treeNode748.Text = "Version 1.0.0.49";
            treeNode749.Name = "Node1";
            treeNode749.Text = "Performance improvements (some camera controls for this)";
            treeNode750.Name = "Node1";
            treeNode750.Text = "LoadModel (*.3ds) files added";
            treeNode751.Name = "Node0";
            treeNode751.Text = "LD3DView";
            treeNode752.Name = "Node3";
            treeNode752.Text = "AddStar and AddRegularPolygon shape methods added";
            treeNode753.Name = "Node2";
            treeNode753.Text = "LDShapes";
            treeNode754.Name = "Node0";
            treeNode754.Text = "Version 1.0.0.48";
            treeNode755.Name = "Node1";
            treeNode755.Text = "Some improvements including animations";
            treeNode756.Name = "Node0";
            treeNode756.Text = "LD3DView";
            treeNode757.Name = "Node0";
            treeNode757.Text = "Version 1.0.0.47";
            treeNode758.Name = "Node1";
            treeNode758.Text = "Some improvemts and new methods";
            treeNode759.Name = "Node0";
            treeNode759.Text = "LD3Dview";
            treeNode760.Name = "Node2";
            treeNode760.Text = "Version 1.0.0.46";
            treeNode761.Name = "Node1";
            treeNode761.Text = "A start at a 3D set of methods";
            treeNode762.Name = "Node0";
            treeNode762.Text = "LD3DView";
            treeNode763.Name = "Node10";
            treeNode763.Text = "Version 1.0.0.45";
            treeNode764.Name = "Node1";
            treeNode764.Text = "Create scrollbars for the GraphicsWindow";
            treeNode765.Name = "Node5";
            treeNode765.Text = "Methods to control the scrollbars allowing a scrolling game to be made";
            treeNode766.Name = "Node0";
            treeNode766.Text = "LDScrollBars";
            treeNode767.Name = "Node4";
            treeNode767.Text = "ColourList method added";
            treeNode768.Name = "Node3";
            treeNode768.Text = "LDUtilities";
            treeNode769.Name = "Node8";
            treeNode769.Text = "Linear and radial gradient methods for shapes, drawings and background";
            treeNode770.Name = "Node9";
            treeNode770.Text = "BackgroundImage method to set the background added";
            treeNode771.Name = "Node6";
            treeNode771.Text = "LDShapes";
            treeNode772.Name = "Node0";
            treeNode772.Text = "Version 1.0.0.44";
            treeNode773.Name = "Node1";
            treeNode773.Text = "AddScrollBars method added for the GraphicsWindow";
            treeNode774.Name = "Node0";
            treeNode774.Text = "LDUtilities";
            treeNode775.Name = "Node0";
            treeNode775.Text = "Version 1.0.0.43";
            treeNode776.Name = "Node1";
            treeNode776.Text = "Call Subs as functions with arguments";
            treeNode777.Name = "Node0";
            treeNode777.Text = "LDCall";
            treeNode778.Name = "Node0";
            treeNode778.Text = "Version 1.0.0.42";
            treeNode779.Name = "Node1";
            treeNode779.Text = "Font dialog added";
            treeNode780.Name = "Node2";
            treeNode780.Text = "Colours dialog moved here from LDColours";
            treeNode781.Name = "Node0";
            treeNode781.Text = "LDDialogs";
            treeNode782.Name = "Node9";
            treeNode782.Text = "Version 1.0.0.41";
            treeNode783.Name = "Node1";
            treeNode783.Text = "Controls methods (RichTextBox and TreeView) moved here from LDDialogs";
            treeNode784.Name = "Node7";
            treeNode784.Text = "WebBrowser, ListBox, ComboBox and CheckBox objects added";
            treeNode785.Name = "Node8";
            treeNode785.Text = "Some methods renamed";
            treeNode786.Name = "Node0";
            treeNode786.Text = "LDControls";
            treeNode787.Name = "Node3";
            treeNode787.Text = "HighScore method move here";
            treeNode788.Name = "Node2";
            treeNode788.Text = "LDNetwork";
            treeNode789.Name = "Node6";
            treeNode789.Text = "SetSize method added";
            treeNode790.Name = "Node5";
            treeNode790.Text = "LDShapes";
            treeNode791.Name = "Node3";
            treeNode791.Text = "Version 1.0.0.40";
            treeNode792.Name = "Node1";
            treeNode792.Text = "SelectTreeView method added";
            treeNode793.Name = "Node2";
            treeNode793.Text = "A currently selected node also registers selection event when it is clicked";
            treeNode794.Name = "Node0";
            treeNode794.Text = "LDDialogs";
            treeNode795.Name = "Node1";
            treeNode795.Text = "Simple high score web method";
            treeNode796.Name = "Node0";
            treeNode796.Text = "LDHighScore";
            treeNode797.Name = "Node3";
            treeNode797.Text = "Version 1.0.0.39";
            treeNode798.Name = "Node2";
            treeNode798.Text = "RichTextBox methods improved";
            treeNode799.Name = "Node1";
            treeNode799.Text = "LDDialogs";
            treeNode800.Name = "Node1";
            treeNode800.Text = "Search, Load and Save methods added";
            treeNode801.Name = "Node0";
            treeNode801.Text = "LDArray";
            treeNode802.Name = "Node0";
            treeNode802.Text = "Version 1.0.0.38";
            treeNode803.Name = "Node1";
            treeNode803.Text = "Depreciated";
            treeNode804.Name = "Node0";
            treeNode804.Text = "LDWeather";
            treeNode805.Name = "Node1";
            treeNode805.Text = "Renamed from LDTrig and some more methods added";
            treeNode806.Name = "Node0";
            treeNode806.Text = "LDMath";
            treeNode807.Name = "Node3";
            treeNode807.Text = "RichTextBox method added";
            treeNode808.Name = "Node2";
            treeNode808.Text = "LDDialogs";
            treeNode809.Name = "Node5";
            treeNode809.Text = "FontList method added";
            treeNode810.Name = "Node4";
            treeNode810.Text = "LDUtilities";
            treeNode811.Name = "Node2";
            treeNode811.Text = "Version 1.0.0.37";
            treeNode812.Name = "Node1";
            treeNode812.Text = "Zip method extended";
            treeNode813.Name = "Node0";
            treeNode813.Text = "LDUtilities";
            treeNode814.Name = "Node2";
            treeNode814.Text = "Version 1.0.0.36";
            treeNode815.Name = "Node1";
            treeNode815.Text = "Collapse and expand treeview nodes method added";
            treeNode816.Name = "Node0";
            treeNode816.Text = "LDDialogs";
            treeNode817.Name = "Node5";
            treeNode817.Text = "Version 1.0.0.35";
            treeNode818.Name = "Node1";
            treeNode818.Text = "Arguments added to Start method";
            treeNode819.Name = "Node0";
            treeNode819.Text = "LDProcess";
            treeNode820.Name = "Node4";
            treeNode820.Text = "Zip compression methods added";
            treeNode821.Name = "Node2";
            treeNode821.Text = "LDUtilities";
            treeNode822.Name = "Node2";
            treeNode822.Text = "Version 1.0.0.34";
            treeNode823.Name = "Node1";
            treeNode823.Text = "GWStyle property added";
            treeNode824.Name = "Node0";
            treeNode824.Text = "LDUtilities";
            treeNode825.Name = "Node1";
            treeNode825.Text = "TreeView and associated events added";
            treeNode826.Name = "Node0";
            treeNode826.Text = "LDDialogs";
            treeNode827.Name = "Node0";
            treeNode827.Text = "Version 1.0.0.33";
            treeNode828.Name = "Node1";
            treeNode828.Text = "Possible end points not plotting bug fixed";
            treeNode829.Name = "Node0";
            treeNode829.Text = "LDGraph";
            treeNode830.Name = "Node2";
            treeNode830.Text = "Version 1.0.0.32";
            treeNode831.Name = "Node1";
            treeNode831.Text = "Activated event and Active property addded";
            treeNode832.Name = "Node0";
            treeNode832.Text = "LDWindows";
            treeNode833.Name = "Node0";
            treeNode833.Text = "Version 1.0.0.31";
            treeNode834.Name = "Node1";
            treeNode834.Text = "Create multiple GraphicsWindows";
            treeNode835.Name = "Node0";
            treeNode835.Text = "LDWindows";
            treeNode836.Name = "Node0";
            treeNode836.Text = "Version 1.0.0.30";
            treeNode837.Name = "Node1";
            treeNode837.Text = "Email sending method";
            treeNode838.Name = "Node0";
            treeNode838.Text = "LDMail";
            treeNode839.Name = "Node1";
            treeNode839.Text = "Add and Multiply methods bug fixed";
            treeNode840.Name = "Node2";
            treeNode840.Text = "Image statistics combined into one method";
            treeNode841.Name = "Node3";
            treeNode841.Text = "Histogram method added";
            treeNode842.Name = "Node0";
            treeNode842.Text = "LDImage";
            treeNode843.Name = "Node0";
            treeNode843.Text = "Version 1.0.0.29";
            treeNode844.Name = "Node1";
            treeNode844.Text = "SnapshotToImageList method added";
            treeNode845.Name = "Node0";
            treeNode845.Text = "LDWebCam";
            treeNode846.Name = "Node3";
            treeNode846.Text = "ImageList image manipulation methods";
            treeNode847.Name = "Node2";
            treeNode847.Text = "LDImage";
            treeNode848.Name = "Node0";
            treeNode848.Text = "Version 1.0.0.28";
            treeNode849.Name = "Node1";
            treeNode849.Text = "SortIndex bugfix for null values";
            treeNode850.Name = "Node0";
            treeNode850.Text = "LDArray";
            treeNode851.Name = "Node1";
            treeNode851.Text = "SnapshotToFile bug fixed";
            treeNode852.Name = "Node0";
            treeNode852.Text = "LDWebCam";
            treeNode853.Name = "Node0";
            treeNode853.Text = "Version 1.0.0.27";
            treeNode854.Name = "Node1";
            treeNode854.Text = "SortIndex method added";
            treeNode855.Name = "Node0";
            treeNode855.Text = "LDArray";
            treeNode856.Name = "Node1";
            treeNode856.Text = "Web based weather report data added";
            treeNode857.Name = "Node0";
            treeNode857.Text = "LDWeather";
            treeNode858.Name = "Node3";
            treeNode858.Text = "DataReceived event added";
            treeNode859.Name = "Node2";
            treeNode859.Text = "LDCommPort";
            treeNode860.Name = "Node0";
            treeNode860.Text = "Version 1.0.0.26";
            treeNode861.Name = "Node1";
            treeNode861.Text = "Speech recognition added";
            treeNode862.Name = "Node0";
            treeNode862.Text = "LDSpeech";
            treeNode863.Name = "Node0";
            treeNode863.Text = "Version 1.0.0.25";
            treeNode864.Name = "Node4";
            treeNode864.Text = "More methods added and some internal code optimised";
            treeNode865.Name = "Node0";
            treeNode865.Text = "LDArray & LDMatrix";
            treeNode866.Name = "Node1";
            treeNode866.Text = "KeyDown method added";
            treeNode867.Name = "Node0";
            treeNode867.Text = "LDUtilities";
            treeNode868.Name = "Node1";
            treeNode868.Text = "GetAllShapesAt method added";
            treeNode869.Name = "Node0";
            treeNode869.Text = "Overlap method for ellipse and rectangle combinations added";
            treeNode870.Name = "Node0";
            treeNode870.Text = "LDShapes";
            treeNode871.Name = "Node0";
            treeNode871.Text = "Version 1.0.0.24";
            treeNode872.Name = "Node1";
            treeNode872.Text = "OpenFile and SaveFile dialogs added";
            treeNode873.Name = "Node0";
            treeNode873.Text = "LDDialogs";
            treeNode874.Name = "Node2";
            treeNode874.Text = "Matrix methods, for example to solve linear equations";
            treeNode875.Name = "Node1";
            treeNode875.Text = "LDMatrix";
            treeNode876.Name = "Node0";
            treeNode876.Text = "Version 1.0.0.23";
            treeNode877.Name = "Node1";
            treeNode877.Text = "Sorting method added";
            treeNode878.Name = "Node0";
            treeNode878.Text = "LDArray";
            treeNode879.Name = "Node0";
            treeNode879.Text = "Version 1.0.0.22";
            treeNode880.Name = "Node2";
            treeNode880.Text = "Velocity Threshold setting added";
            treeNode881.Name = "Node1";
            treeNode881.Text = "LDPhysics";
            treeNode882.Name = "Node0";
            treeNode882.Text = "Version 1.0.0.21";
            treeNode883.Name = "Node3";
            treeNode883.Text = "SetDamping method added";
            treeNode884.Name = "Node2";
            treeNode884.Text = "LDPhysics";
            treeNode885.Name = "Node1";
            treeNode885.Text = "Version 1.0.0.20";
            treeNode886.Name = "Node1";
            treeNode886.Text = "Instrument name can be obtained from its number";
            treeNode887.Name = "Node0";
            treeNode887.Text = "LDMusic";
            treeNode888.Name = "Node0";
            treeNode888.Text = "Version 1.0.0.19";
            treeNode889.Name = "Node1";
            treeNode889.Text = "Calendar uses MS visual styles if available (better calendar, but no colours)";
            treeNode890.Name = "Node0";
            treeNode890.Text = "LDDialogs";
            treeNode891.Name = "Node1";
            treeNode891.Text = "Extends Sounds.PlayMusic to include additional instruments";
            treeNode892.Name = "Node2";
            treeNode892.Text = "Notes can also be played synchronously (chords)";
            treeNode893.Name = "Node0";
            treeNode893.Text = "LDMusic";
            treeNode894.Name = "Node0";
            treeNode894.Text = "Version 1.0.0.18";
            treeNode895.Name = "Node1";
            treeNode895.Text = "AnimationPause and AnimationResume methods added";
            treeNode896.Name = "Node0";
            treeNode896.Text = "LDShapes";
            treeNode897.Name = "Node1";
            treeNode897.Text = "Process list indexed by ID rather than name";
            treeNode898.Name = "Node0";
            treeNode898.Text = "LDProcess";
            treeNode899.Name = "Node1";
            treeNode899.Text = "Version 1.0.0.17";
            treeNode900.Name = "Node1";
            treeNode900.Text = "More effects added";
            treeNode901.Name = "Node0";
            treeNode901.Text = "LDWebCam";
            treeNode902.Name = "Node1";
            treeNode902.Text = "Add or change an image on a button or image shape";
            treeNode903.Name = "Node1";
            treeNode903.Text = "Add an animated gif or tiled image";
            treeNode904.Name = "Node0";
            treeNode904.Text = "LDShapes";
            treeNode905.Name = "Node0";
            treeNode905.Text = "Version 1.0.0.16";
            treeNode906.Name = "Node1";
            treeNode906.Text = "A webcam object for the GraphicsWindow, including a picture taking function";
            treeNode907.Name = "Node0";
            treeNode907.Text = "LDWebCam";
            treeNode908.Name = "Node0";
            treeNode908.Text = "Version 1.0.0.15";
            treeNode909.Name = "Node2";
            treeNode909.Text = "Variables may be changed during a debug session";
            treeNode910.Name = "Node1";
            treeNode910.Text = "LDDebug";
            treeNode911.Name = "Node0";
            treeNode911.Text = "Version 1.0.0.14";
            treeNode912.Name = "Node1";
            treeNode912.Text = "A basic debugging tool";
            treeNode913.Name = "Node0";
            treeNode913.Text = "LDDebug";
            treeNode914.Name = "Node0";
            treeNode914.Text = "Version 1.0.0.13";
            treeNode915.Name = "Node2";
            treeNode915.Text = "Methods to convert between HSL and RGB";
            treeNode916.Name = "Node18";
            treeNode916.Text = "Method to set colour opacity";
            treeNode917.Name = "Node19";
            treeNode917.Text = "Methods to get R, G, B and H, S, L for a colour";
            treeNode918.Name = "Node1";
            treeNode918.Text = "LDColours";
            treeNode919.Name = "Node4";
            treeNode919.Text = "Methods to add and subtract dates and times";
            treeNode920.Name = "Node3";
            treeNode920.Text = "LDDateTime";
            treeNode921.Name = "Node6";
            treeNode921.Text = "Waiting overlay, Calendar and About popups";
            treeNode922.Name = "Node17";
            treeNode922.Text = "Tooltips";
            treeNode923.Name = "Node5";
            treeNode923.Text = "LDDialogs";
            treeNode924.Name = "Node8";
            treeNode924.Text = "File change event";
            treeNode925.Name = "Node7";
            treeNode925.Text = "LDEvents";
            treeNode926.Name = "Node0";
            treeNode926.Text = "Version 1.0.0.12";
            treeNode927.Name = "Node12";
            treeNode927.Text = "Methods to sort arrays by index or value";
            treeNode928.Name = "Node22";
            treeNode928.Text = "Sorting by number and character strings";
            treeNode929.Name = "Node11";
            treeNode929.Text = "LDSort";
            treeNode930.Name = "Node14";
            treeNode930.Text = "Statistics on any array and distribution generation";
            treeNode931.Name = "Node20";
            treeNode931.Text = "Includes integration and differentiation to convert between PDF and CDF";
            treeNode932.Name = "Node21";
            treeNode932.Text = "Normal, Binomial, Traingular and Uniform distributions";
            treeNode933.Name = "Node13";
            treeNode933.Text = "LDStatistics";
            treeNode934.Name = "Node16";
            treeNode934.Text = "Voice and volume added";
            treeNode935.Name = "Node15";
            treeNode935.Text = "LDSpeech";
            treeNode936.Name = "Node9";
            treeNode936.Text = "Version 1.0.0.11";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode31,
            treeNode45,
            treeNode56,
            treeNode71,
            treeNode86,
            treeNode99,
            treeNode108,
            treeNode123,
            treeNode134,
            treeNode148,
            treeNode157,
            treeNode169,
            treeNode180,
            treeNode183,
            treeNode192,
            treeNode199,
            treeNode206,
            treeNode219,
            treeNode230,
            treeNode235,
            treeNode242,
            treeNode245,
            treeNode259,
            treeNode267,
            treeNode273,
            treeNode288,
            treeNode303,
            treeNode309,
            treeNode317,
            treeNode332,
            treeNode349,
            treeNode352,
            treeNode358,
            treeNode364,
            treeNode374,
            treeNode383,
            treeNode386,
            treeNode406,
            treeNode412,
            treeNode415,
            treeNode424,
            treeNode432,
            treeNode438,
            treeNode443,
            treeNode449,
            treeNode452,
            treeNode465,
            treeNode468,
            treeNode473,
            treeNode478,
            treeNode481,
            treeNode487,
            treeNode491,
            treeNode494,
            treeNode500,
            treeNode504,
            treeNode512,
            treeNode518,
            treeNode524,
            treeNode527,
            treeNode534,
            treeNode541,
            treeNode549,
            treeNode552,
            treeNode555,
            treeNode561,
            treeNode566,
            treeNode573,
            treeNode578,
            treeNode584,
            treeNode587,
            treeNode594,
            treeNode599,
            treeNode603,
            treeNode616,
            treeNode624,
            treeNode629,
            treeNode635,
            treeNode638,
            treeNode645,
            treeNode648,
            treeNode656,
            treeNode659,
            treeNode662,
            treeNode666,
            treeNode670,
            treeNode673,
            treeNode676,
            treeNode679,
            treeNode682,
            treeNode685,
            treeNode688,
            treeNode691,
            treeNode695,
            treeNode698,
            treeNode701,
            treeNode704,
            treeNode712,
            treeNode714,
            treeNode720,
            treeNode726,
            treeNode731,
            treeNode736,
            treeNode739,
            treeNode742,
            treeNode745,
            treeNode748,
            treeNode754,
            treeNode757,
            treeNode760,
            treeNode763,
            treeNode772,
            treeNode775,
            treeNode778,
            treeNode782,
            treeNode791,
            treeNode797,
            treeNode802,
            treeNode811,
            treeNode814,
            treeNode817,
            treeNode822,
            treeNode827,
            treeNode830,
            treeNode833,
            treeNode836,
            treeNode843,
            treeNode848,
            treeNode853,
            treeNode860,
            treeNode863,
            treeNode871,
            treeNode876,
            treeNode879,
            treeNode882,
            treeNode885,
            treeNode888,
            treeNode894,
            treeNode899,
            treeNode905,
            treeNode908,
            treeNode911,
            treeNode914,
            treeNode926,
            treeNode936});
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