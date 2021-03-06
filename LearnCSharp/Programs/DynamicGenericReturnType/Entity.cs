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

namespace Programs.DynamicGenericReturnType
{
	public abstract class Entity
	{
		
		public Dictionary<Prop, Object> property {get;set;}
		
		public Entity(){
			property = new Dictionary<Prop, Object>();
		}
		
		//set properties
		public void setProp(Prop key, Object value){
			property.Add(key, value);
		}
		
		//get properties with no cast, more dangerous as no compile check, only runtime check
		public dynamic getProp(Prop prop){
			Object result = property[prop];
			return result;
		}
		
		//getproperties with casting - better approach
		//get properties but only the type you specify ex: getProps<int>
		public T getProp2<T>(Prop prop){
			Object result = property[prop];
			return (T)result;
			/*
			if(result.GetType() == typeof(string)){
				Console.WriteLine("is string");
				String str = result as String;
				//return (T)(object) str;
				return (T) Convert.ChangeType(str, typeof(T));		//the magic
			}
			
			Console.WriteLine("not string but " + result.GetType());
			return (T) Convert.ChangeType(result, typeof(T));		//the magic
			*/
		}
	}
}

