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

namespace Microsoft.PowerShell.Archive.Provider
{
    public partial  class Provider :  DriveCmdletProvider
    {

        /// <summary>
        /// Determines if the specified drive can be mounted.
        /// </summary>
        ///
        /// <param name="drive">
        /// The drive that is going to be mounted.
        /// </param>
        ///
        /// <returns>
        /// The same drive that was passed in, if the drive can be mounted.
        /// null if the drive cannot be mounted.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">
        /// drive is null.
        /// </exception>
        /// <exception cref="System.ArgumentException">
        /// drive root is null or empty.
        /// </exception>
		protected override PSDriveInfo NewDrive(PSDriveInfo drive)
		{
            if (drive == null) {
                throw new Exception("NewArgumentNullException(\"drive\")");
            }
            
            // Validate DynamicParameters
            DriveInfoDynamicParameters param = DynamicParameters as DriveInfoDynamicParameters;

            if (String.IsNullOrEmpty(param.Path)) 
            {
                throw new Exception("NewArgumentException(\"Path\")");
            }

            FileInfo fileInfo = new FileInfo(
                Path.Combine(param.Path, SessionState.Path.CurrentLocation.Path)
            );

			if (!File.Exists(fileInfo.FullName))
			{
				throw new Exception(message: "FileNotFoundException(fileInfo.FullName)");
			}

        }

        protected override object NewDriveDynamicParameters() {
            return new DriveInfoDynamicParameters();
        }
    }

    # region DriveCmdletProvider 

    
    public class DriveInfoDynamicParameters {

        [Parameter]
        [ValidateNotNullOrEmpty]
        public String Path;

        [Parameter]
        public ArchiveType Type;
    }
    #endregion DriveCmdletProvider
}

