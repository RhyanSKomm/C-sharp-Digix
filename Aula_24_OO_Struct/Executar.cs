using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Aula_24_OO_Struct
{
        public struct Point
        {
            public int X {get; set; }
            public int Y {get; set; }

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
    
            public double Distancia(Point p)
            {
                return Math.Sqrt(Math.Pow(X - p.X, 2)) + Math.Pow(Y - p.Y, 2);
            }
        }

        public class Player
        {
            public string Name {get; set;}
            public Point Position {get; set;}

            public Player(string name, Point position)
            {
                Name = name;
                Position = position;
            }

            public void Move(Point newposition)
            {
                Position = newposition;
            }
        }

        public class Executar
        {
            static void Maian(string[] args)
            {
                Point p1 = new Point(10, 20);
                Point p2 = new Point(20, 30);

                System.Console.WriteLine($"Distancia entre p1 e p2: {p1.Distancia(p2)}");

                Player player = new Player("Jogador 1", p1);
                System.Console.WriteLine($"Posição do jogador: {player.Position.X}");
            }
        }
}