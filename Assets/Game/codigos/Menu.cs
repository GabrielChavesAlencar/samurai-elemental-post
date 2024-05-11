using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject menu_principal;
    public GameObject creditos;
    public GameObject config;
    public GameObject logo;
    public GameObject botao_inicial;

    public AudioSource som;
    public AudioClip [] sons_menu;
    public static bool inicio;
    // Start is called before the first frame update
    void Start()
    {
        
        som = GetComponent<AudioSource>();
    }
    private void Awake()
    {
        if (!inicio)
        {
            config_sons.postpros = true;
            inicio = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void iniciar() { logo.SetActive(false);botao_inicial.SetActive(false);menu_principal.SetActive(true); ativar_som(); }
    public void voltar() { creditos.SetActive(false); config.SetActive(false); menu_principal.SetActive(true); ativar_som(); }
    public void credits() { menu_principal.SetActive(false); creditos.SetActive(true); ativar_som(); }
    public void configuracoes() { menu_principal.SetActive(false); config.SetActive(true); ativar_som(); }
    public void jogar() { SceneManager.LoadScene("jogo"); ativar_som(); }
    public void sair() { Application.Quit(); ativar_som(); }

    public void ativar_som() {
        int rand = Random.Range(0, 5);

       
        som.clip = sons_menu[rand];
        som.Play();
    }
}
