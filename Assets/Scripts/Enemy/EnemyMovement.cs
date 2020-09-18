using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        transform.parent.GetComponent<ClusterMovement>().OnChildCollision(collider);
    }
}
