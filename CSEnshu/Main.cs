﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSEnshu
{
    public partial class Main : Form
    {
      
        public static Main MainInstance { get; set;}
        public Main()
        {
            InitializeComponent();
            Main.MainInstance = this;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            

        }

        private void orderButton_Click(object sender, EventArgs e)
        {

        }

        private void addStockButton_Click(object sender, EventArgs e)
        {

        }

        private void searchResult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void itemSearchBox_TextChanged(object sender, EventArgs e)
        {

        }
        
        private List<ItemsDto> searchItems(string searhItemName)
        {

        }
    }
}
