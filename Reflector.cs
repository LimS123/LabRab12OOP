using System;
using System.Reflection;

namespace LabRab12
{
    public static class Reflector
    {
        public static void GetAssembly(Type className)
        {
            Console.WriteLine(className.Assembly);
        }
        public static ConstructorInfo[] GetConstructors(Type className)
        {
            return className.GetConstructors();
        }
        public static MethodInfo[] GetMethods(Type className)
        {
            return className.GetMethods();
        }
        public static PropertyInfo[] GetProperties(Type className)
        {
            return className.GetProperties();
        }
        public static Type[] GetInterfaces(Type className)
        {
            return className.GetInterfaces();
        }
        public static void GetMethodNames(Type className)
        {
            foreach (var method in className.GetMethods())
            {

                Console.WriteLine(method.Name);
            }
        }
    }
}