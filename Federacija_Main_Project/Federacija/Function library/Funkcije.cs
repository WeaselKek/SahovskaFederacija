using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Federacija.BindList;

namespace Federacija.Functions
{
    public class Sortiranje
    {
        
        public static void SortDGV(int index, DataGridView d)
        {
            if (!d.Columns[index].IsDataBound)
                return;

            d.Columns[index].SortMode = DataGridViewColumnSortMode.Programmatic;


            DataGridViewColumn newColumn = d.Columns[index];
            DataGridViewColumn oldColumn = d.SortedColumn;
            ListSortDirection direction;

            if (oldColumn != null)
            {
                // Sort the same column again, reversing the SortOrder.
                if (oldColumn == newColumn &&
                    d.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    // Sort a new column and remove the old SortGlyph.
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }

            d.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;
        }       
    }

    public class Provera
    {
        public static bool chkIfSelected(DataGridView d)
        {
            if (d.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molimo selektujte neki podatak");
                return false;
            }
            if (d.SelectedRows.Count > 1)
            {
                MessageBox.Show("Molimo selektujte samo jedan red");
                return false;
            }
            return true;

        }
        public static void Zatvaranje(FormClosingEventArgs a)
        {
            DialogResult r = MessageBox.Show("Da li ste sigurni", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                a.Cancel = true;
            }
        }
    }

}