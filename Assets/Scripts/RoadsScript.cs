using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadsScript : MonoBehaviour
{
	private Animator animator;

	void Start()
	{
		animator = GetComponent<Animator>();
	}

	void Update()
	{
		if (animator != null){
			if (Input.GetKeyDown(KeyCode.R) && !Input.GetKey(KeyCode.LeftControl)){
					animator.SetTrigger("Wave");
			}
			if (Input.GetKeyDown(KeyCode.R) && Input.GetKey(KeyCode.LeftControl)){
					animator.SetTrigger("WaveReverse");
			}
		}
	}
}
