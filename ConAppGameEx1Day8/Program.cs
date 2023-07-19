using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppGameEx1Day8
{
    public delegate void OurDel();
    internal class Program
    {
        static void Main(string[] args)
        {
            
            GameClass game = new GameClass();
            OurDel del = new OurDel(game.Initial);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter your lucky number");
                double lucky = double.Parse(Console.ReadLine());
                switch (lucky)
                {
                    case 1:
                        {
                            del += new OurDel(game.Firstspin);
                            break;
                        }
                    case 2:
                        {
                            del += new OurDel(game.Secondspin);
                            break;
                        }
                    case 3:
                        {
                            del += new OurDel(game.Thirdspin);
                            break;
                        }
                    case 4:
                        {
                            del += new OurDel(game.Fourthtspin);
                            break;
                        }
                    case 5:
                        {
                            del += new OurDel(game.Fifthspin);
                            break;
                        }
                    case 6:
                        {
                            del += new OurDel(game.Sixthspin);
                            break;
                        }
                    case 7:
                        {
                            del += new OurDel(game.Seventhspin);
                            break;
                        }
                    case 8:
                        {
                            del += new OurDel(game.Eighthspin);
                            break;
                        }
                    case 9:
                        {
                            del += new OurDel(game.Ninthspin);
                            break;
                        }
                    case 10:
                        {
                            del += new OurDel(game.Tenthspin);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("wrong choice!");
                            break;
                        }
                }
            }
            if (elevel >= 4 && prob > 60)
                Console.WriteLine("You Win!");
            else if(energy>=1 && prob>50)
                Console.WriteLine("You are runner up!");
            else
                Console.WriteLine("You loose!");
            Console.ReadKey();
        }
    }
}
