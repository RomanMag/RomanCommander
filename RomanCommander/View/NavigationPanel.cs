using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomanCommander.View
{
    public partial class NavigationPanel : UserControl
    {

        private string activepath;//=Path.GetFullPath("C:\\");
        private List<FileInfo> fileinfos;
        private List<DirectoryInfo> directoryinfos;
        private List<FileSystemInfo> FSInfos;

        public bool HasFocus { set; get; }

        public string ActivePath //Se
        {
            set
            {
                if (PathIsValid(value))
                {

                    string previouspath = activepath;
                    activepath = Path.GetFullPath(value);

                    //GetBrowseViewDirectories();
                    //GetBrowseViewFiles();
                    GetBrowseViewFSInfos();
                    RefreshBrowseView();

                }
            }

            get
            {
                return activepath;
            }
        }

        private void GetBrowseViewFiles()
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(activepath);
            FileInfo[] files = dir.GetFiles();

        }

        private void GetBrowseViewDirectories()
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(activepath);
            DirectoryInfo[] dirs = dir.GetDirectories();
        }

        private void GetBrowseViewFSInfos()
        {

            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(activepath);
            FileSystemInfo[] tmp = dir.GetFileSystemInfos();
            FSInfos = null;
            FSInfos = new List<FileSystemInfo>();
            foreach (FileSystemInfo fs in tmp)
            {

                FSInfos.Add(fs);

            }


        }

        private bool PathIsValid(string path)
        {
            if ((path == null) || !Directory.Exists(path))// || path == activepath)
            {
                return false;
            }
            return true;
        }

        public void RefreshBrowseView()
        {
            BrowseView.Items.Clear();
            //Add [...] to the top of the list
            if (Path.GetFullPath(activepath) != Path.GetPathRoot(activepath))
            {
                ListViewItem newListItem = new ListViewItem("[...]");

                newListItem.SubItems.Add("");
                newListItem.SubItems.Add("");
                newListItem.SubItems.Add("");

                System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(activepath);
                dir = Directory.GetParent(activepath);
                newListItem.SubItems.Add(dir.FullName);
                
                BrowseView.Items.Add(newListItem);
            }

            foreach (FileSystemInfo fs in FSInfos)
            {
                //Name column [0]
                ListViewItem newListItem = new ListViewItem(fs.Name);

                //Extention column [1]
                if ((fs.Attributes & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    newListItem.SubItems.Add("[dir]");

                }
                else
                {
                    if (fs.Extension == "")
                    {
                        newListItem.SubItems.Add("[file]");
                    }
                    else
                    {
                        newListItem.SubItems.Add(fs.Extension);
                    }

                }
                //Size column [2]
                if ((fs.Attributes & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    newListItem.SubItems.Add("[dir]");

                }
                else
                {
                    FileInfo fi = new FileInfo(fs.FullName);
                    newListItem.SubItems.Add(fi.Length.ToString());
                }
                
                //Attributes column [3]
                newListItem.SubItems.Add("");

                //FullPath column [4]
                newListItem.SubItems.Add(fs.FullName);


                //newListItem.SubItems.Add(fs.GetType());
                BrowseView.Items.Add(newListItem);
            }

        }

        public NavigationPanel()
        {
            InitializeComponent();
            InitializeSelectDriveComboBox();

        }

        private void BrowseView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //DirectoryInfo dir = new DirectoryInfo(BrowseView.FocusedItem.Text);
            // FileSystemInfo[] infos = dir.GetFileSystemInfos();
            {
                //ActivePath = BrowseView.FocusedItem.SubItems[4].Text;
                BrowseView_ActivateItem();

            }
        }

        private void InitializeSelectDriveComboBox()
        {
            string[] ListOfDrives = Environment.GetLogicalDrives();

            SelectDriveComboBox.Items.Clear();

            foreach (string str in ListOfDrives)
            {
                SelectDriveComboBox.Items.Add(str);
            }

            SelectDriveComboBox.SelectedItem = SelectDriveComboBox.Items[0];
        }
        private void SelectDriveComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActivePath = SelectDriveComboBox.SelectedItem.ToString();
            BrowseView.Focus();
        }

        private void BrowseView_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            { 
                case (char)Keys.Return:
                    BrowseView_ActivateItem();
                    break;
                case (char)Keys.Back:
                    BrowseView_GoBack();
                    break;
            }
        }

        private void BrowseView_GoBack()
        {
            if (Path.GetFullPath(activepath) != Path.GetPathRoot(activepath))
            {
                System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(ActivePath);
                dir = Directory.GetParent(ActivePath);
                ActivePath = dir.FullName;
            }
        }

        private void BrowseView_ActivateItem()
        {

            if (Directory.Exists(Path.GetFullPath(BrowseView.FocusedItem.SubItems[4].Text)))
            {
                ActivePath = BrowseView.FocusedItem.SubItems[4].Text;
            }
            else
            {
                System.Diagnostics.Process.Start(BrowseView.FocusedItem.SubItems[4].Text);
            }
        }

        internal void ExpandSelectDrive()
        {
            SelectDriveComboBox.Focus();
            SelectDriveComboBox.DroppedDown = true;
        }

        public List<ListViewItem> GetSelectedItems()
        {
            if (BrowseView.Focused && BrowseView.SelectedItems !=null)
            {
                List<ListViewItem> tmp = new List<ListViewItem>();
                foreach (ListViewItem lvi in BrowseView.SelectedItems)
                {
                    tmp.Add(lvi);
                }
                return tmp;
            }
            return null;
        }

        private void BrowseView_Leave(object sender, EventArgs e)
        {
            HasFocus = false;
        }

        private void BrowseView_Enter(object sender, EventArgs e)
        {
            HasFocus = true;
        }

    }
}
