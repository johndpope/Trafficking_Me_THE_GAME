using UnityEngine;
using System.Collections;

public class soundVisual : MonoBehaviour {

	// Use this for initialization
    private AudioClip currentBackgroundSound;
    private AudioClip currentcharacterSound;
    private string currentBackground;
    private string currentcharacter;
    public AudioSource soundSystem;
    private string[] dataSoundBackground;
    private string[] datacharacterSound; 
	void Start () {
        soundSystem.loop = true;
	}
	
	// Update is called once per frame
	void Update () {
	}
    public void UpdateSound(int currentText)
    {
        currentBackgroundSound = Resources.Load<AudioClip>("Music/" + dataSoundBackground[currentText]);
        currentcharacterSound = Resources.Load<AudioClip>("Music/" + datacharacterSound[currentText]);
        if(dataSoundBackground[currentText] == currentBackground){
            currentBackground = dataSoundBackground[currentText];
        }else{
            if (dataSoundBackground != null)
            {
                soundSystem.Stop();
                //Debug.Log("change" + soundSystem.isPlaying);
                soundSystem.clip = currentBackgroundSound;
                soundSystem.Play();
                currentBackground = dataSoundBackground[currentText];
            }
        }
        if (currentcharacterSound != null)
        {
            soundSystem.PlayOneShot(currentcharacterSound);
        }  
    }
    public void UpdateData(string[] backgroundData, string[] soundcharacterData)
    {
        datacharacterSound = soundcharacterData;
        dataSoundBackground = backgroundData;
    }
    public void StopSound()
    {
        soundSystem.Stop();
    }
}
