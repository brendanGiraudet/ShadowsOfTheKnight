using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Player
{
    static void Main(string[] args)
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int W = int.Parse(inputs[0]); // width of the building.
        int H = int.Parse(inputs[1]); // height of the building.
        int N = int.Parse(Console.ReadLine()); // maximum number of turns before game over.
        inputs = Console.ReadLine().Split(' ');
        int X0 = int.Parse(inputs[0]);
        int Y0 = int.Parse(inputs[1]);
        int down = H;
        int up = 0;
        int right = W;
        int left = 0;

        // game loop
        while (true)
        {
            var bombDir = Console.ReadLine();
            Console.Error.WriteLine("up:" + up);
            Console.Error.WriteLine("down:" + down);
            Console.Error.WriteLine("left:" + left);
            Console.Error.WriteLine("right:" + right);
            Console.Error.WriteLine("y:" + Y0);
            Console.Error.WriteLine(bombDir);
            
             // the direction of the bombs from batman's current location (U, UR, R, DR, D, DL, L or UL)
           if(bombDir.Contains("U"))
           {
               down = Y0;
               Y0 -= (int) Math.Round((decimal)(down - up)/2, MidpointRounding.AwayFromZero);
           }
           if(bombDir.Contains("D"))
           {
               up = Y0;
               Y0 += (int) Math.Round((decimal)(down - up)/2, MidpointRounding.AwayFromZero);
           }
           if(bombDir.Contains("R"))
           {
               left = X0;
               X0 += (int) Math.Round((decimal)(right - left)/2, MidpointRounding.AwayFromZero);
           }
           if(bombDir.Contains("L"))
           {
               right = X0;
               X0 -= (int) Math.Round((decimal)(right - left)/2, MidpointRounding.AwayFromZero);
           }

            // the location of the next window Batman should jump to.
            Console.WriteLine(X0 + " " + Y0);
        }
    }
}
