using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerContainer : MonoBehaviour
{
    static ManagerContainer s_Instance;

    ResourceManager _resource = new ResourceManager();
    GamePlayerManager _players = new GamePlayerManager();
    DataManager _data = new DataManager();

    public static ManagerContainer Instance { get { init(); return s_Instance; } }
    public static ResourceManager Resource { get { return Instance._resource; } }
    public static GamePlayerManager Players { get { return Instance._players; } }
    public static DataManager Data { get { return Instance._data; } }

    // Start is called before the first frame update
    public static void init()
    {
        if (s_Instance == null)
        {
            GameObject go = GameObject.Find("@ManagerContainer");
            if (go == null)
            {
                go = new GameObject { name = "@ManagerContainer" };
                go.AddComponent<ManagerContainer>();
            }

            s_Instance = go.GetComponent<ManagerContainer>();
            DontDestroyOnLoad(go);

            s_Instance._data.Init();
        }        
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
