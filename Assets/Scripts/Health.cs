using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefense
{
    public class Health : MonoBehaviour
    {
        public float currentHealth = 5;

        void TakeDamage(float damageAmount)
        {
            currentHealth -= damageAmount;
            ValueDisplay.OnValueChanged.Invoke(gameObject.name + "Health", currentHealth);

            if(currentHealth <= 0)
            {
                Destroy(gameObject);
            }
        }

        public static void TryDamage(GameObject target, float damageAmount)
        {
            Health targetEnemy = target.GetComponent<Health>();
            if (targetEnemy)
            {
                targetEnemy.TakeDamage(damageAmount);
            }
        }
    }
}
