using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewTowerBuilder : MonoBehaviour {

    // Use this for initialization
    private GameObject turret;
    private Vector3 offset = new Vector3(0, 0.1f, 0);
    BuildManager buildManager;
    GameManager gameManager;


    public static bool isDisplay = false;

    void Start () {
        GetComponent<SpriteRenderer>().enabled = false;
        buildManager = BuildManager.instance;
        gameManager = GameManager.instance;
    }
	
	// Update is called once per frame
	void Update () {
        transform.up = Camera.main.transform.position - transform.position;
        transform.forward = -Camera.main.transform.up;
        if (isDisplay)
        {
            GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            GetComponent<SpriteRenderer>().enabled = false;
        }
	}
    private void OnMouseDown()
    {
        if (buildManager.getTower() == null)
        {
            return;
        }
        if (turret != null)
        {
            Debug.Log("Cant' build here! Already Occupid");
            return;
        }
        GameObject choseTower = buildManager.getTower();
        if (gameManager.gold < buildManager.getCost(choseTower))
        {
            Debug.Log("Insufficient Fund!!");
            return;
        }

        BuildManager.fire = true;
        turret = (GameObject)Instantiate(choseTower, transform.position + offset, transform.rotation);
        gameManager.gold -= buildManager.getCost(choseTower);
        Debug.Log("Current Gold: " + gameManager.gold);
        GetComponent<SpriteRenderer>().enabled = false;
    }
}
