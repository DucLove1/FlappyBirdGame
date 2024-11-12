using UnityEditor;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float SpawnRate = 1f;
    public float minHeight = -0.5f;
    public float maxHeight = 0.5f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), SpawnRate,SpawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }
    private void Spawn()
    {
        GameObject pipes = Instantiate(prefab,transform.position,Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
    }
}
