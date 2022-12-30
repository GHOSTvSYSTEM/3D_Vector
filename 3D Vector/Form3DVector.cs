using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3D_Vector
{
    public partial class Form3DVector : Form
    {
        
        
        public Form3DVector()
        {
            InitializeComponent();
        }

        private void BtnAdd_CheckedChanged(object sender, EventArgs e)
        {
            // Parse the input values
            double x1 = double.Parse(VecU1.Text);
            double y1 = double.Parse(VecU2.Text);
            double z1 = double.Parse(VecU3.Text);
            double x2 = double.Parse(VecV1.Text);
            double y2 = double.Parse(VecV2.Text);
            double z2 = double.Parse(VecV3.Text);

            // Create vector instances
            _3DVector v1 = new _3DVector(x1, y1, z1);
            _3DVector v2 = new _3DVector(x2, y2, z2);

            // Perform the vector addition
            _3DVector v3 = v1.Add(v2);

            // Display the result
            lblResult.Text = v3.ToString();
        }

        private void BtnSub_CheckedChanged(object sender, EventArgs e)
        {

            double x1 = double.Parse(VecU1.Text);
            double y1 = double.Parse(VecU2.Text);
            double z1 = double.Parse(VecU3.Text);
            double x2 = double.Parse(VecV1.Text);
            double y2 = double.Parse(VecV2.Text);
            double z2 = double.Parse(VecV3.Text);

            // Create vector instances
            _3DVector v1 = new _3DVector(x1, y1, z1);
            _3DVector v2 = new _3DVector(x2, y2, z2);

            // Perform the vector addition
            _3DVector v3 = v1.Sub(v2);

            // Display the result
            lblResult.Text = v3.ToString();

        }

        private void BtnDot_CheckedChanged(object sender, EventArgs e)
        {
            double x1 = double.Parse(VecU1.Text);
            double y1 = double.Parse(VecU2.Text);
            double z1 = double.Parse(VecU3.Text);
            double x2 = double.Parse(VecV1.Text);
            double y2 = double.Parse(VecV2.Text);
            double z2 = double.Parse(VecV3.Text);

            // Create vector instances
            _3DVector v1 = new _3DVector(x1, y1, z1);
            _3DVector v2 = new _3DVector(x2, y2, z2);

            // Perform the vector addition
            double v3 = v1.DotProduct(v2);

            // Display the result
            lblResult.Text = v3.ToString();
        }

        private void BtnCross_CheckedChanged(object sender, EventArgs e)
        {
            double x1 = double.Parse(VecU1.Text);
            double y1 = double.Parse(VecU2.Text);
            double z1 = double.Parse(VecU3.Text);
            double x2 = double.Parse(VecV1.Text);
            double y2 = double.Parse(VecV2.Text);
            double z2 = double.Parse(VecV3.Text);

            // Create vector instances
            _3DVector v1 = new _3DVector(x1, y1, z1);
            _3DVector v2 = new _3DVector(x2, y2, z2);

            // Perform the vector addition
            _3DVector v3 = v1.CrossProduct(v2);

            // Display the result
            lblResult.Text = v3.ToString();

        }
    }
}
