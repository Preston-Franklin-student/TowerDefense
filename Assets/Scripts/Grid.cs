using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefense
{
    public class Grid : MonoBehaviour
    {
        private Dictionary<Vector3Int, GameObject> gameObjects = new Dictionary<Vector3Int, GameObject>();

        public bool Add(Vector3Int tileCoordinates, GameObject gameObject)
        {
            if (gameObjects.ContainsKey(tileCoordinates)) return false;

            gameObjects.Add(tileCoordinates, gameObject);
            return true;
        }

        public void Remove(Vector3Int tileCoordinates)
        {
            if (!gameObjects.ContainsKey(tileCoordinates)) return;

            Destroy(gameObjects[tileCoordinates]);
            gameObjects.Remove(tileCoordinates);

        }

        public static Vector3Int WorldToGrid(Vector3 worldPosition)
        {
            Vector3Int gridPosition = Vector3Int.zero;
            gridPosition.x = (int)Mathf.Round(worldPosition.x);
            gridPosition.y = (int)Mathf.Round(worldPosition.y);
            gridPosition.z = (int)Mathf.Round(worldPosition.z);

            return gridPosition;

        }

        public static Vector3 GridToWorld(Vector3 gridPosition)
        {
            Vector3Int worldPosition = Vector3Int.zero;

            worldPosition.x = (int)gridPosition.x;
            worldPosition.y = (int)gridPosition.y;
            worldPosition.z = (int)gridPosition.z;
            
            return worldPosition;
        }
    }
}
