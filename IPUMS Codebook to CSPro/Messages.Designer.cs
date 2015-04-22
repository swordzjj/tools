﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IPUMS2CSPro {
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
    internal class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("IPUMS2CSPro.Messages", typeof(Messages).Assembly);
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
        ///   Looks up a localized string similar to There was an error reading the IPUMS codebook:
        ///{0}.
        /// </summary>
        internal static string Codebook_ReadError {
            get {
                return ResourceManager.GetString("Codebook_ReadError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was an error creating the dictionary:
        ///{0}.
        /// </summary>
        internal static string Convert_Failure {
            get {
                return ResourceManager.GetString("Convert_Failure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was no housing record. Please select a different IPUMS codebook file..
        /// </summary>
        internal static string Convert_NoHousingRecord {
            get {
                return ResourceManager.GetString("Convert_NoHousingRecord", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must open a IPUMS codebook..
        /// </summary>
        internal static string Convert_OpenCodebook {
            get {
                return ResourceManager.GetString("Convert_OpenCodebook", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must select a CSPro dictionary..
        /// </summary>
        internal static string Convert_SelectDictionary {
            get {
                return ResourceManager.GetString("Convert_SelectDictionary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully created the CSPro dictionary..
        /// </summary>
        internal static string Convert_Success {
            get {
                return ResourceManager.GetString("Convert_Success", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The codebook has an invalid file type specification: {0}.
        /// </summary>
        internal static string InvalidFileType {
            get {
                return ResourceManager.GetString("InvalidFileType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The codebook did not have a proper variable availability key..
        /// </summary>
        internal static string InvalidVariableAvailability {
            get {
                return ResourceManager.GetString("InvalidVariableAvailability", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The codebook is missing the case selection..
        /// </summary>
        internal static string MissingCaseSelection {
            get {
                return ResourceManager.GetString("MissingCaseSelection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A colon was missing in line: {0}.
        /// </summary>
        internal static string MissingColon {
            get {
                return ResourceManager.GetString("MissingColon", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The codebook is missing the description..
        /// </summary>
        internal static string MissingDescription {
            get {
                return ResourceManager.GetString("MissingDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The codebook does not have a file type specification..
        /// </summary>
        internal static string MissingFileType {
            get {
                return ResourceManager.GetString("MissingFileType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The codebook is missing the variables declaration section..
        /// </summary>
        internal static string MissingVariablesDeclaration {
            get {
                return ResourceManager.GetString("MissingVariablesDeclaration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The end of the file was reached unexpectedly..
        /// </summary>
        internal static string UnexpectedEOF {
            get {
                return ResourceManager.GetString("UnexpectedEOF", resourceCulture);
            }
        }
    }
}
