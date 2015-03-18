using UnityEngine;
using System.Collections;

public class PhoneCanvas : MonoBehaviour {
    public PhoneManage phone;
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
