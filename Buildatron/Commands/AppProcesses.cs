using System;
using System.Collections.Generic;

public class AppProcesses
{
	private static AppProcesses instance;
	private Dictionary<string, App> apps = new Dictionary<string, App>();
	private AppProcesses(){}

	public static AppProcesses getInstance(){
		if (AppProcesses.instance == null){
			AppProcesses.instance = new AppProcesses();
		}
		return AppProcesses.instance;
	}

	public bool containsApp(string s){
		return this.apps.ContainsKey(s);
	}

	public Dictionary<string, App> getApps(){
		return this.apps;
	}

	public void addApp(string s, App a){
		this.apps.Add(s, a);
	}
}
