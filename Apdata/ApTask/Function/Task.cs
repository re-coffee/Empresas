using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ApTask.Function
{
    internal partial class Task
    {
        public Configuration Config { get; set; } = new Configuration();
        public void GetTasks()
        {
            Runspace runspace = RunspaceFactory.CreateRunspace();
            WSManConnectionInfo connectionInfo = new WSManConnectionInfo(PSSessionType.DefaultRemoteShell);
            connectionInfo.ComputerName = "";

            PowerShell ps = PowerShell.Create();
        }
    }
}
