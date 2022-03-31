using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UiMainScene : MonoBehaviour
{

    public Text playerNameText;

    public void Start()
    {

        playerNameText.text = "Name: " + NameSaver.Instance.PlayerName;

    }
}
