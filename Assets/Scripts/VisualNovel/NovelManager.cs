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
        prologue,
        layerone,
        layeroneone,
        layeronetwo,
        layertwoone,
        layertwotwo,
        layertwothree,
        layertwofour,
        layerthreeone,
        layerthreetwo,
        layerthreethree,
        layerthreefour
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
                ,currentStory.getBackground(path),currentStory.getMusicBackground(path)
                ,currentStory.getCharacterMusic(path));
        }
    }
    public void checkStory()
    {
        if (button.currentnumberText == button.getMaxConversation() + 1)
                {
                    if (currentStory.GetHaveQuestinthelast())
                    {
                        system.changeCurrentMission(currentStory.GetQuestMissioninLast());
                    }
                    gameObject.SetActive(false);
                    Time.timeScale = 1;
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
                
                if (choices.Length == 1) 
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
        Time.timeScale = 0;
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
               , currentStory.getBackground(path),currentStory.getMusicBackground(path)
                ,currentStory.getCharacterMusic(path));   
        }
       
    }
    public void SetStory(Storys n)
    {
        switch (n)
        {
            case Storys.prologue: currentStory = new Prologue(); break;
            case Storys.layerone: currentStory = new LayerOne(); break;
            case Storys.layeroneone: currentStory = new LayerOneOne(); break;
            case Storys.layeronetwo: currentStory = new LayerOneTwo(); break;
            case Storys.layertwoone: currentStory = new LayerTwoOne(); break;
            case Storys.layertwotwo: currentStory = new LayerTwoTwo(); break;
            case Storys.layertwothree: currentStory = new LayerTwoThree(); break;
            case Storys.layertwofour: currentStory = new LayerTwoFour(); break;
            case Storys.layerthreeone: currentStory = new LayerThreeOne(); break;
            case Storys.layerthreetwo: currentStory = new LayerThreeTwo(); break;
            case Storys.layerthreethree: currentStory = new LayerThreeThree(); break;
            case Storys.layerthreefour: currentStory = new LayerThreeFour(); break;
            default: currentStory = new Prologue(); break;
        }
    }
}
