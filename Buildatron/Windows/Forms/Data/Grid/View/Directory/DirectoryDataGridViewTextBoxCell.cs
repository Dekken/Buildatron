using System;
using System.Windows.Forms;
public class DirectoryDataGridViewTextBoxCell : DataGridViewTextBoxCell
{
	private string directory;
	public DirectoryDataGridViewTextBoxCell(string directory)
	{
		this.directory = directory;
	}
	public string getDirectory()
	{
		return this.directory;
	}
}
