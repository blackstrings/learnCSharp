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
namespace Programs.DynamicGenericReturnType
{
	public class DynamicGenericReturnTypeDemo
	{
	
		public static void Main(){
			start();
		}
		
		public static void start (){
			Entity e = AppleFactory.getObject();
			string name = e.getProp<string>(Prop.NAME);
			Console.WriteLine(name);
		}
	}
}

