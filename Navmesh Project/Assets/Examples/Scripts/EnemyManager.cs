using UnityEngine;
using UnityEngine.AI;

public class EnemyManager : MonoBehaviour
{
    public NavMeshAgent e_Agent;
    public Transform player;
    public GameObject self1;
    public GameObject self2;

    void Start()
    {
        player = GameObject.Find("HumanoidAgent").GetComponent<Transform>();
    }

    void Update()
    {
        if (Time.time > 1f)
        {
            e_Agent.destination = player.position;
        }
        self1.transform.Rotate(1f, 0f, 0f);
        self2.transform.Rotate(0f, 0f, 1f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameManager.lives -= 1;
            EnemySpawner.isEnemy = false;
            Destroy(gameObject);
        }
    }
}
