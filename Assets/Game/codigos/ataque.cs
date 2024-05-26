using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ataque : MonoBehaviour
{
    public float dano;
    public hud uis;
    public GameObject pos_text;
    public AudioSource som;
    // Start is called before the first frame update
    void Start()
    {
        uis = GameObject.FindGameObjectsWithTag("MainCamera")[0].GetComponent<hud>();
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("inimigo"))
        {
            if(!collision.GetComponent<mob>().invulneravel){
                dano = dano * 10;
                float d_t = 0.7f;
                som.Play();
                if (collision.GetComponent<mob>().atual.tipo != inimigos.lista_insetos.Boss_formiga)
                {
                    collision.GetComponent<mob>().countdown_dano = 0.01f;
                }
                collision.GetComponent<mob>().vidaatual -=dano;
                uis.invocar_texto("" + dano, pos_text.transform.position+ new Vector3(Random.Range(-d_t, d_t), Random.Range(-d_t, d_t), 0),0);
                if (collision.GetComponent<mob>().temp_dano == 0) { collision.GetComponent<mob>().temp_dano = 1; }
                else { collision.GetComponent<mob>().temp_dano = 0; }
            }
          
            gameObject.SetActive(false);
        }
    }
}
