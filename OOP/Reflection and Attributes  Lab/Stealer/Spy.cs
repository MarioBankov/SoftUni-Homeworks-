using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Linq;

namespace Stealer
{
    public class Spy
    {
        private  string @namespece = "Stealer.";
        public string StealFieldInfo(string nameOfTheClass,params string[] filds)
        {
           
            Type classType = Type.GetType(namespece+nameOfTheClass);

            FieldInfo[] classFields = classType.GetFields
               (BindingFlags.Static |
                BindingFlags.NonPublic | 
                BindingFlags.Public | 
                BindingFlags.Instance);

            StringBuilder sb = new StringBuilder();
            var parametersInfo = classType.GetConstructors().First().GetParameters();
            if (parametersInfo.Length==0)
            {

                var instance = Activator.CreateInstance(classType, null);
                sb.AppendLine($"Class under investigation: {nameOfTheClass}");
                foreach (var item in classFields.Where(x => filds.Contains(x.Name)))
                {
                    sb.AppendLine($"{item.Name} = {item.GetValue(instance)}");
                }
            }
            return sb.ToString().TrimEnd();
            
        }
        public string AnalyzeAcessModifiers(string className)
        {
            StringBuilder sb = new StringBuilder();

            Type classType = Type.GetType(@namespece + className);

            FieldInfo[] fieldInfos =classType.GetFields(
                BindingFlags.Static |
                BindingFlags.Public |
                BindingFlags.Instance);

            MethodInfo[] classPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
            MethodInfo[] classNonPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
            
            
            foreach (var field in fieldInfos)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }

            foreach (var method in classNonPublicMethods.Where(x => x.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} have to be public!");
            }
           
            foreach (var method in classPublicMethods.Where(x=>x.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} have to be private!");
            }
            return sb.ToString().TrimEnd();
        }
        [Author("pepi")]
        public string RevealPrivateMethods(string className)
        {
            StringBuilder sb = new StringBuilder();

            Type classType = Type.GetType(namespece + className);

            sb.AppendLine($"All Private Methods of Class: {className}").
                AppendLine($"Base Class: {classType.BaseType.Name}");
            var classPrivateMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (var method in classPrivateMethods)
            {
                sb.AppendLine(method.Name);
            }

            return sb.ToString().TrimEnd();
        }
        [Author("stef4o")]
        public string CollectGettersAndSetters(string className)
        {
            Type classType = Type.GetType(namespece + className);
            var allMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            StringBuilder sb = new StringBuilder();
            foreach (var method in allMethods.Where(x=>x.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} will return {method.ReturnType}");
            }
            foreach (var method in allMethods.Where(x => x.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
