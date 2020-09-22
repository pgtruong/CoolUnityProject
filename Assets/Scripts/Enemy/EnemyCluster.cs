using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCluster : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int startingEnemyCount;
    public int numRows;
    public int enemyCount;

    private GameObject[] _enemies;

    void Start(){
        this.enemyCount = startingEnemyCount;
        this._enemies = new GameObject[startingEnemyCount];
        for(int i=0; i < startingEnemyCount; i++){
            GameObject superEvilEnemy = Instantiate(enemyPrefab, transform.position + (new Vector3(i, 0, 0) * 1.5f), Quaternion.identity);
            this._enemies[i] = superEvilEnemy;
            superEvilEnemy.transform.SetParent(this.gameObject.transform);
        }
    }

    public GameObject[] GetEnemies()
    {
        return this._enemies;
    } 
}
