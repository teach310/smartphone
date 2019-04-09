using System.Collections;
using System.Collections.Generic;

namespace CA2.Data.MasterData{
	public class MasterDataStore : IKeyValueStore, IStageStore, IEnemyStore, IEnemyGroupStore, IItemStore, IItemGroupStore, IStageSpawnStore, ISpawnStore, ITileStore {
		
		public MasterDataSet DataSet{ get; private set; }

		public List<KeyValue> KeyValueList { get { return DataSet.keyValueList; } }
		public List<Stage> StageList { get { return DataSet.stageList; } }
		public List<Enemy> EnemyList { get { return DataSet.enemyList; } }
		public List<EnemyGroup> EnemyGroupList { get { return DataSet.enemyGroupList; } }
		public List<Item> ItemList { get { return DataSet.itemList; } }
		public List<ItemGroup> ItemGroupList { get { return DataSet.itemGroupList; } }
		public List<StageSpawn> StageSpawnList { get { return DataSet.stageSpawnList; } }
		public List<Spawn> SpawnList { get { return DataSet.spawnList; } }
		public List<Tile> TileList { get { return DataSet.tileList; } }

		public MasterDataStore(MasterDataSet dataSet){
			DataSet = dataSet;
		}		
	}
}