using System;
public class DirectoryThreadHandler : ThreadHandler
{
	private FileDirectory fd;
	private string[] output;
	public DirectoryThreadHandler(FileDirectory fd)
	{
		this.fd = fd;
	}
	public override void Handle()
	{
		this.fd = DirectoryHandler.getInstance().HandleDirectory(this.fd);
	}
	public void HandlePrinting()
	{
		if (this.fd.getPath().Equals(""))
		{
			this.output = new string[]
			{
				""
			};
		}
		else
		{
			this.output = DirectoryHandler.getInstance().PrintDirectoryStructure(this.fd);
		}
	}
	public string[] getOutPut()
	{
		return this.output;
	}
}
