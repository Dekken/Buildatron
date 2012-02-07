using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

using Buildatron.Handling.Process;

public class ProcessThreadHandler : ThreadHandler{

	private delegate void enableControlsCallBack(Control c);

    private ProcessCaller caller;
    private ProcessHandle ph;

    public ProcessThreadHandler(ProcessCaller caller){
        this.caller = caller;
	}

	public override void Handle(){
        this.ph = new CommandLine(caller).run();
	}
    public ProcessHandle getProcessHandle() { return this.ph; }
}
