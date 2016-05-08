using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeptlyAdaptiveChallenge.Models
{
    public class NewsItems
    {
        public enum CategoryEnum { Financial, Food };

        public int Id { get; set; }
        public CategoryEnum Category { get; set; }
        public string Headline { get; set; }
        public string Subhead { get; set; }
        public string DateLine { get; set; }
        public string Image { get; set; }
    }

    public class NewsItemManager
    {
        public static void CategorySelector
            (NewsItems.CategoryEnum selectedCategory, ObservableCollection<NewsItems> newsItems)
        {
            newsItems.Clear();
            
            var _newsItems = NewsItemManager.GetNewsItems()
                .Where(p => p.Category == selectedCategory)
                .ToList();

            _newsItems.ForEach(p => newsItems.Add(p));
        }

        public static ObservableCollection<NewsItems> GetNewsItems()
        {
            var items = new ObservableCollection<NewsItems>();

            items.Add(new NewsItems() { Id = 1, Category = NewsItems.CategoryEnum.Financial, Headline = "Lorem Ipsum", Subhead = "doro sit amet", DateLine = "Nunc tristique nec", Image = "Assets/Financial1.png" });
            items.Add(new NewsItems() { Id = 2, Category = NewsItems.CategoryEnum.Financial, Headline = "Etiam ac felis viverra", Subhead = "vulputate nisl ac, aliquet nisi", DateLine = "tortor porttitor, eu fermentum ante congue", Image = "Assets/Financial2.png" });
            items.Add(new NewsItems() { Id = 3, Category = NewsItems.CategoryEnum.Financial, Headline = "Integer sed turpis erat", Subhead = "Sed quis hendrerit lorem, quis interdum dolor", DateLine = "in viverra metus facilisis sed", Image = "Assets/Financial3.png" });
            items.Add(new NewsItems() { Id = 4, Category = NewsItems.CategoryEnum.Financial, Headline = "Proin sem neque", Subhead = "aliquet quis ipsum tincidunt", DateLine = "Integer eleifend", Image = "Assets/Financial4.png" });
            items.Add(new NewsItems() { Id = 5, Category = NewsItems.CategoryEnum.Financial, Headline = "Mauris bibendum non leo vitae tempor", Subhead = "In nisl tortor, eleifend sed ipsum eget", DateLine = "Curabitur dictum augue vitae elementum ultrices", Image = "Assets/Financial5.png" });

            items.Add(new NewsItems() { Id = 6, Category = NewsItems.CategoryEnum.Food, Headline = "Lorem ipsum", Subhead = "dolor sit amet", DateLine = "Nunc tristique nec", Image = "Assets/Food1.png" });
            items.Add(new NewsItems() { Id = 7, Category = NewsItems.CategoryEnum.Food, Headline = "Etiam ac felis viverra", Subhead = "vulputate nisl ac, aliquet nisi", DateLine = "tortor porttitor, eu fermentum ante congue", Image = "Assets/Food2.png" });
            items.Add(new NewsItems() { Id = 8, Category = NewsItems.CategoryEnum.Food, Headline = "Integer sed turpis erat", Subhead = "Sed quis hendrerit lorem, quis interdum dolor", DateLine = "in viverra metus facilisis sed", Image = "Assets/Food3.png" });
            items.Add(new NewsItems() { Id = 9, Category = NewsItems.CategoryEnum.Food, Headline = "Proin sem neque", Subhead = "aliquet quis ipsum tincidunt", DateLine = "Integer eleifend", Image = "Assets/Food4.png" });
            items.Add(new NewsItems() { Id = 10, Category = NewsItems.CategoryEnum.Food, Headline = "Mauris bibendum non leo vitae tempor", Subhead = "In nisl tortor, eleifend sed ipsum eget", DateLine = "Curabitur dictum augue vitae elementum ultrices", Image = "Assets/Food5.png" });

            return items;
        }
    }
}
