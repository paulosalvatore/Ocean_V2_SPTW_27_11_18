using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zumbi : MonoBehaviour
{
	public float velocidade = 0.3f;

	public float delayAndar = 1f;

	Rigidbody rb;
	Animator animator;

	bool andando = false;

	GameObject jogador;

	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody>();
		animator = GetComponent<Animator>();

		Invoke("Andar", delayAndar);

		jogador = GameObject.Find("Jogador");
	}

	void Andar()
	{
		andando = true;
	}

	// Update is called once per frame
	void Update()
	{
		if (andando)
		{
			transform.LookAt(jogador.transform);

			rb.velocity = (jogador.transform.position - transform.position).normalized * velocidade;
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Projétil"))
		{
			animator.SetTrigger("Morrer");
			andando = false;
		}
	}
}
