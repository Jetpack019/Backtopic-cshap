using System;

class MergeSort{
    static void Main(string[] args){
        int[] arr = {12,11,13,5,6,7};
        MergeSortAlgorithm(arr,0,arr.Length - 1);
        Console.WriteLine("Sorted array: "+string.Join(", ",arr));
    }

    private static void MergeSortAlgorithm(int[] arr, int left, int right)
    {
        if(left < right){
            int mid = left + (right - left ) / 2;
            MergeSortAlgorithm(arr,left,mid);
            MergeSortAlgorithm(arr,mid+1,right);
            Merge(arr,left,mid,right);
        }
    }

    private static void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        for(int a=0;a<n1;a++){
            leftArray[a] = arr[left + a];
        }
        for(int b=0;b<n2;b++){
            rightArray[b] = arr[mid+1+b];
        }

        int k = left;
        int i = 0,j = 0;
        while(i<n1 && j<n2){
            if(leftArray[i] <= rightArray[j]){
                arr[k] = leftArray[i];
                i++;
            }else{
                arr[k] = rightArray[j];
                j++;
            }
            k++;
        }

        while(i<n1){
            arr[k] = leftArray[i];
            i++;
            k++;
        }
        while(j<n2){
            arr[k] = rightArray[j];
            j++;
            k++;
        }
    }
}