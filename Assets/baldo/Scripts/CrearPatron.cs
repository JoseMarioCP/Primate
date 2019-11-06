using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearPatron : MonoBehaviour
{
    public string patron;
    public int n;
    public int x, x2;
    private void Awake() 
    {
        Crear_Patron();
        DatosVacios(); // Para seleccionar cuales campos estarán vacios en el ejercicio;
    }

    public void Crear_Patron()
    {
        int opcion = 1;

        if(opcion == 1)
        {// Patron de 123 123 123
            for(int i = 0; i<3; i++) //Cantidad de patrones
            {
                n = Random.Range(1,5); //Figuras en el patrón
                patron = patron + n.ToString(); // Se concatenan los números
            }

            patron = patron + patron + patron;
        }

        if(opcion == 2)
        {// Patron de 12 1 12 1 12 1
            for(int i = 0; i<2; i++) 
            {
                n = Random.Range(1,5); 
                patron = patron + n.ToString(); 
            }
            n = Random.Range(1,5);
            patron = patron + n.ToString(); 

            patron = patron + patron + patron;
        }

        if(opcion == 3)
        {// Patron de 1 2 1 2 1 2 1 2 1
            int a = 0;
            for(int i = 0; i<2; i++) 
            {
                n = Random.Range(1,5); 
                if(i==0){
                    a=n;
                }
                patron = patron + n.ToString(); 
            }

            patron = patron + patron + patron + patron + a.ToString();
        }

        if(opcion == 4)
        {// Patron de 1234 1 1234
            int a = 0;
            for(int i = 0; i<4; i++) 
            {
                n = Random.Range(1,5);
                if(i==0){
                    a=n;
                }
                patron = patron + n.ToString(); 
            }

            patron = patron + a + patron;
        }
    }


    public void DatosVacios()
    {
        int y;
        x = Random.Range(1,5); // Posición del patron que estará vacía
        y = Random.Range(0,100);
        if(y<50)
            y = 2;
        else
            y = 3;

        x2 = x+y; // 2da posición que estará vacía 
    }


    private void Update()
    {
        Debug.Log("Patrón: "+patron);
    }

    
}
