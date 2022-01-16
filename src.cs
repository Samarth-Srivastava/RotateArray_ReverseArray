using System;
using System.IO;
using System.Linq;

class MAIN  {
    public static void Main(string[] args) {
        MAIN m = new MAIN();
        
        string line = Console.ReadLine();
        string[] n_arr_str = line.Split(' ');
        
        int[] n_arr = Array.ConvertAll(n_arr_str, int.Parse);
        int n = n_arr[0];
        int[] A = n_arr.Skip(1).ToArray();

        int B = int.Parse(Console.ReadLine());

        if(B > n)
        B = B%n;

        if(B > 0){
            A = m.reverse(A, 0, n-1);
            A = m.reverse(A, 0, B-1);
            A = m.reverse(A, B, n-1);
        }

        for(int i = 0; i < n; i++){
            Console.Write(A[i] + " ");
        }
    }

    public int[] reverse(int[] arr, int s, int e){
        while(s < e){
            swap(ref arr[s], ref arr[e]);
            s++;
            e--;
        }
        return arr;
    }

    public void swap(ref int num1, ref int num2){
        num1 = num1 + num2;
        num2 = num1 - num2;
        num1 = num1 - num2;
    }
}
