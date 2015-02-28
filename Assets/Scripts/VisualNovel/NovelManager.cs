using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NovelManager : MonoBehaviour {

	// Use this for initialization
    private Story currentStory;
    public VisualNovel button;
    private int path;
    public GameObject buttonway1;
    public GameObject buttonway2;
    private GameController system;
    public enum Storys
    {
        introstory
    }
    public Storys selectStory;
	void Start () {
        Initial();
	}
    public void getAnswerFromPlayer(int n)
    {
        bool isMission= false;
        int questID = 0;
        int r = currentStory.getPathWay(path,n,out isMission, out questID);
        if (isMission)
        {
            system.changeCurrentMission(questID);
        }
        path =r;
        if (r != -1)
        {
            button.setData(currentStory.getConversation(path), currentStory.getNameCharacter(path)
                ,currentStory.getCharacterPicture(path),currentStory.getCharacterPosition(path)
                ,currentStory.getBackground(path));
        }
    }
    public void checkStory()
    {
        if (button.currentnumberText == button.getMaxConversation() + 1)
                {
                    gameObject.SetActive(false);
                }
        if (button.currentnumberText == button.getMaxConversation())
        {
           
            if (!currentStory.checkHaveQuestion(path))
            {
                button.currentnumberText++;
                
            }
            else
            {
                string[] choices = currentStory.getChoice(path);
                
                if (choices.Length == 3)
                {
                    buttonway1.SetActive(true);
                    Text[] temp = buttonway1.GetComponentsInChildren<Text>();
                    for (int i = 0; i < temp.Length; i++)
                    {
                        temp[i].text = choices[i];
                    }
                }
                else
                {
                    buttonway2.SetActive(true);
                    Text[] temp = buttonway2.GetComponentsInChildren<Text>();
                    for (int i = 0; i < temp.Length; i++)
                    {
                        temp[i].text = choices[i];
                    }
                }
            }
        }
    }
    public void Initial()
    {
        system = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameController>();
        buttonway1.SetActive(false);
        buttonway2.SetActive(false);
        SetStory(selectStory);
        path = 1;
        if (currentStory != null)
        {
            //Debug.Log(currentStory.getCharacterPicture(path).Length + " " + currentStory.getCharacterPosition(path)+" "+ );
            button.setData(currentStory.getConversation(path), currentStory.getNameCharacter(path),
           currentStory.getCharacterPicture(path), currentStory.getCharacterPosition(path)
               , currentStory.getBackground(path));   
        }
       
    }
    public void SetStory(Storys n)
    {
        switch (n)
        {
            case Storys.introstory: currentStory = new IntroStory(); break;
            default: currentStory = new IntroStory(); break;
        }
    }
}
