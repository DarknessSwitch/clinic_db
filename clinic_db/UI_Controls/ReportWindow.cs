﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinic_db
{
    public partial class ReportWindow : UserControl
    {
        public ReportWindow(string title)
        {
            InitializeComponent();
            TopLabel.Text = title;
            LoadEntries();
        }

        public void LoadEntries()
        {

        }
    }
}