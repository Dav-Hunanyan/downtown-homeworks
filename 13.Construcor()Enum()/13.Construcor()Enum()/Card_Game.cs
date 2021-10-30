using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Construcor__Enum__
{

    class Program
    {

        enum Cards_Type : byte
        {
            spades = 1,
            clubs,
            hearts,
            diamonds,
            none

        }
        struct Player
        {
            public string name;
            public Cards_Type[] player;
            public Cards_Type played;
            public bool isLost;
            public Player(Cards_Type[] item, string name, Cards_Type played = Cards_Type.none, bool lose = false)
            {
                item = player_cards();
                player = item;
                this.name = name;
                this.played = played;
                this.isLost = lose;
            }


            public void delete(int deleted)
            {
                Cards_Type[] temp = new Cards_Type[player.Length - 1];
                for (int i = 0; i < player.Length; i++)
                {
                    if (i < deleted - 1)
                    {
                        temp[i] = player[i];
                    }
                    if (i > deleted - 1)
                    {
                        temp[i - 1] = player[i];
                    }
                }
                player = temp;
            }
            public void print()
            {
                Console.Write(name + " cards:  ");
                for (int i = 0; i < player.Length; i++)
                {
                    Console.Write((i + 1) + "." + player[i] + "   ");
                }
                Console.WriteLine();
            }
        }

        static Cards_Type[] player_cards()
        {

            Random r = new Random();
            Cards_Type[] item = new Cards_Type[5];
            for (int i = 0; i < 5; i++)
            {
                item[i] = (Cards_Type)(r.Next(1, 5));
            }
            return item;
        }


        static void game()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"            GAME RULES
If you play the same type of card that plays
the player before you then you LOSE the game otherwise you WIN.
GOOD LUCK");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            start: Console.Write("How many players are playing(2 to 5): ");
            int players_count = int.Parse(Console.ReadLine());
            if (players_count < 2 || players_count > 5)
            {
                Console.WriteLine("This game can play only(2 to 5) players");
                goto start;
            }
            Console.ForegroundColor = ConsoleColor.White;

            Player[] players = new Player[players_count];
            for (int i = 0; i < players_count; i++)
            {
                start0: Console.Write("Enter " + (i + 1) + " player name: ");
                string pl_name = Console.ReadLine();
                if (pl_name == "")
                {
                    Console.WriteLine("You didn't enter name");
                    goto start0;
                }
                Cards_Type[] pl_cards = player_cards();
                players[i] = new Player(pl_cards, pl_name);
                for (int j = 0; j < i; j++)
                {
                    if (players[i].name == players[j].name)
                    {
                        Console.WriteLine("That name is already used..Please enter another name");
                        goto start0;
                    }
                }
            }

            for (int i = 0; i < players_count; i++)
            {
                switch (i)
                {
                    case 0: Console.ForegroundColor = ConsoleColor.Cyan; break;
                    case 1: Console.ForegroundColor = ConsoleColor.Yellow; break;
                    case 2: Console.ForegroundColor = ConsoleColor.DarkGray; break;
                    case 3: Console.ForegroundColor = ConsoleColor.Gray; break;
                    case 4: Console.ForegroundColor = ConsoleColor.DarkCyan; break;
                }

                players[i].print();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t\t\tGAME  STARTED\n");
            do
            {
                for (int i = 0; i < players_count; i++)
                {

                    switch (i)
                    {
                        case 0: Console.ForegroundColor = ConsoleColor.Cyan; break;
                        case 1: Console.ForegroundColor = ConsoleColor.Yellow; break;
                        case 2: Console.ForegroundColor = ConsoleColor.DarkGray; break;
                        case 3: Console.ForegroundColor = ConsoleColor.Gray; break;
                        case 4: Console.ForegroundColor = ConsoleColor.DarkCyan; break;
                    }

                    Console.WriteLine();

                    players[i].print();
                    right1: Console.Write(players[i].name + ": Which card do you want to play: ");
                    int played = int.Parse(Console.ReadLine());
                    if (played > players[i].player.Length)
                    {
                        Console.WriteLine("You have only " + players[i].player.Length + " cards.Please give right number!");
                        goto right1;
                    }
                    players[i].played = players[i].player[played - 1];
                    players[i].delete(played);
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(players[i].name + " played: " + players[i].played);
                    if (i > 0 && players[i].played == players[i - 1].played)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n" + players[i].name + " LOSE the game\n");
                        if (players_count == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\t\tThe winner is: " + players[0].name);
                            Console.WriteLine("\t\tCongratulations\n");
                            return;
                        }
                        Player temp = players[i];
                        for (int j = i; j < players_count - 1; j++)
                        {
                            players[j] = players[j + 1];
                        }
                        players[players.Length - 1] = temp;
                        players_count--;
                        i--;
                    }
                    if (i == 0 && players[i].played == players[i + players_count - 1].played)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n" + players[i].name + " LOSE the game\n");
                        if (players_count == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\t\tThe winner is: " + players[1].name);
                            Console.WriteLine("\t\tCongratulations\n");
                            return;
                        }
                        Player temp = players[i];
                        for (int j = i; j < players_count - 1; j++)
                        {
                            players[j] = players[j + 1];
                        }
                        players[players.Length - 1] = temp;
                        players_count--;
                        i--;
                    }

                }


                if (players[players_count - 1].player.Length == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nThere is no winner.Play again\n");
                }


            } while (players[players_count - 1].player.Length != 0);

        }
        static void Main(string[] args)
        {

            int command;
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Give command( 1.Start 2.Exit):  ");
                command = int.Parse(Console.ReadLine());
                switch (command)
                {
                    case 1:
                        game();
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("THANK YOU FOR PLAYING OUR GAME");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong command!");
                        break;
                }

            } while (command != 2);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
