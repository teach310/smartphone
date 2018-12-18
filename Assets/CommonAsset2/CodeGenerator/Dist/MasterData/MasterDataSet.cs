using System.Collections.Generic;

namespace CA2.Data.MasterData{
	[System.Serializable]
	public class MasterDataSet{
		public List<KeyValue> keyValueList;
		public List<Enemy> enemyList;
		public List<EnemyGroup> enemyGroupList;
		public List<Item> itemList;
		public List<ItemGroup> itemGroupList;
		public List<StageSpawn> stageSpawnList;
	}
}
