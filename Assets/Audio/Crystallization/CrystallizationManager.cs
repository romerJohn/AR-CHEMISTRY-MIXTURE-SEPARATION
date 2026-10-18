using System.Collections;
using UnityEngine;
using TMPro;

public class CrystallizationManager : MonoBehaviour
{
	[Header("Objects")]
	public Animator saltAnimator;
	public Transform salt;

	public GameObject fire;
	public GameObject moisture;

	[Header("UI")]
	public GameObject narrationPanel;
	public TextMeshProUGUI infoText;

	[Header("Audio")]
	public AudioSource voiceAudio;

	private Vector3 saltStartLocalPos;
	private Quaternion saltStartLocalRot;
	private Vector3 saltStartScale;

	void Start()
	{
		// SAVE ORIGINAL VALUES
		saltStartLocalPos = salt.localPosition;
		saltStartLocalRot = salt.localRotation;
		saltStartScale = salt.localScale;

		// HIDE OBJECTS
		fire.SetActive(false);
		moisture.SetActive(false);

		// HIDE PANEL
		if (narrationPanel != null)
			narrationPanel.SetActive(false);

		// CLEAR TEXT
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

		// PLAY ANIMATION
		saltAnimator.enabled = true;
		saltAnimator.Play("Salt", 0, 0f);

		// WAIT FOR SALT TO MOVE
		yield return new WaitForSeconds(2f);

		// SHOW FIRE
		fire.SetActive(true);

		// WAIT
		yield return new WaitForSeconds(1f);

		// SHOW MOISTURE
		moisture.SetActive(true);

		// WAIT
		yield return new WaitForSeconds(1f);

		// SHOW PANEL
		if (narrationPanel != null)
			narrationPanel.SetActive(true);

		// SHOW TEXT
		if (infoText != null)
		{
			infoText.text =
			"The fire heats the salt solution. The water evaporates and becomes moisture. After the water is removed, salt crystals are left behind. This process is called crystallization.";
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
		moisture.SetActive(false);

		// STOP ANIMATOR
		saltAnimator.enabled = false;

		// RESET POSITION
		salt.localPosition = saltStartLocalPos;
		salt.localRotation = saltStartLocalRot;
		salt.localScale = saltStartScale;
	}
}