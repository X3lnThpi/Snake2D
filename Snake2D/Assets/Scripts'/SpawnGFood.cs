using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGFood : MonoBehaviour
{

    public GameObject foodPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 3, 4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        Instantiate(foodPrefab, new Vector2(Random.Range(-10.0f, 10.0f), Random.Range(-4.0f, 4.0f)), Quaternion.identity);
    }
}
