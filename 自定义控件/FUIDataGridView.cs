using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Using CSDN
namespace 学生选课系统
{  
    class FUIDataGridView : DataGridView
    {
        public FUIDataGridView()
        {
            BackgroundColor = Color.White;
            GridColor = Color.Blue;
            //base.Font = FontColor.Font;
            base.DoubleBuffered = true;
            base.BorderStyle = BorderStyle.None;
            EnableHeadersVisualStyles = false;
            base.ReadOnly = true;
            base.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            base.CellBorderStyle = DataGridViewCellBorderStyle.None;
            base.RowHeadersVisible = false;
            base.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            base.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            base.AllowUserToResizeColumns = false;
            base.AllowUserToResizeRows = false;

            ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            RowHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            RowHeadersDefaultCellStyle.ForeColor =Color.White;
            RowHeadersDefaultCellStyle.SelectionBackColor = Color.Blue;
            RowHeadersDefaultCellStyle.SelectionForeColor = Color.White;
        }
    }
}
