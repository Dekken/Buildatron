using System;

public class ProcessCaller
{
	private string pName        = "";
    private string prefix       = "";
    private string directory    = "";
	private string cmd          = "";
	private string special      = "";

    private bool echoVar            = false;
    private bool autoExitVar        = false;
    private bool waitForExitVar     = false;
    private bool autoStartVar       = false;

    public ProcessCaller(string pName){ 
        this.pName = pName;
	}

	public void setCmd(string cmd)              { this.cmd = cmd; }
    public void setPrefix(string prefix)        { this.prefix = prefix; }
	public void setSpecial(string special)      { this.special = special; }
    public void setDirectory(string directory)  { this.directory = directory; }
	
    public string getPName()        { return this.pName; }
	public string getCmd()          { return this.cmd; }
    public string getPrefix()       { return this.prefix; }
	public string getSpecial()      { return this.special; }
    public string getDirectory()    { return this.directory; }

    public void setEcho()       { this.echoVar = true; }
    public bool echo()          { return this.echoVar; }

    public void setAutoExit()   { this.autoExitVar = true; }
    public bool autoExit()      { return this.autoExitVar; }

    public void setWaitForExit() { this.waitForExitVar = true; }
    public bool waitForExit()      { return this.waitForExitVar; }

    public void setAutoStart() { this.autoStartVar = true; }
    public bool autoStart()     { return this.autoStartVar; }
}
