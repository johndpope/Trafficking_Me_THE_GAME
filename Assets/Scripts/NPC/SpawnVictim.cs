using UnityEngine;
using System.Collections;

public class SpawnVictim : MonoBehaviour
{

    public int mapID;
    public SpawnV position;
    private GameController system;
    public GameObject cage;
    // Use this for initialization
    void Start()
    {
        system = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameController>();

        if (system.HaveVictimInMap(mapID, position))
        {
            if (!system.IsAlreadyHelpVictim(mapID, position))
            {
                cage.SetActive(true);
                GameObject victim = (GameObject)Instantiate(Resources.Load("Prefabs/Victim"), transform.position + new Vector3(0, 1, 0), Quaternion.Euler(0, 0, 0));
                victim.GetComponent<VictimScript>().mapID = mapID;
                victim.GetComponent<VictimScript>().position = position;
                victim.GetComponent<VictimScript>().ID = system.GetVictimID(mapID, position);
                victim.GetComponent<VictimScript>().cage = cage;

                GameObject visualNovel = (GameObject)Instantiate(Resources.Load("Prefabs/Visualnovel"), transform.position + new Vector3(0, 1, 0), Quaternion.Euler(0, 0, 0));
                victim.GetComponent<VictimScript>().SetVisual(visualNovel);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
