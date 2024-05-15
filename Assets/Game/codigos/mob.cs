using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mob : MonoBehaviour
{
    public float vidamax;
    public float vidaatual;
    public float velocidade;
    public float ataque;
    public float velocidade_ataque;
    public Vector3 pos_inicial;
    public Vector3 escala_inicial;

    public inimigos atual;
    public GameObject player;
    public float distancia;
    public string estado;
    public Rigidbody2D rig;
    public Animator anim;
    public float lado;

    public float countdown;
    public float countdown_dano;
    private float tempo_morte;
    public float countdown_parede;
    public GameObject dano_obj;
    private float posicao_temp;
    public float temp_dano;
    public string elemento;
    public hud uis;
    private float countdown_voou;
    public bool ataqueboss;
    public GameObject rastro;
    public bool drop_garantido;
    public bool vivo;
    public Transform pe_trans;
    public LayerMask inimigo_layer;
    public bool contato;
    // Start is called before the first frame update
    void Start()
    {
        if (drop_garantido) { rastro.SetActive(true); }
        //   som = GetComponent<AudioSource>();
        inicio();
       
    }
    public void inicio() {
        transform.localScale = new Vector2(atual.escala, atual.escala);
        uis = GameObject.FindGameObjectsWithTag("MainCamera")[0].GetComponent<hud>();


        pos_inicial = transform.position;
        escala_inicial = transform.localScale;
        anim = GetComponent<Animator>();


        rig = GetComponent<Rigidbody2D>();
        elemento = atual.elemento;
        if (atual.tipo == inimigos.lista_insetos.Abelha) { dano_obj.GetComponent<ataque_inimigo>().som.clip = dano_obj.GetComponent<ataque_inimigo>().som_ataques[0]; }
        else if (atual.tipo == inimigos.lista_insetos.Formiga) { dano_obj.GetComponent<ataque_inimigo>().som.clip = dano_obj.GetComponent<ataque_inimigo>().som_ataques[1]; }
        else if (atual.tipo == inimigos.lista_insetos.Joaninha) { dano_obj.GetComponent<ataque_inimigo>().som.clip = dano_obj.GetComponent<ataque_inimigo>().som_ataques[2]; }
        else if (atual.tipo == inimigos.lista_insetos.LouvaDeus) { dano_obj.GetComponent<ataque_inimigo>().som.clip = dano_obj.GetComponent<ataque_inimigo>().som_ataques[3]; }
        else if (atual.tipo == inimigos.lista_insetos.Tatu) { dano_obj.GetComponent<ataque_inimigo>().som.clip = dano_obj.GetComponent<ataque_inimigo>().som_ataques[4]; }
        else if (atual.tipo == inimigos.lista_insetos.Boss_formiga) { dano_obj.GetComponent<ataque_inimigo>().som.clip = dano_obj.GetComponent<ataque_inimigo>().som_ataques[1]; }
        else if (atual.tipo == inimigos.lista_insetos.Aranha) { dano_obj.GetComponent<ataque_inimigo>().som.clip = dano_obj.GetComponent<ataque_inimigo>().som_ataques[5]; }
        inicializar();

    }

    // Update is called once per frame
    void Update()
    {
        countdown_parede += Time.deltaTime;
        acao1();
        if (countdown_dano <= 0&&estado!="morte")
        {
            if (estado != "impulso")
            {
                if (distancia > 2.7f) { estado = "andando"; }
                else { estado = "atacando"; }
            }
        }
        if (Physics2D.OverlapCircle(pe_trans.position, 0.1f, inimigo_layer))
        {
            contato = true;
           
        }
        else { contato = false; }

        if (contato && !atual.voador) {
            estado = "impulso";
            impulso_leve();
            mini_pulo();
          
            contato = false;
        }
        if (rig.velocity.y>-0.5f&& rig.velocity.y < 0.5f) {
            if (estado == "impulso") { estado = "parado"; }
        }


     }
    private void FixedUpdate()
    {

        if (atual.tipo! != inimigos.lista_insetos.Boss_formiga)
        {
            andar();
        }
    }
    public void andar() {

        if (estado == "andando")
        {
            rig.velocity = new Vector2(velocidade * 10 * lado * Time.fixedDeltaTime, rig.velocity.y);
          
        }
    }
        private void OnEnable()
    {
        if (atual != null)
        {
            inicializar();
            transform.position = pos_inicial;
            transform.localScale = escala_inicial;
            
      
            
        }

    }
    public void acao1() {
       

        if (vidaatual <= 0) { estado = "morte"; }

        if (estado == "morte")
        {
            desativar_dano();
            anim.Play("morte");
            tempo_morte -= Time.deltaTime / 3;
            if (tempo_morte > 0.95 && tempo_morte < 1)
            {
                tempo_morte = 0.94f;
                float random = Random.Range(0, 10);
                //   print(random);
                if (drop_garantido) { random = 0; }
                if (random < 3)
                {
                    if (elemento == "fogo") { uis.invocar_poder(transform.position, 0, "fogo"); }
                    else if (elemento == "agua") { uis.invocar_poder(transform.position, 1, "agua"); }
                    else if (elemento == "pedra") { uis.invocar_poder(transform.position, 2, "pedra"); }
                    else if (elemento == "eletrico") { uis.invocar_poder(transform.position, 3, "eletrico"); }
                    else if (elemento == "vento") { uis.invocar_poder(transform.position, 4, "vento"); }
                }
            }

            if (tempo_morte < 0) { tempo_morte = 0; vivo = true; gameObject.SetActive(false); }
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, tempo_morte);
            GetComponent<CapsuleCollider2D>().enabled = false;
            rig.velocity = new Vector2(0, 0);
        }
        else
        {
            distancia = Vector2.Distance(player.transform.position, transform.position);

            if (countdown_dano > 0) { countdown_dano += Time.deltaTime; estado = "dano"; }
            if (countdown_dano > 0.8f) { countdown_dano = 0; }

            if (estado == "andando") { anim.Play("andando"); }
            else if (estado == "atacando") { anim.Play("atacando"); }
            else if (estado == "dano") { if (temp_dano > 0.5f) { anim.Play("dano"); } else { anim.Play("dano2"); } }

            if (countdown > 0) { countdown += Time.deltaTime; }
            if (countdown > 0.3f) { countdown = 0; }
        }
        if (lado > 0) { transform.localScale = new Vector2(escala_inicial.x, transform.localScale.y); }
        else { transform.localScale = new Vector2(escala_inicial.x * -1, transform.localScale.y); }

        if (countdown_parede > 0.1f && countdown_parede < 0.5f)
        {
            posicao_temp = transform.position.x;
            countdown = 0.5f;


        }
        if (atual.voador) { countdown_voou += Time.deltaTime; rig.velocity = new Vector2(rig.velocity.x, 0); }
        if (countdown_voou > 3) { if (estado == "andando") { lado = lado * -1; countdown = 0.01f; countdown_voou = 0; } countdown_parede = 0; }
        if (countdown_parede > 1) { if (posicao_temp == transform.position.x && estado == "andando") { lado = lado * -1; countdown = 0.01f; } countdown_parede = 0; }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("parede")|| collision.gameObject.CompareTag("inimigo"))
        {
           
            if (countdown == 0)
            {
               
                countdown_parede = 0;
                
                lado = lado * -1;
               
                transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
                countdown = 0.01f;
            }
        }
    }
    public void impulso_leve()
    {
        if (transform.localScale.x > 0) { rig.AddForce(transform.right * 150, ForceMode2D.Impulse); if (rig.velocity.x > 10) { rig.velocity = new Vector2(10, rig.velocity.y); } }
        else { rig.AddForce(transform.right * -150, ForceMode2D.Impulse); if (rig.velocity.x < -10) { rig.velocity = new Vector2(-10, rig.velocity.y); } }

    }
    public void mini_pulo()
    {
        rig.velocity = new Vector2(rig.velocity.x, 0);

        rig.AddForce(transform.up * (150 / 1.7f), ForceMode2D.Impulse);


        if (rig.velocity.y > 15) { rig.velocity = new Vector2(rig.velocity.x, 15); }
    }
    public void impulso_cima_leve() { rig.velocity = new Vector2(rig.velocity.x, 0); rig.AddForce(transform.up * (15 / 1.5f), ForceMode2D.Impulse); }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("parede")){
            
           
        }
    }


    public void inicializar() {
        if (atual.voador) { rig.gravityScale = 0; }
        else { rig.gravityScale = 1; }
        estado = "andando";
        GetComponent<CapsuleCollider2D>().enabled = true;
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        countdown = 0;
     
        vidamax = atual.vida;
        vidaatual = atual.vida;
        velocidade = atual.velocidade;
        ataque = atual.ataque;
    
        tempo_morte = 1;
        anim.runtimeAnimatorController = atual.anim;
    }
    public void aplicar_dano( ) { dano_obj.SetActive(true); dano_obj.GetComponent<ataque_inimigo>().dano = ataque; }
    public void desativar_dano() { ataqueboss = false;  dano_obj.SetActive(false);  }
}
