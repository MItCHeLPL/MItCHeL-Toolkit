using UnityEngine;

public class FakeChild : MonoBehaviour
{
    [SerializeField] private Transform fakeParent;

    [SerializeField] private Vector3 positionOffset;
    [SerializeField] private Vector3 rotationOffset;

    private Vector3 startPosOffset;
    private Quaternion startRotOffset;


    private void Start()
    {
        if (fakeParent != null)
        {
            SetFakeParent(fakeParent);
        }
    }

    private void Update()
    {
        if (fakeParent != null)
        {
            var targetPos = fakeParent.position - startPosOffset + positionOffset;
            var targetRot = fakeParent.localRotation * startRotOffset * Quaternion.Euler(rotationOffset);

            transform.position = RotatePointAroundPivot(targetPos, fakeParent.position, targetRot);
            transform.localRotation = targetRot;
        }
    }


    public void SetFakeParent(Transform parent)
    {
        startPosOffset = parent.position - transform.position;

        startRotOffset = Quaternion.Inverse(parent.localRotation * transform.localRotation);

        this.fakeParent = parent;
    }

    private Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Quaternion rotation)
    {
        Vector3 dir = point - pivot;

        dir = rotation * dir;

        point = dir + pivot;

        return point;
    }
}
