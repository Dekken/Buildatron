using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Buildatron {

    public class SceneManager : ApplicationContext{

        //private string selectedPlaylist;
        protected bool exitAppOnClose;

        public void selectScene(Form f){
            //forms.Add(f);
            if (MainForm != null) {
                MainForm.Hide();
            }
            MainForm = f;
            MainForm.Show();
        }

        // when a form is closed, don't exit the application if this is a swap
        protected override void OnMainFormClosed(object sender, EventArgs e){
            if (exitAppOnClose){
                base.OnMainFormClosed(sender, e);
            }
        }
    }
}
