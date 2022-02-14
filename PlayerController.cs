using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody PlayerRb;
    public float speed = 9;
    public int scores = 1;
    public float jumpForce = 10;

    public bool OnGround = true;
    public bool OnRide = false;

    public float timeCal;
    void Start()
    {
      PlayerRb = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 9);
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right);
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {

            Debug.Log("test function");
            PlayerRb.AddRelativeForce(2000, 4000, 0);

        }


    }


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Animal")) //condition for adding scores
        {
            scores *= 25;
            Debug.Log("scores =" + scores); //scorces display

            OnRide = true; // i.e. player is riding the animal

        }

    }
    //public void PlayerJump()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {

    //        Debug.Log("test function");
    //        PlayerRb.AddRelativeForce(2000, 4000, 0);

    //    }
    //}

   
}
