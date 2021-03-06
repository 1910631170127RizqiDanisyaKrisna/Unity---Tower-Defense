using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioPlayer : MonoBehaviour
{
    private static audioPlayer _instance = null;

    public static audioPlayer Instance

    {

        get

        {

            if (_instance == null)

            {

                _instance = FindObjectOfType<audioPlayer> ();

            }

 

            return _instance;

        }

    }

 

    [SerializeField] private AudioSource _audioSource;

    [SerializeField] private List<AudioClip> _audioClips;

 

    public void PlaySFX (string name)

    {

        AudioClip sfx = _audioClips.Find (s => s.name == name);

        if (sfx == null)

        {

            return;

        }

 

        _audioSource.PlayOneShot (sfx);

    }
}
