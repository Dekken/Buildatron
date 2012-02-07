using System;
public class MavenCommand
{
	private string command = "";
	private string viewable = "";
	public MavenCommand(string command)
	{
		this.viewable = command;
		this.command = command;
	}
	public MavenCommand(string viewable, string command)
	{
		this.viewable = viewable;
		this.command = command;
	}
	public string getCmd()
	{
		return this.command;
	}
	public string getViewable()
	{
		return this.viewable;
	}
}
