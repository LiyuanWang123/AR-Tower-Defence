using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerControlDelete : MonoBehaviour {
    private Text NewTextBox;

	// Use this for initialization
	void Start () {
        NewTextBox = GameObject.Find("DashboradText").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetDelete()
    {
        BuildManager.delete = true;
        NewTextBox.text = "Select a tower to destroy";
    }
}
