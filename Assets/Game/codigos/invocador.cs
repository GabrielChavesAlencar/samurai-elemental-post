using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invocador : MonoBehaviour
{
    public GameObject mobs;
    public GameObject louva;
    public GameObject Boss;
    public GameObject instancia;
    public GameObject player;
    private float distancia;
    public jogo game;
    public float lado;
    public hud uis;
    public bool invocar_perto;
    public bool drop_garantido;
    public int indice_voou;
    public enum lista_insetos
    {
        Formiga,
        Tatu,
        Joaninha,
        Abelha,
        LouvaDeus,
        Boss_formiga,
        Aranha,
        Barata,
        puloLouvaDeus,
        Tatu_pulo,
        Formiga_Mago
    }
    public lista_insetos tipo;
    // Start is called before the first frame update
    void Start()
    {
        uis = GameObject.FindGameObjectsWithTag("MainCamera")[0].GetComponent<hud>();
        //  instancia = Instantiate(mobs, this.transform);
    }

    // Update is called once per frame
    void Update()
    {
        distancia = Vector2.Distance(player.transform.position, transform.position);
        if (distancia > 30&&tipo!=lista_insetos.Boss_formiga) { if(instancia!=null)instancia.SetActive(false); }
        if (distancia > 18&& distancia < 30||invocar_perto)
        {
            invocar_perto = false;
            int temp_num = 0;
            if (instancia == null) {
                if (tipo == lista_insetos.Boss_formiga) { instancia = Instantiate(Boss, this.transform);uis.hp_boss.SetActive(true); }
                else if (tipo == lista_insetos.puloLouvaDeus) { instancia = Instantiate(louva, this.transform);}
                else
                {
                    instancia = Instantiate(mobs, this.transform);
                    if (drop_garantido) { instancia.GetComponent<mob>().drop_garantido = true; }
                 
                }
            }
           
            instancia.SetActive(true);
          
            if (tipo == lista_insetos.Formiga) { temp_num = 0; }
            else if (tipo == lista_insetos.Tatu) { temp_num = 1; }
            else if (tipo == lista_insetos.Joaninha) { temp_num = 2; }
            else if (tipo == lista_insetos.Abelha) { temp_num = 3; instancia.GetComponent<mob>().indice_voou = indice_voou; }
            else if (tipo == lista_insetos.LouvaDeus) { temp_num = 4; }
            else if (tipo == lista_insetos.Boss_formiga) { temp_num = 5; }
            else if (tipo == lista_insetos.Aranha) { temp_num = 6; }
            else if (tipo == lista_insetos.Barata) { temp_num = 7; }
            else if (tipo == lista_insetos.puloLouvaDeus) { temp_num = 8; }
            else if (tipo == lista_insetos.Tatu_pulo) { temp_num = 9; }
            else if (tipo == lista_insetos.Formiga_Mago) { temp_num = 10; }
          
            instancia.GetComponent<mob>().atual = game.inimigos_script[temp_num];
            instancia.GetComponent<mob>().player = player;

            
            if (instancia.GetComponent<mob>().lado == 0) { instancia.GetComponent<mob>().lado = lado; }
        }
    }
}
