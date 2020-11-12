using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagPickup : MonoBehaviour
{
    public UIManager uIManager;
    public DateTime dateTime;

    private void Start()
    {
        uIManager = FindObjectOfType<Canvas>().GetComponent<UIManager>();
        dateTime = GameObject.FindGameObjectWithTag("Datetime").GetComponent<DateTime>();
    }

    private void OnMouseDown()
    {
        if (gameObject.CompareTag("England"))
        {
            dateTime.Datetime = System.DateTime.Now.AddHours(-4).AddMinutes(-30).ToString("dd:MM:yyyy HH:mm:ss");
            dateTime.DateTimeText.text = dateTime.Datetime;
            uIManager.EnglandDetailsPanel.SetActive(true);         
        }
        else if (gameObject.CompareTag("India"))
        {
            dateTime.Datetime = System.DateTime.Now.ToString("dd:MM:yyyy HH:mm:ss");
            dateTime.DateTimeText.text = dateTime.Datetime;
            uIManager.IndiaDetailsPanel.SetActive(true);
        }
        else if (gameObject.CompareTag("China"))
        {
            dateTime.Datetime = System.DateTime.Now.AddHours(2).AddMinutes(30).ToString("dd:MM:yyyy HH:mm:ss");
            dateTime.DateTimeText.text = dateTime.Datetime;
            uIManager.ChinaDetailsPanel.SetActive(true);
        }
        else if (gameObject.CompareTag("Japan"))
        {
            dateTime.Datetime = System.DateTime.Now.AddHours(3).AddMinutes(30).ToString("dd:MM:yyyy HH:mm:ss");
            dateTime.DateTimeText.text = dateTime.Datetime;
            uIManager.JapanDetailsPanel.SetActive(true);
        }
        else if (gameObject.CompareTag("KAZAKHSTAN"))
        {
            dateTime.Datetime = System.DateTime.Now.AddMinutes(30).ToString("dd:MM:yyyy HH:mm:ss");
            dateTime.DateTimeText.text = dateTime.Datetime;
            uIManager.KAZAKHSTANDetailsPanel.SetActive(true);
        }
    }
}
