using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
   public Transform[] spawnPoints;

   public GameObject zombie;

   private void Start()
   {
        InvokeRepeating("SpawnZombie", 0, 5);
   }

   void SpawnZombie()
   {
        int randomIndex = Random.Range(0, spawnPoints.Length);
       GameObject myZombie = Instantiate(zombie, spawnPoints[randomIndex].position, Quaternion.identity);
   }
}
