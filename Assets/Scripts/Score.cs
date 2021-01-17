using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
   public Text scoreTxt;
   public static int pontuacao = 0;
   public int score = 0;
   

   // Start is called before the first frame update
   void Start()
    {
      scoreTxt.text = "SCORE: " + score;

    }

    // Update is called once per frame
    void Update()
    {
      
      
      scoreTxt.text = "SCORE: " + pontuacao;
   }
}
