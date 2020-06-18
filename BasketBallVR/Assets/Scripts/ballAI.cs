using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballAI : MonoBehaviour
{
    // Start is called before the first frame update
    
    Rigidbody rb;
    //public float time = 3.0f;
    float Counter = 0;
    //public float Attention;
    public float Meditation;
    MindwaveDataModel Data;
    void Start()
    {
      rb=GetComponent<Rigidbody>();  
      //StartCoroutine(Example());
    }

     //Update is called once per frame
     void Update()
     {


        //Attention = Data.eSense.attention;
        
        Debug.Log("Attention Level is =" + MindwaveUI.m_MindwaveData.eSense.attention);
        
        //
           //{
          //rb.AddForce(-10f,50f,0);

//                 if(time >= 0){
  //                time -= Time.deltaTime;
    //             return;
      //   }else{
              //Do Something after clock hits 0
        // rb.isKinematic = true;
        // }*/
       //// if(Input.GetKeyDown(KeyCode.Space))
       if(MindwaveUI.m_MindwaveData.eSense.attention>60)
         { //Debug.Log("its B1 ");
          Counter = Counter +1;
          Debug.Log("Counter is = "+ Counter);
         
          if(Counter==1)
          {rb.AddForce(-250f,1200f,0);
          StartCoroutine(Delay());}
         
         else if(Counter==2)
          {   rb.isKinematic = false;
              rb.AddForce(-250f,1200f,0);
              StartCoroutine(Delay());}
         
         else if(Counter==3)
          {   rb.isKinematic = false;
              rb.AddForce(-700f,1500f,0);
              StartCoroutine(Delay());
              }
         
         } 
            
            //  yield return new WaitForSeconds(5);
             //rb.isKinematic = true;
         

        }
     
  IEnumerator Delay()
      {
         
         
          yield return new WaitForSeconds(0.5f);
          rb.isKinematic = true;
          if(Counter==3)
          {
            rb.isKinematic = false;
          }
          Debug.Log("its working");
    }
    IEnumerator Delay1()
    {


        yield return new WaitForSeconds(0.5f);
        //Attention = Data.eSense.attention;
    }


}
