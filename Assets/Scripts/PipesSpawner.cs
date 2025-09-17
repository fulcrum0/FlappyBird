using System.Collections;
using UnityEngine;

public class PipesSpawner : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] Bird bird;
    [SerializeField] GameObject pipes;
    [SerializeField] float maxY;
    [SerializeField] float minY;
    [SerializeField] float spawnInterval = 1.5f;


    void Start()
    {
        StartCoroutine(SpawnPipes());
    }

    IEnumerator SpawnPipes()
    {
        while (bird.isAlive)
        {
            float randomY = Random.Range(minY, maxY);
            Vector3 spawnPoint = new(4.5f, randomY, 0f);

            GameObject newPipe = Instantiate(pipes, spawnPoint, Quaternion.identity);

            Destroy(newPipe, 2.5f);

            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
