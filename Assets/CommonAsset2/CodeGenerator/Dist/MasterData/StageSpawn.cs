using System.Collections.Generic;

namespace CA2.Data.MasterData{
	[System.Serializable]
	public class StageSpawn{
		public int stage_id;
		public int spawn_type;
		public int respown_time;
		public int enemy_group_id;
		public int item_group_id;
		public int priority;
	}
}
