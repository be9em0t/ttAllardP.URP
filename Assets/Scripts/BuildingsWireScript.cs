using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingsWireScript : MonoBehaviour
{
	private Animator animator;

	void Start()
	{
		animator = GetComponent<Animator>();
	}

	void Update()
	{
		if (animator != null){
			if (Input.GetKeyDown(KeyCode.B) && !Input.GetKey(KeyCode.LeftControl)){
					animator.SetTrigger("Wave");
			}
			if (Input.GetKeyDown(KeyCode.B) && Input.GetKey(KeyCode.LeftControl)){
					animator.SetTrigger("WaveReverse");
			}
		}
	}
}
