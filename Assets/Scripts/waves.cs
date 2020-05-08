using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class waves : MonoBehaviour
{
    public Transform IntruderBase;
    public Transform enemy_1;
    public Transform goblin;
    public Transform orc;

    public Text countDownText;
    public Text statusText;
    

    public float timeSpawn;
    private float startCountDown = 3f;
    private float countDown = 0f;
    private float respCountDown = 6f;
    private float[] waveTime;
    private int waveNum = 10;
    private int num = 0;
    private bool startedCount;
    private bool started;
    private float roundTime;
    private float factor = 0;

    // Use this for initialization
    void Start()
    {
        
        startedCount = false;
        started = false;
        countDown = startCountDown;
        waveTime = new float[] { 5f, 4f, 3f, 3f, 3f, 3f, 4f, 3f, 4f, 3f };
        statusText.text = "Loading";
        roundTime = 0;
        factor = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (factor / 45 >= 1 && roundTime != 0)
        {
            factor = 0;
            Debug.Log("Enemy Enhanced!!");
            Enemy.damage = Enemy.damage * 1.2f;
            Enemy.startHealth = Enemy.startHealth * 1.5f;
        }
        if (GameManager.gameOver)
        {
            statusText.text = "Game Over!";
            return;
        }
        
        if (started && countDown <= 0f)
        {
            StartCoroutine(SpawnWave());
            num++;
            if (num >= waveTime.Length)
            {
                countDown = Random.Range(2f,5f);
            }
            else
            {
                countDown = waveTime[num];
                Debug.Log(num + "th wave respawning!");
            }
        }

        if (countDown <= 0f && !startedCount)
        {
            statusText.text = "Prepare!";
            countDown = respCountDown;
            startedCount = true;
            Debug.Log("Prepare for Defense!");
        }

        if (startedCount && countDown <= 0f)
        {
            statusText.text = "Waves coming!";
            startedCount = false;
            StartCoroutine(SpawnWave());
            num++;
            countDown = waveTime[num];
            started = true;
            Debug.Log("Start respawning!");
            
        }

        

        countDown -= Time.deltaTime;
        
        if (!started)
        {
            countDownText.text = Mathf.Floor(countDown).ToString();
        }else
        {
            factor += Time.deltaTime;
            roundTime += Time.deltaTime;
            countDownText.text = Mathf.Floor(roundTime).ToString();
        }
        //Debug.Log("countDown = " + countDown);
    }

    IEnumerator SpawnWave()
    {
        int number = (int)Random.Range(1, 3);
        if (roundTime > 60)
        {
            number = (int)Random.Range(3, 6);
        }
        Debug.Log("wave = " + number);
        for (int i = 0; i < number; i++)
        {
            
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
    }

    void SpawnEnemy()
    {
        Instantiate(goblin, IntruderBase.position, IntruderBase.rotation);
    }
}
