using UnityEngine;
using UnityEngine.EventSystems;

public class RightControl : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    
    public CatController catController;
    public void OnPointerDown(PointerEventData eventData)
    {
        catController.ControllMoveRight();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        catController.StopMoving();
    }
}
