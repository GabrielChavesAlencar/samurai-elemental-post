using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desativar_post : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        if (configuracoes.postpros) { anim.Play("ativar post"); }
        else { anim.Play("desativar post"); }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
