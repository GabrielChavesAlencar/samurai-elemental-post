using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paralax : MonoBehaviour
{
    public GameObject player;
    public GameObject outro;

    public Vector3 pos_inicial;
    // Start is called before the first frame update
    void Start()
    {
        pos_inicial = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<Rigidbody2D>().velocity.x > 2) { transform.Translate(Vector3.left * Time.deltaTime/2); }
        if (player.GetComponent<Rigidbody2D>().velocity.x < -2) { transform.Translate(Vector3.right * Time.deltaTime / 2); }

        if (transform.localPosition.x < 0.11f) {
            if (transform.localPosition.x > outro.transform.localPosition.x) {
                outro.transform.localPosition = new Vector3(23.6f,1.08f,10);
            }
        }
    }
    public void voltar_pos() { transform.localPosition = pos_inicial; }
}
