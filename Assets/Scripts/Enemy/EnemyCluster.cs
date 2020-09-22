using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCluster : MonoBehaviour
{
    public GameObject enemy;
    public int numEnemies;
    public int numRows;

    void Start(){
        for(int i=0; i < numEnemies; i++){
            GameObject superEvilEnemy = Instantiate(enemy, transform.position + (new Vector3(i, 0, 0) * 1.5f), Quaternion.identity);
            superEvilEnemy.transform.SetParent(this.gameObject.transform);
        }
    }
}
