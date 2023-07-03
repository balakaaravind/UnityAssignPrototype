using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public GameObject player;
    Vector3 pos = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void LateUpdate()
    {

        pos = player.transform.position;
        pos.y = 0.72f;
        pos.z -= 2;
        gameObject.transform.position = pos;
    }
}
