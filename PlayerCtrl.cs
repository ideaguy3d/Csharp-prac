using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour {

    public float speed;
    private Rigidbody rb;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    // Destroy everything that enters the trigger
    void OnTriggerEnter(Collider otherCollider)
    {
        /*
         
            Destroy(otherCollider.gameObject);

            if (other.gameObject.CompareTag("Player"))
            {
                Destroy(other.gameObject);
            }

            gameObject.SetActive(false);

        */

        if(otherCollider.gameObject.CompareTag("Pick Up"))
        {
            otherCollider.gameObject.SetActive(false);
        }

    }

}
