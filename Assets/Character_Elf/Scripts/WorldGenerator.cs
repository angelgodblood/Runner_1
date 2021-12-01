using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenerator : MonoBehaviour
{
    public GameObject[] roadsPrefabs;
    private List<GameObject> activePrefabs = new List<GameObject>();
    private float spawnPos = 0;
    private float roadsLength = 70;

    [SerializeField] private Transform player;
    
    private int startPrefabs = 6;
    void Start()
    {
        for (int i = 0; i < startPrefabs; i++)
        {
            SpawnRoads(Random.Range(0,roadsPrefabs.Length));
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (player.position.z -1 > spawnPos - (startPrefabs * roadsLength))
        {
            SpawnRoads(Random.Range(0, roadsPrefabs.Length));
            DeletePrefabs();
        }
            
    }

    private void SpawnRoads(int roadsIndex)
    {
        GameObject newPrefab = Instantiate(roadsPrefabs[roadsIndex], transform.forward * spawnPos, transform.rotation);
        activePrefabs.Add(newPrefab);
        spawnPos += roadsLength;
    }

    private void DeletePrefabs()
    {
        Destroy(activePrefabs[0]);
        activePrefabs.RemoveAt(0);
    }
}
