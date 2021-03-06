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
namespace Delegates
{
	public class DelegateDemo
	{
//		public static void Main(){ start(); }
		
		//delegate signature
		//any method that matches this delegate signature can be added to this delegate
		delegate void StartUp();
		
		public static void start () {
			//every new delegate must register at least one method for initiation
			StartUp su = new StartUp(method1);
			//to register more methods to the delegate
			su += method2;		//notice you don't add ()
			su += method3;
			//...
			
			//fire the delegate like this, will call all the registered methods
			su();
			
			Console.WriteLine();
			
			//unregister a method from delegate
			su -= method3;
			su -= method1;
			su();
		}
		
		private static void method1(){
			Console.Write("method1 fired,");
		}
		private static void method2(){
			Console.Write("method2 fired,");
		}
		private static void method3(){
			Console.Write("method3 fired,");
		}
		
		
	}
}

