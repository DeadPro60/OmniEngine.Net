﻿using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.RoadEditor.gui;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.ToolsPaletteGroups
    {
    public class RoadEditorPalette
        {
        public static uint initialize()
            {
            #region GuiControl (RoadEditorPalette,EditorGuiGroup)        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiControl", "RoadEditorPalette,EditorGuiGroup",
                typeof (RoadEditorPalette));
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["Enabled"] = "1";
            oc_Newobject7["isContainer"] = "1";
            oc_Newobject7["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject7["HorizSizing"] = "right";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["Position"] = "0 0";
            oc_Newobject7["Extent"] = "1024 768";
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["hovertime"] = "1000";

            #region GuiBitmapButtonCtrl (ERoadEditorSelectModeBtn)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiBitmapButtonCtrl", "ERoadEditorSelectModeBtn",
                typeof (RoadEditorGui.ERoadEditorSelectModeBtn));
            oc_Newobject1["canSaveDynamicFields"] = "0";
            oc_Newobject1["internalName"] = "RoadEditorSelectMode";
            oc_Newobject1["Enabled"] = "1";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject1["HorizSizing"] = "right";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["Position"] = "0 0";
            oc_Newobject1["Extent"] = "25 19";
            oc_Newobject1["MinExtent"] = "8 2";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["Command"] = "RoadEditorGui.prepSelectionMode();";
            oc_Newobject1["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject1["ToolTip"] = "Select Road (1)";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["bitmap"] = "tools/gui/images/menubar/arrow";
            oc_Newobject1["buttonType"] = "RadioButton";
            oc_Newobject1["useMouseEvents"] = "0";

            #endregion

            oc_Newobject7["#Newobject1"] = oc_Newobject1;

            #region GuiBitmapButtonCtrl (ERoadEditorMoveModeBtn)        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiBitmapButtonCtrl", "ERoadEditorMoveModeBtn",
                typeof (RoadEditorGui.ERoadEditorMoveModeBtn));
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["internalName"] = "RoadEditorMoveMode";
            oc_Newobject2["Enabled"] = "1";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject2["HorizSizing"] = "right";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["Position"] = "0 0";
            oc_Newobject2["Extent"] = "25 19";
            oc_Newobject2["MinExtent"] = "8 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["Command"] = "RoadEditorGui.setMode(\\\"RoadEditorMoveMode\\\");";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["ToolTip"] = "Move Point (2)";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["bitmap"] = "tools/worldEditor/images/road-river/move-point";
            oc_Newobject2["buttonType"] = "RadioButton";
            oc_Newobject2["useMouseEvents"] = "0";

            #endregion

            oc_Newobject7["#Newobject2"] = oc_Newobject2;

            #region GuiBitmapButtonCtrl (ERoadEditorScaleModeBtn)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiBitmapButtonCtrl", "ERoadEditorScaleModeBtn",
                typeof (RoadEditorGui.ERoadEditorScaleModeBtn));
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["internalName"] = "RoadEditorScaleMode";
            oc_Newobject3["Enabled"] = "1";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject3["HorizSizing"] = "right";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["Position"] = "0 0";
            oc_Newobject3["Extent"] = "25 19";
            oc_Newobject3["MinExtent"] = "8 2";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["Command"] = "RoadEditorGui.setMode(\\\"RoadEditorScaleMode\\\");";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["ToolTip"] = "Scale Point (4)";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["bitmap"] = "tools/worldEditor/images/road-river/scale-point";
            oc_Newobject3["buttonType"] = "RadioButton";
            oc_Newobject3["useMouseEvents"] = "0";

            #endregion

            oc_Newobject7["#Newobject3"] = oc_Newobject3;

            #region GuiBitmapButtonCtrl (ERoadEditorAddModeBtn)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiBitmapButtonCtrl", "ERoadEditorAddModeBtn",
                typeof (RoadEditorGui.ERoadEditorAddModeBtn));
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["internalName"] = "RoadEditorAddRoadMode";
            oc_Newobject4["Enabled"] = "1";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject4["HorizSizing"] = "right";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["Position"] = "0 0";
            oc_Newobject4["Extent"] = "25 19";
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["Command"] = "RoadEditorGui.setMode(\\\"RoadEditorAddRoadMode\\\");";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["ToolTip"] = "Create Road (5)";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["bitmap"] = "tools/worldEditor/images/road-river/add-road-path";
            oc_Newobject4["buttonType"] = "RadioButton";
            oc_Newobject4["useMouseEvents"] = "0";

            #endregion

            oc_Newobject7["#Newobject4"] = oc_Newobject4;

            #region GuiBitmapButtonCtrl (ERoadEditorInsertModeBtn)        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiBitmapButtonCtrl", "ERoadEditorInsertModeBtn",
                typeof (RoadEditorGui.ERoadEditorInsertModeBtn));
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["internalName"] = "RoadEditorInsertPointMode";
            oc_Newobject5["Enabled"] = "1";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["Position"] = "0 0";
            oc_Newobject5["Extent"] = "25 19";
            oc_Newobject5["MinExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["Command"] = "RoadEditorGui.setMode(\\\"RoadEditorInsertPointMode\\\");";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["ToolTip"] = "Insert Point (+)";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["bitmap"] = "tools/worldEditor/images/road-river/add-point";
            oc_Newobject5["buttonType"] = "RadioButton";
            oc_Newobject5["useMouseEvents"] = "0";

            #endregion

            oc_Newobject7["#Newobject5"] = oc_Newobject5;

            #region GuiBitmapButtonCtrl (ERoadEditorRemoveModeBtn)        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiBitmapButtonCtrl", "ERoadEditorRemoveModeBtn",
                typeof (RoadEditorGui.ERoadEditorRemoveModeBtn));
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["internalName"] = "RoadEditorRemovePointMode";
            oc_Newobject6["Enabled"] = "1";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["Position"] = "0 0";
            oc_Newobject6["Extent"] = "25 19";
            oc_Newobject6["MinExtent"] = "8 2";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["Command"] = "RoadEditorGui.setMode(\\\"RoadEditorRemovePointMode\\\");";
            oc_Newobject6["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["ToolTip"] = "Remove Point (-)";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["bitmap"] = "tools/worldEditor/images/road-river/subtract-point";
            oc_Newobject6["buttonType"] = "RadioButton";
            oc_Newobject6["useMouseEvents"] = "0";

            #endregion

            oc_Newobject7["#Newobject6"] = oc_Newobject6;

            #endregion

            return oc_Newobject7.Create();
            }
        }
    }