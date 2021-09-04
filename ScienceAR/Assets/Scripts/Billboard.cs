using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
	public Transform cam;
	
	//public RectTransform canva;

	private void Awake()
	{

	}

	private void Start()
	{
		
	}
	void LateUpdate()
    {
		
		transform.LookAt(transform.position + cam.forward);
		//transform.Rotate(1, 1, 0);
		

		//canva.transform.rotation = Quaternion.Euler(cam.transform.position.x, cam.transform.position.y, 0);
	}
}
