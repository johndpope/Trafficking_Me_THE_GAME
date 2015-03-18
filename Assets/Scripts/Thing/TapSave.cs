using UnityEngine;
using System.Collections;

public class TapSave : MonoBehaviour
{

    // Use this for initialization
    ClickSaveLoad game;
    void Start()
    {
        game = GetComponent<ClickSaveLoad>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            if (Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition)) &&
                Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition)).tag == "Save")
            {
                game.Savegame(1);
                Debug.Log("save game!!");

            }
        }
    }
}
