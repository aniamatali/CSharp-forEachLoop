using System;
using System.Collections.Generic;

class Songs
{
  public static Dictionary<string, string> songBook = new Dictionary<string, string>();

  static void Main()
  {
    Console.WriteLine("Songs/Bands");
    Console.WriteLine("Enter a song");
    string song = Console.ReadLine();
    Console.WriteLine("Enter a band");
    string band = Console.ReadLine();

    songBook.Add(song, band);

    Console.WriteLine("The songs in your songbook are..." + songBook[song]);
    Main();

  }
}

// static void AddContact()
// {
//   Console.WriteLine("NEW CONTACT");
//   Console.WriteLine("Enter a new contacts name");
//   string name = Console.ReadLine();
//   Console.WriteLine("Enter a new contacts phone number");
//   string number = Console.ReadLine();
//   if (phoneNumbers.ContainsKey(name))
//   {
//     Console.WriteLine("That person is already in your phonebook. Their number is " + phoneNumbers[name]);
//   }
//   else
//   {
//     phoneNumbers.Add(name, number);
//   }
//   Main();
// }
