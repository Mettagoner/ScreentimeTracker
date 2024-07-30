using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Screentime
{
    internal class ListViewUpdater
    {
        //Define private fields
        private ListView listView; //This field will hold the reference to the appropriate ListView instance (Placed in the designer)

        //Constructor
        public ListViewUpdater(ListView listView)
        {
            this.listView = listView; //This sets the private field listView defined in this class to the listView parameter passed to the constructor
            InitializeListView();
        }

        //Function to initialize the designer's ListView box (This function may cause unexpected behavior if the ListViews properties are set manually in the properties tab of the designer)
        private void InitializeListView()
        {
            listView.View = View.Details;
            listView.Columns.Add("Application Name", 200, HorizontalAlignment.Left);
            listView.Columns.Add("Usage Time", 100, HorizontalAlignment.Left);
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.Sorting = SortOrder.Ascending;
        }

        //Function to update the 'ListView' control (i.e. the ListView in the designer)
        public void UpdateListView(Dictionary<string, TimeSpan> appUsageTimes)
        {
            listView.Items.Clear(); //Clear the listview items for repopulation
            foreach (var app in appUsageTimes.OrderByDescending(x => x.Value))
            {
                ListViewItem item = new ListViewItem(app.Key);
                item.SubItems.Add(app.Value.ToString(@"hh\:mm\:ss"));
                listView.Items.Add(item); //Adds the listView item to the 'ListView' control
            }
        }
    }
}
