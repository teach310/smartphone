using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wakame.Data {
	public class AppSettings {

		static AppSettings instance = null;

		public static AppSettings Instance {
			get {
				if (instance == null) {
					instance = new AppSettings () {
						stageUrl = "https://docs.google.com/spreadsheets/d/1qd7eHcuYrVAY2pQaLJjXSM_C3S4L1DgNI8z0odInP1Y/export?format=csv&gid=0"
					};
				}
				return instance;
			}
		}

		public string stageUrl;
	}
}