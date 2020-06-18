using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class  TimerScript : MonoBehaviour {

	public Text timerText;
	public float time = 1200;
	public bool stopTimer,stopSpinner;
    public static int winn = 0;
    public static int gameoverr= 0;
 
    void Start ()
	{
     
        
            StartCoroutine(StartCoundownTimer());
        
	}

	public IEnumerator StartCoundownTimer()
	{
        
            if (!stopTimer  )
            {
         
            
                
                time -= Time.deltaTime;
                yield return new WaitForSeconds(0.01f);
                string minutes = Mathf.Floor(time / 60).ToString("00");
                string seconds = (time % 60).ToString("00");
                string fraction = ((time * 100) % 100).ToString("000");
                timerText.text = "Time Left: " + minutes + ":" + seconds;
                if (time < 10.0f)
                {
                    timerText.color = Color.red;
                }
                StartCoroutine(StartCoundownTimer());
            }
        
	}

	void LateUpdate()
	{
        if (time <= 0.5f && !stopTimer)
        {
           
            stopTimer = true;
            
            if (time != 0 && ScoreArea.currentScore == 5)
            {

                Debug.Log("Win");
                winn = 1;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
               
    
            }

            if (stopTimer && ScoreArea.currentScore < 5)

            {

                Debug.Log("GameOver");
                gameoverr = 1;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

            }

        }
        if (time != 0 && ScoreArea.currentScore == 5)
        {

            Debug.Log("Win");
            winn = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


        }
    }
   
    // public void ReloadGame()
   // {
     //   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   // }
}
