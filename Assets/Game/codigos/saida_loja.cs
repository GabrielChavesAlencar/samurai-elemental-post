using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saida_loja : MonoBehaviour
{
    public jogo Game;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("jogador"))
        {
            //PlayerPrefs.SetInt("num_tela",proximatela.num_tela_fixo);
            PlayerPrefs.SetInt("almas", hud.almas);
            Game.trocartela(proximatela.num_tela_fixo);
        }
    }
}
