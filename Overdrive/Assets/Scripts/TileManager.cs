using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject[] tilePrefabs;

    private Transform playerTransform;
    private float spawnZ = -10.0f;
    private float tileLength = 10.0f;
    private float safeZone = 15.0f;
    private int amnTilesOnScreen = 7;

    private List<GameObject> activeTiles;

    // Start is called before the first frame update
    void Start()
    {
        activeTiles = new List<GameObject>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        for (int i =0; i< amnTilesOnScreen; i++)
        {
            SpawnTile();
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerTransform.position.z - safeZone > (spawnZ - amnTilesOnScreen * tileLength))//generates infinite bridge as player moves
        {
            SpawnTile();
            DeleteTiles();
        }
    }

    private void SpawnTile(int prefabIndex = -1)
    {
        GameObject go;
        go = Instantiate(tilePrefabs[0]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ += tileLength;
        activeTiles.Add(go);
    }

    private void DeleteTiles()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
}
