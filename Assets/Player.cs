using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public int health = 10;
	public bool isDead = false;

	public Weapon[] weaponsAvailable;
	public Weapon currentWeapon;

	public void takeDamage( int nbDamage ){
		this.health -= nbDamage;
		Debug.Log ("Aie ! Je me suis pris " + nbDamage + " dans la gueule !");
		this.gameObject.GetComponent<PlayerController> ().updateHealthUI ();
	}
	public void hitWithCurrentWeapon(){
		Debug.Log ("Je frappe avec mon arme actuelle \"" + this.currentWeapon.displayName + "\" et j'inflige " + this.currentWeapon.nbDamages + " dégats");
	}
}
