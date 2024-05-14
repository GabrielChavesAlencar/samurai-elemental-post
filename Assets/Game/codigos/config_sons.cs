using System.Collections;
using System;
using System.Linq;
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

    public Dropdown ddpResolution;
    public Dropdown ddpQuality;

    public Toggle tgWindown;

    private List<string> resolutions = new List<string>();
    private List<string> quality = new List<string>();
   
    // Start is called before the first frame update
    void Start()
    {
        master_slider.value = volume_master;
        music_slider.value = volume_music;
        efects_slider.value = volume_efeitos;
        tog.isOn = postpros;

        Resolution[] arrResolution = Screen.resolutions;
        foreach (Resolution r in arrResolution) {
            resolutions.Add(string.Format("{0} x {1}",r.width,r.height));
        }
        ddpResolution.AddOptions(resolutions);
        ddpResolution.value = (resolutions.Count - 1);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void mastersond(float num)
    {
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


    public void post(bool b) { postpros = b; }

    public void set_quality() { } 
    public void set_resolution() { } 
    public void set_windown_mode() { } 
}
