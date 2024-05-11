using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : mob
{
    public float tempo_espera;
    
    // Start is called before the first frame update
    void Start()
    {
        inicio();
      
    }

    // Update is called once per frame
    void Update()
    {
        acao1();
        if (countdown_dano <= 0 && estado != "morte")
        {
          
            if (distancia < 7f||ataqueboss) { estado = "atacando";  }     
            else { 
                estado = "andando";
                if (transform.position.x > player.transform.position.x) { lado = -1; transform.eulerAngles = new Vector3(0, 0, 12); }
                else { lado = 1; transform.eulerAngles = new Vector3(0, 0, -12); }
            }
            if (distancia > 7 && distancia < 20) { tempo_espera += Time.deltaTime; }
            if (tempo_espera > 6) { 
                ataqueboss = true; }
            if (tempo_espera > 6.3f) {
               
                if (lado > 0) { rig.AddForce(transform.right * 2000, ForceMode2D.Impulse); tempo_espera = 0; }
                else { rig.AddForce(transform.right * -2000, ForceMode2D.Impulse);tempo_espera = 0; }
                
            }
            if (distancia < 7f) { tempo_espera = 0; }

        }
        uis.tamanho_hp_boss(vidaatual, vidamax);
        if (estado == "morte") {
            uis.hp_boss.SetActive(false);
          
        }

    }
    public void boss_atacando() { ataqueboss = true; }
    
    
}
