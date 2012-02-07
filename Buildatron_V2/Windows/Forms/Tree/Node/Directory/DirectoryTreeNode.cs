using System;
using System.Windows.Forms;

public class DirectoryTreeNode : TreeNode{

	private FileDirectory fd;

	public DirectoryTreeNode(FileDirectory fd){
		this.fd = fd;
	}

	public FileDirectory getFileDirectory(){
		return this.fd;
	}
}
