using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public int pointValue = 1;

    void OnDestroy()
    {
        if (GameMaster.GetInstance())
        {
            GameMaster.GetInstance().IncrementScore(this.pointValue);
        }
        this.transform.parent.GetComponent<EnemyCluster>().enemyCount -= 1;
    }
}
