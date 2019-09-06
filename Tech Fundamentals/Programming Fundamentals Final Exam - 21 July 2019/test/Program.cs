using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Song_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            var regex = new Regex(@"(?<artist>[A-Z]{1}[a-z]+([' ]+[a-z]+)*):(?<song>[A-Z ]+)");

            while ((input = Console.ReadLine()) != "end")
            {
                var matchedArtists = regex.Matches(input);
                var allArtists = regex.Matches(input);
                string finalArtistName = string.Empty;
                string finalSongName = string.Empty;
                string result = string.Empty;
                foreach (Match match in matchedArtists)
                {
                    string artistName = match.Groups["artist"].Value;
                    string song = match.Groups["song"].Value;
                    int key = artistName.Length;

                    for (int i = 0; i < artistName.Length; i++)
                    {
                        char symbol = artistName[i];
                        if (char.IsLower(symbol))
                        {
                            if ((int)symbol + key > (int)'z')
                            {
                                finalArtistName += (char)((int)symbol + key - 26);
                            }
                            else
                            {
                                finalArtistName += (char)(symbol + key);
                            }
                        }
                        else if (char.IsUpper(symbol))
                        {
                            if ((int)symbol + key > (int)'Z')
                            {
                                finalArtistName += (char)((int)symbol + key - 26);
                            }
                            else
                            {
                                finalArtistName += (char)(symbol + key);
                            }
                        }
                        else if (symbol == ' ' | symbol == '\'')
                        {
                            finalArtistName += symbol;
                        }
                    }
                    result += finalArtistName + '@';
                    for (int i = 0; i < song.Length; i++)
                    {
                        char symbol = song[i];
                        if (char.IsLower(symbol))
                        {
                            if ((int)symbol + key > (int)'z')
                            {
                                finalSongName += (char)((int)symbol + key - 26);
                            }
                            else
                            {
                                finalSongName += (char)(symbol + key);
                            }
                        }
                        else if (char.IsUpper(symbol))
                        {
                            if ((int)symbol + key > (int)'Z')
                            {
                                finalSongName += (char)((int)symbol + key - 26);
                            }
                            else
                            {
                                finalSongName += (char)(symbol + key);
                            }
                        }
                        else if (symbol == ' ' | symbol == '\'')
                        {
                            finalSongName += symbol;
                        }
                    }
                    result += finalSongName;

                }
                if (result.Length < input.Length)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                Console.WriteLine($"Successful encryption: {result}");
            }
        }
    }
}