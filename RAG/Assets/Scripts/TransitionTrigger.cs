using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionTrigger : MonoBehaviour
{
	public GameObject inObj;
	public GameObject outObj;

	public BoxCollider inCol;
	public BoxCollider outCol;

	private void Awake()
	{
		inObj = GameObject.FindGameObjectWithTag("In");
		outObj = GameObject.FindGameObjectWithTag("Out");

		inCol = inObj.GetComponentInChildren<BoxCollider>();
		outCol = outObj.GetComponentInChildren<BoxCollider>();
	}

	private void Start()
	{
		outObj.SetActive(false);
	}	
}
