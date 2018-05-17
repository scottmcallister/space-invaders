using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

	public static SoundManager Instance = null;
	public AudioClip alienBuzz1;
	public AudioClip alienBuzz2;
	public AudioClip alienDies;
	public AudioClip bulletFire;
	public AudioClip shipExplosion;

	private AudioSource soundEffectAudio;

	// Use this for initialization
	void Start () {
		if (Instance == null) {
			Instance = this;
		} else if (Instance != this) {
			Destroy(gameObject);
		}

		soundEffectAudio = GetComponent<AudioSource>();
	}
	
	public void playOneShot(AudioClip clip) {
		soundEffectAudio.PlayOneShot(clip);
	}
}
