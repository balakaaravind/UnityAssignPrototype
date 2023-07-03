using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisonChecking : MonoBehaviour
{
    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            gameObject.SetActive(false);
            source.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
