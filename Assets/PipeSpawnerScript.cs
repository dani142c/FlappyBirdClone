using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 2f;
    private float time = 0f;
    public float heightOffset = 10f;
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (time < spawnRate){
            time += Time.deltaTime;
        }
        else {
            spawnPipe();
            time = 0;
        }
    }

    void spawnPipe(){
        float lowestY = transform.position.y - heightOffset;
        float highestY = transform.position.y + heightOffset;
        Instantiate(pipePrefab, new Vector3(transform.position.x, Random.Range(lowestY, highestY), 0), transform.rotation);
    }
}
