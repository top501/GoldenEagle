﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.296
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.ImageViewer.RoiGraphics {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class RoiSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static RoiSettings defaultInstance = ((RoiSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new RoiSettings())));
        
        public static RoiSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// Controls whether or not ROI stats should be shown on new ROI objects by default.
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Controls whether or not ROI stats should be shown on new ROI objects by default.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowAnalysisByDefault {
            get {
                return ((bool)(this["ShowAnalysisByDefault"]));
            }
            set {
                this["ShowAnalysisByDefault"] = value;
            }
        }
        
        /// <summary>
        /// Controls the preferred linear, area and volume units of ROI analysis output. (Pixels, Millimeters, Centimeters)
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Controls the preferred linear, area and volume units of ROI analysis output. (Pix" +
            "els, Millimeters, Centimeters)")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Centimeters")]
        public global::ClearCanvas.ImageViewer.RoiGraphics.Units AnalysisUnits {
            get {
                return ((global::ClearCanvas.ImageViewer.RoiGraphics.Units)(this["AnalysisUnits"]));
            }
            set {
                this["AnalysisUnits"] = value;
            }
        }
    }
}