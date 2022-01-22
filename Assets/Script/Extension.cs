using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public static class Extension
{
    public static T GetOrAddComponent<T>(this GameObject go) where T : UnityEngine.Component
    {
        return Util.GetOrAddComponent<T>(go);
    }

    //go.isValid() << 로 호출가능(매개변수를 앞에서 씀) 
    public static bool isValid(this GameObject go)
    {
        //setActive인 상태인지 확인
        return go != null && go.activeSelf;
    }

    public static void AddUIEvent(this GameObject go, Action<PointerEventData> action, Define.UIEvent type = Define.UIEvent.Click)
    {
        UI_Base.BindEvent(go, action, type);
    }
}
