using UnityEngine;
using System.Collections;

// Boid UI

public class Tester : MonoBehaviour
{
    BoidController controller;

    void Start(){
        controller = FindObjectOfType<BoidController>();
    }

	public void OnClickSpawn(){
		controller.RandomSpawn ();
	}

	public void OnClickSpawnOffScreen(){
		controller.Spawn(controller.transform.position - controller.transform.forward * 8);
	}
}