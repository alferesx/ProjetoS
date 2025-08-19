using System.Collections;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject spike;
    public float spawnTime = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnLoop());
    }

    // Update is called once per frame
     IEnumerator SpawnLoop()
    {
        while (true)
        {
                Instantiate(spike, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
                yield return new WaitForSeconds(spawnTime); // espera antes do próximo spawn
        }
    }
}
