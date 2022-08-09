using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Network_1Motorway_Script : MonoBehaviour
{
	private Animator animator;

	// Start is called before the first frame update
	void Start()
	{
		animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update()
	{
		if (animator != null){
			if (Input.GetKeyDown(KeyCode.N) && !Input.GetKey(KeyCode.LeftControl)){
					animator.SetTrigger("Appear");
			}
			if (Input.GetKeyDown(KeyCode.N) && Input.GetKey(KeyCode.LeftControl)){
					animator.SetTrigger("Disappear");
			}
		}
	}
}
