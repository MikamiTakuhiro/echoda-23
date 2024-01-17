using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManeger : MonoBehaviour
{
    [SerializeField] Text Score;

    //[SerializeField] TimeManager time;

    // Start is called before the first frame update
    void Start()
    {
        int score = TimeManager._resultscore * 100;
        Score.text = score.ToString() + "点";
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
