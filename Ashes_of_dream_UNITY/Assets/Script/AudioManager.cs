using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioMixer Music, Effects;
    public AudioSource Nivel_M, Ambientacion, Moneda;
    public static AudioManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void PlayAudio(AudioSource audio)
    {
        audio.Play();
    }
    // Start is called before the first frame update
    void Start()
    {
        AudioManager.instance.PlayAudio(AudioManager.instance.Nivel_M);
        AudioManager.instance.PlayAudio(AudioManager.instance.Ambientacion);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
