using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using System;
using System.Linq;

namespace Wakame {
    public class ResourceAssets : IDisposable{
        
        public static ResourceAssets Default = new ResourceAssets();

        public readonly Dictionary<int, Sprite> tiles = new Dictionary<int, Sprite>();
        public readonly Dictionary<string, Sprite> playerSprites = new Dictionary<string, Sprite>();
        public readonly Dictionary<string, Sprite> enemySprites = new Dictionary<string, Sprite>();

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

        /// <summary>
        /// 0, 1
        /// /// </summary>
        public Sprite[] LoadPlayer(){
            string[] fileNames = Enumerable.Range(0, 2)
                .Select(i => "player_" + i)
                .ToArray();

            var sprites = new Sprite[fileNames.Length];

            SpriteAtlas playerAtlas = null;
            for (int i = 0; i < fileNames.Length; i++)
            {
                Sprite sp = null;
                if(playerSprites.TryGetValue(fileNames[i], out sp)){
                    sprites[i] = sp;
                    continue;
                }
                if(playerAtlas == null)
                    playerAtlas = Resources.Load<SpriteAtlas>("Images/player");
                sp = playerAtlas.GetSprite(fileNames[i]);
                playerSprites.Add(fileNames[i], sp);
                sprites[i] = sp;
            }
            
            return sprites;
        }

        /// <summary>
        /// 0, 1, 2
        /// /// </summary>
        public Sprite[] LoadEnemy(int id){
            string[] fileNames = Enumerable.Range(0, 3)
                .Select(i => "enemy_" + id + "_" + i)
                .ToArray();

            var sprites = new Sprite[fileNames.Length];

            SpriteAtlas atlas = null;
            for (int i = 0; i < fileNames.Length; i++)
            {
                Sprite sp = null;
                if(enemySprites.TryGetValue(fileNames[i], out sp)){
                    sprites[i] = sp;
                    continue;
                }
                if(atlas == null)
                    atlas = Resources.Load<SpriteAtlas>("Images/EnemyAtlas");
                sp = atlas.GetSprite(fileNames[i]);
                enemySprites.Add(fileNames[i], sp);
                sprites[i] = sp;
            }
            
            return sprites;
        }

        public void Dispose()
        {
            tiles.Clear();
        }
    }
}