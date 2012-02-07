using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace Buildatron
{
    /*
    static class Program{    
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AutoMav());
        }
    }*/

    class Program {

        private static bool devMode = false;

        private static SceneManager sceneManager;

        public static SceneManager SceneManager {
            get { return sceneManager; }
        }

        public Program() {

            foreach(string s in Environment.GetCommandLineArgs()){
                devMode = s.Equals("-dev") ? true : false;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            sceneManager = new SceneManager();

            SceneManager.selectScene(new Buildatron.Scene.s.UserControlForm());

            Application.Run(sceneManager);
        }
        
        /// The main entry point for the application
        [STAThread]
        static void Main() {
            new Program();
        }

        public static bool isDevMode(){
            return Program.devMode;
        }
    }
}
