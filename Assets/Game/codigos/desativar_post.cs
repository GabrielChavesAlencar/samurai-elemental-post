using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desativar_post : MonoBehaviour
{
    public Animator anim;
    public bool ativar_post;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        if (ativar_post) { config_sons.postpros = true; }
       
    }

    // Update is called once per frame
    void Update()
    {
        if (config_sons.postpros) { anim.Play("ativar post"); }
        else { anim.Play("desativar post"); }
    }
}
