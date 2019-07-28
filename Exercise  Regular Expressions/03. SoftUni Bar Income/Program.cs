    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    namespace _03._SoftUni_Bar_Income
    {
        class Program
        {
            static void Main(string[] args)
            {
            double total = 0;
                var regex = @"^%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$";
                while (true)
                {
                    string data = Console.ReadLine();
                    if (data=="end of shift")
                    {
                        break;
                    }
                    Match match = Regex.Match(data, regex);
                    if (match.Success)
                    {
                        double price = int.Parse(match.Groups["count"].Value) * double.Parse(match.Groups["price"].Value);
                    total += price;
                        Console.WriteLine($"{ match.Groups["customer"].Value}: {match.Groups["product"].Value} - {price:f2}");
                    }
                }
            Console.WriteLine("Total income: {0:F2}",total);
            }
        }
    }
