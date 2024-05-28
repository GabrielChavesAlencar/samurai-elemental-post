using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class louva_deus : mob
{
    public GameObject dano_obj2;
    // Start is called before the first frame update
    void Start()
    {
        
        if (drop_garantido) { rastro.SetActive(true); }
        //   som = GetComponent<AudioSource>();
        inicio();
    }

    // Update is called once per frame
    void Update()
    {
      
        acao1();
        if (distancia < 3f&&rig.velocity.y>-0.2f&&rig.velocity.y<0.2f) { estado = "atacando";  }     
        else { 
                estado = "andando";
                if (transform.position.x > player.transform.position.x) { lado = -1;}
                else { lado = 1;}
        }
        if (estado == "morte")
        {
            desativar_dano();
            desativar_dano2();
        }
    }
     public void impulso_cima() { rig.velocity = new Vector2(rig.velocity.x, 0); rig.AddForce(transform.up * 340, ForceMode2D.Impulse); }

      public void aplicar_dano2( ) { dano_obj2.SetActive(true); dano_obj2.GetComponent<ataque_inimigo>().dano = ataque*2.5f; }
    public void desativar_dano2() {dano_obj2.SetActive(false);  }
}
