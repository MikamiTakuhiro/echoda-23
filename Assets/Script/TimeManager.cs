using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    public int countdownMinutes = 1;
    private float countdownSeconds;
    private Text timeText;

    public static int _resultscore = 0;
    public static int _missnumber = 0;
    public static List<string> misswords = new List<string>();
    [SerializeField] TypingManager typingM;

    // Start is called before the first frame update
    void Start()
    {
        timeText = GetComponent<Text>();
        countdownSeconds = countdownMinutes * 60;
    }

    // Update is called once per frame
    void Update()
    {
        countdownSeconds -= Time.deltaTime;
        var span = new TimeSpan(0, 0, (int)countdownSeconds);
        timeText.text = span.ToString(@"mm\:ss");

        if(countdownSeconds <= 0)
        {
            _resultscore = typingM._score;
            _missnumber = typingM._missCount;
            misswords.AddRange(typingM._missList);
            SceneManager.LoadScene("Score"); 
        }
    }
}
