using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissManager : MonoBehaviour
{
    [SerializeField] Text Miss_number;

    // Start is called before the first frame update
    void Start()
    {
        int missnumber = TimeManager._missnumber;
        Miss_number.text = "ミスした回数：" + missnumber.ToString() + "回";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
