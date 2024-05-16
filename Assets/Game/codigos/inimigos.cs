using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



[CreateAssetMenu(fileName = "inimigos", menuName = "ScriptableObject/inimigos")]
[Serializable]
public class inimigos : ScriptableObject
{
    public enum lista_insetos
    {
        Formiga,
        Tatu,
        Joaninha,
        Abelha,
        LouvaDeus,
        Boss_formiga,
        Aranha,
        Barata

    }


    public lista_insetos tipo;
    public float vida;
    public float velocidade;
    public float ataque;
    public bool voador;
    public float escala;
    public string elemento;
    public RuntimeAnimatorController anim;
    public bool Elite;
   



}
