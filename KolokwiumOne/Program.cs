using System;

namespace KolokwiumOne
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 0;
            int b = 0;

            Console.WriteLine("Podaj wartości x i y:");
                if (!int.TryParse(Console.ReadLine(), out int x)) Console.WriteLine("Podano nieprawidłowy iks! \nPodaj liczby całkowite.");
                if (!int.TryParse(Console.ReadLine(), out int y)) Console.WriteLine("Podano nieprawidłowy igrek! \nPodaj liczby całkowite.");

            if(x >= 1 && y >= 1)
            {
                Ksztalt[,] macierz = new Ksztalt[x,y]; 

                for(int i=0; i<x; i++)
                {
                    for(int j=0; j<y; j++)
                    {
                        if (j % 2 == 1) {
                            macierz[i, j] = new Kolo();}
                        else {
                            macierz[i, j] = new Prostokat();}

                        macierz[i, j].WprowadzDane();
                        macierz[i, j].ObliczObwod();

                        if (i > 0 && j > 0){if (macierz[i, j].Obw > macierz[i - 1, j - 1].Obw) { a = i; b = j; }}
                    }
                }


                //wyswietl wszystko
                for (int i = 0; i < x; i++)  { for (int j = 0; j < y; j++) macierz[i, j].WyswietlInformacje();}

                //najwiekszy obw
                Console.WriteLine("Najwiekszy obwód ma: ");
                macierz[a, b].WyswietlInformacje();
            }


            

        }
    }
}
