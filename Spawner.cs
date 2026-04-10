/* using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 2.8f;
    public float heightOffset = 2f;

    void Start()
    {
        InvokeRepeating("SpawnPipe", 1f, spawnRate);
    }

    void SpawnPipe()
    {
        float y = Random.Range(-heightOffset, heightOffset);
        Instantiate(pipePrefab, new Vector3(8, y, 0), Quaternion.identity);
    }
}
*/
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 2.5f;
    public float heightOffset = 2f;

    private bool isRunning = false;

    void Start()
    {
        isRunning = true;
        SpawnPipe(); // ALWAYS spawn first pipe immediately
        InvokeRepeating(nameof(SpawnPipe), spawnRate, spawnRate);
    }

    void SpawnPipe()
    {
        if (!isRunning) return;

        float y = Random.Range(-heightOffset, heightOffset);
        Instantiate(pipePrefab, new Vector3(10, y, 0), Quaternion.identity);
    }

    void OnDisable()
    {
        CancelInvoke();
    }
}