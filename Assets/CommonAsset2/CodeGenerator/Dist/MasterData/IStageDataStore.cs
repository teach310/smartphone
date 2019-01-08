using System.Collections;
using System.Collections.Generic;

namespace CA2.Data.MasterData {
	public interface IStageDataStore{
		List<StageData> StageDataList{ get; }
	}
}