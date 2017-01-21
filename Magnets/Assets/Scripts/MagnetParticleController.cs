using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetParticleController : MonoBehaviour {

	public ParticleSystem magnetWaveParticleSystem;

	// Use this for initialization
	void Start () {
		magnetWaveParticleSystem = FindObjectOfType<ParticleSystem> ();
	}
	
	// Update is called once per frame
	void Update () {
		emitMagneticWaveParticles ();
	}

	void emitMagneticWaveParticles(){
		if (Input.GetKey (KeyCode.A) && magnetWaveParticleSystem.isStopped) {
			magnetWaveParticleSystem.Play();
			Debug.Log ("emit waves");
		} else if(Input.GetKeyUp(KeyCode.A) && magnetWaveParticleSystem.isPlaying) {
			magnetWaveParticleSystem.Stop ();
			Debug.Log ("Dont emit waves");
		}
	}
}
