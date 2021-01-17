using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

   public void StartButton()
   {
      SceneManager.LoadScene("SampleScene");
      Time.timeScale = 1f;
   }


}

      //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

