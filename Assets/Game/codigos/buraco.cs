using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buraco : MonoBehaviour
{
    public GameObject post_volta;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("jogador"))
        {
            collision.transform.position = post_volta.transform.position;
            collision.GetComponent<jogador>().rig.velocity = new Vector3(0,0,0);
            collision.GetComponent<jogador>().vida_atual -= 20;  
            collision.GetComponent<jogador>().dano_queda = false; 
             collision.GetComponent<jogador>().mini_pulo();
            collision.GetComponent<jogador>().som_queda.Play(); 
        }
    }
}
