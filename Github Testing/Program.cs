int score; 

Console.WriteLine("Please Enter your First Score: ");
score = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please Enter your Second Score: ");
score += Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please Enter your Third Score: ");
score += Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please Enter your Fourth Score: ");
score += Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please Enter your Fifth Score: ");
score += Convert.ToInt32(Console.ReadLine());

var total_score = score / 5;

Console.WriteLine("\n");

if (total_score >= 75)
{
    Console.WriteLine("You Passed!");
}

else
{
    Console.WriteLine("You Failed!");
}