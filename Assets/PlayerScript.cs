using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rigidBody;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.fixedTime * Input.GetAxis("Vertical") / 50);
        transform.Translate(Vector3.right * Time.fixedTime * Input.GetAxis("Horizontal") / 50);

        /* 
        if (Input.GetKeyDown("space"))
        {
            rigidBody.AddForce(Vector3.up * 2 00f);
        }
         */
    }
}
