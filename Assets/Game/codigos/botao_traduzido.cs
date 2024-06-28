using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class botao_traduzido : MonoBehaviour
{
    public Text textoeditado;
    public string key;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
         if(key=="coletar"){textoeditado.text=controle_config.chave_coletar+"";}
        if(key=="usar"){textoeditado.text=controle_config.chave_usarItem+"";}
    }
}
