using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.Infrastructure
{
    public class MergedRowsHelper
    {
        List<int> _rows = new List<int>();
        GridView _gridView;
        public void Register(GridView gridView)
        {
            if (gridView == null) return;
            _gridView = gridView;
            gridView.FocusedRowChanged += gridView_FocusedRowChanged;
            gridView.RowStyle += gridView_RowStyle;
            gridView.GridControl.Load += GridControl_Load;
        }

        void GridControl_Load(object sender, EventArgs e)
        {
            RefreshMergedRows();
        }

        void gridView_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (_rows.Contains(_gridView.GetDataSourceRowIndex(e.RowHandle)))
            {
                e.Appearance.Assign(_gridView.PaintAppearance.FocusedRow);
                e.HighPriority = true;
            }
        }

        void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            RefreshMergedRows();
        }

        void RefreshMergedRows()
        {
            _rows = GetMergedRows(_gridView.FocusedRowHandle);
            _gridView.RefreshData();
        }

        List<int> GetMergedRows(int rowHandle)
        {
            HashSet<int> mergedRows = new HashSet<int>();
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in _gridView.VisibleColumns)
            {
                var originalCell = _gridView.GetRowCellDisplayText(rowHandle, col);
                for (int i = rowHandle; ; i--)
                {
                    if (!_gridView.IsValidRowHandle(i)) break;
                    var cell = _gridView.GetRowCellDisplayText(i, col);
                    if (cell == originalCell) mergedRows.Add(i);
                    else break;
                }
                for (int i = rowHandle; ; i++)
                {
                    if (!_gridView.IsValidRowHandle(i)) break;
                    var cell = _gridView.GetRowCellDisplayText(i, col);
                    if (cell == originalCell) mergedRows.Add(i);
                    else break;
                }
            }
            List<int> result = new List<int>();
            foreach (var item in mergedRows)
            {
                result.Add(_gridView.GetDataSourceRowIndex(item));
            }
            return result;
        }
    }
}
