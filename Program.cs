System.Console.Write("Enter first number: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter second number: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

string massage = 
    (firstNum >= 0)
    ? "First number is positive"
    : "First number in negative";
System.Console.WriteLine(massage);


if(firstNum > secondNum)
{
    System.Console.WriteLine("1st number greater then 2nd number!");
}
else if(firstNum == secondNum)
{
    System.Console.WriteLine("1st number is equal to 2nd number!");
}
else 
{
    System.Console.WriteLine("1st number less then 2nd number!");
}

