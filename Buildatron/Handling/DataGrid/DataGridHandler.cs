using System;
using System.Windows.Forms;
public class DataGridHandler
{
	private static DataGridHandler instance;
	public static DataGridHandler getInstance()
	{
		if (DataGridHandler.instance == null)
		{
			DataGridHandler.instance = new DataGridHandler();
		}
		return DataGridHandler.instance;
	}
	public void addRow(DataGridView view, FileDirectory fd)
	{
		DirectoryDataGridViewRow directoryDataGridViewRow = new DirectoryDataGridViewRow(fd);
		string text = DirectoryHandler.getInstance().getPathFromParent(fd, fd.getPath());
		DirectoryDataGridViewTextBoxCell directoryDataGridViewTextBoxCell = new DirectoryDataGridViewTextBoxCell(text);
		DataGridViewComboBoxCell dataGridViewComboBoxCell = new DataGridViewComboBoxCell();
		DataGridViewCheckBoxCell dataGridViewCheckBoxCell = new DataGridViewCheckBoxCell();
		if (text.Length > 50)
		{
			int i = text.Length;
			int num = 20;
			while (i > 50)
			{
				i--;
				num++;
			}
			text = text.Substring(0, 5) + "....." + text.Substring(num);
		}
		directoryDataGridViewTextBoxCell.Value = text;
		dataGridViewComboBoxCell.Items.AddRange(MavenCommands.getInstance().getCmdsAsStrings());
		foreach (string value in dataGridViewComboBoxCell.Items)
		{
			Console.Out.WriteLine(value);
		}
		dataGridViewComboBoxCell.Value = dataGridViewComboBoxCell.Items[0];
		dataGridViewCheckBoxCell.Value = true;
		directoryDataGridViewRow.Cells.Add(directoryDataGridViewTextBoxCell);
		directoryDataGridViewRow.Cells.Add(dataGridViewComboBoxCell);
		directoryDataGridViewRow.Cells.Add(dataGridViewCheckBoxCell);
		directoryDataGridViewTextBoxCell.ReadOnly = true;
		dataGridViewComboBoxCell.ReadOnly = false;
		dataGridViewCheckBoxCell.ReadOnly = false;
		view.Rows.Add(directoryDataGridViewRow);
	}
	public void remRow(DataGridView view, int row)
	{
		try
		{
			view.Rows.RemoveAt(row);
		}
		catch (ArgumentOutOfRangeException var_0_12)
		{
		}
	}
	public void moveRowsUp(DataGridViewRow viewRow)
	{
		DataGridView dataGridView = viewRow.DataGridView;
		int index = viewRow.Index;
		bool selected = dataGridView.Rows[index].Selected;
		if (index != 0)
		{
			dataGridView.Rows.RemoveAt(index);
			dataGridView.Rows.Insert(index - 1, viewRow);
			dataGridView.Rows[index - 1].Selected = true;
		}
	}
	public void moveRowsDown(DataGridViewRow viewRow)
	{
		DataGridView dataGridView = viewRow.DataGridView;
		int index = viewRow.Index;
		if (viewRow.Index != -1 && viewRow.DataGridView.Rows.Count != viewRow.Index)
		{
			try
			{
				dataGridView.Rows.RemoveAt(index);
				dataGridView.Rows.Insert(index + 1, viewRow);
				dataGridView.Rows[index + 1].Selected = true;
			}
			catch (ArgumentOutOfRangeException var_2_6E)
			{
				dataGridView.Rows.Insert(index, viewRow);
				dataGridView.Rows[index].Selected = false;
				dataGridView.Rows[index - 1].Selected = false;
			}
		}
	}
}
