using UnityEngine;
using System.Collections;

public class World : MonoBehaviour {

	public Player player;

	void Start(){
		//Le perso est dans la cave d'un chateau
		//Il avance
		//Et trouve une épée, la ramasse et la met à l'emplacement 0 de son inventaire
		this.player.GetComponent<PlayerController> ().selectWeapon (0);
		//Ah mince, je recontre un ennemi et il fonce sur moi
		//Il me donne un coup
		this.player.GetComponent<Player> ().takeDamage (1);
		//Je dois lui péter la gueule
		this.player.GetComponent<Player> ().hitWithCurrentWeapon ();

		//De nombreuses années après, dans une foret
		// Il avance
		//Et trouve une mega épée qui fait proc une musique et une anim chelou
		this.player.GetComponent<PlayerController> ().selectWeapon (1);
		//Ah mince, je recontre un ennemi et il fonce sur moi
		//Il me donne un coup
		this.player.GetComponent<Player> ().takeDamage (3);
		//Je dois lui péter la gueule
		this.player.GetComponent<Player> ().hitWithCurrentWeapon ();
	}
}
