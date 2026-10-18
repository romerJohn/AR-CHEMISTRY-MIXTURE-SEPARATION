using System.Collections;
using UnityEngine;
using TMPro;

public class EvaporationManager : MonoBehaviour
{
	[Header("Objects")]
	public GameObject fire;
	public GameObject steam;

	[Header("UI")]
	public GameObject narrationPanel;
	public TextMeshProUGUI infoText;

	[Header("Audio")]
	public AudioSource voiceAudio;

	void Start()
	{
		fire.SetActive(false);
		steam.SetActive(false);

		if (narrationPanel != null)
			narrationPanel.SetActive(false);

		if (infoText != null)
			infoText.text = "";
	}

	public void StartExperiment()
	{
		StopAllCoroutines();
		StartCoroutine(ExperimentSequence());
	}

	IEnumerator ExperimentSequence()
	{
		// RESET PANEL
		if (narrationPanel != null)
			narrationPanel.SetActive(false);

		if (infoText != null)
			infoText.text = "";

		// SHOW FIRE
		fire.SetActive(true);

		yield return new WaitForSeconds(1f);

		// SHOW STEAM
		steam.SetActive(true);

		yield return new WaitForSeconds(1f);

		// SHOW PANEL
		if (narrationPanel != null)
			narrationPanel.SetActive(true);

		// SHOW TEXT
		if (infoText != null)
		{
			infoText.text =
			"The salt water is heated using fire. As the temperature increases, the water evaporates and turns into vapor or steam. This process is called evaporation.";
		}

		// PLAY AUDIO
		if (voiceAudio != null)
			voiceAudio.Play();
	}

	public void ResetExperiment()
	{
		StopAllCoroutines();

		// STOP AUDIO
		if (voiceAudio != null)
			voiceAudio.Stop();

		// HIDE PANEL
		if (narrationPanel != null)
			narrationPanel.SetActive(false);

		// CLEAR TEXT
		if (infoText != null)
			infoText.text = "";

		// HIDE OBJECTS
		fire.SetActive(false);
		steam.SetActive(false);
	}
}