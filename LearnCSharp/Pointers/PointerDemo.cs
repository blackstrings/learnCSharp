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
namespace Pointers
{
	/// <summary>
	/// In c# use ref instead of pointers. Read up on safe and unsafe for further undestanding.
	/// yes you can use pointers * but you'll have to know a little bit more to use them correctly.
	/// </summary>
	public class PointerDemo
	{
//		public static void Main(){
//			start();
//		}
		
		private static void start(){
			
			int num = 1;
			increment(ref num);
			Console.WriteLine(num);
		}
		
		private static void increment(ref int count){
			count++;
		}
	}
}

