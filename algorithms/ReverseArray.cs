using System;

class ReverseArray{
    static void Main(string[] args){
        int[] arr = {10,20,30,40,50};

        Console.WriteLine("Original array: " + string.Join(", ",arr));
        ReverseArrayInPlace(arr);
        Console.WriteLine("Reverse array: " +string.Join(", ", arr));
    }

    private static void ReverseArrayInPlace(int[] arr)
    {
      int left = 0;
      int right = arr.Length - 1;

      while(left < right) {
        int temp = arr[left];
        arr[left] = arr[right];
        arr[right] = temp;
        left++;
        right--;
      }
    }
}