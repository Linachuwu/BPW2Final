using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    //Code taken from "Switching Scene On Trigger Unity (Code in Desc if anyone wants it)" by Emerald Development on YouTube.

    public int LevelIndex;

    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            SceneManager.LoadScene(LevelIndex);
    }
}