using SQA_Assignment2;

namespace MidTerm_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, radius;
            bool wantToContinue = false;

            Console.WriteLine("Select enter the radius of the circle.\n");
            radius = Convert.ToInt32(Console.ReadLine());

            enterInitalRadiusAgain:
            if (radius < 1)
            {
                Console.WriteLine("Please enter value greater than 0");
                goto enterInitalRadiusAgain;

            }
            Circle circle = new Circle(radius);

            do
            {
                Console.WriteLine("Select from below given options.\n");
                Console.WriteLine("1. Get circle Radius \n2. Change Circle Radius \n3. Get Circle Circumference \n4. Get Circle Area \n5. Exit  \n\n");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");


                // Switch Case to Select from given options
                switch (choice)
                {
                    case 1:

                        Console.WriteLine("\nThe radius of the circle is :", circle.GetRadius());
                        wantToContinue = true;
                        break;

                    case 2:

                        int newRadius;

                    enterRadiusAgain:
                        Console.WriteLine("Enter the new radius of the circle.\n");
                        newRadius = Convert.ToInt32(Console.ReadLine());

                        if (newRadius < 1)
                        {
                            Console.WriteLine("Radius cannot be less than 1!!! \n");
                            goto enterRadiusAgain;
                        }

                        circle.SetRadius(newRadius);
                        wantToContinue = true;
                        break;

                    case 3:

                        Console.WriteLine("\nThe circumference of the circle is :", circle.GetCircumference());
                        wantToContinue = true;
                        break;

                    case 4:

                        Console.WriteLine("\nThe Area of the circle is :", circle.GetArea());
                        wantToContinue = true;
                        break;

                    case 5:
                        Console.WriteLine("ThankYou for using Application, Have a Nice Day!!!!");
                        wantToContinue = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Choice!!!\n");
                        Console.WriteLine("Please select from given options.\n");
                        break;
                }
            }
            while (wantToContinue);
        }
    }
}