using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MissionDetail : MonoBehaviour {

	// Use this for initialization
    public GameController gameSystem;
    public Text topic;
    public Text description;
    public Quest current;
	void Start () {
        
        

	}
	public void UpdateCurrentMission(){
        gameSystem = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameController>();
        current = gameSystem.getCurrentQuest();
        topic.text = current.QuestName;
        description.text = current.QuestDescription+"\n";
        if (current.GetType() == typeof(FindingQuest))
        {
            FindingQuest temp = (FindingQuest)(current);
            string[] name = new string[1];
            int[] sum = new int[1];
            int[] total = new int[1];
            temp.getItemQuest(out name,out sum, out total);
            for(int i=0;i<name.Length && i<sum.Length;i++){
                bool result = temp.checkCollectwithPrefab(name[i]);
                Debug.Log(result + "kuyynananasss");
                if (result)
                {
                    description.text += "<color=#008000>" + name[i] + " " +sum[i] +"/"+total[i]+ "</color>\n";
                }
                else
                {
                    description.text += "<color=#FF0000>" + name[i] + " " + sum[i] +"/"+total[i]+"</color>\n";
                }
                
            }
        }
    }
}
