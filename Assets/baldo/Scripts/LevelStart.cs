using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelStart : MonoBehaviour
{
    public Sprite naran, manza, pera, uva, plata;
    public string patron;
    public CrearPatron objetoPatron;
    public int x1, x2;

    void Start()    
    {
        naran = Resources.Load<Sprite>("naranja");  // 1
        manza = Resources.Load<Sprite>("manzana");  // 2
        pera = Resources.Load<Sprite>("pera");      // 3
        uva = Resources.Load<Sprite>("uva");        // 4
        plata = Resources.Load<Sprite>("platano");  // 5
        
        objetoPatron = GameObject.Find("cartel1").GetComponent<CrearPatron>();

        x1 = objetoPatron.x;
        x2 = objetoPatron.x2;
        //patron = CrearPatron.patron;
        
        
        patron = objetoPatron.patron;
               
        SeleccionaFiguras();
    }

    public void SeleccionaFiguras()
    {
        switch(gameObject.name)
        {
            case "Slot1":
                if(x1==1) // No tiene imagen y es un campo receptor
                {

                }
                else
                {
                    switch(patron[0])
                    {
                        case '1':
                            CrearImagen("Image1", gameObject, naran);
                        break;

                        case '2':
                            CrearImagen("Image1", gameObject, manza);
                        break;

                        case '3':
                            CrearImagen("Image1", gameObject, pera);
                        break;

                        case '4':
                            CrearImagen("Image1", gameObject, uva);
                        break;

                        case '5':
                            CrearImagen("Image1", gameObject, plata);
                        break;
                    }
                }
            break;

            case "Slot2":
                if(x1==2 || x2==2) // No tiene imagen y es un campo receptor
                {
                        
                }
                else                // Tine imagen y en base al patron se busca cual poner
                {
                    switch(patron[1]) 
                    {
                    case '1':
                        CrearImagen("Image2", gameObject, naran);
                    break;

                     case '2':
                        CrearImagen("Image2", gameObject, manza);
                     break;

                    case '3':
                        CrearImagen("Image2", gameObject, pera);
                     break;

                    case '4':
                        CrearImagen("Image2", gameObject, uva);
                    break;

                    case '5':
                        CrearImagen("Image2", gameObject, plata);
                    break;
                    }
                }
            break;
        
            case "Slot3":
                if(x1==3 || x2==3) // No tiene imagen y es un campo receptor
                {
                        
                }
                else                // Tine imagen y en base al patron se busca cual poner
                {
                    switch(patron[2]) 
                    {
                    case '1':
                        CrearImagen("Image3", gameObject, naran);
                    break;

                     case '2':
                        CrearImagen("Image3", gameObject, manza);
                     break;

                    case '3':
                        CrearImagen("Image3", gameObject, pera);
                     break;

                    case '4':
                        CrearImagen("Image3", gameObject, uva);
                    break;

                    case '5':
                        CrearImagen("Image3", gameObject, plata);
                    break;
                    }
                }
            break;

            case "Slot4": 
                if(x1==4 || x2==4) // No tiene imagen y es un campo receptor
                {
                        
                }
                else                // Tine imagen y en base al patron se busca cual poner
                {
                    switch(patron[3]) 
                    {
                    case '1':
                        CrearImagen("Image4", gameObject, naran);
                    break;

                    case '2':
                        CrearImagen("Image4", gameObject, manza);
                    break;

                    case '3':
                        CrearImagen("Image4", gameObject, pera);
                    break;

                    case '4':
                        CrearImagen("Image4", gameObject, uva);
                    break;

                    case '5':
                        CrearImagen("Image4", gameObject, plata);
                    break;
                    }
                }
            break;

            case "Slot5":
                if(x1==5 || x2==5) // No tiene imagen y es un campo receptor
                {
                        
                }
                else                // Tine imagen y en base al patron se busca cual poner
                {
                    switch(patron[4]) 
                    {
                    case '1':
                        CrearImagen("Image5", gameObject, naran);
                    break;

                     case '2':
                        CrearImagen("Image5", gameObject, manza);
                     break;

                    case '3':
                        CrearImagen("Image5", gameObject, pera);
                     break;

                    case '4':
                        CrearImagen("Image5", gameObject, uva);
                    break;

                    case '5':
                        CrearImagen("Image5", gameObject, plata);
                    break;
                    }
                }
            break;

            case "Slot6":
                if(x2==6) // No tiene imagen y es un campo receptor
                {
                        
                }
                else                // Tine imagen y en base al patron se busca cual poner
                {
                    switch(patron[5]) 
                    {
                    case '1':
                        CrearImagen("Image6", gameObject, naran);
                    break;

                     case '2':
                        CrearImagen("Image6", gameObject, manza);
                     break;

                    case '3':
                        CrearImagen("Image6", gameObject, pera);
                     break;

                    case '4':
                        CrearImagen("Image6", gameObject, uva);
                    break;

                    case '5':
                        CrearImagen("Image6", gameObject, plata);
                    break;
                    }
                }
            break;

            case "Slot7":
                if(x2==7) // No tiene imagen y es un campo receptor
                {
                        
                }
                else                // Tine imagen y en base al patron se busca cual poner
                {
                    switch(patron[6]) 
                    {
                    case '1':
                        CrearImagen("Image7", gameObject, naran);
                    break;

                     case '2':
                        CrearImagen("Image7", gameObject, manza);
                     break;

                    case '3':
                        CrearImagen("Image7", gameObject, pera);
                     break;

                    case '4':
                        CrearImagen("Image7", gameObject, uva);
                    break;

                    case '5':
                        CrearImagen("Image7", gameObject, plata);
                    break;
                    }
                }
            break;

            case "Slot8":
                if(x2==8) // No tiene imagen y es un campo receptor
                {

                }
                else                // Tine imagen y en base al patron se busca cual poner
                {
                    switch(patron[7]) 
                    {
                    case '1':
                        CrearImagen("Image8", gameObject, naran);
                    break;

                     case '2':
                        CrearImagen("Image8", gameObject, manza);
                     break;

                    case '3':
                        CrearImagen("Image8", gameObject, pera);
                     break;

                    case '4':
                        CrearImagen("Image8", gameObject, uva);
                    break;

                    case '5':
                        CrearImagen("Image8", gameObject, plata);
                    break;
                    }
                }
            break;

            case "Slot9":
                // Tine imagen y en base al patron se busca cual poner
                switch(patron[8]) 
                {
                    case '1':
                        CrearImagen("Image2", gameObject, naran);
                    break;

                    case '2':
                        CrearImagen("Image2", gameObject, manza);
                    break;

                    case '3':
                        CrearImagen("Image2", gameObject, pera);
                    break;

                    case '4':
                        CrearImagen("Image2", gameObject, uva);
                    break;

                    case '5':
                        CrearImagen("Image2", gameObject, plata);
                    break;
                }
                
            break;
        }
    }

    public void CrearImagen(string nombre, GameObject padre, Sprite figura)  //Metodo para crear imagenes por script
    {
        GameObject newObject = new GameObject(nombre);   // Se asigna nombre al nuevo objeto
        newObject.AddComponent<Image>();    // Se añade script de imagen
        newObject.GetComponent<Image>().preserveAspect = true;
        newObject.transform.SetParent(padre.transform); // Se le da un objeto padre
        newObject.GetComponent<Image>().sprite = figura;    // Se le da un nuevo Sprite
    }
    
    private void Update()
    {
        //Debug.Log("(LevelStart) Patron: "+patron);
        //Debug.Log("(LevelStart2) 1er Espacio Vacio"+x1);
        //Debug.Log("(LevelStart2) 2do Espacio vacio"+x2);
    }
}
