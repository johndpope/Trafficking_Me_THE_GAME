using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ClickSaveLoad : MonoBehaviour {

	// Use this for initialization
    public Text[] slot;
    SaveLoadManager manager;
    TapSave popup;
    // Use this for initialization
    void Start()
    {
        popup = GetComponent<TapSave>();
        manager = GetComponent<SaveLoadManager>();
    }
    
    public void Savegame(int n)
    {
        manager = GetComponent<SaveLoadManager>();
        manager.setChoice(n);
        manager.loaddataforsave();
        manager.BuildData();
        popup.saveWindow.SetActive(false);
        Time.timeScale = 1;
    }
    public void loadTopic()
    {
        manager.loadtopicdata();
        for (int i = 0; i < manager.topicdate.Length; i++)
        {
            slot[i].text = manager.topicdate[i];
        }
    }

}
