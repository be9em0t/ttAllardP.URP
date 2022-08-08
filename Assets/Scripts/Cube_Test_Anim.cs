using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Test_Anim : MonoBehaviour
{

	private Animator animator;

	void Awake() {
		animator = GetComponent<Animator>();
		// Debug.Log(animator.name);
	}

	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
			if (animator != null){
				if (Input.GetKeyDown(KeyCode.U)){
					animator.SetTrigger("Up");
				}
				if (Input.GetKeyDown(KeyCode.D)){
					animator.SetTrigger("Down");
				}
			}
	}
}
