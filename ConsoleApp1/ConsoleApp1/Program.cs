using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //DrawHLine(5,'a');
            // DrawVLine(5,'c');
            // DrawDLine(5, 'b');
            //DrawDLine2(5, 'c');
            // DrawTriangle(15, '*');
            DrawN(20, '*');
            //DrawTriangle2(5, '*');
            Console.ReadKey();
        }
        static void DrawHLine(int n, char c)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(c);
            }
        }
        static void DrawVLine(int n, char c)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Out.WriteLine(c);
            }
        }
        // first line : 0 space 1 star
        // second line : 1 space 1 star
        // third line : 2 space  1 star
        // forth line : 3 space 1 star
        // last line : n-1 space 1 star
        static void DrawDLine(int n, char c)
        {



            for (int i = 0; i < n; i++)
            {
                DrawHLine(i, ' ');
                DrawHLine(1, c);
                Console.WriteLine();
            }

        }
        //first line : n -1 space 1 star
        // second line: n-2 space 1 star
        // third line : n-3 space 1 star
        //forth line : n-4 space 1 star
        // last line : 0 space 1 star
        static void DrawDLine2(int n, char c)
        {
            for (int i = 0; i < n; i++)
            {
                DrawHLine(n - i, ' ');
                DrawHLine(1, c);
                Console.WriteLine();
            }
        }
        // first line: n -1 spaces 1 star
        // second line: n-2 spaces 1 star,1 space,1 star
        // third line : n-3 spaces,1 star, 1+2 space,1 star
        // forth line : n-4 spaces,1 star, 1+2+2 spaces,1 star
        // last line : 2n-1 stars
        static void DrawTriangle(int n, char c)
        {
            // first line: n -1 spaces 1 star
            DrawHLine(n - 1, ' '); DrawHLine(1, c); Console.WriteLine();
            int a = 2; int b = 1;
            for (int i = 0; i < n - 2; i++)
            {
                // second line: n-2 spaces 1 star,1 space,1 star
                // third line : n-3 spaces,1 star, 1+2 space,1 star
                // forth line : n-4 spaces,1 star, 1+2+2 spaces,1 star
                DrawHLine(n - a, ' '); DrawHLine(1, c);
                DrawHLine(b, ' '); DrawHLine(1, c); Console.WriteLine();
                a = a + 1; b = b + 2;
            }
            // last line : 2n-1 stars
            DrawHLine(2 * n - 1, c); Console.WriteLine();

        }
        //first line:1 star, n-2 space,1 star
        //second line:2 star,n-3 space,1 star
        //third line: 1 star,1 space,1 star,1 space,1 star
        //forth line:1 star, n-3 space,2 star
        //last line:1 star, n-2 space,1 star

        static void DrawN(int n, char c)
        {
            int a = 1; int b = 4;
            DrawHLine(1, c); DrawHLine(n - 2, ' '); DrawHLine(1, c); Console.WriteLine();
            DrawHLine(2, c); DrawHLine(n - 3, ' '); DrawHLine(1, c); Console.WriteLine();
            for (int i = 0; i < n - 4; i++)
            {


                DrawHLine(1, c); DrawHLine(a, ' '); DrawHLine(1, c); DrawHLine(n - b, ' '); DrawHLine(1, c); Console.WriteLine();
                a = a + 1; b = b + 1;
            }
            DrawHLine(1, c); DrawHLine(n - 3, ' '); DrawHLine(2, c); Console.WriteLine();
            DrawHLine(1, c); DrawHLine(n - 2, ' '); DrawHLine(1, c); Console.WriteLine();
        }
        //first line: 2n-1 star
        //second line:n-4 space,1star,1+2+2 space,1 star,
        //third line: n-3 space,1star,1+2 space,1star

        static void DrawTriangle2(int n, char c)
        {
            //first line: 2n-1 star
            DrawHLine(2 * n - 1, c); Console.WriteLine();
            int a = 4; int b = 5;
            for (int i = 0; i < n - 2; i++)
            {
                DrawHLine(n - a, ' '); DrawHLine(1, c);
                DrawHLine(b, ' '); DrawHLine(1, c); Console.WriteLine();
                a = a - 1; b = b - 2;

            }


            //last line n-3 space,1 star, n-3 space
            DrawHLine(n - 1, ' '); DrawHLine(1, c); DrawHLine(n - 3, ' ');
        }
    }
}

