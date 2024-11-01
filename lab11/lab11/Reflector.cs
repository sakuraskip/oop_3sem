using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace lab11
{
    public static class Reflector<T>
    {
        public const string filepath = "C:\\Users\\леха\\Desktop\\3sem\\лабы\\oop\\lab11\\lab11\\file.txt";
        public static string GetName(string classname)
        {
            Type type = classname.GetType();
            return type.Assembly.GetName().Name;
        }
        public static bool HasPublicConstructor(string classname)
        {
            Type type = classname.GetType();
            if(type.GetConstructors().Length >0)
            {
                return true;
            }
            return false;
        }
        public static IEnumerable<string> PublicMethods(string classname)
        {
            Type type = classname.GetType();
            var  methods = type.GetMethods(BindingFlags.Public);
            
            return methods.Select(m => m.Name);
        }
        public static IEnumerable<string> GetFieldsAndProperties(string classname)
        {
            Type type = classname.GetType();

            var fields = type.GetFields(BindingFlags.Public).Select(f=>f.Name);
            var properties = type.GetProperties(BindingFlags.Public).Select(p=>p.Name);

            return fields.Concat(properties);
        }
        public static IEnumerable<string> GetInterfaces(string classname)
        {
            Type type = classname.GetType();
            var interfaces = type.GetInterfaces().Select(i => i.Name);
            return interfaces;
        }
        public static IEnumerable<string> GetMethodsByType(string classname, Type parametertype)
        {
            Type type = classname.GetType();
            var methods = type.GetMethods();

            return methods.Where(m=>m.GetParameters().Any(p=>p.ParameterType == parametertype)).Select(m=>m.Name);
        }
        public static object Invoke(object obj,string classname,string methodname)
        {
            Type type = classname.GetType();
            var method = type.GetMethod(methodname);

            var parameters = method.GetParameters();
            var args = new object[parameters.Length];

            var fileLines = File.ReadAllLines("C:\\Users\\леха\\Desktop\\3sem\\лабы\\oop\\lab11\\lab11\\file.txt");

            for(int i=0;i<fileLines.Length;i++)
            {
                args[i] = Convert.ChangeType(fileLines[i], parameters[i].ParameterType);
            }
        }
    }
}
