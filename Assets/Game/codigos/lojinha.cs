using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class lojinha : MonoBehaviour
{
    //public SpriteRenderer armadura;

    public SpriteRenderer elemento;

    public Sprite [] img_elementos;

    public int rand;

   

    public GameObject obt_text1;
    public GameObject obt_text2;
    public GameObject obt_text3;
    public GameObject obt_text4;
    public GameObject obt_text5;

    public item_mensagem item1;
    public item_mensagem item2;
    public item_mensagem item3;
    public item_mensagem item4;
    public item_mensagem item5;

    
    public GameObject armadura1;
    public GameObject armadura2;
    public GameObject elemento_obj;
    public hud uis;

    public AudioSource som_comprar;

    public static bool armadura_recente;

    // Start is called before the first frame update
    void Start()
    {
       
        rand = Random.Range(0,5);
        elemento.sprite = img_elementos[rand];

    }

    // Update is called once per frame
    void Update()
    {
        
        if(jogo.nivel_armadura==0){armadura1.SetActive(true);}
        else{armadura1.SetActive(false);}

        if(jogo.nivel_armadura==1){armadura2.SetActive(true);}
        else{armadura2.SetActive(false);}


        if(item1.ativado){
            obt_text1.SetActive(true);
            if (Input.GetKeyDown(controle_config.chave_coletar)&&hud.almas>=5){
                hud.almas-=5;
                jogo.num_pocao++;
                PlayerPrefs.SetInt("almas", hud.almas);
                PlayerPrefs.SetInt("pocoes", jogo.num_pocao);
                som_comprar.Play();

            }
        
        }
        else{obt_text1.SetActive(false);}

        if(item2.ativado){
            obt_text2.SetActive(true);
            if (Input.GetKeyDown(controle_config.chave_coletar)&&hud.almas>=20){
                hud.almas-=20;
                jogo.num_pocaoAzul++;
                PlayerPrefs.SetInt("almas", hud.almas);
                PlayerPrefs.SetInt("pocoesAzul", jogo.num_pocaoAzul);
                som_comprar.Play();

            }
        
        }
        else{obt_text2.SetActive(false);}

        if(item3.ativado){
            obt_text3.SetActive(true);
            if (Input.GetKeyDown(controle_config.chave_coletar)&&hud.almas>=10){
                if (rand == 0) { uis.invocar_poder(transform.position + new Vector3(7,-7,0), 0, "fogo"); }
                else if (rand == 1) { uis.invocar_poder(transform.position + new Vector3(7,-7,0), 1, "agua"); }
                else if (rand == 2) { uis.invocar_poder(transform.position + new Vector3(7,-7,0), 2, "pedra"); }
                else if (rand == 3) { uis.invocar_poder(transform.position + new Vector3(7,-7,0), 3, "eletrico"); }
                else if (rand == 4) { uis.invocar_poder(transform.position + new Vector3(7,-7,0), 4, "vento"); }
                hud.almas-=10;
                elemento_obj.SetActive(false);
                som_comprar.Play();

            }
        }
        else{obt_text3.SetActive(false);}

        if(item4.ativado){
            obt_text4.SetActive(true);
            if (Input.GetKeyDown(controle_config.chave_coletar)&&hud.almas>=70){
                hud.almas-=70;
                jogo.nivel_armadura=1;
                PlayerPrefs.SetInt("almas", hud.almas);
                PlayerPrefs.SetInt("armadura", 1);
                armadura_recente = true;
                som_comprar.Play();

            }
        
        }
        else{obt_text4.SetActive(false);}

        if(item5.ativado){
            obt_text5.SetActive(true);
            if (Input.GetKeyDown(controle_config.chave_coletar)&&hud.almas>=150){
                hud.almas-=150;
                jogo.nivel_armadura=2;
                PlayerPrefs.SetInt("almas", hud.almas);
                PlayerPrefs.SetInt("armadura", 2);
                armadura_recente = true;
                som_comprar.Play();
            }
        
        }
        else{obt_text5.SetActive(false);}

           

    }
}
