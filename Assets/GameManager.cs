using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public static GameManager instance;
    public static bool gameOver;
    public int gold;
    public Text goldText;
    public int startGold = 600;
    public Text scoreText;
    public int score;

    // Use this for initialization
    void Start () {
        score = 0;
        gameOver = false;
        gold = startGold;
	}
	
	// Update is called once per frame
	void Update () {
        goldText.text = "GOLD: " + gold;
        scoreText.text = "Score: " + score;
        if (gameOver)
        {
            Debug.Log("Game Over!!!");
            return;
        }
	}

    void Awake()
    {
        if (instance != null)
        {
            return;
        }
        instance = this;
    }
}
