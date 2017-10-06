using System;

class Friends
{
  static void Main()
  {
    string[] myFriendsList = {"kurt", "cathy", "michael"};


    Console.WriteLine("My friends list:");
    foreach (string friend in myFriendsList)
    {
      string upperString = friend.ToUpper();
      Console.WriteLine(upperString);
    }



  }
}

// using System;
//
// class GroceryList
// {
//   static void Main()
//   {
//     string[] myGroceryList = {"eggs", "milk", "bread"};
//     int[] groceryListPrices = {3,6,4};
//
//     Console.WriteLine("My grocery list:");
//     foreach (string groceryItem in myGroceryList)
//     {
//       Console.WriteLine(groceryItem);
//     }
//
//     int total = 0;
//     foreach (int price in groceryListPrices)
//     {
//       total = total + price;
//     }
//
//     Console.WriteLine("Your total for this shopping trip is $"+ total);
//   }
// }
