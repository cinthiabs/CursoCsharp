﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] n = new int[3,5]; // criando array de 3 linhas e 5 colunas
            int[,] num = new int[2, 2] { { 10, 20 }, { 30, 40 } };

            n[0,0] = 10;
            n[0,1] = 20;
            n[0,2] = 30;
            n[0,3] = 40;
            n[0,4] = 50;

            n[1, 0] = 60;
            n[1, 1] = 70;
            n[1, 2] = 80;
            n[1, 3] = 90;
            n[1, 4] = 15;

            n[2, 0] = 25;
            n[2, 1] = 35;
            n[2, 2] = 45;
            n[2, 3] = 55;
            n[2, 4] = 65;

            Console.WriteLine(n[1, 3]);
            Console.WriteLine(n[2, 1]);
            Console.Read(); 

        }
    }
}
