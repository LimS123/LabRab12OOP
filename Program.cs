using System;
using static LabRab12.Reflector;

namespace LabRab12
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAssembly(typeof(String));
            Console.WriteLine("\n--------------Вывод конструкторов--------------------------------------------------------\n");
            var Constructorslist = GetConstructors(typeof(String));
            foreach (var value in Constructorslist)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("\n--------------Вывод public методов--------------------------------------------------------\n");
            var Methodslist = GetMethods(typeof(String));
            foreach (var method in Methodslist)
            {
                Console.WriteLine(method);
            }
            Console.WriteLine("\n--------------Вывод свойств--------------------------------------------------------\n");
            var Propertieslist = GetProperties(typeof(String));
            foreach (var property in Propertieslist)
            {
                Console.WriteLine(property);
            }
            Console.WriteLine("\n-------------Вывод Интерфейсов---------------------------------------------------------\n");
            var interfacelist = GetInterfaces(typeof(String));
            foreach (var face in interfacelist)
            {
                Console.WriteLine(face);
            }
            Console.WriteLine("\n-------------Вывод названий методов---------------------------------------------------------\n");
            GetMethodNames(typeof(String)); 
            Console.WriteLine("\n----------------------------------------------------------------------\n");
        }
    }
}