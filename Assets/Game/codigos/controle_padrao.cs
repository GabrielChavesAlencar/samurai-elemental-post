using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controle_padrao : MonoBehaviour
{
   
   private void Awake()
   {
 
    if(controle_config.chave_direita == KeyCode.None){controle_config.chave_direita = KeyCode.D;}
    if(controle_config.chave_esquerda == KeyCode.None){controle_config.chave_esquerda = KeyCode.A;}
    if(controle_config.chave_pulo == KeyCode.None){controle_config.chave_pulo = KeyCode.W;}
    if(controle_config.chave_katana == KeyCode.None){controle_config.chave_katana = KeyCode.RightControl;}
    if(controle_config.chave_especial == KeyCode.None){controle_config.chave_especial = KeyCode.Return;}
    if(controle_config.chave_coletar == KeyCode.None){controle_config.chave_coletar = KeyCode.Insert;}
    if(controle_config.chave_combinar == KeyCode.None){controle_config.chave_combinar = KeyCode.Home;}
   
    
   }
}
