using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlarAnimaciones : MonoBehaviour
{

    public Animator transicion;
   

    public void animacionFinal()
    {

        transicion.SetTrigger("Animacion");
    }

        
       
       
 
}
