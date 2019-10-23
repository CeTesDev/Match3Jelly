using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class HUDFPS : MonoBehaviour 
{


	public Text text;
	/* Public Variables */
	public float frequency = 0.3f;

	/* **********************************************************************
	 * PROPERTIES
	 * *********************************************************************/
	public int FramesPerSec { get; protected set; }

	/* **********************************************************************
	 * EVENT HANDLERS
	 * *********************************************************************/
	/*
	* EVENT: Start
	*/
	private void Start() {
//		this.transform.paren÷t
		DontDestroyOnLoad(this.transform.parent.gameObject);
		StartCoroutine(FPS());
	}

	/*
	 * EVENT: FPS
	 */
	private IEnumerator FPS() {
		for(;;){
			// Capture frame-per-second
			int lastFrameCount = Time.frameCount;
			float lastTime = Time.realtimeSinceStartup;
			yield return new WaitForSeconds(frequency);	
			float timeSpan = Time.realtimeSinceStartup - lastTime;
			int frameCount = Time.frameCount - lastFrameCount;

			// Display it
			FramesPerSec = Mathf.RoundToInt(frameCount / timeSpan);
			text.text = FramesPerSec + " fps";
			text.color = FramesPerSec < 10 ? Color.red : (FramesPerSec <20 ? Color.yellow : Color.green);
		}
	}
}