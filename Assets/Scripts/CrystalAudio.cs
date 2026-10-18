using UnityEngine;

public class CrystalAudio : MonoBehaviour
{
	public AudioSource audioSource;

	// =========================
	// CRYSTALLIZATION
	// =========================
	[Header("Crystallization")]
	public AudioClip crystalDefinition;
	public AudioClip crystalMaterials;
	public AudioClip crystalProcedure;
	public AudioClip crystalApplications;

	// =========================
	// MAGNETIC SEPARATION
	// =========================
	[Header("Magnetic Separation")]
	public AudioClip magneticDefinition;
	public AudioClip magneticMaterials;
	public AudioClip magneticProcedure;
	public AudioClip magneticApplications;

	// =========================
	// FLOATATION
	// =========================
	[Header("Floatation")]
	public AudioClip floatationDefinition;
	public AudioClip floatationMaterials;
	public AudioClip floatationProcedure;
	public AudioClip floatationApplications;

	// =========================
	// EVAPORATION
	// =========================
	[Header("Evaporation")]
	public AudioClip evaporationDefinition;
	public AudioClip evaporationMaterials;
	public AudioClip evaporationProcedure;
	public AudioClip evaporationApplications;

	// =========================
	// EXTRACTION
	// =========================
	[Header("Extraction")]
	public AudioClip extractionDefinition;
	public AudioClip extractionMaterials;
	public AudioClip extractionProcedure;
	public AudioClip extractionApplications;

	// =========================
	// SIEVING
	// =========================
	[Header("Sieving")]
	public AudioClip sievingDefinition;
	public AudioClip sievingMaterials;
	public AudioClip sievingProcedure;
	public AudioClip sievingApplications;

	// ==================================================
	// TOGGLE AUDIO FUNCTION
	// ==================================================
	void ToggleAudio(AudioClip clip)
	{
		// Stop if same audio is clicked again
		if (audioSource.isPlaying && audioSource.clip == clip)
		{
			audioSource.Stop();
		}
		else
		{
			// Play new audio
			audioSource.clip = clip;
			audioSource.Play();
		}
	}

	// ==================================================
	// CRYSTALLIZATION FUNCTIONS
	// ==================================================
	public void PlayCrystalDefinition()
	{
		ToggleAudio(crystalDefinition);
	}

	public void PlayCrystalMaterials()
	{
		ToggleAudio(crystalMaterials);
	}

	public void PlayCrystalProcedure()
	{
		ToggleAudio(crystalProcedure);
	}

	public void PlayCrystalApplications()
	{
		ToggleAudio(crystalApplications);
	}

	// ==================================================
	// MAGNETIC FUNCTIONS
	// ==================================================
	public void PlayMagneticDefinition()
	{
		ToggleAudio(magneticDefinition);
	}

	public void PlayMagneticMaterials()
	{
		ToggleAudio(magneticMaterials);
	}

	public void PlayMagneticProcedure()
	{
		ToggleAudio(magneticProcedure);
	}

	public void PlayMagneticApplications()
	{
		ToggleAudio(magneticApplications);
	}

	// ==================================================
	// FLOATATION FUNCTIONS
	// ==================================================
	public void PlayFloatationDefinition()
	{
		ToggleAudio(floatationDefinition);
	}

	public void PlayFloatationMaterials()
	{
		ToggleAudio(floatationMaterials);
	}

	public void PlayFloatationProcedure()
	{
		ToggleAudio(floatationProcedure);
	}

	public void PlayFloatationApplications()
	{
		ToggleAudio(floatationApplications);
	}

	// ==================================================
	// EVAPORATION FUNCTIONS
	// ==================================================
	public void PlayEvaporationDefinition()
	{
		ToggleAudio(evaporationDefinition);
	}

	public void PlayEvaporationMaterials()
	{
		ToggleAudio(evaporationMaterials);
	}

	public void PlayEvaporationProcedure()
	{
		ToggleAudio(evaporationProcedure);
	}

	public void PlayEvaporationApplications()
	{
		ToggleAudio(evaporationApplications);
	}

	// ==================================================
	// EXTRACTION FUNCTIONS
	// ==================================================
	public void PlayExtractionDefinition()
	{
		ToggleAudio(extractionDefinition);
	}

	public void PlayExtractionMaterials()
	{
		ToggleAudio(extractionMaterials);
	}

	public void PlayExtractionProcedure()
	{
		ToggleAudio(extractionProcedure);
	}

	public void PlayExtractionApplications()
	{
		ToggleAudio(extractionApplications);
	}

	// ==================================================
	// SIEVING FUNCTIONS
	// ==================================================
	public void PlaySievingDefinition()
	{
		ToggleAudio(sievingDefinition);
	}

	public void PlaySievingMaterials()
	{
		ToggleAudio(sievingMaterials);
	}

	public void PlaySievingProcedure()
	{
		ToggleAudio(sievingProcedure);
	}

	public void PlaySievingApplications()
	{
		ToggleAudio(sievingApplications);
	}
}
