using System.Collections;
using System.Collections.Generic;
using CA2;
using UnityEngine;
using UniRx.Async;
using UnityEngine.UI;
// using UnityEngine.AddressableAssets;
using UniRx;

namespace Wakame {
    public class Home : CA2.SceneBase {
        
        [SerializeField] Image sampleImage;
        [SerializeField] SpriteRenderer sampleSprite;
        Sprite tile0;

        public override void OnLoad(object options = null){
            // Debug.Log(Domain.Repository.StageDataRepository.FindById(1));
            // var keyValuePair = CA2.Data.KeyValueRepository.FindAll () [0];
			// Debug.LogFormat ("Key {0}, Value{1}", keyValuePair.key, keyValuePair.value);
            // Addressables.LoadAsset<Sprite>("Tile/floor_0").Completed += sp => {
            //     tile0 = sp.Result;
            //     sampleImage.sprite = tile0;
            //     sampleSprite.sprite = tile0;
            // };

            sampleImage.sprite = ResourceAssets.Default.LoadEnemy(1)[0];
            sampleSprite.sprite = ResourceAssets.Default.LoadEnemy(1)[1];
        }

        public void GoGame(){
            SimpleSceneNavigator.Instance.GoForwardAsync<Game>().Forget();
        }
    }
}