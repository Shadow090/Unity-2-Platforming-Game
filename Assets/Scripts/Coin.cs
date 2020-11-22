using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : collectable
{
    // Start is called before the first frame update
    private void Start()
    {
        collectableName = "Coin";
	description = "increase score by 10";

	DontDestroyOnLoad(this.gameObject);
    }

    public override void Use()
    {
      player.GetComponent<playerManager>().ChangeScore(10);
      Destroy(this.gameObject); //Cleans up no longer useful object
    }

}
