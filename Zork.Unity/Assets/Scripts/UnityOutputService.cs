using TMPro;
using UnityEngine;
using Zork;

public class UnityOutputService : MonoBehaviour, IOutputService
{
    [SerializeField]
    private GameObject OutputText;

    [SerializeField]
    private GameObject OutPutTextContainer;

    public void Clear()
    {
        for(int Entries = 0; Entries < OutPutTextContainer.transform.childCount; ++Entries)
        {
            Destroy(OutPutTextContainer.transform.GetChild(Entries).gameObject);
        }
    }

    public void Write(object value)
    {
        Write(value.ToString());
    }

    public void Write(string value)
    {
        int Entries = OutPutTextContainer.transform.childCount;

        if (Entries == 0)
        {
            Instantiate(OutputText, OutPutTextContainer.transform);
        }
        else
        {
            GameObject latest = OutPutTextContainer.transform.GetChild(Entries - 1).gameObject;
            latest.GetComponent<TMP_Text>().text += value;
        }
    }

    public void WriteLine(object value)
    {
        WriteLine(value.ToString());
    }

    public void WriteLine(string value)
    {
        GameObject textLine = Instantiate(OutputText, OutPutTextContainer.transform);

        textLine.GetComponent<TMP_Text>().text = value;
    }
}
