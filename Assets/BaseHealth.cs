using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseHealth : MonoBehaviour {
    public static float health;
    public int startBaseHealth = 1;
    public Image healthBar;
    // Use this for initialization
    void Start () {
        health = startBaseHealth;
    }
	
	// Update is called once per frame
	void Update () {
        healthBar.fillAmount = health / startBaseHealth;

        if (health <= 0f)
        {
            gameOver();
        }
	}

    void gameOver()
    {
        GameManager.gameOver = true;
    }
}
