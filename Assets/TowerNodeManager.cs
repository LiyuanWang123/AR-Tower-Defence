using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerNodeManager : MonoBehaviour {

    private bool click = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        click = !click;
        if(click)
        {
            NewTowerBuilder.isDisplay = true;
        }
        else
        {
            NewTowerBuilder.isDisplay = false;
        }
    }

   }
