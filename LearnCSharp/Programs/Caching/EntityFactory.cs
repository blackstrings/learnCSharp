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
	public static class EntityFactory
	{
		public static Entity getObject(){
			
			int maxIndex = Cache.Instance.entities.Count;
			
			Random random = new Random();
			int index = random.Next(0,maxIndex);
			
			
			Entity entity = Cache.Instance.entities[index];
			entity.lvl = random.Next(entity.minLvl, entity.maxLvl);
			
			return entity;
		}
	}
}

