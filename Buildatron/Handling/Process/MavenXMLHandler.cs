using System;
using System.IO;
public class MavenXMLHandler : XmlHandler
{
	public static MavenXMLHandler instance;
	public static MavenXMLHandler getInstance()
	{
		if (MavenXMLHandler.instance == null){
			MavenXMLHandler.instance = new MavenXMLHandler();
		}
		return MavenXMLHandler.instance;
	}

	
}