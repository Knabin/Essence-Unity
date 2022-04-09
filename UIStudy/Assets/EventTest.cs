using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventTest : MonoBehaviour, IPointerEnterHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public void OnPointerEnter(PointerEventData data)
    {
        Debug.Log(data.position);
    }

    public void OnBeginDrag(PointerEventData data)
    {
        transform.position = data.position;
    }

    public void OnDrag(PointerEventData data)
    {
        transform.position = data.position;
    }

    public void OnEndDrag(PointerEventData data)
    {
        transform.position = data.position;
    }
}
