using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerActive : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Timerobj;
    void Start()
    {
        Timerobj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (MindwaveUI.TimeTrigger == 1)
        {

            Timerobj.SetActive(true);



        }

    }
}
