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
using System.Collections;
using System.Collections.Generic;

using con = System.Console;

namespace DataStructure
{
	public class DataStructureDemo
	{
//		public static void Main(){ genericList(); }
		
		private static void genericList(){
			List<string> strs = new List<string>();
			
			strs.Add("one");
			strs.Add("two");
			strs.Add("three");
			strs.Add("four");
			
			//all in one 
			for(int i=0; i<strs.Count; i++){
				con.Write( strs[i] + "." );
			}
			
			//foreach
			foreach(string str in strs){
				Console.Write(str + ",");
			}
			
			
		}
		
	}
}

