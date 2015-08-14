///loading from a file and caching the data in memory
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Caching
{
	///A true cache object should become a singleton-like-object and outlive the entire session - avoid static class for cache
	public class Cache
	{

		private static string pathTxt = @"C:\Users\xlao\git\LearnCSharp\LearnCSharp\Programs\Caching\data.txt";
		private static string pathSerialize = @"C:\Users\xlao\git\LearnCSharp\LearnCSharp\Programs\Caching\data.so";
	
		//cached fields
		public List<Entity> entities {get;set;}
	
		//singleton
		private static Cache instance = null;
		private static readonly object padlock = new object();
		public static Cache Instance {
			get{
				lock(padlock){
					if(instance == null){
						instance = new Cache();
					}
					return instance;
				}
			}
		}
	
		//different ways to save/load
		//following two method is by saving json as text only
		public void save(string jsonStr){
			System.IO.File.WriteAllText(pathTxt, jsonStr);
		}
		
		public void load(){
			//we can load more methods in here
			loadEntities();
		}
		
		///load the data txt as objects into the main saved object
		public void loadEntities(){
			try{
				
				string serialized = System.IO.File.ReadAllText(pathTxt);//load non-binary file
				
				DataSaveObject data = JsonConvert.DeserializeObject<DataSaveObject>(serialized);//deserialize into a temp obj
				
				//move temp obj into cache data
				entities = data.entities;
				
				data = null;	//for gc
				
				//test the data
				foreach(Entity entity in entities){
					Console.WriteLine(entity.toString());
				}
				
				//when we have a state, pass data into a more persistent state state
				//PState.Instance.inventory = data.entities;
				//PState.Instance.itemInventory = stateLoad.itemInventory;
			}catch(FileNotFoundException e){
				Console.WriteLine("no load file found" + e);
			}
		}
		
		
		//method 2 - better method and more time to setup
		//this method makes you serialize your data into json
		//then pass that json string into the savedObject's string fields
		//so basically all your objects are saved as json string
		//the main savedObj will be holding these jsonString 
		//which then the savedObject itself will be serialized into binary
		public void saveSerialized(){
			//prepare the saving obj
			string serialized = System.IO.File.ReadAllText(pathTxt);//load non-binary file
			DataSaveObject so = new DataSaveObject();
			
			//serialize the state data objects into json
			//pass in the serialized json data to the saving object
			//so.entities = JsonConvert.SerializeObject(PState.Instance.inventory);
			//so.itemInventory = JsonConvert.SerializeObject(PState.Instance.itemInventory);
			so.binaryData = serialized;
			
			//prepare the save location and formatter
			Stream stream = File.Open(pathSerialize, FileMode.Create);
			BinaryFormatter bformatter = new BinaryFormatter();
			
			//write saving obj to file
			bformatter.Serialize(stream, so);
			stream.Close();
		}
		
		
		public void loadDeserializeObject(){
			//prepare the savedObj for loading back data
			DataSaveObject so = null;
			
			//read file
			Stream stream = File.Open(pathSerialize, FileMode.Open);
			BinaryFormatter bf = new BinaryFormatter();
			
			//convert to obj
			so = (DataSaveObject) bf.Deserialize(stream);
			stream.Close();
			
			//reassign the values - dont' forget to deserialize the json str to objects, then assign the obj
			DataSaveObject so2 = JsonConvert.DeserializeObject<DataSaveObject>(so.binaryData);//deserialize into a temp obj
			entities = new List<Entity>();
			entities = so2.entities;
			so2 = null;
			so = null;
			//PState.Instance.itemInventory = JsonConvert.DeserializeObject<List<Item>>(so.itemInventory);
			
		}
		
		
	}
}

