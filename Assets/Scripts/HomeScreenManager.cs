using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeScreenManager : MonoBehaviour
{
	public void OpenCrystallization()
	{
		ExperimentData.selectedExperiment = "Crystallization";
		SceneManager.LoadScene("InstructionScene");
	}

	public void OpenMagnetic()
	{
		ExperimentData.selectedExperiment = "Magnetic";
		SceneManager.LoadScene("InstructionScene");
	}

	public void OpenFloatation()
	{
		ExperimentData.selectedExperiment = "Floatation";
		SceneManager.LoadScene("InstructionScene");
	}

	public void OpenEvaporation()
	{
		ExperimentData.selectedExperiment = "Evaporation";
		SceneManager.LoadScene("InstructionScene");
	}

	public void OpenExtraction()
	{
		ExperimentData.selectedExperiment = "Extraction";
		SceneManager.LoadScene("InstructionScene");
	}

	public void OpenSieving()
	{
		ExperimentData.selectedExperiment = "Sieving";
		SceneManager.LoadScene("InstructionScene");
	}

	public void BackToStartScene()
	{
		SceneManager.LoadScene("StartScene");
	}
}