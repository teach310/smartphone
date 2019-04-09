using System.Collections.Generic;

namespace CA2.Data.MasterData{
	[System.Serializable]
	public partial class Tile{
		public int id;
		public int icon_id;
		public int collision_detection;
		public int spawn_target_type;
		public int spawn_target_group_id;
	}
}
