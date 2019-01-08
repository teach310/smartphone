using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx.Async;
using CA2;

namespace Wakame {
    public class Title : CA2.SceneBase {
        public void GoHome() => SimpleSceneNavigator.Instance.GoForwardAsync<Home>().Forget();
    }
}