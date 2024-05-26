using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss_aranha : mob
{
    public float tempo_andandar;
    public GameObject campo_forca;
    public int indice_escudo;

    public GameObject minions;

    public GameObject minon1;
    public GameObject minon2;
    public GameObject minon3;

    public int invocar;
    
    // Start is called before the first frame update
    void Start()
    {
         inicio();
    }

    // Update is called once per frame
    void Update()
    {
        distancia = Vector2.Distance(player.transform.position, transform.position);

        

        if(vidaatual<200&&invocar == 0){indice_escudo=5;}
        else if(vidaatual<450&&invocar == 0){indice_escudo=3;}
        else if(vidaatual<800&&invocar == 0){indice_escudo=1;}

        if(indice_escudo==1||indice_escudo==3||indice_escudo==5){
            campo_forca.SetActive(true);
            invulneravel = true;
            if(minon1 == null){minon1 = Instantiate(minions); minon1.GetComponent<mob>().player = player; }
            if(minon2 == null){minon2 = Instantiate(minions); minon2.GetComponent<mob>().player = player;}
            if(minon3 == null){minon3 = Instantiate(minions); minon3.GetComponent<mob>().player = player;}

            if(invocar == 0&&minon1!=null&&minon2!=null&&minon3!=null){
                invocar = 3;
                minon1.GetComponent<mob>().desativar_distancia = true;
                minon2.GetComponent<mob>().desativar_distancia = true;
                minon3.GetComponent<mob>().desativar_distancia = true;
                if (transform.position.x > player.transform.position.x) {
                    minon1.transform.position = transform.position + new Vector3(-10,0,0);
                    minon2.transform.position = transform.position + new Vector3(-20,0,0);
                    minon3.transform.position = transform.position + new Vector3(-30,0,0);
                }
                else{
                    minon1.transform.position = transform.position + new Vector3(10,0,0);
                    minon2.transform.position = transform.position + new Vector3(20,0,0);
                    minon3.transform.position = transform.position + new Vector3(30,0,0);
                }


            }


        }
        else{campo_forca.SetActive(false);invulneravel = false;}
       //  acao1();
       uis.tamanho_hp_boss(vidaatual, vidamax);
       if (estado == "andando") { anim.Play("andando"); }
        else if (estado == "atacando") { anim.Play("atacando"); }
        else if (estado == "dano") { if (temp_dano > 0.5f) { anim.Play("dano"); } else { anim.Play("dano2"); } }

       if (lado > 0) { transform.localScale = new Vector2(escala_inicial.x, transform.localScale.y); }
            else { transform.localScale = new Vector2(escala_inicial.x * -1, transform.localScale.y); }
        if (estado != "morte")
        {
            
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
