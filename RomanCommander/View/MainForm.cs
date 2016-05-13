using RomanCommander.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomanCommander
{
    
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch(keyData)
            {
                case (Keys.Control | Keys.F):
                    MessageBox.Show("What the Ctrl+F?");    
                    return true;
                case (Keys.Alt | Keys.F1):
                    navigationPanel1.ExpandSelectDrive();
                    return true;
                case (Keys.Alt | Keys.F2):
                    navigationPanel2.ExpandSelectDrive();
                    return true;
                case (Keys.F5):
                    ActivateCopyAction();
                    return true;
                case (Keys.F8):
                    ActivateDeleteAction();
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ActivateCopyAction()
        {
            if (navigationPanel1.HasFocus)
            {
                FileOperations.Copy(navigationPanel1.GetSelectedItems(), navigationPanel2.ActivePath);
                navigationPanel2.ActivePath = navigationPanel2.ActivePath;
            }
            else if (navigationPanel2.HasFocus)
            {
                FileOperations.Copy(navigationPanel2.GetSelectedItems(), navigationPanel1.ActivePath);
                navigationPanel1.ActivePath = navigationPanel1.ActivePath;
            }
        }

        private void ActivateDeleteAction()
        {
            if (navigationPanel1.HasFocus)
            {
                FileOperations.Delete(navigationPanel1.GetSelectedItems());
                navigationPanel1.ActivePath = navigationPanel1.ActivePath;
            }
            else if (navigationPanel2.HasFocus)
            {
                FileOperations.Delete(navigationPanel2.GetSelectedItems());
                navigationPanel1.ActivePath = navigationPanel1.ActivePath;
            }
        }




        private void CopyButton_Click(object sender, EventArgs e)
        {
            ActivateCopyAction();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }



    }
}
