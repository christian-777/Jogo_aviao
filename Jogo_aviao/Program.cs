internal class Program
{
    private static void Main(string[] args)
    {
        int l = 5, c = 1;
        ConsoleKeyInfo tecla;
            int x, y, p = 0;
            exibeCeu(l, c);
            do
            {
                Console.Write("tecle a direcao com as teclas do teclado e chegue a V com A: ");
                tecla=Console.ReadKey();
                x = l;
                y = c;
            switch (tecla.Key.ToString())
            {
                case "UpArrow":
                    x-=1;
                    break;
                case "DownArrow":
                    x += 1;
                    break;
                case "RightArrow":
                    y += 1;
                    break;
                case "LeftArrow":
                    y -= 1;
                    break;
            }

                if ((x >= 0 && x <= 6) && (y >= 0 && y <= 8))
                {
                    if ((x <= (l + 1) && x >= (l - 1)) && (y <= (c + 1) && y >= (c - 1)))
                    {
                        l = x;
                        c = y;
                        if (x == 0 || y == 0 || x == 6 || y == 8)
                        {
                            Console.Write("bateu na barreira");
                            break;
                        }
                        else
                        {
                            if ((x == 1 && y == 3) || (x == 3 && y == 1) || (x == 3 && y == 3) || (y == 6 && (x == 2 || x == 3)) || (x == 5 && y == 5))
                            {
                                Console.Write("bateu na barreira");
                                break;
                            }
                            else
                            {
                                exibeCeu(x, y);
                                if (x == 1 && y == 7)
                                {
                                    Console.Write("voce ganhou");
                                    p = 1;
                                }
                                else
                                {
                                    Console.Write("Continue\n");
                                }

                            }
                        }
                    }
                    else
                    {
                        if (x == 0 || y == 0 || x == 6 || y == 8)
                        {
                            Console.Write("bateu na barreira");
                            break;
                        }
                        else
                        {
                            Console.Write("uma casa por vez apenas\n");
                        }

                    }
                }
                else
                {
                    Console.Write("posicao invalida\n");
                }
            } while (p == 0);

        void exibeCeu(int x, int y)
        {
            Console.Clear();
            int i, j;
            for (i = 0; i < 7; i++)
            {
                for (j = 0; j < 9; j++)
                {
                    if (i == 0 || j == 0 || i == 6 || j == 8)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        if ((i == 1 && j == 3) || (i == 3 && j == 1) || (i == 3 && j == 3) || (j == 6 && (i == 2 || i == 3)) || (i == 5 && j == 5))
                        {
                            Console.Write("* ");
                        }
                        else
                        {
                            if (i == x && j == y)
                            {
                                Console.Write("A ");
                            }
                            else if (i == 1 && j == 7)
                            {
                                Console.Write("V ");
                            }
                            else
                            {
                                Console.Write("- ");
                            }
                        }
                    }
                }
                Console.Write("\n");
            }
        }
    }
}