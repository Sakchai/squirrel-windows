﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGet.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class AnalysisResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AnalysisResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NuGet.Resources.AnalysisResources", typeof(AnalysisResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The assembly &apos;{0}&apos; is not inside the &apos;lib&apos; folder and hence it won&apos;t be added as reference when the package is installed into a project..
        /// </summary>
        internal static string AssemblyOutsideLibDescription {
            get {
                return ResourceManager.GetString("AssemblyOutsideLibDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move it into the &apos;lib&apos; folder if it should be referenced..
        /// </summary>
        internal static string AssemblyOutsideLibSolution {
            get {
                return ResourceManager.GetString("AssemblyOutsideLibSolution", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Assembly outside lib folder..
        /// </summary>
        internal static string AssemblyOutsideLibTitle {
            get {
                return ResourceManager.GetString("AssemblyOutsideLibTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The assembly &apos;{0}&apos; is placed directly under &apos;lib&apos; folder. It is recommended that assemblies be placed inside a framework-specific folder..
        /// </summary>
        internal static string AssemblyUnderLibDescription {
            get {
                return ResourceManager.GetString("AssemblyUnderLibDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move it into a framework-specific folder. If this assembly is targeted for multiple frameworks, ignore this warning..
        /// </summary>
        internal static string AssemblyUnderLibSolution {
            get {
                return ResourceManager.GetString("AssemblyUnderLibSolution", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Assembly not inside a framework folder..
        /// </summary>
        internal static string AssemblyUnderLibTitle {
            get {
                return ResourceManager.GetString("AssemblyUnderLibTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The folder &apos;{0}&apos; under &apos;lib&apos; is not recognized as a valid framework name or a supported culture identifier..
        /// </summary>
        internal static string InvalidFrameworkDescription {
            get {
                return ResourceManager.GetString("InvalidFrameworkDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rename it to a valid framework name..
        /// </summary>
        internal static string InvalidFrameworkSolution {
            get {
                return ResourceManager.GetString("InvalidFrameworkSolution", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid framework folder..
        /// </summary>
        internal static string InvalidFrameworkTitle {
            get {
                return ResourceManager.GetString("InvalidFrameworkTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file &apos;{0}&apos; will be ignored by NuGet because it is not directly under &apos;tools&apos; folder..
        /// </summary>
        internal static string MisplacedInitScriptDescription {
            get {
                return ResourceManager.GetString("MisplacedInitScriptDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Place the file directly under &apos;tools&apos; folder..
        /// </summary>
        internal static string MisplacedInitScriptSolution {
            get {
                return ResourceManager.GetString("MisplacedInitScriptSolution", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Init.ps1 script will be ignored..
        /// </summary>
        internal static string MisplacedInitScriptTitle {
            get {
                return ResourceManager.GetString("MisplacedInitScriptTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The transform file &apos;{0}&apos; is outside the &apos;content&apos; folder and hence will not be transformed during installation of this package..
        /// </summary>
        internal static string MisplacedTransformFileDescription {
            get {
                return ResourceManager.GetString("MisplacedTransformFileDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move it into the &apos;content&apos; folder..
        /// </summary>
        internal static string MisplacedTransformFileSolution {
            get {
                return ResourceManager.GetString("MisplacedTransformFileSolution", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Transform file outside content folder..
        /// </summary>
        internal static string MisplacedTransformFileTitle {
            get {
                return ResourceManager.GetString("MisplacedTransformFileTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Description text is long but the Summary text is empty. This means the Description text will be truncated in the &apos;Manage NuGet Packages&apos; dialog..
        /// </summary>
        internal static string MissingSummaryDescription {
            get {
                return ResourceManager.GetString("MissingSummaryDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provide a brief summary of the package in the Summary field..
        /// </summary>
        internal static string MissingSummarySolution {
            get {
                return ResourceManager.GetString("MissingSummarySolution", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Consider providing Summary text..
        /// </summary>
        internal static string MissingSummaryTitle {
            get {
                return ResourceManager.GetString("MissingSummaryTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The script file &apos;{0}&apos; is outside the &apos;tools&apos; folder and hence will not be executed during installation of this package..
        /// </summary>
        internal static string ScriptOutsideToolsDescription {
            get {
                return ResourceManager.GetString("ScriptOutsideToolsDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move it into the &apos;tools&apos; folder..
        /// </summary>
        internal static string ScriptOutsideToolsSolution {
            get {
                return ResourceManager.GetString("ScriptOutsideToolsSolution", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PowerShell file outside tools folder..
        /// </summary>
        internal static string ScriptOutsideToolsTitle {
            get {
                return ResourceManager.GetString("ScriptOutsideToolsTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The script file &apos;{0}&apos; is not recognized by NuGet and hence will not be executed during installation of this package..
        /// </summary>
        internal static string UnrecognizedScriptDescription {
            get {
                return ResourceManager.GetString("UnrecognizedScriptDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rename it to install.ps1, uninstall.ps1 or init.ps1 and place it directly under &apos;tools&apos;..
        /// </summary>
        internal static string UnrecognizedScriptSolution {
            get {
                return ResourceManager.GetString("UnrecognizedScriptSolution", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unrecognized PowerShell file..
        /// </summary>
        internal static string UnrecognizedScriptTitle {
            get {
                return ResourceManager.GetString("UnrecognizedScriptTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file at &apos;{0}&apos; uses the obsolete &apos;WinRT&apos; as the framework folder..
        /// </summary>
        internal static string WinRTObsoleteDescription {
            get {
                return ResourceManager.GetString("WinRTObsoleteDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Replace &apos;WinRT&apos; or &apos;WinRT45&apos; with &apos;NetCore45&apos;..
        /// </summary>
        internal static string WinRTObsoleteSolution {
            get {
                return ResourceManager.GetString("WinRTObsoleteSolution", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The framework name &apos;WinRT&apos; is obsolete..
        /// </summary>
        internal static string WinRTObsoleteTitle {
            get {
                return ResourceManager.GetString("WinRTObsoleteTitle", resourceCulture);
            }
        }
    }
}
