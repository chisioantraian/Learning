using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutshell.Others
{
    interface ICovariant<out R>
    {
        R GetSomething();
        //void SetSomething(R sampleArg);
        //void DoSomething<T>() where T : R;
    }

    interface IContravariant<in A>
    {
        void SetSomething(A sampleArg);
        void DoSomething<T>() where T : A;
        //A GetSomething();
    }

    class SampleImplementation<R> : ICovariant<R>
    {
        public R GetSomething()
        {
            throw new NotImplementedException();
        }
    }

    interface IVariant<out R, in A>
    {
        R GetSomething();
        void SetSomething(A sampleArg);
        R GetSomething(A sampleArg);
    }

    class Animal { }
    class Cat : Animal { }
    class Dog : Animal { }

    class Pets : IEnumerable<Cat>, IEnumerable<Dog>
    {
        public IEnumerator<Cat> GetEnumerator()
        {
            Console.WriteLine("cat");
            yield return new Cat();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
        {
            Console.WriteLine("dog");
            yield return new Dog();
        }
    }

    interface IGarage<in Z, out T1, out T2> { }



    class VarianceExample
    {
        public static void Run()
        {
            IEnumerable<Animal> an = new List<Cat>();
            //List<Animal> pts = new Pets();
            //IEnumerable<Animal> pets = new Pets();
            //pets.GetEnumerator();
            //FList(new List<Cat> {  });
            //Cat[] cats = new Cat[] { new Cat(), };
            //FArray(cats);
            //ContraList(new List<Cat>() { });
            //ContraArray(new Animal[] { });
        }

        private static void FList<T>(List<T> la) where T:Animal
        {
            Console.WriteLine(la);
            //la.Add(new Dog());
        }
        private static void FArray(Animal[] aa) { aa[0] = new Dog(); }

        private static void ContraList(List<Cat> cats)
        //private static void ContraList<T>(List<Cat> lt)
        {

        }

        private static void ContraArray(Cat[] cats)
        {
            //
        }
    }
}
