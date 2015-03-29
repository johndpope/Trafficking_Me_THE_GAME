using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class VisualNovel : MonoBehaviour {

	// Use this for initialization
    private string currentText;
    public int currentnumberText;
    public string[] textData;
    public string[] nameChar;
    public int[] emotionChoose;
    public Text display;
    public Text NameDisplay;
    private IEnumerator runText;
   // public Image target;
    private ImageController imageCon;
    private soundVisual soundEffect;
	void Awake () {
        currentText = "";
        imageCon = GetComponent<ImageController>();
        soundEffect = GetComponent<soundVisual>();
        runText = scollingText();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void ClickChangeText()
    {
        if (currentnumberText < textData.Length)
        {
            imageCon.UpdateRender(currentnumberText);
            soundEffect.UpdateSound(currentnumberText); 
            NameDisplay.text = nameChar[currentnumberText];
            StopCoroutine(runText);
            runText = scollingText();
            StartCoroutine(runText);
            currentnumberText++;
            
        }
        
    }
    private IEnumerator scollingText()
    {
        string displaytext = "";
        string temp = textData[currentnumberText];
        
        for (int i = 0; i < temp.Length; i++)
        {
            displaytext += temp[i];
            currentText = displaytext;
            display.text = currentText;
            yield return new WaitForSeconds(1 / (temp.Length*2));
        }
    }
    public int getMaxConversation()
    {
        return textData.Length;
    }
    public void setData(string[] data, string[] name, string[][] characters,Position[][] positions,string[] backgrounds, string[] soundBackground,string[] soundCharacter)
    {
        textData = data;
        nameChar = name;
        imageCon.addData(characters, positions,backgrounds);
        soundEffect.UpdateData(soundBackground, soundCharacter);
        currentnumberText = 0;
        NameDisplay.text = nameChar[currentnumberText];
        imageCon.UpdateRender(currentnumberText);
        soundEffect.UpdateSound(currentnumberText);
        StopCoroutine(runText);
        runText = scollingText();
        StartCoroutine(runText);
        currentnumberText = 1;

    }
    public void stopCorouVisual()
    {
        StopCoroutine(runText);
    }
}