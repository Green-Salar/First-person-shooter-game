using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioRecieverScript : MonoBehaviour
{
    public AudioSource source;
    public AudioClip[] sounds;
    void leftfootfall()
    {
        source.PlayOneShot(sounds[0]);
    }
    void rightfootfall()
    {
          source.PlayOneShot(sounds[0]);
    }
    void rise(){
          source.PlayOneShot(sounds[1]);
    }
    void land(){
          source.PlayOneShot(sounds[2]);
    }
}
