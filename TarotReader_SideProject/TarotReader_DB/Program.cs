using System;

namespace TarotReader_SideProject
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface user = new UserInterface();

            user.Intro();
            user.MainMenu();
        }
    }
}
