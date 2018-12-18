using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CA2 {
	public class MasterDataSettings{

		static MasterDataSettings instance = null;

		public static MasterDataSettings Instance {
			get {
				if (instance == null) {
					instance = new MasterDataSettings () {
						masterDataUrl = "https://script.google.com/macros/s/AKfycbxipjqeExO5JuD8uBX5M_rfvnZHEFSrFJb0CIka-fFx4joAIrI7/exec"
					};
				}
				return instance;
			}
		}

		public string masterDataUrl;
	}
}