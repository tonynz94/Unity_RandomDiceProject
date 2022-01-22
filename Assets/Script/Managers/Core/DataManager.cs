using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ILoader<Key, Value>
{
    Dictionary<Key, Value> MakeDict();
}

public class DataManager
{
    public Dictionary<int, Data.DiceStat> diceDict { get; private set; } = new Dictionary<int, Data.DiceStat>();

    public void Init()
    {
        diceDict = LoadJson<Data.DiceStatData, int, Data.DiceStat>("DiceData").MakeDict();
    }

    Loader LoadJson<Loader, Key, Value>(string path) where Loader : ILoader<Key, Value>
    {
        //Json�� ������ �ε��� ��. 
        TextAsset textAsset = ManagerContainer.Resource.Load<TextAsset>($"Data/{path}");
        //json�� �ִ� ���� Ŭ������ ��������� �̸��� ���� ���� �ʱ�ȭ ��.
        return JsonUtility.FromJson<Loader>(textAsset.text);   
    }
}
