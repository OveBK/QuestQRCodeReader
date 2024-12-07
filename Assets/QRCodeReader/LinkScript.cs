using Anaglyph.DisplayCapture.Barcodes;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class LinkScript : MonoBehaviour
{
    [SerializeField] private TMP_Text linkText;

    [SerializeField] private GameObject OpenQRCode;

    public bool activeLink = false;

    public GameObject CameraRig;

    public void ShowWindow(string text, Vector3 pos)
    {
        if (!activeLink)
        {
            activeLink = true;
            OpenQRCode.SetActive(true);
            linkText.text = text;
            OpenQRCode.transform.position = pos;
            OpenQRCode.transform.rotation = CameraRig.transform.rotation;
        }
    }

    public void HideWindow()
    {
        OpenQRCode.SetActive(false);
        activeLink = false;        
    }

    public void OpenBrowser() 
    {
        Application.OpenURL(linkText.text);
        Application.Quit();
        HideWindow();
    }

    public void CancelLink()
    {
        HideWindow();
    }
}
