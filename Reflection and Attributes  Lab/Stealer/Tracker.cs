using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Tracker
    {
       public  void PrintMethodsByAuthor()
        {
          var methods= Assembly.GetExecutingAssembly()
                .GetTypes()
                .SelectMany(t => t.GetMethods())
                .Where(x=>x.IsDefined(typeof(AuthorAttribute)));

            foreach (var item in methods)
            {
                var name = item.Name;
                var attributeName = item.GetCustomAttribute<AuthorAttribute>().Name;

                Console.WriteLine("{0} is written by {1}",name,attributeName);
            }
        }
    }
}
