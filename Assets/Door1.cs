using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door1 : MonoBehaviour
{
    public int SceneBuildIndex;

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Trigger Entered");
        if (other.tag == "Player")
        {
            print("Switching Scene to " + SceneBuildIndex);
            SceneManager.LoadScene(SceneBuildIndex, LoadSceneMode.Single);
        }
    }
}
