using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Generacion_Flechas : MonoBehaviour 
{

    public MusicaFondo audio;
    public Musica musica;

    //public CapturarEntradas scriptRespuesta;
    public Timer tiempo;
    public GameObject respustasTactiles;        //objeto que contiene los botones para inttroducir las respuestas

    public Canvas Instrucciones_Iniciales;
	public Comenzar_Partida ComenzarP;

	public float tiempoEntreFlechas;
	public BotonesPulsados boton;
	public Text Fila1;
	public ArrayList flechas=new ArrayList();

    public bool problema = false;       //indica que las flechas ya estan listas para aprenderselas de memoria
    public int recorrido = 0;

    public MostrarPuntuacionM puntuacion;
	// Update is called once per frame
	void Update () 
	{

		//VERIFICA SI DEBE INICAR LA PARTIDA GENERANDO FLECHAS
		if (ComenzarP.Comenzar == true)
		{
            
			Instrucciones_Iniciales.gameObject.SetActive (false);   //desactivando el canvas de instrucciones
                                                                    //StartCoroutine(generacionInicial ());
           
             musica.FueraDeTiempo(); //activando la musica de fondo aprevechando el metodo de fuera de tiepmo

            StartCoroutine(generacion(2));      //se generan las primeras flechas inciales
			ComenzarP.Comenzar = false;     //cambia el valor de la variable comezar 
			//Debug.Log ("Comenzo");
		}

        if(Input.GetKeyUp(KeyCode.A))
        {
           // Debug.Log("cantidad de arraylist " + flechas.Count);
            //StartCoroutine(generacionYSumar(flechas.Count));
            AnadirFlechas();

        }

    }
    
        //metodo para la generacion de flechas en pantalla
	IEnumerator generacion(int num)
	{
		int numeroArray = 0;    //guarda el valor de un numero aleatorio para escoger la direccion de una flecha

		Fila1.text = "";    //texto que guarda los caracteres de las flechas
		int numero;         //guarda un numero aleatorio

		
		int tamanio=num;        //obtiene la cantidadd de objectos en el array

      
        flechas.Clear ();         //limpiando el arraylist


        yield return new WaitForSeconds (2f);
		for(int i=0;i<tamanio+2;i++)
		{
            recorrido++;

            if (i == 6) 
			{
				Fila1.text+="\n";
			}

			yield return new WaitForSeconds (tiempoEntreFlechas);
			numero = Random.Range (1, 5);
			numeroArray = numero;

			flechas.Add( numero);       //se agrega al array el numero aleatorio generado

			switch (numeroArray) 
			{
			case 1:

				Fila1.text+="A"+"  ";

				break;

			case 2:

				Fila1.text+="B"+"  ";

				break;

			case 3:

				Fila1.text+="C"+"  ";

				break;

			case 4:

				Fila1.text+="D"+"  ";

				break;

			}//SWITCH


		}

        problema = true;    //preguntas planteadas

                                    //------------TIEMPO PARA MEMORIZAR LAS FLECHAS---------------//
        yield return new WaitForSeconds(3f);

        musica.bajaVolumen();
       // musica.Detener();
       // audio.Comenzar();
        //Debug.Log("desactivando texto");        
        Fila1.enabled = false;              //desactivando el texto que contiene las flechas en pantalla
        respustasTactiles.SetActive(true);      //se activa el objeto que contiene los botones de respuesta


        tiempo.decrementar = true;  //inicia el decremento del tiempo para capturar las respuestas
    }



    //agregar mas numero de manera aleatoria al array de las flechas
   public void AnadirFlechas()
    {

        if (recorrido == 12)
        {
            Debug.Log("partida terminada");
            this.enabled = false;     //desactivando este script para nno seguir generando flechas
            puntuacion.mostrarPuntuacion();

        }
        else
        {
            int numeroArray = 0;
            int numero;

            for (int i = 0; i < 2; i++)
            {

                numero = Random.Range(1, 5);
                numeroArray = numero;
                flechas.Add(numero);

            }
            StartCoroutine(RecorrerArray(flechas));

            problema = true;            //preguntas planteadas
        }
        
    }



    //se recorre el array y va mostrando en pantalla las flechas 
    IEnumerator RecorrerArray(ArrayList flechas)
    {
        musica.subirVolumen(); //activando la musica de fondo aprevechando el metodo de fuera de tiepmo
        musica.FueraDeTiempo();
        
        Fila1.text = "";
      
        recorrido = 0;//variable global para llevar el contador de los recorridos 

        foreach (int pos in flechas)
        {

            //Debug.Log("numero " + pos);
            recorrido++;

            //salto de linea al mostrar las flechas en pantalla
            if (recorrido  == 7)
            {
                Fila1.text += "\n";
            }

            yield return new WaitForSeconds(tiempoEntreFlechas);
            
            switch (pos)
            {
                case 1:

                    Fila1.text += "A" + "  ";

                    break;

                case 2:

                    Fila1.text += "B" + "  ";

                    break;

                case 3:

                    Fila1.text += "C" + "  ";

                    break;

                case 4:

                    Fila1.text += "D" + "  ";

                    break;

            }//SWITCH

        }

        Debug.Log("cantidad de recorrido: " + recorrido);
        yield return new WaitForSeconds(3f);        //se espera un momento para memorizar las flechas en pantalla para despues desactivarlas
        
        musica.bajaVolumen();
       // musica.Detener();
        //audio.Comenzar();
        

        Debug.Log("desactivando texto");
        Fila1.enabled = false;                      //desactivando el texto que contiene las flechas en pantalla
        respustasTactiles.SetActive(true);          //se activa el objeto que contiene los botones de respuesta
        tiempo.decrementar = true;                  //inicia el decremento del tiempo para capturar las respuestas


    }
}
