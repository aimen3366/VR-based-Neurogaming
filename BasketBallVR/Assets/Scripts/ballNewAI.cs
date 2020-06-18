using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ballNewAI : MonoBehaviour
{
    Rigidbody rb; // For basketball rigidbody
    public bool onGround; // it's a flag
    
   public Slider myslider; // for showing attention value in the form of bar

    void Start()
    {
        onGround = true;
        rb = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {

       myslider.value = MindwaveUI.m_MindwaveData.eSense.attention; // Assign attention value to slider

        if (onGround)                     // if onGround flag is true
        {

            /////////////////////// Used for Testing /////////////////////////// 
            //if (Input.GetButtonDown("Jump"))
            //{
            //    Debug.Log("key pressed");
            //    rb.velocity = new Vector3(0f, 8f, 5f);
            //    onGround = false;
            //}
            /////////////////////// Above code of block is Used for Game Testing ///////////////////////////


            //////////////////////////////////////////////////////// Block1 ///////////////////////////////////////////////////////////////////////////////////////////
            if (MindwaveUI.m_MindwaveData.eSense.attention >= 1 && MindwaveUI.m_MindwaveData.eSense.attention <= 10) //Range Check for attention values between 1 to 10   
            {

                rb.velocity = new Vector3(0f, 0.5f, 0.1f); // Apply velocity on the basketball, x=0, y=0.5f and z=0.1f  
                onGround = false;                          // set 'onGround' flag is false 



            }
            //////////////////////////////////////////////////////// Block1_End ///////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////// Same As Block1 ////////////////////////////////////////////////////////////////////////////////////// 
            if (MindwaveUI.m_MindwaveData.eSense.attention >= 10 && MindwaveUI.m_MindwaveData.eSense.attention <= 20)
            {

                rb.velocity = new Vector3(0f, 1.0f, 0.2f);
                onGround = false;


            }
            if (MindwaveUI.m_MindwaveData.eSense.attention >= 20 && MindwaveUI.m_MindwaveData.eSense.attention <= 30)
            {

                rb.velocity = new Vector3(0f, 1.5f, 0.3f);
                onGround = false;


            }

            if (MindwaveUI.m_MindwaveData.eSense.attention >= 40 && MindwaveUI.m_MindwaveData.eSense.attention <= 50)
            {

                rb.velocity = new Vector3(0f, 2.0f, 0.4f);
                onGround = false;


            }
            if (MindwaveUI.m_MindwaveData.eSense.attention >= 50 && MindwaveUI.m_MindwaveData.eSense.attention <= 60)
            {

                rb.velocity = new Vector3(0f, 2.5f, 0.5f);
                onGround = false;


            }
            if (MindwaveUI.m_MindwaveData.eSense.attention >= 60 && MindwaveUI.m_MindwaveData.eSense.attention <= 70)
            {

                rb.velocity = new Vector3(0f, 3.0f, 0.6f);
                onGround = false;


            }
            if (MindwaveUI.m_MindwaveData.eSense.attention >= 70 && MindwaveUI.m_MindwaveData.eSense.attention <= 80)
            {

                rb.velocity = new Vector3(0f, 3.5f, 0.7f);
                onGround = false;


            }
            if (MindwaveUI.m_MindwaveData.eSense.attention >= 80 && MindwaveUI.m_MindwaveData.eSense.attention <= 90)
            {

                rb.velocity = new Vector3(0f, 4.0f, 0.8f);
                onGround = false;


            }
            if (MindwaveUI.m_MindwaveData.eSense.attention >= 90 && MindwaveUI.m_MindwaveData.eSense.attention <= 100)
            {

                rb.velocity = new Vector3(0f, 4.5f, 0.9f);
                onGround = false;


            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }



    }
    private void OnCollisionEnter(Collision any)    //Function called when ball collide with plane
     {
        any.gameObject.CompareTag("Ground");        //Check ball collide with plane , 'Ground' tag is assign to the plane  
        onGround = true;                            // set 'onGround' flag true 

    }


}
