using System;
using UnityEngine;
using easyInputs;

public class RobuxCoilSpringGun : MonoBehaviour
{
    public Transform spawnPoint;          // Where to spawn the Robux object
    public float shootForce = 20f;        // Initial impulse force
    public float springStrength = 80f;    // Spring joint spring strength
    public float springDamping = 6f;      // Spring joint damping
    public float springMaxDistance = 3f;  // Max stretch distance of the spring

    public int springSegments = 30;       // Number of segments in the coil spring visual
    public float coilAmplitude = 0.1f;    // Coil spring radius/amplitude
    public float coilFrequency = 6f;      // Coil wave frequency
    public float coilSpinSpeed = 8f;      // Spin speed of the coil animation

    private GameObject robuxObj;
    private Rigidbody robuxRb;
    private SpringJoint springJoint;
    private LineRenderer coilRenderer;
    private float coilTime;

    private Texture2D[] robuxTextures;

    public static void ActivateRobuxSpringGun()
    {
        GameObject obj = new GameObject("RobuxCoilSpringGun");
        obj.AddComponent<RobuxCoilSpringGun>();
    }   

    void Update()
    {
        if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
        {
            ShootRobuxSpring();
        }


        AnimateCoil();
    }

    void ShootRobuxSpring()
    {
        if (robuxTextures.Length == 0 || spawnPoint == null)
            return;

        // Clean up old objects if still present
        if (robuxObj != null) Destroy(robuxObj);
        if (coilRenderer != null) Destroy(coilRenderer.gameObject);

        // Create Robux cube
        robuxObj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        robuxObj.transform.position = spawnPoint.position;
        robuxObj.transform.rotation = spawnPoint.rotation;
        robuxObj.transform.localScale = Vector3.one * 0.2f;

        // Assign random Robux texture material
        // Assign green Robux-style material
        Renderer rend = robuxObj.GetComponent<Renderer>();
        Material mat = new Material(Shader.Find("Standard"));
        mat.color = new Color(0.3f, 1f, 0.3f); // bright green
        rend.material = mat;


        // Rigidbody for physics
        robuxRb = robuxObj.GetComponent<Rigidbody>();
        if (robuxRb == null) robuxRb = robuxObj.AddComponent<Rigidbody>();
        robuxRb.mass = 1f;

        // Add SpringJoint connecting back to the spawnPoint's Rigidbody or world anchor
      
        springJoint.spring = springStrength;
        springJoint.damper = springDamping;
        springJoint.maxDistance = springMaxDistance;

        // Apply impulse forward
        robuxRb.AddForce(spawnPoint.forward * shootForce, ForceMode.Impulse);

        // Setup LineRenderer for coil visual between spawnPoint and robuxObj
        GameObject coilObj = new GameObject("CoilSpring");
        coilRenderer = coilObj.AddComponent<LineRenderer>();
        coilRenderer.positionCount = springSegments + 1;
        coilRenderer.startWidth = 0.02f;
        coilRenderer.endWidth = 0.02f;
        coilRenderer.material = new Material(Shader.Find("Sprites/Default"));
        coilRenderer.startColor = Color.cyan;
        coilRenderer.endColor = new Color(0.5f, 0f, 1f); // purple

        coilTime = 0f;

        // Destroy after 10 seconds
        Destroy(robuxObj, 10f);
        Destroy(coilObj, 10f);
    }

    void AnimateCoil()
    {
        if (coilRenderer == null || robuxObj == null) return;

        coilTime += Time.deltaTime * coilSpinSpeed;

        Vector3 startPos = spawnPoint.position;
        Vector3 endPos = robuxObj.transform.position;
        Vector3 dir = endPos - startPos;
        float length = dir.magnitude;
        dir.Normalize();

        // Find two perpendicular vectors to dir to form the coil circle basis
        Vector3 axis1 = Vector3.Cross(dir, Vector3.up);
        if (axis1 == Vector3.zero) axis1 = Vector3.Cross(dir, Vector3.right);
        axis1.Normalize();

        Vector3 axis2 = Vector3.Cross(dir, axis1);
        axis2.Normalize();

        for (int i = 0; i <= springSegments; i++)
        {
            float t = (float)i / springSegments;
            float angle = t * 3.1415927f * 2f * coilFrequency + coilTime;


            float radius = coilAmplitude * (length / springMaxDistance); // scale radius with distance

            Vector3 basePos = Vector3.Lerp(startPos, endPos, t);
            Vector3 offset = axis1 * Mathf.Cos(angle) * radius + axis2 * Mathf.Sin(angle) * radius;

            coilRenderer.SetPosition(i, basePos + offset);
        }
    }
}
