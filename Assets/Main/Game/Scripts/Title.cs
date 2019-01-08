using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx.Async;
using CA2;
using UniRx;
using Wakame.Domain.Service;

namespace Wakame {
    public class Title : CA2.SceneBase {
        public void GoHome(){
            var titleLoadService = new TitleLoadService();
            SimpleSceneNavigator.Instance.GoForwardAsync<Home>(onBeforeLeaveAsync:titleLoadService.LoadAsync).Forget();
        }
    }
}