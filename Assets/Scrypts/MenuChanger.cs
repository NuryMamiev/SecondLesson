using UnityEngine;

public class MenuChanger : MonoBehaviour
{
    [SerializeField] private GameObject[] pannels;

    private void Start()
    {
        SwitchPannel(0);
    }
    private void SwitchPannel(int pannelIndex)
    {
        if(pannelIndex < 0 || pannelIndex >= pannels.Length)
        {
            Debug.LogError("invalid index");
            return;
        }
        foreach (var panel in pannels)
        {
            panel.SetActive(false);
        }
        pannels[pannelIndex].SetActive(true);
    }

    public void GoToMainMenu() => SwitchPannel(0);
    public void GoToButtons() => SwitchPannel(1);
    public void GoToToggles() => SwitchPannel(2);
    public void GoToDrops() => SwitchPannel(3);
    public void GoToInputPannel() => SwitchPannel(4);
    public void GoToScroll() => SwitchPannel(5);
}
