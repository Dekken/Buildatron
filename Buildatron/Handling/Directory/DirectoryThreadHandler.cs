using System;
public class DirectoryThreadHandler : ThreadHandler
{
	private FileDirectory fd;
	private string filePattern;
	public DirectoryThreadHandler(FileDirectory fd, string filePattern){
		this.fd = fd;
        this.filePattern = filePattern;
	}
	public override void Handle()
	{
		this.fd = DirectoryHandler.getInstance().HandleDirectory(this.fd, filePattern);
	}
	
}
