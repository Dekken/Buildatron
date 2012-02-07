using System;
public class Maven3Handler : MavenVersionHandler
{
	public static Maven3Handler instance;
	public static Maven3Handler getInstance()
	{
		if (Maven3Handler.instance == null)
		{
			Maven3Handler.instance = new Maven3Handler();
		}
		return Maven3Handler.instance;
	}
	public override bool Handle()
	{
		return true;
	}
}
