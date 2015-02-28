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
   // public Image target;
    private ImageController imageCon;
	void Awake () {
        currentText = "";
        imageCon = GetComponent<ImageController>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void ClickChangeText()
    {
        if (currentnumberText < textData.Length)
        {
            //target.sprite = playerEmotion[emotionChoose[currentnumberText]];

            imageCon.UpdateRender(currentnumberText);
            NameDisplay.text = nameChar[currentnumberText];
            StopCoroutine(scollingText());
            StartCoroutine(scollingText());
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
    public void setData(string[] data, string[] name, string[][] characters,Position[][] positions,string[] backgrounds)
    {
        textData = data;
        nameChar = name;
        imageCon.addData(characters, positions,backgrounds);
        currentnumberText = 0;
        NameDisplay.text = nameChar[currentnumberText];
        imageCon.UpdateRender(currentnumberText);
        StopCoroutine(scollingText());
        StartCoroutine(scollingText());
        currentnumberText = 1;
    }
}