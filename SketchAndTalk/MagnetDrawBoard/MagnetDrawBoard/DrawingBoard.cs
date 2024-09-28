using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShareLib;

namespace MagnetDrawBoard
{
    public partial class DrawingBoard : Form
    {
        private Region holeRegion;
        private bool formDragging;
        private Point pointClicked;
        private int scrollX = 0;
        private Point mouseDown, mouseMove;
        int mouseX;
        List<Point> drawlines = new List<Point>();
        ArrayList arrlstApts = new ArrayList();
        ArrayList arrlstPts;

        private bool isDrawing = false;
        private Point lastPoint = Point.Empty;
        Client client;

         
        public DrawingBoard(Client client)
        {
            this.client = client;
            InitializeComponent();
            mynumber_nuberlabel.Text = this.client.Id;
           // this.client.MessageReceived += OnMessageReceived;
            this.client.DataReceived += OnDataReceived;
            this.client.StartReceivingMessages();
           
        }

    

        private void SetRoundedCornersWithHole()
        {
            // Define the radius for the rounded corners
            int cornerRadius = 20;
            int holeWidth = 250; // Width of the hole
            int holeHeight = 30; // Height of the hole
            int holeX = (this.Width - holeWidth) / 2; // Center the hole horizontally
            int holeY = 10; // Small offset from the top of the form

            GraphicsPath path = new GraphicsPath();
            // Add a rounded rectangle to the path
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(this.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(this.Width - cornerRadius, this.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, this.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseFigure();

            // Define the hole's region
            holeRegion = new Region(new Rectangle(holeX, holeY, holeWidth, holeHeight));

            // Exclude the hole from the rounded rectangle
            Region formRegion = new Region(path);
            formRegion.Exclude(new Rectangle(holeX, holeY, holeWidth, holeHeight));

            // Apply the region to the form
            this.Region = formRegion;
        }

        private void DrawingBoard_Load(object sender, EventArgs e)
        {
            SetRoundedCornersWithHole();
        }
 
        private void move_label_MouseDown(object sender, MouseEventArgs e)
        {
            // Set drag mode on.
            formDragging = true;

            // Store the offset where the control was clicked.
            pointClicked = new Point(e.X, e.Y);
        }

        private void move_label_MouseMove(object sender, MouseEventArgs e)
        {
            if (formDragging)
            {
                Point pointMoveTo;

                // Find the current mouse position in screen coordinates.
                pointMoveTo = this.PointToScreen(new Point(e.X, e.Y));

                // Compensate for the position the control was clicked.
                pointMoveTo.Offset(-pointClicked.X, -pointClicked.Y);

                // Compensate for the non-client region (title bar).
                // This code is not necessary if you explicitly hide the title bar
                //  by setting the form's BorderStyle to None.
                pointMoveTo.Offset(0, -25);

                // Move the form.
                this.Location = pointMoveTo;
            }
        }

        private void move_label_MouseUp(object sender, MouseEventArgs e)
        {
            formDragging = false;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            scrollX = hScrollBar1.Value;
            Point mousePos = Cursor.Position;

            // Convert to client coordinates (relative to the form or control)
            Point clientPos = this.PointToClient(mousePos);

            // Now you have the X position of the mouse relative to the form/control
            mouseX = clientPos.X;
            
             drawlines.Add(new Point(mouseX, pictureBox1.Height));

            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
         
            Graphics grfx = e.Graphics;
            Pen pen = new Pen(ForeColor);
            for (int i = 0; i < arrlstApts.Count; i++)
                grfx.DrawLines(pen, (Point[])arrlstApts[i]);
             
            if (drawlines.Count() > 1)
            {
                // Use Graphics to draw a black line from (scrollX, 0) to (scrollX, scrollY)
                using (Pen whitepen = new Pen(Color.White, pictureBox1.Height + pictureBox1.Height))
                {
                    e.Graphics.DrawLines(whitepen, drawlines.ToArray());
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                arrlstPts = new ArrayList();
                arrlstPts.Add(new Point(e.X, e.Y));
                isDrawing = true;

            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrawing)
                return;
            arrlstPts.Add(new Point(e.X, e.Y));
            Graphics grfx = pictureBox1.CreateGraphics();
            grfx.DrawLine(new Pen(ForeColor),
                                (Point)arrlstPts[arrlstPts.Count - 2],
                                (Point)arrlstPts[arrlstPts.Count - 1]);

            grfx.Dispose();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!isDrawing)
                    return;
                Point[] apt = (Point[])arrlstPts.ToArray(typeof(Point));
                arrlstApts.Add(apt);
                isDrawing = false;
                drawlines.Clear();
                drawlines = new List<Point>();         
            }
        }

        private void buttonrefresh_Click(object sender, EventArgs e)
        {
            arrlstApts.Clear();
            pictureBox1.Invalidate();
        }

        private void receivernumber_nuberlabel_Click(object sender, EventArgs e)
        {
            ReceiverDialPad mbpad = new ReceiverDialPad(client);
            if (mbpad.ShowDialog() == DialogResult.OK)
            {
                receivernumber_nuberlabel.Text = mbpad.numberBox.Text;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonsend_Click(object sender, EventArgs e)
        {
            //string message = receivernumber_nuberlabel.Text.ToString() + ":" + "Hi";
            //this.client.SendingMessage(message);
           
            if (IsNumber(receivernumber_nuberlabel.Text)){
                RemotePoint remoteobj = new RemotePoint();
                remoteobj.drawlines = new List<Point>();
                remoteobj.drawlines = this.drawlines;
                remoteobj.arrlstApts = new ArrayList();
                remoteobj.arrlstApts = this.arrlstApts;
                this.client.SendingData(remoteobj, Convert.ToInt16(receivernumber_nuberlabel.Text.ToString()));
            }
              
            else
                receivernumber_nuberlabel.Text = "? ? ?";
        }
        private bool IsNumber(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                    return false;  // If any character is not a digit, return false
            }
            return true;  // All characters are digits, return true
        }
        private void OnMessageReceived(string obj)
        {
          //  textBox1.AppendText(obj + Environment.NewLine);  // Add received message to the TextBox
        }
        private void OnDataReceived(RemotePoint obj)
        {

            arrlstApts = new ArrayList(obj.arrlstApts); // Creates a new ArrayList based on the contents

         
            drawlines = new List<Point>(obj.drawlines); // Creates a new List based on the contents

            // Trigger a redraw of the picture box
            pictureBox1.Invalidate();
        }
        

      
    }
}
