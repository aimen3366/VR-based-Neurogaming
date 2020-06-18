using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncing : MonoBehaviour
{
    // Start is called before the first frame update
    public bool onGround;

   private Rigidbody rb;
    public float range;
    void Start()
    {
        onGround = true;
        
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        range = Random.Range(1.0f,100.0f);

        if(onGround)
        {
            //if (Input.GetButtonDown("Jump"))
            //{

            //    rb.velocity = new Vector3(-20f, 40f, 0f);
            //    onGround = false;
            //} 
            ///////////////////// for ranndom values//////////////////
            Debug.Log("Range Values" + range);
            if (range>10.0f || range<20.0f)
            {
                rb.velocity = new Vector3(-20f, 15f, 0f);
                onGround = false;
            }

            else if (range>30.0f || range<40.0f)
            {
                rb.velocity = new Vector3(-20f, 25f, 0f);
                onGround = false;
            }
            else if (range > 50.0f || range<60.0f)
            {
                rb.velocity = new Vector3(-20f, 35f, 0f);
                onGround = false;
            }

            else if (range> 70.0f || range<80.0f)
            {
                rb.velocity = new Vector3(-20f, 45f, 0f);
                onGround = false;
            }
            

            /////////////////////////for random values /////////////////////////////////
        }
    }

    private void OnCollisionEnter(Collision any)
    {
        any.gameObject.CompareTag("Ground");
         onGround = true;
        
    }


}
