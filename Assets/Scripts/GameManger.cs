using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManger : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI HealthTxt;
    public GameObject gameOverUi;

    // Start is called before the first frame update
    void Start()
    {
        

    }
    private void OnEnable()
    {
        EventManager.onEnemyCollided.AddListener(EnemyCollided);
        EventManager.onHealthCollided.AddListener(HealthCollided);



    }

    private void HealthCollided()
    {
        if (score <= 100)
        {
            score += 10;
            Debug.Log("health  " + score);
        }
    }

    private void EnemyCollided()
    {
       if (score>= 10)
        {
            score -= 10;
            Debug.Log("healttth  " + score);
        }
    }

    
    private void OnDisable()
    {
        EventManager.onEnemyCollided.RemoveListener(EnemyCollided);
        EventManager.onHealthCollided.RemoveListener(HealthCollided);
    }


    // Update is called once per frame
    void Update()
    {
        if (score >= 50)
        {
            gameOverUi.SetActive(true);
        }
        HealthTxt.text = "SCORE : "+score.ToString();

    }
}
