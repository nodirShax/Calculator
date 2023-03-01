using Calculator.Classes;

System.Console.Write("Enter first number: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter second number: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter operation (+,-,/,*) : ");
string operation = Console.ReadLine();

Employe employe = new Employe(firstNum,secondNum);

employe.ChekFirstNumAndPrintResult();
employe.CompareNumbers();
employe.DoOperation(operation);
employe.PrintTableKarra();
