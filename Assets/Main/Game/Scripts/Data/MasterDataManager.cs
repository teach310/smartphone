using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using Wakame.Data.Loader;
using System;

namespace Wakame.Data
{
	// MasterDataの保持、ロード
	public class StageDataManager{
		static StageDataManager instance = null;
		public static StageDataManager Instance{
			get{ return instance ?? (instance = new StageDataManager());}
		}

		public StageDataSet StageDataSet{get; private set; }

		public IObservable<Unit> Load(){
			return Observable.FromCoroutine(LoadCoroutine);
		}

		IEnumerator LoadCoroutine(){
			var stageDataLoader = new StageDataLoader();
			var stageDataSet = new StageDataSet();
			var stageLoadTask = stageDataLoader.Load(1, AppSettings.Instance.stageUrl).ToYieldInstruction();
			yield return stageLoadTask;
			stageDataSet.stageDataList = new List<StageData>{stageLoadTask.Result};
			StageDataSet = stageDataSet;
		}
	}
}

