using System;
using System.Collections.Generic;
using System.Text;

namespace KolokwiumOne
{
    abstract class Ksztalt
    {
        public string s_nazwa;
        public float obw;
        
        protected Ksztalt(){}

        public abstract void WprowadzDane();
        public abstract void ObliczObwod();
        public abstract void WyswietlInformacje();

        public float Obw { get => obw; }
    }
}
