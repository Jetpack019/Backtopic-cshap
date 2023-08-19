class FibonacciRecursion
{
    static void Main(string[] args){
        int n = 10;
        System.Console.WriteLine("Fibonacci Series up to " + n + " terms:");
        for(int i = 0; i < n; i++){
            System.Console.Write(CalculateFibonacci(i) + " ");
        }
    }

    private static int CalculateFibonacci(int n)
    {
        if(n <= 1){
            return n;
        } else{
            return CalculateFibonacci(n - 1) + CalculateFibonacci(n-2);
        }

    }
}