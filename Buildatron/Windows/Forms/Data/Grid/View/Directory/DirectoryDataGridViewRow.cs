using System;
using System.Windows.Forms;

public class DirectoryDataGridViewRow : DataGridViewRow{

	private FileDirectory fd;

	public DirectoryDataGridViewRow(FileDirectory fd){
		this.fd = fd;
	}
	
    public FileDirectory getFileDirectory(){
		return this.fd;
	}
}
