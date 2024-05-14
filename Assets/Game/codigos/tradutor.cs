using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class tradutor : MonoBehaviour
{
   
    public Text textoeditado;
    public string key;
    private void Awake()
    {
       
      //  textoeditado.GetComponent<TMP_Text>();
         key = textoeditado.text;

        textoeditado.text = Data.LOCALIZATION[key][Data.CURRENT_LANGUAGE()];
        //print(Data.languageName);
    }
    private void Update()
    {
        textoeditado.text = Data.LOCALIZATION[key][Data.CURRENT_LANGUAGE()];
    }


}
