using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TowerControl : MonoBehaviour {
    private Text NewTextBox;
    // Use this for initialization
    void Start () {
        NewTextBox = GameObject.Find("DashboradText").GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetDefaultTower()
    {
        BuildManager.fire = false;
        NewTextBox.text = "Building Normal tower";
    }
}
