using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameoverControl : MonoBehaviour {
    public Canvas CanvasObject;

    // Use this for initialization
    void Start () {
        CanvasObject = GameObject.Find("GameoverCanvas").GetComponent<Canvas>();
        CanvasObject.GetComponent<Canvas>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		if(GameManager.gameOver)
        {
            CanvasObject.GetComponent<Canvas>().enabled = true;
        }
	}
}
