using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UniRx;
using Wakame.Data;
using System.Linq;

public class ConvinientTools : EditorWindow {

	[MenuItem("Tools/Convinient")]
	static void Open(){
		GetWindow<ConvinientTools>();
	}

	void OnGUI(){
		if(GUILayout.Button("Load Stage")){
			ObservableWWW.Get(AppSettings.Instance.stageUrl)
				.Select(x=>StageData.Parser.Parse(x))
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
		
	}
}
