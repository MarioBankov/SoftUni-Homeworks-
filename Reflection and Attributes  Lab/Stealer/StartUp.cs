using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
  
    [Author("pepi")]
    public class StartUp
    {
       public  static void Main(string[] args)
        {
            Spy spy = new Spy();
            var result = spy.CollectGettersAndSetters("Hacker");
            Console.WriteLine(result);
            Tracker t = new Tracker();
            t.PrintMethodsByAuthor();
        }
    }
}
