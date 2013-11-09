using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Buildatron.Scene.s.userControl.rights.settings.preloaded.services.configurations;
namespace Buildatron.Scene.s.userControl.rights.operational.services.datagrid{
	public class OperationalControlDataGridHandler
	{
		private static OperationalControlDataGridHandler instance;
		public static OperationalControlDataGridHandler getInstance()
		{
			if (OperationalControlDataGridHandler.instance == null)
			{
				OperationalControlDataGridHandler.instance = new OperationalControlDataGridHandler();
			}
			return OperationalControlDataGridHandler.instance;
		}
		public void addRow(DataGridView view, FileDirectory fd, string config){

			DirectoryDataGridViewRow directoryDataGridViewRow = new DirectoryDataGridViewRow(fd);

			string text = DirectoryHandler.getInstance().getPathFromParent(fd, fd.getPath());
			DirectoryDataGridViewTextBoxCell directories = new DirectoryDataGridViewTextBoxCell(text);
			DataGridViewComboBoxCell commands = new DataGridViewComboBoxCell();
			DataGridViewCheckBoxCell include = new DataGridViewCheckBoxCell();
			DataGridViewCheckBoxCell echo = new DataGridViewCheckBoxCell();
			DataGridViewCheckBoxCell display = new DataGridViewCheckBoxCell();
			DataGridViewCheckBoxCell autoExit = new DataGridViewCheckBoxCell();
			DataGridViewCheckBoxCell waitForExit = new DataGridViewCheckBoxCell();
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
			directories.Value = text;

			foreach(Command c in PreloadedConfigurationGetterService.getInstance().getCommandsFromXMLConfiguration(config)){
				commands.Items.Add(c.getName());
			}
			if(commands.Items.Count == 0) return;
			commands.Value = commands.Items[0];

			include.Value = true;
			echo.Value = true;
			display.Value = true;
			autoExit.Value = true;
			waitForExit.Value = true;
			directoryDataGridViewRow.Cells.Add(directories);
			directoryDataGridViewRow.Cells.Add(commands);
			directoryDataGridViewRow.Cells.Add(include);
			directoryDataGridViewRow.Cells.Add(display);
			directoryDataGridViewRow.Cells.Add(autoExit);
			directoryDataGridViewRow.Cells.Add(waitForExit);
		
			directories.ReadOnly = true;
			commands.ReadOnly = false;
			include.ReadOnly = false;
			echo.ReadOnly = false;
			display.ReadOnly = false;
			autoExit.ReadOnly = false;
			view.Rows.Add(directoryDataGridViewRow);
		}
		public void addSavedRows(DataGridView view, string config){
	        List<Command> cmds = PreloadedConfigurationGetterService.getInstance().getCommandsFromXMLConfiguration(config);
			foreach(Sequence seq in PreloadedConfigurationGetterService.getInstance().getSequencesFromXMLConfiguration(config)){
				addRow(view, new FileDirectory(seq.directory(), null), config);
                //((DataGridViewComboBoxCell)view.Rows[view.Rows.Count - 1].Cells[1]).Value = cmds[int.Parse(seq.command())].getName();
                view.Rows[view.Rows.Count - 1].Cells[1].Value = ((DataGridViewComboBoxCell)view.Rows[view.Rows.Count - 1].Cells[1]).Items[int.Parse(seq.command())];
                //view.Rows[view.Rows.Count - 1].Cells[1].Value = seq.command();
                //((DataGridViewComboBoxCell)dr.Cells[1]).Items.IndexOf(dr.Cells[1].Value).ToString()
                view.Rows[view.Rows.Count - 1].Cells[2].Value = seq.include()   == "1" ? true : false;
                view.Rows[view.Rows.Count - 1].Cells[3].Value = seq.display()   == "1" ? true : false;
                view.Rows[view.Rows.Count - 1].Cells[4].Value = seq.autoExit()  == "1" ? true : false;
			}
		}

		public void remRow(DataGridView view, int row){

			try{
				view.Rows.RemoveAt(row);
			}
			catch (ArgumentOutOfRangeException var_0_12){}
		}
		public void moveRowsUp(DataGridViewRow viewRow){

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
		public void moveRowsDown(DataGridViewRow viewRow){

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
}