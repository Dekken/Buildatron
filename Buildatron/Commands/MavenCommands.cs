using System;
using System.Collections.Generic;
public class MavenCommands
{
	private static MavenCommands instance;
	private static Dictionary<string, MavenCommand> commands;
	public static MavenCommands getInstance()
	{
		if (MavenCommands.instance == null)
		{
			MavenCommands.commands = new Dictionary<string, MavenCommand>();
			MavenCommands.instance = new MavenCommands();
		}
		return MavenCommands.instance;
	}
	public string[] getCmdsAsStrings(List<MavenCommand> mavenCommands)
	{
		List<string> list = new List<string>();
		foreach (MavenCommand current in mavenCommands)
		{
			list.Add(current.getViewable());
		}
		return list.ToArray();
	}
	public string[] getCmdsAsStrings()
	{
		List<string> list = new List<string>();
		foreach (MavenCommand current in MavenCommands.commands.Values)
		{
			list.Add(current.getViewable());
		}
		return list.ToArray();
	}
	public MavenCommand getCommandForString(string s)
	{
		MavenCommand result;
		if (MavenCommands.commands.TryGetValue(s, out result))
		{
			return result;
		}
		throw new NotImplementedException();
	}
	public List<MavenCommand> getAllCommands()
	{
		List<MavenCommand> list = new List<MavenCommand>();
		foreach (MavenCommand current in MavenCommands.commands.Values)
		{
			list.Add(current);
		}
		return list;
	}
	public void addMvnCmd(string cmd)
	{
		if (!MavenCommands.commands.ContainsKey(cmd))
		{
			MavenCommands.commands.Add(cmd, new MavenCommand(cmd));
		}
	}
	public void addMvnCmd(string viewable, string cmd)
	{
		if (!MavenCommands.commands.ContainsKey(viewable))
		{
			MavenCommands.commands.Add(viewable, new MavenCommand(viewable, cmd));
		}
	}
}
