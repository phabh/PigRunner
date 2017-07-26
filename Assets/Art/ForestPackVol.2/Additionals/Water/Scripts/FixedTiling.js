#pragma strict
//THIS SCRIPT IS USED TO KEEP THE TILLING OF WATER PLANES EQUAL RELATIVE TO SCALE
var tileScale : float = 0.1f;

//Run script in editer
//@script ExecuteInEditMode()

function Start () {
	//INSTANCED TILING
	//Instance material tiling separately | Best if your scene contains multiple water planes of different scales | Increases draw calls per water plane
	GetComponent.<Renderer>().material.mainTextureScale = new Vector2(transform.localScale.x * tileScale, transform.localScale.y * tileScale);
	
	//SHARED TILING
	//Share tiling among the same material | Best if your scene contains a single water plane, or multiple water planes of the same scale
	//GetComponent.<Renderer>().sharedMaterial.mainTextureScale = new Vector2(transform.localScale.x * tileScale, transform.localScale.y * tileScale);
}