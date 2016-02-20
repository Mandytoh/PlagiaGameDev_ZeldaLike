using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public RectTransform healthTextUI;
	public Vector3 modificationPosition;

	void Start(){
		this.updateHealthUI ();
	}

	void Update () {

		modificationPosition = new Vector3 (0, 0, 0);

		if(Input.GetKey(KeyCode.DownArrow)){
			modificationPosition.y --;
		}
		if(Input.GetKey(KeyCode.UpArrow)){
			modificationPosition.y ++;
		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			modificationPosition.x --;
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			modificationPosition.x ++;
		}

		this.modificationPosition.Normalize ();
		this.gameObject.transform.position = new Vector3 (
			this.gameObject.transform.position.x + modificationPosition.x ,
			this.gameObject.transform.position.y + modificationPosition.y,
			this.gameObject.transform.position.z + modificationPosition.z
		);
	}

	public void updateHealthUI(){
		this.healthTextUI.GetComponent<Text> ().text = this.gameObject.GetComponent<Player> ().health.ToString ();
	}

	public void selectWeapon ( int indexWeapon ){
		if (this.gameObject.GetComponent<Player> ().weaponsAvailable [indexWeapon] == null) {
			Debug.Log ("Oh oh, non mais qu'est ce que tu veux ? Cette arme n'existe pas !");
		} else {
			Weapon currentWeapon = this.gameObject.GetComponent<Player> ().weaponsAvailable [indexWeapon];
			this.gameObject.GetComponent<Player> ().currentWeapon = currentWeapon;
			Debug.Log ("J'ai une arme et celle ci est : " + currentWeapon.displayName);
			Debug.Log ("De par son apparence, je pense qu'elle fait " + currentWeapon.nbDamages + " dégats");
		}
	}
}

