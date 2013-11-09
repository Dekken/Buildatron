using System;

public class Sequence{

	
	private string dir 	= "";
	private string cmd 	= "";
	private string inc 	= "";
	private string dis 	= "";
	private string ae 	= "";

	public Sequence(string dir, string cmd, string inc, string dis, string ae) {
		this.dir 	= dir;
		this.cmd 	= cmd;	
		this.inc 	= inc;	
		this.dis 	= dis;	
		this.ae 	= ae;	
	}
	public string directory(){
		return this.dir;
	}
	public string command(){
		return this.cmd;
	}
	public string include(){
		return this.inc;
	}
	public string display(){
		return this.dis;
	}
	public string autoExit(){
        return this.ae;
	}
}