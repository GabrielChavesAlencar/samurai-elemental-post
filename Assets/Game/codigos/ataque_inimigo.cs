using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ataque_inimigo : MonoBehaviour
{
    public float dano;
    public hud uis;
    public GameObject pos_text;
    public AudioSource som;
    public AudioClip[] som_ataques;
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
        if (collision.gameObject.CompareTag("jogador"))
        {
            som.Play();
            float d_t = 0.7f;
            collision.GetComponent<jogador>().vida_atual -= dano;
            collision.GetComponent<jogador>().estado = "dano";
            if (collision.GetComponent<jogador>().temp_dano == 0) { collision.GetComponent<jogador>().temp_dano = 1; }
            else { collision.GetComponent<jogador>().temp_dano = 0; }
            uis.invocar_texto("" + dano, pos_text.transform.position + new Vector3(Random.Range(-d_t, d_t), Random.Range(-d_t, d_t), 0),0);
            gameObject.SetActive(false);
        }
    }
}
