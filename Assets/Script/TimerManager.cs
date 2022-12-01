using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerManager : MonoBehaviour
{
    

    [Header("Component")]
    public TextMeshProUGUI GameViewTime;
    public TextMeshProUGUI PauseMenuTime;
    public GameObject PauseMenuUI;
    public GameObject GameViewUI;
    public GameObject MainMenuUI;

    [Header("Timer Settings")]
    public float currentTime;
    public bool countDown;

    [Header("Limit Settings")]
    public bool hasLimit;
    public float timerLimit;
    public bool GameIsPaused = false;



    private void Update()
    {
        
        currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;

        if(hasLimit && ((countDown && currentTime <= timerLimit) || (!countDown && currentTime >= timerLimit)))
        {
            currentTime = timerLimit;
            SetTimerText();
            enabled = false;
        }

        SetTimerText();

        if(PauseMenuUI.activeInHierarchy)
        {
            Time.timeScale = 0f;
            GameIsPaused = true;
        }
        if(GameViewUI.activeInHierarchy)
        {
            Time.timeScale = 1f;
            GameIsPaused = false;
        }
        if (MainMenuUI.activeInHierarchy)
        {
            Time.timeScale = 0f;
            currentTime = 0;
        }
        
    }

    private void SetTimerText()
    {
        GameViewTime.text = string.Format("{00:00}:{01:00}", Mathf.Floor(currentTime / 59), currentTime % 59);
        PauseMenuTime.text = GameViewTime.text;
    }

    void Pause()
    {
        
    }
}
