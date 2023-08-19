class BubbleSort{
     static void Main(String[] args){
        int[] arr = {64,34,25,12,22,11,90};

        int n = arr.Length;
        for(int i = 0; i< n-1;i++){
             Console.WriteLine("i: " + string.Join(", ",n));
            for(int j = 0;j <n-i-1;j++){
                Console.WriteLine("j: " + string.Join(", ",j));
                if(arr[j] > arr[j+1]){
                    int temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                     Console.WriteLine("temp: " + string.Join(", ",arr[j+1]));
                }
            }
        }
      Console.WriteLine("Sorted array: " + string.Join(", ",arr));
    }
}