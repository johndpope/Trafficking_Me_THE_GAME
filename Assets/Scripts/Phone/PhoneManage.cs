﻿using UnityEngine;
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
    public MissionDetail mission;
    public bool inDocArea = false;
    public GameObject image;
    public int documentID;

    private CharacterEmotion player;
    private GameController system;
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
        mission = messagepage.GetComponent<MissionDetail>();
        documentID = -1;

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterEmotion>();
        system = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameController>();
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void takeDoc()
    {
        if (documentID > -1)
        {
            StopCoroutine(blinking(image));
            inDocArea = false;
            docManager.collectDoc(documentID, true);

            player.updateEncouragementStat(1);
            system.SendMessage("IsStatChange", "+1 trustness");
        }
        
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

    IEnumerator blinking(GameObject obj)
    {
        while (inDocArea)
        {
            Debug.Log("inDocArea");
            
            yield return new WaitForSeconds(0.5f);
            obj.SetActive(!obj.activeSelf);
        }
        obj.SetActive(false);
    }
    public void setWarnmingFindDoc(bool haveDoc, int docID)
    {
        documentID = docID;
        inDocArea = haveDoc;
        if (haveDoc == true && camerapage.activeSelf == true)
        {
            
            StopCoroutine(blinking(image));
            StartCoroutine(blinking(image));
        }
        else
        {
            //inDocArea = haveDoc;
            image.SetActive(false);
        }
        

    }
    public void loadPage(int i)
    {

        switch (i)
        {
            case 1: Debug.Log("cam");
                camerapage.SetActive(true);
                if (inDocArea)
                {
                    StopCoroutine(blinking(image));
                    StartCoroutine(blinking(image));
                }
                else
                {
                    image.SetActive(false);
                }
                break;
            case 2: Debug.Log("mess");
                messagepage.SetActive(true);
                mission.UpdateCurrentMission();
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
                if (mobile.activeSelf)
                {
                    camerapage.SetActive(false);
                    messagepage.SetActive(false);
                    soundpage.SetActive(false);
                    statpage.SetActive(false);
                    mobile.SetActive(false);
                    settingpage.SetActive(false);
                    mobile.SetActive(false);
                }
                else
                {
                    mobile.SetActive(true);
                }
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
    public void CloseAllPage()
    {
        camerapage.SetActive(false);
        messagepage.SetActive(false);
        soundpage.SetActive(false);
        statpage.SetActive(false);
        mobile.SetActive(false);
        settingpage.SetActive(false);
        mobile.SetActive(false);
    }
}
