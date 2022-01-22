using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ResourceManager
{
    public T Load<T>(string path) where T : Object
    {
        //pool�� �������� �̸��� ����ϰ� ����.

        //Prefab���� Ȯ��
        //Pooling ���� Ȯ��
        if (typeof(T) == typeof(GameObject))
        {
            string name = path;
            int index = name.LastIndexOf("/");  //�ڿ��� ���� ã��.
            if (index >= 0) //ã�Ҵٸ�.
                name = name.Substring(index + 1); //index + 1���� �������� name�� ����

            //GameObject go = Managers.Pool.GetOriginal(name);
            //if (go != null) //���� ã�ƴٸ�.
            //    return go as T;

        }
        //(������ ã�����) â���� prefab ��η� �����ͼ� ���� ������Ʈ�� ���� ��
        return Resources.Load<T>(path);
    }

    //���ӿ�����Ʈ�� ������ ���ִ� �Լ�.
    public GameObject Instantiate(string path, GameObject parent = null)
    {
        //���� ������Ʈ�� ������ �����´�.
        GameObject original = Load<GameObject>($"Prefabs/{path}");

        if (original == null)
        {
            Debug.Log($"Fail to load prefab : {path}");
            return null;
        }

        //Poolable ��ũ��Ʈ�� �ִٴ� ���� ������Ʈ Ǯ���� ����ϰ� �ִٴ� ��.
       // if (original.GetComponent<Poolable>() != null)
       //     return Managers.Pool.Pop(original, parent).gameObject;

        //Ǯ���� ����� �ƴ϶��
        //������ Ŀ���Ͽ� �������ݴϴ�. 
        GameObject go = Object.Instantiate(original, parent.transform);
        go.name = original.name;

        return go;
    }

    //���ӿ�����Ʈ�� ���� ���ִ� �Լ�.
    public void Destory(GameObject go, float time = 0.0f)
    {
        if (go == null)
            return;

        //Poolable ��ũ��Ʈ�� �ִٴ� ���� ������Ʈ Ǯ���� ����ϰ� �ִٴ� ��.
        //Poolable poolable = go.GetComponent<Poolable>();
        //
        ////���࿡ Ǯ����� ������ �ִٸ�
        //if (poolable != null)
        //{
        //    //������Ʈ�� �ı���Ű�� �ʰ� �ٽ� Ǯ���ٰ� ��ȯ�� �ϴ� ��.
        //    Managers.Pool.Push(poolable);
        //    return;
        //}
        Object.Destroy(go, time);
    }
}
