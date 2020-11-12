using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject IndiaDetailsPanel;
    public GameObject EnglandDetailsPanel;
    public GameObject ChinaDetailsPanel;
    public GameObject JapanDetailsPanel;
    public GameObject KAZAKHSTANDetailsPanel;
    public GameObject PanelClose;

    // Start is called before the first frame update
    void Start()
    {
        IndiaDetailsPanel.SetActive(false);
        EnglandDetailsPanel.SetActive(false);
        ChinaDetailsPanel.SetActive(false);
        JapanDetailsPanel.SetActive(false);
        KAZAKHSTANDetailsPanel.SetActive(false);
    }

    public void OnPanelCloseButton(GameObject Panel)
    {
        Panel.SetActive(false);
    }
}
