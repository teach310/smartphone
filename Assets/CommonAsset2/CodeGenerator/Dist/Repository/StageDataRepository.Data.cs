using System.Collections;
using System.Collections.Generic;
using CA2.Data.MasterData;

namespace CA2.Data{
	public partial class StageDataRepository{

		IStageDataStore dataStore;

		public StageDataRepository(IStageDataStore dataStore){
			this.dataStore = dataStore;
		}

		public static StageDataRepository Default = null;

		static List<StageData> DataList(StageDataRepository repository = null){
			if(repository == null)
				repository = Default;
			return repository != null ? repository.dataStore.StageDataList : new List<StageData>();
		}

		public static List<StageData> FindAll(StageDataRepository repository = null){
			return DataList(repository);
		}
	}
}

