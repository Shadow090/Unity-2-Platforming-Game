using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class canvasManager : MonoBehaviour
{
    public GameObject fadingPanel;

    private void Start()
    {
	if (fadingPanel != null)
	{
        	fadingPanel.SetActive(false);
	}
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ResetLevel()
    {
        StartCoroutine(FadingOut(SceneManager.GetActiveScene().buildIndex));
	//GameObject.Find("PlayerInfo").GetComponent<PlayerINFO>().ResetValues();
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevel()
    {
        StartCoroutine(FadingOut((SceneManager.GetActiveScene().buildIndex+1)%SceneManager.sceneCountInBuildSettings));
        //SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex+1)%SceneManager.sceneCountInBuildSettings);
    }

    private IEnumerator FadingOut(int sceneToLoad)
    {
        fadingPanel.SetActive(true);

        for(int i = 0; i < 100; i++)
        {
            fadingPanel.GetComponent<CanvasGroup>().alpha = (float)i * 0.01f;
            yield return new WaitForSecondsRealtime(0.01f);
        }
        SceneManager.LoadScene(sceneToLoad);
    }
}
