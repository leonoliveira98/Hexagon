using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{

   public Text maxScr;
   public int a;

   // Start is called before the first frame update
   void Start()
    {
      a = PlayerPrefs.GetInt("MaxScore");

      maxScr.text = "HIGHSCORE: " + a.ToString();
    }

    // Update is called once per frame
    void Update()
    {

      if (Score.pontuacao > a)
      {
         a = Score.pontuacao;

         PlayerPrefs.SetInt("MaxScore", a); //Guardar o score maximo na cache do telemovel
      }

   }
}
