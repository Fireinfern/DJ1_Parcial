using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChangeManager : MonoBehaviour
{
    public static SceneChangeManager instance;

    void Awake() {
        instance = this;
    }

    public void StartGame() {
        SceneChanger.ChangeScene("SeleccionScene");
    }

    public void ParadoYSinPolo() {
        PlayerPrefs.SetInt("lives", 1);
        SceneChanger.ChangeScene("GameScene");
    }
    public void PlayNormal() {
        PlayerPrefs.SetInt("lives", 4);
        SceneChanger.ChangeScene("GameScene");
    }

    public void GameOver() {
        SceneChanger.ChangeScene("GameOverScene");
    }

    public void ToMenu() {
        SceneChanger.ChangeScene("MenuScene");
    }
}
