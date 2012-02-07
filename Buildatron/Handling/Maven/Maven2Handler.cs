using System;
public class Maven2Handler : MavenVersionHandler
{
	public static Maven2Handler instance;
	public static Maven2Handler getInstance()
	{
		if (Maven2Handler.instance == null)
		{
			Maven2Handler.instance = new Maven2Handler();
		}
		return Maven2Handler.instance;
	}
	public override bool Handle()
	{
		return true;
	}
}
