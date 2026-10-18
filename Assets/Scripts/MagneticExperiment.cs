using System.Collections;
using UnityEngine;
using TMPro;

public class MagneticExperiment : MonoBehaviour
{
	[Header("Animation")]
	public Animator magnetAnimator;

	[Header("Objects")]
	public Transform magnet;
	public Transform iron;

	[Header("UI")]
	public GameObject narrationPanel;
	public TextMeshProUGUI infoText;

	[Header("Audio")]
	public AudioSource voiceAudio;

	[Header("Timing")]
	public float magnetMoveTime = 2f;
	public float waitBeforeAttach = 1f;

	private Vector3 magnetStartLocalPos;
	private Quaternion magnetStartLocalRot;
	private Vector3 magnetStartScale;

	private Vector3 ironStartLocalPos;
	private Quaternion ironStartLocalRot;
	private Vector3 ironStartScale;

	private Transform ironOriginalParent;

	void Start()
	{
		magnetStartLocalPos = magnet.localPosition;
		magnetStartLocalRot = magnet.localRotation;
		magnetStartScale = magnet.localScale;

		ironOriginalParent = iron.parent;
		ironStartLocalPos = iron.localPosition;
		ironStartLocalRot = iron.localRotation;
		ironStartScale = iron.localScale;

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
		magnet.gameObject.SetActive(true);
		iron.gameObject.SetActive(true);

		if (narrationPanel != null)
			narrationPanel.SetActive(false);

		if (infoText != null)
			infoText.text = "";

		magnetAnimator.enabled = true;
		magnetAnimator.Play("MagnetMove", 0, 0f);

		yield return new WaitForSeconds(magnetMoveTime);
		yield return new WaitForSeconds(waitBeforeAttach);

		iron.SetParent(magnet, true);
		iron.localPosition = new Vector3(0, -0.05f, 0);

		if (narrationPanel != null)
			narrationPanel.SetActive(true);

		if (infoText != null)
		{
			infoText.text =
			"The magnet attracts the iron particles because iron is a magnetic material, while the sand remains because it is non-magnetic. This process is called magnetic separation.";
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

		magnetAnimator.enabled = false;

		magnet.localPosition = magnetStartLocalPos;
		magnet.localRotation = magnetStartLocalRot;
		magnet.localScale = magnetStartScale;

		iron.SetParent(ironOriginalParent, false);
		iron.localPosition = ironStartLocalPos;
		iron.localRotation = ironStartLocalRot;
		iron.localScale = ironStartScale;

		magnet.gameObject.SetActive(true);
		iron.gameObject.SetActive(true);
	}
}