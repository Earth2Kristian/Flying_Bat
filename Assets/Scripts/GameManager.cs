using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Data;

public class GameManager : MonoBehaviour
{
    // Scoring System Variables
    public float score;
    public TMP_Text scoreText;
    
    // Timer System Variables
    public float timerCounts;
    public TMP_Text timerText;
    public TMP_Text timerText2;
    public TMP_Text finalScoreText;
    public TMP_Text finalScoreText2;

    // UI System Variables
    public GameObject playStartUI;
    public GameObject playTimeUI;
    public GameObject gameoverUI;

    private static GameManager instance = null;

    private void Start()
    {
        // The time will be set as 0 from the start of the game
        timerCounts = 0;

        // Texts has been set
        scoreText.text = " " + Mathf.Round(score);
        timerText.text = " " + Mathf.Round(timerCounts);

        // UIs has beens set by default
        playStartUI.SetActive(true);
        playTimeUI.SetActive(false);
        gameoverUI.SetActive(false);

        // Game will be temporary be paused until the game has start
        Time.timeScale = 0;
    }

    void Update()
    {
        // The timer will increase by 1 slowly
        timerCounts += 1 * Time.deltaTime;
        timerText.text = "TIME: " + Mathf.Round(timerCounts);
        timerText2.text = "TIME: " + Mathf.Round(timerCounts);
    }

    public void Play()
    {
        // This function will allow the game to play
        playTimeUI.SetActive(true);
        playStartUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        // This function will allow to stop the game when the bird collided
        gameoverUI.SetActive(true);
        finalScoreText.text = "YOUR TIME SCORE: " + Mathf.Round(timerCounts);
        finalScoreText2.text = "YOUR TIME SCORE: " + Mathf.Round(timerCounts);
        Time.timeScale = 0;
    }

    public void Replay()
    {
        // This function will allow the game to restart by reloading the scene
        SceneManager.LoadScene(0);

        // The timer will be reset to 0
        timerCounts = 0;
    }

    void Awake()
    {
        instance = this;
    }

    public static GameManager Instance
    {
        get
        {
            return instance;
        }
    }

}
