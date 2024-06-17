using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arvores : MonoBehaviour
{
     public GameObject player;
    public GameObject outro;

    public Vector3 pos_inicial;
    public float countdown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(countdown>0.2f){
            if (player.GetComponent<Rigidbody2D>().velocity.x > 2) { transform.Translate(Vector3.left * Time.deltaTime); }
            if (player.GetComponent<Rigidbody2D>().velocity.x < -2) { transform.Translate(Vector3.right * Time.deltaTime); }
        }
        if(Input.anyKey){countdown+=Time.deltaTime;}
        else{countdown = 0;}
        if (transform.localPosition.x < -18.56f) {
            /*
            if (transform.localPosition.x > outro.transform.localPosition.x) {
                outro.transform.localPosition = new Vector3(16f,2.53f,10);
            }
            */
            transform.localPosition = new Vector3(18.56f,-1.35f,10);
            // new Vector3(18.56f+outro.transform.position.x,outro.transform.position.y,outro.transform.position.z);
        }
    }
    public void voltar_pos() { transform.localPosition = pos_inicial; }
}
