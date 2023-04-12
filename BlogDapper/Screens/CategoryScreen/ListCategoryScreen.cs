using BlogDapper.Models;
using BlogDapper.Repositories;
using BlogDapper.Screens.TagScreens;

namespace BlogDapper.Screens.CategoryScreen
{
    public class ListCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de categories");
            Console.WriteLine("--------------");
            List();
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<Category>(DataBase.Connection);
            var categories = repository.Get();
            foreach (var category in categories)
                Console.WriteLine($"{category.Id} - {category.Name} ({category.Slug})");
        }
    }
}
