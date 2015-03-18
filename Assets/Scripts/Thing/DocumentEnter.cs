using UnityEngine;
using System.Collections;

public class DocumentEnter : MonoBehaviour
{

    // Use this for initialization
    public PhoneManage phone;
    public int docNumber;

    void Start()
    {
        phone = GameObject.FindGameObjectWithTag("PhoneCanvas").GetComponent<PhoneCanvas>().phone;
    }


    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D e)
    {
        if (e.tag == "Player")
        {
            if (phone != null && !phone.docManager.isDocCollected(docNumber))
            {

                phone.setWarnmingFindDoc(true,docNumber);
            }
        }

    }
    void OnTriggerExit2D(Collider2D e)
    {

        if (e.tag == "Player")
        {
            if (phone != null)
            {

                phone.setWarnmingFindDoc(false, -1);
            }
        }
    }
}
