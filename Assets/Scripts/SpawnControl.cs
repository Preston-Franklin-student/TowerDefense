using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefense
{
    public class SpawnControl : MonoBehaviour
    {
        public List<GameObject> enemies = new List<GameObject>();

        public int baseSpawnAmount = 3;
        public int enemyIndexRange = 0;
        public float baseSpawnRate = 0;

        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(StartSpawn());
        }

        IEnumerator StartSpawn()
        {
            int enemyIndex = Random.Range(0, enemyIndexRange);
            int spawnAmount = Random.Range(baseSpawnAmount - 2, baseSpawnAmount + 2);
            spawnAmount -= enemyIndex;
            float spawnRate = Random.Range(baseSpawnRate, baseSpawnRate * 2f);
            StartCoroutine(StartWave(enemyIndex, spawnAmount, spawnRate));
            yield return new WaitForSeconds(1);
        }

       IEnumerator StartWave(int enemyIndex, int spawnAmount, float spawnRate)
        {
            for(int i = 0; i < spawnAmount; i++)
            {
                SpawnEnemy(enemies[enemyIndex]);
                yield return new WaitForSeconds(spawnRate);
            }
            StartCoroutine(StartSpawn());
        }

        void SpawnEnemy(GameObject enemy)
        {
            Instantiate(enemy, transform.position, transform.rotation);
        }
    }
}
