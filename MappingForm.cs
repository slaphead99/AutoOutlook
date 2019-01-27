//
// MappingForm.cs
//
// This file was generated by MapForce 2017r3.
//
// YOU SHOULD NOT MODIFY THIS FILE, BECAUSE IT WILL BE
// OVERWRITTEN WHEN YOU RE-RUN CODE GENERATION.
//
// Refer to the MapForce Documentation for further details.
// http://www.altova.com/mapforce
//

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Mapping
{
	/// <summary>
	/// Summary description for MappingForm.
	/// </summary>
	public class MappingForm : System.Windows.Forms.Form, Altova.TraceTarget
	{
		// general
		private System.Windows.Forms.PictureBox pictureBoxLogo;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.LinkLabel linkLabelAltova;
		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.Panel panelStructures;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.ListBox listBoxOutput;
		// generated by Mapforce
		private System.Windows.Forms.Label labelSource0;
		private System.Windows.Forms.TextBox textBoxSource0;
		private System.Windows.Forms.Label labelTarget0;
		private System.Windows.Forms.TextBox textBoxTarget0;
		private System.Windows.Forms.Button buttonTarget0;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MappingForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			textBoxSource0.Text = "alltasks001.CSV"			textBoxTarget0.Text = "D:/Downloads/eSignatures for Dummies.xml";

		}

		[STAThread]
		public static void Main(string[] args) 
		{
			MappingForm form = new MappingForm();
			form.ShowDialog();
		}

		public void WriteTrace(string info)
		{
			listBoxOutput.Items.Add( info );
			listBoxOutput.Refresh();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MappingForm));
			this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.labelTitle = new System.Windows.Forms.Label();
			this.linkLabelAltova = new System.Windows.Forms.LinkLabel();
			this.labelDescription = new System.Windows.Forms.Label();
			this.panelStructures = new System.Windows.Forms.Panel();
			this.buttonStart = new System.Windows.Forms.Button();
			this.listBoxOutput = new System.Windows.Forms.ListBox();
			// Mapforce generated
			this.labelSource0 = new System.Windows.Forms.Label();
			this.textBoxSource0 = new System.Windows.Forms.TextBox();
			this.buttonSource0 = new System.Windows.Forms.Button();
			this.labelTarget0 = new System.Windows.Forms.Label();
			this.textBoxTarget0 = new System.Windows.Forms.TextBox();
			this.buttonTarget0 = new System.Windows.Forms.Button();

			this.panelStructures.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBoxLogo
			// 
			this.pictureBoxLogo.BackColor = System.Drawing.Color.White;
			this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
			this.pictureBoxLogo.Location = new System.Drawing.Point(16, 16);
			this.pictureBoxLogo.Name = "pictureBoxLogo";
			this.pictureBoxLogo.Size = new System.Drawing.Size(80, 80);
			this.pictureBoxLogo.TabIndex = 0;
			this.pictureBoxLogo.TabStop = false;
			// 
			// pictureBox
			// 
			this.pictureBox.BackColor = System.Drawing.Color.White;
			this.pictureBox.Location = new System.Drawing.Point(8, 8);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(96, 392);
			this.pictureBox.TabIndex = 1;
			this.pictureBox.TabStop = false;
			// 
			// labelTitle
			// 
			this.labelTitle.Location = new System.Drawing.Point(112, 8);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(360, 16);
			this.labelTitle.TabIndex = 2;
			this.labelTitle.Text = "THIS APPLICATION WAS GENERATED BY MapForce 2017r3";
			// 
			// linkLabelAltova
			// 
			this.linkLabelAltova.Location = new System.Drawing.Point(112, 32);
			this.linkLabelAltova.Name = "linkLabelAltova";
			this.linkLabelAltova.Size = new System.Drawing.Size(360, 23);
			this.linkLabelAltova.TabIndex = 3;
			this.linkLabelAltova.TabStop = true;
			this.linkLabelAltova.Text = "http://www.altova.com/mapforce";
			// 
			// labelDescription
			// 
			this.labelDescription.Location = new System.Drawing.Point(112, 72);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(360, 23);
			this.labelDescription.TabIndex = 4;
			this.labelDescription.Text = "Please check the input and output files and press the start button...";
			// 
			// panelStructures
			// 
			this.panelStructures.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelStructures.Controls.Add(this.labelSource0);
			this.panelStructures.Controls.Add(this.textBoxSource0);
			this.panelStructures.Controls.Add(this.buttonSource0);
			this.panelStructures.Controls.Add(this.labelTarget0);
			this.panelStructures.Controls.Add(this.textBoxTarget0);
			this.panelStructures.Controls.Add(this.buttonTarget0);
			this.panelStructures.Location = new System.Drawing.Point(24, 104);
			this.panelStructures.Name = "panelStructures";
			this.panelStructures.Size = new System.Drawing.Size(448, 168);
			this.panelStructures.TabIndex = 5;
			// 
			// buttonStart
			// 
			this.buttonStart.Location = new System.Drawing.Point(24, 280);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.TabIndex = 6;
			this.buttonStart.Text = "Start";
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// listBoxOutput
			// 
			this.listBoxOutput.Location = new System.Drawing.Point(24, 312);
			this.listBoxOutput.Name = "listBoxOutput";
			this.listBoxOutput.Size = new System.Drawing.Size(448, 82);
			this.listBoxOutput.TabIndex = 7;

			// Mapforce generated
			// 
			// labelSource0
			// 
			this.labelSource0.Name = "labelSource0";
			this.labelSource0.Location = new System.Drawing.Point(8, 8);
			this.labelSource0.Size = new System.Drawing.Size(432, 16);
			this.labelSource0.TabIndex = 0;
			this.labelSource0.Text = "Source of alltasks001:";
			// 
			// textBoxSource0
			// 
			this.textBoxSource0.Name = "textBoxSource0";
			this.textBoxSource0.Location = new System.Drawing.Point(8, 24);
			this.textBoxSource0.Size = new System.Drawing.Size(376, 20);
			this.textBoxSource0.TabIndex = 1;
			this.textBoxSource0.Text = "";
			// 
			// labelTarget0
			// 
			this.labelTarget0.Name = "labelTarget0";
			this.labelTarget0.Location = new System.Drawing.Point(8, 56);
			this.labelTarget0.Size = new System.Drawing.Size(432, 16);
			this.labelTarget0.TabIndex = 2;
			this.labelTarget0.Text = "Target instance of _testtarget_a_an.xsd:";
			this.labelTarget0.Text = "Target instance of eSignatures for Dummies:";
			// 
			// textBoxTarget0
			// 
			this.textBoxTarget0.Name = "textBoxTarget0";
			this.textBoxTarget0.Location = new System.Drawing.Point(8, 72);
			this.textBoxTarget0.Size = new System.Drawing.Size(376, 20);
			this.textBoxTarget0.TabIndex = 3;
			this.textBoxTarget0.Text = "";
			// 
			// buttonTarget0
			// 
			this.buttonTarget0.Name = "buttonTarget0";
			this.buttonTarget0.Location = new System.Drawing.Point(392, 72);
			this.buttonTarget0.Size = new System.Drawing.Size(48, 23);
			this.buttonTarget0.TabIndex = 4;
			this.buttonTarget0.Text = "Open...";
			this.buttonTarget0.Click += new System.EventHandler(this.buttonTarget0_Click);
			// 
			// MappingForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(496, 406);
			this.Controls.Add(this.listBoxOutput);
			this.Controls.Add(this.buttonStart);
			this.Controls.Add(this.panelStructures);
			this.Controls.Add(this.labelDescription);
			this.Controls.Add(this.linkLabelAltova);
			this.Controls.Add(this.labelTitle);
			this.Controls.Add(this.pictureBoxLogo);
			this.Controls.Add(this.pictureBox);
			this.Name = "Mapping";
			this.Text = "Mapping";
			this.panelStructures.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void buttonSource0_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog	ofd = new OpenFileDialog();
			ofd.Filter = "XML-Files (*.xml)|*.xml|All files (*.*)|*.*";
			ofd.FilterIndex = 1;
			ofd.RestoreDirectory = true;
			ofd.AddExtension = true;

			if( ofd.ShowDialog() != DialogResult.OK )
				return ;

			textBoxSource0.Text = ofd.FileName;
		}

		private void buttonTarget0_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog	ofd = new OpenFileDialog();
			ofd.AddExtension = true;
			ofd.Filter = "XML-Files (*.xml)|*.xml|All files (*.*)|*.*"";
			ofd.FilterIndex = 1;
			ofd.RestoreDirectory = true;

			if( ofd.ShowDialog() != DialogResult.OK )
				return ;

			textBoxTarget0.Text = ofd.FileName;
		}


		private void buttonStart_Click(object sender, System.EventArgs e)
		{
			WriteTrace("Mapping started...");

			try
			{
				MappingMapToeSignatures_for_Dummies MappingMapToeSignatures_for_DummiesObject = new MappingMapToeSignatures_for_Dummies();
				MappingMapToeSignatures_for_DummiesObject.RegisterTraceTarget( this );
				MappingMapToeSignatures_for_DummiesObject.Run(
					textBoxSource0.Text,
					textBoxTarget0.Text
					);
			}
			catch ( Exception err )
			{
				WriteTrace( "ERROR: " );
				WriteTrace( err.Message );
				WriteTrace( err.StackTrace );
			}

			WriteTrace("Mapping finished.");
		}
	}
}
