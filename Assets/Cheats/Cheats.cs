using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cheats : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            if (SceneManager.GetActiveScene().buildIndex == 1)
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            UpgradeVariables.money += 10f;
            UpgradeVariables.score += 10f;
        }
    }
}
