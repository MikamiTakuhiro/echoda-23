using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MIssWords : MonoBehaviour
{
    [SerializeField] Text Miss_words;
    // Start is called before the first frame update
    void Start()
    {
        Miss_words.text = "ミスしたワード：" + string.Join(", ", TimeManager.misswords);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
