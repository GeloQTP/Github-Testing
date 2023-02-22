int score;
string suffix = "" ;

Console.WriteLine("Please Enter your 1st Score: ");
score = Convert.ToInt32(Console.ReadLine());

for (int i=2; i<=5; i++)
{

    if (i==2)
    {
        suffix = "nd";
    }

    else if (i==3) 
    {
        suffix = "rd" ;
    }

    else if (i >= 4)
    {
        suffix = "th";
    }

    Console.WriteLine("Please Enter your " + i + suffix + " Score:");
    score += Convert.ToInt32(Console.ReadLine());
}

var total_score = score / 5;

Console.WriteLine("\n");
Console.WriteLine("Finished Recording!\nPress any key to see the result");
Console.ReadKey();
Console.WriteLine("\n");

if (total_score >= 75)
{
    Console.WriteLine("You Passed!");
}

else
{
    Console.WriteLine("You Failed!");
}