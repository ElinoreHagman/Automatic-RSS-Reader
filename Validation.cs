using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project_RSS
{
    class Validation 
    {
        private readonly PodcastFeed podcastFeed = new PodcastFeed();
        private readonly CategoryFeed categoryFeed = new CategoryFeed();
        private readonly Urlinfo info = new Urlinfo();

        public bool TboxUrlHasValue(TextBox url)
        {
            bool isValid = true;
            if (url.Text == ("")) { 

                MessageBox.Show("You must enter a valid url!");
                isValid = false; 
            }
            
            return isValid;

        }

        public bool IntervalHasValue(ComboBox interval)
        {
            bool isValid = true;
            if (interval.SelectedItem == null)
            {

                MessageBox.Show("You must choose an interval!");
                isValid = false;
            }

            return isValid;

        }

        public bool CategoryHasValue(ComboBox category) 
        {
            bool isValid = true;
            if (category.SelectedItem == null)
            {
                isValid = false;
            }

            return isValid;

        }

        public bool CategoryListIsChosen(ListBox categoryList)
        {
            bool isValid = true;
            if (categoryList.SelectedItem == null)
            {
                isValid = false;
                MessageBox.Show("You must choose a category first.");
            }

            return isValid;

        }

        public bool TboxCategoryHasValue(TextBox category)
        {
            bool isValid = true;
            if (category.Text == ("")) 
            {
                MessageBox.Show("You must write something in the field!");
                isValid = false; 
            }
            return isValid;
        }

        public bool CategoryIsSame(TextBox category)
        {
            bool isValid = true;
            if (categoryFeed.GetCategoryList().Contains(category.Text))
            {
                MessageBox.Show("Category already exsists, you must create a new category!");
                isValid = false;
            }
            return isValid;
        }

        public bool IsUrlLegitAndNew(TextBox url)
        {
            bool isLegit = true;
            if (!info.DoesUrlExist(url.Text))
            {
                isLegit = false;
            }

            foreach (var podcast in podcastFeed.GetSavedPodcasts())
            {
                if (podcast.Url.Equals(url.Text))
                {
                    isLegit = false;
                }
            }

            if (isLegit == false)
            {
                MessageBox.Show("You need to use an XML file (not a RSS(text)) that you haven't yet used.");
            }

            return isLegit;
        }    

        public bool DoesCategoryListExist(List<string> categoryList, bool message)
        {
            bool doesExist = true;
            if (categoryList.Count == 0)
            {
                doesExist = false;
                if (message)
                {
                    MessageBox.Show("You don't have any categories..");
                }
            }

            return doesExist;
        }

        public bool DoesPodcastExsist(ComboBox interval, ComboBox category)
        {
            bool doesExsist = true; 
            if(interval.SelectedItem == null || category.SelectedItem == null)
            {
                MessageBox.Show("You must input the information!");
                doesExsist = false;
            }
            return doesExsist;
        }

        public bool CanPodcastBeDeleted(DataGridView table)
        {
            bool isSelected = true;
            if (table.SelectedRows.Count==0)
            {
                MessageBox.Show("You must choose a podcast to delete!");
                isSelected = false;
            }
            return isSelected;
        }

    }
}
