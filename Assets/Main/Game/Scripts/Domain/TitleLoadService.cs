using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CA2.Data;
using UniRx.Async;
using Wakame.Data;
using UniRx;

namespace Wakame.Domain.Service
{
    public class TitleLoadService{
        public async UniTask LoadAsync(){
            await MasterDataManager.Instance.LoadAsync();
            await StageDataManager.Instance.Load();
        }
    }
}

