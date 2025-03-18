using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefense
{
    public class Health : MonoBehaviour
    {
        public int currentHealth = 5;

        void TakeDamage(int damageAmount)
        {
            currentHealth -= damageAmount;
            if(currentHealth <= 0)
            {
                Destroy(gameObject);
            }
        }

        public static void TryDamage(GameObject target, int damageAmount)
        {
            print("Taken damage");
            Health targetEnemy = target.GetComponent<Health>();
            if (targetEnemy)
            {
                targetEnemy.TakeDamage(damageAmount);
            }
        }
    }
}
