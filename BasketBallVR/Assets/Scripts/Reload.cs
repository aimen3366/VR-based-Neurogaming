using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Reload : MonoBehaviour
{
    public Text GameEndingText;
   
    void Start()
    {

     }
    void LateUpdate()
    {
        if(TimerScript.winn==1)
        {
            GameEndingText.text = "Win"; // show 'Win' message 

        }

        if (TimerScript.gameoverr==1)
        {

            GameEndingText.text = "GameOver"; // show 'GameOver' message


        }
    }
    public void reload()

    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

}
