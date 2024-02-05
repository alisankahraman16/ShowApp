namespace ShowsApp.Models
{
    public class Repository
    {
        private static readonly List<Show> _shows = new();
        private static readonly List<Category> _categories = new();

        static Repository()
        {
            _categories.Add(new Category {CategoryId = 1, Name = "Show"});
            _categories.Add(new Category {CategoryId = 2, Name = "Serie"});
            _categories.Add(new Category {CategoryId = 3, Name = "Movie"});

            _shows.Add(new Show {
                ShowId=1,
                ShowTitle = "SILICON VALLEY",
                ShowGenre = "Comedy",
                ShowRate = 8.5,
                Image = "SiliconValley.jpg",
                CategoryId = 1
            });

             _shows.Add(new Show {
                ShowId=2,
                ShowTitle = "Sherlock",
                ShowGenre = "Crime",
                ShowRate = 9.2,
                Image = "Sherlock.jpg",
                CategoryId = 2
            });

             _shows.Add(new Show {
                ShowId=3,
                ShowTitle = "Emma",
                ShowGenre = "Romantic Comedy",
                ShowRate = 8.1,
                Image = "Emma.jpg",
                CategoryId = 1
            });

             _shows.Add(new Show {
                ShowId=2,
                ShowTitle = "The IT Crowd",
                ShowGenre = "Comedy",
                ShowRate = 8.5,
                Image = "TheITCrowd.jpg",
                CategoryId = 1
            });
        }

        public static List<Show> Shows
        {
            get
            {
                return _shows;
            }
        }

        public static void CreateShow(Show entitiy)
        {
            _shows.Add(entitiy);
        }

        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }
    }
}