using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    //PRODUCTO FINAL
    //Se crean los atributos de la clase Pizza
        public class Pizza
        {
         
            public string Masa { get; set; }
            public string Salsa { get; set; }
            public string Relleno { get; set; }
            public string Tamaño { get; set; }

            //Se crea un constructor 
            public Pizza()
            {

            }
            
            public Pizza(string tamaño, string masa, string salsa, string relleno) : this() //Constructor que indica que se puede
            //trabajar con estos atributos en otras clases
            {
                Tamaño = tamaño;
                Masa = masa;
                Salsa = salsa;
                Relleno = relleno;
            }
        }
    }

