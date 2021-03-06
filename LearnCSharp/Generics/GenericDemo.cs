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
/// Don't forget to include the generic library to use generics
/// </summary>
namespace Generics
{
	
	public class GenericDemo
	{
//		public static void Main(){ start(); }
		
		private static void start(){
			simpleGeneric();
		}
		
		//examples
		private static void simpleGeneric(){
			int num = 5;
			
			//ex1
			genericMethod1<int>(ref num);
			
			//ex2
			genericaMethod2<int>(30);
			
			//ex3
			Console.WriteLine( returnGenericMethod<int>(50) );
			
			//ex4
			string name = returnGenericMethod3<string>(Prop.NAME);
			//Console.WriteLine(age);
			
			//Console.WriteLine( returnGenericMethod2<Object>() );
		}
		
		
		//generica method - passing in generic ref
		private static void genericMethod1<T>(ref T generic){
			T temp;
			temp = generic;
			Console.WriteLine(temp);
		}
		
		//generic method - passing in generic type
		private static void genericaMethod2<T>(T gen){
			Console.WriteLine(gen);
		}
		
		//return generic
		private static T returnGenericMethod<T>(T gen){
			return gen;
		}
		
		//return generic method
		private static T returnGenericMethod2<T>(){
			Object result = "I am string";
			result = 5;
			
			//unlike java, you don't need to check if it is of type this before converting
			//if(result is String){
			return (T) Convert.ChangeType(result, typeof(T));		//the magic
			//}
//			if(result.GetType() == typeof(string)){
//				return (T) Convert.ChangeType(result, typeof(string));
//			}
		}
		
		private static T returnGenericMethod3<T>(Prop prop){
			//test data
			Dictionary<Prop, Object> dict = new Dictionary<Prop, Object>();
			dict.Add(Prop.NAME, "tom");
			dict.Add(Prop.AGE, 55);
			
			object result = dict[prop];
			
			//Type.GetType(sType)
			return (T) Convert.ChangeType(result, typeof(T));
		}
		
	}
}

