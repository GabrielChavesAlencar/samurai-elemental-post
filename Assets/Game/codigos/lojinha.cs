using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class lojinha : MonoBehaviour
{
    public SpriteRenderer armadura;

    public SpriteRenderer elemento;

    public Sprite [] img_elementos;

    public int rand;

    public Text mensagem;

    public GameObject obt_text;
    
    // Start is called before the first frame update
    void Start()
    {
        rand = Random.Range(0,5);
        elemento.sprite = img_elementos[rand];

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
