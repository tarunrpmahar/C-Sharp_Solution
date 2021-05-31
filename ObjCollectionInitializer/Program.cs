﻿using System;
using System.Collections.Generic;

namespace ObjCollectionInitializer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var team = new BaseballTeam
            {
                ["RF"] = "Mookie Betts",
                [4] = "Jose Altuve",
                ["CF"] = "Mike Trout"
            };

            Console.WriteLine(team["2B"]);
            Console.ReadLine();

        }

        public class BaseballTeam
        {
            private string[] players = new string[9];
            private readonly List<string> positionAbbreviations = new List<string>
            {
                "P", "C", "1B", "2B", "3B", "SS", "LF", "CF", "RF"
            };

            public string this[int position]
            {
                // Baseball positions are 1 - 9.
                get { return players[position - 1]; }
                set { players[position - 1] = value; }
            }
            public string this[string position]
            {
                get { return players[positionAbbreviations.IndexOf(position)]; }
                set { players[positionAbbreviations.IndexOf(position)] = value; }
            }
        }

    }
}
