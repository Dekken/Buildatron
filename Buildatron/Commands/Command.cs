using System;

public class Command{

	private string command  = "";
    private string output   = "";

	public Command(string command, string output){
		this.command = command;
		this.output = output;
	}
	public string getCommand(){
		return this.command;
	}
	public string getOutPut(){
		return this.output;
	}
}