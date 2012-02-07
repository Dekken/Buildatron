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

}
