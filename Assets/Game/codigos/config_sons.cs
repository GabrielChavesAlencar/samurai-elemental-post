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

   


    public Toggle tgWindown;

    public List<string> resolutions = new List<string>();
    public List<Vector2> resolucoes = new List<Vector2>();
    public List<string> quality = new List<string>();

    public Text resolucao_text;
    public Text qualidade_text;

    public int num_quali;
    public int num_reso;
    public int num_lingua;
    // Start is called before the first frame update
    void Start()
    { 
        master_slider.value = volume_master;
        music_slider.value = volume_music;
        efects_slider.value = volume_efeitos;
        tog.isOn = postpros;

        

        Resolution[] arrResolution = Screen.resolutions;
        foreach (Resolution r in arrResolution) {
            resolutions.Add(string.Format("{0}X{1}",r.width,r.height));
        }
      //  ddpResolution_tmp.AddOptions(resolutions);
    //    ddpResolution_tmp.value = (resolutions.Count - 1);
        
        quality = QualitySettings.names.ToList<string>();
     //   ddpQuality_tmp.AddOptions(quality);
     //   ddpQuality_tmp.value = QualitySettings.GetQualityLevel();

        num_quali = quality.Count-1;
        num_reso = resolutions.Count-1;
        //print(resolutions[0]);
        //print(quality[0]);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (resolutions != null)
        {
            resolucao_text.text = resolutions[num_reso];
        }
        if (quality != null)
        {
            qualidade_text.text = quality[num_quali];
        }
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

    public void set_windown_mode() {
        if (tgWindown.isOn) { Screen.fullScreen = false; }
        else { Screen.fullScreen = true; }
    }
    public void mudar_qualidade(int num) { 
        num_quali += num;
        if (num_quali >= quality.Count) { num_quali = 0; } 
        if (num_quali < 0) { num_quali = quality.Count-1; }

        QualitySettings.SetQualityLevel(num_quali, true);

    }
    public void mudar_resolucao(int num) {
        num_reso += num;
       
        if (num_reso >= resolutions.Count) { num_reso = 0; }
        if (num_reso < 0) { num_reso = resolutions.Count-1; }

      
        string[] res = resolutions[num_reso].Split('X');
       
        int w = Convert.ToInt16(res[0].Trim());
        int h = Convert.ToInt16(res[1].Trim());
       
        Screen.SetResolution(w, h, Screen.fullScreen);

    }
    public void mudar_lingua(int num) {
        num_lingua += num;
        if (num_lingua > 6) { num_lingua = 0; }
        if (num_lingua < 0) { num_lingua = 6; }

        if (num_lingua == 0) { Data.languageName = "en-US"; }
        else if (num_lingua == 1) { Data.languageName = "es-ES"; }
        else if (num_lingua == 2) { Data.languageName = "pt-BR"; }
        else if (num_lingua == 3) { Data.languageName = "de-DE"; }
        else if (num_lingua == 4) { Data.languageName = "ru-RU"; }
        else if (num_lingua == 5) { Data.languageName = "zh-CN"; }
        else if (num_lingua == 6) { Data.languageName = "ja-JP"; }
    }
}
