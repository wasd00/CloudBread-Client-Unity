﻿using UnityEngine;
using System.Collections;

public class CBLoginUI : CBBaseUI {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnGUI()
	{
		GUILayout.BeginArea (MainAreaRect);
			GUILayout.Button ("Facebook 인증", GUILayout.Width (100));
			GUILayout.Button ("Twitter 인증", GUILayout.Width (100));
			GUILayout.Button ("Google ID 인증", GUILayout.Width (100));
			GUILayout.Button ("Microsoft ID 인증", GUILayout.Width (100));
		GUILayout.EndArea ();

	}


}
