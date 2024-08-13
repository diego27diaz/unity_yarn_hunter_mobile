using UnityEngine;
using UnityEngine.EventSystems;

public class LeftControl : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public CatController catController;
    public void OnPointerDown(PointerEventData eventData)
    {
        catController.ControllMoveLeft();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        catController.StopMoving();
    }
}

