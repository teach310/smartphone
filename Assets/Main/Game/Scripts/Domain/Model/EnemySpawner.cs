using System.Collections;
using System.Collections.Generic;
using CA2.Data;
using UnityEngine;

namespace Wakame {
    /// <summary>
    /// 出てくる敵を取得する
    /// </summary>
    public class EnemySpawner{

        Queue<EnemyModel> enemyQueue = new Queue<EnemyModel>();

        public EnemySpawner(int enemyGroupId){
            UpdateQueue(enemyGroupId, 10); // (1) 出てくる敵をリストアップ
        }

        void UpdateQueue(int enemyGroupId, int enemyCount){
            var enemyGroups = EnemyGroupRepository.FindAllById(enemyGroupId); // (2) EnemyGroupマスターから出てくる敵候補を取得
            if(enemyGroups.Count == 0)
                return;

            for (int i = 0; i < enemyCount; i++)
            {
                var enemyId = enemyGroups[0].enemy_id; // TODO (3) 重みを考慮してidを決定
                enemyQueue.Enqueue(EnemyModel.CreateById(enemyId));  // (4) 出てくる敵リストにつっこむ
            }
        }

        // (5) 出てくる敵リストから的モデルを取得
        // このEnemyModelから敵の見た目を構築する。
        public EnemyModel DequeueEnemy(){
            if(enemyQueue.Count == 0)
                return null;
            return enemyQueue.Dequeue();
        }        
    }
}