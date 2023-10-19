using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class StartScript : MonoBehaviour
{
    public void Scene1()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
