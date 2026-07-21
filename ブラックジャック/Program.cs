using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ブラックジャック
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] card = new int[13];
            Random r = new Random();
            string no = "no";
            int point = 0;
            int ace = 0;

            while (true) 
            {
                int draw;
                draw = r.Next(13);
                if (card[draw] != 1)
                {
                    card[draw] = 1;
                    draw++;
                    Console.WriteLine("draw:"+draw);
                    if (draw == 1) 
                    {
                        ace = 1;
                        draw = 0;
                    }
                    if(draw > 10)
                    {
                        draw = 10;
                    }
                    point += draw;

                    if (ace != 0)
                    {
                        if (point + 11 <= 21) ace = 11;
                        else ace = 1;
                    }
                    if (point + ace < 21) 
                    {
                        int p = point + ace;
                        Console.WriteLine("point:" + p);
                    } 
                    else if (point + ace > 21)
                    {
                        int p = point + ace;
                        Console.WriteLine("point:" + p);
                        Console.WriteLine("burst");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Blackjack");
                        break;
                    }
                    Console.WriteLine("続けますか?");
                    string cont = Console.ReadLine();
                    if (cont.Equals(no))
                    {
                        break;
                    }
                }
                

            }
        }
    }
}
