using System;
using System.Collections.Generic;
using System.IO;

namespace Project_RSS
{
    class Category : Filewriter
    {
        public void AddCategory(string category)
        {
            categories.Add(category);
            using (StreamWriter sw = File.AppendText(savedCategories))
            {
                sw.WriteLine(category);
            }
        }

        public void DeleteCategory(string category)
        {
            categories.Remove(category);
            UpdateCategoryList(categories);
        }

        public void ChangeCategory(string chosenCategory, string newName)
        {
            int categoryIndex = categories.IndexOf(chosenCategory);
            categories[categoryIndex] = newName;
            UpdateCategoryList(categories);
        }

        public List<string> GetCategories()
        {
            categories.Clear();
            if (File.Exists(savedCategories) == true)
            {
                using (StreamReader sr = new StreamReader(savedCategories))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        categories.Add(line);
                    }
                }
            }
            return categories;
        }

        public void UpdateCategoryList(List<string> categoryList)
        {
            File.WriteAllText(savedCategories, string.Empty);
            using (StreamWriter sw = File.AppendText(savedCategories))
            {
                foreach (var c in categoryList)
                {
                    sw.WriteLine(c);
                }
            }
        }
    }
}
