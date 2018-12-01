using System;
using System.Collections.Generic;
using System.Text;

namespace KolokwiumOne
{
    class Prostokat : Ksztalt
    {
        private float f_boka;
        private float f_bokb;

        public Prostokat(string s_nazwa, float f_boka, float f_bokb) : base(s_nazwa)
        {
            this.f_boka = f_boka;
            this.f_bokb = f_bokb;
            this.s_nazwa = s_nazwa;
        }

        public Prostokat() { }

        public override void WyswietlInformacje() => Console.WriteLine($"Obiekt typu: Prostokąt o nazwie {this.s_nazwa} \nObwód tego prostokąta to: {obw}");

        public override void ObliczObwod()
        {
            if(f_boka!=0 && f_bokb != 0)
            {
                this.obw = (2 * f_bokb) +(2 * f_boka);
            }
        }
        public override void WprowadzDane()
        {
            Console.WriteLine("Podaj nazwę dla tego prostokąta");
                this.s_nazwa = Console.ReadLine();
            Console.WriteLine("Podaj bok A");
                if (!float.TryParse(Console.ReadLine(), out this.f_boka)) Console.WriteLine("To nie jest liczba!!!");
            Console.WriteLine("Podaj bok B");
                if (!float.TryParse(Console.ReadLine(), out this.f_bokb)) Console.WriteLine("To nie jest liczba!!!");
                if (f_bokb < 1 || f_boka < 1) { Console.WriteLine("Niestety boki prostokąta nie mogą być mniejsze niż 1 :( "); }
        }
        public string Nazwa { get => s_nazwa; }
        
        
    }
}
