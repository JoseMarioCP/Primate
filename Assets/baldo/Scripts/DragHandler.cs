using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static GameObject itemBeingDragged;
    Vector3 startPosition;
    Transform startParent;
    public static Transform padre;
        public void OnBeginDrag (PointerEventData eventData)
    {
        itemBeingDragged = gameObject; //El objeto que se esta moviendo se asigna la itemBeingDragged
        startPosition = transform.position; // Espacio incial al ser movido, antes de que se moviera
        startParent = transform.parent; // Regresa el padre antes de ser jalado
        padre = startParent;    // Guarda el padre antes de ser movido
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition; // Se mueve a conforme se mueva el mouse o input
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        itemBeingDragged = null; //Se acabo de mover
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        if(transform.parent == startParent){
            transform.position = startPosition; // Se cambia la posicion incial antes de ser 
                                                // jalado; transform.position es la posicion 
                                                // del gameObject, startPositiion es la posición
                                                // del objeto padre antes de ser movida
        }
    }
}
