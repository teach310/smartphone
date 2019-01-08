using System.Collections;
using System.Collections.Generic;

/// <summary>
/// MasterDataStoreとRepositoryを紐づける
/// </summary>
namespace CA2.Data.MasterData {
	public class MasterDataRepositoryBuilder {
		public void Build (MasterDataStore dataStore) {
			KeyValueRepository.Default = new KeyValueRepository (dataStore);
			StageRepository.Default = new StageRepository (dataStore);
			EnemyRepository.Default = new EnemyRepository (dataStore);
			EnemyGroupRepository.Default = new EnemyGroupRepository (dataStore);
			ItemRepository.Default = new ItemRepository (dataStore);
			ItemGroupRepository.Default = new ItemGroupRepository (dataStore);
			StageSpawnRepository.Default = new StageSpawnRepository (dataStore);
		}
	}
}