using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreArea : MonoBehaviour
{

    public GameObject Myplayer1;
    public GameObject Myplayer2;
    public GameObject Myplayer3;
    public GameObject Myplayer4;
    public GameObject Myplayer5;
    //public Transform SpawnPoint;
    public GameObject score;
    public GameObject attempts;
    public static int currentScore;
    void Start()
    {
        
        Myplayer1.SetActive(true);
        Myplayer2.SetActive(false);
        Myplayer3.SetActive(false);
        Myplayer4.SetActive(false);
        Myplayer5.SetActive(false);
        //Myplayer.transform.position = SpawnPoint.transform.position;
    }
    void OnTriggerEnter()
    {

  
        currentScore = int.Parse(score.GetComponent<Text>().text) + 1;
        score.GetComponent<Text>().text = currentScore.ToString();

        int currentAttempts = int.Parse(attempts.GetComponent<Text>().text) -1;
        attempts.GetComponent<Text>().text = currentAttempts.ToString();

        if (currentScore == 1)
        {
            Myplayer1.SetActive(false);
            Myplayer2.SetActive(true);
        }

        if (currentScore == 2)
        {
            Myplayer2.SetActive(false);
            Myplayer3.SetActive(true);
        }

        if (currentScore == 3)
        {
            Myplayer3.SetActive(false);
            Myplayer4.SetActive(true);
        }

        if (currentScore == 4)
        {
            Myplayer4.SetActive(false);
            Myplayer5.SetActive(true);
        }

        if (currentScore == 5)
        {
            Myplayer5.SetActive(false);

        }



        // Myplayer1.SetActive(false);
      //  StartCoroutine(wait());

    }
   /* IEnumerator wait()
    {
        yield return new WaitForSeconds(0.1f);
       // Myplayer.SetActive(true);

        if (currentScore == 1)
        {
            Myplayer1.SetActive(false);
            Myplayer2.SetActive(true);
        }

        if (currentScore == 2)
        {
            Myplayer2.SetActive(false);
            Myplayer3.SetActive(true);
        }

        if (currentScore == 3)
        {
            Myplayer3.SetActive(false);
            Myplayer4.SetActive(true);
        }

        if (currentScore == 4)
        {
            Myplayer4.SetActive(false);
            Myplayer5.SetActive(true);
        }

        if (currentScore == 5)
        {
            Myplayer5.SetActive(false);
            
        }

        //Myplayer.transform.position = SpawnPoint.transform.position;

    }*/



}
