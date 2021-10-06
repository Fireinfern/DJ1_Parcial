using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField]
    private TMP_Text LivesText;

    private int lives;

    private int points = 0;

    void Awake() {
        instance = this;
        lives = PlayerPrefs.GetInt("lives");
        LivesText.text = "Lives: " + lives.ToString();
    }

    public void deductLives(int lostLives){
        lives -= lostLives;
        if(lives <= 0){
            PlayerPrefs.SetInt("score", points);
            SceneChangeManager.instance.GameOver();
        }
        LivesText.text = "Lives: " + lives.ToString();
    }

    public void awardPoints(int gainedPoints){
        points += gainedPoints;
    }
}
