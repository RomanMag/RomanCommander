using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanCommander.Controller
{
    public interface iNavigationPanel
    {
       
        


    }

    public class BrowseViewItem
    {
        //General 
        public string FullPath { set; get; }
        int ItemType { set; get; }
        string ItemName { set; get; }



        BrowseViewItem(string FullItemPath)
        {
            FullPath = FullItemPath;

        }
        
        public bool Refresh()
        {
            //TODO: implement Refresh Item functionality
            return true;
        }

    }

    

}
