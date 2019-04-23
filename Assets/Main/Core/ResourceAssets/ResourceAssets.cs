using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using System;

namespace Wakame {
    public class ResourceAssets : IDisposable{
        
        public static ResourceAssets Default = new ResourceAssets();

        public readonly Dictionary<int, Sprite> tiles = new Dictionary<int, Sprite>();

        public Sprite LoadTile(int id){
            Sprite sp = null;
            if(tiles.TryGetValue(id, out sp)){
                return sp;
            }

            var tileAtlas = Resources.Load<SpriteAtlas>("Images/TileAtlas");
            sp = tileAtlas.GetSprite("floor_" + id);
            tiles.Add(id, sp);
            return sp;
        }

        public void Dispose()
        {
            tiles.Clear();
        }
    }
}