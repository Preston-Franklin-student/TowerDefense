using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefense
{
    public class IncreaseGold : MonoBehaviour
    {
        Player player;

        public int goldAmount = 5;
        public int delay = 1;
        public int increaseGoldDelay = 50;

        // Start is called before the first frame update
        void Start()
        {
            player = FindObjectOfType<Player>();
            StartCoroutine(EarnGold());
            StartCoroutine(IncreaseGoldAmount());
        }

        IEnumerator EarnGold()
        {
            while(true)
            {
                player.AddGold(goldAmount);
                yield return new WaitForSeconds(delay);
            }
        }

        IEnumerator IncreaseGoldAmount()
        {
            yield return new WaitForSeconds(increaseGoldDelay);
            goldAmount += 1;
        }
    }
}
