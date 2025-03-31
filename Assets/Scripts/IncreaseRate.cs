using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TowerDefense
{
    public class IncreaseRate : MonoBehaviour
    {

        SpawnControl spawnControl;

        // Start is called before the first frame update
        void Start()
        {
            spawnControl = FindObjectOfType<SpawnControl>();
            StartCoroutine(IncreaseSpawnAmount());
            StartCoroutine(IncreaseEnemyIndex());
            StartCoroutine(IncreaseSpawnRate());
        }

        IEnumerator IncreaseSpawnAmount()
        {
            for(int i = 0; i < 13; i++)
            {
                yield return new WaitForSeconds(15);
                spawnControl.baseSpawnAmount = spawnControl.baseSpawnAmount + 1;
            }
        }

        IEnumerator IncreaseEnemyIndex()
        {
            for (int i = 0; i < 4; i++)
            {
                yield return new WaitForSeconds(30 * (i + 1));
                spawnControl.enemyIndexRange = spawnControl.enemyIndexRange + 1;
            }
        }

        IEnumerator IncreaseSpawnRate()
        {
            while(spawnControl.baseSpawnRate > 0.5)
            {
                yield return new WaitForSeconds(50);
                    spawnControl.baseSpawnRate = spawnControl.baseSpawnRate - 0.5f;
            }
        }
    }
}