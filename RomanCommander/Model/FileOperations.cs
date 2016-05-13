using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace RomanCommander.Model
{
    public class FileOperations
    {
        public static void Copy(List<ListViewItem> copylist, string copyto)
        {
            //TODO: Implement Are You Sure dialog
            foreach (ListViewItem lvi in copylist)
            {
                if (lvi.SubItems[0].Text != "[...]")
                {
                    string sourcePath = Path.GetFullPath(lvi.SubItems[4].Text); // lvi.SubItems[4].Text;

                    if (Directory.Exists(sourcePath))
                    {
                        try
                        {
                            FileSystem.CopyDirectory(sourcePath, Path.GetFullPath(copyto), UIOption.AllDialogs);
                        }
                        catch
                        { 
                            //TODO: show relevant message
                            string message = ("Maybe you canceled copy or something went wrong during copy? from [" + sourcePath + "] to [" + copyto + "]");
                            MessageBox.Show(message);
                        }
                    }
                    else
                    {
                        string copyto_file = Path.Combine(copyto, Path.GetFileName(sourcePath));
                        try
                        {
                            FileSystem.CopyFile(sourcePath, copyto_file, UIOption.AllDialogs);
                        }
                        catch
                        {
                            //TODO: show relevant message
                            string message = ("Maybe you canceled copy or something went wrong during copy? from ["+sourcePath+"] to ["+copyto+"]");
                            MessageBox.Show(message);
                        }
                    }
                }
                
                
            }

        }
        public static void Delete(List<ListViewItem> deletelist)
        { 
            //TODO: Implement Are You Sure dialog
            foreach (ListViewItem lvi in deletelist)
            {
                if (lvi.SubItems[0].Text != "[...]")
                {
                    string sourcePath = Path.GetFullPath(lvi.SubItems[4].Text); // lvi.SubItems[4].Text;
                    if (Directory.Exists(sourcePath))
                    {
                        FileSystem.DeleteDirectory(sourcePath, UIOption.AllDialogs, RecycleOption.SendToRecycleBin);
                    }
                    else if (File.Exists(sourcePath))
                    {
                        FileSystem.DeleteFile(sourcePath, UIOption.AllDialogs, RecycleOption.SendToRecycleBin);
                    }
                }
            }

        }
    }
}
