using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PhoneManage : MonoBehaviour {
    public GameObject camerapage;
    public GameObject messagepage;
    public GameObject soundpage;
    public GameObject statpage;
    public GameObject mobile;
    public GameObject settingpage;
    public GameObject wpicon;
    public GameObject albumpage;
    public GameObject docraw;
    public bool seeingDoc = false;
    public DocManager docManager;
	// Use this for initialization
	void Start () {
         camerapage.SetActive(false);
         messagepage.SetActive(false);
         soundpage.SetActive(false);
         statpage.SetActive(false);
         mobile.SetActive(false);
         settingpage.SetActive(false);
         wpicon.SetActive(true);
         albumpage.SetActive(false);
         docraw.SetActive(false);
        docManager = new DocManager();
        docManager.collectDoc(0, true);
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public void checkIsCollect()
    {
        GameObject[] allDoc = GameObject.FindGameObjectsWithTag("DocChoice");
        for (int i = 0; i < docManager.getCountData() && i<allDoc.Length; i++)
        {
            if (docManager.isDocCollected(i) == true)
            {
                Image temp = allDoc[i].GetComponent<Image>();
                temp.sprite = Resources.Load<Sprite>("doc/" + "doc"+(i+1));
            }
            else
            {
                Image temp = allDoc[i].GetComponent<Image>();
                temp.sprite = Resources.Load<Sprite>("default/blank");
            }
        }
    }

    public void loadPage(int i)
    {

        switch (i)
        {
            case 1: Debug.Log("cam");
                camerapage.SetActive(true);
                break;
            case 2: Debug.Log("mess");
                messagepage.SetActive(true);
                break;
            case 3: Debug.Log("rec"); 
                soundpage.SetActive(true);
                break;
            case 4: Debug.Log("sta");
                statpage.SetActive(true);
                break;
            case 5: Debug.Log("down");
                camerapage.SetActive(false);
                messagepage.SetActive(false);
                soundpage.SetActive(false);
                statpage.SetActive(false);
                mobile.SetActive(false);
                settingpage.SetActive(false);
                break;
            case 6: Debug.Log("shut down");
                break;
            case 7: 
                camerapage.SetActive(false);
                messagepage.SetActive(false);
                soundpage.SetActive(false);
                statpage.SetActive(false);
                mobile.SetActive(false);
                settingpage.SetActive(false);
                mobile.SetActive(true);
                break;
            case 8: Debug.Log("up");
                mobile.SetActive(true);
                break;
            case 9:
                albumpage.SetActive(true);
                checkIsCollect();
                break;
            case 10:
                if (seeingDoc)
                {
                    seeingDoc = false;
                    docraw.SetActive(false);

                    
                 }
                 else
                 {
                     albumpage.SetActive(false);
                 }
                break;
            case 11:
                seeingDoc = true;
                docraw.SetActive(true);
                break;

        }
    }
}
