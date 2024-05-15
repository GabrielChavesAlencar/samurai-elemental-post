using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class hud : MonoBehaviour
{
    public GameObject texto;
    public GameObject[] texto_invocado;
    public GameObject[] drop_poderes;
    private GameObject[] poderes_invocados;
    private int indice_texto;
    public GameObject grupo_texto;
    public GameObject grupo_iP;
    public GameObject player;

    public Image elemento1;
    public Image elemento2;

    public Sprite[] icones_poderes;

    public RectTransform barra_HP;
    private float tamanho_rect;
    public float tempo_morte;
    public GameObject tutorial_obj;
    public static bool tutorial;

    public GameObject hp_boss;
    public RectTransform barra_HP_boss;
    private float tamanho_rect_boss;

    public static int almas;
    public TMP_Text alma_text;
    // Start is called before the first frame update
    void Start()
    {
        texto_invocado = new GameObject[5];
        poderes_invocados = new GameObject[15];
        tamanho_rect = barra_HP.sizeDelta.x;
        tamanho_rect_boss = barra_HP_boss.sizeDelta.x;
        
    }
    public void tamanho_hp_boss(float hp_atual,float hp_max) {
        float conta_hp = tamanho_rect_boss * hp_atual / hp_max;
        barra_HP_boss.sizeDelta = new Vector2(conta_hp, barra_HP_boss.sizeDelta.y);
    }

    // Update is called once per frame
    void Update()
    {
        alma_text.text = almas.ToString("000");
        if (Input.anyKey) { tutorial = true; }
        if (!tutorial) { tutorial_obj.SetActive(true); Time.timeScale = 0; }
        else if(tutorial_obj.activeInHierarchy) { tutorial_obj.SetActive(false); Time.timeScale = 1; }


        if (player.GetComponent<jogador>().vida_atual <= 0){ tempo_morte += Time.deltaTime; }
        if (tempo_morte > 3) { SceneManager.LoadScene("jogo"); }
        float conta_hp = tamanho_rect * player.GetComponent<jogador>().vida_atual/player.GetComponent<jogador>().vida_Max;
        barra_HP.sizeDelta = new Vector2(conta_hp, barra_HP.sizeDelta.y);
        if (elemento1.sprite == null) { elemento1.color = new Color(0, 0, 0, 0); }
        else  { elemento1.color = new Color(1, 1, 1, 1); }

        if (elemento2.sprite == null) { elemento2.color = new Color(0, 0, 0, 0); }
        else { elemento2.color = new Color(1, 1, 1, 1); }

        if (player.GetComponent<jogador>().elemento1==""){ elemento1.sprite = null; }
        else if (player.GetComponent<jogador>().elemento1=="fogo"){ elemento1.sprite = icones_poderes[0]; }
        else if (player.GetComponent<jogador>().elemento1=="agua"){ elemento1.sprite = icones_poderes[1]; }
        else if (player.GetComponent<jogador>().elemento1=="pedra"){ elemento1.sprite = icones_poderes[2]; }
        else if (player.GetComponent<jogador>().elemento1== "eletrico") { elemento1.sprite = icones_poderes[3]; }
        else if (player.GetComponent<jogador>().elemento1=="vento"){ elemento1.sprite = icones_poderes[4]; }


        if (player.GetComponent<jogador>().elemento2 == "") { elemento2.sprite = null; }
        else if (player.GetComponent<jogador>().elemento2 == "fogo") { elemento2.sprite = icones_poderes[0]; }
        else if (player.GetComponent<jogador>().elemento2 == "agua") { elemento2.sprite = icones_poderes[1]; }
        else if (player.GetComponent<jogador>().elemento2 == "pedra") { elemento2.sprite = icones_poderes[2]; }
        else if (player.GetComponent<jogador>().elemento2 == "eletrico") { elemento2.sprite = icones_poderes[3]; }
        else if (player.GetComponent<jogador>().elemento2 == "vento") { elemento2.sprite = icones_poderes[4]; }
    }
    public void invocar_poder(Vector3 pos,int num,string elemento) {
        for (int i = 0; i < 15; i++)
        {
            if (poderes_invocados[i] == null)
            {
                
                poderes_invocados[i] = Instantiate(drop_poderes[num], grupo_iP.transform);
                poderes_invocados[i].transform.position = pos;
                poderes_invocados[i].GetComponent<elementalespera>().player = player;
                i = 15;
            }
            else if (poderes_invocados[i].GetComponent<elementalespera>().elemento == elemento) {

              

                if (!poderes_invocados[i].activeInHierarchy)
                {
                    poderes_invocados[i].SetActive(true);
                    poderes_invocados[i].transform.position = pos;
                    poderes_invocados[i].GetComponent<elementalespera>().player = player;
                    i = 15;
                }
                else {
                    poderes_invocados[i] = Instantiate(drop_poderes[num], grupo_iP.transform);
                    poderes_invocados[i].transform.position = pos;
                    poderes_invocados[i].GetComponent<elementalespera>().player = player;
                    i = 15;
                }
             }
           
        }
       
    
    }
    public void invocar_texto(string texto_te,Vector3 trans,int num) {
        
        for (int i = 0; i < 5; i++) {
            if (texto_invocado[i] == null) {
                texto_invocado[i] = Instantiate(texto, grupo_texto.transform);
                texto_invocado[i].GetComponent<textoobj>().atualizar_texto(texto_te, num);
                texto_invocado[i].transform.position = trans;

                i = 5;
            }
            else if (!texto_invocado[i].activeInHierarchy) {
                texto_invocado[i].SetActive(true);
                texto_invocado[i].GetComponent<textoobj>().atualizar_texto(texto_te, num);
                texto_invocado[i].transform.position = trans;
                i = 5;
            }
        }
      
    }
}
