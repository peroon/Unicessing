using UnityEngine;
using System.Collections;

public class OverdrawCamera : MonoBehaviour {

	// クリア方法
	public CameraClearFlags clearFlag = CameraClearFlags.Depth;
	
	void Start () {
		Camera.main.clearFlags = clearFlag;
	}
}
