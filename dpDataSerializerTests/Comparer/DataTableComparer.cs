﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace dpDataSerializerTests
{
	public static class DataTableComparer
	{
		/// <summary>
		/// https://stackoverflow.com/a/45620698/2390270
		/// Compare a source and target datatables and return the row that are the same, different, added, and removed
		/// </summary>
		/// <param name="dtOld">DataTable to compare</param>
		/// <param name="dtNew">DataTable to compare to dtOld</param>
		/// <param name="dtSame">DataTable that would give you the common rows in both</param>
		/// <param name="dtDifferences">DataTable that would give you the difference</param>
		/// <param name="dtAdded">DataTable that would give you the rows added going from dtOld to dtNew</param>
		/// <param name="dtRemoved">DataTable that would give you the rows removed going from dtOld to dtNew</param>
		public static void GetTableDiff(DataTable dtOld, DataTable dtNew, ref DataTable dtSame, ref DataTable dtDifferences, ref DataTable dtAdded, ref DataTable dtRemoved)
		{
			dtAdded = dtOld.Clone();
			dtAdded.Clear();
			dtRemoved = dtOld.Clone();
			dtRemoved.Clear();
			dtSame = dtOld.Clone();
			dtSame.Clear();
			if (dtNew.Rows.Count > 0) dtDifferences.Merge(dtNew.AsEnumerable().Except(dtOld.AsEnumerable(), DataRowComparer.Default).CopyToDataTable<DataRow>());
			if (dtOld.Rows.Count > 0) dtDifferences.Merge(dtOld.AsEnumerable().Except(dtNew.AsEnumerable(), DataRowComparer.Default).CopyToDataTable<DataRow>());
			if (dtOld.Rows.Count > 0 && dtNew.Rows.Count > 0) dtSame = dtOld.AsEnumerable().Intersect(dtNew.AsEnumerable(), DataRowComparer.Default).CopyToDataTable<DataRow>();
			foreach (DataRow row in dtDifferences.Rows)
			{
				if (dtOld.AsEnumerable().Any(r => Enumerable.SequenceEqual(r.ItemArray, row.ItemArray))
					&& !dtNew.AsEnumerable().Any(r => Enumerable.SequenceEqual(r.ItemArray, row.ItemArray)))
				{
					dtRemoved.Rows.Add(row.ItemArray);
				}
				else if (dtNew.AsEnumerable().Any(r => Enumerable.SequenceEqual(r.ItemArray, row.ItemArray))
					&& !dtOld.AsEnumerable().Any(r => Enumerable.SequenceEqual(r.ItemArray, row.ItemArray)))
				{
					dtAdded.Rows.Add(row.ItemArray);
				}
			}

		}
	}
}
