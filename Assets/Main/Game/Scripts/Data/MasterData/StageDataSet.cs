using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Wakame.Data
{
	public class StageData{
		public int[,] stages;

		public class Parser{
			public static StageData Parse(string csvData, int xLength = 30, int yLength = 30){
				StringReader reader = new StringReader(csvData);
				var lines = new List<string[]>();
				while(reader.Peek() > -1) {
					string line = reader.ReadLine();
					Debug.Log(line);
					lines.Add(line.Split(',')); // リストに入れる
				}

				if(lines.Count == 0)
					return null;

				var newStages = new int[yLength, xLength];
				for (int i = 0; i < newStages.GetLength(0); i++)
				{
					Debug.LogFormat("Stage y {0}", i);
					for (int j = 0; j < newStages.GetLength(1); j++)
					{
						try
						{
							newStages[i,j] = int.Parse(lines[i][j]);
							Debug.Log(newStages[i,j]);
						}
						catch (System.FormatException)
						{
							Debug.LogErrorFormat("Cant Parse x{0} y{1}", j, i);
							newStages[i,j] = 0;
						}
						
					}
				}
				return new StageData(){stages = newStages};
			}
		}

		public override string ToString(){
			if(stages == null)
				return "No Stage";

			return string.Format("stages x{0} y{1}", stages.GetLength(0), stages.GetLength(1));
		}
	}

	public class StageDataSet{

		public List<StageData> stageDataList;
	}
}

