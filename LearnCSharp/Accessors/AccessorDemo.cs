///explains getters and setters to fields
using System;
using System.Collections.Generic;

namespace Accessors
{
	public class AccessorDemo
	{
//		public static void Main () { start();}
		
		private static void start(){
			
			MyObj obj = new MyObj();
			obj.age = 5;
			obj.Age = 10;
			
			Console.WriteLine(obj.age + " : " + obj.Age);
			
			//Console.WriteLine(age);
		}
	}
	
	public class MyObj{
		public MyObj(){
			numbers = new List<int>();	//init the list
		}
	
		//automatic setters and getters - the newer method
		public int age {get;set;}
		
		//the above is same as the old method
		private int _age;
		public int Age{
			get{
				return _age;
			}
			set{
				_age = value;
			}
		}
		
		//you make one private while the other is read only
		public string name {get; private set;}
		
		//to init you'll have to use the constructor
		public List<int> numbers {get; private set;}
	}
}

