///The temp object that will hold the parsed data from the text file
using System;
using System.Collections.Generic;

namespace Caching
{
	public class DataSaveObject
	{
		//tier1
		//json will get pushed into a list, then if you want key/value you'll have to loop the list and do key value
		public List<Entity> entities {get; set;}
		
		//tier2
		//re-categorize
		
		
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

