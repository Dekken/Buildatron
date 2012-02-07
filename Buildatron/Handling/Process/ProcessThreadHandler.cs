using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
public class ProcessThreadHandler : ThreadHandler
{
	private delegate void enableControlsCallBack(Control c);
	private string[] lines;
	private string app;
	private TextBox cmdTextBox;
	private List<Control> disableds;
	private DataGridView DirectoryCmdView;
	public ProcessThreadHandler(string app, TextBox cmdTextBox, List<Control> disableds, DataGridView DirectoryCmdView)
	{
		this.app = app;
		this.cmdTextBox = cmdTextBox;
		this.disableds = disableds;
		this.DirectoryCmdView = DirectoryCmdView;
	}
	public override void Handle()
	{
		AppProcesses instance = AppProcesses.getInstance();
		if (!instance.containsApp("cmd.exe"))
		{
			instance.addApp("cmd.exe", new CommandLine(new AppProcess("cmd.exe")));
		}
		foreach (DirectoryDataGridViewRow directoryDataGridViewRow in (IEnumerable)this.DirectoryCmdView.Rows)
		{
			bool flag = false;
			string text = "";
			string text2 = "";
			if (directoryDataGridViewRow.Cells[2] is DataGridViewCheckBoxCell)
			{
				if (!(bool)((DataGridViewCheckBoxCell)directoryDataGridViewRow.Cells[2]).Value)
				{
					continue;
				}
			}
			if (Settings.CLEAR_OUTPUT_ON_EACH_COMMAND)
			{
				this.cmdTextBox.Text = "";
			}
			if (directoryDataGridViewRow.Cells[1] is DataGridViewComboBoxCell)
			{
				text2 = MavenCommands.getInstance().getCommandForString((string)((DataGridViewComboBoxCell)directoryDataGridViewRow.Cells[1]).Value).getCmd();
			}
			if (directoryDataGridViewRow.Cells[0] is DirectoryDataGridViewTextBoxCell)
			{
				text = ((DirectoryDataGridViewTextBoxCell)directoryDataGridViewRow.Cells[0]).getDirectory();
			}
			string text3 = string.Concat(new object[]
			{
				"/c ", 
				text.ToCharArray()[0], 
				": && cd ", 
				text, 
				" && ", 
				text2
			});
			Console.WriteLine(text3);
			TextBox expr_1B3 = this.cmdTextBox;
			expr_1B3.Text = expr_1B3.Text + text3 + "\r\n";
			App app;
			if (instance.getApps().TryGetValue("cmd.exe", out app))
			{
				app.getProcess().setCmd(text3);
				app.getProcess().setSpecial("");
			}
			if (ProcessHandler.getInstance().Handle(this.app, this.cmdTextBox))
			{
				break;
			}
			if (flag)
			{
				break;
			}
		}
		this.enableControls(this.disableds);
		Cursor.Current = Cursors.Default;
	}
	private void enableControls(List<Control> disableds)
	{
		foreach (Control current in disableds)
		{
			if (current.InvokeRequired)
			{
				current.Invoke(new ProcessThreadHandler.enableControlsCallBack(this.enableControlsWithInvoke), new object[]
				{
					current
				});
			}
			else
			{
				this.enableControlsWithInvoke(current);
			}
		}
	}
	private void enableControlsWithInvoke(Control c)
	{
		c.Enabled = true;
	}
	public string[] getLines()
	{
		return this.lines;
	}
}
