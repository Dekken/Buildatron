using System;
using System.Collections.Generic;
using System.IO;
public class DirectoryHandler
{
	public static DirectoryHandler instance;
	public static DirectoryHandler getInstance()
	{
		if (DirectoryHandler.instance == null)
		{
			DirectoryHandler.instance = new DirectoryHandler();
		}
		return DirectoryHandler.instance;
	}
	public FileDirectory HandleDirectory(FileDirectory rd)
	{
		MavenXMLHandler.getInstance().getMvnCmdsForDir(rd);
		if (Settings.RECURSE_DIRECTORY)
		{
			rd.setChildren(this.getChildrenOf(rd, rd.getPath()));
			foreach (FileDirectory current in rd.getChildren())
			{
				this.HandleDirectory(current);
			}
		}
		return rd;
	}
	private List<FileDirectory> getChildrenOf(FileDirectory fd, string path)
	{
		List<FileDirectory> list = new List<FileDirectory>();
		if (fd.getParent() != null)
		{
			path = this.getPathFromParent(fd, path);
		}
		if (Directory.Exists(path) && MavenXMLHandler.getInstance().dirHasMavenFile(fd))
		{
			try
			{
				string[] directories = Directory.GetDirectories(path);
				for (int i = 0; i < directories.Length; i++)
				{
					string path2 = directories[i];
					if (MavenXMLHandler.getInstance().dirHasMavenFile(path2))
					{
						list.Add(new FileDirectory(new DirectoryInfo(path2).Name, fd));
					}
				}
			}
			catch (UnauthorizedAccessException)
			{
				Console.Out.WriteLine(HelperErrors.UNAUTHORISED_DIRECTORY_ACCESS + path);
			}
		}
		return list;
	}
	public string[] PrintDirectoryStructure(FileDirectory rd)
	{
		List<string> list = new List<string>();
		list.Add(rd.getPath());
		foreach (FileDirectory current in rd.getChildren())
		{
			this.PrintDirectoryStructure(current, list, 1);
		}
		return list.ToArray();
	}
	private List<string> PrintDirectoryStructure(FileDirectory rd, List<string> printOut, int tabs)
	{
		string str = "";
		for (int i = 0; i < tabs; i++)
		{
			str += "\t";
		}
		printOut.Add(str + rd.getPath());
		foreach (FileDirectory current in rd.getChildren())
		{
			this.PrintDirectoryStructure(current, printOut, tabs + 1);
		}
		return printOut;
	}
	private void HandleError(List<object> abstractList)
	{
		abstractList.Clear();
	}
	public string getPathFromParent(FileDirectory fd, string path)
	{
		if (fd.getParent() != null)
		{
			path = this.getPathFromParent(fd.getParent(), fd.getParent().getPath()) + "\\" + path;
		}
		return path;
	}
}
