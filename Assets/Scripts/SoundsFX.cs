using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsFX : MonoBehaviour
{
    private AudioSource destroySound;

    void Start(){
        destroySound = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision){

        destroySound.Play();

    }
}
