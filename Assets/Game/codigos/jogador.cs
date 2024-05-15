using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jogador : MonoBehaviour
{
    public float vida_Max;
    public float vida_atual;
    public float velocidade;
    public Animator anim;
    public string estado;
    public Rigidbody2D rig;
    public float forca_pulo;
    private Vector3 escala_inicial;

    public LayerMask chao;
    public LayerMask inimigo_layer;
    public bool esta_no_chao;
    public bool esta_no_inimigo;
    public bool esta_no_chao_espada;
    public bool esta_no_inimigo_espada;
    public Transform pe_trans;
    public Transform espada_trans;
    public Vector3 velocidadey;

    private float countdown_ataque;
    private float countdown_dano;
    private int combo;
    public GameObject dano_obj;
    public float temp_dano;

    public  string elemento1;
    public static string elemento1est;
    public  string elemento2;
    public static string elemento2est;

    public GameObject[] poderes;
    private GameObject[] poderes_invocados;
    private int indice_poder;
    public GameObject grupo_poderes;
    public GameObject local_poder;
    public GameObject obj_veloz;
    private Vector3 pos_inicial;

    public AudioClip[] efeitos_katana;
    public AudioSource som;
    public bool dano_queda;
    public float maxY;
    private float dano_quedas;
    public AudioSource som_queda;
    public AudioSource som_queda2;
    public float poder_countdown;
    // Start is called before the first frame update
    void Start()
    {
        
        if (elemento1est == null) { elemento1est = ""; }
        if (elemento2est == null) { elemento2est = ""; }
        elemento1 = elemento1est;
        elemento2 = elemento2est;
        vida_atual = vida_Max;
        anim = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();
  
        escala_inicial = transform.localScale;
        estado = "parado";
        poderes_invocados = new GameObject[20];
        pos_inicial = transform.position;
        som = GetComponent<AudioSource>();
        poder_countdown = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (poder_countdown > 0) { poder_countdown += Time.deltaTime; }
        if (poder_countdown > 4) { poder_countdown = 0; }
        if (velocidadey.y < maxY) { maxY = velocidadey.y; }
        if (transform.position.y < -13) { reiniciarpos();}
        if (vida_atual <= 0) { estado = "morte"; vida_atual = 0; }
        if (estado == "morte") { anim.Play("morte"); elemento1est = ""; elemento2est = ""; }
        else if (estado == "dano") {
            if (temp_dano > 0.5f) { anim.Play("dano"); } 
            else { anim.Play("dano2"); } 
            countdown_dano += Time.deltaTime;
            if (countdown_dano > 0.5f) { countdown_dano = 0;estado = "parado"; } 
        }
        else if (estado != "morte"&& estado != "dano")
        {
            /*
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)|| Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (esta_no_chao && estado != "poderespecial" && estado != "espera")
                {

                    rig.AddForce(transform.up * forca_pulo, ForceMode2D.Impulse);
                    estado = "pulando";

                    if (rig.velocity.y > 15) { rig.velocity = new Vector2(rig.velocity.x, 15); }

                }
            }
            */
            if (velocidadey.y < -1) {
                if (estado != "ataque_pulando" && estado != "especial_voar" && estado != "ataque1" && estado != "ataque2" && estado != "ataque3") {
                    estado = "caindo";
                }
            }
            if (estado == "caindo") {
                if (esta_no_chao) { estado = "parado"; }
            }
            if (Physics2D.OverlapCircle(pe_trans.position, 0.3f, chao))
            {
                esta_no_chao = true;
                if (dano_queda) { vida_atual -= dano_quedas;  dano_queda = false; som_queda.Play(); }
            }
            else {
              
                esta_no_chao = false;
                if (velocidadey.y < -19 && velocidadey.y > -24 && estado != "ataque_pulando") { dano_queda = true;dano_quedas = 10; }
                else if (velocidadey.y < -24 && estado != "ataque_pulando") { dano_queda = true; dano_quedas = 20; }
                else if (velocidadey.y < -30 && estado == "ataque_pulando") { dano_queda = true; dano_quedas = 10; }
            }
        
            esta_no_inimigo = Physics2D.OverlapCircle(pe_trans.position, 0.3f, inimigo_layer);



            velocidadey = rig.velocity;

            if (estado != "especial_voar") { obj_veloz.SetActive(false); }

            if (estado == "parado") { anim.Play("parado"); rig.velocity = new Vector2(0, rig.velocity.y); }
            else if (estado == "andando") { anim.Play("andando"); }
            else if (estado == "pulando") { anim.Play("pulando"); }
            else if (estado == "ataque1") { anim.Play("ataque1"); }
            else if (estado == "ataque2") { anim.Play("ataque2"); }
            else if (estado == "ataque3") { anim.Play("ataque3"); }
            else if (estado == "especial_voar") { anim.Play("especial_voar"); }
            else if (estado == "poderespecial") { anim.Play("poderespecial"); }
            else if (estado == "caindo") { anim.Play("caindo"); }
            else if (estado == "ataque_pulando")
            {
                anim.Play("ataque_aereo");
                esta_no_chao_espada = Physics2D.OverlapCircle(espada_trans.position, 0.9f, chao);
                esta_no_inimigo_espada = Physics2D.OverlapCircle(espada_trans.position, 0.9f, inimigo_layer);
            }

            if (esta_no_chao)
            {
                if (estado == "pulando" || estado == "ataque_pulando")
                {
                    estado = "parado";
                }
            }

            if (Input.GetKeyUp(KeyCode.A)|| Input.GetKeyUp(KeyCode.RightArrow)) { if (estado == "andando") { estado = "parado"; } }
            if (Input.GetKeyUp(KeyCode.D)|| Input.GetKeyUp(KeyCode.LeftArrow)) { if (estado == "andando") { estado = "parado"; } }

            if (Input.GetKeyUp(KeyCode.RightControl)|| Input.GetKeyUp(KeyCode.LeftControl))
            {
                if (estado == "parado" || estado == "andando")
                {
                    if (combo == 0) { estado = "ataque1"; aplicar_dano(1);  }
                    else if (combo == 1) { estado = "ataque2"; aplicar_dano(1); }
                    else if (combo == 2) { estado = "ataque3"; aplicar_dano(2); }

                    som.clip = efeitos_katana[combo];
                    som.Play();

                }
                if (estado == "pulando"|| estado == "caindo")
                {
                    som.clip = efeitos_katana[2]; som.Play(); 

                    estado = "ataque_pulando";
                    aplicar_dano(3);
                }

            }

            if (Input.GetKeyUp(KeyCode.KeypadEnter)|| Input.GetKeyUp(KeyCode.Return))
            {
                if (elemento1 != "" && estado != "especial_voar"&&poder_countdown==0)
                {
                    
                    if (estado == "parado" || estado == "andando")
                    {
                        poder_countdown = 0.01f;
                        rig.velocity = new Vector2(0, 0);
                        if (elemento2 == "")
                        {
                            if (elemento1 == "fogo")
                            {
                                indice_poder = 0;

                            }
                            else if (elemento1 == "agua")
                            {
                                indice_poder = 1;
                            }
                            else if (elemento1 == "pedra")
                            {
                                indice_poder = 2;
                            }
                            else if (elemento1 == "eletrico")
                            {
                                indice_poder = 3;
                            }
                            else if (elemento1 == "vento")
                            {
                                indice_poder = 4;
                            }
                        }
                        else if (elemento2 == "vento")
                        {
                            if (elemento1 == "pedra")
                            {
                                indice_poder = 5;

                            }
                            if (elemento1 == "agua")
                            {
                                indice_poder = 8;

                            }
                            if (elemento1 == "eletrico")
                            {
                                indice_poder = 12;

                            }
                            if (elemento1 == "fogo")
                            {
                                indice_poder = 14;

                            }
                            if (elemento1 == "vento")
                            {
                                indice_poder = 17;

                            }

                        }
                        else if (elemento2 == "pedra")
                        {

                            if (elemento1 == "vento")
                            {
                                indice_poder = 5;

                            }
                            if (elemento1 == "eletrico")
                            {
                                indice_poder = 7;

                            }
                            if (elemento1 == "agua")
                            {
                                indice_poder = 10;

                            }
                            if (elemento1 == "fogo")
                            {
                                indice_poder = 11;

                            }
                            if (elemento1 == "pedra")
                            {
                                indice_poder = 15;

                            }

                        }
                        else if (elemento2 == "agua")
                        {
                            if (elemento1 == "fogo")
                            {
                                indice_poder = 6;

                            }
                            if (elemento1 == "vento")
                            {
                                indice_poder = 8;

                            }
                            if (elemento1 == "pedra")
                            {
                                indice_poder = 10;

                            }
                            if (elemento1 == "eletrico")
                            {
                                indice_poder = 13;

                            }
                            if (elemento1 == "agua")
                            {
                                indice_poder = 16;

                            }
                        }
                        else if (elemento2 == "fogo")
                        {
                            if (elemento1 == "agua")
                            {
                                indice_poder = 6;

                            }
                            if (elemento1 == "eletrico")
                            {
                                indice_poder = 9;

                            }
                            if (elemento1 == "pedra")
                            {
                                indice_poder = 11;

                            }
                            if (elemento1 == "vento")
                            {
                                indice_poder = 14;

                            }
                            if (elemento1 == "fogo")
                            {
                                indice_poder = 18;

                            }
                        }
                        else if (elemento2 == "eletrico")
                        {
                            if (elemento1 == "pedra")
                            {
                                indice_poder = 7;

                            }
                            if (elemento1 == "fogo")
                            {
                                indice_poder = 9;

                            }
                            if (elemento1 == "vento")
                            {
                                indice_poder = 12;

                            }
                            if (elemento1 == "agua")
                            {
                                indice_poder = 13;

                            }
                            if (elemento1 == "eletrico")
                            {
                                indice_poder = 19;

                            }
                        }


                        if (indice_poder != 12)
                        {
                            estado = "poderespecial";
                        }
                        else
                        {
                            estado = "especial_voar";
                        }
                    }
                }
            }
            if (countdown_ataque > 0) { countdown_ataque += Time.deltaTime; }

            if (countdown_ataque > 1) { combo = 0; countdown_ataque = 0; }
        }
        
    }

    private void FixedUpdate()
    {
        if (estado != "morte" && estado != "dano")
        {

            if (Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.RightArrow))
            {
                if (estado == "parado" || estado == "andando")
                {
                    estado = "andando";
                    rig.velocity = new Vector2(220 * Time.fixedDeltaTime, rig.velocity.y);
                    transform.localScale = escala_inicial;
                }
                else if (estado == "pulando" || estado == "caindo") {
                    rig.velocity = new Vector2(220 * Time.fixedDeltaTime, rig.velocity.y);
                    transform.localScale = escala_inicial;
                }
            }



            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                if (estado == "parado" || estado == "andando")
                {
                    estado = "andando";
                    rig.velocity = new Vector2(-220 * Time.fixedDeltaTime, rig.velocity.y);
                    transform.localScale = new Vector3(-escala_inicial.x, escala_inicial.y, escala_inicial.z);
                }
                else if (estado == "pulando"|| estado == "caindo") {
                    rig.velocity = new Vector2(-220 * Time.fixedDeltaTime, rig.velocity.y);
                    transform.localScale = new Vector3(-escala_inicial.x, escala_inicial.y, escala_inicial.z);
                }
            }

            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                if (esta_no_chao && estado != "poderespecial" && estado != "espera")
                {

                    rig.AddForce(transform.up * forca_pulo, ForceMode2D.Impulse);
                    estado = "pulando";

                    if (rig.velocity.y > 15) { rig.velocity = new Vector2(rig.velocity.x, 15); }

                }
            }
            if (esta_no_chao_espada || esta_no_inimigo_espada || esta_no_inimigo)
            {
                rig.velocity = new Vector2(rig.velocity.x, 0);
                if (esta_no_inimigo) { vida_atual -= 5;som_queda2.Play(); }
                mini_pulo();
               
                impulso_leve();
                esta_no_chao_espada = false;
                desativar_dano();
                esta_no_inimigo_espada = false;
                esta_no_inimigo = false;
            }
        }

      
    }
    public void reiniciarpos() { transform.position = pos_inicial; }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("inimigo"))
        {
            if (estado == "pulando") {
                mini_pulo();
            }
        }
    }
    public void mini_pulo() {
        rig.velocity = new Vector2(rig.velocity.x, 0);
        velocidadey = new Vector3(0, 0, 0);
        anim.Play("parado");
        anim.Play("pulando");
        rig.AddForce(transform.up * (forca_pulo / 1.7f), ForceMode2D.Impulse);
        estado = "pulando";

        if (rig.velocity.y > 15) { rig.velocity = new Vector2(rig.velocity.x, 15); }
    }
    public void fim_golpe() {
        
        combo++;
        countdown_ataque = 0.01f;
        if (combo > 2) { combo = 0; }
        estado = "parado";
    }
    public void impulso_cima() { rig.velocity = new Vector2(rig.velocity.x, 0); rig.AddForce(transform.up * (forca_pulo/1.1f), ForceMode2D.Impulse); }
    public void impulso_cima_leve() { rig.velocity = new Vector2(rig.velocity.x, 0); rig.AddForce(transform.up * (forca_pulo/1.5f), ForceMode2D.Impulse); }
    public void impulso_baixo() { rig.velocity = new Vector2(rig.velocity.x, 0); rig.AddForce(transform.up * -(forca_pulo), ForceMode2D.Impulse); }
    public void impulso_leve() {
        if (transform.localScale.x > 0) { rig.AddForce(transform.right * 4, ForceMode2D.Impulse); if (rig.velocity.x > 5) { rig.velocity = new Vector2(5, rig.velocity.y); } }
        else { rig.AddForce(transform.right * -4, ForceMode2D.Impulse); if (rig.velocity.x < -5) { rig.velocity = new Vector2(-5,rig.velocity.y); } }
     
    }
    public void aplicar_dano(float dano) { dano_obj.SetActive(true);dano_obj.GetComponent<ataque>().dano = dano; }
    public void desativar_dano() { dano_obj.SetActive(false); }
    public void golpe_especial() {
        if (indice_poder == 12&&esta_no_chao)
        {
            obj_veloz.SetActive(true);
            if (transform.localScale.x > 0)
            {
                rig.velocity = new Vector2(0, 0);
                rig.AddForce(new Vector2(20, forca_pulo/1.3f), ForceMode2D.Impulse);
            }
            else
            {
                rig.velocity = new Vector2(0, 0);
                rig.AddForce(new Vector2(-20, forca_pulo/1.3f), ForceMode2D.Impulse);
            }
        }


        Vector3 pos_tem = new Vector3(0, 0, 0);
        for (int i = 0; i < poderes_invocados.Length; i++)
        {


            if (poderes_invocados[i] == null)
            {
                if (indice_poder != 12)
                {
                    poderes_invocados[i] = Instantiate(poderes[indice_poder], grupo_poderes.transform);
                    poderes_invocados[i].GetComponent<golpeespecial>().dano = 6;
                }
                if (indice_poder == 0) { pos_tem = local_poder.transform.position + new Vector3(0, -0.64f, 0); }
                else if (indice_poder == 1) { pos_tem = local_poder.transform.position + new Vector3(0, -1.3f, 0); }
                else if (indice_poder == 2) { pos_tem = local_poder.transform.position + new Vector3(0, -0.6f, 0); }
                else if (indice_poder == 3) { pos_tem = local_poder.transform.position + new Vector3(0, -0.8f, 0); }
                else if (indice_poder == 4) { pos_tem = local_poder.transform.position + new Vector3(0, -0.8f, 0); }
                

                else if (indice_poder == 5)
                {
                    if (transform.localScale.x > 0)
                    {
                        pos_tem = local_poder.transform.position + new Vector3(4.5f, -0.6f, 0);
                        poderes_invocados[i].transform.localScale = new Vector3(2f, 2f, 0);
                    }
                    else
                    {
                        pos_tem = local_poder.transform.position + new Vector3(-4.5f, -0.6f, 0);
                        poderes_invocados[i].transform.localScale = new Vector3(-2f, 2f, 0);
                    }
                    poderes_invocados[i].GetComponent<golpeespecial>().dano = 7;


                }
                else if (indice_poder == 6)
                {
                    if (transform.localScale.x > 0)
                    {
                        pos_tem = local_poder.transform.position + new Vector3(4.5f, -0.6f, 0);
                        poderes_invocados[i].transform.localScale = new Vector3(1.5f, 1.5f, 0);
                    }
                    else
                    {
                        pos_tem = local_poder.transform.position + new Vector3(-4.5f, -0.6f, 0);
                        poderes_invocados[i].transform.localScale = new Vector3(-1.5f, 1.5f, 0);
                    }
                    poderes_invocados[i].GetComponent<golpeespecial>().dano = 7;


                }
                else if (indice_poder == 7)
                {
                    if (transform.localScale.x > 0)
                    {
                        pos_tem = local_poder.transform.position + new Vector3(2.5f, -0.6f, 0);
                        poderes_invocados[i].transform.localScale = new Vector3(1.5f, 1.5f, 0);
                    }
                    else
                    {
                        pos_tem = local_poder.transform.position + new Vector3(-2.5f, -0.6f, 0);
                        poderes_invocados[i].transform.localScale = new Vector3(-1.5f, 1.5f, 0);
                    }
                    poderes_invocados[i].GetComponent<golpeespecial>().dano = 7;


                }
                else if (indice_poder == 8)
                {
                    if (transform.localScale.x > 0)
                    {
                        pos_tem = local_poder.transform.position + new Vector3(2.5f, 0.96f, 0);
                        poderes_invocados[i].transform.localScale = new Vector3(1.8f, 1.8f, 0);
                    }
                    else
                    {
                        pos_tem = local_poder.transform.position + new Vector3(-2.5f, 0.96f, 0);
                        poderes_invocados[i].transform.localScale = new Vector3(-1.8f, 1.8f, 0);
                    }
                    poderes_invocados[i].GetComponent<golpeespecial>().dano = 7;


                }
                else if (indice_poder == 9)
                {
                    if (transform.localScale.x > 0)
                    {
                        pos_tem = local_poder.transform.position + new Vector3(3.0f, -1f, 0);
                        poderes_invocados[i].transform.localScale = new Vector3(1.8f, 1.8f, 0);
                    }
                    else
                    {
                        pos_tem = local_poder.transform.position + new Vector3(-3.0f, -1f, 0);
                        poderes_invocados[i].transform.localScale = new Vector3(-1.8f, 1.8f, 0);
                    }
                    poderes_invocados[i].GetComponent<golpeespecial>().dano = 7;


                }
                else if (indice_poder == 10)
                {
                    if (transform.localScale.x > 0)
                    {
                        pos_tem = local_poder.transform.position + new Vector3(3.0f, 0.5f, 0);
                        poderes_invocados[i].transform.localScale = new Vector3(1.8f, 1.8f, 0);
                    }
                    else
                    {
                        pos_tem = local_poder.transform.position + new Vector3(-3.0f, 0.5f, 0);
                        poderes_invocados[i].transform.localScale = new Vector3(-1.8f, 1.8f, 0);
                    }
                    poderes_invocados[i].GetComponent<golpeespecial>().dano = 7;


                }
                else if (indice_poder == 11)
                {
                    if (transform.localScale.x > 0)
                    {
                        pos_tem = local_poder.transform.position + new Vector3(3.0f, 1.0f, 0);
                        poderes_invocados[i].transform.localScale = new Vector3(1.8f, 1.8f, 0);
                    }
                    else
                    {
                        pos_tem = local_poder.transform.position + new Vector3(-3.0f, 1.0f, 0);
                        poderes_invocados[i].transform.localScale = new Vector3(-1.8f, 1.8f, 0);
                    }
                    poderes_invocados[i].GetComponent<golpeespecial>().dano = 7;


                }
                else if (indice_poder == 13)
                {
                    if (transform.localScale.x > 0)
                    {
                        pos_tem = local_poder.transform.position + new Vector3(2.5f, -0.6f, 0);
                        poderes_invocados[i].transform.localScale = new Vector3(1.0f, 1.0f, 0);
                    }
                    else
                    {
                        pos_tem = local_poder.transform.position + new Vector3(-2.5f, -0.6f, 0);
                        poderes_invocados[i].transform.localScale = new Vector3(-1.0f, 1.0f, 0);
                    }
                    poderes_invocados[i].GetComponent<golpeespecial>().dano = 15;


                }
                else if (indice_poder == 14)
                {
                    if (transform.localScale.x > 0)
                    {
                        pos_tem = local_poder.transform.position + new Vector3(3.0f, 0.5f, 0);
                        poderes_invocados[i].transform.localScale = new Vector3(1.5f, 1.5f, 0);
                    }
                    else
                    {
                        pos_tem = local_poder.transform.position + new Vector3(-3.0f, 0.5f, 0);
                        poderes_invocados[i].transform.localScale = new Vector3(-1.5f, 1.5f, 0);
                    }
                    poderes_invocados[i].GetComponent<golpeespecial>().dano = 7;


                }
                else if (indice_poder == 15)
                {
                    if (transform.localScale.x > 0)
                    {
                        pos_tem = local_poder.transform.position + new Vector3(3.0f, 1.5f, 0);
                        poderes_invocados[i].transform.localScale = new Vector3(1.5f, 1.5f, 0);
                    }
                    else
                    {
                        pos_tem = local_poder.transform.position + new Vector3(-3.0f, 1.5f, 0);
                        poderes_invocados[i].transform.localScale = new Vector3(1.5f, 1.5f, 0);
                    }
                    poderes_invocados[i].GetComponent<golpeespecial>().dano = 8;


                }
                else if (indice_poder == 16)
                {
                    if (transform.localScale.x > 0)
                    {
                        pos_tem = local_poder.transform.position + new Vector3(3.0f, 0.5f, 0);
                        poderes_invocados[i].transform.localScale = new Vector3(1.7f, 1.7f, 0);
                    }
                    else
                    {
                        pos_tem = local_poder.transform.position + new Vector3(-3.0f, 0.5f, 0);
                        poderes_invocados[i].transform.localScale = new Vector3(-1.7f, 1.7f, 0);
                    }
                    poderes_invocados[i].GetComponent<golpeespecial>().dano = 8;


                }
                else if (indice_poder == 17)
                {
                    if (transform.localScale.x > 0)
                    {
                        pos_tem = local_poder.transform.position + new Vector3(3.0f, 1f, 0);
                        poderes_invocados[i].transform.localScale = new Vector3(1.9f, 1.9f, 0);
                    }
                    else
                    {
                        pos_tem = local_poder.transform.position + new Vector3(-3.0f, 1f, 0);
                        poderes_invocados[i].transform.localScale = new Vector3(-1.9f, 1.9f, 0);
                    }
                    poderes_invocados[i].GetComponent<golpeespecial>().dano = 8;


                }
                else if (indice_poder == 18)
                {
                    if (transform.localScale.x > 0)
                    {
                        pos_tem = local_poder.transform.position + new Vector3(4.5f, -0.6f, 0);
                        poderes_invocados[i].transform.localScale = new Vector3(1.5f, 1.5f, 0);
                    }
                    else
                    {
                        pos_tem = local_poder.transform.position + new Vector3(-4.5f, -0.6f, 0);
                        poderes_invocados[i].transform.localScale = new Vector3(-1.5f, 1.5f, 0);
                    }
                    poderes_invocados[i].GetComponent<golpeespecial>().dano = 16;


                }
                else if (indice_poder == 19)
                {
                    if (transform.localScale.x > 0)
                    {
                        pos_tem = local_poder.transform.position + new Vector3(2.5f, -0.6f, 0);
                        poderes_invocados[i].transform.localScale = new Vector3(1.5f, 1.5f, 0);
                    }
                    else
                    {
                        pos_tem = local_poder.transform.position + new Vector3(-2.5f, -0.6f, 0);
                        poderes_invocados[i].transform.localScale = new Vector3(-1.5f, 1.5f, 0);
                    }
                    poderes_invocados[i].GetComponent<golpeespecial>().dano = 8;


                }

                if (indice_poder != 12)
                {
                    poderes_invocados[i].transform.position = pos_tem;
                }
                


                i = 20;
               
            }
            else if(poderes_invocados[i].GetComponent<golpeespecial>().elemento == poderes[indice_poder].GetComponent<golpeespecial>().elemento)
            {
                if (!poderes_invocados[i].activeInHierarchy)
                {
                    if (indice_poder != 12)
                    {
                        poderes_invocados[i].GetComponent<golpeespecial>().dano = 6;
                    }
                    if (indice_poder == 0) { pos_tem = local_poder.transform.position + new Vector3(0, -0.64f, 0); }
                    else if (indice_poder == 1) { pos_tem = local_poder.transform.position + new Vector3(0, -1.3f, 0); }
                    else if (indice_poder == 2) { pos_tem = local_poder.transform.position + new Vector3(0, -0.6f, 0); }
                    else if (indice_poder == 3) { pos_tem = local_poder.transform.position + new Vector3(0, -0.8f, 0); }
                    else if (indice_poder == 4) { pos_tem = local_poder.transform.position + new Vector3(0, -0.8f, 0); }
                    else if (indice_poder == 5)
                    {
                        if (transform.localScale.x > 0)
                        {
                            pos_tem = local_poder.transform.position + new Vector3(4.5f, -0.6f, 0);
                            poderes_invocados[i].transform.localScale = new Vector3(2f, 2f, 0);
                        }
                        else
                        {
                            pos_tem = local_poder.transform.position + new Vector3(-4.5f, -0.6f, 0);
                            poderes_invocados[i].transform.localScale = new Vector3(-2f, 2f, 0);
                        }
                        poderes_invocados[i].GetComponent<golpeespecial>().dano = 7;
                    }
                    else if (indice_poder == 6)
                    {
                        if (transform.localScale.x > 0)
                        {
                            pos_tem = local_poder.transform.position + new Vector3(4.5f, -0.6f, 0);
                            poderes_invocados[i].transform.localScale = new Vector3(1.5f, 1.5f, 0);
                        }
                        else
                        {
                            pos_tem = local_poder.transform.position + new Vector3(-4.5f, -0.6f, 0);
                            poderes_invocados[i].transform.localScale = new Vector3(-1.5f, 1.5f, 0);
                        }
                        poderes_invocados[i].GetComponent<golpeespecial>().dano = 7;
                    }
                    else if (indice_poder == 7)
                    {
                        if (transform.localScale.x > 0)
                        {
                            pos_tem = local_poder.transform.position + new Vector3(2.5f, -0.6f, 0);
                            poderes_invocados[i].transform.localScale = new Vector3(1.5f, 1.5f, 0);
                        }
                        else
                        {
                            pos_tem = local_poder.transform.position + new Vector3(-2.5f, -0.6f, 0);
                            poderes_invocados[i].transform.localScale = new Vector3(-1.5f, 1.5f, 0);
                        }
                        poderes_invocados[i].GetComponent<golpeespecial>().dano = 7;
                    }
                    else if (indice_poder == 8)
                    {
                        if (transform.localScale.x > 0)
                        {
                            pos_tem = local_poder.transform.position + new Vector3(2.5f, 0.96f, 0);
                            poderes_invocados[i].transform.localScale = new Vector3(1.8f, 1.8f, 0);
                        }
                        else
                        {
                            pos_tem = local_poder.transform.position + new Vector3(-2.5f, 0.96f, 0);
                            poderes_invocados[i].transform.localScale = new Vector3(-1.8f, 1.8f, 0);
                        }
                        poderes_invocados[i].GetComponent<golpeespecial>().dano = 7;
                    }
                    else if (indice_poder == 9)
                    {
                        if (transform.localScale.x > 0)
                        {
                            pos_tem = local_poder.transform.position + new Vector3(3.0f, -1f, 0);
                            poderes_invocados[i].transform.localScale = new Vector3(1.8f, 1.8f, 0);
                        }
                        else
                        {
                            pos_tem = local_poder.transform.position + new Vector3(-3.0f, -1f, 0);
                            poderes_invocados[i].transform.localScale = new Vector3(-1.8f, 1.8f, 0);
                        }
                        poderes_invocados[i].GetComponent<golpeespecial>().dano = 7;
                    }
                    else if (indice_poder == 10)
                    {
                        if (transform.localScale.x > 0)
                        {
                            pos_tem = local_poder.transform.position + new Vector3(3.0f, 0.5f, 0);
                            poderes_invocados[i].transform.localScale = new Vector3(1.8f, 1.8f, 0);
                        }
                        else
                        {
                            pos_tem = local_poder.transform.position + new Vector3(-3.0f, 0.5f, 0);
                            poderes_invocados[i].transform.localScale = new Vector3(-1.8f, 1.8f, 0);
                        }
                        poderes_invocados[i].GetComponent<golpeespecial>().dano = 7;
                    }
                    else if (indice_poder == 11)
                    {
                        if (transform.localScale.x > 0)
                        {
                            pos_tem = local_poder.transform.position + new Vector3(3.0f, 1f, 0);
                            poderes_invocados[i].transform.localScale = new Vector3(1.8f, 1.8f, 0);
                        }
                        else
                        {
                            pos_tem = local_poder.transform.position + new Vector3(-3.0f, 1f, 0);
                            poderes_invocados[i].transform.localScale = new Vector3(-1.8f, 1.8f, 0);
                        }
                        poderes_invocados[i].GetComponent<golpeespecial>().dano = 7;
                    }
                    else if (indice_poder == 12)
                    {
                        obj_veloz.SetActive(true);
                        if (transform.localScale.x > 0)
                        {

                        }
                        else
                        {

                        }
                    }
                    else if (indice_poder == 13)
                    {
                        if (transform.localScale.x > 0)
                        {
                            pos_tem = local_poder.transform.position + new Vector3(2.5f, -0.6f, 0);
                            poderes_invocados[i].transform.localScale = new Vector3(1.0f, 1.0f, 0);
                        }
                        else
                        {
                            pos_tem = local_poder.transform.position + new Vector3(-2.5f, -0.6f, 0);
                            poderes_invocados[i].transform.localScale = new Vector3(-1.0f, 1.0f, 0);
                        }
                        poderes_invocados[i].GetComponent<golpeespecial>().dano = 15;
                    }
                    else if (indice_poder == 14)
                    {
                        if (transform.localScale.x > 0)
                        {
                            pos_tem = local_poder.transform.position + new Vector3(3.0f, 0.5f, 0);
                            poderes_invocados[i].transform.localScale = new Vector3(1.5f, 1.5f, 0);
                        }
                        else
                        {
                            pos_tem = local_poder.transform.position + new Vector3(-3.0f, 0.5f, 0);
                            poderes_invocados[i].transform.localScale = new Vector3(-1.5f, 1.5f, 0);
                        }
                        poderes_invocados[i].GetComponent<golpeespecial>().dano = 7;
                    }
                    else if (indice_poder == 15)
                    {
                        if (transform.localScale.x > 0)
                        {
                            pos_tem = local_poder.transform.position + new Vector3(3.0f, 1.5f, 0);
                            poderes_invocados[i].transform.localScale = new Vector3(1.5f, 1.5f, 0);
                        }
                        else
                        {
                            pos_tem = local_poder.transform.position + new Vector3(-3.0f, 1.5f, 0);
                            poderes_invocados[i].transform.localScale = new Vector3(1.5f, 1.5f, 0);
                        }
                        poderes_invocados[i].GetComponent<golpeespecial>().dano = 8;
                    }
                    else if (indice_poder == 16)
                    {
                        if (transform.localScale.x > 0)
                        {
                            pos_tem = local_poder.transform.position + new Vector3(3.0f, 0.5f, 0);
                            poderes_invocados[i].transform.localScale = new Vector3(1.7f, 1.7f, 0);
                        }
                        else
                        {
                            pos_tem = local_poder.transform.position + new Vector3(-3.0f, 0.5f, 0);
                            poderes_invocados[i].transform.localScale = new Vector3(-1.7f, 1.7f, 0);
                        }
                        poderes_invocados[i].GetComponent<golpeespecial>().dano = 8;
                    }
                    else if (indice_poder == 17)
                    {
                        if (transform.localScale.x > 0)
                        {
                            pos_tem = local_poder.transform.position + new Vector3(3.0f, 1f, 0);
                            poderes_invocados[i].transform.localScale = new Vector3(1.9f, 1.9f, 0);
                        }
                        else
                        {
                            pos_tem = local_poder.transform.position + new Vector3(-3.0f, 1f, 0);
                            poderes_invocados[i].transform.localScale = new Vector3(-1.9f, 1.9f, 0);
                        }
                        poderes_invocados[i].GetComponent<golpeespecial>().dano = 8;
                    }
                    else if (indice_poder == 18)
                    {
                        if (transform.localScale.x > 0)
                        {
                            pos_tem = local_poder.transform.position + new Vector3(4.5f, -0.6f, 0);
                            poderes_invocados[i].transform.localScale = new Vector3(1.5f, 1.5f, 0);
                        }
                        else
                        {
                            pos_tem = local_poder.transform.position + new Vector3(-4.5f, -0.6f, 0);
                            poderes_invocados[i].transform.localScale = new Vector3(-1.5f, 1.5f, 0);
                        }
                        poderes_invocados[i].GetComponent<golpeespecial>().dano = 16;
                    }
                    else if (indice_poder == 19)
                    {
                        if (transform.localScale.x > 0)
                        {
                            pos_tem = local_poder.transform.position + new Vector3(2.5f, -0.6f, 0);
                            poderes_invocados[i].transform.localScale = new Vector3(1.5f, 1.5f, 0);
                        }
                        else
                        {
                            pos_tem = local_poder.transform.position + new Vector3(-2.5f, -0.6f, 0);
                            poderes_invocados[i].transform.localScale = new Vector3(-1.5f, 1.5f, 0);
                        }
                        poderes_invocados[i].GetComponent<golpeespecial>().dano = 8;
                    }






                    if (indice_poder != 12)
                    {
                        poderes_invocados[i].transform.position = pos_tem;
                        poderes_invocados[i].SetActive(true);
                    }
                    i = 20;
                }
            }

        }
    }
    public void voltar_parado() { estado = "parado";

        obj_veloz.SetActive(false);
    }
   

}
