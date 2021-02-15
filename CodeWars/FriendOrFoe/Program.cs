using System;
using System.Collections.Generic;
/// <summary>
/// Make a program that filters a list of strings and returns a list with only your friends name in it.
///If a name has exactly 4 letters in it, you can be sure that it has to be a friend of yours!
///Otherwise, you can be sure he's not...
/// </summary>

namespace FriendOrFoe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
            FriendOrFoe(names);
            static IEnumerable<string> FriendOrFoe(string[] names)
            {
                List<string> friends = new List<string>();
                foreach (string item in names)
                {
                    if (item.Length == 4)
                    {
                        friends.Add(item);
                    }
                }
                return friends;
            }
        }
    }
}
