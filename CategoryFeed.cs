using System;
using System.Collections.Generic;

namespace Project_RSS
{
    class CategoryFeed : Feed
    {
        public List<string> GetCategoryList()
        {
            List<string> categoryList = category.GetCategories();
            return categoryList;
        }

        public void AddCategorytoList(string aCategory)
        {
            category.AddCategory(aCategory);
        }

        public override void Delete(string aCategory)
        {
            category.DeleteCategory(aCategory);
        }

        public void ChangeCategoryInformation(string oldCategoryName, string NewCategoryName)
        {
            category.ChangeCategory(oldCategoryName, NewCategoryName);
        }
    }
}
