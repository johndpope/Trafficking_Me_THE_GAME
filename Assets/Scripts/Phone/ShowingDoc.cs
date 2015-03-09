using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowingDoc : MonoBehaviour
{

    // Use this for initialization
    public Image result;
    PhoneManage system;
    string docName;
    void Start()
    {
        system = GameObject.FindGameObjectWithTag("Mobile").GetComponent<PhoneManage>();
    }
    public void setDocName(string docName)
    {
        this.docName = docName;
    }
    public void updateDocument(int i)
    {
        if (system.docManager.isDocCollected(i))
        {
            system.loadPage(11);    
            result.sprite = Resources.Load<Sprite>("doc/" + docName);
        }
        
    }

}
