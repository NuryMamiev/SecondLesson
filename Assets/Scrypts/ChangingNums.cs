using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class ChangingNums : MonoBehaviour
{
    public TextMeshProUGUI displayText;
    public Button button;
    public Button button2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeText(string text)
    {
        displayText.text = text;
    }
    public void DisableButt()
    {
        button.interactable = false;
        button2.interactable = false;
    }
    public void EnableButt()
    {
        button.interactable = true;
        button2.interactable = true;
    }
}
