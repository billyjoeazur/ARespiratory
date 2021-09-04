using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackerObj : MonoBehaviour
{

	public bool lungs = false;
	public bool number1 = false;

	public GameObject lung, num1;

	public GameObject number2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (lungs == true && number1 == true)
		{
			number2.SetActive(true);
			lung.SetActive(false);
			num1.SetActive(false);

		}

		if (lungs == false || number1 == false)
		{
			number2.SetActive(false);
		}

		if (lungs == false) 
		{
			lung.SetActive(false);
		}

		if (number1 == false)
		{
			num1.SetActive(false);
		}
    }

	public void Lungs()
	{
		lungs = true;
		lung.SetActive(true);
	}

	public void Number1()
	{
		number1 = true;
		num1.SetActive(true);
	}

	public void LungsOff()
	{
		lungs = false;
		number2.SetActive(false);
	}

	public void Number1Off()
	{
		number1 = false;
		number2.SetActive(false);
	}
}
