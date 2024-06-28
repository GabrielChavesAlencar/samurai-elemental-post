using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golpeespecial : MonoBehaviour
{
    public float dano;
    private float dano_inicial;
    public hud uis;
    public string elemento;
    public GameObject pos_text;
    public bool continuo;
    public bool veloz;
    public bool superefetivo;
    public float tempo;
    // Start is called before the first frame update
    void Start()
    {
        uis = GameObject.FindGameObjectsWithTag("MainCamera")[0].GetComponent<hud>();
        dano_inicial = dano*10;
    }

    // Update is called once per frame
    void Update()
    {
        if (tempo > 0){ tempo += Time.deltaTime; }
        if (tempo > 1f) { tempo = 0; }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("inimigo")&&!collision.GetComponent<mob>().invulneravel)
        {
            
            dano = dano * 10;
            if (!veloz)
            {
                dano = dano_inicial;
            }
            float d_t = 0.5f;
            int temp_color = 0;
            if (elemento == collision.GetComponent<mob>().elemento) { dano = dano / 2; temp_color = 1; }
            else if (elemento == "fogo"|| elemento == "fogo2")
            {
                if (collision.GetComponent<mob>().elemento == "vento") { dano = dano * 2; temp_color = 2;superefetivo = true; }
                if (collision.GetComponent<mob>().elemento == "agua") { dano = dano / 2; temp_color = 1; }
                if (collision.GetComponent<mob>().elemento == "fogo") { dano = dano / 2; temp_color = 1; }
            }
            else if (elemento == "agua"|| elemento == "agua2")
            {
                if (collision.GetComponent<mob>().elemento == "fogo") { dano = dano * 2; temp_color = 2; superefetivo = true; }
                if (collision.GetComponent<mob>().elemento == "pedra") { dano = dano / 2; temp_color = 1; }
                if (collision.GetComponent<mob>().elemento == "agua") { dano = dano / 2; temp_color = 1; }
            }
            else if (elemento == "pedra"|| elemento == "pedra2")
            {
                if (collision.GetComponent<mob>().elemento == "agua") { dano = dano * 2; temp_color = 2; superefetivo = true; }
                if (collision.GetComponent<mob>().elemento == "eletrico") { dano = dano / 2; temp_color = 1; }
                if (collision.GetComponent<mob>().elemento == "pedra") { dano = dano / 2; temp_color = 1; }
            }
            else if (elemento == "eletrico"|| elemento == "eletrico2")
            {
                if (collision.GetComponent<mob>().elemento == "pedra") { dano = dano * 2; temp_color = 2; superefetivo = true; }
                if (collision.GetComponent<mob>().elemento == "vento") { dano = dano / 2; temp_color = 1; }
                if (collision.GetComponent<mob>().elemento == "eletrico") { dano = dano / 2; temp_color = 1; }
            }
            else if (elemento == "vento"|| elemento == "vento2")
            {
                if (collision.GetComponent<mob>().elemento == "eletrico") { dano = dano * 2; temp_color = 2; superefetivo = true; }
                if (collision.GetComponent<mob>().elemento == "fogo") { dano = dano / 2; temp_color = 1; }
                if (collision.GetComponent<mob>().elemento == "vento") { dano = dano / 2; temp_color = 1; }
            }

            

            if (!continuo) { 
                GetComponent<BoxCollider2D>().enabled = false;
                aplicardano(collision,d_t,temp_color);


            }
            else {
                if (collision.GetComponent<mob>().estado != "dano"&&tempo==0) {
                    aplicardano(collision, d_t, temp_color);
                    tempo = 0.1f;
                    
                }
            }
            
            //gameObject.SetActive(false);
        }
    }

    public void aplicardano(Collider2D collision,float d_t,int temp_color) {
        if(jogo.tempo_pocaoAzul>0){dano = dano * 1.5f;}
            //else{}
        if (collision.GetComponent<mob>().atual.tipo != inimigos.lista_insetos.Boss_formiga)
        {
            collision.GetComponent<mob>().countdown_dano = 0.01f;
        }
        else if (superefetivo) { collision.GetComponent<mob>().countdown_dano = 0.01f; }
        collision.GetComponent<mob>().vidaatual -= dano;
        uis.invocar_texto("" + dano, pos_text.transform.position + new Vector3(Random.Range(-d_t, d_t), Random.Range(-d_t, d_t), 0), temp_color);
        if (collision.GetComponent<mob>().temp_dano == 0) { collision.GetComponent<mob>().temp_dano = 1; }
        else { collision.GetComponent<mob>().temp_dano = 0; }
    }
    public void destivar() {
        GetComponent<BoxCollider2D>().enabled = false;
        gameObject.SetActive(false);
    }
    public void ativar_colider() {
        GetComponent<BoxCollider2D>().enabled = true;
    }
    private void OnEnable()
    {
        if (!veloz)
        {
            GetComponent<Animator>().Play("golpe");
        }
        else { dano = 14;ativar_colider(); }
    }
}
