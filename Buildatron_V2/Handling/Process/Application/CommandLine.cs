using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using Buildatron.Handling.Process;

public class CommandLine : App
{

    public CommandLine(ProcessCaller caller): base(){}

	public override ProcessHandle run(ProcessHandle ph){
		ProcessCaller caller = ph.getProcessCaller();
		ProcessStartInfo processStartInfo = new ProcessStartInfo(caller.getPName());
        string directory = caller.getDirectory();
        if(directory.Contains(":")){
            directory = caller.getDirectory().ToCharArray()[0] + ": && cd " + caller.getDirectory();
        }
        directory = directory + " &&";
        string command = caller.getPrefix() + " " + directory + " " +  caller.getCmd();

        if(caller.autoExit()){
             command += " && exit";
        }
        Console.WriteLine(command);
        processStartInfo.Arguments = command;
        
        
        if (caller.getPrefix().Equals("/c")){
            processStartInfo.UseShellExecute = false;
            processStartInfo.CreateNoWindow = true;
        }
        processStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Minimized;
        //
        /*
        processStartInfo.RedirectStandardInput = true;        
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.RedirectStandardError = true;
        */

		this.process.StartInfo = processStartInfo;	

        /*
        StreamWriter standardInput = this.process.StandardInput;
        StreamReader standardOutput = this.process.StandardOutput;
        standardInput.AutoFlush = true;
        standardInput.Write(command + Environment.NewLine);
        standardInput.Flush();*/
            
        //if (caller.getPrefix().Equals("/k")){
        return ph.setProcess(this.process);
	}
}
