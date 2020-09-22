using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float bulletSpeed;
    
    void FixedUpdate()
    {
        transform.position += transform.up * Time.deltaTime * bulletSpeed;
    }

    void OnTriggerEnter(Collider collider) {
        if(collider.gameObject.CompareTag("wall")){
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.CompareTag("enemy")){
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
