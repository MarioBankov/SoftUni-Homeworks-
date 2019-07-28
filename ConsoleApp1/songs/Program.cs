using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace songs
{
   public class Song
    {
       public string name { get; set; }
       public  string typeList { get; set; }
       public string time { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song>list= new List<Song>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('_').ToArray();

                string type = input[0];
                string name  = input[1];
                string time = input[2];
                Song song = new Song
                {
                    name = name,
                    typeList = type,
                    time = time

                };
                list.Add(song);
            }
            string type1 = Console.ReadLine();
            if (type1=="all")
            {
                foreach (var item in list)
                {
                    Console.WriteLine(item.name);
                }
            }
            List<Song> newlist = list.Where(x => x.typeList == type1).ToList();

            for (int i = 0; i < newlist.Count; i++)
            {
                Console.WriteLine(newlist[i].name);
            }

        }
    }
}
