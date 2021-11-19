using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zork;

public class UnityOutputService : MonoBehaviour, IOutputService
{
    [SerializeField]
    private TextMeshProUGUI OutputText;

    [SerializeField]
    private Transform OutPutTextContainer;

    [SerializeField]
    private Image NewLinePrefab;

    [SerializeField]
    private int MaxEntries;

    private readonly List<GameObject> Entries;

    public UnityOutputService() => Entries = new List<GameObject>();

    private void Start()
    {

    }

    public void Clear()
    {
        Entries.ForEach(entry => Destroy(entry));
    }

    public void Write(string value)
    {
        var textLine = GameObject.Instantiate(OutputText);

        textLine.transform.SetParent(OutPutTextContainer);

        OutputText.text = value;

        Entries.Add(OutputText.gameObject);
    }

    public void WriteLine(string value)
    {
        ParseAndWriteLine(value);
    }

    private void ParseAndWriteLine(string value)
    {
        string[] delimiters = { "\n" };

        var lines = value.Split(delimiters, StringSplitOptions.None);

        foreach (var line in lines)
        {
            if(Entries.Count >= MaxEntries)
            {
                var entry = Entries.First();

                Destroy(entry);

                Entries.Remove(entry);
            }

            if (string.IsNullOrWhiteSpace(line))
            {
                WriteNewLine();
            }
            else
            {
                WriteTextLine(line);
            }
        }
    }

    private void WriteNewLine()
    {
        var newLine = Instantiate(NewLinePrefab);

        newLine.transform.SetParent(OutPutTextContainer, false);

        Entries.Add(newLine.gameObject);
    }

    private void WriteTextLine(string value)
    {
        var textLine = GameObject.Instantiate(OutputText);

        textLine.transform.SetParent(OutPutTextContainer, false);

        OutputText.text = value;

        Entries.Add(textLine.gameObject);
    }
}
