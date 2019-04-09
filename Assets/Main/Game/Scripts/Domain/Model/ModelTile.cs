using System.Collections;
using System.Collections.Generic;
using CA2.Data;
using CA2.Data.MasterData;
using UnityEngine;

namespace Wakame{

    public class ModelTile
    {
        public Tile tile;

        ModelTile(Tile tile){
            this.tile = tile;
        }

        public static ModelTile CreateById(int tile_id) {
            var tile = TileRepository.FindById(tile_id);

            return new ModelTile(tile);
        }

    }

}
