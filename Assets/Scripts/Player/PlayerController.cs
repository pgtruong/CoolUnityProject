using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Settings")]
    public float speed = 10;
    [Header("Bullet Settings")]
    public GameObject bulletPrefab;
    public float bulletSpeed = 5;
    private bool canMoveLeft = true;
    private bool canMoveRight = true;
    private GameObject shotBullet;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && shotBullet == null){
            shotBullet = Instantiate(bulletPrefab, transform.position + transform.up, Quaternion.identity);
            shotBullet.GetComponent<BulletMovement>().bulletSpeed = bulletSpeed;
        }
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A) && canMoveLeft){
            transform.position -= transform.right * Time.deltaTime * speed;
        }

        else if (Input.GetKey(KeyCode.D) && canMoveRight){
            transform.position += transform.right * Time.deltaTime * speed;            
        }        
    }

    void OnTriggerEnter(Collider collider) {
        if(collider.gameObject.CompareTag("wall")){
            if (transform.position.x < 0)
                canMoveLeft = false;
            
            else if (transform.position.x > 0)
                canMoveRight = false;
        }
    }

    void OnTriggerExit(Collider collider) {
        if(collider.gameObject.CompareTag("wall")){
            if (transform.position.x < 0)
                canMoveLeft = true;
            
            else if (transform.position.x > 0)
                canMoveRight = true;
        }
    }
}
