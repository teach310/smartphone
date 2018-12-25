using System.Collections;
using System.Collections.Generic;
using CA2.Data.MasterData;

namespace CA2.Data{
	public partial class ItemGroupRepository{

		IItemGroupStore dataStore;

		public ItemGroupRepository(IItemGroupStore dataStore){
			this.dataStore = dataStore;
		}

		public static ItemGroupRepository Default = null;

		static List<ItemGroup> DataList(ItemGroupRepository repository = null){
			if(repository == null)
				repository = Default;
			return repository != null ? repository.dataStore.ItemGroupList : new List<ItemGroup>();
		}

		public static List<ItemGroup> FindAll(ItemGroupRepository repository = null){
			return DataList(repository);
		}
	}
}

