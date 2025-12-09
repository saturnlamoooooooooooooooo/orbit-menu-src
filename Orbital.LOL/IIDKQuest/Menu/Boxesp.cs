using System;
using UnityEngine;

namespace TemplateMenuByZinx.Menu.mods
{
    internal class Box_Esp
    {
        public static void boxesp()
        {
            bool flashRed = Mathf.FloorToInt(Time.time * 2f) % 2 == 0;
            Color flashColor = flashRed ? Color.red : Color.black;

            foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
            {
                if (vrrig != null && !vrrig.isOfflineVRRig && !vrrig.isMyPlayer)
                {
                    GameObject gameObject = new GameObject("boxESP");
                    gameObject.transform.position = vrrig.headMesh.transform.position - new Vector3(0f, 0.05f, 0f);

                    GameObject top = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    GameObject bottom = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    GameObject left = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    GameObject right = GameObject.CreatePrimitive(PrimitiveType.Cube);

                    UnityEngine.Object.Destroy(top.GetComponent<BoxCollider>());
                    UnityEngine.Object.Destroy(bottom.GetComponent<BoxCollider>());
                    UnityEngine.Object.Destroy(left.GetComponent<BoxCollider>());
                    UnityEngine.Object.Destroy(right.GetComponent<BoxCollider>());

                    top.transform.SetParent(gameObject.transform);
                    top.transform.localPosition = new Vector3(0f, 0.49f, 0f);
                    top.transform.localScale = new Vector3(1f, 0.02f, 0.02f);

                    bottom.transform.SetParent(gameObject.transform);
                    bottom.transform.localPosition = new Vector3(0f, -0.49f, 0f);
                    bottom.transform.localScale = new Vector3(1f, 0.02f, 0.02f);

                    left.transform.SetParent(gameObject.transform);
                    left.transform.localPosition = new Vector3(-0.49f, 0f, 0f);
                    left.transform.localScale = new Vector3(0.02f, 1f, 0.02f);

                    right.transform.SetParent(gameObject.transform);
                    right.transform.localPosition = new Vector3(0.49f, 0f, 0f);
                    right.transform.localScale = new Vector3(0.02f, 1f, 0.02f);

                    Shader shader = Shader.Find("GUI/Text Shader");
                    top.GetComponent<Renderer>().material.shader = shader;
                    bottom.GetComponent<Renderer>().material.shader = shader;
                    left.GetComponent<Renderer>().material.shader = shader;
                    right.GetComponent<Renderer>().material.shader = shader;

                    top.GetComponent<Renderer>().material.color = flashColor;
                    bottom.GetComponent<Renderer>().material.color = flashColor;
                    left.GetComponent<Renderer>().material.color = flashColor;
                    right.GetComponent<Renderer>().material.color = flashColor;

                    gameObject.transform.LookAt(gameObject.transform.position + Camera.main.transform.rotation * Vector3.forward,
                                                Camera.main.transform.rotation * Vector3.up);

                    UnityEngine.Object.Destroy(gameObject, Time.deltaTime);
                }
            }
        }
    }
}
