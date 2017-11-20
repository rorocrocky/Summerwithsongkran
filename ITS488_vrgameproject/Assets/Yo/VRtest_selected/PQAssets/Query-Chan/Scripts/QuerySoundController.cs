using UnityEngine;
using System.Collections;

//[RequireComponent(typeof(AudioSource))]

public class QuerySoundController : MonoBehaviour {
	
	
	public AudioClip[] soundData;

	public enum QueryChanSoundType
	{
		
		DO_ME_A_FAVOR = 0,
		GOOD_MORNING = 1,
		GOOD_NIGHT_01 = 2,
		GOOD_NIGHT_02 = 3,
		GREETING_01 = 4,
	}

	
	public void PlaySoundByType (QueryChanSoundType soundNumber) {

		this.GetComponent<AudioSource>().Stop();
		this.GetComponent<AudioSource>().PlayOneShot(soundData[(int)soundNumber]);
		
	}


	public void PlaySoundByNumber (int soundNumber) {
		
		this.GetComponent<AudioSource>().Stop();
		this.GetComponent<AudioSource>().PlayOneShot(soundData[soundNumber]);
		
	}


	public void StopSound () {

		this.GetComponent<AudioSource>().Stop();
		
	}
	
}
