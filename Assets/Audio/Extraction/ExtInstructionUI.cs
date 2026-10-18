using UnityEngine;

public class ExtInstructionUI : MonoBehaviour
{
	public GameObject instructionPanel;

	public GameObject instructionButton;

	public AudioSource instructionVoice;

	public void ShowInstructions()
	{
		// SHOW PANEL
		instructionPanel.SetActive(true);

		// HIDE BUTTON
		instructionButton.SetActive(false);

		// PLAY VOICE
		if (instructionVoice != null)
		{
			instructionVoice.Play();
		}
	}

	public void HideInstructions()
	{
		// HIDE PANEL
		instructionPanel.SetActive(false);

		// SHOW BUTTON AGAIN
		instructionButton.SetActive(true);

		// STOP VOICE
		if (instructionVoice != null)
		{
			instructionVoice.Stop();
		}
	}
}