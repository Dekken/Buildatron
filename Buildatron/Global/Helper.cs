using System;
using System.IO;
using System.Windows.Forms;

public class Helper{

	public static Helper instance;
	private TextBox cmdTextBox;

	public static Helper getInstance(){
		if (Helper.instance == null){
			Helper.instance = new Helper();
		}
        return Helper.instance;
	}

	public TextBox getCmdTextBox(){
        return this.cmdTextBox;
	}

	public void setCmdTextBox(TextBox cmdTextBoxA){
        this.cmdTextBox = cmdTextBoxA;
	}

	public int ValidateDirectoryInput(string s){

		if (Directory.Exists(s)){
			return 0;
		}
		if (this.CheckForCommand(s)){
            return 1;
		}
        return 2;
	}

	private bool CheckForCommand(string s){
		foreach (Command command in ViewableCommands.getAllCommands()){			 
			if (command.getCommand().ToLower().Contains(s.ToLower())){
				return true;
			}
		}
		return false;
	}

	public void RunCommand(string cmd, TextBox cmdTextBox){
		Command command = this.getCommand(cmd);
		
	}

	private Command getCommand(string s){
		foreach (Command command in ViewableCommands.getAllCommands()){
			if (command.getCommand().ToLower().Equals(s.ToLower())){
				return command;
			}
		}
		return new Command("NULL", "This is not a command");
	}

	public void ThrowError(string error){
		this.cmdTextBox.Text = error;
	}
}
