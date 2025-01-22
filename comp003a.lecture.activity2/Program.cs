// Author:Roman 
//Course:Comp-003a
//Faculty: Jonathan 
//Purpose:Lecture activity
namespace comp003a.lecture.activity2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //these declare and initialice variables
            string username;// Variable to store the user's name 
            int userAge;//Variable to stor the user's age
            double productPrice;// Variable to store the product price
            bool isStudent;// Variable to store if the user is a student (true/false)


            //prompt the user to enter their name
            Console.Write("Enter your name");
            username = Console.ReadLine();// reads and assig the user's input to userName


            //prompt the user to enter their age
            Console.Write("Enter your age: ");
            userAge = int.Parse(Console.ReadLine());// convert and assign the user's input to userAge

            // prompt the user to enter the product price
            Console.Write("Enter the price of a product");
            productPrice = double.Parse(Console.ReadLine());// convert and assign the user's input to product price

            // Prompt the user to indicate if they are a student
            Console.Write(" Are you a student? (true/false)");
            isStudent = bool.Parse(Console.ReadLine());// convert and assign the user's input to isStudent
            


        }
    }
}
