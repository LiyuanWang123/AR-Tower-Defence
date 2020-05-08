using UnityEngine;

public class shop : MonoBehaviour {

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void BuyDefaultTower ()
    {    
        buildManager.SetTurretToBuild(buildManager.defaultTower);
    }

    public void BuyFireTower()
    {
        buildManager.SetTurretToBuild(buildManager.fireTower);
    }
}
