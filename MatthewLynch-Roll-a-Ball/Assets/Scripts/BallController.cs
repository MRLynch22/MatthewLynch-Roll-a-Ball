using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    public float speed;
    private Rigidbody _rigidBody;


    // Start is called before the first frame update
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump"))
        {
            
        }

        Vector2 moveVector = Vector2.zero;
        moveVector.x = Input.GetAxis("Horizontal");
        moveVector.y = Input.GetAxis("Vertical");

        _rigidBody.AddForce(new Vector3(moveVector.x, 0, moveVector.y) * speed, ForceMode.Force);
    }
}
