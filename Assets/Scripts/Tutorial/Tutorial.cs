using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
public enum tutorialList
{
    control,escapse,thing,enemy
}
public class Tutorial : MonoBehaviour {
    public GameObject previousButton;
    public GameObject nextOneButton;
    public GameObject nextTwoButton;
    public Text previous;
    public Text nextOne;
    public Text nextTwo;
    public string[] infoTutorial;
    private List<string> controlTutorial;
    private List<string> escapeTutorial;
    private List<string> thingTutorial;
    private List<string> EnemyTutorial;
    private tutorialList currentTutorial;
    public Image picture;
    private int page;
	// Use this for initialization
	void Start () {
        initial();
        page = 0;
        Time.timeScale = 0;
        previousButton.SetActive(false);
        nextTwoButton.SetActive(false);
        picture.sprite = Resources.Load<Sprite>("tutorial/" + infoTutorial[page]);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void NextPicture()
    {
        if (page < infoTutorial.Length-1)
        {
            
            page++;
            if (page > 0)
            {
                nextOneButton.SetActive(false);
                previousButton.SetActive(true);
                nextTwoButton.SetActive(true);
            }
            picture.sprite = Resources.Load<Sprite>("tutorial/" + infoTutorial[page]);
        }
        else
        {
            page = 0;
            Time.timeScale = 1;
            gameObject.SetActive(false);
        }
        if (page == infoTutorial.Length - 1)
        {
            nextTwo.text = "End";
        }
        else
        {
            nextTwo.text = "Next";
        }
    }
    public void previousPicture()
    {
        if(page >0){
            page--;
            picture.sprite = Resources.Load<Sprite>("tutorial/"+infoTutorial[page]);
            nextTwo.text = "Next";
        }
        if(page == 0)
        {
            previousButton.SetActive(false);
            nextOneButton.SetActive(true);
            nextTwoButton.SetActive(false);
        }
    }
    public void initial()
    {
        controlTutorial = new List<string>();
        escapeTutorial = new List<string>();
        thingTutorial = new List<string>();
        EnemyTutorial = new List<string>();
        controlTutorial.Add("A1");
        controlTutorial.Add("A2");
        controlTutorial.Add("A3");
        escapeTutorial.Add("B1");
        escapeTutorial.Add("B2");
        escapeTutorial.Add("B3");
        thingTutorial.Add("C1");
        thingTutorial.Add("C2");
        thingTutorial.Add("C3");
        thingTutorial.Add("D1");
        thingTutorial.Add("D2");
        setTutorial(currentTutorial);
    }
    public void setTutorial(tutorialList story)
    {
        currentTutorial = story;
        if (story == tutorialList.control)
        {
            infoTutorial = controlTutorial.ToArray();
        }
        else if (story == tutorialList.escapse)
        {
            infoTutorial = escapeTutorial.ToArray();
        }
        else if (story == tutorialList.thing)
        {
            infoTutorial = thingTutorial.ToArray();
        }
        else if (story == tutorialList.enemy)
        {
            infoTutorial = EnemyTutorial.ToArray();
        }
    }
}
