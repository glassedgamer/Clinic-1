using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] GameObject enemy;

    [SerializeField] float spawnDelay = 1f;

    private void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnDelay, spawnDelay);
    }

    void SpawnEnemy()
    {
        Instantiate(enemy, this.transform.position, Quaternion.identity);
    }
}
