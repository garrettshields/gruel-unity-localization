using System;
using UnityEngine;

namespace Gruel.Localization {
	[Serializable]
	public class KeyReplacementPair {
		
#region Properties
		public string TargetKey => _targetKey;
		public string ReplacementKey => _replacementKey;
#endregion Properties

#region Fields
		[SerializeField] private string _targetKey;
		[SerializeField] private string _replacementKey;
#endregion Fields

	}
}