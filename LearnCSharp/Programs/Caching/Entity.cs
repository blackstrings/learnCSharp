///The temp object that will hold the parsed data from the text file
using System;
using System.Collections.Generic;
using System.Text;

namespace Caching
{
	public class Entity
	{
	
		public int id {get; set;}
		public string name {get;set;}
		public int baseDmg {get;set;}
		public int baseEnergy {get;set;}
		public int minLvl {get;set;}
		public int maxLvl {get;set;}
		public int rarity {get;set;}
		
		//you do not need to full fill every field in the json
		//for fields that don't exist, when load, that json portion just gets ignored
		//public List<Item> itemTemplateRepo {get;set;}
		
		public Entity (){}
		
		public string toString(){
			StringBuilder sb = new StringBuilder();
			sb.Append(id);
			sb.Append(",");
			sb.Append(name);
			sb.Append(",");
			sb.Append(baseDmg);
			sb.Append(",");
			sb.Append(baseEnergy);
			sb.Append(",");
			sb.Append(minLvl);
			sb.Append(",");
			sb.Append(maxLvl);
			sb.Append(",");
			sb.Append(rarity);
			return sb.ToString();
		}
	}
}

