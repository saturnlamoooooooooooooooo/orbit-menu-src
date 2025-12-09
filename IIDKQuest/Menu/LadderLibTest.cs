using UnityEngine;
using easyInputs;
using GorillaLocomotion;

namespace IIDKQuest.Mods
{
    public class SpringLadderGun : MonoBehaviour
    {
        private static LineRenderer railsRenderer;  // To draw rails
        private static LineRenderer rungsRenderer;  // To draw rungs

        private const int rungCountMin = 5;
        private const int rungCountMax = 20;
        private const float ladderWidth = 0.3f;   // Distance between rails
        private const float rungThickness = 0.02f;

        public static void Activate()
        {
            Vector3 origin = Player.Instance.rightHandTransform.position;
            Vector3 direction = Player.Instance.rightHandTransform.forward;

            if (Physics.Raycast(origin, direction, out RaycastHit hit))
            {
                Vector3 end = hit.point;
                float distance = Vector3.Distance(origin, end);

                // Number of rungs based on distance
                int rungCount = Mathf.Clamp(Mathf.RoundToInt(distance / 0.3f), rungCountMin, rungCountMax);

                // Create/destroy LineRenderers if needed
                if (railsRenderer == null)
                {
                    GameObject railsObj = new GameObject("LadderRails");
                    railsRenderer = railsObj.AddComponent<LineRenderer>();
                    railsRenderer.positionCount = 4;  // 2 rails, each with 2 points
                    railsRenderer.startWidth = rungThickness;
                    railsRenderer.endWidth = rungThickness;
                    railsRenderer.material = new Material(Shader.Find("Sprites/Default"));
                    railsRenderer.startColor = Color.cyan;
                    railsRenderer.endColor = Color.cyan;
                }

                if (rungsRenderer == null)
                {
                    GameObject rungsObj = new GameObject("LadderRungs");
                    rungsRenderer = rungsObj.AddComponent<LineRenderer>();
                    rungsRenderer.positionCount = rungCount * 2;  // 2 points per rung
                    rungsRenderer.startWidth = rungThickness;
                    rungsRenderer.endWidth = rungThickness;
                    rungsRenderer.material = new Material(Shader.Find("Sprites/Default"));
                    rungsRenderer.startColor = Color.cyan;
                    rungsRenderer.endColor = Color.cyan;
                }

                // Calculate ladder orientation basis
                Vector3 forward = (end - origin).normalized;
                Vector3 up = Vector3.up;

                // Fix up vector if nearly parallel
                if (Vector3.Dot(forward, up) > 0.9f)
                    up = Vector3.right;

                Vector3 right = Vector3.Cross(forward, up).normalized;
                up = Vector3.Cross(right, forward).normalized;

                // Calculate rail positions (rails run from origin to end, offset left and right)
                Vector3 leftRailStart = origin - right * (ladderWidth / 2f);
                Vector3 leftRailEnd = end - right * (ladderWidth / 2f);
                Vector3 rightRailStart = origin + right * (ladderWidth / 2f);
                Vector3 rightRailEnd = end + right * (ladderWidth / 2f);

                // Set rails positions
                railsRenderer.SetPosition(0, leftRailStart);
                railsRenderer.SetPosition(1, leftRailEnd);
                railsRenderer.SetPosition(2, rightRailStart);
                railsRenderer.SetPosition(3, rightRailEnd);

                // Set rungs positions (evenly spaced between rails)
                for (int i = 0; i < rungCount; i++)
                {
                    float t = (float)i / (rungCount - 1);
                    Vector3 rungPosLeft = Vector3.Lerp(leftRailStart, leftRailEnd, t);
                    Vector3 rungPosRight = Vector3.Lerp(rightRailStart, rightRailEnd, t);

                    rungsRenderer.SetPosition(i * 2, rungPosLeft);
                    rungsRenderer.SetPosition(i * 2 + 1, rungPosRight);
                }
            }
            else
            {
                // Destroy visuals if no hit
                if (railsRenderer != null)
                {
                    GameObject.Destroy(railsRenderer.gameObject);
                    railsRenderer = null;
                }
                if (rungsRenderer != null)
                {
                    GameObject.Destroy(rungsRenderer.gameObject);
                    rungsRenderer = null;
                }
            }
        }
    }
}
