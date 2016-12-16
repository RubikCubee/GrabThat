using UnityEngine;
using System.Collections;

public class RewardBehavior : MonoBehaviour {

	private Shader shader;
	private string name; 
	private int weight;
	//private Color color; 
	// Use this for initialization
	void Start () {
		// color = gameObject.GetComponent<Renderer>().material.color;
		name = this.gameObject.name;
		Debug.Log (name);

		if(name.Contains("1"))
		{
			weight = 1;
		}
		else if(name.Contains("3"))
		{
			weight = 3;
		}
		else if(name.Contains("5"))
		{
			weight = 5;
		}		
		else if(name.Contains("7"))
		{
			weight = 7;
		}
					
		string shaderToFind = "Value" + weight;
		///Debug.Log (weight);
		shader = this.GetComponent<Renderer>().materials.
		//i//f(shader!= null)
	}

	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag.Equals("Joueur"))
		{
			var player = col.gameObject;
			var bodyPlayer = player.transform.FindChild("Body");
			Renderer rendPlayer = bodyPlayer.GetComponent<Renderer>();
			rendPlayer.material.shader = shader;

			// Détruire la boite attrapé 
			Destroy(this.gameObject);
		}		
	}
}
