using System;
using System.IO;
using System.Windows.Forms;
public class Helper
{
	public static Helper instance;
	private static TextBox cmdTextBox;
	public static Helper getInstance()
	{
		if (Helper.instance == null)
		{
			Helper.instance = new Helper();
		}
		return Helper.instance;
	}
	public static TextBox getCmdTextBox()
	{
		return Helper.cmdTextBox;
	}
	public static void setCmdTextBox(TextBox cmdTextBoxA)
	{
		Helper.cmdTextBox = cmdTextBoxA;
	}
	public int ValidateDirectoryInput(string s)
	{
		int result;
		if (Directory.Exists(s))
		{
			result = 2;
		}
		else
		{
			if (this.CheckForCommand(s))
			{
				result = 1;
			}
			else
			{
				result = 0;
			}
		}
		return result;
	}
	private bool CheckForCommand(string s)
	{
		Command[] allCommands = Commands.getInstance().getAllCommands();
		bool result;
		for (int i = 0; i < allCommands.Length; i++)
		{
			Command command = allCommands[i];
			if (command.getCommand().ToLower().Contains(s.ToLower()))
			{
				result = true;
				return result;
			}
		}
		result = false;
		return result;
	}
	public void RunCommand(string cmd, TextBox cmdTextBox)
	{
		Command command = this.getCommand(cmd);
		cmdTextBox.Text = command.getOutPut();
	}
	private Command getCommand(string s)
	{
		Command[] allCommands = Commands.getInstance().getAllCommands();
		Command result;
		for (int i = 0; i < allCommands.Length; i++)
		{
			Command command = allCommands[i];
			if (command.getCommand().ToLower().Equals(s.ToLower()))
			{
				result = command;
				return result;
			}
		}
		result = new Command("NULL", "This is not a command");
		return result;
	}
	public void ThrowError(string error)
	{
		Helper.cmdTextBox.Text = error;
	}
}
