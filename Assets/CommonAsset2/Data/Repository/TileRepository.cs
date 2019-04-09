﻿using System.Collections;
using System.Collections.Generic;
using CA2.Data;
using CA2.Data.MasterData;
using UnityEngine;

namespace CA2.Data
{
	public partial class TileRepository{
		public static Tile FindById(int id, TileRepository repository = null){
			return DataList(repository).Find(x=> x.id == id);
		}
	}
}
