using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_Lobby : BaseScene
{
    #region GameObject
    GameObject obj_Panel_LobbyUI;
    GameObject obj_Panel_BattleUI;
    GameObject obj_Panel_InventoryUI;
    #endregion

    public GameObject canvas;

    protected override void Init()
    {
        base.Init();
        SceneType = Define.Scene.MainLobby;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    public override void Clear()
    {

    }
}
