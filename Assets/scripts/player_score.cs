using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_score : MonoBehaviour
{
    private float score = 0.0f;

    private int difficultyLevel = 1;
    private int maxdifficultyLevel = 10;
    private int scoreToNextLevel = 10;

    public Text scoreText;


    private bool isDead = false;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
       
    {
        if (isDead)
            return;
        if (score >= scoreToNextLevel)
            levelUp();
        score += Time.deltaTime*difficultyLevel;
        scoreText.text = ((int)score).ToString();
    }
    void levelUp()
    {
        if (difficultyLevel == maxdifficultyLevel)
            return;
        scoreToNextLevel *=2;
        difficultyLevel++;
        GetComponent<player_motor>().SetSpeed(difficultyLevel);
        Debug.Log(difficultyLevel);
    }
 
}

