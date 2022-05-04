// Game1 Jared Browner-Botson
class Program
    {
        public static char playerSignature = ' ';

        static int turns = 0;

        static char[] ArrangeBoard = 
        {
            '1', '2', '3', '4', '5', '6', '7', '8', '9'
        };

        
        public static void BoardReset()
        {
            char[] SetBoard = 
            {
                '1', '2', '3', '4', '5', '6', '7', '8', '9'
            };

            ArrangeBoard = SetBoard;
            DrawBoard();
            turns = 0;
        }

        public static void DrawBoard()
        {
            Console.Clear();
            Console.WriteLine("{0}|{1}|{2}", ArrangeBoard[0], ArrangeBoard[1], ArrangeBoard[2]);
            Console.WriteLine("-+-+-");
            Console.WriteLine("{0}|{1}|{2}", ArrangeBoard[3], ArrangeBoard[4], ArrangeBoard[5]);
            Console.WriteLine("-+-+-");
            Console.WriteLine("{0}|{1}|{2}", ArrangeBoard[6], ArrangeBoard[7], ArrangeBoard[8]);
        }

        static void Main(string[] args)
        {
            int player = 2;
            int input = 0;
            bool inputCorrect = true;

            do
            {
                if (player == 2)
                {
                    player = 1;
                    XorO(player, input);
                }
                else if (player == 1)
                {
                    player = 2;
                    XorO(player, input);
                }

                DrawBoard();
                turns++;

                Horizontal();
                Vertical();
                Diagnal();

                if (turns == 10)
                {
                    Draw();
                }
                
                do
                {
                    Console.WriteLine("\nPlayer {0} turn", player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Press number (1-9)");
                    }

                    if ((input == 1) && (ArrangeBoard[0] == '1'))
                        inputCorrect = true;
                    else if ((input == 2) && (ArrangeBoard[1] == '2'))
                        inputCorrect = true;
                    else if ((input == 3) && (ArrangeBoard[2] == '3'))
                        inputCorrect = true;
                    else if ((input == 4) && (ArrangeBoard[3] == '4'))
                        inputCorrect = true;
                    else if ((input == 5) && (ArrangeBoard[4] == '5'))
                        inputCorrect = true;
                    else if ((input == 6) && (ArrangeBoard[5] == '6'))
                        inputCorrect = true;
                    else if ((input == 7) && (ArrangeBoard[6] == '7'))
                        inputCorrect = true;
                    else if ((input == 8) && (ArrangeBoard[7] == '8'))
                        inputCorrect = true;
                    else if ((input == 9) && (ArrangeBoard[8] == '9'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("Please press a number");
                        inputCorrect = false;
                    }

                } while (!inputCorrect);
            } while (true);
        }

        public static void XorO(int player, int input)
        {
            if (player == 1) playerSignature = 'O';
            else if (player == 2) playerSignature = 'X';

            switch (input)
            {
                case 1: ArrangeBoard[0] = playerSignature; break;
                case 2: ArrangeBoard[1] = playerSignature; break;
                case 3: ArrangeBoard[2] = playerSignature; break;
                case 4: ArrangeBoard[3] = playerSignature; break;
                case 5: ArrangeBoard[4] = playerSignature; break;
                case 6: ArrangeBoard[5] = playerSignature; break;
                case 7: ArrangeBoard[6] = playerSignature; break;
                case 8: ArrangeBoard[7] = playerSignature; break;
                case 9: ArrangeBoard[8] = playerSignature; break;
            }
        }

        public static void Horizontal()
        {
            char[] playerSignatures = { 'X', 'O' };

            foreach (char playerSignature in playerSignatures)
            {
                if (   ((ArrangeBoard[0] == playerSignature) && (ArrangeBoard[1] == playerSignature) && (ArrangeBoard[2] == playerSignature))
                    || ((ArrangeBoard[3] == playerSignature) && (ArrangeBoard[4] == playerSignature) && (ArrangeBoard[5] == playerSignature))
                    || ((ArrangeBoard[6] == playerSignature) && (ArrangeBoard[7] == playerSignature) && (ArrangeBoard[8] == playerSignature)))
                {
                    Console.Clear();
                    if (playerSignature == 'X')
                    {
                        Console.WriteLine("Player 1 wins");
                    }
                    else if (playerSignature == 'O')
                    {
                        Console.WriteLine("Plyer 2 wins");
                    }

                    Console.WriteLine("Press any key to restart game");
                    Console.ReadKey();
                    BoardReset();

                    break;
                }
            }
        }

        public static void Vertical()
        {
            char[] playerSignatures = { 'X', 'O' };

            foreach (char playerSignature in playerSignatures)
            {
                if (   ((ArrangeBoard[0] == playerSignature) && (ArrangeBoard[3] == playerSignature) && (ArrangeBoard[6] == playerSignature))
                    || ((ArrangeBoard[1] == playerSignature) && (ArrangeBoard[4] == playerSignature) && (ArrangeBoard[7] == playerSignature))
                    || ((ArrangeBoard[2] == playerSignature) && (ArrangeBoard[5] == playerSignature) && (ArrangeBoard[8] == playerSignature)))
                {
                    Console.Clear();
                    if (playerSignature == 'X')
                    {
                        Console.WriteLine("Player 1 wins");
                    }
                    else if (playerSignature == 'O')
                    {
                        Console.WriteLine("Plyer 2 wins");
                    }

                    Console.WriteLine("Press any key to restart game");
                    Console.ReadKey();
                    BoardReset();

                    break;
            
                }
            }

        }

            public static void Diagnal()
        {
            char[] playerSignatures = { 'X', 'O' };

            foreach (char playerSignature in playerSignatures)
            {
                if (   ((ArrangeBoard[0] == playerSignature) && (ArrangeBoard[4] == playerSignature) && (ArrangeBoard[8] == playerSignature))
                    || ((ArrangeBoard[6] == playerSignature) && (ArrangeBoard[4] == playerSignature) && (ArrangeBoard[2] == playerSignature)))
                    
                {
                    Console.Clear();
                    if (playerSignature == 'X')
                    {
                        Console.WriteLine("Player 1 wins");
                    }
                    else if (playerSignature == 'O')
                    {
                        Console.WriteLine("Plyer 2 wins");
                    }

                    Console.WriteLine("Press any key to restart game");
                    Console.ReadKey();
                    BoardReset();

                    break;
                }
            }
        }

        public static void Draw()
        {
            if (turns == 10)
            {
                Console.WriteLine("It's a draw" +
                                  "\nPlease press any key to restart");
                Console.ReadKey();
                BoardReset();
            }
        }
    }