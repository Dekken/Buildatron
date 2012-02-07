using System;
using System.Windows.Forms;
public class TreeViewThreadHandler
{
	private DirectoryTreeNode root;
	private FileDirectory fd;
	private bool nodeExists = false;
	private TreeView tree;
	public TreeViewThreadHandler(FileDirectory fd, TreeView tree)
	{
		this.fd = fd;
		this.tree = tree;
	}
	public void Handle()
	{
		this.root = TreeViewHandler.getInstance().PopulateTreeView(this.fd);
	}
	public void CheckNodeExists()
	{
		this.nodeExists = TreeViewHandler.getInstance().AlreadyContainsNode(this.fd, this.tree);
	}
	public TreeNode getRoot()
	{
		return this.root;
	}
	public bool getNodeExists()
	{
		return this.nodeExists;
	}
}
