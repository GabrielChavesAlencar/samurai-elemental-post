using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proximatela : MonoBehaviour
{
    public jogo Game;
    public int num_tela;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("jogador"))
        {
            PlayerPrefs.SetInt("num_tela",num_tela);
            PlayerPrefs.SetInt("almas", hud.almas);
           
            Game.trocartela(num_tela);
        }
    }
}
