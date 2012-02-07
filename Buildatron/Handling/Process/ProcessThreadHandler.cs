using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

using Buildatron.Handling.Process;

public class ProcessThreadHandler : ThreadHandler{

	private delegate void enableControlsCallBack(Control c);


    private ProcessHandle ph;

    public ProcessThreadHandler(ProcessHandle ph){
        this.ph = ph;
	}

	public override void Handle(){
        this.ph = new CommandLine(ph.getProcessCaller()).run(ph);
	}

    public ProcessHandle getProcessHandle() { return this.ph; }
}
