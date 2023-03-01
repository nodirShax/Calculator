System.Console.Write("Enter first number: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter second number: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter operation (+,-,/,*) : ");
string operation = Console.ReadLine();

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

// switch (operation)
// {
//     case "+":
//         System.Console.WriteLine($"{firstNum} + {secondNum} = {firstNum + secondNum}");
//         break;
//     case "-":
//         System.Console.WriteLine($"{firstNum} - {secondNum} = {firstNum - secondNum}");
//         break;
//     case "*":
//         System.Console.WriteLine($"{firstNum} * {secondNum} = {firstNum * secondNum}");
//         break;
//     case "/":
//         System.Console.WriteLine($"{firstNum} / {secondNum} = {firstNum / secondNum}");
//         break;
//     default:
//         System.Console.WriteLine("Operation not found");
//         break;
// }
string result = operation switch
{
    "+" => $"{firstNum} + {secondNum} = {firstNum + secondNum}",
    "-" => $"{firstNum} - {secondNum} = {firstNum - secondNum}",
    "*" => $"{firstNum} * {secondNum} = {firstNum * secondNum}",
    "/" => $"{firstNum} / {secondNum} = {firstNum / secondNum}",
    _   => "Operation not found"
};

System.Console.WriteLine(result);

for (int i = 1; i <= 10; i++)
{
    for(int j = 1; j <=10; j++)
    {
        System.Console.WriteLine($"{i} * {j} = {i*j}");
    }
    System.Console.WriteLine();
}