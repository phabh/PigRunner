#pragma strict
//This script is used to animate a texture atlas | This script is used on the Waves prefab, used in the waterfall
var uvAnimationTileX = 4;
var uvAnimationTileY = 4;
var framesPerSecond = 10.0;

function Update () {
	var index : int = Time.time * framesPerSecond;
	index = index % (uvAnimationTileX * uvAnimationTileY);
	var size = Vector2 (1.0 / uvAnimationTileX, 1.0 / uvAnimationTileY);
	
	var uIndex = index % uvAnimationTileX;
	var vIndex = index / uvAnimationTileX;
	
	var offset = Vector2 (uIndex * size.x, 1.0 - size.y - vIndex * size.y);
 
	GetComponent.<Renderer>().material.SetTextureOffset ("_MainTex", offset);
	GetComponent.<Renderer>().material.SetTextureScale ("_MainTex", size);
}