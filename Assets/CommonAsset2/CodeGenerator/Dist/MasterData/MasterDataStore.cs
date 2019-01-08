using System.Collections;
using System.Collections.Generic;

namespace CA2.Data.MasterData{
	public class MasterDataStore : IKeyValueStore, IStageDataStore, IEnemyStore, IEnemyGroupStore, IItemStore, IItemGroupStore, IStageSpawnStore {
		
		public MasterDataSet DataSet{ get; private set; }

		public List<KeyValue> KeyValueList { get { return DataSet.keyValueList; } }
		public List<StageData> StageDataList { get { return DataSet.stageDataList; } }
		public List<Enemy> EnemyList { get { return DataSet.enemyList; } }
		public List<EnemyGroup> EnemyGroupList { get { return DataSet.enemyGroupList; } }
		public List<Item> ItemList { get { return DataSet.itemList; } }
		public List<ItemGroup> ItemGroupList { get { return DataSet.itemGroupList; } }
		public List<StageSpawn> StageSpawnList { get { return DataSet.stageSpawnList; } }

		public MasterDataStore(MasterDataSet dataSet){
			DataSet = dataSet;
		}		
	}
}