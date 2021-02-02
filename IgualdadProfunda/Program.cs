using System;

namespace IgualdadProfunda
{
    class Program
    {
        //Escribe una función igualdadProfunda que toma dos valores
        //y retorne true solo si tienen el mismo valor o son objetos con las mismas propiedades,
        //donde los valores de las propiedades sean iguales cuando comparadas con una llamada recursiva a igualdadProfunda.

        static void Main(string[] args)
        {
            
        }

        private static bool igualdadProfunda(object a, object b)
        {
            if (a == b) return true;

            if (a == null || b == null) return false;

            if (a.GetType() != typeof(object) || b.GetType() != typeof(object)) return false;

            Array keyA = Array.CreateInstance(typeof(object), a[]);
            Array keyB = Array.CreateInstance(typeof(object), b[]);

            foreach(var key in keyA)
            {
                if (keyB.SetValue(key)) ;
            }
        }
    }
}
