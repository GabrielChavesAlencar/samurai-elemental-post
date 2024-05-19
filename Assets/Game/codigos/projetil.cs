using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projetil : MonoBehaviour
{
    public hud uis;
    public GameObject grupo;
    public float dano;
    public float tempo;
    // Start is called before the first frame update
    void Start()
    {
        uis = GameObject.FindGameObjectsWithTag("MainCamera")[0].GetComponent<hud>();
        grupo = GameObject.FindGameObjectsWithTag("bola_fogo")[0];
        dano = 20;

        transform.parent = grupo.transform;
    }

    // Update is called once per frame
    void Update()
    {
        tempo+=Time.deltaTime;
        if(tempo>5){gameObject.SetActive(false);tempo=0;}
        if(transform.localScale.x>0){
            transform.Translate(Vector2.right*3*Time.deltaTime);
        }
        else{
             transform.Translate(Vector2.right*-3*Time.deltaTime);
        }
    }

     private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("jogador"))
        {
             float d_t = 0.7f;
            uis.invocar_texto("" + dano,transform.position + new Vector3(Random.Range(-d_t, d_t), Random.Range(-d_t, d_t), 0),0);
            collision.GetComponent<jogador>().vida_atual -= dano;
            collision.GetComponent<jogador>().estado = "dano";
            tempo = 0;
            gameObject.SetActive(false);
        }
    }
}
