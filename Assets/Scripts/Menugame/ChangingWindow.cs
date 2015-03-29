using UnityEngine;
using System.Collections;

public class ChangingWindow : MonoBehaviour
{

    // Use this for initialization
    public void changingWindow(int n)
    {
        switch (n)
        {
            case 1: Application.LoadLevel("LoadGame"); break;
            case 2: Application.LoadLevel("selectCharacter"); break;
            case 3: Application.LoadLevel("one"); break;
            case 4: Application.LoadLevel("Menugame"); break;
        }
    }
}
