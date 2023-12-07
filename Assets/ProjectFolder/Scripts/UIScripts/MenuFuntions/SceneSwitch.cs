using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{

    public void LoadScene(string levelToLoad)
    {
        StartCoroutine(LoadLevelASync(levelToLoad));
    }

    IEnumerator LoadLevelASync(string levelToLoad)
    {
        AsyncOperation loadOperation = SceneManager.LoadSceneAsync(levelToLoad);
        /*loadOperation.allowSceneActivation = false;
        yield return new WaitForSeconds(3);
        loadOperation.allowSceneActivation = true;*/
        yield return new WaitForSeconds(1);
    }
}
