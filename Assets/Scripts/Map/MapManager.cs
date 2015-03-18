using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
public class MapManager : MonoBehaviour {
    public GameObject mapraw;
    public GameObject mapicon;
    public GameObject c1,c2,c3,c4,c5,c6,c7,c8,c9,c10,c11,c12,c13,c14,c15,c16,c17,c18,c19,c20,c21,c22,c23,c24,c25,c26,c27,c28,c29,c30,c31,c32,c34,c3567;
    bool openingMap;
    Dictionary<string, GameObject> mapDictionary = new Dictionary<string, GameObject>();


    // Use this for initialization
    public void openMap()
    {     
        if (Application.loadedLevelName != "thirtythree")
        {
            gameObject.SetActive(true);
            mapraw.SetActive(true);
            openingMap = true;
            StartCoroutine(blinking(mapDictionary[Application.loadedLevelName]));
        }
    }
    public void closeMap()
    {
        mapDictionary[Application.loadedLevelName].SetActive(false);
        StopCoroutine(blinking(mapDictionary[Application.loadedLevelName]));

        gameObject.SetActive(false);

        mapraw.SetActive(false);
        
    }

    IEnumerator blinking(GameObject obj)
    {
        while (openingMap)
        {
            

            yield return new WaitForSeconds(0.7f);
            obj.SetActive(!obj.activeSelf);
        }


    }
	void Start () {
        Debug.Log("mapja");
        //Debug.Log(Application.loadedLevelName);
        mapraw.SetActive(false);
        c1.SetActive(false); 
        c2.SetActive(false); 
        c3.SetActive(false); 
        c4.SetActive(false); 
        c5.SetActive(false); 
        c6.SetActive(false); 
        c7.SetActive(false);
        c8.SetActive(false);
        c9.SetActive(false);
        c10.SetActive(false);
        c11.SetActive(false);
        c12.SetActive(false);
        c13.SetActive(false);
        c14.SetActive(false);
        c15.SetActive(false);
        c16.SetActive(false);
        c17.SetActive(false);
        c18.SetActive(false);
        c19.SetActive(false);
        c20.SetActive(false);
        c21.SetActive(false);
        c22.SetActive(false);
        c23.SetActive(false);
        c24.SetActive(false);
        c25.SetActive(false);
        c26.SetActive(false);
        c27.SetActive(false);
        c28.SetActive(false);
        c29.SetActive(false);
        c30.SetActive(false);
        c31.SetActive(false);
        c32.SetActive(false);
        c34.SetActive(false);
        c3567.SetActive(false);


        mapDictionary.Add("one", c1);
        mapDictionary.Add("two", c2);
        mapDictionary.Add("three", c3);
        mapDictionary.Add("four", c4);
        mapDictionary.Add("five", c5);
        mapDictionary.Add("six", c6);
        mapDictionary.Add("seven", c7);
        mapDictionary.Add("eight", c8);
        mapDictionary.Add("nine", c9);
        mapDictionary.Add("ten", c10);
        mapDictionary.Add("eleven", c11);
        mapDictionary.Add("twelve", c12);
        mapDictionary.Add("thirteen", c13);
        mapDictionary.Add("fourteen", c14);
        mapDictionary.Add("fifteen", c15);
        mapDictionary.Add("sixteen", c16);
        mapDictionary.Add("seventeen", c17);
        mapDictionary.Add("eighteen", c18);
        mapDictionary.Add("nineteen", c19);
        mapDictionary.Add("twenty", c20);
        mapDictionary.Add("twentyone", c21);
        mapDictionary.Add("twentytwo", c22);
        mapDictionary.Add("twentythree", c23);
        mapDictionary.Add("twentyfour", c24);
        mapDictionary.Add("twentyfive", c25);
        mapDictionary.Add("twentysix", c26);
        mapDictionary.Add("twentyseven", c27);
        mapDictionary.Add("twentyeight", c28);
        mapDictionary.Add("twentynine", c29);
        mapDictionary.Add("thirty", c30);
        mapDictionary.Add("thirtyone", c31);
        mapDictionary.Add("thirtytwo", c32);
        mapDictionary.Add("thirtyfour", c34);
        mapDictionary.Add("thirtyfive-thirtyseven", c3567);
        gameObject.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
