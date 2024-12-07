using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Anaglyph.DisplayCapture.Barcodes
{
	public class Indicator : MonoBehaviour
	{
		public bool activeLink = false;

		public GameObject QRCodeManager;

		[SerializeField] private TMP_Text textMesh;
		public TMP_Text TextMesh => textMesh;

		private Vector3[] offsetPositions = new Vector3[4];

		void Awake ()
		{
			QRCodeManager = GameObject.Find("QRWindowManager");
		}

		public void Set(BarcodeTracker.Result result) => Set(result.text, result.corners);

		public void Set(string text, Vector3[] corners)
		{
			Vector3 topCenter = (corners[2] + corners[3]) / 2f;
			textMesh.text = "";
			
			
			if (!QRCodeManager.GetComponent<LinkScript>().activeLink)
			{
				QRCodeManager.GetComponent<LinkScript>().ShowWindow(text, topCenter);
			}
		}
	}

	
}