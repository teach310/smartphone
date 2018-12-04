using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Wakame.Data;

namespace Wakame.Domain.Repository
{
	public static class StageDataRepository {

		static List<StageData> DataList{
			get{return MasterDataManager.Instance.StageDataSet.stageDataList; }
		}
		/// <summary>
		/// 初級は1
		/// </summary>
		public static StageData FindById(int id){
			return DataList.Find(x=>x.StageId == id);
		}
	}
}

