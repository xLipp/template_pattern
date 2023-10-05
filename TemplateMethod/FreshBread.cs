using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    /// <summary>
    /// The AbstractClass which contains the template method.
    /// </summary>
    abstract class Bread
    {
        public abstract void MixIngredients();

        public abstract void Bake();

        public virtual void Slice()
        {
            Console.WriteLine("Нарезаем хлеб"); 
        }

        // The template method
        public void Make()
        {
            MixIngredients();
            Bake();
            Slice();
        }
    }

    class Bran : Bread
    {
        public override void MixIngredients()
        {
            Console.WriteLine("\nСобираем ингредиенты для приготовления хлеба с отрубями");
        }

        public override void Bake()
        {
            Console.WriteLine("Выпекаем хлеб с отрубями. (25 минут)");
        }
    }

    class Sourdough : Bread
    {
        public override void MixIngredients()
        {
            Console.WriteLine("\nСобираем ингредиенты для хлеба на закваске.");
        }

        public override void Bake()
        {
            Console.WriteLine("Выпекаем хлеб на закваске. (20 минут)");
        }
    }

    class WholeWheat : Bread
    {
        public override void MixIngredients()
        {
            Console.WriteLine("\nСобирем ингредиенты для цельнозернового хлеба.");
        }

        public override void Bake()
        {
            Console.WriteLine("Выпекаем цельнозерновой хлеб. (15 минут)");
        }
    }
}
