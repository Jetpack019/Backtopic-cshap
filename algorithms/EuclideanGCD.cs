class EuclideanGCD
{
    static void Main(string[] args){
        int a = 40;
        int b = 10;
        int gcd = CalculateGCD(a,b);
        System.Console.WriteLine("GCD of " + a + " and " + b + " is: " + gcd);
        
    }

    private static int CalculateGCD(int a, int b)
    {
        if(b==0){
            return a;
        }else{
            return CalculateGCD(b,a%b);
        }
    }
}