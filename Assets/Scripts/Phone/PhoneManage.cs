using UnityEngine;
using System.Collections;

public class PhoneManage : MonoBehaviour {
    public GameObject camerapage;
    public GameObject messagepage;
    public GameObject soundpage;
    public GameObject statpage;
    public GameObject mobile;
    public GameObject settingpage;
    public GameObject wpicon;

	// Use this for initialization
	void Start () {
         camerapage.SetActive(false);
         messagepage.SetActive(false);
         soundpage.SetActive(false);
         statpage.SetActive(false);
         mobile.SetActive(false);
         settingpage.SetActive(false);
         wpicon.SetActive(true);
        
	}
	
	// Update is called once per frame
	void Update () {
	
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
        }

  /*      if (enter.tag == "Player")
        {

            Debug.Log("u nai box na ja");
            isinSideBox = true;
            popup.SetActive(true);
        }
    
   */ }
}
