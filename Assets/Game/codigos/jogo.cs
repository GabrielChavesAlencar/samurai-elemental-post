using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jogo : MonoBehaviour
{
    public inimigos[] inimigos_script;
    public GameObject[] telas;
    public GameObject loja;
    public jogador player;
    public static int num_tela;
    
    public static int num_pocao;
    public static int num_pocaoAzul;
    public static int nivel_armadura;
    public Sprite[] backgrunds;
    public Sprite[] backgrunds_juntas;
    public SpriteRenderer back_render;
    public SpriteRenderer back_render2;
    public GameObject junta1;
    public GameObject junta2;
    public AudioClip[] musicas;
    public AudioSource som;

    public int armadura_test;
  
    public Sprite[] arvores_sprite;
    // Start is called before the first frame update
    void Start()
    {
        //num_tela = 9;
       
        som = GetComponent<AudioSource>();
        som.clip = musicas[num_tela];
        
        som.Play();
        
        back_render.sprite = backgrunds[num_tela];
       
        for (int i = 0; i < telas.Length; i++)
        {
            if (i == num_tela) { telas[i].SetActive(true); player.reiniciarpos(); }
            else { telas[i].SetActive(false); }


        }
        loja.SetActive(false);

        num_pocao = PlayerPrefs.GetInt("pocoes");
        num_pocaoAzul = PlayerPrefs.GetInt("pocoesAzul");
        nivel_armadura = PlayerPrefs.GetInt("armadura");




    }
  
    // Update is called once per frame
    void Update()
    {
       
        /*
        if (Input.GetKey(KeyCode.Alpha1)) {

            player.elemento1 = jogador.elemento1est;
            player.elemento2 = jogador.elemento2est;
            SceneManager.LoadScene(0);
        }
        */
    }
    public void trocartela(int num) {
        player.elemento1 = jogador.elemento1est;
        player.elemento2 = jogador.elemento2est;
        //num_tela = num;
        SceneManager.LoadScene("jogo");
    }

    public void trocartela_loja(int num) {
        player.elemento1 = jogador.elemento1est;
        player.elemento2 = jogador.elemento2est;
        
        player.reiniciarpos();
        transform.position = new Vector3(-1.21f,0.09f,-10);
        
        num_tela = num;
        telas[num-1].SetActive(false);
        loja.SetActive(true);
        //SceneManager.LoadScene("jogo");
    }
}
