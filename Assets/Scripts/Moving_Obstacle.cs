using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Obstacle : MonoBehaviour
{
    public Rigidbody rb;

    public float Movement = 10f;
    
  
    void FixedUpdate()
    {
        
        rb.AddForce(Movement * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        var gameobject = GameObject.Find("Moving Obstacle").transform.position;

        Vector3 endpoint = new Vector3(4.00f * Time.deltaTime, 1.50f, 64.42f);

        

        if ((gameobject - endpoint).magnitude >= 4.00f)
        {
            
            Movement = 0f;
        }

      

     
    }
}
