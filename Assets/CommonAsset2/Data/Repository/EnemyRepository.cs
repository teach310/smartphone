using System.Collections;
using System.Collections.Generic;
using CA2.Data;
using CA2.Data.MasterData;
using UnityEngine;

namespace CA2.Data
{
	public partial class EnemyRepository{
		public static Enemy FindById(int id, EnemyRepository repository = null){
			return DataList(repository).Find(x=> x.id == id);
		}
	}
}
