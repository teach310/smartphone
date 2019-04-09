using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CA2.Data.MasterData;
using CA2.Data;
    
namespace Wakame {
    public class EnemyModel{
        public Enemy Enemy{get; private set; }

        public EnemyModel(Enemy enemy){
            Enemy = enemy;
        }

        public static EnemyModel CreateById(int id){
            var enemy = EnemyRepository.FindById(id);
            return new EnemyModel(enemy);
        }
    }
}