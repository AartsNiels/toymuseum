using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnTouchChangeScene : MonoBehaviour
{
    public string scene;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(LoadSceneWithDelay(scene, 5f));
        }
    }

    IEnumerator LoadSceneWithDelay(string sceneName, float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
    }

    public void ChangeScene(string sceneName)
    {
        StartCoroutine(LoadSceneWithDelay(sceneName, 5f));
    }
}
