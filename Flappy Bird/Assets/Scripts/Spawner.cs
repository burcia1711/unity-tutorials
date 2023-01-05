using UnityEngine;
using UnityEngine.UIElements;

public class Spawner : MonoBehaviour
{
    private GameObject player;
    public GameObject prefab;
    public float spawnRate = 1f;
    public float minHeight = -5f;
    public float maxHeight = -1f;

    public Vector3 Position { get; private set; }

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()

    {
        Position = player.transform.position + new Vector3(20, 0, 0);
        GameObject pipes = Instantiate(prefab, new Vector3(Position.x, 0, -10), Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
    }

}
