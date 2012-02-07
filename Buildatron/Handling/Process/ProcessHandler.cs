using System;
using System.Windows.Forms;
public class ProcessHandler
{
	public static ProcessHandler instance;
	public static ProcessHandler getInstance()
	{
		if (ProcessHandler.instance == null)
		{
			ProcessHandler.instance = new ProcessHandler();
		}
		return ProcessHandler.instance;
	}
	public void Invoker()
	{
	}
	public bool Handle(string pName, TextBox cmdTextBox)
	{
		bool result;
		if (AppProcesses.getInstance().getApps().ContainsKey(pName))
		{
			if (AppProcesses.getInstance().getApps().ContainsKey(pName))
			{
				App app;
				AppProcesses.getInstance().getApps().TryGetValue(pName, out app);
				result = app.Handle(cmdTextBox);
				return result;
			}
		}
		result = true;
		return result;
	}
}
