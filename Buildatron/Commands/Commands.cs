using System;
public class Commands
{
	public static Commands instance;
	public static Command HELP = new Command("help", "this is the help command");
	public static Command WELCOME = new Command("welcome", "Welcome to wtf this thing is.");
	public Command[] helpCommands = new Command[]
	{
		Commands.HELP
	};
	public Command[] allCommands = new Command[]
	{
		Commands.HELP, 
		Commands.WELCOME
	};
	public static Commands getInstance()
	{
		if (Commands.instance == null)
		{
			Commands.instance = new Commands();
		}
		return Commands.instance;
	}
	public Command[] getHelpCommands()
	{
		return this.helpCommands;
	}
	public Command[] getAllCommands()
	{
		return this.allCommands;
	}
}
