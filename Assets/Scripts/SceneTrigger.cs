
using UnityEngine;

using UnityEngine.SceneManagement;

public class SceneTrigger : MonoBehaviour

{

    [Header("Scene to load on trigger enter")]

    public string sceneToLoad;

    private void OnTriggerEnter2D(Collider2D other)

    {

        if (other.CompareTag("Player"))

        {

            if (!string.IsNullOrEmpty(sceneToLoad))

            {

                SceneManager.LoadScene(sceneToLoad);

            }

            else

            {

                Debug.LogWarning("SceneTrigger: No scene name assigned!");

            }

        }

    }

}

