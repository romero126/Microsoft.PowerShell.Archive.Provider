using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Provider;
using System.Linq;
using System.Text;
using Microsoft.PowerShell.Commands;


namespace Microsoft.PowerShell.Archive.Provider
{

                                                     
    // Todo: Add support for the following:
    //      NavigationCmdletProvider, IContentCmdletProvider, IPropertyCmdletProvider , ISecurityDescriptorCmdletProvider, ICmdletProviderSupportsHelp
    //      Currently Supports
    //          DriveCmdletProvider
    [CmdletProvider(Provider.ProviderName, ProviderCapabilities.ShouldProcess | ProviderCapabilities.ExpandWildcards )]
    public partial  class Provider :  DriveCmdletProvider
    {
        
        /// <summary>
        /// Gets the name of the provider.
        /// </summary>
        public const string ProviderName = "ArchiveProvider";

        
    }


    
}

