using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePause : MonoBehaviour {
    public static bool paused;
	// Use this for initialization
	void Start () {
        paused = false;
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void Pause()
    {
        
        paused = true;
 
        if (paused)
        {
            Time.timeScale = 0;
        }

    }

    public void Resume()
    {
        paused = false;
        Time.timeScale = 1;
    }
}
