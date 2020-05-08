using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour {
    public static BuildManager instance;

    public static bool fire = false;
    public static bool upgrade = false;
    public static bool delete = false;
    public int cost;
    public GameObject defaultTower;
    public GameObject fireTower;
    private GameObject chosenTower;

    public GameObject getTower()
    {
        if (fire)
        {
            chosenTower = fireTower;
        }
        else
        {
            chosenTower = defaultTower;
        }
            return chosenTower;
    }
	void Start () {
        chosenTower = defaultTower;
        cost = 100;
    }
	
    void Awake()
    {
        if (instance != null && !upgrade)
        {
            return;
        }

        instance = this;
    }

    public int getCost(GameObject turret)
    {
        if (fire)
        {
            cost = 300;
            fire = false;
        }else if (upgrade)
        {
            cost = 150;
            
        }
        else if (delete)
        {
            cost = 0;
            delete = false;
        }
        else
        {
            cost = 100;
        }
        return cost;
    }

     public void SetTurretToBuild (GameObject turret)
    {
        chosenTower = turret;
    }
}
