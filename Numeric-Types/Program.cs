/*1. Write a program to calculate the area of a rectangle 
and print the answer to the console. 
You should prompt the user for the dimensions. 
(What data types should the dimensions be?)*/
        
    //a. Add a print line to prompt the user for the length of the rectangle.
        Console.WriteLine("What is the length of your rectangle? ");

    //b. Define a variable to handle the user’s response.
        double length = Convert.ToDouble(Console.ReadLine());
        
    //c. Repeat the previous two steps to ask for and store the rectangle’s width.
        Console.WriteLine("What is the width of your rectangle? ");
        double width = Convert.ToDouble(Console.ReadLine());

    //d. Use the length and width values to calculate the rectangle’s area.
        double area = length * width;

    //e. Print a statement using concatenation to communicate to the user what the area of their rectangle is.
        Console.WriteLine("The area of the rectangle with a length of " + length + ", and a width of " + width + ", is " + area + ".");

    //f. Run the program to verify your code.



        /*More on Numeric Types:
            2. Write a program that asks a user for the number of miles 
            they have driven and the amount of gas they’ve consumed (in gallons), 
            and print their miles-per-gallon.*/

                //Miles Driven
                Console.WriteLine("How many miles did you drive on your trip? ");
                double miles = Convert.ToDouble(Console.ReadLine());

                //Gallons of Gas Used
                Console.WriteLine("How many gallons of gas did you use? ");
                double gallons = Convert.ToDouble(Console.ReadLine());

                //MPG
                double mpg = miles / gallons;

                //Results
                Console.WriteLine("The MPG for the trip was: " + mpg + ".");