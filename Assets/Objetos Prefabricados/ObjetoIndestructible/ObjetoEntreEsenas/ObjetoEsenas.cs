using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoEsenas : MonoBehaviour
{
    public int capa;
    public static ObjetoEsenas objeto;

    // Start is called before the first frame update
    void Awake()
    {
        if(objeto==null)
        {
            objeto = this;
            DontDestroyOnLoad(gameObject);

        }
        else
        {
            if(objeto!=null)
            {
                Destroy(this);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
