using System;

public class Command{

	private string command  = "";
    private string name   = "";

    public Command(string name, string command) {
        this.name = name;
        this.command = command;       
	}
	public string getCommand(){
		return this.command;
	}
	public string getName(){
        return this.name;
	}
}