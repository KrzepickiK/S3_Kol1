using System;
using System.Collections.Generic;
using System.Text;

namespace KolokwiumOne
{
    class Kolo : Ksztalt
    {
        private float f_promien;

        public Kolo(){}
        public Kolo(string s_nazwa, float f_promien) : base(s_nazwa)
        {
            if (string.IsNullOrEmpty(s_nazwa))
            {
                throw new ArgumentException("Nie podano nazwy :( ", nameof(s_nazwa));
            }

            this.f_promien = f_promien;
        }

        public override void ObliczObwod() {
         if (f_promien > 0)
            {       
                this.obw = (float)(Math.PI * Math.Pow(f_promien, 2));
            }
        }

        public override void WprowadzDane()
        {
            Console.WriteLine("Podaj nazwę dla tego koła");
                this.s_nazwa = Console.ReadLine();
            Console.WriteLine("Podaj promień");
                if (!float.TryParse(Console.ReadLine(), out this.f_promien)) Console.WriteLine("To nie jest liczba!!!");
        }

        public override void WyswietlInformacje() => Console.WriteLine($"Obiekt typu: Koło o nazwie {this.s_nazwa} \nObwód tego kółka to: {obw}");
    }
}
