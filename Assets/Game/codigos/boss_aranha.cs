using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss_aranha : mob
{
    public float tempo_andandar;
    // Start is called before the first frame update
    void Start()
    {
         inicio();
    }

    // Update is called once per frame
    void Update()
    {
       //  acao1();
       if (estado == "andando") { anim.Play("andando"); }
        else if (estado == "atacando") { anim.Play("atacando"); }
        else if (estado == "dano") { if (temp_dano > 0.5f) { anim.Play("dano"); } else { anim.Play("dano2"); } }

       if (lado > 0) { transform.localScale = new Vector2(escala_inicial.x, transform.localScale.y); }
            else { transform.localScale = new Vector2(escala_inicial.x * -1, transform.localScale.y); }
        if (countdown_dano <= 0 && estado != "morte")
        {
            distancia = Vector2.Distance(player.transform.position, transform.position);

            if (distancia < 7f||ataqueboss) { 
                estado = "atacando";
                if (transform.position.x > player.transform.position.x) { lado = -1;}
                else { lado = 1;}
            }     
            else { 
                estado = "andando";
                //if (transform.position.x > player.transform.position.x) { lado = -1;}
               // else { lado = 1;}
                tempo_andandar+=Time.deltaTime;
                if(tempo_andandar>7){lado*=-1;tempo_andandar=0;}
            }
        }
    }
}
