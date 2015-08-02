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
using Newtonsoft.Json;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace TBase
{
	/// <summary>
	/// Not the best most efficient way to save.
	/// </summary>
	public static class SaveLoadState
	{

		private static string pathTxt = @"C:\Users\xlao\git\LearnCSharp\LearnCSharp\Programs\TBase\saveFile.txt";
		private static string pathSerialize = @"C:\Users\xlao\git\LearnCSharp\LearnCSharp\Programs\TBase\saveFile.so";
		
		//different ways to save/load
		//following two method is by saving json as text only
		public static void save(string jsonStr){
			System.IO.File.WriteAllText(pathTxt, jsonStr);
		}
		
		public static void load(){
			try{
				string serialized = System.IO.File.ReadAllText(pathTxt);
				PStateSaveObject stateLoad = JsonConvert.DeserializeObject<PStateSaveObject>(serialized);
				PState.Instance.inventory = stateLoad.inventory;
				PState.Instance.itemInventory = stateLoad.itemInventory;
			}catch(FileNotFoundException e){
				Console.WriteLine("no load file found");
			}
		}
		
		//method 2 - better method and more time to setup
		//this method makes you serialize your data into json
		//then pass that json string into the savedObject's string fields
		//so basically all your objects are saved as json string
		//the main savedObj will be holding these jsonString 
		//which then the savedObject itself will be serialized into binary
		public static void saveSerialized(){
			//prepare the saving obj
			PStateSaveSerializeable pStateSave = new PStateSaveSerializeable();
			
			//serialize the state data objects into json
			//pass in the serialized json data to the saving object
			pStateSave.inventory = JsonConvert.SerializeObject(PState.Instance.inventory);
			pStateSave.itemInventory = JsonConvert.SerializeObject(PState.Instance.itemInventory);
			
			//prepare the save location and formatter
			Stream stream = File.Open(pathSerialize, FileMode.Create);
			BinaryFormatter bformatter = new BinaryFormatter();
			
			//write saving obj to file
			bformatter.Serialize(stream, pStateSave);
			stream.Close();
		}
		
		public static void loadDeserializeObject(){
			//prepare the savedObj for loading back data
			PStateSaveSerializeable pStateSave = null;
			
			//read file
			Stream stream = File.Open(pathSerialize, FileMode.Open);
			BinaryFormatter bf = new BinaryFormatter();
			
			//convert to obj
			pStateSave = (PStateSaveSerializeable) bf.Deserialize(stream);
			stream.Close();
			
			//reassign the values - dont' forget to deserialize the json str to objects, then assign the obj
			PState.Instance.inventory = JsonConvert.DeserializeObject<List<int>>(pStateSave.inventory);
			PState.Instance.itemInventory = JsonConvert.DeserializeObject<List<Item>>(pStateSave.itemInventory);
			
		}
		
		
	}
}

