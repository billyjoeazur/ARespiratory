using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LungPartsLineRenderer : MonoBehaviour
{
	public LineRenderer line;
	public Transform posText, posPart;
	void Start()
    {
		line.positionCount = 2;
	}

    // Update is called once per frame
    void LateUpdate()
    {
		line.SetPosition(0, posText.position);
		line.SetPosition(1, posPart.position);
		//if (posPart.Length == 2)
		//{
		//	line.SetPosition(1, posPart[1].position);
		//}
	}
}
