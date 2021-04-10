using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_SoundMana : MonoBehaviour
{
    [SerializeField] AudioSource JellyBounce;
    [SerializeField] AudioSource JellyPop;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayBounce()
    {
        JellyBounce.Play();
    }

    public void PlayPop()
    {
        JellyPop.Play();
    }
}
