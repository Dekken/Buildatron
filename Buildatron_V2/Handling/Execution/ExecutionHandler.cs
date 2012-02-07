using System;
public class ExecutionHandler
{
	public static ExecutionHandler instance;
	public static ExecutionHandler getInstance()
	{
		if (ExecutionHandler.instance == null)
		{
			ExecutionHandler.instance = new ExecutionHandler();
		}
		return ExecutionHandler.instance;
	}
	public void Invoker()
	{
	}
	public void Handle()
	{
	}
}
