using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class barreira : MonoBehaviour
{
    public TMP_Text alma_text;
    public int quantidade;
    // Start is called before the first frame update
    void Start()
    {
        if (jogo.num_tela == 0) {quantidade = hud.almas + 8;}
        if (jogo.num_tela == 1) {quantidade = hud.almas + 7;}
        if (jogo.num_tela == 2) {quantidade = hud.almas + 10;}
        if (jogo.num_tela == 3) {quantidade = hud.almas + 12;}
    }

    // Update is called once per frame
    void Update()
    {
        alma_text.text = hud.almas.ToString("000") + "/" + quantidade.ToString("000");
        if (hud.almas >= quantidade) { gameObject.SetActive(false); }
    }
}
