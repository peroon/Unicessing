using UnityEngine;
using System.Collections;

public class PrefabMultiplier : MonoBehaviour {

	public GameObject prefab;
	public int num;

	void Start () {
		for (int i = 0; i < num; i++) {
			var go = Instantiate (prefab, transform.position, Quaternion.identity) as GameObject;
			go.GetComponent<Renderer> ().material.color = ColorUtil.RandomColor (); 
		}	
	}
	
}
