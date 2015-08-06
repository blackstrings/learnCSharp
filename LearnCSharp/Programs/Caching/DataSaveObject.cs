///The temp object that will hold the parsed data from the text file
using System;
using System.Collections.Generic;

namespace Caching
{
	public class DataSaveObject
	{
	
		public List<Entity> entities {get; set;}
		
		//you do not need to full fill every field in the json
		//for fields that don't exist, when load, that json portion just gets ignored
		//public List<Item> itemTemplateRepo {get;set;}
		
		public DataSaveObject ()
		{
			//init this object on start
			entities = new List<Entity>();
		}
	}
}

