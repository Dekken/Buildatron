using System;
using System.Windows.Forms;

using Buildatron.Handling.Process;

namespace Buildatron.Windows.Forms.Data.Grid.View.Process.Handle {
    public class ProcessHandleDataGridViewRow : DataGridViewRow{
        private ProcessHandle ph;

        public ProcessHandleDataGridViewRow(ProcessHandle ph){
            this.ph = ph;
        }

        public ProcessHandle getProcessHandle() { return ph; }
    }
}