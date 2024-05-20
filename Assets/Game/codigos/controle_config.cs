using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class controle_config : MonoBehaviour
{
    public bool trocar_botoes;
    public string tecla_atual;
    private int indice;

     private List<KeyCode> allKeyCodes;
   
    public static KeyCode chave_direita;
    public static KeyCode chave_esquerda;
    public static KeyCode chave_pulo;
    public static KeyCode chave_katana;
    public static KeyCode chave_especial;
    public static KeyCode chave_coletar;
    public static KeyCode chave_combinar;
    public static KeyCode chave_sair;

    public GameObject menu_controles;
    public GameObject imagem_aperte;

    public Text direita_text; 
    public Text esquerda_text;
    public Text pulo_text;
    public Text katana_text;
    public Text especial_text;
    public Text coletar_text;
    public Text combinar_text;
    public Text sair_text;


    private void Awake()
    {
        allKeyCodes = new List<KeyCode>(Enum.GetValues(typeof(KeyCode)) as KeyCode[]);
    }
    // Start is called before the first frame update
    void Start()
    {
        if( PlayerPrefs.GetString("direita")==""){PlayerPrefs.SetString("direita","D");}
        if( PlayerPrefs.GetString("esquerda")==""){PlayerPrefs.SetString("esquerda","A");}
        if( PlayerPrefs.GetString("pulo")==""){PlayerPrefs.SetString("pulo","W");}
        if( PlayerPrefs.GetString("katana")==""){PlayerPrefs.SetString("katana","RightControl");}
        if( PlayerPrefs.GetString("especial")==""){PlayerPrefs.SetString("especial","Return");}
        if( PlayerPrefs.GetString("coletar")==""){PlayerPrefs.SetString("coletar","Insert");}
        if( PlayerPrefs.GetString("combinar")==""){PlayerPrefs.SetString("combinar","Home");}
        if( PlayerPrefs.GetString("sair")==""){PlayerPrefs.SetString("sair","Escape");}
        
        
        chave_direita = allKeyCodes.Find(x =>  x+"" == PlayerPrefs.GetString("direita"));
        chave_esquerda = allKeyCodes.Find(x =>  x+"" == PlayerPrefs.GetString("esquerda"));
        chave_pulo = allKeyCodes.Find(x =>  x+"" == PlayerPrefs.GetString("pulo"));
        chave_katana = allKeyCodes.Find(x =>  x+"" == PlayerPrefs.GetString("katana"));
        chave_especial = allKeyCodes.Find(x =>  x+"" == PlayerPrefs.GetString("especial"));
        chave_coletar = allKeyCodes.Find(x =>  x+"" == PlayerPrefs.GetString("coletar"));
        chave_combinar = allKeyCodes.Find(x =>  x+"" == PlayerPrefs.GetString("combinar"));
        chave_sair = allKeyCodes.Find(x =>  x+"" == PlayerPrefs.GetString("sair"));
    }








    // Update is called once per frame
    void Update()
    {
        imagem_aperte.SetActive(trocar_botoes);
        if(menu_controles.activeInHierarchy){
            direita_text.text = chave_direita+"";
            esquerda_text.text = chave_esquerda+"";
            pulo_text.text = chave_pulo+"";
            katana_text.text = chave_katana+"";
            especial_text.text = chave_especial+"";
            coletar_text.text = chave_coletar+"";
            combinar_text.text = chave_combinar+"";
            sair_text.text = chave_sair+"";
        }
        if (Input.anyKeyDown&&trocar_botoes)
        {
         print("precione uma tecla");    
            foreach (KeyCode key in Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(key))
                {
                  if(indice==0){ PlayerPrefs.SetString("direita",key+"");chave_direita = key;}
                  else if(indice==1){ PlayerPrefs.SetString("esquerda",key+"");chave_esquerda = key;}
                  else if(indice==2){ PlayerPrefs.SetString("pulo",key+"");chave_pulo = key;}
                  else if(indice==3){ PlayerPrefs.SetString("katana",key+"");chave_katana = key;}
                  else if(indice==4){ PlayerPrefs.SetString("especial",key+"");chave_especial = key;}
                  else if(indice==5){ PlayerPrefs.SetString("coletar",key+"");chave_coletar = key;}
                  else if(indice==6){ PlayerPrefs.SetString("combinar",key+"");chave_combinar = key;}
                  else if(indice==7){ PlayerPrefs.SetString("sair",key+"");chave_sair = key;}

                   
                trocar_botoes = false;
                       
                print("trocado: "+key);
                    
                   
                }
            }
        }
    }







    public void trocar(int num){
        indice = num;
        trocar_botoes = true;
    }
}
