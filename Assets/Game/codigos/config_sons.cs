using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class config_sons : MonoBehaviour
{
    public AudioMixer mixer;
    public static float volume_master;
    public static float volume_music;
    public static float volume_efeitos;

    public Slider master_slider;
    public Slider music_slider;
    public Slider efects_slider;

    public static bool postpros;
    public Toggle tog;
    public void mastersond(float num) {
        volume_master = num;

        mixer.SetFloat("volume_master", num);
    }
    public void musica(float num)
    {
        volume_music = num;

        mixer.SetFloat("volume_musica", num);
    }
    public void sound_efeitos(float num)
    {
        volume_efeitos = num;

        mixer.SetFloat("volume_efeitos", num);
    }

    // Start is called before the first frame update
    void Start()
    {
        master_slider.value = volume_master;
        music_slider.value = volume_music;
        efects_slider.value = volume_efeitos;
        tog.isOn = postpros;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void post(bool b) { postpros = b; }
}
