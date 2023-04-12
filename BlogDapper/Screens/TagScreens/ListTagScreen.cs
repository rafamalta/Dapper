﻿using BlogDapper.Models;
using BlogDapper.Repositories;

namespace BlogDapper.Screens.TagScreens
{
    public class ListTagScreen
    {
        public static void Load() 
        {
            Console.Clear();
            Console.WriteLine("Lista de tags");
            Console.WriteLine("--------------");
            List();
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<Tag>(DataBase.Connection);
            var tags = repository.Get();
            foreach (var tag in tags)            
                Console.WriteLine($"{tag.Id} - {tag.Name} ({tag.Slug})");            
        }
    }
}
