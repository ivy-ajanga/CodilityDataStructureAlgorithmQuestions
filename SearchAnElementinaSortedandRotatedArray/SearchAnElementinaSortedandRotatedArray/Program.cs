using System;

namespace SearchAnElementinaSortedandRotatedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 4, 5, 6, 7, 8, 9, 1, 2, 3 };//2
            int key = 6;
            Console.WriteLine(BinarySearch(A,0,A.Length-1,key));
        }
        public static int BinarySearch(int[]A, int low, int high, int key)
        {
            /*
                 1)Find middle point mid = (l + h)/2
                 2) If key is present at middle point, return mid.
                 3) Else If arr[l..mid] is sorted
                     a) If key to be searched lies in range from arr[l]
                        to arr[mid], recur for arr[l..mid].
                     b) Else recur for arr[mid+1..h]
                 4) Else (arr[mid+1..h] must be sorted)
                     a) If key to be searched lies in range from arr[mid+1]
                        to arr[h], recur for arr[mid+1..h].
                     b) Else recur for arr[l..mid] 
             */
            int mid = (low + high) / 2;
            if (key == A[mid]) return mid;
            if (low > high) return -1;
            if(A[low]<=A[mid])
            {
                if(key>=A[low] && key <=A[mid])
                
                    return BinarySearch(A, low, mid-1, key);
                
            
                    return BinarySearch(A, mid+1,high, key);
                
            }
             if (key >= A[mid] && key <= A[high])
          
                   return BinarySearch(A, mid + 1, high, key);
                
                   return BinarySearch(A, low, mid-1, key);
                
            
                
        }
    }
}
