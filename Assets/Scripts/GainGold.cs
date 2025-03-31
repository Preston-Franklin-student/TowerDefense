using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefense
{
    public class GainGold : MonoBehaviour
    {
        Player player;

        public Tower_SO towerType;

        public void Start()
        {
            player = FindObjectOfType<Player>();
            StartCoroutine(GiveGold());
        }

        IEnumerator GiveGold()
        {
            while(true)
            {
                player.AddGold(towerType.damage);
                yield return new WaitForSeconds(towerType.fireRate);
            }
        }
    }
}
