using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StatDetail : MonoBehaviour {

    CharacterEmotion playeremo;
    public Text encorageout;
    public Text trustinessout;
    public Text braveryout;
    int encorage;
    int trustiness;
    int bravery;
    void Start()
    {
        playeremo = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterEmotion>();
        playeremo.getCharacterStat(out encorage, out trustiness, out bravery);
        encorageout.text = "Encourage :  " + encorage;
        trustinessout.text = "Trustiness : " + trustiness;
        braveryout.text = "Bravery :"+bravery;
    }
	
	// Update is called once per frame
	void Update () {
        updateStatText();
	}

    public void updateStatText()
    {
        playeremo.getCharacterStat(out encorage, out trustiness, out bravery);
        encorageout.text = "Encourage :  " + encorage;
        trustinessout.text = "Trustiness : " + trustiness;
        braveryout.text = "Bravery :" + bravery;
    }
}
