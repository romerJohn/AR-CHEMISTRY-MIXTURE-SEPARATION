using UnityEngine;
using UnityEngine.SceneManagement;

public class BacktoInstruction : MonoBehaviour
{
	public void BackToInstruction()
	{
		SceneManager.LoadScene("InstructionScene");
	}
}
