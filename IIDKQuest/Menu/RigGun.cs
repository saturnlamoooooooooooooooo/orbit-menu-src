using System;
using easyInputs;
using UnityEngine;

namespace IIDKQuest.Mods
{

	internal class RigGun
	{

        public static void RigTp()
        {
            while (true)
            {
                if (GorillaTagger.Instance != null && GorillaTagger.Instance.myVRRig != null)
                {
                    GorillaTagger.Instance.myVRRig.enabled = true;

                    if (EasyInputs.GetGripButtonDown(EasyHand.RightHand))
                    {
                        RaycastHit hit;
                        if (Physics.Raycast(GorillaTagger.Instance.rightHandTransform.position, GorillaTagger.Instance.rightHandTransform.forward, out hit))
                        {
                            if (pointer == null)
                            {
                                pointer = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                                UnityEngine.Object.Destroy(pointer.GetComponent<Rigidbody>());
                                UnityEngine.Object.Destroy(pointer.GetComponent<SphereCollider>());
                                pointer.transform.localScale = new Vector3(0.067f, 0.067f, 0.067f);
                            }

                            pointer.transform.position = hit.point + hit.normal * 0.3f;
                            pointer.GetComponent<Renderer>().material.color = Color.magenta;

                            if (line == null)
                            {
                                line = new GameObject("line");
                                var lineRenderer = line.AddComponent<LineRenderer>();
                                lineRenderer.startWidth = 0.01f;
                                lineRenderer.endWidth = 0.01f;
                                lineRenderer.material = new Material(Shader.Find("Sprites/Default"));
                                lineRenderer.startColor = Color.magenta;
                                lineRenderer.endColor = Color.magenta;
                            }

                            var lr = line.GetComponent<LineRenderer>();
                            lr.SetPosition(0, GorillaTagger.Instance.rightHandTransform.position);
                            lr.SetPosition(1, pointer.transform.position);

                            GorillaTagger.Instance.myVRRig.enabled = false;
                            GorillaTagger.Instance.myVRRig.transform.position = hit.point + hit.normal * 0.3f;
                            GorillaTagger.Instance.myVRRig.enabled = true;
                        }
                    }
                }
                // The loop goes on forever — might want to add a small yield/wait here to avoid locking CPU.
            }
        }



        public RigGun()
		{
			for (;;)
			{
				IL_06:
				uint num = 1758301855U;
				for (;;)
				{
					uint num2;
					switch ((num2 = (((num << 0) - (0U - 0U) - 0U - 0U ^ 0U) - (0U ^ 0U) << 0 ^ 0U)) % 3U)
					{
					case 0U:
						goto IL_06;
					case 1U:
						num = ((num2 + 2609111716U ^ 831946417U ^ 0U) << 0 ^ 0U) - 0U;
						continue;
					}
					return;
				}
			}
		}

		public static GameObject pointer;

	
		public static GameObject line;
	}
}
