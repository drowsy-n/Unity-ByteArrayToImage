using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ByteArrayToImage : MonoBehaviour {

	public GameObject canvasImage;

	void Start () {
		
	}
	
	private void Set_Image(byte[] recevByteArr)
	{
		try
		{
			Texture2D bmp;
			bmp = new Texture2D(8, 8);
			bmp.LoadImage(recevByteArr, false);

			Vector2 pivot = new Vector2(0.5f, 0.5f);
			Rect tRect = new Rect(0, 0, bmp.width, bmp.height);
			Sprite newSprite = Sprite.Create(bmp, tRect, pivot);

			GameObject webcam = GameObject.Find("Webcam");
			canvasImage.GetComponent<Image>().overrideSprite = newSprite;

		}
		catch
		{
		}
	}
}
