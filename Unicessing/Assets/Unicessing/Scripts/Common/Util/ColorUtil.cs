using UnityEngine;
using System.Collections;

public class ColorUtil : MonoBehaviour {

	public static Color RandomColor(){
		return new Color(Random.value, Random.value, Random.value);
	}

}
