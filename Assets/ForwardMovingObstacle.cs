using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMovingObstacle : MonoBehaviour
{
    public Rigidbody rigidBody;

    public float Movement = 5f;
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        rigidBody.AddForce(0, 0, Movement * Time.deltaTime);

        
    }
}
