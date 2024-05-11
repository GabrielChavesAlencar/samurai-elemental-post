using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataforma : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y-2.0f < transform.position.y) { GetComponent<BoxCollider2D>().enabled = false; }
        else { GetComponent<BoxCollider2D>().enabled = true; }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("jogador")) { print("test"); player.GetComponent<jogador>().estado= "espera"; }
    }
    private void OnEnable()
    {
        player = GameObject.FindGameObjectsWithTag("jogador")[0];
    }
}
