using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
   public GameOverScreen GameOverScreen;
   public float moveSpeed = 600f;
   float pointer_x = 0f;

   // Update is called once per frame
   void Update()
   {
      //movement = Input.GetAxisRaw("Horizontal"); //Teclas A e D

      pointer_x = Input.GetAxis("Horizontal");
      if (Input.touchCount > 0)
      {
         pointer_x = Input.touches[0].deltaPosition.y;
         

      }
   }

   private void FixedUpdate()
   {
      transform.RotateAround(Vector3.zero, Vector3.forward, pointer_x * Time.fixedDeltaTime * -moveSpeed);

   }


   //Quando o jogador (bola) colide com os hexagons
   private void OnTriggerEnter2D(Collider2D collision)
   {
      //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

      GameOver();

   }

   public void GameOver()
   {

      GameOverScreen.Setup();
   }
}
