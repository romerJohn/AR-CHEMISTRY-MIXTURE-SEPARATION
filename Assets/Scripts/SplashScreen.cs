using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SplashScreen : MonoBehaviour
{
	public float delayTime = 10f;

	void Start()
	{
		StartCoroutine(LoadScene());
	}

	IEnumerator LoadScene()
	{
		yield return new WaitForSeconds(delayTime);
		SceneManager.LoadScene("StartScene");
	}
}