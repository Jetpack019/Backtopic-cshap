class LinearSearch
{
    static void Main(string[] args){
        int[] arr = {10,30,50,70,90,110};
        int target = 70;
        int result = LinearSearchAlgorithm(arr,target);

        if(result == -1){
            System.Console.WriteLine("Element not found");
        } else{
            System.Console.WriteLine("Element found at index: " + result);
        }
    }

    private static int LinearSearchAlgorithm(int[] arr, int target)
    {
        for (int i=0;i<arr.Length;i++){
            if(arr[i]==target){
                return i;
            }
        }
        return -1;
    }
}