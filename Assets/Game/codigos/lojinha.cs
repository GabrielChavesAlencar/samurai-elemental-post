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

    public Text mensagem;

    public GameObject obt_text;

    public item_mensagem item1;
    public item_mensagem item2;
    public item_mensagem item3;
    public item_mensagem item4;
    public item_mensagem item5;

    
    public GameObject armadura1;
    public GameObject armadura2;

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
            obt_text.SetActive(true);mensagem.text = "poção";
            if (Input.GetKeyDown(controle_config.chave_coletar)&&hud.almas>=5){
                hud.almas-=5;
                jogo.num_pocao++;
            }
        
        }
        else if(item2.ativado){
            obt_text.SetActive(true);mensagem.text = "poção azul";
            if (Input.GetKeyDown(controle_config.chave_coletar)&&hud.almas>=20){
                hud.almas-=20;
                jogo.num_pocaoAzul++;
            }
        
        }
        else if(item3.ativado){
            obt_text.SetActive(true);mensagem.text = "elemento";
            if (Input.GetKeyDown(controle_config.chave_coletar)&&hud.almas>=10){}
        }
        else if(item4.ativado){
            obt_text.SetActive(true);mensagem.text = "armadura";
            if (Input.GetKeyDown(controle_config.chave_coletar)&&hud.almas>=70){
                hud.almas-=70;
                jogo.nivel_armadura=1;
            }
        
        }
        else if(item5.ativado){
            obt_text.SetActive(true);mensagem.text = "armadura";
            if (Input.GetKeyDown(controle_config.chave_coletar)&&hud.almas>=150){
                hud.almas-=150;
                jogo.nivel_armadura=2;
            }
        
        }
        else{obt_text.SetActive(false);}
    }
}
