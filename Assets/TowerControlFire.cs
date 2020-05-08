using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TowerControlFire : MonoBehaviour {
    private Text NewTextBox;
    // Use this for initialization
    void Start () {
        NewTextBox = GameObject.Find("DashboradText").GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetFireTower()
    {
        BuildManager.fire = true;
        NewTextBox.text = "Building Fire tower";
    }
}
