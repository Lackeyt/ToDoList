using System;

namespace ToDoList.Models
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to the To Do List");
      Program.AddViewLogic();
    }
    static void AddViewLogic()
    {
      Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");
      string addView = Console.ReadLine();
      if (addView == "Add" || addView == "add")
      {
        Console.WriteLine("Please enter the description for the new item.");
        string description = Console.ReadLine();
        Item newItem = new Item(description);
        Console.WriteLine($"{description} has been added to your list.");
        Program.AddViewLogic();
      }
      else if (addView == "View" || addView == "view")
      {
        Console.WriteLine("Your To Do List:");
        foreach(Item element in Item.GetAll())
        {
          Console.WriteLine($"{element.Description}");
        }
        Program.AddViewLogic();
      }
      else
      {
        Console.WriteLine("-invalid command-");
        Program.AddViewLogic();
      }
    }
  }
}