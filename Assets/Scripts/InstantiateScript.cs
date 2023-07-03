using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateScript : MonoBehaviour
{
    public GameObject[] objects;
    public Transform planeTransform;
    private int randomIndex;
    public float instanceInterval = 3f;
    private float timer = 0f; 
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= instanceInterval)

        {
            Vector3 randomPosition = GetRandomPosition();
            int randomIndex = GetObjectIndex();

            Instantiate(objects[randomIndex], randomPosition, Quaternion.identity);

            timer = 0f;
        }

    }

    private int GetObjectIndex()
    {
        randomIndex = Random.Range(0, objects.Length);
        return randomIndex;
    }
    private Vector3 GetRandomPosition()
    {
        Vector3 planeSize = planeTransform.localScale;
        float randomX = Random.Range(-planeSize.x / 2f, planeSize.x / 2f);
        float randomZ = Random.Range(-planeSize.z / 2f, planeSize.z / 2f);

        Vector3 randomPosition = planeTransform.position + new Vector3(randomX, 0f, randomZ);

        return randomPosition;
    }
}
