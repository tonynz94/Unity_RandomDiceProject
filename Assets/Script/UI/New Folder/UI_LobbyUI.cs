using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UI_LobbyUI : UI_Base
{
    protected enum GameObjects
    {
        obj_contents_Game,
        obj_contents_Inventory
    };


    protected enum Buttons
    {
        btn_tab_Battle,
        btn_tab_Inventory
    };

    // Start is called before the first frame update

    private void Awake()
    {
        Bind<GameObject>(typeof(GameObjects));
        Bind<Button>(typeof(Buttons));
    }

    private void OnEnable()
    {
        Click_BattleTab();
    }
    void Start()
    {
       
    }

    public void Click_InventoryTab()
    {
        Get<GameObject>((int)GameObjects.obj_contents_Game).SetActive(false);
        Get<GameObject>((int)GameObjects.obj_contents_Inventory).SetActive(true);
        Get<Button>((int)Buttons.btn_tab_Inventory).interactable = false;
        Get<Button>((int)Buttons.btn_tab_Battle).interactable = true;
    }

    public void Click_BattleTab()
    {
        Get<GameObject>((int)GameObjects.obj_contents_Game).SetActive(true);
        Get<GameObject>((int)GameObjects.obj_contents_Inventory).SetActive(false);
        Get<Button>((int)Buttons.btn_tab_Inventory).interactable = true;
        Get<Button>((int)Buttons.btn_tab_Battle).interactable = false;
       
    }

    public void Click_BattleMode()
    {
        PlayerPrefs.SetString("NextSceneName", "Scene_Battle");
        SceneManager.LoadScene("Scene_Loading");
    }

    public override void Init()
    {
        throw new System.NotImplementedException();
    }
}
