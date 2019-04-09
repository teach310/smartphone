using System.Collections;
using System.Collections.Generic;
using CA2.Data.MasterData;

namespace CA2.Data{
	public partial class SpawnRepository{

		ISpawnStore dataStore;

		public SpawnRepository(ISpawnStore dataStore){
			this.dataStore = dataStore;
		}

		public static SpawnRepository Default = null;

		static List<Spawn> DataList(SpawnRepository repository = null){
			if(repository == null)
				repository = Default;
			return repository != null ? repository.dataStore.SpawnList : new List<Spawn>();
		}

		public static List<Spawn> FindAll(SpawnRepository repository = null){
			return DataList(repository);
		}
	}
}

