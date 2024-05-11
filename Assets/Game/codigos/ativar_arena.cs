using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ativar_arena : MonoBehaviour
{
    public GameObject arena;
    public jogo game;
    public AudioClip som_boss;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("jogador"))
        {
            arena.SetActive(true);
            game.som.Stop();
            game.som.clip = som_boss;
            game.som.Play();
            gameObject.SetActive(false);
        }
    }
}
