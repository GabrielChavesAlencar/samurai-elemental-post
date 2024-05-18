using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class louva_deus : mob
{
    
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
        
    }
     public void impulso_cima() { rig.velocity = new Vector2(rig.velocity.x, 0); rig.AddForce(transform.up * 340, ForceMode2D.Impulse); }
}
