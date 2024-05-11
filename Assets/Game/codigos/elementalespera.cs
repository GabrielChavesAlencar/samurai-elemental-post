using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elementalespera : MonoBehaviour
{
    public string elemento;
    public float distancia;
    public GameObject player;

    public GameObject texto1;
    public GameObject texto2;

    public AudioClip [] sons;
    public AudioSource som;
    // Start is called before the first frame update
    void Start()
    {
       
        som = GameObject.FindGameObjectsWithTag("powerup")[0].GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        distancia = Vector2.Distance(player.transform.position, transform.position);
        if (distancia > 18) { gameObject.SetActive(false); }
        if (distancia < 1.5f)
        {
            if (player.GetComponent<jogador>().elemento1 == "") { texto2.SetActive(false); texto1.SetActive(true); } 
            else if(player.GetComponent<jogador>().elemento2 == "") { texto1.SetActive(false); texto2.SetActive(true); }
            else { texto2.SetActive(false); texto1.SetActive(true); }
        }
        else {
            texto1.SetActive(false); 
            texto2.SetActive(false); 
        
        }

            if (Input.GetKey(KeyCode.Insert))
        {
            if (distancia < 1.5f)
            {
                som.clip = sons[0];
                som.Play();
                player.GetComponent<jogador>().elemento1 = elemento;
                player.GetComponent<jogador>().elemento2 = "";
                jogador.elemento1est = player.GetComponent<jogador>().elemento1;
                jogador.elemento2est = player.GetComponent<jogador>().elemento2;
                gameObject.SetActive(false);
            }
        }
        if (Input.GetKey(KeyCode.Home))
        {
            if (distancia < 1.5f && player.GetComponent<jogador>().elemento2 == "")
            {
                som.clip = sons[1];
                som.Play();
                if (elemento == "pedra")
                {
                    if (player.GetComponent<jogador>().elemento1 == "vento")
                    {
                        player.GetComponent<jogador>().elemento2 = elemento;
                        gameObject.SetActive(false);
                    }
                    if (player.GetComponent<jogador>().elemento1 == "eletrico")
                    {
                        player.GetComponent<jogador>().elemento2 = elemento;
                        gameObject.SetActive(false);
                    }
                    if (player.GetComponent<jogador>().elemento1 == "agua")
                    {
                        player.GetComponent<jogador>().elemento2 = elemento;
                        gameObject.SetActive(false);
                    }
                    if (player.GetComponent<jogador>().elemento1 == "fogo")
                    {
                        player.GetComponent<jogador>().elemento2 = elemento;
                        gameObject.SetActive(false);
                    }
                    if (player.GetComponent<jogador>().elemento1 == "pedra")
                    {
                        player.GetComponent<jogador>().elemento2 = elemento;
                        gameObject.SetActive(false);
                    }
                }
                else if (elemento == "vento")
                {
                    if (player.GetComponent<jogador>().elemento1 == "pedra")
                    {
                        player.GetComponent<jogador>().elemento2 = elemento;
                        gameObject.SetActive(false);
                    }
                    if (player.GetComponent<jogador>().elemento1 == "agua")
                    {
                        player.GetComponent<jogador>().elemento2 = elemento;
                        gameObject.SetActive(false);
                    }
                    if (player.GetComponent<jogador>().elemento1 == "eletrico")
                    {
                        player.GetComponent<jogador>().elemento2 = elemento;
                        gameObject.SetActive(false);
                    }
                    if (player.GetComponent<jogador>().elemento1 == "fogo")
                    {
                        player.GetComponent<jogador>().elemento2 = elemento;
                        gameObject.SetActive(false);
                    }
                    if (player.GetComponent<jogador>().elemento1 == "vento")
                    {
                        player.GetComponent<jogador>().elemento2 = elemento;
                        gameObject.SetActive(false);
                    }
                }
                else if (elemento == "agua")
                {
                    if (player.GetComponent<jogador>().elemento1 == "fogo")
                    {
                        player.GetComponent<jogador>().elemento2 = elemento;
                        gameObject.SetActive(false);
                    }
                    if (player.GetComponent<jogador>().elemento1 == "vento")
                    {
                        player.GetComponent<jogador>().elemento2 = elemento;
                        gameObject.SetActive(false);
                    }
                    if (player.GetComponent<jogador>().elemento1 == "pedra")
                    {
                        player.GetComponent<jogador>().elemento2 = elemento;
                        gameObject.SetActive(false);
                    }
                    if (player.GetComponent<jogador>().elemento1 == "eletrico")
                    {
                        player.GetComponent<jogador>().elemento2 = elemento;
                        gameObject.SetActive(false);
                    }
                    if (player.GetComponent<jogador>().elemento1 == "agua")
                    {
                        player.GetComponent<jogador>().elemento2 = elemento;
                        gameObject.SetActive(false);
                    }
                }
                else if (elemento == "fogo")
                {
                    if (player.GetComponent<jogador>().elemento1 == "agua")
                    {
                        player.GetComponent<jogador>().elemento2 = elemento;
                        gameObject.SetActive(false);
                    }
                    if (player.GetComponent<jogador>().elemento1 == "eletrico")
                    {
                        player.GetComponent<jogador>().elemento2 = elemento;
                        gameObject.SetActive(false);
                    }
                    if (player.GetComponent<jogador>().elemento1 == "pedra")
                    {
                        player.GetComponent<jogador>().elemento2 = elemento;
                        gameObject.SetActive(false);
                    }
                    if (player.GetComponent<jogador>().elemento1 == "vento")
                    {
                        player.GetComponent<jogador>().elemento2 = elemento;
                        gameObject.SetActive(false);
                    }
                    if (player.GetComponent<jogador>().elemento1 == "fogo")
                    {
                        player.GetComponent<jogador>().elemento2 = elemento;
                        gameObject.SetActive(false);
                    }
                }
                else if (elemento == "eletrico")
                {
                    if (player.GetComponent<jogador>().elemento1 == "pedra")
                    {
                        player.GetComponent<jogador>().elemento2 = elemento;
                        gameObject.SetActive(false);
                    }
                    if (player.GetComponent<jogador>().elemento1 == "fogo")
                    {
                        player.GetComponent<jogador>().elemento2 = elemento;
                        gameObject.SetActive(false);
                    }
                    if (player.GetComponent<jogador>().elemento1 == "vento")
                    {
                        player.GetComponent<jogador>().elemento2 = elemento;
                        gameObject.SetActive(false);
                    }
                    if (player.GetComponent<jogador>().elemento1 == "agua")
                    {
                        player.GetComponent<jogador>().elemento2 = elemento;
                        gameObject.SetActive(false);
                    }
                    if (player.GetComponent<jogador>().elemento1 == "eletrico")
                    {
                        player.GetComponent<jogador>().elemento2 = elemento;
                        gameObject.SetActive(false);
                    }
                }
                jogador.elemento1est = player.GetComponent<jogador>().elemento1;
                jogador.elemento2est = player.GetComponent<jogador>().elemento2;
            }
        }


     }
}
