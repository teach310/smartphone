using System.Collections;
using System.Collections.Generic;
using CA2.Data.MasterData;

namespace CA2.Data{
	public partial class StageSpawnRepository{

		IStageSpawnStore dataStore;

		public StageSpawnRepository(IStageSpawnStore dataStore){
			this.dataStore = dataStore;
		}

		public static StageSpawnRepository Default = null;

		static List<StageSpawn> DataList(StageSpawnRepository repository = null){
			if(repository == null)
				repository = Default;
			return repository != null ? repository.dataStore.StageSpawnList : new List<StageSpawn>();
		}

		public static List<StageSpawn> FindAll(StageSpawnRepository repository = null){
			return DataList(repository);
		}
	}
}

