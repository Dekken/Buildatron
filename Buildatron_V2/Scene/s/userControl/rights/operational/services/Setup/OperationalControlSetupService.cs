using System;
using System.Windows.Forms;

namespace Buildatron.Scene.s.userControl.rights.operational.services.setup {
    public class OperationalControlSetupService {

        public static OperationalControlSetupService instance;
        public static OperationalControlSetupService getInstance() {
            if (OperationalControlSetupService.instance == null) {
                OperationalControlSetupService.instance = new OperationalControlSetupService();
            }
            return OperationalControlSetupService.instance;
        }

        private void setupConfigurables() { }

        public void initialiseBuildingForm(OperationalControl form) {
            form.setCmdTextBox("WELCOME");
            
            /*
            if (System.IO.File.Exists("C:\\maven.txt")) {
                string[] lines = System.IO.File.ReadAllLines("C:\\maven.txt");
                if (lines[0] != null) {
                    if (lines[0].Substring(0, 1).Equals("#")) {
                        form.directoryInput.Text = lines[0].Substring(1).Trim();
                        form.populateTreeButton_Click(this, System.EventArgs.Empty);
                    }
                }
            }
            */
        }

    }
}