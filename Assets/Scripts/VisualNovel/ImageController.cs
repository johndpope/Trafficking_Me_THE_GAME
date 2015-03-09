using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ImageController : MonoBehaviour {

    
	// Use this for initialization
    private string[][] talker;
    private Position[][] pos;
    private string[] backgrounds;
    public Image[] render;
    public Image background;
	// Update is called once per frame
    public void UpdateRender(int n)
    {
        for (int i = 0; i < render.Length; i++)
        {
            render[i].sprite = (Sprite)Resources.Load("default/blank", typeof(Sprite));
        }
        for (int j = 0; j < talker[n].Length; j++)
        {
            if (pos[n][j] == Position.left)
            {
                render[0].sprite = (Sprite)Resources.Load("character/" + talker[n][j], typeof(Sprite));
            }
            else if (pos[n][j] == Position.middle)
            {
                render[1].sprite = (Sprite)Resources.Load("character/" + talker[n][j], typeof(Sprite));
            }
            else if (pos[n][j] == Position.right)
            {
                render[2].sprite = (Sprite)Resources.Load("character/" + talker[n][j], typeof(Sprite));
            }
       }
       background.sprite = Resources.Load<Sprite>("background/" + backgrounds[n]);

        
    }
    public void addData(string[][] character,Position[][] position, string[] background){
        talker = character;
        pos = position;
        backgrounds = background;
    }
    public void checkResources(int n)
    {
        if(Resources.Load<Sprite>("image/"+backgrounds[n]) == null){
            Debug.Log("Error: cannot download file");
        }
    }
}
