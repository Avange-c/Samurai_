using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OpenMenuScript : MonoBehaviour
{
    public void onClick()
    {
        SceneManager.LoadScene(3);
    }
}
