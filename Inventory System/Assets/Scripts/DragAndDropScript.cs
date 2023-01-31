using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDropScript : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler //IDropHandler //These are what make the mouse controls work.
{
    [SerializeField] private Canvas canvas; //Canvas refers to the canvas in my unity scene.
    [SerializeField] private InventoryUI inventoryUI; //Refers to the 'backpack' inventory in my scene that the other script is for.
   
    private CanvasGroup canvasGroup; //CanvasGroup refers to the component called CanvasGroup attatched to the items in my unity scene.
    private RectTransform rectTransform; //RectTransform refers to the component called RectTransform attatched to the items in my unity scene.

    private Inventory inventory;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        inventory = new Inventory();
    }

    //Debug.Log() informs me that all the functions are working, and then if they are working correctly depending on the positioning in the lines of each function.

    public void OnBeginDrag(PointerEventData eventData) //When the dragging movement begins.
    {
        Debug.Log("OnBeginDrag");
        canvasGroup.alpha = .5f; //Makes the items slightly transparent when dragged.
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData) //For when the items are dragged with a mouse.
    {
        //Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor; //This is to ensure that the mouse and the item stay to together and it should accomodate all screen six
    }

    public void OnEndDrag(PointerEventData eventData) //For when the items are unclicked with the mouse.
    {
        Debug.Log("OnEndDrag");
        canvasGroup.alpha = 1f; //Makes the items opaque again when the items are dropped.
        canvasGroup.blocksRaycasts = true;
    }

    public void OnPointerDown(PointerEventData eventData) //For when the items are clicked with a mouse.
    {
        Debug.Log("OnPointerDown");
    }
}