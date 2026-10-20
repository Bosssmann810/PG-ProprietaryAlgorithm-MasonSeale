using JetBrains.Annotations;
using UnityEngine;

public class CloudMover : MonoBehaviour
{
    public GameObject cloud;
    public int speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = Random.Range(1, 10);
        if(speed < 3)
        {
            cloud.transform.localScale = cloud.transform.localScale * 2;
        }
        if(speed > 6)
        {
            cloud.transform.localScale = cloud.transform.localScale * 0.5f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        cloud.transform.position = new Vector3 (cloud.transform.position.x + speed *Time.deltaTime, cloud.transform.position.y, cloud.transform.position.z);
    }
}
