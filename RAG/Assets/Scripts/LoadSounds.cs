using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSounds : MonoBehaviour {
	
	public AudioClip[] part1stems;
	public AudioClip[] part2stems;

	public AudioClip currentStem1;
	public AudioClip currentStem2;
	public int randomStem1;
	public int randomStem2;

	public AudioSource stem1;
	public AudioSource stem2;
	
	private void OnEnable()
	{
		randomStem1 = Random.Range(0, part1stems.Length);
		randomStem2 = Random.Range(0, part1stems.Length);

		currentStem1 = part1stems[randomStem1];
		currentStem2 = part1stems[randomStem2];

		stem1.clip = currentStem1;
		stem2.clip = currentStem2;
		
		stem1.Play();
		stem2.Play();
	}
}
