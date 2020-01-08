using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class CuatroQuesosBuilder:PizzaBuilder //Se crea la clase CuatroQuesosBuilder que implementa la clase Pizza Builder
    {
        //Producto
        //Builder Concreto
        public CuatroQuesosBuilder(string tamaño) //Se define el tamaño de la pizza
        {
            Pizza = new Pizza  //Instanciar
            {
                Tamaño = tamaño
            };
        }
        //Pasos para preparar la pizza según se la requiera con el tipo de masa, tipo de salsa y tipo de relleno 
        //Se sobreescribe las operaciones para los componentes que está interesado en crear
        public override void PasoPrepararMasa()
        {
            Pizza.Masa = "Cocido";
        }

        public override void PasoAñadirSalsa()
        {
            Pizza.Salsa = "Roquefort";
        }

        public override void PasoPrepararRelleno()
        {
            Pizza.Relleno = "mozzarela+gorgonzola+parmesano+ricotta";
        }
    }
}
