using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverController : MonoBehaviour
{
    private float TimeToMenu = 3.0f;
    
    [SerializeField]
    private TMP_Text ScoreText;

    void Awake() {
        ScoreText.text = "Score: " + PlayerPrefs.GetInt("score").ToString();
        PlayerPrefs.DeleteAll();
    }

    void Update()
    {
        UpdateTime();
    }

    void UpdateTime(){
        if(TimeToMenu <= 0.0f){
            SceneChangeManager.instance.ToMenu();
            return;
        }
        TimeToMenu -= Time.deltaTime;
    }
}
