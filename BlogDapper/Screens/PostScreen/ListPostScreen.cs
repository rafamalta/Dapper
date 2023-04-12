using BlogDapper.Models;
using BlogDapper.Repositories;
using BlogDapper.Screens.TagScreens;

namespace BlogDapper.Screens.PostScreen
{
    public class ListPostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de posts");
            Console.WriteLine("--------------");
            List();
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<Post>(DataBase.Connection);
            var posts = repository.Get();
            foreach (var post in posts)
                Console.WriteLine($"{post.Id} - {post.Title} - ({post.Slug})");
        }
    }
}
