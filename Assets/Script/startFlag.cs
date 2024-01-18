using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startFlag : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // スペースキーが押されたら StartGame メソッドを呼び出す
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartGame();
        }
    }

    void StartGame() 
     { 
          /* GameScene�����[�h*/ SceneManager.LoadScene("Game"); 
     }
}
