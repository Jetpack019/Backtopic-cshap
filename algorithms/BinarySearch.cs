class BinarySearch
{
    static void Main(string[] args){
        int[] arr = {2,4,6,8,10,12,14,16,18,20};
        int target = 12;
        int result = BinarySearchAlgorithm(arr,target);

        if(result == -1){
            System.Console.WriteLine("Element not found");
        }else{
            System.Console.WriteLine("Element found at index: " + result);
        }
    }

    private static int BinarySearchAlgorithm(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while(left <= right){
            int mid = left  + (right - left)  / 2;

            if(arr[mid] == target){
                return mid;
            }else if(arr[mid] < target){
                left = mid + 1;
            }else{
                right = mid - 1;
            }
        }
        return -1;
    }
}