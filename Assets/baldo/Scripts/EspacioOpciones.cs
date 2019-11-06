using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class EspacioOpciones : MonoBehaviour, IDropHandler
{
    public GameObject item{
        get{
            if(transform.childCount>0){ // Si este objeto tiene un hijo, regresara el primero
                return transform.GetChild(0).gameObject;
            }
            return null;
        }
    }

    public void OnDrop (PointerEventData eventData)
    {
        if(!item){ //No hay hijo en este objeto (Slot)
            DragHandler.itemBeingDragged.transform.SetParent (transform); // Al objeto movido se le
                                                                          // asigna como padre este objeto
            
            CrearObjeto(DragHandler.itemBeingDragged.name, DragHandler.itemBeingDragged.GetComponent<Image>().sprite); // Recoge el nombre y sprite del objeto jalado para crear uno nuevo
        }
        else{
            //CrearObjeto(DragHandler.itemBeingDragged.name, DragHandler.itemBeingDragged.GetComponent<Image>().sprite); // Recoge el nombre y sprite del objeto jalado para crear uno nuevo
            Destroy(DragHandler.itemBeingDragged);
        }
    }

    public void CrearObjeto(string nombre, Sprite figura)  // Volver a crear objeto cuando llega al ejercicio
    {
        GameObject newObject = new GameObject(nombre);   // Se asigna nombre al nuevo objeto
        newObject.AddComponent<Image>();    // Se añade script de imagen
        newObject.AddComponent<DragHandler>();  //Se le agregan scripts
        newObject.AddComponent<CanvasGroup>();
        newObject.transform.SetParent(DragHandler.padre); // Se le da un objeto padre
        newObject.GetComponent<Image>().sprite = figura;    // Se le da un nuevo Sprite
        newObject.GetComponent<Image>().preserveAspect = true;
    }

    
}
