class FactorialRecursion
{
    static void Main(string[] args){
        int num = 5;
        int result = CalculateFactorial(num);
        System.Console.WriteLine("Factorial of " + num + " is: " + result);
    }

    private static int CalculateFactorial(int num)
    {
        if(num == 0 || num == 1){
            return 1;
        } else{
            return num * CalculateFactorial(num-1);
        }
    }
}