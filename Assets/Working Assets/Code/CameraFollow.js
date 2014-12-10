#pragma strict


var target : GameObject;
var zposition : float;


function Start () {

}
function Update()
{
	transform.position.y = target.transform.position.y;
	transform.position.x = target.transform.position.x;
	transform.position.z = zposition;
	
} 