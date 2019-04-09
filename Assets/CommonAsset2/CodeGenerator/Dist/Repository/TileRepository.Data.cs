using System.Collections;
using System.Collections.Generic;
using CA2.Data.MasterData;

namespace CA2.Data{
	public partial class TileRepository{

		ITileStore dataStore;

		public TileRepository(ITileStore dataStore){
			this.dataStore = dataStore;
		}

		public static TileRepository Default = null;

		static List<Tile> DataList(TileRepository repository = null){
			if(repository == null)
				repository = Default;
			return repository != null ? repository.dataStore.TileList : new List<Tile>();
		}

		public static List<Tile> FindAll(TileRepository repository = null){
			return DataList(repository);
		}
	}
}

