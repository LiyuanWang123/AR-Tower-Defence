using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerNode : MonoBehaviour {

    private GameObject turret;
    private Vector3 offset = new Vector3( 0, 0.1f, 0 );
    BuildManager buildManager;
    GameManager gameManager;
    private Text NewTextBox;

    void Start()
    {
        buildManager = BuildManager.instance;
        gameManager = GameManager.instance;
        NewTextBox = GameObject.Find("LOG").GetComponent<Text>();

    }

    void OnMouseDown()//buildTower
    {
        if (buildManager.getTower() == null)
        {
            return;
        }

        if (turret != null && !BuildManager.upgrade && !BuildManager.delete)
        {
            NewTextBox.text = "Cant' build here! Already Occupid";
            Debug.Log("Cant' build here! Already Occupid");
            return;
        }
        if (turret == null && BuildManager.delete)
        {
            NewTextBox.text = "Nothing to Delete";
            Debug.Log("Nothing to Delete");
            BuildManager.delete = false;
            return;
        }
        if (turret == null && BuildManager.upgrade)
        {
            NewTextBox.text = "Nothing to Upgrade";
            Debug.Log("Nothing to Upgrade");
            BuildManager.upgrade = false;
            return;
        }
        if (turret != null && BuildManager.delete)
        {
            NewTextBox.text = "Tower Deleted";
            Debug.Log("Tower Deleted");
            Destroy(turret);
            BuildManager.delete = false;
            return;
        }
        if (BuildManager.upgrade)
        {
            NewTextBox.text = "Upgrade Success";
            Debug.Log("Upgrade Success!");
            turret.GetComponent<Turret>().upgrade();
            gameManager.gold -= 150;
            BuildManager.upgrade = false;
            return;
        }


        GameObject choseTower = buildManager.getTower();
        if (gameManager.gold < buildManager.getCost(choseTower))
        {
            NewTextBox.text = "Insufficient Fund!!";
            Debug.Log("Insufficient Fund!!");
            return;
        }
        turret = (GameObject)Instantiate(choseTower, transform.position+offset, transform.rotation);
        gameManager.gold -= buildManager.getCost(choseTower);
        Debug.Log("Current Gold: " + gameManager.gold);
    }

}
