using System;
public class Settings
{
	public static bool RECURSE_DIRECTORY = true;
	public static bool STOP_ON_BUILD_FAIL = true;
	public static bool CLEAR_OUTPUT_ON_EACH_COMMAND = true;

    //Loaded from masterconfig - eventually
    public static bool AUTO_DELETE_DEAD_PROCESSES_FROM_VIEW = true;

	public static int MAX_SEQUENTIAL_COMMANDS = 50;
}
