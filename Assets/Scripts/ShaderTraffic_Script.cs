using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderTraffic_Script : MonoBehaviour
{
	private Material mat;
	private float sWidth;
	private float sHeight;
	private float nextStepTime = 0f;
	private float stepPeriod;
	private float currentStep = 0f;
	private float totalSteps;
	private float activeSteps;
	private float percentDone;

	void Start()
	{
		sWidth = Screen.width;
		sHeight = Screen.height;
		mat = GetComponent<MeshRenderer>().sharedMaterial;
		mat.SetFloat("_Anim_Step", 0);
		mat.SetFloat("_Anim_Posiiton", 0);
		stepPeriod = mat.GetFloat("_Step_Period");
		totalSteps = mat.GetFloat("_Total_steps");
		activeSteps = mat.GetFloat("_Active_Steps");
		// totalSteps = 5f;
		Debug.Log(totalSteps);

		// InvokeRepeating("TrafficLines", 3.0f, 5.0f);
	}

	void Update()
	{
		TrafficLines();
	}

	void TrafficLines(){
		if (Time.time > nextStepTime ) {
			nextStepTime += stepPeriod;
			if (currentStep > totalSteps){
				currentStep = 0;
			}
			mat.SetFloat("_Anim_Step", currentStep);
			currentStep += 1f * activeSteps;
		}

		percentDone = 1-( (nextStepTime - Time.time)/stepPeriod );
		float position = Mathf.Lerp(0, 1, percentDone);
		// Debug.Log(position);
		mat.SetFloat("_Anim_Posiiton", position);

	}


		void OnGUI()
	{
		string messageTxt = string.Format("Current time:{0}\nNext step: {1}\nPercent: {2}", (Time.time).ToString(), nextStepTime, percentDone);
		GUIStyle txtStyle = new GUIStyle(GUI.skin.label);
		txtStyle.fontSize = (int)(sWidth/60);
		txtStyle.normal.textColor = Color.white;
		txtStyle.hover.textColor = Color.white;
		float boxWidth = sWidth/2;
		float boxHeight = sHeight/2;
		// if (showMessage == true){
			GUI.Box(new Rect(sWidth/2, 10, boxWidth, boxHeight), messageTxt, txtStyle);
		// }
	}

}
