using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_team
{
	internal class Sort
	{
		public static double[,] SortMas(double[,] vs)
		{
			for (int g = 0; g < vs.GetLength(1); g++)
			{
				for (int i = 0; i < vs.GetLength(0); i += 2)
				{
					for (int j = 0; j < vs.GetLength(1) - 1; j++)
					{
						if (Math.Abs(vs[i, j]) > Math.Abs(vs[i, j + 1]))
						{
							double smena = vs[i, j];
							vs[i, j] = vs[i, j + 1];
							vs[i, j + 1] = smena;
						}
					}
				}
			}
			return vs;
		}
	}
}
