using System.Collections;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using System.IO;

public class SplashVideoManager : MonoBehaviour
{
	public VideoPlayer videoPlayer;
	public AudioSource musicSource;

	public string videoFileName = "splash_new.mp4";
	public string nextSceneName = "StartScene";

	IEnumerator Start()
	{
		string path = Path.Combine(Application.streamingAssetsPath, videoFileName);

		videoPlayer.source = VideoSource.Url;
		videoPlayer.url = path;

		videoPlayer.Prepare();

		while (!videoPlayer.isPrepared)
		{
			yield return null;
		}

		videoPlayer.Play();
		musicSource.Play();

		videoPlayer.loopPointReached += OnVideoFinished;
	}

	void OnVideoFinished(VideoPlayer vp)
	{
		musicSource.Stop();
		SceneManager.LoadScene(nextSceneName);
	}
}