using System.Linq;
using UnityEngine;
using UnityEngine.Internal;

public class ExtendedPhysics : Physics
{
    //Raycast

    public static RaycastHit[] OrderedRaycastAll(Vector3 origin, Vector3 direction, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
        float magnitude = direction.magnitude;
        if (magnitude > float.Epsilon)
        {
            Vector3 direction2 = direction / magnitude;
            return RaycastAll(ray: new Ray(origin, direction2), maxDistance: maxDistance, layerMask: layerMask, queryTriggerInteraction: queryTriggerInteraction).OrderBy(x => x.distance).ToArray();
        }

        return new RaycastHit[0];
    }

    public static RaycastHit[] OrderedRaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask)
    {
        return OrderedRaycastAll(origin, direction, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
    }

    public static RaycastHit[] OrderedRaycastAll(Vector3 origin, Vector3 direction, float maxDistance)
    {
        return OrderedRaycastAll(origin, direction, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
    }

    public static RaycastHit[] OrderedRaycastAll(Vector3 origin, Vector3 direction)
    {
        return OrderedRaycastAll(origin, direction, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
    }

    public static RaycastHit[] OrderedRaycastAll(Ray ray, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
        return OrderedRaycastAll(ray.origin, ray.direction, maxDistance, layerMask, queryTriggerInteraction);
    }

    public static RaycastHit[] OrderedRaycastAll(Ray ray, float maxDistance, int layerMask)
    {
        return OrderedRaycastAll(ray.origin, ray.direction, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
    }

    public static RaycastHit[] OrderedRaycastAll(Ray ray, float maxDistance)
    {
        return OrderedRaycastAll(ray.origin, ray.direction, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
    }

    public static RaycastHit[] OrderedRaycastAll(Ray ray)
    {
        return OrderedRaycastAll(ray.origin, ray.direction, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
    }



    //CapsuleCast

    public static RaycastHit[] OrderedCapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
        float magnitude = direction.magnitude;
        if (magnitude > float.Epsilon)
        {
            Vector3 direction2 = direction / magnitude;
            return CapsuleCastAll(point1, point2, radius, direction2, maxDistance, layerMask, queryTriggerInteraction).OrderBy(x => x.distance).ToArray();
        }

        return new RaycastHit[0];
    }

    public static RaycastHit[] OrderedCapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask)
    {
        return OrderedCapsuleCastAll(point1, point2, radius, direction, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
    }

    public static RaycastHit[] OrderedCapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance)
    {
        return OrderedCapsuleCastAll(point1, point2, radius, direction, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
    }

    public static RaycastHit[] OrderedCapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction)
    {
        return OrderedCapsuleCastAll(point1, point2, radius, direction, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
    }



    //SphereCast

    public static RaycastHit[] OrderedSphereCastAll(Vector3 origin, float radius, Vector3 direction, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
        float magnitude = direction.magnitude;
        if (magnitude > float.Epsilon)
        {
            Vector3 direction2 = direction / magnitude;
            return SphereCastAll(origin, radius, direction2, maxDistance, layerMask, queryTriggerInteraction).OrderBy(x => x.distance).ToArray();
        }

        return new RaycastHit[0];
    }

    public static RaycastHit[] OrderedSphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance, int layerMask)
    {
        return OrderedSphereCastAll(origin, radius, direction, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
    }

    public static RaycastHit[] OrderedSphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance)
    {
        return OrderedSphereCastAll(origin, radius, direction, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
    }

    public static RaycastHit[] OrderedSphereCastAll(Vector3 origin, float radius, Vector3 direction)
    {
        return OrderedSphereCastAll(origin, radius, direction, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
    }

    public static RaycastHit[] OrderedSphereCastAll(Ray ray, float radius, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
        return OrderedSphereCastAll(ray.origin, radius, ray.direction, maxDistance, layerMask, queryTriggerInteraction);
    }

    public static RaycastHit[] OrderedSphereCastAll(Ray ray, float radius, float maxDistance, int layerMask)
    {
        return OrderedSphereCastAll(ray, radius, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
    }

    public static RaycastHit[] OrderedSphereCastAll(Ray ray, float radius, float maxDistance)
    {
        return OrderedSphereCastAll(ray, radius, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
    }

    public static RaycastHit[] OrderedSphereCastAll(Ray ray, float radius)
    {
        return OrderedSphereCastAll(ray, radius, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
    }



    //BoxCast

    public static RaycastHit[] OrderedBoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, [DefaultValue("Quaternion.identity")] Quaternion orientation, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
    {
        float magnitude = direction.magnitude;
        if (magnitude > float.Epsilon)
        {
            Vector3 direction2 = direction / magnitude;
            return BoxCastAll(center, halfExtents, direction2, orientation, maxDistance, layerMask, queryTriggerInteraction).OrderBy(x => x.distance).ToArray();
        }

        return new RaycastHit[0];
    }

    public static RaycastHit[] OrderedBoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask)
    {
        return OrderedBoxCastAll(center, halfExtents, direction, orientation, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
    }

    public static RaycastHit[] OrderedBoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance)
    {
        return OrderedBoxCastAll(center, halfExtents, direction, orientation, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
    }

    public static RaycastHit[] OrderedBoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation)
    {
        return OrderedBoxCastAll(center, halfExtents, direction, orientation, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
    }

    public static RaycastHit[] OrderedBoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction)
    {
        return OrderedBoxCastAll(center, halfExtents, direction, Quaternion.identity, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
    }
}
