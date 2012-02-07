using System;
using System.Windows.Forms;
public class TreeViewHandler
{
	public static TreeViewHandler instance;
	public static TreeViewHandler getInstance()
	{
		if (TreeViewHandler.instance == null)
		{
			TreeViewHandler.instance = new TreeViewHandler();
		}
		return TreeViewHandler.instance;
	}
	public DirectoryTreeNode PopulateTreeView(FileDirectory rd)
	{
		DirectoryTreeNode directoryTreeNode = new DirectoryTreeNode(rd);
		directoryTreeNode.Name = rd.getPath();
		directoryTreeNode.Text = rd.getPath();
		foreach (FileDirectory current in rd.getChildren())
		{
			this.PopulateTreeViewForChildren(current, directoryTreeNode);
		}
		return directoryTreeNode;
	}
	public void PopulateTreeViewForChildren(FileDirectory rd, TreeNode root)
	{
		DirectoryTreeNode directoryTreeNode = new DirectoryTreeNode(rd);
		directoryTreeNode.Text = rd.getPath();
		directoryTreeNode.Name = rd.getPath();
		root.Nodes.Add(directoryTreeNode);
		foreach (FileDirectory current in rd.getChildren())
		{
			this.PopulateTreeViewForChildren(current, directoryTreeNode);
		}
	}
	public bool AlreadyContainsNode(FileDirectory fd, TreeView tree)
	{
		bool result;
		foreach (TreeNode treeNode in tree.Nodes)
		{
			if (fd.getPath().Equals(treeNode.Name))
			{
				result = true;
				return result;
			}
		}
		result = false;
		return result;
	}
}
