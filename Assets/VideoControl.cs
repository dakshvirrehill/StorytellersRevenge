using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RenderHeads.Media.AVProVideo;
public class VideoControl : MonoBehaviour {
	public GameObject MenuGaze;
	public GameObject Menu;
	public MediaPlayer mp;
	public ParticleSystem ps;
	//public GameObject player;
	bool enabled=false;
	void Update () {
		//DoCheck (mp,Menu,enabled);
		int times = (int)(mp.Control.GetCurrentTimeMs ()/1000);
		//Debug.Log (times);
		if (mp.Control.IsPlaying() && (times == 51||times == 90||times==155||times==210))
		{
			pausenMenu (mp, Menu, enabled);
		}
		if (mp.Control.IsPlaying () && times > 210 && !ps.isPlaying) {
			//Debug.Log ("in this function");
			ps.Play ();
		}
		if (mp.Control.IsPlaying () && times >= 230) {
			ps.Pause ();
			ps.Clear ();
		}
		/*if (mp.Control.IsFinished ()) {
			ps.Pause ();
			mp.Control.Rewind ();
	}*/
	//private static void DoCheck(MediaPlayer mp, GameObject Menu, bool enabled) {
		
		}
	//}
	private static void pausenMenu(MediaPlayer mp, GameObject Menu, bool enabled) {
		mp.Control.Pause ();
		Menu.SetActive (true);
		enabled = true;
	} 
	public void Continue() {
		enabled = false;
		Menu.SetActive (false);
		mp.Control.Play ();
		mp.Control.SeekFast (mp.Control.GetCurrentTimeMs () + 1000);
	}
	public void EnableDisableMenu() {
		if (!enabled) {
			enabled = true;
			Menu.SetActive (true);
			mp.Control.Pause ();
		} else {
			Menu.SetActive (false);
			enabled = false;
			mp.Control.Play ();
		}
	}
	public void rewind() {
		mp.Control.Rewind ();
		Menu.SetActive (false);
		enabled = false;
		if(mp.Control.IsPaused()) {
			mp.Control.Play ();
		}
	}
	public void indianTemple() {
		mp.Control.SeekFast (52000);
		Menu.SetActive (false);
		enabled = false;
		if(mp.Control.IsPaused()) {
			mp.Control.Play ();
		}
	}
	public void tajMahal() {
		mp.Control.SeekFast (91000);
		Menu.SetActive (false);
		enabled = false;
		if(mp.Control.IsPaused()) {
			mp.Control.Play ();
		}
	}
	public void mcLeodGanj() {
		mp.Control.SeekFast (156000);
		Menu.SetActive (false);
		enabled = false;
		if(mp.Control.IsPaused()) {
			mp.Control.Play ();
		}
	}
	public void credits() {
		mp.Control.SeekFast (211000);
		Menu.SetActive (false);
		enabled = false;
		if(mp.Control.IsPaused()) {
			mp.Control.Play ();
		}
	}
}