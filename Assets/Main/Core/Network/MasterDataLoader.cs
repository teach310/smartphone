using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using Wakame.Data;

public class MasterDataLoader {
	// const string url = "https://script.google.com/macros/s/AKfycbyLLNDee4YMprcLly0LwboGn-c1TUY7Df-LsbnySW_5GKZr2Dvp/exec";

	// public IObservable<UniRx.Unit> Load () {
	// 	return ObservableWWW.Get (url, null, new ProgressLogger ())
	// 		.Do (x => Debug.Log (x))
	// 		.Select (x => ConvertArrayToListJson (x))
	// 		.Select (json => JsonUtility.FromJson<MasterDataSet> (json))
	// 		.ForEachAsync (dataSet => MasterDataStore.dataSet = dataSet);
	// }

	// public static string ConvertArrayToListJson (string json) {
	// 	return "{ \"unitList\": " + json + "}";
	// }

	// public class ProgressLogger : IProgress<float> {
	// 	public void Report (float value) {
	// 		Debug.Log (value);
	// 	}
	// }
}