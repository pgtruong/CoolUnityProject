using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    private bool canMoveLeft = true;
    private bool canMoveRight = true;

    void Start()
    {
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A) && canMoveLeft)
        {
            transform.position -= transform.right * Time.deltaTime * speed;
        }

        else if (Input.GetKey(KeyCode.D) && canMoveRight)
        {
            transform.position += transform.right * Time.deltaTime * speed;            
        }
    }

    void OnTriggerEnter(Collider collider) {
        if(collider.gameObject.CompareTag("Wall")){
            if (transform.position.x < 0)
                canMoveLeft = false;
            
            else if (transform.position.x > 0)
                canMoveRight = false;
        }
    }

    void OnTriggerExit(Collider collider) {
        if(collider.gameObject.CompareTag("Wall")){
            if (transform.position.x < 0)
                canMoveLeft = true;
            
            else if (transform.position.x > 0)
                canMoveRight = true;
        }
    }
}
