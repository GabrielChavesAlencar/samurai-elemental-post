using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contadorminion : MonoBehaviour
{
    public boss_aranha bosses;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  
    private void OnDisable()
    {
        //print("funcionou");
        bosses.invocar--;
    }
}