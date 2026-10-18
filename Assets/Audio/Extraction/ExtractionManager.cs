using System.Collections;
using UnityEngine;
using TMPro;

public class ExtractionManager : MonoBehaviour
{
	[Header("Objects")]
	public Animator solventAnimator;
	public Transform solvent;

	public GameObject waterBlue;
	public GameObject waterYellow;

	[Header("UI")]
	public GameObject narrationPanel;
	public TextMeshProUGUI infoText;

	[Header("Audio")]
	public AudioSource voiceAudio;

	private Vector3 solventStartLocalPos;
	private Quaternion solventStartLocalRot;
	private Vector3 solventStartLocalScale;

	void Start()
	{
		solventStartLocalPos = solvent.localPosition;
		solventStartLocalRot = solvent.localRotation;
		solventStartLocalScale = solvent.localScale;

		if (solventAnimator != null)
			solventAnimator.enabled = false;

		if (narrationPanel != null)
			narrationPanel.SetActive(false);

		ResetExperiment();
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

		solvent.gameObject.SetActive(true);

		if (solventAnimator != null)
		{
			solventAnimator.enabled = true;
			solventAnimator.Rebind();
			solventAnimator.Update(0f);
			solventAnimator.Play("SolventPour", 0, 0f);
		}

		yield return new WaitForSeconds(3f);

		solvent.gameObject.SetActive(false);

		waterYellow.SetActive(false);
		waterBlue.SetActive(true);

		if (narrationPanel != null)
			narrationPanel.SetActive(true);

		if (infoText != null)
		{
			infoText.text =
			"The solvent is added to the liquid mixture. The solvent helps separate one substance from the other liquid. This process is called extraction.";
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

		if (solventAnimator != null)
		{
			solventAnimator.StopPlayback();
			solventAnimator.Rebind();
			solventAnimator.Update(0f);
			solventAnimator.enabled = false;
		}

		solvent.gameObject.SetActive(true);

		solvent.localPosition = solventStartLocalPos;
		solvent.localRotation = solventStartLocalRot;
		solvent.localScale = solventStartLocalScale;

		waterBlue.SetActive(true);
		waterYellow.SetActive(true);
	}
}