using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSounds : MonoBehaviour {
	
	public AudioClip[] part1stems;
	public AudioClip[] part2stems;

	public AudioClip currentStem1;
	public AudioClip currentStem2;
	public AudioClip indicatorPt1;
	public AudioClip indicatorPt2;
	public int randomStem1;
	public int randomStem2;

	public int randomStemPt2_1;
	public int randomStemPt2_2;

	public AudioSource stem1;
	public AudioSource stem2;

	public AudioSource indicator;
	
	private void OnEnable()
	{

		if (RoomManager.instance.part2)
		{
			randomStemPt2_1 = Random.Range(0, part2stems.Length);
			randomStemPt2_2 = Random.Range(0, part2stems.Length);
			
			currentStem1 = part2stems[randomStemPt2_1];
			currentStem2 = part2stems[randomStemPt2_2];

			stem1.clip = currentStem1;
			stem2.clip = currentStem2;
		
			stem1.Play();
			stem2.Play();

			indicator = GameObject.FindGameObjectWithTag("Indicator").GetComponent<AudioSource>();

			indicator.clip = indicatorPt2;
			indicator.Play();
		}
		else if (RoomManager.instance.part1)
		{
			randomStem1 = Random.Range(0, part1stems.Length);
			randomStem2 = Random.Range(0, part1stems.Length);

			currentStem1 = part1stems[randomStem1];
			currentStem2 = part1stems[randomStem2];

			stem1.clip = currentStem1;
			stem2.clip = currentStem2;
		
			stem1.Play();
			stem2.Play();
			
			indicator = GameObject.FindGameObjectWithTag("Indicator").GetComponent<AudioSource>();

			indicator.clip = indicatorPt1;
			indicator.Play();
		}
	}
}
