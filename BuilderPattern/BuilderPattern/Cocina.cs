using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    // Director
    public class Cocina
    {
        private PizzaBuilder _pizzaBuilder;

        public Pizza CocinarPizza(PizzaBuilder pizzaBuilder) //se le incrementa el constructor
        {
            RecepcionarProximaPizza(pizzaBuilder); //Métodos a desarrollar paso a paso
            CocinarPizzaPasoAPaso();//Métodos a desarrollar paso a paso
            return PizzaPreparada; //retornar
        }

        public void RecepcionarProximaPizza(PizzaBuilder pizzaBuilder)//Metodo que permite al usuario recepcionar la pizza que desea, 
            //implementando la clase PizzaBuilder que es el constructor.
        {
            _pizzaBuilder = pizzaBuilder;
        }

        public void CocinarPizzaPasoAPaso() //Metodo de pasos para cocinar la pizza
        {
            _pizzaBuilder.PasoPrepararMasa(); //el constructor más la propiedad de preparar la masa
            _pizzaBuilder.PasoAñadirSalsa();  //el constructor más la propiedad de preparar añadir la salsa
            _pizzaBuilder.PasoPrepararRelleno();  //el constructor más la propiedad de preparar el relleno
        }

        public Pizza PizzaPreparada //Se implementa la clase pizza(producto final) en el metodo de la pizza ya preparada
        {
            get { return _pizzaBuilder.ObtenerPizza(); } //retorna el resultado de la pizza

        }

    }
}

