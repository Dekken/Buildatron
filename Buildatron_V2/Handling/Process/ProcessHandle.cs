using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buildatron.Handling.Process {
    public class ProcessHandle {

        private int pid;
        private int exitCode = -1;

        public ProcessHandle(int pid){
            this.pid = pid;
        }

        public ProcessHandle setExitCode(int exitCode) { this.exitCode = exitCode; return this; }
        
        public int getExitCode(){return this.exitCode; }
        public int getPID()     { return this.pid; }
    }
}
