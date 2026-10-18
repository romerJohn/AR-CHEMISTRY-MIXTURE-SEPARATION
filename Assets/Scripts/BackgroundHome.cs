using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundHome : MonoBehaviour
{
	private static BackgroundHome instance;

	private AudioSource audioSource;

	void Awake()
	{
		// Check if another AudioManager already exists
		if (instance != null && instance != this)
		{
			Destroy(gameObject);
			return;
		}

		instance = this;

		// Keep music when changing scenes
		DontDestroyOnLoad(gameObject);

		audioSource = GetComponent<AudioSource>();

		// Play only if not already playing
		if (!audioSource.isPlaying)
		{
			audioSource.Play();
		}
	}
	
}
