using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UniRx;
using Wakame.Data;
using System.Linq;
using Wakame.Domain.Repository;

public class ConvinientTools : EditorWindow {

	[MenuItem("Tools/Convinient")]
	static void Open(){
		GetWindow<ConvinientTools>();
	}

	void OnGUI(){
		if(GUILayout.Button("Load Stage")){
			ObservableWWW.Get(AppSettings.Instance.stageUrl)
				.Select(x=>StageData.Parser.Parse(1, x))
				.Subscribe(y => {
					var stageDataSet = new StageDataSet(){ stageDataList = new List<StageData>(){y}};

					foreach (var item in stageDataSet.stageDataList)
					{
						Debug.Log(item);
					}
				});
			// var loader = new SpreadSheetLoader();
			// loader.Load(stageUrl)
			// .Subscribe(x=>Debug.Log(x.text), e => Debug.LogError(e));
		}

		if(GUILayout.Button("AnyTest")){
			StageDataManager.Instance.Load()
				.Subscribe(_=>{
					var stageData = StageDataRepository.FindById(1);
					Debug.Log(stageData);
				});
		}
	}
}
