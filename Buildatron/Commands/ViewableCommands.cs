using System;

public class ViewableCommands{

    public static Command HELP = new Command("help", "this is the help command");
    public static Command WELCOME = new Command("welcome", "Welcome to wtf this thing is.");

    public static Command[] helpCommands = new Command[]{
		ViewableCommands.HELP
	};
    public static Command[] allCommands = new Command[]{
		ViewableCommands.HELP, 
		ViewableCommands.WELCOME
	};

    public static Command[] getHelpCommands(){
        return helpCommands;
    }
    public static Command[] getAllCommands(){
        return allCommands;
    }
}