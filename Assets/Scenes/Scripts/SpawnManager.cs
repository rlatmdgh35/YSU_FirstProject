using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject Enemy1Prefab;
    public GameObject Enemy2Prefab;

    void Start()
    {
        SpawnEnemy(Enemy1Prefab, new Vector3(1, 2, 0));
        SpawnEnemy(Enemy2Prefab, new Vector3(-1, 1, 0));
    }

    public void SpawnEnemy(GameObject prefab, Vector3 inVec)
    {
        GameObject enemy = Instantiate(prefab);
        enemy.transform.position = inVec;
        enemy.GetComponent<Enemy>().Move();
    }


}
