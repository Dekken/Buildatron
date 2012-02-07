using System;
using System.Collections.Generic;
using System.IO;
public class DirectoryHandler
{
	public static DirectoryHandler instance;

    public static DirectoryHandler getInstance(){
		if (DirectoryHandler.instance == null){
			DirectoryHandler.instance = new DirectoryHandler();
		}
		return DirectoryHandler.instance;
	}

    public FileDirectory HandleDirectory(FileDirectory rd, string filepatterns) {

        rd.setChildren(this.getChildrenOf(rd, rd.getPath(), filepatterns));
		foreach (FileDirectory current in rd.getChildren()){
            this.HandleDirectory(current, filepatterns);
		}	
		return rd;
	}

	private List<FileDirectory> getChildrenOf(FileDirectory fd, string path, string filepattern){
		List<FileDirectory> list = new List<FileDirectory>();
        if (fd.getParent() != null){
			path = this.getPathFromParent(fd, path);
		}
        if (Directory.Exists(path)) {
			try{
				foreach( string s in Directory.GetDirectories(path)){
                    if (directoryHasFilePattern(s, filepattern)) {
						list.Add(new FileDirectory(new DirectoryInfo(s).Name, fd));
					}
				}
			}
			catch (UnauthorizedAccessException){
				Console.Out.WriteLine(HelperErrors.UNAUTHORISED_DIRECTORY_ACCESS + path);
			}
		}
		return list;
	}

	public string[] PrintDirectoryStructure(FileDirectory rd){
		List<string> list = new List<string>();
		list.Add(rd.getPath());
		foreach (FileDirectory current in rd.getChildren()){
			this.PrintDirectoryStructure(current, list, 1);
		}
		return list.ToArray();
	}

	private List<string> PrintDirectoryStructure(FileDirectory rd, List<string> printOut, int tabs){
		string str = "";
		for (int i = 0; i < tabs; i++){
			str += "\t";
		}
		printOut.Add(str + rd.getPath());
		foreach (FileDirectory current in rd.getChildren()){
			this.PrintDirectoryStructure(current, printOut, tabs + 1);
		}
		return printOut;
	}

	private void HandleError(List<object> abstractList){
		abstractList.Clear();
	}

	public string getPathFromParent(FileDirectory fd, string path){
		if (fd.getParent() != null)
		{
			path = this.getPathFromParent(fd.getParent(), fd.getParent().getPath()) + "\\" + path;
		}
		return path;
	}

    public bool directoryHasFilePattern(string path, string filePattern) {
        if (System.IO.Directory.Exists(path)) {
            
            foreach (string s in (filePattern.IndexOf(",") == -1) ? new string[] { filePattern } : filePattern.Split(',')) {
                try {
                    if (System.IO.Directory.GetFiles(path, s).Length > 0){
                        return true;
                    }
                } catch (UnauthorizedAccessException) { Console.Out.WriteLine(HelperErrors.UNAUTHORISED_DIRECTORY_ACCESS + path); }
            }

        }
        return filePattern.Equals("");
    }
}
