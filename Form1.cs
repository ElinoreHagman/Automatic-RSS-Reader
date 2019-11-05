using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Project_RSS
{
    public partial class Form1 : Form
    {
        private readonly PodcastFeed podcastFeed = new PodcastFeed();
        private readonly CategoryFeed categoryFeed = new CategoryFeed();
        private int chosenPodcastIndex = 0;
        private readonly Validation validation = new Validation();

        public Form1()
        {
            InitializeComponent();
            FillInCategories();
            FillOutIntervalCombobox();
            FillOutTable();
            SetTimerWhenPageOpens();
        }

        private void BtnAddCategory_Click(object sender, EventArgs e)
        {
            if(validation.TboxCategoryHasValue(TbInputCategory) && validation.CategoryIsSame(TbInputCategory))
            {
                categoryFeed.AddCategorytoList(TbInputCategory.Text);

                ClearCategoryFields();
                FillInCategories();
            }
        }

        private void BtnDeleteCategory_Click(object sender, EventArgs e)
        {
            if(validation.CategoryListIsChosen(ListCategories))
            {
                categoryFeed.Delete(TbInputCategory.Text);
                ClearCategoryFields();
                FillInCategories();
            }
        }

        private void BtnSaveCategory_Click(object sender, EventArgs e)
        {
            if (validation.CategoryListIsChosen(ListCategories) && validation.TboxCategoryHasValue(TbInputCategory))
            {
            var oldName = ListCategories.SelectedItem;
            string newName = TbInputCategory.Text;
            categoryFeed.ChangeCategoryInformation(oldName.ToString(), newName);
            ClearCategoryFields();
            FillInCategories();
            }
        }

        private void ListCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCategory = ListCategories.SelectedItem;
            if (selectedCategory != null)
            {
                TbInputCategory.Text = selectedCategory.ToString();
            }
        }

        private async void LbAddPodcast_Click(object sender, EventArgs e)
        {
            if (validation.TboxUrlHasValue(TbUrl) && validation.IsUrlLegitAndNew(TbUrl) && validation.IntervalHasValue(CboxInterval))
            {
                if (validation.CategoryHasValue(CboxCategory))
                {
                    Podcast p = await podcastFeed.AddNewPodcast(TbUrl.Text, CboxCategory.SelectedItem.ToString(), CboxInterval.SelectedItem.ToString());
                    TableFeed.Rows.Add(p.TotalEpisodes, p.Name, p.Interval, p.Category);

                    SetTimer();

                } else
                {
                    Podcast p = await podcastFeed.AddNewPodcast(TbUrl.Text, CboxInterval.SelectedItem.ToString());
                    TableFeed.Rows.Add(p.TotalEpisodes, p.Name, p.Interval, p.Category);

                    SetTimer();
                }
            }
        }

        private void LbDeletePodcast_Click(object sender, EventArgs e)
        {
            if (validation.CanPodcastBeDeleted(TableFeed)) {
                int rowindex = TableFeed.CurrentRow.Index;
                TableFeed.Rows.RemoveAt(rowindex);
                podcastFeed.Delete(rowindex);
                ListPodcastEpisodes.Items.Clear();
                LbEpisodes.Text = "Podcast episodes";
                LbPodcastInformation.Text = "Episode description";
                TxtPodcastDescription.Text = "";
            }             
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LbPodcastInformation.Text = "Episode description";
            TxtPodcastDescription.Text = "";
            LbEpisodes.Text = "";
            ListPodcastEpisodes.Items.Clear();

            int selectedRowCount = TableFeed.Rows.GetRowCount(DataGridViewElementStates.Selected);
            chosenPodcastIndex = 0;
            LbEpisodes.Text = TableFeed.SelectedRows[chosenPodcastIndex].Cells[1].Value.ToString();

            for (int i = 0; i < selectedRowCount; i++)
            {
                chosenPodcastIndex = TableFeed.SelectedRows[i].Index;
            }

            List<Episode> episodeList = podcastFeed.GetEpisodeList(chosenPodcastIndex);
            foreach(var article in episodeList)
            {
                ListPodcastEpisodes.Items.Add(article.EpisodeName);
            }

            TbUrl.Text = podcastFeed.GetPodcastUrl(chosenPodcastIndex);
            CboxCategory.SelectedItem = podcastFeed.GetPodcastCategory(chosenPodcastIndex);
            CboxInterval.SelectedItem = podcastFeed.GetInterval(chosenPodcastIndex);
        }

        private void LbSavePodcast_Click(object sender, EventArgs e)
        {
            if(validation.DoesPodcastExsist(CboxInterval, CboxCategory))
            
            {
                string category = CboxCategory.SelectedItem.ToString();
                string interval = CboxInterval.SelectedItem.ToString();
                int rowIndex = TableFeed.CurrentRow.Index;

                if (TableFeed.Rows.Count > 0) { TableFeed.Rows.Clear(); }
                podcastFeed.UpdatePodcast(rowIndex, category, interval);
                FillOutTable();
            }
        }

        private void FillInCategories()
        {
            var categoryList = categoryFeed.GetCategoryList();
            if (validation.DoesCategoryListExist(categoryList, false))
            {
                foreach (var c in categoryList)
                {
                    ListCategories.Items.Add(c);
                    CboxCategory.Items.Add(c);
                }
            }
        }

        private void ClearCategoryFields()
        {
            TbInputCategory.Clear();
            ListCategories.Items.Clear();
            CboxCategory.Items.Clear();
        }

        private void FillOutTable()
        {
            var podcastList = podcastFeed.GetSavedPodcasts();
            foreach(var p in podcastList)
            {
                TableFeed.Rows.Add(p.TotalEpisodes, p.Name, p.Interval, p.Category);
            }
        }

        private void FillOutIntervalCombobox()
        {
            CboxInterval.Items.Add("Every 10 minutes");
            CboxInterval.Items.Add("Every 30 minutes");
        }

        private void ListPodcastEpisodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPodcast = ListPodcastEpisodes.SelectedItem.ToString();
            LbPodcastInformation.Text = selectedPodcast;

            List<Episode> episodeList = podcastFeed.GetEpisodeList(chosenPodcastIndex);

            foreach (var episode in episodeList)
            {
                if (episode.EpisodeName.Equals(selectedPodcast))
                {
                    string desc = episode.EpisodeDescription;
                    string removeText = @"<br/><br/>";
                    TxtPodcastDescription.Text = desc.Replace(removeText + " ", "");
                }
            }
        }

		private void BtnListPodcastsFromCategory_Click(object sender, EventArgs e)
		{
            var categoryList = categoryFeed.GetCategoryList();
            if (validation.DoesCategoryListExist(categoryList, true) && validation.CategoryListIsChosen(ListCategories))
            {
                string chosenCategory = ListCategories.SelectedItem.ToString();
                TableFeed.Rows.Clear();
                List<Podcast> pList = podcastFeed.GetSavedPodcasts();

                var podQuery =
                from pod in pList
                where pod.Category == chosenCategory
                select pod;

                foreach (var p in podQuery)
                {
                    TableFeed.Rows.Add(p.TotalEpisodes, p.Name, p.Interval, p.Category);
                }
            }
        }

        private void BtnShowAll_Click(object sender, EventArgs e)
        {
            TableFeed.Rows.Clear();
            FillOutTable();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer timer = (Timer)sender;
            string url = (string)timer.Tag;
            podcastFeed.UpdatePodcast(url);
            TableFeed.Rows.Clear();
            FillOutTable();
        }

        public void SetTimer()
        {
            string intervalString = CboxInterval.SelectedItem.ToString();
            int chosenInterval;

            if (intervalString.Equals("Every 10 minutes"))
            {
                chosenInterval = 600000;
            }
            else
            {
                chosenInterval = 1800000;
            }

            var timer = new Timer
            {
                Interval = chosenInterval,
                Enabled = true,
                Tag = TbUrl.Text
            };

            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }

        public void SetTimerWhenPageOpens()
        {
            int chosenInterval;
            List<Podcast> podcastList = podcastFeed.GetSavedPodcasts();

            foreach (var p in podcastList)
            {
                string pInterval = p.Interval;
                string eachUrl = p.Url;

                if (pInterval.Equals("Every 10 minutes"))
                {
                    chosenInterval = 600000;
                }
                else
                {
                    chosenInterval = 1800000;
                }

                var timer = new Timer
                {
                    Interval = chosenInterval,
                    Enabled = true,
                    Tag = eachUrl
                };

                timer.Tick += new EventHandler(timer1_Tick);
                timer.Start();
            }
        }

        private void TbInputCategory_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TbUrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void CboxInterval_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtPodcastDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void CboxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
