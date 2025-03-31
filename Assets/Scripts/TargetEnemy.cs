using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefense
{
    public class TargetEnemy : MonoBehaviour
    {

        public GameObject target;
        public Tower tower;

        // Update is called once per frame
        void Update()
        {
            target = tower.enemyTarget;
            if (target) transform.LookAt(target.transform.position);
        }
    }
}