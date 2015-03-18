using UnityEngine;
using System.Collections;

public class ClickSaveLoad : MonoBehaviour {

	// Use this for initialization
    SaveLoadManager manager;
    public void Savegame(int n)
    {
        manager = GetComponent<SaveLoadManager>();
        manager.setChoice(n);
        manager.loaddataforsave();
        manager.BuildData();
    }

}
