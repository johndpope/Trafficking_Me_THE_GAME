using UnityEngine;
using System.Collections;

public class TapSave : MonoBehaviour
{

    // Use this for initialization
    ClickSaveLoad game;
    public GameObject saveWindow;
    void Start()
    {
        game = GetComponent<ClickSaveLoad>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && saveWindow.activeSelf == false)
        {

            if (Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition)) &&
                Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition)).tag == "Save")
            {
                saveWindow.SetActive(true);
                game.loadTopic();
                Time.timeScale = 0;
                PhoneCanvas phone = GameObject.FindGameObjectWithTag("PhoneCanvas").GetComponent<PhoneCanvas>();
                phone.setShow(false);
            }
        }
    }
    public void closeMenu()
    {
        Time.timeScale = 1;
        saveWindow.SetActive(false);
        PhoneCanvas phone = GameObject.FindGameObjectWithTag("PhoneCanvas").GetComponent<PhoneCanvas>();
        phone.setShow(true);
    }
}
