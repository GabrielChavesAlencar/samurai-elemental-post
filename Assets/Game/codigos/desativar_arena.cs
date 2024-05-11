using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desativar_arena : MonoBehaviour
{
    public invocador inv;
    public GameObject arena;
    public GameObject hp_boss;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inv.instancia != null) {
            if (inv.instancia.GetComponent<mob>().vidaatual<=0&& inv.instancia.GetComponent<boss>().vivo) {
                arena.SetActive(false);
                hp_boss.SetActive(false);
                gameObject.SetActive(false);
            }
        }
    }
}
