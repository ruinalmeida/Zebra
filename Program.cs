using System;

namespace Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
			GetSolucao gs = new GetSolucao();
			gs.gime();

			string e1 = "yellow";
			string e2 = gs.Solucao[3];
			string e3 = "Kools";
			string e4 = "1";
			string e5 = gs.Solucao[11];
			string e6 = "Norwegian";

			string e7 = "blue";
			string e8 = "horse";
			string e9 = gs.Solucao[7];
			string e10 = "2";
			string e11 = gs.Solucao[12];
			string e12 = gs.Solucao[15];

			string e13 = gs.Solucao[0];
			string e14 = gs.Solucao[4];
			string e15 = gs.Solucao[8];
			string e16 = "3";
			string e17 = "Milk";
			string e18 = gs.Solucao[16];

			string e19 = gs.Solucao[1];
			string e20 = gs.Solucao[5];
			string e21 = gs.Solucao[9];
			string e22 = "4";
			string e23 = gs.Solucao[13];
			string e24 = gs.Solucao[17];

			string e25 = gs.Solucao[2];
			string e26 = gs.Solucao[6];
			string e27 = gs.Solucao[10];
			string e28 = "5";
			string e29 = gs.Solucao[14];
			string e30 = gs.Solucao[18];

			
			Console.WriteLine("House 1");
			Console.WriteLine(e1);
			Console.WriteLine(e2);
			Console.WriteLine(e3);
			Console.WriteLine(e5);
			Console.WriteLine(e6);
			Console.WriteLine();
			Console.WriteLine("House 2");
			Console.WriteLine(e7);
			Console.WriteLine(e8);
			Console.WriteLine(e9);
			Console.WriteLine(e11);
			Console.WriteLine(e12);
			Console.WriteLine();
			Console.WriteLine("House 3");
			Console.WriteLine(e13);
			Console.WriteLine(e14);
			Console.WriteLine(e15);
			Console.WriteLine(e17);
			Console.WriteLine(e18);
			Console.WriteLine();
			Console.WriteLine("House 4");
			Console.WriteLine(e19);
			Console.WriteLine(e20);
			Console.WriteLine(e21);
			Console.WriteLine(e23);
			Console.WriteLine(e24);
			Console.WriteLine();
			Console.WriteLine("House 5");
			Console.WriteLine(e25);
			Console.WriteLine(e26);
			Console.WriteLine(e27);
			Console.WriteLine(e29);
			Console.WriteLine(e30);
		}
    }
}
