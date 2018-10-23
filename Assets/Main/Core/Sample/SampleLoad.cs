using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.U2D;

public class SampleLoad : MonoBehaviour {

	[AssetReferenceTypeRestriction(typeof(SpriteAtlas)),SerializeField]
	AssetReference playerRef;

	public int direction = 0;
	[SerializeField]  SpriteRenderer spRenderer;

	void Start(){
		Addressables.LoadAsset<SpriteAtlas>(playerRef).Completed += atlas => {
			spRenderer.sprite = atlas.Result.GetSprite(atlas.Result.name + "_" + direction.ToString());
		};
	}
}
