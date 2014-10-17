// WinterLeaf Entertainment
// Copyright (c) 2014, WinterLeaf Entertainment LLC
// 
// All rights reserved.
// 
// The use of the WinterLeaf Entertainment LLC OMNI "Community Edition" is governed by this license agreement ("Agreement").
// 
// These license terms are an agreement between WinterLeaf Entertainment LLC and you.  Please read them. They apply to the source code and any other assets or works that are included with the product named above, which includes the media on which you received it, if any. These terms also apply to any updates, supplements, internet-based services, and support services for this software and its associated assets, unless other terms accompany those items. If so, those terms apply. You must read and agree to this Agreement terms BEFORE installing OMNI "Community Edition" to your hard drive or using OMNI in any way. If you do not agree to the license terms, do not download, install or use OMNI. Please make copies of this Agreement for all those in your organization who need to be familiar with the license terms.
// 
// This license allows companies of any size, government entities or individuals to create, sell, rent, lease, or otherwise profit commercially from, games using executables created from the source code that accompanies OMNI "Community Edition".
// 
// BY CLICKING THE ACCEPTANCE BUTTON AND/OR INSTALLING OR USING OMNI "Community Edition", THE INDIVIDUAL ACCESSING OMNI ("LICENSEE") IS CONSENTING TO BE BOUND BY AND BECOME A PARTY TO THIS AGREEMENT. IF YOU DO NOT ACCEPT THESE TERMS, DO NOT INSTALL OR USE OMNI. IF YOU COMPLY WITH THESE LICENSE TERMS, YOU HAVE THE RIGHTS BELOW:
// 
// Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
// 
//     Redistributions of source code must retain the all copyright notice, this list of conditions and the following disclaimer.
//     Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
//     With respect to any Product that the Licensee develop using the Software:
//     Licensee shall:
//         display the OMNI Logo, in the start-up sequence of the Product (unless waived by WinterLeaf Entertainment);
//         display in the "About" box or in the credits screen of the Product the text "OMNI by WinterLeaf Entertainment";
//         display the OMNI Logo, on all external Product packaging materials and the back cover of any printed instruction manual or the end of any electronic instruction manual;
//         notify WinterLeaf Entertainment in writing that You are publicly releasing a Product that was developed using the Software within the first 30 days following the release; and
//         the Licensee hereby grant WinterLeaf Entertainment permission to refer to the Licensee or the name of any Product the Licensee develops using the Software for marketing purposes. All goodwill in each party's trademarks and logos will inure to the sole benefit of that party.
//     Neither the name of WinterLeaf Entertainment LLC or OMNI nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
//     The following restrictions apply to the use of OMNI "Community Edition":
//     Licensee may not:
//         create any derivative works of OMNI Engine, including but not limited to translations, localizations, or game making software other than Games;
//         redistribute, encumber, sell, rent, lease, sublicense, or otherwise transfer rights to OMNI "Community Edition"; or
//         remove or alter any trademark, logo, copyright or other proprietary notices, legends, symbols or labels in OMNI Engine; or
//         use the Software to develop or distribute any software that competes with the Software without WinterLeaf Entertainment�s prior written consent; or
//         use the Software for any illegal purpose.
// 
// THIS SOFTWARE IS PROVIDED BY WINTERLEAF ENTERTAINMENT LLC ''AS IS'' AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL WINTERLEAF ENTERTAINMENT LLC BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE. 

#region

using System;
using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Containers;

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<GuiMeshRoadEditorCtrl_Base>))]
    public partial class GuiMeshRoadEditorCtrl_Base : EditTSCtrl
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiMeshRoadEditorCtrl_Base ts, string simobjectid)
        {
            return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(GuiMeshRoadEditorCtrl_Base ts, string simobjectid)
        {
            if (ReferenceEquals(ts, null))
                return !ReferenceEquals(simobjectid, null);
            return !ts.Equals(simobjectid);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator string(GuiMeshRoadEditorCtrl_Base ts)
        {
            if (ReferenceEquals(ts, null))
                return "0";
            return ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator GuiMeshRoadEditorCtrl_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (GuiMeshRoadEditorCtrl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiMeshRoadEditorCtrl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GuiMeshRoadEditorCtrl_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiMeshRoadEditorCtrl_Base(int simobjectid)
        {
            return (GuiMeshRoadEditorCtrl) Omni.self.getSimObject((uint) simobjectid, typeof (GuiMeshRoadEditorCtrl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GuiMeshRoadEditorCtrl_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiMeshRoadEditorCtrl_Base(uint simobjectid)
        {
            return (GuiMeshRoadEditorCtrl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiMeshRoadEditorCtrl_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// Default Material used by the Mesh Road Editor on bottom surface road creation. 
        /// </summary>
        [MemberGroup("")]
        public String bottomMaterialName
        {
            get { return Omni.self.GetVar(_ID + ".bottomMaterialName").AsString(); }
            set { Omni.self.SetVar(_ID + ".bottomMaterialName", value.AsString()); }
        }

        /// <summary>
        /// 
        /// </summary>
        [MemberGroup("")]
        public float DefaultDepth
        {
            get { return Omni.self.GetVar(_ID + ".DefaultDepth").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".DefaultDepth", value.AsString()); }
        }

        /// <summary>
        /// 
        /// </summary>
        [MemberGroup("")]
        public Point3F DefaultNormal
        {
            get { return Omni.self.GetVar(_ID + ".DefaultNormal").AsPoint3F(); }
            set { Omni.self.SetVar(_ID + ".DefaultNormal", value.AsString()); }
        }

        /// <summary>
        /// 
        /// </summary>
        [MemberGroup("")]
        public float DefaultWidth
        {
            get { return Omni.self.GetVar(_ID + ".DefaultWidth").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".DefaultWidth", value.AsString()); }
        }

        /// <summary>
        /// 
        /// </summary>
        [MemberGroup("")]
        public ColorI HoverNodeColor
        {
            get { return Omni.self.GetVar(_ID + ".HoverNodeColor").AsColorI(); }
            set { Omni.self.SetVar(_ID + ".HoverNodeColor", value.AsString()); }
        }

        /// <summary>
        /// 
        /// </summary>
        [MemberGroup("")]
        public ColorI HoverSplineColor
        {
            get { return Omni.self.GetVar(_ID + ".HoverSplineColor").AsColorI(); }
            set { Omni.self.SetVar(_ID + ".HoverSplineColor", value.AsString()); }
        }

        /// <summary>
        /// 
        /// </summary>
        [MemberGroup("")]
        public bool isDirty
        {
            get { return Omni.self.GetVar(_ID + ".isDirty").AsBool(); }
            set { Omni.self.SetVar(_ID + ".isDirty", value.AsString()); }
        }

        /// <summary>
        /// 
        /// </summary>
        [MemberGroup("")]
        public ColorI SelectedSplineColor
        {
            get { return Omni.self.GetVar(_ID + ".SelectedSplineColor").AsColorI(); }
            set { Omni.self.SetVar(_ID + ".SelectedSplineColor", value.AsString()); }
        }

        /// <summary>
        /// Default Material used by the Mesh Road Editor on side surface road creation. 
        /// </summary>
        [MemberGroup("")]
        public String sideMaterialName
        {
            get { return Omni.self.GetVar(_ID + ".sideMaterialName").AsString(); }
            set { Omni.self.SetVar(_ID + ".sideMaterialName", value.AsString()); }
        }

        /// <summary>
        /// Default Material used by the Mesh Road Editor on upper surface road creation. 
        /// </summary>
        [MemberGroup("")]
        public String topMaterialName
        {
            get { return Omni.self.GetVar(_ID + ".topMaterialName").AsString(); }
            set { Omni.self.SetVar(_ID + ".topMaterialName", value.AsString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// deleteNode() )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void deleteNode()
        {
            m_ts.fn_GuiMeshRoadEditorCtrl_deleteNode(_ID);
        }

        /// <summary>
        ///  )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getMode()
        {
            return m_ts.fn_GuiMeshRoadEditorCtrl_getMode(_ID);
        }

        /// <summary>
        ///  )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public float getNodeDepth()
        {
            return m_ts.fn_GuiMeshRoadEditorCtrl_getNodeDepth(_ID);
        }

        /// <summary>
        ///  )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public Point3F getNodeNormal()
        {
            return new Point3F(m_ts.fn_GuiMeshRoadEditorCtrl_getNodeNormal(_ID));
        }

        /// <summary>
        ///  )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public Point3F getNodePosition()
        {
            return new Point3F(m_ts.fn_GuiMeshRoadEditorCtrl_getNodePosition(_ID));
        }

        /// <summary>
        ///  )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public float getNodeWidth()
        {
            return m_ts.fn_GuiMeshRoadEditorCtrl_getNodeWidth(_ID);
        }

        /// <summary>
        ///  )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getSelectedRoad()
        {
            return m_ts.fn_GuiMeshRoadEditorCtrl_getSelectedRoad(_ID);
        }

        /// <summary>
        ///  )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void matchTerrainToRoad()
        {
            m_ts.fn_GuiMeshRoadEditorCtrl_matchTerrainToRoad(_ID);
        }

        /// <summary>
        ///  )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void regenerate()
        {
            m_ts.fn_GuiMeshRoadEditorCtrl_regenerate(_ID);
        }

        /// <summary>
        /// setMode( String mode ) )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setMode(string mode)
        {
            m_ts.fn_GuiMeshRoadEditorCtrl_setMode(_ID, mode);
        }

        /// <summary>
        ///  )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setNodeDepth(float depth)
        {
            m_ts.fn_GuiMeshRoadEditorCtrl_setNodeDepth(_ID, depth);
        }

        /// <summary>
        ///  )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setNodeNormal(Point3F normal)
        {
            m_ts.fn_GuiMeshRoadEditorCtrl_setNodeNormal(_ID, normal.AsString());
        }

        /// <summary>
        ///  )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setNodePosition(Point3F pos)
        {
            m_ts.fn_GuiMeshRoadEditorCtrl_setNodePosition(_ID, pos.AsString());
        }

        /// <summary>
        ///  )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setNodeWidth(float width)
        {
            m_ts.fn_GuiMeshRoadEditorCtrl_setNodeWidth(_ID, width);
        }

        /// <summary>
        /// ),  )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setSelectedRoad(string objName = "")
        {
            m_ts.fn_GuiMeshRoadEditorCtrl_setSelectedRoad(_ID, objName);
        }

        #endregion

        #region T3D Callbacks

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onNodeModified(string nodeIdx)
        {
        }

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onNodeSelected(string nodeIdx)
        {
        }

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void paletteSync(string mode)
        {
        }

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onRoadSelected(string road)
        {
        }

        #endregion

        public GuiMeshRoadEditorCtrl_Base()
        {
        }
    }
}