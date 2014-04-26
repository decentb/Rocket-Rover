﻿using UnityEngine;
using System.Collections;

public class RampSpawner : MonoBehaviour {

    public Transform rampPrefab;

    public float rampSpeed = 10.0f;

	// Use this for initialization
	void Start ()
    {
        StartCoroutine("SpawnRamp");
	}

    IEnumerator SpawnRamp()
    {
        while (true)
        {
            yield return new WaitForSeconds(4.0f);
            Transform ramp = Instantiate(rampPrefab, transform.position, Quaternion.identity) as Transform;
            ramp.name = rampPrefab.name;
            ramp.rigidbody2D.velocity = new Vector3(-rampSpeed, 0, 0);
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
