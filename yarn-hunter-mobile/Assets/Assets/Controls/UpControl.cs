using UnityEngine;
using UnityEngine.EventSystems;

public class UpControl : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
   
    public CatController catController;
    public void OnPointerDown(PointerEventData eventData)
    {
        catController.ControllMoveUp();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
    }
}
