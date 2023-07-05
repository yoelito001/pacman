namespace PacMan
{
using System;
using System.Threading;


    class Program
    {
        
    public static string? mapa;
        static void Main(string[] args)
        {
            


            Console.WriteLine(@"


           █████    █████    ███████         ███    ███  █████  ███    ██
          ██   ██  ██   ██  ██               ████  ████ ██   ██ ████   ██
          ██████   ███████  ██        █████  ██ ████ ██ ███████ ██ ██  ██
          ██       ██   ██  ██               ██  ██  ██ ██   ██ ██  ██ ██
          ██       ██   ██   ██████          ██      ██ ██   ██ ██   ████


                             
                                    :-=+*####**+=:.                 
                                  :+#@@@@@@@@@@@@@@@@#+-.             
                               .+%@@@@@@@@@@@@@@@@@@@@@@@*:           
                             :*@@@@@@@@@@@@@@@@@@@@@@@@@@@@#-         
                           .*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#:       
                          -%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@+      
                         +@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@+     
                        *@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#-      
                       +@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#-        
                      -@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*:          
                     .%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@+.            
                     +@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@+.              
                     %@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%=.        :===:   
                    -@@@@@@@@@@@@@@@@@@@@@@@@@@@@%=.        .#@@@@@#: 
                    =@@@@@@@@@@@@@@@@@@@@@@@@@@#-          .%@@@@@@@@.
                    +@@@@@@@@@@@@@@@@@@@@@@@@#-            -@@@@@@@@@=
                    *@@@@@@@@@@@@@@@@@@@@@@@@=.            :@@@@@@@@@-
                    +@@@@@@@@@@@@@@@@@@@@@@@@@@*:           =@@@@@@@+ 
                    -@@@@@@@@@@@@@@@@@@@@@@@@@@@@#-          :+#%#*:  
                    .@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%=.                
                    *@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@+:              
                    :@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#-            
                     +@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%=.         
                      .#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%+.       
                       .%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*:     
                        .#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%:    
                         .*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#.     
                          -%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=       
                           .=%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*.        
                              =%@@@@@@@@@@@@@@@@@@@@@@@@%+.          
                                :+#@@@@@@@@@@@@@@@@@@%+-             
                                   .-=*#%@@@@@@%#*+-.                
                                          :==:       ");



            Console.WriteLine("Presione Enter para continuar");
            Console.ReadLine();

          pac();

        }
        public static void pac()
        {
          int posX = 0; // Posición inicial en el eje X
        int posY = 0; // Posición inicial en el eje Y

        Console.CursorVisible = false;
        Console.Clear();
        ConsoleKeyInfo keyInfo;
        bool exit = false;
        string[] mapa = {
            "+-----+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+---+",
            "|        |        |                                            |",
            "+  +--+  +  +--+--+  +--+--+--+--+--+--+--+--+--+  +--+--+--+  +",
            "|     |     |        |     |     |              |     |        |",
            "+--+  +  +--+  +--+--+  +  +  +  +  +--+--+--+  +--+  +  +--+--+",
            "|     |  |     |        |     |  |        |  |  |     |     |  |",
            "+  +--+  +  +--+  +--+--+--+--+--+--+  +--+--+  +--+--+--+  +--+",
            "|  |     |  |  |  |              |  |  |     |        |  |     |",
            "+  +--+--+  +--+  +  +--+--+--+  +  +  +  +  +--+  +  +--+--+  +",
            "|        |  |     |     |     |  |  |     |     |  |           |",
            "+  +--+  +  +  +--+--+  +--+  +  +--+--+--+--+  +  +--+--+--+--",
            "|  |     |  |        |     |  |              |  |           |  |",
            "+  +  +--+--+--+--+--+  +  +--+--+--+--+  +  +--+  +--+  +--+--",
            "|  |  |                    |              |  |     |  |  |     |",
            "+  +  +  +--+--+--+--+--+--+--+  +--+--+  +- +--+  +  +  +--+  +",
            "|  |        |     |                    |  |     |  |     |     |",
            "+--+--+--+  +  +  +  +--+  +--+--+  +--+--+  +  +  +--+  +  +--+",
            "|     |     |  |  |     |        |  |        |  |  |  |  |     |",
            "+  +--+  +--+  +  +--+  +  +--+--+--+  +--+--+--+  +  +  +--+  +",
            "|  |  |        |     |  |     |     |           |  |     |  |  |",
            "+  +  +  +--+--+--+--+  +--+  +  +--+--+--+  +  +--+--+--+  +--+",
            "|  |                       |  |     |  |  |     |        |  |  |",
            "+  +  +--+--+--+--+--+--+--+--+--+  +--+--+  +--+--+--+  +--+  +",
            "|  |        |     |  |        |  |  |  |              |  |     |",
            "+--+--+--+  +  +  +  +  +--+  +--+  +--+  +--+  +--+--+  +  +--+",
            "|     |     |  |  |  |  |  |        |  |  |     |     |  |     |",
            "+  +--+  +--+  +  +  +  +--+--+--+--+--+  +--+  +  +  +--+--+",
            "|           |  |  |  |                 |  |  |     |  |        |",
            "+--+--+--+  +--+  +  +--+--+--+--+--+  +  +  +--+--+--+--+--+  +",
            "START ->          |                 |     |              | END ->",
            "+-----+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+"
        };

        // Imprimir el mapa
        foreach (string row in mapa)
        {
            Console.WriteLine(row);
        }

System.Console.WriteLine(mapa);         
        Console.ForegroundColor = ConsoleColor.Yellow;

        while (!exit)
        {

            Console.SetCursorPosition(posX, posY);
            System.Console.WriteLine("o");
            keyInfo = Console.ReadKey(true);
            DateTime UltimaEntrada = DateTime.MinValue; // Tiempo de la última entrada
            TimeSpan TiempoEntreEntras = TimeSpan.FromMilliseconds(150); // Tiempo de enfriamiento entre entradas (500 milisegundos)
            

            switch (keyInfo.Key)
            {
                case ConsoleKey.W:
                    Console.SetCursorPosition(posX, posY);
                    Console.Write("u");
                    Thread.Sleep(100);
                 Console.SetCursorPosition(posX, posY);
                 System.Console.WriteLine("  ");
                    posY--;
                    break;

                case ConsoleKey.S:
                    Console.SetCursorPosition(posX, posY);
                    Console.Write("n");
                    Thread.Sleep(100);
                Console.SetCursorPosition(posX, posY);
                 System.Console.WriteLine("  ");
                    posY++;
                    break;

                case ConsoleKey.A:
                    Console.SetCursorPosition(posX, posY);
                    Console.Write(">");
                    Thread.Sleep(100);
                Console.SetCursorPosition(posX, posY);
                 System.Console.WriteLine("  ");
                    posX--;
                    break;

                case ConsoleKey.D:
                    Console.SetCursorPosition(posX, posY);
                    Console.Write("c");
                    Thread.Sleep(100);
                Console.SetCursorPosition(posX, posY);
                 System.Console.WriteLine("  ");
                    posX++;
                    break;

                case ConsoleKey.Escape:
                Console.SetCursorPosition(posX, posY);
                 System.Console.WriteLine("  ");
                    exit = true;
                    break;
        
            }
        }
      }
    }
}

