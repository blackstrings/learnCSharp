//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1026
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

/// <summary>
/// If you call an obj's method inside a loop, 
/// which the method does random, you'll get all the same number
/// </summary>
namespace Randomize
{
	public class RandomDemo
	{
        public static void Main(){ start(); }
		
		private static void start(){
			Random rand = new Random();
			
			//ex1
			int num = rand.Next(10,20);			//11-19
			int num2 = rand.Next(10,20);
			Console.WriteLine(num + " : " + num2);
			
			//ex2 - will generate new numbers
			int maxSize = 10;
			int min = 1;
			int max = 100;
			int[] arr = new int[maxSize];
			for(int i=0; i<maxSize; i++){
				arr[i] = rand.Next(min,max);
				Console.Write(arr[i] + ",");
			}
			Console.WriteLine();
			Console.WriteLine(arr.ToString());
			
			//ex3
			double d = rand.NextDouble()*2;		//0-2.0
			Console.WriteLine(d);
			
			float f = (float)rand.NextDouble()*5;
			Console.WriteLine(f);
			
			//ex4 - take existing array, push into list, and re-shuffle list
			List<int> ns = new List<int>(arr);
			Shuffle.shuffle(ns);
			for(int i=0; i<ns.Count; i++){
				Console.Write(ns[i] + ",");
			}
		}
		
		
	}
}

