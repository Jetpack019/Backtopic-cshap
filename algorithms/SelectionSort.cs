class SelectionSort
{
    static void Main(string[] args){
        int[] arr = {64, 34, 25, 12, 22, 11, 90};
        SelectionSortAlgorithm(arr);
        System.Console.WriteLine("Sorted array: " + string.Join(", ",arr));

        
    }

    private static void SelectionSortAlgorithm(int[] arr)
    {
        int n = arr.Length;
        for (int i=0;i<n-1;i++){
            int minIndex = i;
            for(int j=i+1;j<n;j++){
                if(arr[j] < arr[minIndex]){
                    minIndex = j;
                }
            }
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }
}