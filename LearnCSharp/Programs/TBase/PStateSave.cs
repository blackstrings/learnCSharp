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
	public class PStateSave
	{
	
		public List<int> inventory {get; set;}
		public List<Item> itemInventory {get; set;}
		
		//you do not need to full fill every field in the json
		//for fields that don't exist, when load, that json portion just gets ignored
		//public List<Item> itemTemplateRepo {get;set;}
		
		public PStateSave ()
		{
			inventory = new List<int>();
			itemInventory = new List<Item>();
			//itemTemplateRepo = new List<Item>();
		}
	}
}

