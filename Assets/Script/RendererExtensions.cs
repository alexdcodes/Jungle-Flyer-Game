/*/*
Alex Diker

*/
using UnityEngine;

public static class RendererExtensions
{
    
// SOURCE:
// http://wiki.unity3d.com/index.php?title=IsVisibleFrom

    public static bool IsVisibleFrom(this Renderer renderer, Camera camera)
	{
		Plane[] planes = GeometryUtility.CalculateFrustumPlanes(camera);
		return GeometryUtility.TestPlanesAABB(planes, renderer.bounds);
	}
}