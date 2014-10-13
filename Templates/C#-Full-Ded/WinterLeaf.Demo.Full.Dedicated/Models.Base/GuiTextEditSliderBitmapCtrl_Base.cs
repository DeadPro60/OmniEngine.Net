


#region
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Containers;
using WinterLeaf.Engine.Enums;
using System.ComponentModel;
using System.Threading;
using  WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using Winterleaf.Demo.Full.Dedicated.Models.User.Extendable;
#endregion

namespace Winterleaf.Demo.Full.Dedicated.Models.Base
    {
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(TypeConverterGeneric<GuiTextEditSliderBitmapCtrl_Base>))]
    public partial class GuiTextEditSliderBitmapCtrl_Base: GuiTextEditCtrl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiTextEditSliderBitmapCtrl_Base ts, string simobjectid)
            {
            return object.ReferenceEquals(ts, null) ? object.ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
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
            
            return (this._ID ==(string)myReflections.ChangeType( obj,typeof(string)));
            }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(GuiTextEditSliderBitmapCtrl_Base ts, string simobjectid)
            {
            if (object.ReferenceEquals(ts, null))
                return !object.ReferenceEquals(simobjectid, null);
            return !ts.Equals(simobjectid);

            }


            /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator string( GuiTextEditSliderBitmapCtrl_Base ts)
            {
            if (object.ReferenceEquals(ts, null))
                 return "0";
            return ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator GuiTextEditSliderBitmapCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiTextEditSliderBitmapCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiTextEditSliderBitmapCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiTextEditSliderBitmapCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiTextEditSliderBitmapCtrl_Base(int simobjectid)
            {
            return  (GuiTextEditSliderBitmapCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiTextEditSliderBitmapCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiTextEditSliderBitmapCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiTextEditSliderBitmapCtrl_Base(uint simobjectid)
            {
            return  (GuiTextEditSliderBitmapCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiTextEditSliderBitmapCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Unused 
/// </summary>
[MemberGroup("")]
public String bitmap
       {
       get
          {
          return Omni.self.GetVar(_ID + ".bitmap").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".bitmap", value.AsString());
          }
       }
/// <summary>
/// If true, the control will accept giving focus to the user when the mouse wheel is used.\n
/// </summary>
[MemberGroup("")]
public bool focusOnMouseWheel
       {
       get
          {
          return Omni.self.GetVar(_ID + ".focusOnMouseWheel").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".focusOnMouseWheel", value.AsString());
          }
       }
/// <summary>
/// Character format type to place in the control.\n
/// </summary>
[MemberGroup("")]
public String format
       {
       get
          {
          return Omni.self.GetVar(_ID + ".format").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".format", value.AsString());
          }
       }
/// <summary>
/// How far to increment the slider on each step.\n
/// </summary>
[MemberGroup("")]
public float increment
       {
       get
          {
          return Omni.self.GetVar(_ID + ".increment").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".increment", value.AsString());
          }
       }
/// <summary>
/// Maximum vertical and horizontal range to allow in the control.\n
/// </summary>
[MemberGroup("")]
public Point2F range
       {
       get
          {
          return Omni.self.GetVar(_ID + ".range").AsPoint2F();
          }
       set
          {
          Omni.self.SetVar(_ID + ".range", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public GuiTextEditSliderBitmapCtrl_Base (){}
}}
