using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundWaveScript : MonoBehaviour
{
	// public GameObject rootObj;
	// public RootInputScript rootInput;
	// bool waveTrigger = false;

	private Animator animator;

	// Start is called before the first frame update
	void Start()
	{
		animator = GetComponent<Animator>();
		// rootObj = GameObject.Find("rootObj");
		// rootInput = rootObj.GetComponent<RootInputScript>();
	}

	// Update is called once per frame
	void Update()
	{
		if (animator != null){
			// waveTrigger = rootInput.waveTrigger;
			if (Input.GetKeyDown(KeyCode.G) && !Input.GetKey(KeyCode.LeftControl)){
					animator.SetTrigger("CastWave");
			}
			if (Input.GetKeyDown(KeyCode.G) && Input.GetKey(KeyCode.LeftControl)){
					animator.SetTrigger("ReverseWave");
			}
		}
	}
}
