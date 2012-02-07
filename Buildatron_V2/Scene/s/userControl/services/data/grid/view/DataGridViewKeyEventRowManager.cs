using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

using Buildatron.Scene.s.userControl.rights.err;

namespace Buildatron.Scene.s.userControl.services.data.grid.view {
    public class DataGridViewKeyEventRowManager {

        public static void moveRowUpOrFail(DataGridView view, int index){
            swap(view, index - 1, index);
        }
        
        public static void moveRowDownOrFail(DataGridView view, int index) {
            swap(view, index, index + 1);
        }

        public static void deleteRowOrFail(DataGridView view, int index){
            throw new FailToMoveDataGridViewRowException();
        }

        private static void swap(DataGridView view, int a, int b){
            try{
                DataGridViewRow r1 = view.Rows[a];
                DataGridViewRow r2 = view.Rows[b];

                view.Rows.Remove(r1);
                view.Rows.Remove(r2);

                view.Rows.Insert(a, r1);
                view.Rows.Insert(a, r2);

            }
            catch(ArgumentOutOfRangeException e){ throw new FailToMoveDataGridViewRowException(); }
        }
    }
}
