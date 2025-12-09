using UnityEngine;
using System;
using easyInputs;   

public class SpringBananaGun : MonoBehaviour
{
    public Transform hand;               // Assign your right hand transform in inspector
    public float shootForce = 10f;       // Throw speed
    public float springStrength = 80f;   // SpringJoint strength
    public float springDamping = 6f;     // SpringJoint damping
    public float springMaxDistance = 3f; // Max spring stretch

    public int coilSegments = 30;        // LineRenderer coil resolution
    public float coilRadius = 0.05f;     // Coil thickness
    public float coilFrequency = 6f;     // Coil turns frequency
    public float coilSpinSpeed = 8f;     // Coil animation speed

    private GameObject bananaObj;
    private Rigidbody bananaRb;
    private SpringJoint springJoint;
    private LineRenderer coilRenderer;
    private float coilTime;

    public static void BannanaGunActivate()
    {
        GameObject obj = new GameObject("SpringBananaGun");
        obj.AddComponent<SpringBananaGun>();
    }
    void Update()
    {
        if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
        {
            SpawnBananaWithSpring();
        }

        AnimateCoil();
    }

    void SpawnBananaWithSpring()
    {
        if (bananaObj != null) Destroy(bananaObj);
        if (coilRenderer != null) Destroy(coilRenderer.gameObject);

        // Create banana as a curved cylinder
        bananaObj = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        bananaObj.transform.position = hand.position + hand.forward * 0.3f;
        bananaObj.transform.rotation = Quaternion.LookRotation(hand.forward);
        bananaObj.transform.localScale = new Vector3(0.05f, 0.2f, 0.05f);
        bananaObj.transform.Rotate(0f, 0f, 30f); // curve the banana

        // Color banana yellow
        var rend = bananaObj.GetComponent<Renderer>();
        rend.material = new Material(Shader.Find("Standard"));
        rend.material.color = Color.yellow;

        // Rigidbody for physics
        bananaRb = bananaObj.AddComponent<Rigidbody>();
        bananaRb.mass = 1f;

        // Add spring joint connected to hand rigidbody or world anchor
        Rigidbody connectedBody = hand.GetComponentInParent<Rigidbody>();
        if (connectedBody == null)
        {
            connectedBody = hand.gameObject.AddComponent<Rigidbody>();
            connectedBody.isKinematic = true;
        }

        
        springJoint.spring = springStrength;
        springJoint.damper = springDamping;
        springJoint.maxDistance = springMaxDistance;

        // Throw banana forward
        bananaRb.AddForce(hand.forward * shootForce, ForceMode.Impulse);

        // Setup coil line renderer
        GameObject coilObj = new GameObject("BananaCoil");
        coilRenderer = coilObj.AddComponent<LineRenderer>();
        coilRenderer.positionCount = coilSegments + 1;
        coilRenderer.startWidth = 0.02f;
        coilRenderer.endWidth = 0.02f;
        coilRenderer.material = new Material(Shader.Find("Sprites/Default"));
        coilRenderer.startColor = Color.yellow;
        coilRenderer.endColor = new Color(1f, 0.9f, 0f); // yellow gradient

        coilTime = 0f;

        // Destroy banana and coil after 10 seconds
        Destroy(bananaObj, 10f);
        Destroy(coilObj, 10f);
    }

    void AnimateCoil()
    {
        if (coilRenderer == null || bananaObj == null) return;

        coilTime += Time.deltaTime * coilSpinSpeed;

        Vector3 startPos = hand.position;
        Vector3 endPos = bananaObj.transform.position;
        Vector3 dir = endPos - startPos;
        float length = dir.magnitude;
        dir.Normalize();

        Vector3 axis1 = Vector3.Cross(dir, Vector3.up);
        if (axis1 == Vector3.zero) axis1 = Vector3.Cross(dir, Vector3.right);
        axis1.Normalize();

        Vector3 axis2 = Vector3.Cross(dir, axis1);
        axis2.Normalize();

        for (int i = 0; i <= coilSegments; i++)
        {
            float t = (float)i / coilSegments;
            double angle = t * Math.PI * 2.0 * coilFrequency + coilTime;


            float radius = coilRadius * (length / springMaxDistance);

            Vector3 basePos = Vector3.Lerp(startPos, endPos, t);
            Vector3 offset = axis1 * Mathf.Cos((float)angle) * radius + axis2 * Mathf.Sin((float)angle) * radius;

            coilRenderer.SetPosition(i, basePos + offset);
        }
    }
}
