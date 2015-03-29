using UnityEngine;
using System.Collections;

public class PhoneCanvas : MonoBehaviour {
    public PhoneManage phone;
    public GameObject mobileIcon;
    public GameObject run;
    public GameObject map;
    public GameObject tutorial;
    //public GameObject eventSystem;
    public bool checking;
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        
    }

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        /*if (!checking)
        {
            checking = true;
        }*/
        
	}
    public void setShow(bool n)
    {
        if (Time.timeScale == 0)
        {
            phone.CloseAllPage();
            phone.gameObject.SetActive(n);
            mobileIcon.SetActive(n);
            run.SetActive(n);
            map.SetActive(n);
        }
        else
        {
            mobileIcon.SetActive(n);
            run.SetActive(n);
            map.SetActive(n);
        }
    }
}
