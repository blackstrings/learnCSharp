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
namespace TBase
{
	public static class MainController
	{
		//responsible to interacte between the box and the user
		public static void itemToUser(Item item){
			PState state = PState.Instance;
			//Item item = state.getItem();
			state.itemInventory.Add(item);
		}
		public static void numToUser(int rand){
			PState.Instance.inventory.Add(rand);
		}
	}
}
