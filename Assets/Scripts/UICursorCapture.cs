using UnityEngine;
using UnityEngine.EventSystems;

namespace TowerDefense
{
    public class UICursorCapture : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        public bool cursorOverUI = false;

        public void OnPointerEnter(PointerEventData eventData)
        {
            cursorOverUI = true;
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            cursorOverUI = false;
        }
    }
}
