using System;
public class Maven1Handler : MavenVersionHandler
{
	public static Maven1Handler instance;
	public static Maven1Handler getInstance()
	{
		if (Maven1Handler.instance == null)
		{
			Maven1Handler.instance = new Maven1Handler();
		}
		return Maven1Handler.instance;
	}
	public override bool Handle()
	{
		return true;
	}
}
