using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class changeTextRun : MonoBehaviour {

	// Use this for initialization
    private CharacterController controller;
    public Text text;
	void Start () {
        controller = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterController>();
	}
    public void changeText()
    {
        controller.changeRun();
        if (controller.getRun())
        {
            text.text = "Walk";
        }
        else
        {
            text.text = "Run";
        }
    }
}
