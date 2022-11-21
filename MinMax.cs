// https://www.hackerrank.com/challenges/one-week-preparation-kit-mini-max-sum/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=preparation-kits&playlist_slugs%5B%5D=one-week-preparation-kit&playlist_slugs%5B%5D=one-week-day-one

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

        public static void miniMaxSum(List<int> arr)
        {
            
            long   sum=arr.Sum();
            long  max=0;
            long   min=1000000000;
            long  temp = 0;
            
            for( long  i=0;i<5;i++){
                
                for( long  j=i+1;j<5;j++){
                    temp = arr[j];
                    arr[j]= arr[i];
                    arr[i]=temp;
                };
            };
            
            foreach(var item in arr){
                if((sum-item)>max){
                    max = sum-item;
                };
                if((sum-item)<min){
                    min = sum-item;
                    
                };
            };
            Console.WriteLine($"{min} {max}");        

        }

    }

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
