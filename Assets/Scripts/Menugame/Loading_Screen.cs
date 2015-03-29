using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Loading_Screen : MonoBehaviour
{

    private bool gameLoading;
    public Sprite[] loadingScreen;
    public int t;
    public Image image;
    // Use this for initialization
    void Start()
    {
        gameLoading = true;
        t = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (Application.isLoadingLevel)
        {
            gameLoading = true;
        }
        else
        {
            gameLoading = false;

        }
        if (gameLoading)
        {
            try
            {
                t = Random.Range(0, loadingScreen.Length);

                image.sprite = loadingScreen[t];
                image.gameObject.SetActive(true);
            }
            catch
            {

            }
        }
    }
    public bool gameloading
    {
        set
        {
            gameLoading = gameloading;
        }
        get
        {
            return gameLoading;
        }
    }
}
