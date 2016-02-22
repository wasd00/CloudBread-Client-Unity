﻿using UnityEngine;
using System.Collections;
using Facebook.Unity;

public class AzureAuthentication : MonoBehaviour {

	void awake()
	{
		if (!FB.IsInitialized) {
			// Initialize the Facebook SDK
			FB.Init(InitCallback, OnHideUnity);
		} else {
			// Already initialized, signal an app activation App Event
			FB.ActivateApp();
		}
	}

	private void InitCallback ()
	{
		if (FB.IsInitialized) {
			// Signal an app activation App Event
			FB.ActivateApp();
			// Continue with Facebook SDK
			// ...
		} else {
			Debug.Log("Failed to Initialize the Facebook SDK");
		}
	}

	private void OnHideUnity (bool isGameShown)
	{
		if (!isGameShown) {
			// Pause the game - we will need to hide
			Time.timeScale = 0;
		} else {
			// Resume the game - we're getting focus again
			Time.timeScale = 1;
		}
	}

	public class AuthenticationToken
	{
	}
	public class FacebookGoogleAuthenticationToken : AuthenticationToken
	{
		public string access_token;
	}
	public class MicrosoftAuthenticationToken : AuthenticationToken
	{
		public string authenticationToken;
	}
}

public enum AuthenticationProvider
{
	// Summary:
	//     Microsoft Account authentication provider.
	MicrosoftAccount = 0,
	//
	// Summary:
	//     Google authentication provider.
	Google = 1,
	//
	// Summary:
	//     Twitter authentication provider.
	Twitter = 2,
	//
	// Summary:
	//     Facebook authentication provider.
	Facebook = 3,
}