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
namespace Inheritance
{
	public class InheritDemo
	{
		/*
		public static void Main(){
			start();
		}
		*/
		
		private static void start(){
			BaseClass derived = new DerivedClass();
			derived.add(5,5);
			DerivedClass d2 = new DerivedClass();
			d2.add(3,3);
		}
	}
}

