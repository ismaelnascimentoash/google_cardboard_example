using UnityEngine;
using UnityEngine.XR;

namespace IsmaelNascimentoAssets
{
	public class RuntimeCardboardLoader : MonoBehaviour
	{
		#region VARIABLES

		private static RuntimeCardboardLoader instance;
		public static RuntimeCardboardLoader Instance
		{
			get { return instance = instance ?? new GameObject("RuntimeCardboardLoader").AddComponent<RuntimeCardboardLoader>(); }
		}

		public bool EnableVRMode
		{
			set { XRSettings.enabled = value; }
		}

		#endregion

		#region MONOBEHAVIOUR_METHODS

		private void OnEnable()
		{
			instance = this;
		}

		#endregion
	}
}