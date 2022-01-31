using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

//��� ���� �ֻ���
public abstract class BaseScene : MonoBehaviour
{
    public Define.Scene SceneType { get; protected set; } = Define.Scene.Unknown;
    void Awake()
    {
        Init();
        ManagerContainer.init();
    }

    protected virtual void Init()
    {
        //���� �� �ȿ� EventSystem�� ã��.
        Object obj = GameObject.FindObjectOfType(typeof(EventSystem));
        if (obj == null)    //���� ���ٸ� ���� �� �̸� ����
            ManagerContainer.Resource.Instantiate("UI/EventSystem").name = "@EventSystem";
    }

    public abstract void Clear();
}
