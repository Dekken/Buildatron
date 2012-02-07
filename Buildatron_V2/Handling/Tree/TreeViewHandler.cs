using System;
using System.Windows.Forms;
public class TreeViewHandler{

	public static TreeViewHandler instance;

	public static TreeViewHandler getInstance(){
		if (TreeViewHandler.instance == null){
			TreeViewHandler.instance = new TreeViewHandler();
		}
		return TreeViewHandler.instance;
	}

	public DirectoryTreeNode PopulateDirectoryTreeView(FileDirectory rd){
		DirectoryTreeNode directoryTreeNode = new DirectoryTreeNode(rd);
		directoryTreeNode.Name = rd.getPath();
		directoryTreeNode.Text = rd.getPath();

		foreach (FileDirectory current in rd.getChildren()){
			this.PopulateDirectoryTreeViewForChildren(current, directoryTreeNode);
		}
		return directoryTreeNode;
	}
    public void PopulateDirectoryTreeViewForChildren(FileDirectory rd, TreeNode root) {
        DirectoryTreeNode directoryTreeNode = new DirectoryTreeNode(rd);
        directoryTreeNode.Text = rd.getPath();
        directoryTreeNode.Name = rd.getPath();
        root.Nodes.Add(directoryTreeNode);

        foreach (FileDirectory current in rd.getChildren()) {
            this.PopulateDirectoryTreeViewForChildren(current, directoryTreeNode);
        }
    }
}