 using System;
  class Program
  {
      static void Main()
      {
        int runningTotal = 0;
        bool keepGoing = true;
       //Prompts the user
       
        while(keepGoing){
        System.Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");
        
        //Reads the users input
        string entry = Console.ReadLine();
          
          if(entry == "quit"){
            
            keepGoing = false;
            
              } 
               else {
        
        int minutes = int.Parse(entry);
        
        //Add minutes exercised to total
        runningTotal += minutes; 
        
        //Display total minutes exercised to the screen
        Console.Write("You have entered: "+ runningTotal + " minutes" + "\n");   
               
          }
          //Console.WriteLine("Your FINAL DATA: " + runningTotal + " minutes" );
          //Console.WriteLine("Goodbye!");
          
        }
       
       Console.WriteLine("Your FINAL DATA: " + runningTotal + " minutes" );
       Console.WriteLine("Goodbye!");
        
      }
   }