using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorZumbis : MonoBehaviour
{
	public GameObject zumbiPrefab;

	public float delay = 2f;
	public float area = 5f;

	void Start()
	{
		InvokeRepeating("GerarZumbi", delay, delay);
	}

	void GerarZumbi()
	{
		Vector2 posicaoAleatoria = Random.insideUnitCircle * area;

		GameObject zumbi = Instantiate(zumbiPrefab);
		zumbi.transform.position = new Vector3(
			posicaoAleatoria.x,
			zumbi.transform.position.y,
			posicaoAleatoria.y
		);
	}
}
