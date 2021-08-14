using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenApp : MonoBehaviour
{
	public void openUberApp()
	{
		bool fail = false;
		string bundleId = "com.ubercab";// ur target bundle id
		AndroidJavaClass up = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
		AndroidJavaObject ca = up.GetStatic<AndroidJavaObject>("currentActivity");
		AndroidJavaObject packageManager = ca.Call<AndroidJavaObject>("getPackageManager");

		AndroidJavaObject launchIntent = null;
		try
		{
			launchIntent = packageManager.Call<AndroidJavaObject>("getLaunchIntentForPackage", bundleId);
		}
			catch (System.Exception e)
			{
				fail = true;
				Debug.Log("Failed!");

			}

		if (fail)
		{ //open app in store
			Application.OpenURL("https://play.google.com/store/apps/details?id=com.ubercab&hl=en&gl=US");
		}
		else //open the app
			ca.Call("startActivity", launchIntent);

		up.Dispose();
		ca.Dispose();
		packageManager.Dispose();
		launchIntent.Dispose();
	}
}
