using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class boxLoading : MonoBehaviour {

    public Text[] slot;
    private SaveLoadManager manager;
    private int numberofSlot;
    void Start()
    {
        manager = GetComponent<SaveLoadManager>();
        manager.loadtopicdata();
        for (int i = 0; i < manager.topicdate.Length; i++)
        {
            slot[i].text = manager.topicdate[i];
        }
    }
    public void changeScene(int i)
    {
        if (manager.topicdate[i] != null && manager.topicdate[i] !="")
        {
            numberofSlot = i;
            Application.LoadLevel("thirtythree");
            Instantiate(Resources.Load<GameObject>("Prefabs/Player"), new Vector3(-2.992473f, -1.492281f, 0), Quaternion.identity);
            Instantiate(Resources.Load<GameObject>("Prefabs/Canvas"), new Vector3(-2.992473f, -1.492281f, -5), Quaternion.identity);
            Instantiate(Resources.Load<GameObject>("Prefabs/main camera"), new Vector3(-2.992473f, -1.492281f, -5), Quaternion.identity);
            
            DontDestroyOnLoad(gameObject);
            
        }
        
    }
    public void loadData()
    {
        manager.LoadData(numberofSlot);
    }
}
