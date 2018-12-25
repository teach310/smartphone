using System.Collections;
using System.Collections.Generic;
using CA2.Data.MasterData;

namespace CA2.Data{
	public partial class EnemyGroupRepository{

		IEnemyGroupStore dataStore;

		public EnemyGroupRepository(IEnemyGroupStore dataStore){
			this.dataStore = dataStore;
		}

		public static EnemyGroupRepository Default = null;

		static List<EnemyGroup> DataList(EnemyGroupRepository repository = null){
			if(repository == null)
				repository = Default;
			return repository != null ? repository.dataStore.EnemyGroupList : new List<EnemyGroup>();
		}

		public static List<EnemyGroup> FindAll(EnemyGroupRepository repository = null){
			return DataList(repository);
		}
	}
}

