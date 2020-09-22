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
}
