 using UnityEngine;
 using System.Collections;
 using UnityEngine.UI;
public class StatusBar : MonoBehaviour
{

     CharacterEmotion playeremo;
     public Vector2 pos = new Vector2(20, 60);
     public Vector2 size = new Vector2(60, 20);
     public Texture2D emptyTex;
     public Texture2D fullTex;
     int encorage;
     int trustiness;
     int bravery;
     public int selected;
     float status;

     
     void OnGUI() {
         playeremo = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterEmotion>();
         playeremo.getCharacterStat(out encorage, out trustiness, out bravery);
         float posX = Screen.width * pos.x;
         float posY = Screen.height * pos.y;
         switch (selected)
         {
             case 1: status = bravery/10f;
                 break;
             case 2: status = encorage/10f;
                 break;
             case 3: status = trustiness/10f;
                 break;

         }

 
         //draw the background:
         GUI.BeginGroup(new Rect(posX, posY, size.x, size.y));
         GUI.Box(new Rect(0, 0, size.x, size.y), emptyTex);
         
     //draw the filled-in part:
         GUI.BeginGroup(new Rect(0, 0, size.x * status, size.y));
         GUI.Box(new Rect(0, 0, size.x * status, size.y), fullTex);
 
         GUI.EndGroup();
         GUI.EndGroup();
     }
 
     // Use this for initialization
     void Start () {
     }
 
     // Update is called once per frame
     void Update() {
     }
 }