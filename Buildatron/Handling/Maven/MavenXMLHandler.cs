using System;
using System.IO;
public class MavenXMLHandler : XmlHandler
{
	public static MavenXMLHandler instance;
	public static MavenXMLHandler getInstance()
	{
		if (MavenXMLHandler.instance == null)
		{
			MavenXMLHandler.instance = new MavenXMLHandler();
		}
		return MavenXMLHandler.instance;
	}
	public bool dirHasMavenFile(FileDirectory fd)
	{
		string path = fd.getPath();
		if (fd.getParent() != null)
		{
			path = DirectoryHandler.getInstance().getPathFromParent(fd, fd.getPath());
		}
		return this.dirHasMavenFile(path);
	}
	public bool dirHasMavenFile(string path)
	{
		bool result;
		if (Directory.Exists(path))
		{
			try
			{
				if (Directory.GetFiles(path, "maven.xml").Length > 0)
				{
					result = true;
					return result;
				}
				if (Directory.GetFiles(path, "pom.xml").Length > 0)
				{
					result = true;
					return result;
				}
			}
			catch (UnauthorizedAccessException)
			{
				Console.Out.WriteLine(HelperErrors.UNAUTHORISED_DIRECTORY_ACCESS + path);
			}
		}
		result = false;
		return result;
	}
	public void getMvnCmdsForDir(FileDirectory fd)
	{
	}
}
