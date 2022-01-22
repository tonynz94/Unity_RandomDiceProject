using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_Loading : BaseScene
{
    public GameObject canvas;

    protected override void Init()
    {
        base.Init();
        SceneType = Define.Scene.Loading;
    }

    public override void Clear()
    {
         
    }
}
