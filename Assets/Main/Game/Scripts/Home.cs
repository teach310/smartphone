using System.Collections;
using System.Collections.Generic;
using CA2;
using UnityEngine;
using UniRx.Async;

namespace Wakame {
    public class Home : CA2.SceneBase {

        public override void OnLoad(object options = null){
            Debug.Log(Domain.Repository.StageDataRepository.FindById(1));
            var keyValuePair = CA2.Data.KeyValueRepository.FindAll () [0];
			Debug.LogFormat ("Key {0}, Value{1}", keyValuePair.key, keyValuePair.value);
        }

        public void GoGame(){
            SimpleSceneNavigator.Instance.GoForwardAsync<Game>().Forget();
        }
    }
}