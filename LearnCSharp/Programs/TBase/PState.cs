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

namespace TBase
{
	public class PState
	{
		private static PState instance = null;
		private static readonly object padlock = new object();
		
		private PState ()
		{
			inventory = new List<int>();
			Console.WriteLine("PState alive");
		}
		
		public static PState Instance {
		
			get{
				lock(padlock){
					if(instance == null){
						instance = new PState();
					}
					return instance;
				}
			}
			
		}
		
		//states
		public List<int> inventory {get; private set;}
		
		
		//methods
		public int getRandomNum(int min, int max){
			return new Random().Next(min, max);
		}
	}
}

