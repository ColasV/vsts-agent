﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AgentService {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AgentService.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized string similar to Agent listener exit with retryable error, re-launch agent in 5 seconds..
        /// </summary>
        internal static string AgentExitWithError {
            get {
                return ResourceManager.GetString("AgentExitWithError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Agent listener exit with 0 return code, stop the service, no retry needed..
        /// </summary>
        internal static string AgentExitWithoutError {
            get {
                return ResourceManager.GetString("AgentExitWithoutError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Agent listener exit with terminated error, stop the service, no retry needed..
        /// </summary>
        internal static string AgentExitWithTerminatedError {
            get {
                return ResourceManager.GetString("AgentExitWithTerminatedError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Agent listener exit with undefined return code, re-launch agent in 5 seconds..
        /// </summary>
        internal static string AgentExitWithUndefinedReturnCode {
            get {
                return ResourceManager.GetString("AgentExitWithUndefinedReturnCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Agent listener exit because of updating, re-launch agent in 5 seconds..
        /// </summary>
        internal static string AgentUpdateInProcess {
            get {
                return ResourceManager.GetString("AgentUpdateInProcess", resourceCulture);
            }
        }
    }
}
