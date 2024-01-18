using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // escキーが押されたら StartGame メソッドを呼び出す
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            RestartGame();
        }
    }
    void RestartGame() 
     { 
          /* GameScene�����[�h*/ SceneManager.LoadScene("start"); 
     }
}
