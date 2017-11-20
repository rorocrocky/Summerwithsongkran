using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBullet : MonoBehaviour {

    public AudioSource audioSource;

    public GameObject destroyedVersion;
    private GameObject ThisgameObject;

    public int amount = 1;

    // Reference to the shattered version of the object

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        ScoreCount sc = FindObjectOfType<ScoreCount>();
        sc.increaseScore(amount);

        // transform.Rotate(new Vector3(45f, 0f, 0f));
        ThisgameObject = Instantiate(destroyedVersion, transform.position, transform.rotation);
        ThisgameObject.transform.Rotate(new Vector3(-90f, 0f, 0f));
        Destroy(other.gameObject);
        Destroy(this.gameObject);
    }

}
