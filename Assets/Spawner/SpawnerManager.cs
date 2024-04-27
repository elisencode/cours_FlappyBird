using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    [SerializeField]
    GameObject PipePrefab;
    [SerializeField]
    float delai = 1f;
    
    void Start()
    {
        InvokeRepeating("SpawnPipe", 0f, delai);
    }

   void SpawnPipe()
    {
        Instantiate(PipePrefab);
    }

    public void StopSpawn()
    {
        CancelInvoke();
    }

    
}
