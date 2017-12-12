using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
	public GameObject[] rooms;
	public GameObject activeRoom;

	public int randomRoom;

	public static RoomManager instance;	

	private void Start()
	{
		instance = this;
		SpawnRoom();
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
