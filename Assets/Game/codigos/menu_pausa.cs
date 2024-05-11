using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_pausa : MonoBehaviour
{
    public AudioSource som;
    public AudioClip[] sons_menu;
    public jogador player;

    public GameObject pausa_obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) { pausa_obj.SetActive(true); Time.timeScale = 0; }
    }
    public void ativar_som()
    {
        int rand = Random.Range(0, 5);


        som.clip = sons_menu[rand];
        som.Play();
    }
    public void continuar() {  ativar_som();pausa_obj.SetActive(false);Time.timeScale = 1; }
    public void restart() { ativar_som(); Time.timeScale = 1; player.elemento1 = jogador.elemento1est;
        player.elemento2 = jogador.elemento2est; SceneManager.LoadScene("jogo"); }
    public void menu() { ativar_som(); Time.timeScale = 1; SceneManager.LoadScene("menu"); }
}
