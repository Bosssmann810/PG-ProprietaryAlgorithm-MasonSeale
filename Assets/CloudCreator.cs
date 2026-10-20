using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class CloudCreator : MonoBehaviour
{
    public GameObject cloudA;
    public GameObject cloudB;
    public GameObject cloudC;
    public Transform spawnMin;
    public Transform spawnMax;

    public float cloudDensity;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(CloudSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        cloudDensity -=Time.deltaTime *0.005f;
    }
    IEnumerator CloudSpawner()
    {
        while (true)
        {
            SpawnCloud();
            yield return new WaitForSeconds(cloudDensity);
        }
    }
    public void SpawnCloud()
    {
        int cloudShape = Random.Range(0, 3);
        if(cloudShape == 0)
        {
            GameObject cloud = Instantiate(cloudA);
            RandomizePosition(cloud);
        }
        if(cloudShape == 1)
        {
            GameObject cloud = Instantiate(cloudB);
            RandomizePosition(cloud);
        }
        if (cloudShape == 2)
        {
            GameObject cloud = Instantiate(cloudC);
            RandomizePosition(cloud);
        }
    }
    public void RandomizePosition(GameObject cloud)
    {
        float pos = Random.Range(spawnMin.position.z, spawnMax.position.z);
        cloud.transform.position = new Vector3(spawnMin.position.x,spawnMin.position.y, pos);
    }
}
