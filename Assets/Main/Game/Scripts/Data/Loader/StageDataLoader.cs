using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using Wakame.Data;
using System;

namespace Wakame.Data.Loader
{
	public class StageDataLoader{
		public IObservable<StageData> Load(int id, string url){
			return ObservableWWW.Get(url)
				.Select(x=>StageData.Parser.Parse(id, x));
		}
	}
}

