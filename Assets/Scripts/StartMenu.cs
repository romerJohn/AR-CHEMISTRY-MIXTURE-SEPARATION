using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
	// Load Home Scene
	public void StartApp()
	{
		SceneManager.LoadScene("HomeScene");
	}

	// Exit Application
	public void ExitApp()
	{
		Application.Quit();

		// For testing in Unity Editor
		Debug.Log("Application Closed");
	}
}