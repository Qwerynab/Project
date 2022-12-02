using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody rb;

    public float ForwardForce = 50f;
    public float SidewaysForce = 25;
    public float JumpForce = 25;
    public bool AllowJump;
    public GameObject Camera;

    private void Update()
    {
        if (AllowJump && Input.GetKeyDown(KeyCode.Space) && transform.position.y < 1.1f)
        {
            rb.AddForce(Vector3.up * JumpForce, ForceMode.VelocityChange);
        }
        
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange );
        }

        if(Input.GetKey("a"))
        {
            rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
