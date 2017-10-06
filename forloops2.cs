using System;

class Numbers
{
  static void Main()
  {

    Console.WriteLine("Enter a Number:");
    string numberInput = Console.ReadLine();
    int intNumberInput = int.Parse(numberInput);

    for (int index = 0; index < intNumberInput; index++);
    if (intNumberInput % 2 != 0) {
      Console.WriteLine("odd");
    } else {
      Console.WriteLine("even");
    }

  }
}

// using System;

// class GroceryList
// {
//   static void Main()
//   {
//     string[] myGroceryList = { "eggs", "milk", "bread", "bananas", "cereal", "rice" };
//
//     Console.WriteLine("My grocery list:");
//     for (int index = 0; index < myGroceryList.Length; index++)
//     {
//       Console.WriteLine(myGroceryList[index]);
//     }
//   }
// }
