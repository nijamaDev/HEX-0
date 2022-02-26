using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCrontroller : MonoBehaviour
{
    private AudioSource destroySound;

    // Start is called before the first frame update
    void Start()
    {
        destroySound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
