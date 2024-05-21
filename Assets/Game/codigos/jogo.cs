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
      //  num_tela = 6;
       
        som = GetComponent<AudioSource>();
        som.clip = musicas[num_tela];
        
        som.Play();
        
        back_render.sprite = backgrunds[num_tela];
        back_render2.sprite = backgrunds[num_tela];

        junta1.GetComponent<SpriteRenderer>().sprite = backgrunds_juntas[num_tela];
        junta2.GetComponent<SpriteRenderer>().sprite = backgrunds_juntas[num_tela];


        if (num_tela == 0) {local_juntas(15.02f, 0, 1.8f, 2);}
        else if (num_tela == 1) { local_juntas(18.45f, 0, 2, 2); }
        else if (num_tela == 2) { local_juntas(15.76f, 0, 1.8f, 2); }
        else if (num_tela == 3) { local_juntas(16.76f, 0, 1.8f, 2); }
        else if (num_tela == 4) { local_juntas(16.76f, 0, 1.8f, 2); }
        else if (num_tela == 5) { local_juntas(18.14f, 0, 1.8f, 2); }
        else if (num_tela == 6) { local_juntas(25.35f, 0, 2.2f, 2); }
        else if (num_tela == 7) { local_juntas(17.97f, 0, 2, 2); }
        else if (num_tela == 8) { local_juntas(15.94f, 0, 1.8f, 2); }
        else if (num_tela == 9) { local_juntas(15.94f, 0, 1.8f, 2); }
        
          //  telas[num_tela].SetActive(true);
            for (int i = 0; i < telas.Length; i++)
            {
                if (i == num_tela) { telas[i].SetActive(true); player.reiniciarpos(); }
                else { telas[i].SetActive(false); }


            }




    }

    public void local_juntas(float local1,float local2,float escala,float escala2) {
        junta1.GetComponent<Transform>().localPosition = new Vector2(local1, local2);
        junta1.GetComponent<Transform>().localScale = new Vector2(escala, escala2);

        junta2.GetComponent<Transform>().localPosition = new Vector2(local1, local2);
        junta2.GetComponent<Transform>().localScale = new Vector2(escala, escala2);
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
