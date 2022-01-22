using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Loading : MonoBehaviour
{

    public Text txt_Tips;
    public Text txt_progressNum;
    public Slider slider_LoadBar;
    // Start is called before the first frame update
    void Start()
    {
        LoadLevel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLevel()
    {
        string next_scene_name = PlayerPrefs.GetString("NextSceneName", string.Empty);
        PlayerPrefs.SetString("NextSceneName", string.Empty);
        //if (GFGlobal.randomValueForTip == -1)
        //{
        //    Label_Tip.text = GFLocale.Instance.GetLocalStr(tips[UnityEngine.Random.Range(0, tips.Length)]);
        //}
        //else
        //{
        //    Label_Tip.text = GFLocale.Instance.GetLocalStr(tips[GFGlobal.randomValueForTip]);
        //    GFGlobal.randomValueForTip = -1;
        //}
        StartCoroutine(LoadAsynchronously(next_scene_name));
    }

    IEnumerator LoadAsynchronously(string sceneName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);

            slider_LoadBar.value = progress;
            txt_progressNum.text = $"{progress * 100f}%";
            yield return null;
        }
    }
}
