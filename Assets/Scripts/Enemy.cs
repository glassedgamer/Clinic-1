using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    GameObject player;

    [SerializeField] NavMeshAgent enemyAgent;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        enemyAgent.SetDestination(player.transform.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == player)
        {
            Destroy(gameObject);
        }
    }

}
