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
        //Json의 파일을 로드해 줌. 
        TextAsset textAsset = ManagerContainer.Resource.Load<TextAsset>($"Data/{path}");
        //json에 있는 값을 클래스의 멤버변수에 이름에 맞춰 값을 초기화 함.
        return JsonUtility.FromJson<Loader>(textAsset.text);   
    }
}
