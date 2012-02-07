using System;
using System.Diagnostics;
using System.Windows.Forms;

using Buildatron.Handling.Process;

public abstract class App{

	protected Process process;

    public App(){
		this.process = new Process();
	}
	public abstract ProcessHandle run(ProcessHandle ph);
}
