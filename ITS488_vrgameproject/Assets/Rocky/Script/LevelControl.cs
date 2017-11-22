using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelControl : MonoBehaviour {
	
	public int index;
	public string levelName;
	
	public Image black;
	public Animator anim;

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.CompareTag("Player"))
		{
			StartCoroutine(Fading());
			//SceneManager.LoadScene(1);
		}
	}
	
	IEnumerator Fading()
	{
		anim.SetBool("Fade",true);
		yield return new WaitUntil(()=>black.color.a==1);
		SceneManager.LoadScene(index);
	}
}
