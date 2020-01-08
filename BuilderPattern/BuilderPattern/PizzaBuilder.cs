using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    //Builder
    //La clase abstracta define una operación por cada componente que puede ser creado. 
    public abstract class PizzaBuilder
    {
        // Se utiliza Protected para que las clases que implementen puedan acceder
        protected Pizza Pizza;
        public string Tamaño { get; set; }//atributo

        public Pizza ObtenerPizza() { return Pizza; } //Se crea un método que es de Obtener la Pizza y donde retornará la clase Pizza


        
        // Un paso para cada una de las propiedades de las operaciones a realizar
        public virtual void PasoPrepararMasa()
        {

        }

        public virtual void PasoAñadirSalsa()
        {

        }

        public virtual void PasoPrepararRelleno()
        {

        }

        public virtual void PasoDoblarPizza()
        {

        }
    }
}
