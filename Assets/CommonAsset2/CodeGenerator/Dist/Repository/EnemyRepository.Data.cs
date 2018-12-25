using System.Collections;
using System.Collections.Generic;
using CA2.Data.MasterData;

namespace CA2.Data{
	public partial class EnemyRepository{

		IEnemyStore dataStore;

		public EnemyRepository(IEnemyStore dataStore){
			this.dataStore = dataStore;
		}

		public static EnemyRepository Default = null;

		static List<Enemy> DataList(EnemyRepository repository = null){
			if(repository == null)
				repository = Default;
			return repository != null ? repository.dataStore.EnemyList : new List<Enemy>();
		}

		public static List<Enemy> FindAll(EnemyRepository repository = null){
			return DataList(repository);
		}
	}
}

