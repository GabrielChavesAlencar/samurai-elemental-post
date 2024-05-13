using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jogo : MonoBehaviour
{
    public inimigos[] inimigos_script;
    public GameObject[] telas;
    public jogador player;
    public static int num_tela;
    public Sprite[] backgrunds;
    public Sprite[] backgrunds_juntas;
    public SpriteRenderer back_render;
    public SpriteRenderer back_render2;
    public GameObject junta1;
    public GameObject junta2;
    public AudioClip[] musicas;
    public AudioSource som;
    // Start is called before the first frame update
    void Start()
    {
      //  num_tela = 4;
        
        som = GetComponent<AudioSource>();
        som.clip = musicas[num_tela];
        
        som.Play();
        
        back_render.sprite = backgrunds[num_tela];
        
          //  telas[num_tela].SetActive(true);
            for (int i = 0; i < telas.Length; i++)
            {
                if (i == num_tela) { telas[i].SetActive(true); player.reiniciarpos(); }
                else { telas[i].SetActive(false); }


            }

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
        /*
        for (int i=0;i<telas.Length;i++) {
            if (i == num) { telas[i].SetActive(true);player.reiniciarpos(); }
            else { telas[i].SetActive(false); }

            
        }*/
        num_tela = num;
        SceneManager.LoadScene("jogo");
    }
}
