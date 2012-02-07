using System;
using System.Diagnostics;
using System.Windows.Forms;

using Buildatron.Handling.Process;

public abstract class App
{
	protected ProcessCaller caller;
	protected Process process;
    public App(ProcessCaller caller){
        this.caller = caller;
		this.process = new Process();
	}
	public abstract ProcessHandle run();

    public ProcessCaller getCaller(){
        return this.caller;
    }

}
