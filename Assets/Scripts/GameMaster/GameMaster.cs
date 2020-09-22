using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    private static GameMaster _instance = null;
    private int _score = 0;

    public GameObject enemyCluster;

    void Start()
    {
        if (GameMaster._instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            GameMaster._instance = this;
        }
    }

    void Update()
    {
        Debug.Log("Is Game Complete: " + this.IsGameComplete());
        Debug.Log("Score: " + this._score);
        if (this.IsGameComplete())
        {
            Debug.Break();
        }
    }

    public static GameMaster GetInstance()
    {
        return GameMaster._instance;
    }

    public int IncrementScore(int scoreDelta)
    {
        return this._score += scoreDelta;
    }

    public bool IsGameComplete()
    {
        EnemyCluster cluster = this.enemyCluster.GetComponent<EnemyCluster>();
        return cluster.enemyCount == 0;
    }
}
