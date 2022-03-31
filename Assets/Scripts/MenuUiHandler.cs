using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[DefaultExecutionOrder(1000)]
public class MenuUiHandler : MonoBehaviour
{

    public void GetText()
    {

        NameSaver.Instance.displayText();

    }

    public void StartNew()
    {

        SceneManager.LoadScene(1);


    }

}
