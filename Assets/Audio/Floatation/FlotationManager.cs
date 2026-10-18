using System.Collections;
using UnityEngine;
using TMPro;

public class FlotationManager : MonoBehaviour
{
	[Header("Objects")]
	public Animator oilAnimator;
	public Transform oil;

	[Header("UI")]
	public GameObject narrationPanel;
	public TextMeshProUGUI infoText;

	[Header("Audio")]
	public AudioSource voiceAudio;

	private Vector3 oilStartLocalPos;
	private Quaternion oilStartLocalRot;
	private Vector3 oilStartScale;

	void Start()
	{
		oilStartLocalPos = oil.localPosition;
		oilStartLocalRot = oil.localRotation;
		oilStartScale = oil.localScale;

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
		if (narrationPanel != null)
			narrationPanel.SetActive(false);

		if (infoText != null)
			infoText.text = "";

		oilAnimator.enabled = true;
		oilAnimator.Play("OilPour", 0, 0f);

		yield return new WaitForSeconds(3f);

		if (narrationPanel != null)
			narrationPanel.SetActive(true);

		if (infoText != null)
		{
			infoText.text =
			"The oil is poured into the beaker containing water. Oil floats on top because it is less dense than water. This process demonstrates flotation.";
		}

		if (voiceAudio != null)
			voiceAudio.Play();
	}

	public void ResetExperiment()
	{
		StopAllCoroutines();

		if (voiceAudio != null)
			voiceAudio.Stop();

		if (narrationPanel != null)
			narrationPanel.SetActive(false);

		if (infoText != null)
			infoText.text = "";

		oilAnimator.enabled = false;

		oil.localPosition = oilStartLocalPos;
		oil.localRotation = oilStartLocalRot;
		oil.localScale = oilStartScale;
	}
}