using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Provider;
using System.Linq;
using System.Text;
using Microsoft.PowerShell.Commands;
using Microsoft.PowerShell.Archive;


namespace Microsoft.PowerShell.Archive
{
    public enum ArchiveType {
        Zip,
        Tar
    }
    

    internal interface IArchive: IDisposable
    {
        string Path { get; }

        
        //internal bool EntryExists;
        //internal bool AddEntry;
        // RemoveEntry

        // NewEntry

        


        // Get-Location                 : Handled in Provider
        // Set-Location                 : Handled in Provider
        // Get-Item                     : 
        // Get-ChildItem                : 
        // Invoke-Item                  : 
        // Move-Item                    : 
        // New-Item                     :
        // Remove-Item                  :
        // Get-ItemProperty             :
        // Set-ItemProperty             :
        // Clear-Item                   :
        // Clear-ItemProperty           :
        // Remove-Item                  :
        // Remove-ItemProperty          :
        // Get-Acl                      :
        // Set-Acl                      :
        // Get-AuthenticodeSignature    : 
        // Set-AuthenticodeSignature    : 
        
        internal IEnumerable<IArchiveEntry> GetEntries() {}
        internal IEnumerable<IArchiveEntry> GetEntries(string path, bool recurse, uint depth) {}


        


        private void GetPathItems(
            string path,
            bool recurse,
            uint depth,
            bool nameOnly,
            ReturnContainers returnContainers)
        {

        }

        
    }
    internal interface IArchiveEntry : IDisposable {

    }
    
    internal interface IArchiveFileEntry : IArchiveEntry
    {

    }

    internal interface IArchiveFileEntry : IArchiveEntry
    {
        
    }
}