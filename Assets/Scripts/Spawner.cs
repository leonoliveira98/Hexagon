using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
   public float spawnRate = 1f;

   public GameObject hexagonPrefab;

   public static float nextTimeToSpawn = 0f;

    // Update is called once per frame
    void Update()
    {

      if(Score.pontuacao < 10)
      {
         if (Time.time >= nextTimeToSpawn)
         {

            Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity); //Para fazer aparecer os hexagons
            nextTimeToSpawn = Time.time + 2f / spawnRate;

         }

      } 
      else if(Score.pontuacao >= 10 && Score.pontuacao < 30)
      {
         if (Time.time >= nextTimeToSpawn)
         {

            Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity); //Para fazer aparecer os hexagons
            nextTimeToSpawn = Time.time + 1.5f / spawnRate;

         }
      } else
      {
         if (Time.time >= nextTimeToSpawn)
         {

            Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity); //Para fazer aparecer os hexagons
            nextTimeToSpawn = Time.time + 1f / spawnRate;

         }
      }
      
    }

}
