using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOverScreen : MonoBehaviour
{

   public Text pointsText;
    public void Setup()
   {

      gameObject.SetActive(true);
      pointsText.text = Score.pontuacao + " PONTOS";
      Score.pontuacao = 0;
      Time.timeScale = 0f;
   }

   public void RestartButton()
   {
      SceneManager.LoadScene("SampleScene");
      Time.timeScale = 1f;
   }

   public void ExitButton()
   {

      SceneManager.LoadScene("Menu");
   }
}
