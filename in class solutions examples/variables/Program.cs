//Derek Smith
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {

        //create an string named firstName
        string firstName;

        //Assign a value to firstName (use tour name)
        firstName = "Derek";


        //Create an int named favoritNumber and assign your favorite number to it 
         int favoriteNumber = 13;

         double crazyNumber = 7.6767 * favoriteNumber;

         string lastName = "Smith";
         string fullName = firstName + lastName;

         //MAKE IT DYNAMIC
         Console.WriteLine("Please enter your first name: >>");
         firstName = Console.ReadLine();

         Console.WriteLine("Please enter your last name: >>");
         lastName = Console.ReadLine();

         Console.WriteLine("Please enter your favorite number: >>");
         string favoirteNumberAsString = Console.ReadLine();
         //favoriteNumber = Convert.ToInt32(Console.ReadLine());

         fullName = firstName + " " + lastName;
         crazyNumber = 7.6767 + favoriteNumber; 
         Console.WriteLine(fullName + " has the favorite number of " + favoriteNumber + " which equates to a crazyNumber of " + crazyNumber); 

           
            
        
         Console.ReadKey(); 





        }
 

    }



   

    
}
