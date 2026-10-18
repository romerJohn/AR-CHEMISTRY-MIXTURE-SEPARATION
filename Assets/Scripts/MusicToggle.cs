using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MusicToggle : MonoBehaviour
{
	public AudioSource musicSource;

	// Assign your TMP Text here
	public TextMeshProUGUI buttonText;

	void Start()
	{
		// Default text when music starts playing
		if (musicSource.isPlaying)
			buttonText.text = "Stop Sound";
		else
			buttonText.text = "Play Sound";
	}

	public void ToggleMusic()
	{
		if (musicSource.isPlaying)
		{
			musicSource.Pause();
			buttonText.text = "Play Sound";
		}
		else
		{
			musicSource.Play();
			buttonText.text = "Stop Sound";
		}
	}
}