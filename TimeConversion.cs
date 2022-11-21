// https://www.hackerrank.com/challenges/one-week-preparation-kit-time-conversion/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=preparation-kits&playlist_slugs%5B%5D=one-week-preparation-kit&playlist_slugs%5B%5D=one-week-day-one

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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        
        
        string[] str = s.Split(":");
        string hr = str[0];
        if(int.Parse(hr)==12){
            hr = s.Contains("AM")?"00":"12";
        }
        else if (s.Contains("PM")){
            hr = (Convert.ToInt32(hr) + 12).ToString();
        }
        return $"{hr}:{str[1]}:{str[2][0]}{str[2][1]}";
        
    
    }

    

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();

        // this is to show a change
    }
}


  git config --global user.email "amalatheresegeorge2022@ec.sjcetpalai.ac.in"
  git config --global user.name "amala_therese"