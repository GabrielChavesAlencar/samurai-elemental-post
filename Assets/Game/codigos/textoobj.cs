using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class textoobj : MonoBehaviour
{
    public TMP_Text obj_text;
    public float temp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        temp += Time.deltaTime;
        if (temp > 1) { gameObject.SetActive(false); }
    }
    public void atualizar_texto(string tesxt,int num) {
        obj_text.text = tesxt;temp = 0;
        if (num == 0) { obj_text.color = Color.white; }
        else if (num == 1) { obj_text.color = Color.red; }
        else if (num == 2) { obj_text.color = Color.green; }
        
    }
  

 }
