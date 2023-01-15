using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    public Text TimerText;
    public float playtime;
    public bool timerStart;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        playtime = 0;
        timerStart = false;
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
    }

    public void GameStart()
    {
        print("게임 시작");
        GameObject.Find("Panel").SetActive(false);
        timerStart = true;
        Time.timeScale = 1;
    }

    public void Timer()
    {
        if (timerStart)
        {
            playtime += Time.deltaTime;
            TimerText.text = "Play Time: " + playtime.ToString("N2") + "초";
        }
    }
}
