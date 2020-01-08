using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // modelo tradicional
            var pizzaCuatroQuesosTradicional = new Pizza( //instancia la clase Pizza
                tamaño: "Familiar",
                masa: "Cocido",
                salsa: "Roquefort",
                relleno: "mozzarela+gorgonzola+parmesano+ricotta");


            // con builder (constructor)
            var cocina = new Cocina(); //instancia la clase cocina

            //Instancia la clase de pizza que desea y llama al método de recepción de pizza
            cocina.RecepcionarProximaPizza(new CuatroQuesosBuilder("Familiar")); 

            cocina.CocinarPizzaPasoAPaso();//de la clase cocina se llama al método de cicnar la pizza paso a paso
            var pizzaCuatroQuesos = cocina.PizzaPreparada; //retorna

            //Así mismo se realiza con la otra clase de pizza
            var pizzaHawuaianaTradicional = new Pizza(
                tamaño: "Mediana",
                masa: "Sueva",
                salsa: "Dulce",
                relleno: "piña+tomate+jamón");

            //Instancia la clase de pizza que desea y llama al método de recepción de pizza
            cocina.RecepcionarProximaPizza(new HawaianaBuilder("Mediana")); 

            cocina.CocinarPizzaPasoAPaso(); //de la clase cocina se llama al método de cicnar la pizza paso a paso

            var pizzaHawuaiana = cocina.PizzaPreparada;


        }
    }
}
