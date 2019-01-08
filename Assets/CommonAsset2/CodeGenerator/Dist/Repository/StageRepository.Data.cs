using System.Collections;
using System.Collections.Generic;
using CA2.Data.MasterData;

namespace CA2.Data{
	public partial class StageRepository{

		IStageStore dataStore;

		public StageRepository(IStageStore dataStore){
			this.dataStore = dataStore;
		}

		public static StageRepository Default = null;

		static List<Stage> DataList(StageRepository repository = null){
			if(repository == null)
				repository = Default;
			return repository != null ? repository.dataStore.StageList : new List<Stage>();
		}

		public static List<Stage> FindAll(StageRepository repository = null){
			return DataList(repository);
		}
	}
}

