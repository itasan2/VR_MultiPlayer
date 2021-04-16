using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.XR;

public class AvatorMultiplayer : NetworkBehaviour
{
	public override void OnStartLocalPlayer()
	{
		if(isServer) {
			XRSettings.enabled = true;
		}

		GameObject camera = GameObject.FindWithTag("MainCamera");
		transform.parent = camera.transform;
		transform.localPosition = Vector3.zero;
		transform.rotation = camera.transform.rotation;
	}
}
