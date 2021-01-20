using System;
using System.Reflection.Emit;

namespace Mazzoni.Alex._4H.Poligono
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            bool flag=false;
            string strLato, strnLati;
            int nl;
            double ll;
            Poligono figura = new Poligono();
            do
            {
                Console.WriteLine("Inserisci il numero dei lati del poligono (da 3 a 20)");
                strnLati = Console.ReadLine();

                Console.WriteLine("Inserisci la lunghezza del lato");
                strLato = Console.ReadLine();

                nl = Convert.ToInt32(strnLati)
                ll = Convert.ToDouble(strnLati);
                figura = (nl, ll);
                figura.Perimetro(figura.n, figura.lato);
                flag = figura.Confronto(figura.n, figura.lato);
            } while (flag);
            */
            Console.WriteLine("Programma creato da Alex Mazzoni, 4H");
            Console.WriteLine("Inserisci il numero dei lati del poligono (da 3 a 20)");
            string strnLati = Console.ReadLine();

            Console.WriteLine("Inserisci la lunghezza del lato");
            string strLato = Console.ReadLine();
            
            Poligono figura = new Poligono(Convert.ToInt32(strnLati), Convert.ToDouble(strLato));
            figura.Perimetro(figura.n, figura.lato);
            figura.Confronto(figura.n, figura.lato);
            figura.Apotema(figura.n, figura.lato);
            figura.Area(figura.n, figura.lato);
            Console.WriteLine($"Perimetro del poligono = {figura.perimetro}");
            Console.WriteLine($"Apotema del poligono = {figura.apotema:n3}");
            Console.WriteLine($"Area del poligono = {figura.area:n3}");
        }
        class Poligono
        {
            public double lato;
            public int n;
            public double nF;
            public double apotema;
            public double area;
            public double perimetro;
            public bool flag;
            public Poligono()
            {

            }
            public Poligono(int nlati, double L_lato)
            {
                lato = L_lato;
                n = nlati;
            }
            public bool Confronto(int n, double lato)
            {
                if (n >= 3 || n <= 20)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Il poligono inserito è OK!");
                    Console.ForegroundColor = ConsoleColor.White;
                    return flag = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Il poligono inserito NON VA BENE!");
                    Console.ForegroundColor = ConsoleColor.White;
                    return flag = false;
                }
            }
            public void Perimetro(int n, double lato)
            {
                perimetro =n * lato;
            }
            public void Apotema(int n, double lato)
            {
                nF = 1/( 2*Math.Tan(Math.PI/n));
                apotema = nF * lato;
            }
            public void Area(double Apotema, double Perimetro)
            {
                area =(perimetro*apotema)/2;
            }
        }
    }
}
