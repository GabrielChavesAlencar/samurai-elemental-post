using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class botoestutorial : MonoBehaviour
{
    public Text direita_text; 
    public Text esquerda_text;
    public Text pulo_text;
    public Text katana_text;
    public Text especial_text;
    public Text coletar_text;
    public Text combinar_text;

    public Text usarpotion_text;
    public Text trocaritem_text;
  //  public Text sair_text;
    // Start is called before the first frame update
    void Start()
    {
            direita_text.text = controle_config.chave_direita+"";
            esquerda_text.text = controle_config.chave_esquerda+"";
            pulo_text.text = controle_config.chave_pulo+"";
            katana_text.text = controle_config.chave_katana+"";
            especial_text.text = controle_config.chave_especial+"";
            coletar_text.text = controle_config.chave_coletar+"";
            combinar_text.text = controle_config.chave_combinar+"";

            usarpotion_text.text = controle_config.chave_usarItem+"";
            trocaritem_text.text = controle_config.chave_trocarItem+"";
            //sair_text.text = controle_config.chave_sair+"";
        
    }

    
}
