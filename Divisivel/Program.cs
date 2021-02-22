using System;

namespace Divisivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = Int32.Parse(Console.ReadLine());

            string tres = "";
            string sete = "";
            string seis = "";

            if (numero%3==0) {
                tres = "3";
            }
            if (numero%6==0) {
                seis = "6";
            }
            if (numero%7==0) {
                sete = "7";
            }

            Console.WriteLine(tres + "," + seis + "," + sete);
        }
    }
}
