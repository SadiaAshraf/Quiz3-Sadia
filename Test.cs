using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Rigidbody PlayerRb;
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody>();
    }

  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Debug.Log("test function");
            PlayerRb.AddRelativeForce(200, 400, 0);

        }
    }
    public void playerMovement()
    {

    }
}
