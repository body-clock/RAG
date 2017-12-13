using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
	public GameObject[] rooms;
	public GameObject activeRoom;

	public int randomRoom;

	public int spaceCounter;
	public bool part1 = false;
	public bool part2 = false;

	public static RoomManager instance;	

	private void Start()
	{
		instance = this;
		part1 = true;
		SpawnRoom();
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			spaceCounter++;
		}

		if (spaceCounter == 0)
		{
			part2 = false;
			part1 = true;
		} else if (spaceCounter == 1)
		{
			part1 = false;
			part2 = true;
		} else if (spaceCounter > 1)
		{
			spaceCounter = 0;
		}
		
		Debug.Log(spaceCounter);
	}

	public void SpawnRoom()
	{
		if (rooms != null)
		{
			if (activeRoom!=null)
			{
				activeRoom.SetActive(false);
			}
			
			randomRoom = Random.Range(0, rooms.Length);
			activeRoom = rooms[randomRoom];
			activeRoom.SetActive(true);
		}
	}
}
