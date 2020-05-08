using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public static float damage = 10;
    public static float startHealth = 100;
    public float health;
    private float oriHealth;
    public static int reward = 25;

    private Transform target;
    GameManager gameManager;

    [Header("Unity Stuff")]
    public Image healthBar;

    private void Start()
    {
        oriHealth = startHealth;
        health = startHealth;
        gameManager = GameManager.instance;
    }
    public void TakeDamage(int amount)
    {
        health -= amount;

        healthBar.fillAmount = health / oriHealth;
        if(health <= 0)
        {
            Die();
            gameManager.gold += reward;
        }

        if (GameManager.gameOver)
        {
            return;
        }
    }

    void Die()
    {
        gameManager.score += 50;
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {

    }

    
}
