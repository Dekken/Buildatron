using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
public class CommandLine : App
{
	private delegate void UpdateTextBoxCallBack(TextBox cmdTextBox, string[] lines);
	public CommandLine(AppProcess appProcess) : base(appProcess)
	{
	}
	public override bool Handle(TextBox cmdTextBox)
	{
		string[] array = new string[0];
		bool flag = false;
		ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd");
		processStartInfo.Arguments = this.appProcess.getCmd();
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.RedirectStandardInput = true;
		processStartInfo.RedirectStandardError = true;
		bool result;
		try
		{
			this.process.StartInfo = processStartInfo;
			this.process.Start();
			StreamWriter standardInput = this.process.StandardInput;
			StreamReader standardOutput = this.process.StandardOutput;
			standardInput.AutoFlush = true;
			standardInput.Write(this.appProcess.getCmd() + Environment.NewLine);
			string text;
			while (!this.process.HasExited)
			{
				text = standardOutput.ReadLine();
				if (text == null)
				{
					break;
				}
				array = Regex.Split(text, "\r\n");
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					string str = array2[i];
					cmdTextBox.Text = cmdTextBox.Text + str + "\r\n";
					DateTime now = DateTime.Now;
					bool arg_133_0;
					if (now.Millisecond % 100 >= 0)
					{
						now = DateTime.Now;
						arg_133_0 = (now.Millisecond % 100 > 10);
					}
					else
					{
						arg_133_0 = true;
					}
					if (!arg_133_0)
					{
						cmdTextBox.SelectionStart = cmdTextBox.Text.Length;
						cmdTextBox.ScrollToCaret();
						cmdTextBox.Refresh();
					}
				}
			}
			if (Settings.STOP_ON_BUILD_FAIL)
			{
				if (this.process.ExitCode != 0)
				{
					flag = true;
				}
			}
			Console.WriteLine(this.process.ExitCode);
			standardInput.Flush();
			text = standardOutput.ReadToEnd();
			if (text != null && !text.Equals(""))
			{
				array = Regex.Split(text, "\r\n");
				this.writeToTextBox(array, cmdTextBox);
			}
			result = flag;
		}
		catch (Exception ex)
		{
			Console.Write(ex.Message);
			result = true;
		}
		return result;
	}
	private void writeToTextBox(string[] lines, TextBox cmdTextBox)
	{
		List<string> list = new List<string>();
		list.AddRange(cmdTextBox.Lines);
		list.AddRange(lines);
		if (cmdTextBox.InvokeRequired)
		{
			cmdTextBox.BeginInvoke(new CommandLine.UpdateTextBoxCallBack(this.updateTextBox), new object[]
			{
				cmdTextBox, 
				list.ToArray()
			});
		}
		else
		{
			this.updateTextBox(cmdTextBox, list.ToArray());
		}
	}
	private void updateTextBox(TextBox cmdTextBox, string[] lines)
	{
		cmdTextBox.Lines = lines;
		cmdTextBox.Invalidate(true);
		cmdTextBox.Update();
	}
}
