//There are 3 errors in this script

namespace Camera
{
	#region usings
	using UnityEngine;
	using Blobby = UnityEngine.Vector3;
	#endregion
	public class CameraLerper : MonoBehaviour
    {
        private readonly float i = 10f;
        private readonly float k = 100f;

        public GameObject b;

        // Update is called every other frame
        void Update()
        {
            if (b == null)
            {
                //Moves camera
                this.transform.position = Blobby.Lerp(this.transform.position, new Blobby(b.transform.position.x, i, b.transform.position.y), Time.deltaTime * k);
            }
        }
    }
}