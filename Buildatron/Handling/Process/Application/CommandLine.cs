using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using Buildatron.Handling.Process;

public class CommandLine : App
{

    public CommandLine(ProcessCaller caller): base(caller){}

	public override ProcessHandle run(){
		
		ProcessStartInfo processStartInfo = new ProcessStartInfo(caller.getPName());
        //string text3 = "/c " + directory.ToCharArray()[0] + ": && cd " + directory + " && " + directory
        if(this.caller.getDirectory().Contains(":")){
            this.caller.setDirectory(this.caller.getDirectory().ToCharArray()[0] + ": && cd " + this.caller.getDirectory());
        }
        this.caller.setDirectory(this.caller.getDirectory() + " &&");
        string command = this.caller.getPrefix() + " " + this.caller.getDirectory() + " " +  this.caller.getCmd();

        if(caller.autoExit()){
             command += " && exit";
        }
        Console.WriteLine(command);
        processStartInfo.Arguments = command;
        
        
        if (caller.getPrefix().Equals("/c")){
            processStartInfo.UseShellExecute = false;
            processStartInfo.CreateNoWindow = true;
        }/*
        processStartInfo.RedirectStandardInput = true;        
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.RedirectStandardError = true;
        */
		int result = -1;
		try{

			this.process.StartInfo = processStartInfo;
			this.process.Start();
            /*
             
            StreamWriter standardInput = this.process.StandardInput;
            StreamReader standardOutput = this.process.StandardOutput;
            standardInput.AutoFlush = true;
            standardInput.Write(command + Environment.NewLine);
            standardInput.Flush();*/
            
            //if (caller.getPrefix().Equals("/k")){
            if (caller.waitForExit()){
            
                while(!process.HasExited){}
                
            }
            return new ProcessHandle(this.process.Id);
		}
		catch (Exception ex){
			Console.Write(ex.Message);
		}
		return new ProcessHandle(-1);
	}

}
