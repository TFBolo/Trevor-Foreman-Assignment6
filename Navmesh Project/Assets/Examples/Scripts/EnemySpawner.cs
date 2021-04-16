using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public static bool isEnemy;
    public GameObject enemy;

    void Start()
    {
        isEnemy = false;
    }

    void Update()
    {
        if (!isEnemy)
        {
            Instantiate(enemy, gameObject.transform.position, gameObject.transform.rotation);
            isEnemy = true;
        }
    }
}
