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

    public GameObject objectivePoint;
    public RectTransform objectivePointRectTransform;
    Dictionary<int, float[]> objectiveList = new Dictionary<int, float[]>();

    private GameController system;
    private Quest currentQuest;
    // Use this for initialization
    public void openMap()
    {
        system = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameController>();
        if (Application.loadedLevelName != "thirtythree")
        {
            gameObject.SetActive(true);
            mapraw.SetActive(true);
            openingMap = true;
            StartCoroutine(blinking(mapDictionary[Application.loadedLevelName]));

            //objective Location
            currentQuest = system.getCurrentQuest();

            if (currentQuest.GetType() == typeof(MapQuest))
            {
                objectivePoint.SetActive(true);
                MapQuest temp = (MapQuest)currentQuest;


                objectivePointRectTransform.anchoredPosition = new Vector2(objectiveList[temp.getDestination()][0], objectiveList[temp.getDestination()][1]);
            }
            else
            {

                objectivePoint.SetActive(false);
            }


            //objectivePoint.SetActive(true);
            //Debug.Log(objectivePointRectTransform.anchoredPosition.x + " " + objectivePointRectTransform.anchoredPosition.y);
            //objectivePointRectTransform.anchoredPosition = new Vector2(objectiveList[2][0], objectiveList[2][1]);
        }
        else
        {
            //objective Location
            currentQuest = system.getCurrentQuest();

            if (currentQuest.GetType() == typeof(MapQuest))
            {
                objectivePoint.SetActive(true);
                MapQuest temp = (MapQuest)currentQuest;


                objectivePointRectTransform.anchoredPosition = new Vector2(objectiveList[temp.getDestination()][0], objectiveList[temp.getDestination()][1]);
            }
            else
            {
                objectivePoint.SetActive(false);
            }
        }
    }
    public void closeMap()
    {
        mapDictionary[Application.loadedLevelName].SetActive(false);
        StopCoroutine(blinking(mapDictionary[Application.loadedLevelName]));

        gameObject.SetActive(false);

        mapraw.SetActive(false);
        objectivePoint.SetActive(false);
        
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

        objectivePoint.SetActive(false);

        objectiveList.Add(0, new float[] { -39, 38.7f }); //x axis, y axis
        objectiveList.Add(1, new float[] { -25.9f, 38.7f });
        objectiveList.Add(2, new float[] { -1.3f, 38.7f });
        objectiveList.Add(3, new float[] { -38.9f, 15.8f });
        objectiveList.Add(4, new float[] { -22.2f, 15.8f });
        objectiveList.Add(5, new float[] { -8.1f, 15.8f });
        objectiveList.Add(6, new float[] { 6.2f, 15.8f });
        objectiveList.Add(7, new float[] { 18.8f, 15.8f });
        objectiveList.Add(8, new float[] { -38.6f, 1.9f });
        objectiveList.Add(9, new float[] { -22.5f, 1.9f });
        objectiveList.Add(10, new float[] { -8.1f, 1.9f });
        objectiveList.Add(11, new float[] { 6.3f, 1.9f });
        objectiveList.Add(12, new float[] { 21.8f, -2.5f });
        objectiveList.Add(13, new float[] { 34.9f, -2.4f });
        objectiveList.Add(14, new float[] { -41.8f, -12.1f });
        objectiveList.Add(15, new float[] { -21.0f, -18.7f });
        objectiveList.Add(16, new float[] { -5.2f, -18.7f });
        objectiveList.Add(17, new float[] { 6.4f, -18.7f });
        objectiveList.Add(18, new float[] { -18.7f, -18.7f });
        objectiveList.Add(19, new float[] { 32.2f, -18.7f });
        objectiveList.Add(20, new float[] { 42.8f, -22.2f });
        objectiveList.Add(21, new float[] { -39.5f, -30.7f });
        objectiveList.Add(22, new float[] { -23.1f, -31.2f });
        objectiveList.Add(23, new float[] { -7.3f, -31.2f });
        objectiveList.Add(24, new float[] { 18.3f, -31.2f });
        objectiveList.Add(25, new float[] { 33.2f, -31.2f });
        objectiveList.Add(26, new float[] { 40.3f, -41.6f });
        objectiveList.Add(27, new float[] { 15.5f, -41.6f });
        objectiveList.Add(28, new float[] { -7.3f, -41.6f });
        objectiveList.Add(29, new float[] { -31.8f, -41.6f });
        objectiveList.Add(30, new float[] { 35.0f, 31.1f });
        objectiveList.Add(31, new float[] { 35.0f, 12.6f });
        objectiveList.Add(33, new float[] { -17.6f, -8.9f });
        objectiveList.Add(34, new float[] { -17.6f, 27.2f });
        system = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameController>();

	}
	
	// Update is called once per frame
	void Update () {
	}
}
