using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shader_Control_Script : MonoBehaviour
{
    private Material material;
    // bool startCounter = false;
    private float startTime;
    public float animLength;
	private float sWidth;
	private float sHeight;

    // Start is called before the first frame update
    void Start()
    {
		sWidth = Screen.width;
		sHeight = Screen.height;
        material = GetComponent<MeshRenderer>().sharedMaterial;
        material.SetFloat("_StartTime", -float.MaxValue);
        material.SetInt("_StartTimer", 0);
        material.SetInt("_Mix", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (startTime>0){
            Debug.Log((Time.time).ToString());
            if (Time.time>(startTime + animLength)){
                material.SetInt("_StartTimer", 0);
            }
        }
        // startTime = material.GetFloat("_StartTime");
        if (Input.GetMouseButtonDown(0)){
            // ShaderFuck();
            DissolveOnClick();
        }
    }
 

    void ShaderFuck(){
            Debug.Log("Click!");
            material.SetFloat("_Mix", .9f);
    }

    void DissolveOnClick(){
        startTime = Time.time;
        // startCounter = true;
        material.SetInt("_StartTimer", 1);
        // material.SetFloat("_StartTime", startTime);
        // Debug.Log(( Time.time-startTime).ToString());

    }

    	void OnGUI()
	{
        string messageTxt = string.Format("Current time:{0}\nStart time: {1}\nAnim length: {2}", (Time.time).ToString(), startTime, startTime + animLength);
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
