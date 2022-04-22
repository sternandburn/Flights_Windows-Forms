using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SternFlight
{
    public partial class Form1 : Form
    {
        
        string[] vertices = { "Seattle", "San Francisco", "Los Angeles", "Denver", "Kansas City", "Chicago", "Boston",
                "New York", "Atlanta", "Miami", "Dallas", "Houston" };

        // Edge array for graph
        int[,] edges = { { 0, 1, 807 }, { 0, 3, 1331 }, { 0, 5, 2097 }, { 1, 0, 807 }, { 1, 2, 381 }, { 1, 3, 1267 },
                { 2, 1, 381 }, { 2, 3, 1015 }, { 2, 4, 1663 }, { 2, 10, 1435 }, { 3, 0, 1331 }, { 3, 1, 1267 },
                { 3, 2, 1015 }, { 3, 4, 599 }, { 3, 5, 1003 }, { 4, 2, 1663 }, { 4, 3, 599 }, { 4, 5, 533 },
                { 4, 7, 1260 }, { 4, 8, 864 }, { 4, 10, 496 }, { 5, 0, 2097 }, { 5, 3, 1003 }, { 5, 4, 533 },
                { 5, 6, 983 }, { 5, 7, 787 }, { 6, 5, 983 }, { 6, 7, 214 }, { 7, 4, 1260 }, { 7, 5, 787 },
                { 7, 6, 214 }, { 7, 8, 888 }, { 8, 4, 864 }, { 8, 7, 888 }, { 8, 9, 661 }, { 8, 10, 781 },
                { 8, 11, 810 }, { 9, 8, 661 }, { 9, 11, 1187 }, { 10, 2, 1435 }, { 10, 4, 496 }, { 10, 8, 781 },
                { 10, 11, 239 }, { 11, 8, 810 }, { 11, 9, 1187 }, { 11, 10, 239 } };


        public Form1()
        {
            InitializeComponent();
            foreach(string city in vertices)
            {
                cbFrom.Items.Add(city);
                cbTo.Items.Add(city);
            }
        }


        private void cbTo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbFrom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void lbFlights_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNSF_Click(object sender, EventArgs e)
        {
           
            if(cbFrom.SelectedIndex >= 0 && cbTo.SelectedIndex >= 0)
            {
                    for (int i = 0; i < edges.GetLength(0); i++)
                    {

                        if (cbFrom.SelectedIndex == edges[i, 0] && cbTo.SelectedIndex == edges[i,1])
                        {
                            lbFlights.Items.Add("Miles: " + edges[i, 2] + " from " + vertices[edges[i, 0]] + " to " + vertices[edges[i, 1]]);
                            
                        }
                    }
                    
            }
                
            
             else if (cbFrom.SelectedIndex >= 0)
                {
                    for (int i = 0; i < edges.GetLength(0); i++)
                    {

                        if (cbFrom.SelectedIndex == edges[i, 0])
                        {
                            lbFlights.Items.Add("Total Miles: " + edges[i, 2] + " from " + vertices[edges[i, 0]] + " to " + vertices[edges[i, 1]]);
                        }
                    }
                }
            
            else
            {
                MessageBox.Show("Please make a selection");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbFlights.Items.Clear();
        }
    }
}
