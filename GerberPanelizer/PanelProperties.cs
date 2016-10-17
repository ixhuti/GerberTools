﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerberCombinerBuilder
{
    public partial class PanelProperties : Form
    {
        private GerberLibrary.GerberPanel ParentPanel;


        public PanelProperties(GerberLibrary.GerberPanel ThePanel)
        {
            InitializeComponent();
            ParentPanel = ThePanel;

            WidthBox.Value = (decimal)ParentPanel.TheSet.Width;
            HeightBox.Value = (decimal)ParentPanel.TheSet.Height;
            MarginBox.Value = (decimal)ParentPanel.TheSet.MarginBetweenBoards;

            filloffsetbox.Value = (decimal)ParentPanel.TheSet.FillOffset;
            smoothoffsetbox.Value= (decimal)ParentPanel.TheSet.Smoothing;
            ExtraTabDrillDistance.Value = (decimal)ParentPanel.TheSet.ExtraTabDrillDistance;
            FillEmpty.Checked = ParentPanel.TheSet.ConstructNegativePolygon;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ParentPanel.TheSet.Width = (double)WidthBox.Value;
            ParentPanel.TheSet.Height = (double)HeightBox.Value;
            ParentPanel.TheSet.MarginBetweenBoards = (double)MarginBox.Value;
            ParentPanel.TheSet.ConstructNegativePolygon = FillEmpty.Checked;
            ParentPanel.TheSet.ExtraTabDrillDistance = (double) ExtraTabDrillDistance.Value;
            ParentPanel.TheSet.FillOffset = (double)filloffsetbox.Value;
            ParentPanel.TheSet.Smoothing = (double)smoothoffsetbox.Value;


            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // cancel
            Close();
        }

    }
}