namespace Calculator.Classes
{
    class Employe
    {
        public int FirstNum { get; set; }
        public int SecondNum { get; set; }
        public Employe(int firstNum , int secondNum)
        {
            FirstNum = firstNum;
            SecondNum = secondNum;    
        } 

        public void ChekFirstNumAndPrintResult()
        {
            string massage = 
                (FirstNum >= 0)
                ? "First number is positive"
                : "First number in negative";
            System.Console.WriteLine(massage);
        }
        public void CompareNumbers()
        {
            if(FirstNum > SecondNum)
            {
                System.Console.WriteLine("1st number greater then 2nd number!");
            }
            else if(FirstNum == SecondNum)
            {
                System.Console.WriteLine("1st number is equal to 2nd number!");
            }
            else 
            {
                System.Console.WriteLine("1st number less then 2nd number!");
            }
        }

        public void DoOperation(string operation)
        {
            string result = operation switch
                {
                    "+" => $"{FirstNum} + {SecondNum} = {FirstNum + SecondNum}",
                    "-" => $"{FirstNum} - {SecondNum} = {FirstNum - SecondNum}",
                    "*" => $"{FirstNum} * {SecondNum} = {FirstNum * SecondNum}",
                    "/" => $"{FirstNum} / {SecondNum} = {FirstNum / SecondNum}",
                    _   => "Operation not found"
                };
            System.Console.WriteLine(result);
        }

        public void PrintTableKarra()
        {
            for (int i = 1; i <= 10; i++)
            {
                for(int j = 1; j <=10; j++)
                {
                    System.Console.WriteLine($"{i} * {j} = {i*j}");
                }
                System.Console.WriteLine();
            }
        }
    }
}