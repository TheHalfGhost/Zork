using System;
using UnityEngine;
using Zork;
using TMPro;

public class UnityInputService : MonoBehaviour, IInputService
{
    [SerializeField]
    private TMP_InputField InputField;

   public event EventHandler<string> InputReceived;

    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            string inputstring = InputField.text.Trim().ToUpper();

            if (string.IsNullOrEmpty(inputstring) == false)
            {
                InputReceived?.Invoke(this, inputstring);
            }

            InputField.text = string.Empty;
        }
    }
}
