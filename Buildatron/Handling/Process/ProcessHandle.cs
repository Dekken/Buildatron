using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Timers;
using System.Threading;

using System.Diagnostics;


namespace Buildatron.Handling.Process {
    public class ProcessHandle {
        
        private System.Diagnostics.Process p;

        private PerformanceCounter cpu;
        private PerformanceCounter ram;

        private ProcessCaller caller;

        private ProcessHandle blockedBy = null;

        private int exitCode = -1;    
        private bool hasStartedVar = false;

        public ProcessHandle(ProcessCaller caller){       
            this.caller = caller;
 
            this.cpu = new PerformanceCounter("Processor", "% Processor Time", "_Total" );
            this.ram = new PerformanceCounter("Memory", "Available MBytes", String.Empty );    
            
        }

        public void start() { if(!hasStartedVar) p.Start(); hasStartedVar = true;}
        public void Kill() { if(hasProcessStarted() && !hasProcessExited()) p.Kill(); }

        public ProcessHandle setProcess(System.Diagnostics.Process p) {this.p = p; return this; }

        public ProcessHandle setExitCode(int exitCode) { this.exitCode = exitCode; return this; }
        public ProcessHandle setBlockedBy(ProcessHandle blockedBy) { this.blockedBy = blockedBy; return this; }

        public ProcessCaller getProcessCaller()         { return this.caller; }

        public string getExitCode()    { return this.exitCode.ToString(); }
        public ProcessHandle getBlockedBy()   { return this.blockedBy;}
        public string getPID()         { 
            try{
                return this.p.Id.ToString();
            }
            catch(NullReferenceException e){ return "-1";}        
            catch(InvalidOperationException e){ return "-1";}        
        }

        public string getCPUUsage()     { if(hasProcessStarted()) return p.UserProcessorTime.TotalMilliseconds.ToString();  return "";}
        public string getRAMUsage()     { if(hasProcessStarted()) return p.WorkingSet64.ToString();  return "";}
        public string getRunningTime()  { if(hasProcessStarted()) return p.TotalProcessorTime.TotalMilliseconds.ToString();  return "";}

        public bool hasProcessStarted() { return hasStartedVar; }

        public bool hasProcessExited() {
            try{
                return p.HasExited;;
            }catch(InvalidOperationException e){ return false; }
        }

    }
}
