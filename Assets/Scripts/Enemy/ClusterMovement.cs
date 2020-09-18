using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClusterMovement : MonoBehaviour
{
    public float initialSpeed = 2f;
    public float additionalSpeedOnBounce = 1f;
    public float maxSpeed = 20f;
    public float dropDistancePerBounce = 1;

    private Vector3 _moveDirection;
    private float _speed;

    void Start()
    {
        this._speed = this.initialSpeed;
        this._moveDirection = new Vector3(1, 0, 0);
    }

    void FixedUpdate()
    {
        gameObject.GetComponent<Rigidbody>().velocity = this._moveDirection * this._speed;
    }

    public void OnChildCollision(Collider collider)
    {
        if(collider.gameObject.CompareTag("wall"))
        {
            this._moveDirection *= -1;
            if (this._speed + this.additionalSpeedOnBounce > this.maxSpeed)
            {
                this._speed = this.maxSpeed;
            }
            else if (this._speed != this.maxSpeed)
            {
                this._speed += this.additionalSpeedOnBounce;
            }
            gameObject.transform.position -= this.dropDistancePerBounce * transform.up;
        }
    }
}
