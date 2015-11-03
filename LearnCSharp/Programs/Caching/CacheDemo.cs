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
namespace Caching
{
	public class CacheDemo
	{
		//public static void Main () { start();}
		
		public static void start(){
			//nonBinarySaveLoad();
			binarySaveLoad();
			
		}
		
		//nonbinary example - loads in non-binary txt file data, parsed into cache
		public static void nonBinarySaveLoad(){
			Cache cache = Cache.Instance;
			cache.load();
			
			//test data
			Entity entity = EntityFactory.getObject();
			Console.WriteLine(entity.toString ());
		}
		
		//binary example - loads in binary saved file, parse into cache
		public static void binarySaveLoad(){
			Cache cache = Cache.Instance;
			
			//save
			//Only turn on when you first need to create the file, after that no need to turn on this command
			//cache.saveSerialized();
			
			//load
			cache.loadDeserializeObject();
			
			//test data
			Entity entity = EntityFactory.getObject();
			Console.WriteLine(entity.toString ());
		}
	}
}
