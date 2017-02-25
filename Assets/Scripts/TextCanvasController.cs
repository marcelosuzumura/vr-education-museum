using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextCanvasController : MonoBehaviour {

	public Button backButton;
	public Button advanceButton;
	public Text text;
	public Text progressText;
	public string[] texts;

	private int currentTextIndex;

	void Start () {
		this.currentTextIndex = 0;

		this.UpdateProgressText ();
	}

	void Update () {
		this.text.text = this.texts [this.currentTextIndex].Replace("\\n","\n");
	}

	void UpdateProgressText() {
		this.progressText.text = (this.currentTextIndex + 1) + "/" + (this.texts.Length);
	}

	public void TextBack() {
		int newTextIndex = this.currentTextIndex;
		newTextIndex -= 1;

		if (newTextIndex >= 0) {
			this.currentTextIndex = newTextIndex;
			this.UpdateProgressText ();
		}

		Debug.Log (this.currentTextIndex);
	}

	public void TextAdvance() {
		int newTextIndex = this.currentTextIndex;
		newTextIndex += 1;

		if (newTextIndex <= this.texts.Length - 1) {
			this.currentTextIndex = newTextIndex;
			this.UpdateProgressText ();
		}

		Debug.Log (this.currentTextIndex);
	}

	public void Dismiss() {
		Destroy (this.gameObject);
	}

}
