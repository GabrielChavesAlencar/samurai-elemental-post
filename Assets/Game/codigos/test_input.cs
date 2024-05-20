using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 

public class test_input : MonoBehaviour
{
    public bool trocar_botoes;
    public string tecla_atual;
    //public KeyCode[] allKeyCodes
   //  public KeyCode chave;
    private List<KeyCode> allKeyCodes;
   
    public static KeyCode chave_direita;
    public KeyCode chave_esquerda;
    public KeyCode chave_pulo;
    public KeyCode chave_katana;
    public KeyCode chave_especial;
    public KeyCode chave_coletar;
    public KeyCode chave_combinar;
    public KeyCode chave_sair;
    private void Awake()
    {
        allKeyCodes = new List<KeyCode>(Enum.GetValues(typeof(KeyCode)) as KeyCode[]);
    }
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

        /*
        if(Input.anyKeyDown){
            print(""+Input.inputString);
        }
        */
        //PlayerPrefs.GetString(tecla_atual)
        
        if(Input.GetKeyDown(chave_direita)){
            print("funcionou");
        }

        
         if (Input.anyKeyDown)
        {
             
            // Itera pelas teclas que foram pressionadas no frame atual
            foreach (KeyCode key in Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(key))
                {
                    // Imprime o KeyCode da tecla pressionada no console
                   // Debug.Log(key);
                    if(trocar_botoes){
                        PlayerPrefs.SetString(tecla_atual,key+"");
                        trocar_botoes = false;
                       
                        print("trocado: "+PlayerPrefs.GetString(tecla_atual));
                    }
                    // Aqui você pode adicionar sua lógica para tratar a tecla pressionada
                }
            }
        }
    }
 
    public void trocar(string tecla){
          //chave = allKeyCodes.Find(x => tecla==x+"");
        tecla_atual = tecla;
        trocar_botoes = true;
    }
}
