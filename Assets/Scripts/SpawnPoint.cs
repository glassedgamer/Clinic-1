using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] GameObject enemy;

    [SerializeField] float spawnDelayMin = 1f;
    [SerializeField] float spawnDelayMax = 5f;
    float randSpawnDelay;

    private void Start()
    {
        randSpawnDelay = Random.Range(spawnDelayMin, spawnDelayMax);
        InvokeRepeating("SpawnEnemy", randSpawnDelay, randSpawnDelay);
    }

    void SpawnEnemy()
    {
        Instantiate(enemy, this.transform.position, Quaternion.identity);

        randSpawnDelay = Random.Range(spawnDelayMin, spawnDelayMax);
        print(randSpawnDelay);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawSphere(transform.position, 0.5f);
    }
}
