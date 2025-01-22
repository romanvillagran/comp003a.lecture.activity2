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



            // step 3.2: perform calculations
            int futureAge = userAge + 5;// calculate the user's age in 5 years
            bool isAdult = userAge >= 18;// determine is the user is 18 or older
            bool isAdultStudent = isStudent && isAdult;// determine if the user is both a student and an adult


            //step 3.3: 
            Console.WriteLine($"\nHello, {username}!");
            Console.WriteLine($"You are currently {userAge} years old. In 5 years, you will be {futureAge}.");
            Console.WriteLine($"Are you 18 or older? {isAdult}");
            Console.WriteLine($"Are you both a student and 18 or older? {isAdultStudent}");

        }
    }
}
