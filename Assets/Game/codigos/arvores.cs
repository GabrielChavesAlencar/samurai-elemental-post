using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arvores : MonoBehaviour
{
    public GameObject player;
    public jogo game;
    private SpriteRenderer render;

   
    private float countdown_D;
    private float countdown_E;
    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<SpriteRenderer>();
        trocar_imagem();
    }

    // Update is called once per frame
    void Update()
    {
        if(countdown_E>0.2f){if (player.GetComponent<Rigidbody2D>().velocity.x < -2) { transform.Translate(Vector3.right * Time.deltaTime); }}

        if(countdown_D>0.2f){if (player.GetComponent<Rigidbody2D>().velocity.x > 2) { transform.Translate(Vector3.left * Time.deltaTime); }}

        if (Input.GetKey(controle_config.chave_direita)) {countdown_D+=Time.deltaTime; }
        else{countdown_D = 0;}

        if (Input.GetKey(controle_config.chave_esquerda)) { countdown_E+=Time.deltaTime; }
        else{countdown_E=0;}

      
      
        if (transform.localPosition.x < -18.56f) {
           
            transform.localPosition = new Vector3(18.56f,-1.35f,10);
            trocar_imagem();
           
        }
        if (transform.localPosition.x > 18.56f) {
            transform.localPosition = new Vector3(-18.56f,-1.35f,10);
            trocar_imagem();
        }
    }
    
    public void trocar_imagem(){
        int rand = Random.Range(0,5);
        render.sprite = game.arvores_sprite[rand];
        if(rand==0||rand ==1||rand ==5){render.color = Color.gray;}
        else{render.color = Color.white;}
    }
}
