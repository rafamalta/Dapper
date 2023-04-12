﻿using BlogDapper.Screens.CategoryScreen;
using BlogDapper.Screens.TagScreens;
using Microsoft.Data.SqlClient;

namespace BlogDapper
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;
                                            Database=Blog;
                                            User ID=sa;
                                            Password=12345678;
                                            Trusted_Connection=False;
                                            TrustServerCertificate=True";

        static void Main(string[] args)
        {
            DataBase.Connection = new SqlConnection(CONNECTION_STRING);

            DataBase.Connection.Open();

            Load();

            Console.ReadKey();
            DataBase.Connection.Close();
        }

        private static void Load()
        {
            Console.Clear();
            Console.WriteLine("Meu Blog");
            Console.WriteLine("-----------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Gestão de usuário");
            Console.WriteLine("2 - Gestão de perfil");
            Console.WriteLine("3 - Gestão de categoria");
            Console.WriteLine("4 - Gestão de tag");
            Console.WriteLine("5 - Vincular perfil/usuário");
            Console.WriteLine("6 - Vincular post/tag");
            Console.WriteLine("7 - Relatórios");
            Console.WriteLine();
            Console.WriteLine();

            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 3:
                    MenuCategoryScreen.Load(); break;
                case 4:
                    MenuTagScreen.Load(); break;
                default: Load(); break;
            }
        }
    }
}
