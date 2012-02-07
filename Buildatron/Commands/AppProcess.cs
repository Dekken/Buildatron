using System;

public class AppProcess
{
	private string pName    = "";
	private string cmd      = "";
	private string special  = "";

	public AppProcess(string pName) { 
        this.pName = pName;
	}

	public void setCmd(string cmd)          { this.cmd = cmd; }
	public void setSpecial(string special)  { this.special = special; }
	
    public string getPName()    { return this.pName; }
	public string getCmd()      { return this.cmd; }
	public string getSpecial()  { return this.special; }
}
