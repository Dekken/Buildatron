using System;
using System.Diagnostics;
using System.Windows.Forms;
public abstract class App
{
	protected AppProcess appProcess;
	protected Process process;
	public App(AppProcess appProcess)
	{
		this.appProcess = appProcess;
		this.process = new Process();
	}
	public abstract bool Handle(TextBox cmdTextBox);
	public AppProcess getProcess()
	{
		return this.appProcess;
	}
}
