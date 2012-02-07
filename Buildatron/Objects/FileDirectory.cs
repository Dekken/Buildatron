using System;
using System.Collections.Generic;
public class FileDirectory
{
	private List<FileDirectory> children = new List<FileDirectory>();
	private List<MavenCommand> commands = new List<MavenCommand>();
	private FileDirectory parent = null;
	private string path = "";
	public FileDirectory(string path, FileDirectory parent)
	{
		this.path = path;
		this.parent = parent;
	}
	public FileDirectory getParent()
	{
		return this.parent;
	}
	public string getPath()
	{
		return this.path;
	}
	public void addMvnCmd(string cmd)
	{
		this.commands.Add(new MavenCommand(cmd));
	}
	public void addMvnCmd(string viewable, string cmd)
	{
		this.commands.Add(new MavenCommand(viewable, cmd));
	}
	public void setChildren(List<FileDirectory> children)
	{
		this.children = children;
	}
	public List<FileDirectory> getChildren()
	{
		return this.children;
	}
	public List<MavenCommand> getCommnands()
	{
		return this.commands;
	}
}
