using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartControl : MonoBehaviour {
    public Canvas CanvasObject;
    public static bool StartPushed;

    // Use this for initialization
    void Start () {
        CanvasObject = GameObject.Find("StartCanvas").GetComponent<Canvas>();
        CanvasObject.GetComponent<Canvas>().enabled = true;
        StartPushed = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GameStart()
    {
        StartPushed = true;
        CanvasObject.GetComponent<Canvas>().enabled = false;
    }
}
