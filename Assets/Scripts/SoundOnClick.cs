using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnClick : MonoBehaviour
{
    [SerializeField] AudioClip click;

    AudioSource audioSource;

    void Start()
    {
        DontDestroyOnLoad(this);

        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            audioSource.PlayOneShot(click);
        }
    }
}
