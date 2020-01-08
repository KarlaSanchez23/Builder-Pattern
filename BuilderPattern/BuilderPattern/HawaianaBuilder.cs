using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class HawaianaBuilder:PizzaBuilder
    {
        //Producto
        //Builder Concreto
        
        public HawaianaBuilder(string tamaño) //Se define el tamaño de la pizza
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
            Pizza.Masa = "Suave";
        }

        public override void PasoAñadirSalsa()
        {
            Pizza.Salsa = "Dulce";
        }

        public override void PasoPrepararRelleno()
        {
            Pizza.Relleno = "piña+tomate+jamón";
        }
    }
}
