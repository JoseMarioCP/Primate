using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;

public class Desvanecer : MonoBehaviour {

	public float transparencia = 1;
	SpriteRenderer sprite;
	public Timer timer;


	public enum Modo
	{
		Show=0,
		Hide=1,
		Nothing=-1
	};

	public Modo modo;

	// Use this for initialization
	void Start () 
	{
		modo = Modo.Nothing;
		sprite = GetComponent<SpriteRenderer> ();
	}



	public void Update()
	{
		if (timer.tiempo<=0) 
		{
			modo = Modo.Hide;
		}

		if (timer.tiempo==5) {

			modo = Modo.Show;
		}


		if(modo.Equals(Modo.Hide))
		{
			if (transparencia <= 0) 
			{
				modo = Modo.Nothing;
			}
			else {
				transparencia -= Time.deltaTime;
				sprite.color = new Color (sprite.color.r, sprite.color.g, sprite.color.b, transparencia);
			}
		}

		if(modo.Equals(Modo.Show))
		{
			if (transparencia >= 1) 
			{
				modo = Modo.Nothing;
			} 
			else 
			{
				transparencia += Time.deltaTime*8;
				sprite.color = new Color (sprite.color.r, sprite.color.g, sprite.color.b, transparencia);
			}
		}

			
	}

}
