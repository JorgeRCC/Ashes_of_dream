using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioMixer musicMixer, effectsMixer;
    public AudioSource Nivel_M, Ambientacion, Moneda, Vida;
    public static AudioManager instance;

    [Range(-80, 10)]
    public float masterVol, effectsVol;
    public Slider masterSldr, effectsSldr;

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

        masterSldr.value = masterVol;
        effectsSldr.value = effectsVol;

        masterSldr.minValue = -60;
        masterSldr.maxValue = 10;

        effectsSldr.minValue = -60;
        effectsSldr.maxValue = 10;
    }

    // Update is called once per frame
    void Update()
    {
        MasterVolume();
        EffectsVolume();
    }
    public void MasterVolume() 
    {
        musicMixer.SetFloat("masterVolume", masterSldr.value);
    }
    public void EffectsVolume()
    {
        effectsMixer.SetFloat("effectsVolume", effectsSldr.value);
    }
}
