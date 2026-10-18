using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionManager : MonoBehaviour
{
	public GameObject crystallizationPanel;
	public GameObject magneticPanel;
	public GameObject floatationPanel;
	public GameObject extractionPanel;
	public GameObject evaporationPanel;
	public GameObject sievingPanel;

	void Start()
	{


		// Show selected panel
		switch (ExperimentData.selectedExperiment)
		{
			case "Crystallization":
				crystallizationPanel.SetActive(true);
				break;

			case "Magnetic":
				magneticPanel.SetActive(true);
				break;

			case "Floatation":
				floatationPanel.SetActive(true);
				break;

			case "Extraction":
				extractionPanel.SetActive(true);
				break;

			case "Evaporation":
				evaporationPanel.SetActive(true);
				break;

			case "Sieving":
				sievingPanel.SetActive(true);
				break;
		}
	}
	public void StartARSimulation()
	{
		switch (ExperimentData.selectedExperiment)
		{
			case "Magnetic":
				SceneManager.LoadScene("ARScene_Magnetic");
				break;

			case "Crystallization":
				SceneManager.LoadScene("ARScene_Crystallization");
				break;

			case "Floatation":
				SceneManager.LoadScene("ARScene_Floatation");
				break;

			case "Extraction":
				SceneManager.LoadScene("ARScene_Extraction");
				break;

			case "Evaporation":
				SceneManager.LoadScene("ARScene_Evaporation");
				break;

			case "Sieving":
				SceneManager.LoadScene("ARScene_Sieving");
				break;
		}
	}

	// BACK BUTTON
	public void BackToHome()
	{
		SceneManager.LoadScene("HomeScene");
	}
}