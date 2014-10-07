﻿using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.RoadEditor.gui
    {
    public class RoadEditorSettingsTab
        {
        [ConsoleInteraction(true, "RoadEditorSettingsTab_initialize")]
        public static void initialize()
            {
            #region GuiControl (RoadEditorSettingsTab,EditorGuiGroup)        oc_Newobject22

            ObjectCreator oc_Newobject22 = new ObjectCreator("GuiControl", "RoadEditorSettingsTab,EditorGuiGroup");
            oc_Newobject22["isContainer"] = "1";
            oc_Newobject22["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject22["HorizSizing"] = "right";
            oc_Newobject22["VertSizing"] = "bottom";
            oc_Newobject22["position"] = "0 0";
            oc_Newobject22["Extent"] = "800 600";
            oc_Newobject22["MinExtent"] = "8 2";
            oc_Newobject22["canSave"] = "1";
            oc_Newobject22["Visible"] = "1";
            oc_Newobject22["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject22["hovertime"] = "1000";
            oc_Newobject22["canSaveDynamicFields"] = "1";

            #region GuiTabPageCtrl (ERoadEditorSettingsPage)        oc_Newobject21

            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiTabPageCtrl", "ERoadEditorSettingsPage");
            oc_Newobject21["fitBook"] = "1";
            oc_Newobject21["text"] = "Road Editor";
            oc_Newobject21["maxLength"] = "1024";
            oc_Newobject21["Margin"] = "0 0 0 0";
            oc_Newobject21["Padding"] = "0 0 0 0";
            oc_Newobject21["AnchorTop"] = "1";
            oc_Newobject21["AnchorBottom"] = "0";
            oc_Newobject21["AnchorLeft"] = "1";
            oc_Newobject21["AnchorRight"] = "0";
            oc_Newobject21["isContainer"] = "1";
            oc_Newobject21["Profile"] = "ToolsGuiSolidDefaultProfile";
            oc_Newobject21["HorizSizing"] = "width";
            oc_Newobject21["VertSizing"] = "height";
            oc_Newobject21["position"] = "0 0";
            oc_Newobject21["Extent"] = "208 400";
            oc_Newobject21["MinExtent"] = "8 2";
            oc_Newobject21["canSave"] = "1";
            oc_Newobject21["Visible"] = "1";
            oc_Newobject21["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject21["hovertime"] = "1000";
            oc_Newobject21["canSaveDynamicFields"] = "1";

            #region GuiScrollCtrl ()        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject20["willFirstRespond"] = "1";
            oc_Newobject20["hScrollBar"] = "alwaysOff";
            oc_Newobject20["vScrollBar"] = "dynamic";
            oc_Newobject20["lockHorizScroll"] = "1";
            oc_Newobject20["lockVertScroll"] = "0";
            oc_Newobject20["constantThumbHeight"] = "0";
            oc_Newobject20["childMargin"] = "0 0";
            oc_Newobject20["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject20["Margin"] = "0 0 0 0";
            oc_Newobject20["Padding"] = "0 0 0 0";
            oc_Newobject20["AnchorTop"] = "1";
            oc_Newobject20["AnchorBottom"] = "0";
            oc_Newobject20["AnchorLeft"] = "1";
            oc_Newobject20["AnchorRight"] = "0";
            oc_Newobject20["isContainer"] = "1";
            oc_Newobject20["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject20["HorizSizing"] = "width";
            oc_Newobject20["VertSizing"] = "height";
            oc_Newobject20["position"] = "0 0";
            oc_Newobject20["Extent"] = "208 400";
            oc_Newobject20["MinExtent"] = "8 2";
            oc_Newobject20["canSave"] = "1";
            oc_Newobject20["Visible"] = "1";
            oc_Newobject20["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject20["hovertime"] = "1000";
            oc_Newobject20["canSaveDynamicFields"] = "0";

            #region GuiStackControl ()        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject19["StackingType"] = "Vertical";
            oc_Newobject19["HorizStacking"] = "Left to Right";
            oc_Newobject19["VertStacking"] = "Top to Bottom";
            oc_Newobject19["Padding"] = "0";
            oc_Newobject19["isContainer"] = "1";
            oc_Newobject19["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject19["HorizSizing"] = "width";
            oc_Newobject19["VertSizing"] = "bottom";
            oc_Newobject19["position"] = "1 1";
            oc_Newobject19["extent"] = "208 210";
            oc_Newobject19["MinExtent"] = "8 2";
            oc_Newobject19["canSave"] = "1";
            oc_Newobject19["isDecoy"] = "0";
            oc_Newobject19["Visible"] = "1";
            oc_Newobject19["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject19["hovertime"] = "1000";

            #region GuiRolloutCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiRolloutCtrl", "");
            oc_Newobject8["Profile"] = "GuiRolloutProfile";
            oc_Newobject8["HorizSizing"] = "right";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["position"] = "10 10";
            oc_Newobject8["extent"] = "208 95";
            oc_Newobject8["Caption"] = "Defaults";
            oc_Newobject8["Margin"] = "0 3 0 0";
            oc_Newobject8["DragSizable"] = new ObjectCreator.StringNoQuote("false");
            oc_Newobject8["container"] = new ObjectCreator.StringNoQuote("true");

            #region GuiStackControl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject7["StackingType"] = "Vertical";
            oc_Newobject7["HorizStacking"] = "Left to Right";
            oc_Newobject7["VertStacking"] = "Top to Bottom";
            oc_Newobject7["Padding"] = "0";
            oc_Newobject7["isContainer"] = "1";
            oc_Newobject7["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject7["HorizSizing"] = "width";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["position"] = "0 0";
            oc_Newobject7["Extent"] = "208 0";
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["isDecoy"] = "0";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["padding"] = "3";

            #region GuiControl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiControl", "");
            oc_Newobject3["isContainer"] = "1";
            oc_Newobject3["horizSizing"] = "right";
            oc_Newobject3["vertSizing"] = "bottom";
            oc_Newobject3["extent"] = "208 18";

            #region GuiTextCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject1["text"] = "Width:";
            oc_Newobject1["maxLength"] = "1024";
            oc_Newobject1["Margin"] = "0 0 0 0";
            oc_Newobject1["Padding"] = "0 0 0 0";
            oc_Newobject1["AnchorTop"] = "1";
            oc_Newobject1["AnchorBottom"] = "0";
            oc_Newobject1["AnchorLeft"] = "1";
            oc_Newobject1["AnchorRight"] = "0";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject1["HorizSizing"] = "right";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["position"] = "5 1";
            oc_Newobject1["Extent"] = "70 16";
            oc_Newobject1["MinExtent"] = "8 2";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject3["#Newobject1"] = oc_Newobject1;

            #region GuiTextEditCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiTextEditCtrl", "",
                typeof (ESettingsWindow.ESettingsWindowTextEdit));
            oc_Newobject2["historySize"] = "0";
            oc_Newobject2["password"] = "0";
            oc_Newobject2["tabComplete"] = "0";
            oc_Newobject2["sinkAllKeyEvents"] = "0";
            oc_Newobject2["passwordMask"] = "*";
            oc_Newobject2["maxLength"] = "1024";
            oc_Newobject2["Margin"] = "0 0 0 0";
            oc_Newobject2["Padding"] = "0 0 0 0";
            oc_Newobject2["AnchorTop"] = "1";
            oc_Newobject2["AnchorBottom"] = "0";
            oc_Newobject2["AnchorLeft"] = "1";
            oc_Newobject2["AnchorRight"] = "0";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["Profile"] = "ToolsGuiNumericTextEditProfile";
            oc_Newobject2["HorizSizing"] = "width";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["position"] = "81 0";
            oc_Newobject2["Extent"] = "121 18";
            oc_Newobject2["MinExtent"] = "8 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["canSaveDynamicFields"] = "1";
            //oc_Newobject2["class"] = "ESettingsWindowTextEdit";
            // oc_Newobject2["className"] = "ESettingsWindowTextEdit";
            oc_Newobject2["editorSettingsRead"] = "RoadEditorPlugin.readSettings();";
            oc_Newobject2["editorSettingsValue"] = "RoadEditor/DefaultWidth";
            oc_Newobject2["editorSettingsWrite"] = "RoadEditorPlugin.writeSettings();";

            #endregion

            oc_Newobject3["#Newobject2"] = oc_Newobject2;

            #endregion

            oc_Newobject7["#Newobject3"] = oc_Newobject3;

            #region GuiControl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiControl", "");
            oc_Newobject6["isContainer"] = "1";
            oc_Newobject6["horizSizing"] = "right";
            oc_Newobject6["vertSizing"] = "bottom";
            oc_Newobject6["extent"] = "208 18";

            #region GuiTextCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject4["text"] = "Material:";
            oc_Newobject4["maxLength"] = "1024";
            oc_Newobject4["Margin"] = "0 0 0 0";
            oc_Newobject4["Padding"] = "0 0 0 0";
            oc_Newobject4["AnchorTop"] = "1";
            oc_Newobject4["AnchorBottom"] = "0";
            oc_Newobject4["AnchorLeft"] = "1";
            oc_Newobject4["AnchorRight"] = "0";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject4["HorizSizing"] = "right";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["position"] = "5 1";
            oc_Newobject4["Extent"] = "70 16";
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject6["#Newobject4"] = oc_Newobject4;

            #region GuiTextEditCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiTextEditCtrl", "",
                typeof (ESettingsWindow.ESettingsWindowTextEdit));
            oc_Newobject5["historySize"] = "0";
            oc_Newobject5["password"] = "0";
            oc_Newobject5["tabComplete"] = "0";
            oc_Newobject5["sinkAllKeyEvents"] = "0";
            oc_Newobject5["passwordMask"] = "*";
            oc_Newobject5["maxLength"] = "1024";
            oc_Newobject5["Margin"] = "0 0 0 0";
            oc_Newobject5["Padding"] = "0 0 0 0";
            oc_Newobject5["AnchorTop"] = "1";
            oc_Newobject5["AnchorBottom"] = "0";
            oc_Newobject5["AnchorLeft"] = "1";
            oc_Newobject5["AnchorRight"] = "0";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject5["HorizSizing"] = "width";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["position"] = "81 0";
            oc_Newobject5["Extent"] = "121 18";
            oc_Newobject5["MinExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["canSaveDynamicFields"] = "1";
            //oc_Newobject5["class"] = "ESettingsWindowTextEdit";
            //oc_Newobject5["className"] = "ESettingsWindowTextEdit";
            oc_Newobject5["editorSettingsRead"] = "RoadEditorPlugin.readSettings();";
            oc_Newobject5["editorSettingsValue"] = "RoadEditor/MaterialName";
            oc_Newobject5["editorSettingsWrite"] = "RoadEditorPlugin.writeSettings();";

            #endregion

            oc_Newobject6["#Newobject5"] = oc_Newobject5;

            #endregion

            oc_Newobject7["#Newobject6"] = oc_Newobject6;

            #endregion

            oc_Newobject8["#Newobject7"] = oc_Newobject7;

            #endregion

            oc_Newobject19["#Newobject8"] = oc_Newobject8;

            #region GuiRolloutCtrl ()        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiRolloutCtrl", "");
            oc_Newobject18["Profile"] = "GuiRolloutProfile";
            oc_Newobject18["HorizSizing"] = "right";
            oc_Newobject18["VertSizing"] = "bottom";
            oc_Newobject18["position"] = "10 10";
            oc_Newobject18["extent"] = "208 95";
            oc_Newobject18["Caption"] = "Colors";
            oc_Newobject18["Margin"] = "0 3 0 0";
            oc_Newobject18["DragSizable"] = new ObjectCreator.StringNoQuote("false");
            oc_Newobject18["container"] = new ObjectCreator.StringNoQuote("true");

            #region GuiStackControl ()        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject17["StackingType"] = "Vertical";
            oc_Newobject17["HorizStacking"] = "Left to Right";
            oc_Newobject17["VertStacking"] = "Top to Bottom";
            oc_Newobject17["Padding"] = "0";
            oc_Newobject17["isContainer"] = "1";
            oc_Newobject17["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject17["HorizSizing"] = "width";
            oc_Newobject17["VertSizing"] = "bottom";
            oc_Newobject17["position"] = "0 0";
            oc_Newobject17["Extent"] = "208 0";
            oc_Newobject17["MinExtent"] = "8 2";
            oc_Newobject17["canSave"] = "1";
            oc_Newobject17["isDecoy"] = "0";
            oc_Newobject17["Visible"] = "1";
            oc_Newobject17["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject17["hovertime"] = "1000";
            oc_Newobject17["padding"] = "3";

            #region GuiControl ()        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiControl", "",
                typeof (ESettingsWindow.ESettingsWindowColor));
            oc_Newobject12["isContainer"] = "1";
            oc_Newobject12["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject12["HorizSizing"] = "right";
            oc_Newobject12["VertSizing"] = "bottom";
            oc_Newobject12["position"] = "5 10";
            oc_Newobject12["Extent"] = "208 18";
            oc_Newobject12["MinExtent"] = "8 2";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["Visible"] = "1";
            oc_Newobject12["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject12["hovertime"] = "1000";
            oc_Newobject12["canSaveDynamicFields"] = "1";
            //oc_Newobject12["class"] = "ESettingsWindowColor";
            //oc_Newobject12["className"] = "ESettingsWindowColor";
            oc_Newobject12["editorSettingsRead"] = "RoadEditorPlugin.readSettings();";
            oc_Newobject12["editorSettingsValue"] = "RoadEditor/HoverSplineColor";
            oc_Newobject12["editorSettingsWrite"] = "RoadEditorPlugin.writeSettings();";

            #region GuiTextCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject9["text"] = "Hover Spline:";
            oc_Newobject9["maxLength"] = "1024";
            oc_Newobject9["Margin"] = "0 0 0 0";
            oc_Newobject9["Padding"] = "0 0 0 0";
            oc_Newobject9["AnchorTop"] = "1";
            oc_Newobject9["AnchorBottom"] = "0";
            oc_Newobject9["AnchorLeft"] = "1";
            oc_Newobject9["AnchorRight"] = "0";
            oc_Newobject9["isContainer"] = "0";
            oc_Newobject9["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject9["HorizSizing"] = "right";
            oc_Newobject9["VertSizing"] = "bottom";
            oc_Newobject9["position"] = "0 1";
            oc_Newobject9["Extent"] = "70 16";
            oc_Newobject9["MinExtent"] = "8 2";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["canSaveDynamicFields"] = "1";

            #endregion

            oc_Newobject12["#Newobject9"] = oc_Newobject9;

            #region GuiTextEditCtrl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiTextEditCtrl", "",
                typeof (ESettingsWindow.ESettingsWindowColorEdit));
            oc_Newobject10["historySize"] = "0";
            oc_Newobject10["password"] = "0";
            oc_Newobject10["tabComplete"] = "0";
            oc_Newobject10["sinkAllKeyEvents"] = "0";
            oc_Newobject10["passwordMask"] = "*";
            oc_Newobject10["maxLength"] = "1024";
            oc_Newobject10["Margin"] = "0 0 0 0";
            oc_Newobject10["Padding"] = "0 0 0 0";
            oc_Newobject10["AnchorTop"] = "1";
            oc_Newobject10["AnchorBottom"] = "0";
            oc_Newobject10["AnchorLeft"] = "1";
            oc_Newobject10["AnchorRight"] = "0";
            oc_Newobject10["isContainer"] = "0";
            oc_Newobject10["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject10["HorizSizing"] = "width";
            oc_Newobject10["VertSizing"] = "bottom";
            oc_Newobject10["position"] = "80 0";
            oc_Newobject10["Extent"] = "104 18";
            oc_Newobject10["MinExtent"] = "8 2";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["Visible"] = "1";
            oc_Newobject10["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["internalName"] = "ColorEdit";
            oc_Newobject10["canSaveDynamicFields"] = "1";
            //oc_Newobject10["class"] = "ESettingsWindowColorEdit";
            // oc_Newobject10["className"] = "ESettingsWindowColorEdit";

            #endregion

            oc_Newobject12["#Newobject10"] = oc_Newobject10;

            #region GuiSwatchButtonCtrl ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiSwatchButtonCtrl", "",
                typeof (ESettingsWindow.ESettingsWindowColorButton));
            oc_Newobject11["color"] = "1 1 1 1";
            oc_Newobject11["groupNum"] = "-1";
            oc_Newobject11["buttonType"] = "PushButton";
            oc_Newobject11["useMouseEvents"] = "0";
            oc_Newobject11["isContainer"] = "0";
            oc_Newobject11["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject11["horizSizing"] = "left";
            oc_Newobject11["vertSizing"] = "bottom";
            oc_Newobject11["position"] = "188 2";
            oc_Newobject11["extent"] = "14 14";
            oc_Newobject11["MinExtent"] = "8 2";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["Visible"] = "1";
            oc_Newobject11["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject11["hovertime"] = "1000";
            oc_Newobject11["internalName"] = "ColorButton";
            oc_Newobject11["canSaveDynamicFields"] = "1";
            //oc_Newobject11["class"] = "ESettingsWindowColorButton";
            //oc_Newobject11["className"] = "ESettingsWindowColorButton";

            #endregion

            oc_Newobject12["#Newobject11"] = oc_Newobject11;

            #endregion

            oc_Newobject17["#Newobject12"] = oc_Newobject12;

            #region GuiControl ()        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiControl", "",
                typeof (ESettingsWindow.ESettingsWindowColor));
            oc_Newobject16["isContainer"] = "1";
            oc_Newobject16["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject16["HorizSizing"] = "right";
            oc_Newobject16["VertSizing"] = "bottom";
            oc_Newobject16["position"] = "5 30";
            oc_Newobject16["Extent"] = "208 18";
            oc_Newobject16["MinExtent"] = "8 2";
            oc_Newobject16["canSave"] = "1";
            oc_Newobject16["Visible"] = "1";
            oc_Newobject16["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject16["hovertime"] = "1000";
            oc_Newobject16["canSaveDynamicFields"] = "1";
            //oc_Newobject16["class"] = "ESettingsWindowColor";
            //oc_Newobject16["className"] = "ESettingsWindowColor";
            oc_Newobject16["editorSettingsRead"] = "RoadEditorPlugin.readSettings();";
            oc_Newobject16["editorSettingsValue"] = "RoadEditor/SelectedSplineColor";
            oc_Newobject16["editorSettingsWrite"] = "RoadEditorPlugin.writeSettings();";

            #region GuiTextCtrl ()        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject13["text"] = "Sel. Spline:";
            oc_Newobject13["maxLength"] = "1024";
            oc_Newobject13["Margin"] = "0 0 0 0";
            oc_Newobject13["Padding"] = "0 0 0 0";
            oc_Newobject13["AnchorTop"] = "1";
            oc_Newobject13["AnchorBottom"] = "0";
            oc_Newobject13["AnchorLeft"] = "1";
            oc_Newobject13["AnchorRight"] = "0";
            oc_Newobject13["isContainer"] = "0";
            oc_Newobject13["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject13["HorizSizing"] = "right";
            oc_Newobject13["VertSizing"] = "bottom";
            oc_Newobject13["position"] = "0 1";
            oc_Newobject13["Extent"] = "70 16";
            oc_Newobject13["MinExtent"] = "8 2";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["Visible"] = "1";
            oc_Newobject13["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject13["hovertime"] = "1000";
            oc_Newobject13["canSaveDynamicFields"] = "1";

            #endregion

            oc_Newobject16["#Newobject13"] = oc_Newobject13;

            #region GuiTextEditCtrl ()        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiTextEditCtrl", "",
                typeof (ESettingsWindow.ESettingsWindowColorEdit));
            oc_Newobject14["historySize"] = "0";
            oc_Newobject14["password"] = "0";
            oc_Newobject14["tabComplete"] = "0";
            oc_Newobject14["sinkAllKeyEvents"] = "0";
            oc_Newobject14["passwordMask"] = "*";
            oc_Newobject14["maxLength"] = "1024";
            oc_Newobject14["Margin"] = "0 0 0 0";
            oc_Newobject14["Padding"] = "0 0 0 0";
            oc_Newobject14["AnchorTop"] = "1";
            oc_Newobject14["AnchorBottom"] = "0";
            oc_Newobject14["AnchorLeft"] = "1";
            oc_Newobject14["AnchorRight"] = "0";
            oc_Newobject14["isContainer"] = "0";
            oc_Newobject14["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject14["HorizSizing"] = "width";
            oc_Newobject14["VertSizing"] = "bottom";
            oc_Newobject14["position"] = "80 0";
            oc_Newobject14["Extent"] = "104 18";
            oc_Newobject14["MinExtent"] = "8 2";
            oc_Newobject14["canSave"] = "1";
            oc_Newobject14["Visible"] = "1";
            oc_Newobject14["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject14["hovertime"] = "1000";
            oc_Newobject14["internalName"] = "ColorEdit";
            oc_Newobject14["canSaveDynamicFields"] = "1";
            //oc_Newobject14["class"] = "ESettingsWindowColorEdit";
            //oc_Newobject14["className"] = "ESettingsWindowColorEdit";

            #endregion

            oc_Newobject16["#Newobject14"] = oc_Newobject14;

            #region GuiSwatchButtonCtrl ()        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiSwatchButtonCtrl", "",
                typeof (ESettingsWindow.ESettingsWindowColorButton));
            oc_Newobject15["color"] = "1 1 1 1";
            oc_Newobject15["groupNum"] = "-1";
            oc_Newobject15["buttonType"] = "PushButton";
            oc_Newobject15["useMouseEvents"] = "0";
            oc_Newobject15["isContainer"] = "0";
            oc_Newobject15["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject15["horizSizing"] = "left";
            oc_Newobject15["vertSizing"] = "bottom";
            oc_Newobject15["position"] = "188 2";
            oc_Newobject15["extent"] = "14 14";
            oc_Newobject15["MinExtent"] = "8 2";
            oc_Newobject15["canSave"] = "1";
            oc_Newobject15["Visible"] = "1";
            oc_Newobject15["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject15["hovertime"] = "1000";
            oc_Newobject15["internalName"] = "ColorButton";
            oc_Newobject15["canSaveDynamicFields"] = "1";
            //oc_Newobject15["class"] = "ESettingsWindowColorButton";
            //oc_Newobject15["className"] = "ESettingsWindowColorButton";

            #endregion

            oc_Newobject16["#Newobject15"] = oc_Newobject15;

            #endregion

            oc_Newobject17["#Newobject16"] = oc_Newobject16;

            #endregion

            oc_Newobject18["#Newobject17"] = oc_Newobject17;

            #endregion

            oc_Newobject19["#Newobject18"] = oc_Newobject18;

            #endregion

            oc_Newobject20["#Newobject19"] = oc_Newobject19;

            #endregion

            oc_Newobject21["#Newobject20"] = oc_Newobject20;

            #endregion

            oc_Newobject22["#Newobject21"] = oc_Newobject21;

            #endregion

            oc_Newobject22.Create();
            }
        }
    }