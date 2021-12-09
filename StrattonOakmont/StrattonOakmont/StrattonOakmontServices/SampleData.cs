using StrattonOakmontModels;
using System.Collections.Generic;
using System.Linq;

namespace StrattonOakmontServices
{
    public class SampleData
    {
		public static void Initialize(AppDBContext db)
		{
			if (!db.Companies.Any())
			{
				db.Companies.AddRange(
					new Company()
					{
						Name = "Google",
						Desc = "Goooooooogle!!!!!!",
						Сapitalization = 250000000,
						IMG = "/admin/IMG/Google.jpg",
					},
					new Company()
					{
						Name = "Amazon",
						Desc = "Amazooooooooooooooon!!!!!!",
						Сapitalization = 20000000,
						IMG = "/admin/IMG/Amazon.jpg",
					},
					new Company()
					{
						Name = "Facebook",
						Desc = "Faceeeeeeeeeebook!!!!!!",
						Сapitalization = 3333333,
						IMG = "/admin/IMG/Google.jpg",
					}
				);
			}

            if (!db.Categories.Any())
            {
				db.Categories.AddRange(
					new Category()
					{
						CategoryName = "Stock",
					},
					new Category()
					{
						CategoryName = "Bond",
					}
				);
			}

			db.SaveChanges();
		}

		public static Dictionary<string, Category> Category;
		public static Dictionary<string, Category> Categories
		{
			get
			{
				Category[] categories = new Category[]
				{
					new Category()
					{
						CategoryName = "Stock",
					},
					new Category()
					{
						CategoryName = "Bond",
					},
				};

				Category = new Dictionary<string, Category>();
				foreach (var i in categories)
				{
					Category.Add(i.CategoryName, i);
				}
				return Category;
			}
		}
	}
}
