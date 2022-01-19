using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class MAIN  {
    public static void Main(string[] args) {
        MAIN m = new MAIN();
        
        string line = Console.ReadLine();
        string[] n_arr_str = line.Split(' ');
        
        int N = Convert.ToInt32(n_arr_str[0]);
        
        List<int> A = new List<int>();
        for(int i = 0; i < N; i++){
            A.Add(Convert.ToInt32(n_arr_str[i+1]));
        }
        
        int B = int.Parse(Console.ReadLine());

        B = B%N;

        if(B > 0){
            A = m.reverse(A, 0, N-1);
            A = m.reverse(A, 0, B-1);
            A = m.reverse(A, B, N-1);
        }

        for(int i = 0; i < N; i++){
            Console.Write(A[i] + " ");
        }
    }

    public List<int> reverse(List<int> arr, int s, int e){
        while(s < e){
            int temp = -1;

            temp = arr[s];
            arr[s] = arr[e];
            arr[e] = temp;

            s++;
            e--;
        }
        return arr;
    }
}
