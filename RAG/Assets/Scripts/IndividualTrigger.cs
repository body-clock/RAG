using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndividualTrigger : MonoBehaviour
{

	public TransitionTrigger trans;
	
	public AudioSource SwitchSource1;
	public AudioSource SwitchSource2;
	public AudioSource SwitchSource3;
	public AudioSource SwitchSource4;

	private void Awake()
	{
		trans = GetComponentInParent<TransitionTrigger>();
	}

	private void OnTriggerEnter(Collider other)
	{
		if (gameObject.CompareTag("Out"))
		{
			RoomManager.instance.SpawnRoom();
			trans.inObj.SetActive(true);
			trans.outObj.SetActive(false);
		}

		if (gameObject.CompareTag("In"))
		{
			print("in");
			trans.inObj.SetActive(false);
			trans.outObj.SetActive(true);
		}
	}
}
