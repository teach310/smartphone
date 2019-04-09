using System.Collections;
using System.Collections.Generic;
using CA2.Data;
using CA2.Data.MasterData;
using UnityEngine;

namespace CA2.Data
{
	public partial class ItemGroupRepository{
		public static List<ItemGroup> FindAllById(int id, ItemGroupRepository repository = null){
			return DataList(repository).FindAll(x=> x.group_id == id);
		}
	}
}
