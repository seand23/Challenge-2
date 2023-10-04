using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class Link : MonoBehaviour 
{

	public void OpenGitHub()
	{
		#if !UNITY_EDITOR
		openWindow("https://github.com/seand23");
		#endif
	}

	[DllImport("__Internal")]
	private static extern void openWindow(string url);

}