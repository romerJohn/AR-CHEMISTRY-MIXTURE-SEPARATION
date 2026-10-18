using System.Collections;
using UnityEngine;
using TMPro;

public class SievingManager : MonoBehaviour
{
	[Header("Animations")]
	public Animator sandAnimator;
	public Animator stoneAnimator;

	[Header("Objects")]
	public Transform sand;
	public Transform stone;

	[Header("UI")]
	public GameObject narrationPanel;
	public TextMeshProUGUI infoText;

	[Header("Audio")]
	public AudioSource voiceAudio;

	private Vector3 sandStartLocalPos;
	private Quaternion sandStartLocalRot;
	private Vector3 sandStartScale;

	private Vector3 stoneStartLocalPos;
	private Quaternion stoneStartLocalRot;
	private Vector3 stoneStartScale;

	void Start()
	{
		sandStartLocalPos = sand.localPosition;
		sandStartLocalRot = sand.localRotation;
		sandStartScale = sand.localScale;

		stoneStartLocalPos = stone.localPosition;
		stoneStartLocalRot = stone.localRotation;
		stoneStartScale = stone.localScale;

		if (narrationPanel != null)
			narrationPanel.SetActive(false);

		if (infoText != null)
			infoText.text = "";
	}

	public void StartExperiment()
	{
		StopAllCoroutines();

		sand.gameObject.SetActive(true);
		stone.gameObject.SetActive(true);

		if (narrationPanel != null)
			narrationPanel.SetActive(false);

		if (infoText != null)
			infoText.text = "";

		sandAnimator.enabled = true;
		stoneAnimator.enabled = true;

		StartCoroutine(ExperimentSequence());
	}

	IEnumerator ExperimentSequence()
	{
		sandAnimator.Play("SandFall", 0, 0f);
		stoneAnimator.Play("StoneShake", 0, 0f);

		yield return new WaitForSeconds(3f);

		if (narrationPanel != null)
			narrationPanel.SetActive(true);

		if (infoText != null)
		{
			infoText.text =
			"The mixture is poured into the sieve. The small sand particles pass through the holes of the sieve, while the larger stones remain on top. This process is called sieving.";
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

		sandAnimator.enabled = false;
		stoneAnimator.enabled = false;

		sand.gameObject.SetActive(true);
		stone.gameObject.SetActive(true);

		sand.localPosition = sandStartLocalPos;
		sand.localRotation = sandStartLocalRot;
		sand.localScale = sandStartScale;

		stone.localPosition = stoneStartLocalPos;
		stone.localRotation = stoneStartLocalRot;
		stone.localScale = stoneStartScale;
	}
}