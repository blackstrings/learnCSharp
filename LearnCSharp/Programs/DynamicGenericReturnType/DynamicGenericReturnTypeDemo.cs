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

//the propblem with this is that there is no typeSaftey
//so you can't know the error until runtime, it is best practice to have typeSaftey on
//so you would rather cast to the type when getting the attributes
namespace Programs.DynamicGenericReturnType
{
	public class DynamicGenericReturnTypeDemo
	{
	
//		public static void Main(){ start(); }
		
		public static void start (){
			Entity e = AppleFactory.getObject();
			//string name = e.getProp<string>(Prop.NAME);
			string name = e.getProp(Prop.NAME);
			int age = e.getProp(Prop.AGE);
			float speed = e.getProp(Prop.SPEED);
			bool high = e.getProp(Prop.HIGH);
			
			Console.WriteLine(name + " : " + age + " : " + speed + " : " + high);
		}
	}
}

