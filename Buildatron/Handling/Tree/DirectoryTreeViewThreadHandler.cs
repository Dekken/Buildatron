using System;
using System.Windows.Forms;

public class DirectoryTreeViewThreadHandler{

	private DirectoryTreeNode root;
	private FileDirectory fd;
	private TreeView tree;

	public DirectoryTreeViewThreadHandler(FileDirectory fd, TreeView tree){
		this.fd = fd;
		this.tree = tree;
	}
	public void HandleDirectoryTree(){
		this.root = TreeViewHandler.getInstance().PopulateDirectoryTreeView(this.fd);
	}

	public TreeNode getRoot(){
		return this.root;
	}
    public bool checkNodeExists(TreeView tree) {
        foreach (TreeNode treeNode in tree.Nodes) {
            if (fd.getPath().Equals(treeNode.Name)) {
                return true;
            }
        }
        return false;
	}
}
