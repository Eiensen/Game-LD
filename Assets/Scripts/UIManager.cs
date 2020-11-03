using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject MainUIPanel;
    public GameObject ResultPanel;
    public Joystick joystick;

    public void MainUIPanelSetActiv()
    {
        if (!MainUIPanel.activeInHierarchy)
            MainUIPanel.SetActive(true);
    }

    public void MainUIPanelSetInactive()
    {
        if (MainUIPanel.activeInHierarchy)
            MainUIPanel.SetActive(false);
    }

    public void ResultPanelSetActive()
    {
        if (!ResultPanel.activeInHierarchy)
            ResultPanel.SetActive(true);
    }

    public void ResultPanelSetInacrive()
    {
        if (ResultPanel.activeInHierarchy)
            ResultPanel.SetActive(false);
    }
}
