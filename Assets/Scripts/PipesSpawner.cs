using UnityEngine;

public class PipesSpawner : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] GameObject pipes;

    void Update()
    {

    }

    void SpawnPipe()
    {
        Instantiate(pipes, )
    }
}
