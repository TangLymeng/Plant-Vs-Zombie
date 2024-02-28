using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
   public Transform[] spawnPoints;

   public GameObject zombie;

   public ZombieTypeProb[] zombieTypes;

   private List<ZombieType> probList = new List<ZombieType>();

   private void Start()
   {
        InvokeRepeating("SpawnZombie", 0, 5);

            foreach (ZombieTypeProb zom in zombieTypes)
            {
               for (int i = 0; i < zom.probability; i++)
               {
                     probList.Add(zom.type);
               }
            }
   }

   void SpawnZombie()
   {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        GameObject myZombie = Instantiate(zombie, spawnPoints[randomIndex].position, Quaternion.identity);
        myZombie.GetComponent<Zombie>().type = probList[Random.Range(0, probList.Count)];
   }
}

[System.Serializable]
public class ZombieTypeProb
{
    public ZombieType type;
    public int probability;
}
